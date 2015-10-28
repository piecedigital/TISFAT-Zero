﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TISFAT.Entities;
using TISFAT.Util;

namespace TISFAT
{
	public enum EditMode
	{
		Default, Onion, Phase
	}

	public partial class MainForm : Form
	{
		#region Properties
		IAction ItemSavedOn;
		IAction LastAction;

		public Project ActiveProject;
		private string ProjectFileName;
		private bool ProjectDirty;

		private Stack<IAction> UndoList;
		private Stack<IAction> RedoList;

		public TimelineForm Form_Timeline;
		public CanvasForm Form_Canvas;
		public PropertiesForm Form_Toolbox;

		private EditMode _ActiveEditMode;
		public EditMode ActiveEditMode
		{
			get { return _ActiveEditMode; }
			set
			{
				btn_EditModeDefault.Checked = value == EditMode.Default;
				btn_EditModeOnion.Checked = value == EditMode.Onion;
				btn_EditModePhase.Checked = value == EditMode.Phase;

				_ActiveEditMode = value;
				Form_Timeline.MainTimeline.GLContext.Invalidate();
			}
		}

		public bool PreviewCamera
		{
			get { return ckb_PreviewCamera.Checked; } 
			set { ckb_PreviewCamera.Checked = value; }
		}

		public Timeline MainTimeline
		{
			get { return Form_Timeline == null ? null : Form_Timeline.MainTimeline; }
		}

		private static Random Why = new Random();
		#endregion

		public MainForm()
		{
			DoubleBuffered = true;

			this.ResizeBegin += (s, e) => { this.SuspendLayout(); };
			this.ResizeEnd += (s, e) => { this.ResumeLayout(true); };

			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			ProjectNew();

			// Create and show forms
			Form_Timeline = new TimelineForm(sc_MainContainer.Panel2);
			Form_Toolbox = new PropertiesForm(sc_MainContainer.Panel2);
			Form_Canvas = new CanvasForm(sc_MainContainer.Panel2);

			Form_Timeline.Show();
			Form_Toolbox.Show();
			Form_Canvas.Show();

			Form_Timeline.Location = new Point(5, 0);
			Form_Toolbox.Location = new Point(50, Form_Timeline.Location.Y + Form_Timeline.Height + 4);
			Form_Canvas.Location = new Point(Form_Toolbox.Location.X + Form_Toolbox.Width + 20, Form_Timeline.Location.Y + Form_Timeline.Height + 4);

			if (Program.LoadFile != "")
				ProjectOpen(Program.LoadFile);
		}

		public void SetDirty(bool dirty)
		{
			ProjectDirty = dirty;
			Text = "TISFAT Zero - " + (Path.GetFileNameWithoutExtension(ProjectFileName) ?? "Untitled") + (dirty ? " *" : "");
		}

		private void SetFileName(string filename)
		{
			ProjectFileName = filename;
			SetDirty(filename == null);
		}

		public void Do(IAction action)
		{
			if (!action.Do())
				return;

			SetDirty(true);

			LastAction = action;

			UndoList.Push(action);
			RedoList.Clear();

			UpdateUndoRedoButtons();

			if (UndoList.Count % 10 == 0)
				AutoSave();
		}

		private void UpdateUndoRedoButtons()
		{
			if (UndoList.Count > 0)
			{
				btn_Undo.ImageDefault = Properties.Resources.undo;
				undoToolStripMenuItem.Image = Properties.Resources.undo_16;
			}
			else
			{
				btn_Undo.ImageDefault = Properties.Resources.undo_gray;
				undoToolStripMenuItem.Image = Properties.Resources.undo_gray_16;
			}

			if (RedoList.Count > 0)
			{
				btn_Redo.ImageDefault = Properties.Resources.redo;
				redoToolStripMenuItem.Image = Properties.Resources.redo_16;
			}
			else
			{
				btn_Redo.ImageDefault = Properties.Resources.redo_gray;
				redoToolStripMenuItem.Image = Properties.Resources.redo_gray_16;
			}
		}

		private void Undo()
		{
			if (UndoList.Count < 1)
				return;

			IAction item = UndoList.Pop();

			SetDirty(UndoList.Count == 0 ? ItemSavedOn != null : item != ItemSavedOn);

			LastAction = item;

			RedoList.Push(item);
			item.Undo();

			UpdateUndoRedoButtons();
		}

		private void Redo()
		{
			if (RedoList.Count < 1)
				return;

			IAction item = RedoList.Pop();

			SetDirty(RedoList.Count == 0 ? item != ItemSavedOn : ItemSavedOn != null);

			LastAction = item;

			UndoList.Push(item);
			item.Do();

			UpdateUndoRedoButtons();
		}

		#region File Saving / Loading
		public void ProjectNew()
		{
			ActiveProject = new Project();

			UndoList = new Stack<IAction>();
			RedoList = new Stack<IAction>();

			ItemSavedOn = null;

			UpdateUndoRedoButtons();

			SetFileName(null);

			StickFigure defaultFig = new StickFigure();
			ActiveProject.Layers.Add(defaultFig.CreateDefaultLayer(0, 20, new LayerCreationArgs(0, "")));

			if (Form_Canvas != null)
			{
				Program.Form_Canvas.GLContext_Init();
				Program.Form_Canvas.CanvasForm_Resize(null, null);

				Program.Form_Canvas.Size = new Size(ActiveProject.Width, ActiveProject.Height);
			}

			if (MainTimeline != null)
			{
				MainTimeline.ClearSelection();
				MainTimeline.GLContext.Invalidate();
			}

			SetDirty(false);
		}

		public void ProjectOpen(string filename)
		{
			if (MainTimeline == null)
				return;

			ActiveProject = new Project();

			UndoList = new Stack<IAction>();
			RedoList = new Stack<IAction>();

			ItemSavedOn = null;

			UpdateUndoRedoButtons();

			using (var reader = new BinaryReader(new FileStream(filename, FileMode.Open)))
			{
				UInt16 version = reader.ReadUInt16();
				ActiveProject.Read(reader, version);
			}

			SetFileName(filename);

			MainTimeline.ClearSelection();
			MainTimeline.SeekStart();

			if (Form_Canvas != null)
			{
				Program.Form_Canvas.GLContext_Init();
				Program.Form_Canvas.CanvasForm_Resize(null, null);

				Program.Form_Canvas.ClientSize = new Size(ActiveProject.Width, ActiveProject.Height);
			}

			if (MainTimeline != null)
				MainTimeline.GLContext.Invalidate();
		}

		public void ProjectSave(string filename, bool isAutoSave=false)
		{
			if (MainTimeline == null)
				return;

			ItemSavedOn = LastAction;

			using (var writer = new BinaryWriter(new FileStream(filename, FileMode.Create)))
			{
				writer.Write(FileFormat.Version);
				ActiveProject.Write(writer);
			}

			if (!isAutoSave)
			{
				SetFileName(filename);
				ProjectFileName = filename;
			}
		}

		public DialogResult ProjectSaveAs()
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.AddExtension = true;
			dialog.Filter = "TISFAT Zero Project|*.tzp";

			DialogResult result = dialog.ShowDialog();

			if (result == DialogResult.OK)
				ProjectSave(dialog.FileName);

			return result;
		}

		public void ProjectExport()
		{
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "Animated GIF|*.gif|Animated PNG|*.png|MPEG-4|*.mp4|AVI|*.avi|WebM|*.webm|Flash Video|*.flv|Windows Media Video|*.wmv";

			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			float fps = ActiveProject.FPS;
			float delta = 1.0f / fps;

			float endTime = 0.0f;

			string temp = Path.GetTempPath() + Path.GetRandomFileName();
			Directory.CreateDirectory(temp);

			foreach (Layer layer in ActiveProject.Layers)
			{
				endTime = Math.Max(endTime, layer.Framesets[layer.Framesets.Count - 1].EndTime);
			}

			int n = 0;
			int nt = (int)Math.Ceiling(endTime / ActiveProject.AnimSpeed / delta);

			ProgressDialog progress = new ProgressDialog();

			progress.StartPosition = FormStartPosition.CenterParent;

			bool frameCanceled = false;
			EventHandler frameCancelHandler = (_1, _2) => { frameCanceled = true; };

			progress.Title = "Rendering Frames..";
			progress.ProgressStyle = ProgressBarStyle.Continuous;
			progress.Canceled += frameCancelHandler;
			progress.Work = () =>
			{
				for (float time = 0; time <= endTime / ActiveProject.AnimSpeed && !frameCanceled; time += delta)
				{
					progress.DetailText = "Frame " + (n + 1) + " of " + (nt + 1);
					progress.ProgressValue = n * 100 / nt;

					Form_Canvas.DrawFrame(time * ActiveProject.AnimSpeed, true, true);
					Image.FromHbitmap(Form_Canvas.TakeScreenshot()).Save(temp + "\\" + n + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
					Application.DoEvents();
					n++;
				}

				if (frameCanceled)
				{
					Directory.Delete(temp, true);
					progress.Close();
					return;
				}

				progress.Canceled -= frameCancelHandler;
				progress.Canceled += progress.Finish;

				progress.Title = "Encoding Video..";
				progress.ProgressStyle = ProgressBarStyle.Marquee;
				progress.DetailText = "Waiting for ffmpeg..";

				ProcessStartInfo startInfo = new ProcessStartInfo();
				startInfo.FileName = "ffmpeg.exe";
				startInfo.Arguments = "-y -r " + fps + " -i \"" + temp + "\\%d.bmp\" \"" + dlg.FileName + "\"";
				startInfo.UseShellExecute = false;
				startInfo.CreateNoWindow = true;

				Process processTemp = new Process();
				processTemp.StartInfo = startInfo;
				processTemp.EnableRaisingEvents = true;

				processTemp.Exited += (sender2, e2) =>
				{
					progress.Finish(sender2, e2);
					Directory.Delete(temp, true);
				};

				processTemp.Start();
			};

			progress.ShowDialog();
		}

		public void AutoSave()
		{
			string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string fileName = Path.Combine(appData, "TISFAT Zero\\autosave.tzp");

			if (!Directory.Exists(Path.GetDirectoryName(fileName)))
				Directory.CreateDirectory(Path.GetDirectoryName(fileName));

			ProjectSave(fileName, true);
		}
		#endregion

		public void CheckKeyPressed(KeyEventArgs e)
		{
			// This doesnt do anything right now
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (ProjectDirty)
			{
				SaveChangesDialog dlg = new SaveChangesDialog();

				dlg.StartPosition = FormStartPosition.CenterParent;

				switch (dlg.ShowDialog())
				{
					case DialogResult.Yes:
						if (ProjectFileName != null)
							ProjectSave(ProjectFileName);
						else
							e.Cancel = ProjectSaveAs() != DialogResult.OK;
						break;
					case DialogResult.No: // TODO: Add a preference for overwriting the autosave file if you decline.
						// AutoSave();
						break;
					case DialogResult.Cancel:
						e.Cancel = true;
						break;

					default:
						throw new ArgumentException("Unknown Dialog Result");
				}
			}
		}

		#region Events
		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProjectNew();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.AddExtension = true;
			dialog.Filter = "TISFAT Zero Project|*.tzp";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ProjectOpen(dialog.FileName);
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ProjectFileName != null)
				ProjectSave(ProjectFileName);
			else
				ProjectSaveAs();
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProjectSaveAs();
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProjectExport();
		}

		private void btn_EditModeDefault_Click(object sender, EventArgs e)
		{
			ActiveEditMode = EditMode.Default;
		}

		private void btn_EditModeOnion_Click(object sender, EventArgs e)
		{
			ActiveEditMode = EditMode.Onion;
		}

		private void btn_EditModePhase_Click(object sender, EventArgs e)
		{
			ActiveEditMode = EditMode.Phase;
		}

		private void btn_RemoveLayer_Click(object sender, EventArgs e)
		{
			Form_Timeline.MainTimeline.RemoveLayer();
		}

		private void btn_AddLayer_Click(object sender, EventArgs e)
		{
			AddLayerDialog dlg = new AddLayerDialog();

			dlg.StartPosition = FormStartPosition.CenterParent;

			dlg.ShowDialog();
		}

		private void btn_Undo_Click(object sender, EventArgs e)
		{
			Undo();
		}

		private void btn_Redo_Click(object sender, EventArgs e)
		{
			Redo();
		}

		private void projectPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProjectPropertiesDialog dlg = new ProjectPropertiesDialog();

			dlg.StartPosition = FormStartPosition.CenterParent;

			dlg.ShowDialog();
		}

		private void openColorPickerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorPickerDialog dlg = new ColorPickerDialog();

			dlg.ShowDialog();
		}

		private void skipToStartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MainTimeline.SeekFirstFrame();
		}

		private void seekToEndToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MainTimeline.SeekLastFrame();
		}

		private void nextFrameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MainTimeline.SeekNextFrame();
		}

		private void previousFrameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MainTimeline.SeekPrevFrame();
		}

		private void insertKeyframeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MainTimeline.InsertKeyframe();
		}

		private void removeKeyframeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MainTimeline.RemoveKeyframe();
		}

		private void nextKeyframeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MainTimeline.NextKeyframe();
		}

		private void previousKeyframeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MainTimeline.PrevKeyframe();
		}

		private void renameLayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_Timeline.renameToolStripMenuItem_Click(sender, e);
		}

		private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_Timeline.moveLayerUpToolStripMenuItem_Click(sender, e);
		}

		private void moveLayerDownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_Timeline.moveLayerDownToolStripMenuItem_Click(sender, e);
		}

		private void playAnimationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MainTimeline.TogglePause();
		}

		private void ckb_PreviewCamera_CheckedChanged(object sender, EventArgs e)
		{
			MainTimeline.GLContext.Invalidate();
		}

		private void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.AddExtension = true;
			dialog.Filter = "TISFAT Project|*.sif";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				TISFAT.Util.Legacy.FileFormat.Load(dialog.FileName);
			}
		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Undo();
		}

		private void redoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Redo();
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPressed(e);
		}
		#endregion
	}
}
