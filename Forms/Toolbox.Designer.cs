﻿namespace TISFAT_ZERO
{
	partial class Toolbox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Default Figure");
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Custom Figure..");
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Stick Figures", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Line");
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Rectangle");
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Poly");
			System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Shapes", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
			System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Light Source");
			System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Text");
			this.pnl_mainPanel = new System.Windows.Forms.Panel();
			this.pnl_addTools = new System.Windows.Forms.Panel();
			this.trv_addView = new System.Windows.Forms.TreeView();
			this.btn_cancelButton = new System.Windows.Forms.Button();
			this.pnl_Properties = new System.Windows.Forms.Panel();
			this.pnl_Properties_Custom = new System.Windows.Forms.Panel();
			this.btn_bitmapUseNone = new System.Windows.Forms.Button();
			this.lbl_Properties_Bitmap = new System.Windows.Forms.Label();
			this.com_Properties_Bitmap = new System.Windows.Forms.ComboBox();
			this.btn_Properties_Edit = new System.Windows.Forms.Button();
			this.pnl_Properties_Rect = new System.Windows.Forms.Panel();
			this.num_rectOLAlpha = new System.Windows.Forms.NumericUpDown();
			this.num_rectFillAlpha = new System.Windows.Forms.NumericUpDown();
			this.num_rectOLThickness = new System.Windows.Forms.NumericUpDown();
			this.lbl_rectOLThickness = new System.Windows.Forms.Label();
			this.lbl_rectOLAlpha = new System.Windows.Forms.Label();
			this.lbl_rectFillAlpha = new System.Windows.Forms.Label();
			this.pic_rectOLColor = new System.Windows.Forms.PictureBox();
			this.lbl_rectOLColor = new System.Windows.Forms.Label();
			this.pic_rectFillColor = new System.Windows.Forms.PictureBox();
			this.chk_rectFilled = new System.Windows.Forms.CheckBox();
			this.lbl_rectFillColor = new System.Windows.Forms.Label();
			this.btn_pnlLine_Cancel = new System.Windows.Forms.Button();
			this.pnl_Properties_Stick = new System.Windows.Forms.Panel();
			this.lbl_pnlStick_Transparency = new System.Windows.Forms.Label();
			this.num_alpha = new System.Windows.Forms.NumericUpDown();
			this.tkb_alpha = new System.Windows.Forms.TrackBar();
			this.pic_pnlStick_color = new System.Windows.Forms.PictureBox();
			this.lbl_pnlStick_figureColor = new System.Windows.Forms.Label();
			this.pnl_Properties_Line = new System.Windows.Forms.Panel();
			this.lbl_pnlLine_Transparency = new System.Windows.Forms.Label();
			this.num_pnlLine_Transparency = new System.Windows.Forms.NumericUpDown();
			this.tkb_pnlLine_Transparency = new System.Windows.Forms.TrackBar();
			this.lbl_pnlLine_Color = new System.Windows.Forms.Label();
			this.pic_pnlLine_color = new System.Windows.Forms.PictureBox();
			this.num_pnlLine_thickness = new System.Windows.Forms.NumericUpDown();
			this.lbl_pnlLine_thickness = new System.Windows.Forms.Label();
			this.pnl_mainTools = new System.Windows.Forms.Panel();
			this.ckb_renderShadows = new System.Windows.Forms.CheckBox();
			this.btn_BGButton = new System.Windows.Forms.Button();
			this.btn_poserButton = new System.Windows.Forms.Button();
			this.btn_scaleButton = new System.Windows.Forms.Button();
			this.fPropButton = new System.Windows.Forms.Button();
			this.drawButton = new System.Windows.Forms.Button();
			this.btn_addButton = new System.Windows.Forms.Button();
			this.pnl_ctrlPanel = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.maskedTextBox1 = new System.Windows.Forms.NumericUpDown();
			this.btn_playPause = new System.Windows.Forms.Button();
			this.lbl_FPS = new System.Windows.Forms.Label();
			this.lbl_frameCount = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lbl_dbgAngleToParent = new System.Windows.Forms.Label();
			this.lbl_stickFigures = new System.Windows.Forms.Label();
			this.lbl_jointLength = new System.Windows.Forms.Label();
			this.lbl_selectedJoint = new System.Windows.Forms.Label();
			this.lbl_yPos = new System.Windows.Forms.Label();
			this.lbl_xPos = new System.Windows.Forms.Label();
			this.lbl_selectionDummy = new System.Windows.Forms.Label();
			this.pnl_Drawing = new System.Windows.Forms.Panel();
			this.pnl_paintPanel = new System.Windows.Forms.Panel();
			this.btn_cancelButtonDraw = new System.Windows.Forms.Button();
			this.animTimer = new System.Windows.Forms.Timer(this.components);
			this.dlg_Color = new System.Windows.Forms.ColorDialog();
			this.ckb_LoopAnim = new System.Windows.Forms.CheckBox();
			this.pnl_mainPanel.SuspendLayout();
			this.pnl_addTools.SuspendLayout();
			this.pnl_Properties.SuspendLayout();
			this.pnl_Properties_Custom.SuspendLayout();
			this.pnl_Properties_Rect.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_rectOLAlpha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_rectFillAlpha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_rectOLThickness)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_rectOLColor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_rectFillColor)).BeginInit();
			this.pnl_Properties_Stick.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_alpha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tkb_alpha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_pnlStick_color)).BeginInit();
			this.pnl_Properties_Line.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_pnlLine_Transparency)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tkb_pnlLine_Transparency)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_pnlLine_color)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_pnlLine_thickness)).BeginInit();
			this.pnl_mainTools.SuspendLayout();
			this.pnl_ctrlPanel.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.maskedTextBox1)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.pnl_Drawing.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_mainPanel
			// 
			this.pnl_mainPanel.Controls.Add(this.pnl_addTools);
			this.pnl_mainPanel.Controls.Add(this.pnl_Properties);
			this.pnl_mainPanel.Controls.Add(this.pnl_mainTools);
			this.pnl_mainPanel.Controls.Add(this.pnl_ctrlPanel);
			this.pnl_mainPanel.Controls.Add(this.lbl_selectionDummy);
			this.pnl_mainPanel.Controls.Add(this.pnl_Drawing);
			this.pnl_mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_mainPanel.Location = new System.Drawing.Point(0, 0);
			this.pnl_mainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.pnl_mainPanel.Name = "pnl_mainPanel";
			this.pnl_mainPanel.Size = new System.Drawing.Size(163, 336);
			this.pnl_mainPanel.TabIndex = 2;
			// 
			// pnl_addTools
			// 
			this.pnl_addTools.Controls.Add(this.trv_addView);
			this.pnl_addTools.Controls.Add(this.btn_cancelButton);
			this.pnl_addTools.Location = new System.Drawing.Point(198, 142);
			this.pnl_addTools.Name = "pnl_addTools";
			this.pnl_addTools.Size = new System.Drawing.Size(151, 203);
			this.pnl_addTools.TabIndex = 27;
			// 
			// trv_addView
			// 
			this.trv_addView.Dock = System.Windows.Forms.DockStyle.Top;
			this.trv_addView.FullRowSelect = true;
			this.trv_addView.Location = new System.Drawing.Point(0, 0);
			this.trv_addView.Name = "trv_addView";
			treeNode10.Name = "nde_Stick_Default";
			treeNode10.Tag = "0";
			treeNode10.Text = "Default Figure";
			treeNode10.ToolTipText = "The default stick figure";
			treeNode11.Name = "nde_Stick_Custom";
			treeNode11.Tag = "1";
			treeNode11.Text = "Custom Figure..";
			treeNode11.ToolTipText = "Create your own figure, or load an existing one";
			treeNode12.Checked = true;
			treeNode12.Name = "nde_StickFigures";
			treeNode12.Tag = "-1";
			treeNode12.Text = "Stick Figures";
			treeNode12.ToolTipText = "Various stick figure objects";
			treeNode13.Name = "nde_Shape_Line";
			treeNode13.Tag = "2";
			treeNode13.Text = "Line";
			treeNode13.ToolTipText = "A primitive line, from point A to point B.";
			treeNode14.Name = "nde_Shape_Rect";
			treeNode14.Tag = "3";
			treeNode14.Text = "Rectangle";
			treeNode14.ToolTipText = "A basic rectangle with 4 control points.";
			treeNode15.Name = "nde_Shape_Poly";
			treeNode15.Tag = "6";
			treeNode15.Text = "Poly";
			treeNode15.ToolTipText = "A shape with a user-defined amount of points";
			treeNode16.Checked = true;
			treeNode16.Name = "nde_Shapes";
			treeNode16.Tag = "-1";
			treeNode16.Text = "Shapes";
			treeNode16.ToolTipText = "Various primitive shapes";
			treeNode17.Name = "nde_lightSource";
			treeNode17.Tag = "4";
			treeNode17.Text = "Light Source";
			treeNode17.ToolTipText = "A source of light for the shading engine";
			treeNode18.Name = "nde_Text";
			treeNode18.Tag = "5";
			treeNode18.Text = "Text";
			treeNode18.ToolTipText = "A text object with 4 control points and configurable text.";
			this.trv_addView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode16,
            treeNode17,
            treeNode18});
			this.trv_addView.ShowLines = false;
			this.trv_addView.Size = new System.Drawing.Size(151, 158);
			this.trv_addView.TabIndex = 26;
			this.trv_addView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.AddObject);
			// 
			// btn_cancelButton
			// 
			this.btn_cancelButton.Location = new System.Drawing.Point(34, 164);
			this.btn_cancelButton.Name = "btn_cancelButton";
			this.btn_cancelButton.Size = new System.Drawing.Size(75, 23);
			this.btn_cancelButton.TabIndex = 25;
			this.btn_cancelButton.Text = "Cancel";
			this.btn_cancelButton.UseVisualStyleBackColor = true;
			this.btn_cancelButton.Click += new System.EventHandler(this.btn_cancelButton_Click);
			// 
			// pnl_Properties
			// 
			this.pnl_Properties.AutoSize = true;
			this.pnl_Properties.Controls.Add(this.pnl_Properties_Custom);
			this.pnl_Properties.Controls.Add(this.pnl_Properties_Rect);
			this.pnl_Properties.Controls.Add(this.btn_pnlLine_Cancel);
			this.pnl_Properties.Controls.Add(this.pnl_Properties_Stick);
			this.pnl_Properties.Controls.Add(this.pnl_Properties_Line);
			this.pnl_Properties.Location = new System.Drawing.Point(198, 142);
			this.pnl_Properties.Name = "pnl_Properties";
			this.pnl_Properties.Size = new System.Drawing.Size(151, 632);
			this.pnl_Properties.TabIndex = 30;
			// 
			// pnl_Properties_Custom
			// 
			this.pnl_Properties_Custom.Controls.Add(this.btn_bitmapUseNone);
			this.pnl_Properties_Custom.Controls.Add(this.lbl_Properties_Bitmap);
			this.pnl_Properties_Custom.Controls.Add(this.com_Properties_Bitmap);
			this.pnl_Properties_Custom.Controls.Add(this.btn_Properties_Edit);
			this.pnl_Properties_Custom.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Properties_Custom.Location = new System.Drawing.Point(0, 474);
			this.pnl_Properties_Custom.Name = "pnl_Properties_Custom";
			this.pnl_Properties_Custom.Size = new System.Drawing.Size(151, 158);
			this.pnl_Properties_Custom.TabIndex = 31;
			// 
			// btn_bitmapUseNone
			// 
			this.btn_bitmapUseNone.Location = new System.Drawing.Point(38, 57);
			this.btn_bitmapUseNone.Name = "btn_bitmapUseNone";
			this.btn_bitmapUseNone.Size = new System.Drawing.Size(75, 20);
			this.btn_bitmapUseNone.TabIndex = 29;
			this.btn_bitmapUseNone.Text = "Use None";
			this.btn_bitmapUseNone.UseVisualStyleBackColor = true;
			this.btn_bitmapUseNone.Click += new System.EventHandler(this.btn_bitmapUseNone_Click);
			// 
			// lbl_Properties_Bitmap
			// 
			this.lbl_Properties_Bitmap.AutoSize = true;
			this.lbl_Properties_Bitmap.Location = new System.Drawing.Point(20, 14);
			this.lbl_Properties_Bitmap.Name = "lbl_Properties_Bitmap";
			this.lbl_Properties_Bitmap.Size = new System.Drawing.Size(45, 13);
			this.lbl_Properties_Bitmap.TabIndex = 28;
			this.lbl_Properties_Bitmap.Text = "Bitmap: ";
			// 
			// com_Properties_Bitmap
			// 
			this.com_Properties_Bitmap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.com_Properties_Bitmap.FormattingEnabled = true;
			this.com_Properties_Bitmap.Location = new System.Drawing.Point(22, 30);
			this.com_Properties_Bitmap.Name = "com_Properties_Bitmap";
			this.com_Properties_Bitmap.Size = new System.Drawing.Size(109, 21);
			this.com_Properties_Bitmap.TabIndex = 27;
			this.com_Properties_Bitmap.SelectionChangeCommitted += new System.EventHandler(this.com_Properties_Bitmap_SelectionChangeCommitted);
			// 
			// btn_Properties_Edit
			// 
			this.btn_Properties_Edit.Location = new System.Drawing.Point(41, 110);
			this.btn_Properties_Edit.Name = "btn_Properties_Edit";
			this.btn_Properties_Edit.Size = new System.Drawing.Size(75, 23);
			this.btn_Properties_Edit.TabIndex = 26;
			this.btn_Properties_Edit.Text = "Edit Figure";
			this.btn_Properties_Edit.UseVisualStyleBackColor = true;
			this.btn_Properties_Edit.Click += new System.EventHandler(this.btn_Properties_Edit_Click);
			// 
			// pnl_Properties_Rect
			// 
			this.pnl_Properties_Rect.AutoScroll = true;
			this.pnl_Properties_Rect.Controls.Add(this.num_rectOLAlpha);
			this.pnl_Properties_Rect.Controls.Add(this.num_rectFillAlpha);
			this.pnl_Properties_Rect.Controls.Add(this.num_rectOLThickness);
			this.pnl_Properties_Rect.Controls.Add(this.lbl_rectOLThickness);
			this.pnl_Properties_Rect.Controls.Add(this.lbl_rectOLAlpha);
			this.pnl_Properties_Rect.Controls.Add(this.lbl_rectFillAlpha);
			this.pnl_Properties_Rect.Controls.Add(this.pic_rectOLColor);
			this.pnl_Properties_Rect.Controls.Add(this.lbl_rectOLColor);
			this.pnl_Properties_Rect.Controls.Add(this.pic_rectFillColor);
			this.pnl_Properties_Rect.Controls.Add(this.chk_rectFilled);
			this.pnl_Properties_Rect.Controls.Add(this.lbl_rectFillColor);
			this.pnl_Properties_Rect.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Properties_Rect.Location = new System.Drawing.Point(0, 316);
			this.pnl_Properties_Rect.Name = "pnl_Properties_Rect";
			this.pnl_Properties_Rect.Size = new System.Drawing.Size(151, 158);
			this.pnl_Properties_Rect.TabIndex = 32;
			// 
			// num_rectOLAlpha
			// 
			this.num_rectOLAlpha.Location = new System.Drawing.Point(83, 88);
			this.num_rectOLAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.num_rectOLAlpha.Name = "num_rectOLAlpha";
			this.num_rectOLAlpha.Size = new System.Drawing.Size(45, 20);
			this.num_rectOLAlpha.TabIndex = 35;
			this.num_rectOLAlpha.ValueChanged += new System.EventHandler(this.num_rectOLAlpha_ValueChanged);
			// 
			// num_rectFillAlpha
			// 
			this.num_rectFillAlpha.Location = new System.Drawing.Point(22, 88);
			this.num_rectFillAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.num_rectFillAlpha.Name = "num_rectFillAlpha";
			this.num_rectFillAlpha.Size = new System.Drawing.Size(45, 20);
			this.num_rectFillAlpha.TabIndex = 34;
			this.num_rectFillAlpha.ValueChanged += new System.EventHandler(this.num_rectFillAlpha_ValueChanged);
			// 
			// num_rectOLThickness
			// 
			this.num_rectOLThickness.Location = new System.Drawing.Point(51, 128);
			this.num_rectOLThickness.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.num_rectOLThickness.Name = "num_rectOLThickness";
			this.num_rectOLThickness.Size = new System.Drawing.Size(45, 20);
			this.num_rectOLThickness.TabIndex = 33;
			// 
			// lbl_rectOLThickness
			// 
			this.lbl_rectOLThickness.AutoSize = true;
			this.lbl_rectOLThickness.Location = new System.Drawing.Point(37, 110);
			this.lbl_rectOLThickness.Name = "lbl_rectOLThickness";
			this.lbl_rectOLThickness.Size = new System.Drawing.Size(73, 13);
			this.lbl_rectOLThickness.TabIndex = 9;
			this.lbl_rectOLThickness.Text = "OL Thickness";
			// 
			// lbl_rectOLAlpha
			// 
			this.lbl_rectOLAlpha.AutoSize = true;
			this.lbl_rectOLAlpha.Location = new System.Drawing.Point(80, 72);
			this.lbl_rectOLAlpha.Name = "lbl_rectOLAlpha";
			this.lbl_rectOLAlpha.Size = new System.Drawing.Size(51, 13);
			this.lbl_rectOLAlpha.TabIndex = 8;
			this.lbl_rectOLAlpha.Text = "OL Alpha";
			// 
			// lbl_rectFillAlpha
			// 
			this.lbl_rectFillAlpha.AutoSize = true;
			this.lbl_rectFillAlpha.Location = new System.Drawing.Point(19, 72);
			this.lbl_rectFillAlpha.Name = "lbl_rectFillAlpha";
			this.lbl_rectFillAlpha.Size = new System.Drawing.Size(49, 13);
			this.lbl_rectFillAlpha.TabIndex = 5;
			this.lbl_rectFillAlpha.Text = "Fill Alpha";
			// 
			// pic_rectOLColor
			// 
			this.pic_rectOLColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pic_rectOLColor.Location = new System.Drawing.Point(90, 43);
			this.pic_rectOLColor.Name = "pic_rectOLColor";
			this.pic_rectOLColor.Size = new System.Drawing.Size(25, 25);
			this.pic_rectOLColor.TabIndex = 4;
			this.pic_rectOLColor.TabStop = false;
			this.pic_rectOLColor.Click += new System.EventHandler(this.pic_rectOLColor_Click);
			// 
			// lbl_rectOLColor
			// 
			this.lbl_rectOLColor.AutoSize = true;
			this.lbl_rectOLColor.Location = new System.Drawing.Point(80, 27);
			this.lbl_rectOLColor.Name = "lbl_rectOLColor";
			this.lbl_rectOLColor.Size = new System.Drawing.Size(48, 13);
			this.lbl_rectOLColor.TabIndex = 3;
			this.lbl_rectOLColor.Text = "OL Color";
			// 
			// pic_rectFillColor
			// 
			this.pic_rectFillColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pic_rectFillColor.Location = new System.Drawing.Point(28, 43);
			this.pic_rectFillColor.Name = "pic_rectFillColor";
			this.pic_rectFillColor.Size = new System.Drawing.Size(25, 25);
			this.pic_rectFillColor.TabIndex = 2;
			this.pic_rectFillColor.TabStop = false;
			this.pic_rectFillColor.Click += new System.EventHandler(this.pic_rectFillColor_Click);
			// 
			// chk_rectFilled
			// 
			this.chk_rectFilled.AutoSize = true;
			this.chk_rectFilled.Checked = true;
			this.chk_rectFilled.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_rectFilled.Location = new System.Drawing.Point(48, 8);
			this.chk_rectFilled.Name = "chk_rectFilled";
			this.chk_rectFilled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chk_rectFilled.Size = new System.Drawing.Size(50, 17);
			this.chk_rectFilled.TabIndex = 1;
			this.chk_rectFilled.Text = "Filled";
			this.chk_rectFilled.UseVisualStyleBackColor = true;
			this.chk_rectFilled.CheckedChanged += new System.EventHandler(this.chk_rectFilled_CheckedChanged);
			// 
			// lbl_rectFillColor
			// 
			this.lbl_rectFillColor.AutoSize = true;
			this.lbl_rectFillColor.Location = new System.Drawing.Point(19, 27);
			this.lbl_rectFillColor.Name = "lbl_rectFillColor";
			this.lbl_rectFillColor.Size = new System.Drawing.Size(46, 13);
			this.lbl_rectFillColor.TabIndex = 0;
			this.lbl_rectFillColor.Text = "Fill Color";
			// 
			// btn_pnlLine_Cancel
			// 
			this.btn_pnlLine_Cancel.Location = new System.Drawing.Point(38, 164);
			this.btn_pnlLine_Cancel.Name = "btn_pnlLine_Cancel";
			this.btn_pnlLine_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_pnlLine_Cancel.TabIndex = 25;
			this.btn_pnlLine_Cancel.Text = "Cancel";
			this.btn_pnlLine_Cancel.UseVisualStyleBackColor = true;
			this.btn_pnlLine_Cancel.Click += new System.EventHandler(this.btn_pnlLine_Cancel_Click);
			// 
			// pnl_Properties_Stick
			// 
			this.pnl_Properties_Stick.Controls.Add(this.lbl_pnlStick_Transparency);
			this.pnl_Properties_Stick.Controls.Add(this.num_alpha);
			this.pnl_Properties_Stick.Controls.Add(this.tkb_alpha);
			this.pnl_Properties_Stick.Controls.Add(this.pic_pnlStick_color);
			this.pnl_Properties_Stick.Controls.Add(this.lbl_pnlStick_figureColor);
			this.pnl_Properties_Stick.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Properties_Stick.Location = new System.Drawing.Point(0, 158);
			this.pnl_Properties_Stick.Name = "pnl_Properties_Stick";
			this.pnl_Properties_Stick.Size = new System.Drawing.Size(151, 158);
			this.pnl_Properties_Stick.TabIndex = 31;
			// 
			// lbl_pnlStick_Transparency
			// 
			this.lbl_pnlStick_Transparency.AutoSize = true;
			this.lbl_pnlStick_Transparency.Location = new System.Drawing.Point(38, 59);
			this.lbl_pnlStick_Transparency.Name = "lbl_pnlStick_Transparency";
			this.lbl_pnlStick_Transparency.Size = new System.Drawing.Size(75, 13);
			this.lbl_pnlStick_Transparency.TabIndex = 4;
			this.lbl_pnlStick_Transparency.Text = "Transparency:";
			// 
			// num_alpha
			// 
			this.num_alpha.Location = new System.Drawing.Point(53, 113);
			this.num_alpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.num_alpha.Name = "num_alpha";
			this.num_alpha.Size = new System.Drawing.Size(45, 20);
			this.num_alpha.TabIndex = 3;
			this.num_alpha.ValueChanged += new System.EventHandler(this.num_alpha_ValueChanged);
			// 
			// tkb_alpha
			// 
			this.tkb_alpha.Location = new System.Drawing.Point(23, 76);
			this.tkb_alpha.Maximum = 255;
			this.tkb_alpha.Name = "tkb_alpha";
			this.tkb_alpha.Size = new System.Drawing.Size(104, 45);
			this.tkb_alpha.TabIndex = 2;
			this.tkb_alpha.Scroll += new System.EventHandler(this.tkb_alpha_Scroll);
			// 
			// pic_pnlStick_color
			// 
			this.pic_pnlStick_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pic_pnlStick_color.Location = new System.Drawing.Point(101, 19);
			this.pic_pnlStick_color.Name = "pic_pnlStick_color";
			this.pic_pnlStick_color.Size = new System.Drawing.Size(25, 25);
			this.pic_pnlStick_color.TabIndex = 1;
			this.pic_pnlStick_color.TabStop = false;
			this.pic_pnlStick_color.Click += new System.EventHandler(this.pic_pnlStick_color_Click);
			// 
			// lbl_pnlStick_figureColor
			// 
			this.lbl_pnlStick_figureColor.AutoSize = true;
			this.lbl_pnlStick_figureColor.Location = new System.Drawing.Point(26, 25);
			this.lbl_pnlStick_figureColor.Name = "lbl_pnlStick_figureColor";
			this.lbl_pnlStick_figureColor.Size = new System.Drawing.Size(66, 13);
			this.lbl_pnlStick_figureColor.TabIndex = 0;
			this.lbl_pnlStick_figureColor.Text = "Figure Color:";
			// 
			// pnl_Properties_Line
			// 
			this.pnl_Properties_Line.Controls.Add(this.lbl_pnlLine_Transparency);
			this.pnl_Properties_Line.Controls.Add(this.num_pnlLine_Transparency);
			this.pnl_Properties_Line.Controls.Add(this.tkb_pnlLine_Transparency);
			this.pnl_Properties_Line.Controls.Add(this.lbl_pnlLine_Color);
			this.pnl_Properties_Line.Controls.Add(this.pic_pnlLine_color);
			this.pnl_Properties_Line.Controls.Add(this.num_pnlLine_thickness);
			this.pnl_Properties_Line.Controls.Add(this.lbl_pnlLine_thickness);
			this.pnl_Properties_Line.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Properties_Line.Location = new System.Drawing.Point(0, 0);
			this.pnl_Properties_Line.Name = "pnl_Properties_Line";
			this.pnl_Properties_Line.Size = new System.Drawing.Size(151, 158);
			this.pnl_Properties_Line.TabIndex = 26;
			// 
			// lbl_pnlLine_Transparency
			// 
			this.lbl_pnlLine_Transparency.AutoSize = true;
			this.lbl_pnlLine_Transparency.Location = new System.Drawing.Point(38, 71);
			this.lbl_pnlLine_Transparency.Name = "lbl_pnlLine_Transparency";
			this.lbl_pnlLine_Transparency.Size = new System.Drawing.Size(75, 13);
			this.lbl_pnlLine_Transparency.TabIndex = 5;
			this.lbl_pnlLine_Transparency.Text = "Transparency:";
			// 
			// num_pnlLine_Transparency
			// 
			this.num_pnlLine_Transparency.Location = new System.Drawing.Point(53, 121);
			this.num_pnlLine_Transparency.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.num_pnlLine_Transparency.Name = "num_pnlLine_Transparency";
			this.num_pnlLine_Transparency.Size = new System.Drawing.Size(45, 20);
			this.num_pnlLine_Transparency.TabIndex = 3;
			this.num_pnlLine_Transparency.ValueChanged += new System.EventHandler(this.num_alpha_ValueChanged);
			// 
			// tkb_pnlLine_Transparency
			// 
			this.tkb_pnlLine_Transparency.Location = new System.Drawing.Point(23, 87);
			this.tkb_pnlLine_Transparency.Maximum = 255;
			this.tkb_pnlLine_Transparency.Name = "tkb_pnlLine_Transparency";
			this.tkb_pnlLine_Transparency.Size = new System.Drawing.Size(104, 45);
			this.tkb_pnlLine_Transparency.TabIndex = 4;
			// 
			// lbl_pnlLine_Color
			// 
			this.lbl_pnlLine_Color.AutoSize = true;
			this.lbl_pnlLine_Color.Location = new System.Drawing.Point(41, 48);
			this.lbl_pnlLine_Color.Name = "lbl_pnlLine_Color";
			this.lbl_pnlLine_Color.Size = new System.Drawing.Size(37, 13);
			this.lbl_pnlLine_Color.TabIndex = 3;
			this.lbl_pnlLine_Color.Text = "Color: ";
			// 
			// pic_pnlLine_color
			// 
			this.pic_pnlLine_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pic_pnlLine_color.Location = new System.Drawing.Point(85, 43);
			this.pic_pnlLine_color.Name = "pic_pnlLine_color";
			this.pic_pnlLine_color.Size = new System.Drawing.Size(25, 25);
			this.pic_pnlLine_color.TabIndex = 2;
			this.pic_pnlLine_color.TabStop = false;
			this.pic_pnlLine_color.Click += new System.EventHandler(this.pic_pnlLine_color_Click);
			// 
			// num_pnlLine_thickness
			// 
			this.num_pnlLine_thickness.Location = new System.Drawing.Point(83, 17);
			this.num_pnlLine_thickness.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.num_pnlLine_thickness.Name = "num_pnlLine_thickness";
			this.num_pnlLine_thickness.Size = new System.Drawing.Size(45, 20);
			this.num_pnlLine_thickness.TabIndex = 1;
			this.num_pnlLine_thickness.ValueChanged += new System.EventHandler(this.num_pnlLine_thickness_ValueChanged);
			// 
			// lbl_pnlLine_thickness
			// 
			this.lbl_pnlLine_thickness.AutoSize = true;
			this.lbl_pnlLine_thickness.Location = new System.Drawing.Point(22, 19);
			this.lbl_pnlLine_thickness.Name = "lbl_pnlLine_thickness";
			this.lbl_pnlLine_thickness.Size = new System.Drawing.Size(62, 13);
			this.lbl_pnlLine_thickness.TabIndex = 0;
			this.lbl_pnlLine_thickness.Text = "Thickness: ";
			// 
			// pnl_mainTools
			// 
			this.pnl_mainTools.Controls.Add(this.ckb_renderShadows);
			this.pnl_mainTools.Controls.Add(this.btn_BGButton);
			this.pnl_mainTools.Controls.Add(this.btn_poserButton);
			this.pnl_mainTools.Controls.Add(this.btn_scaleButton);
			this.pnl_mainTools.Controls.Add(this.fPropButton);
			this.pnl_mainTools.Controls.Add(this.drawButton);
			this.pnl_mainTools.Controls.Add(this.btn_addButton);
			this.pnl_mainTools.Location = new System.Drawing.Point(6, 142);
			this.pnl_mainTools.Name = "pnl_mainTools";
			this.pnl_mainTools.Size = new System.Drawing.Size(151, 203);
			this.pnl_mainTools.TabIndex = 28;
			// 
			// ckb_renderShadows
			// 
			this.ckb_renderShadows.AutoSize = true;
			this.ckb_renderShadows.Location = new System.Drawing.Point(21, 170);
			this.ckb_renderShadows.Name = "ckb_renderShadows";
			this.ckb_renderShadows.Size = new System.Drawing.Size(108, 17);
			this.ckb_renderShadows.TabIndex = 25;
			this.ckb_renderShadows.Text = "Render Shadows";
			this.ckb_renderShadows.UseVisualStyleBackColor = true;
			this.ckb_renderShadows.CheckedChanged += new System.EventHandler(this.ckb_renderShadows_CheckedChanged);
			// 
			// btn_BGButton
			// 
			this.btn_BGButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_BGButton.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_BGButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(129)))), ((int)(((byte)(145)))));
			this.btn_BGButton.Location = new System.Drawing.Point(77, 108);
			this.btn_BGButton.Name = "btn_BGButton";
			this.btn_BGButton.Size = new System.Drawing.Size(73, 50);
			this.btn_BGButton.TabIndex = 24;
			this.btn_BGButton.TabStop = false;
			this.btn_BGButton.Text = "BG Color";
			this.btn_BGButton.UseVisualStyleBackColor = true;
			this.btn_BGButton.Click += new System.EventHandler(this.btn_BGButton_Click);
			// 
			// btn_poserButton
			// 
			this.btn_poserButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_poserButton.Enabled = false;
			this.btn_poserButton.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_poserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(129)))), ((int)(((byte)(145)))));
			this.btn_poserButton.Location = new System.Drawing.Point(1, 108);
			this.btn_poserButton.Name = "btn_poserButton";
			this.btn_poserButton.Size = new System.Drawing.Size(73, 50);
			this.btn_poserButton.TabIndex = 23;
			this.btn_poserButton.TabStop = false;
			this.btn_poserButton.Text = "Figure Poser";
			this.btn_poserButton.UseVisualStyleBackColor = true;
			// 
			// btn_scaleButton
			// 
			this.btn_scaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_scaleButton.Enabled = false;
			this.btn_scaleButton.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_scaleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(129)))), ((int)(((byte)(145)))));
			this.btn_scaleButton.Location = new System.Drawing.Point(77, 56);
			this.btn_scaleButton.Name = "btn_scaleButton";
			this.btn_scaleButton.Size = new System.Drawing.Size(73, 50);
			this.btn_scaleButton.TabIndex = 22;
			this.btn_scaleButton.TabStop = false;
			this.btn_scaleButton.Text = "Scale Figure";
			this.btn_scaleButton.UseVisualStyleBackColor = true;
			// 
			// fPropButton
			// 
			this.fPropButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.fPropButton.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fPropButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(129)))), ((int)(((byte)(145)))));
			this.fPropButton.Location = new System.Drawing.Point(1, 56);
			this.fPropButton.Name = "fPropButton";
			this.fPropButton.Size = new System.Drawing.Size(73, 50);
			this.fPropButton.TabIndex = 21;
			this.fPropButton.TabStop = false;
			this.fPropButton.Text = "Object Properties";
			this.fPropButton.UseVisualStyleBackColor = true;
			this.fPropButton.Click += new System.EventHandler(this.fPropButton_Click_1);
			// 
			// drawButton
			// 
			this.drawButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.drawButton.Enabled = false;
			this.drawButton.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.drawButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(129)))), ((int)(((byte)(145)))));
			this.drawButton.Location = new System.Drawing.Point(77, 4);
			this.drawButton.Name = "drawButton";
			this.drawButton.Size = new System.Drawing.Size(73, 50);
			this.drawButton.TabIndex = 20;
			this.drawButton.TabStop = false;
			this.drawButton.Text = "Drawing";
			this.drawButton.UseVisualStyleBackColor = true;
			this.drawButton.Click += new System.EventHandler(this.drawButton_Click_1);
			// 
			// btn_addButton
			// 
			this.btn_addButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_addButton.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(129)))), ((int)(((byte)(145)))));
			this.btn_addButton.Location = new System.Drawing.Point(1, 4);
			this.btn_addButton.Name = "btn_addButton";
			this.btn_addButton.Size = new System.Drawing.Size(73, 50);
			this.btn_addButton.TabIndex = 19;
			this.btn_addButton.TabStop = false;
			this.btn_addButton.Text = "Add";
			this.btn_addButton.UseVisualStyleBackColor = true;
			this.btn_addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// pnl_ctrlPanel
			// 
			this.pnl_ctrlPanel.BackColor = System.Drawing.SystemColors.Control;
			this.pnl_ctrlPanel.Controls.Add(this.tabControl1);
			this.pnl_ctrlPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_ctrlPanel.Location = new System.Drawing.Point(0, 0);
			this.pnl_ctrlPanel.Name = "pnl_ctrlPanel";
			this.pnl_ctrlPanel.Size = new System.Drawing.Size(163, 140);
			this.pnl_ctrlPanel.TabIndex = 1;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(163, 140);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.LightGray;
			this.tabPage1.Controls.Add(this.ckb_LoopAnim);
			this.tabPage1.Controls.Add(this.maskedTextBox1);
			this.tabPage1.Controls.Add(this.btn_playPause);
			this.tabPage1.Controls.Add(this.lbl_FPS);
			this.tabPage1.Controls.Add(this.lbl_frameCount);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(155, 114);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Control";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(74, 34);
			this.maskedTextBox1.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.maskedTextBox1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(40, 20);
			this.maskedTextBox1.TabIndex = 4;
			this.maskedTextBox1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.maskedTextBox1.ValueChanged += new System.EventHandler(this.maskedTextBox1_ValueChanged);
			// 
			// btn_playPause
			// 
			this.btn_playPause.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
			this.btn_playPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(129)))), ((int)(((byte)(145)))));
			this.btn_playPause.Location = new System.Drawing.Point(40, 85);
			this.btn_playPause.Name = "btn_playPause";
			this.btn_playPause.Size = new System.Drawing.Size(75, 23);
			this.btn_playPause.TabIndex = 3;
			this.btn_playPause.Text = "Play";
			this.btn_playPause.UseVisualStyleBackColor = true;
			this.btn_playPause.Click += new System.EventHandler(this.btn_playPause_Click);
			// 
			// lbl_FPS
			// 
			this.lbl_FPS.AutoSize = true;
			this.lbl_FPS.Location = new System.Drawing.Point(41, 37);
			this.lbl_FPS.Name = "lbl_FPS";
			this.lbl_FPS.Size = new System.Drawing.Size(30, 13);
			this.lbl_FPS.TabIndex = 2;
			this.lbl_FPS.Text = "FPS:";
			// 
			// lbl_frameCount
			// 
			this.lbl_frameCount.AutoSize = true;
			this.lbl_frameCount.Location = new System.Drawing.Point(50, 7);
			this.lbl_frameCount.Name = "lbl_frameCount";
			this.lbl_frameCount.Size = new System.Drawing.Size(54, 13);
			this.lbl_frameCount.TabIndex = 0;
			this.lbl_frameCount.Text = "Playback:";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.LightGray;
			this.tabPage2.Controls.Add(this.lbl_dbgAngleToParent);
			this.tabPage2.Controls.Add(this.lbl_stickFigures);
			this.tabPage2.Controls.Add(this.lbl_jointLength);
			this.tabPage2.Controls.Add(this.lbl_selectedJoint);
			this.tabPage2.Controls.Add(this.lbl_yPos);
			this.tabPage2.Controls.Add(this.lbl_xPos);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1013, 114);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Debug";
			// 
			// lbl_dbgAngleToParent
			// 
			this.lbl_dbgAngleToParent.AutoSize = true;
			this.lbl_dbgAngleToParent.Location = new System.Drawing.Point(3, 66);
			this.lbl_dbgAngleToParent.Name = "lbl_dbgAngleToParent";
			this.lbl_dbgAngleToParent.Size = new System.Drawing.Size(84, 13);
			this.lbl_dbgAngleToParent.TabIndex = 10;
			this.lbl_dbgAngleToParent.Text = "AngleToParent: ";
			// 
			// lbl_stickFigures
			// 
			this.lbl_stickFigures.AutoSize = true;
			this.lbl_stickFigures.Location = new System.Drawing.Point(3, 81);
			this.lbl_stickFigures.Name = "lbl_stickFigures";
			this.lbl_stickFigures.Size = new System.Drawing.Size(85, 13);
			this.lbl_stickFigures.TabIndex = 9;
			this.lbl_stickFigures.Text = "StickFigure List: ";
			// 
			// lbl_jointLength
			// 
			this.lbl_jointLength.AutoSize = true;
			this.lbl_jointLength.Location = new System.Drawing.Point(3, 52);
			this.lbl_jointLength.Name = "lbl_jointLength";
			this.lbl_jointLength.Size = new System.Drawing.Size(71, 13);
			this.lbl_jointLength.TabIndex = 8;
			this.lbl_jointLength.Text = "Joint Length: ";
			// 
			// lbl_selectedJoint
			// 
			this.lbl_selectedJoint.AutoSize = true;
			this.lbl_selectedJoint.Location = new System.Drawing.Point(3, 39);
			this.lbl_selectedJoint.Name = "lbl_selectedJoint";
			this.lbl_selectedJoint.Size = new System.Drawing.Size(80, 13);
			this.lbl_selectedJoint.TabIndex = 7;
			this.lbl_selectedJoint.Text = "Selected Joint: ";
			// 
			// lbl_yPos
			// 
			this.lbl_yPos.AutoSize = true;
			this.lbl_yPos.Location = new System.Drawing.Point(3, 17);
			this.lbl_yPos.Name = "lbl_yPos";
			this.lbl_yPos.Size = new System.Drawing.Size(47, 13);
			this.lbl_yPos.TabIndex = 6;
			this.lbl_yPos.Text = "Y Pos: 0";
			// 
			// lbl_xPos
			// 
			this.lbl_xPos.AutoSize = true;
			this.lbl_xPos.Location = new System.Drawing.Point(3, 4);
			this.lbl_xPos.Name = "lbl_xPos";
			this.lbl_xPos.Size = new System.Drawing.Size(47, 13);
			this.lbl_xPos.TabIndex = 5;
			this.lbl_xPos.Text = "X Pos: 0";
			// 
			// lbl_selectionDummy
			// 
			this.lbl_selectionDummy.AutoSize = true;
			this.lbl_selectionDummy.Location = new System.Drawing.Point(74, 198);
			this.lbl_selectionDummy.Name = "lbl_selectionDummy";
			this.lbl_selectionDummy.Size = new System.Drawing.Size(0, 13);
			this.lbl_selectionDummy.TabIndex = 19;
			// 
			// pnl_Drawing
			// 
			this.pnl_Drawing.Controls.Add(this.pnl_paintPanel);
			this.pnl_Drawing.Controls.Add(this.btn_cancelButtonDraw);
			this.pnl_Drawing.Location = new System.Drawing.Point(198, 142);
			this.pnl_Drawing.Name = "pnl_Drawing";
			this.pnl_Drawing.Size = new System.Drawing.Size(151, 203);
			this.pnl_Drawing.TabIndex = 29;
			// 
			// pnl_paintPanel
			// 
			this.pnl_paintPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_paintPanel.Location = new System.Drawing.Point(0, 0);
			this.pnl_paintPanel.Name = "pnl_paintPanel";
			this.pnl_paintPanel.Size = new System.Drawing.Size(151, 158);
			this.pnl_paintPanel.TabIndex = 26;
			// 
			// btn_cancelButtonDraw
			// 
			this.btn_cancelButtonDraw.Location = new System.Drawing.Point(34, 164);
			this.btn_cancelButtonDraw.Name = "btn_cancelButtonDraw";
			this.btn_cancelButtonDraw.Size = new System.Drawing.Size(75, 23);
			this.btn_cancelButtonDraw.TabIndex = 25;
			this.btn_cancelButtonDraw.Text = "Cancel";
			this.btn_cancelButtonDraw.UseVisualStyleBackColor = true;
			this.btn_cancelButtonDraw.Click += new System.EventHandler(this.btn_cancelButtonDraw_Click);
			// 
			// animTimer
			// 
			this.animTimer.Interval = 24;
			this.animTimer.Tick += new System.EventHandler(this.animTimer_Tick);
			// 
			// ckb_LoopAnim
			// 
			this.ckb_LoopAnim.AutoSize = true;
			this.ckb_LoopAnim.Checked = true;
			this.ckb_LoopAnim.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckb_LoopAnim.Location = new System.Drawing.Point(52, 62);
			this.ckb_LoopAnim.Name = "ckb_LoopAnim";
			this.ckb_LoopAnim.Size = new System.Drawing.Size(50, 17);
			this.ckb_LoopAnim.TabIndex = 5;
			this.ckb_LoopAnim.Text = "Loop";
			this.ckb_LoopAnim.UseVisualStyleBackColor = true;
			this.ckb_LoopAnim.CheckedChanged += new System.EventHandler(this.ckb_LoopAnim_CheckedChanged);
			// 
			// Toolbox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(163, 336);
			this.ControlBox = false;
			this.Controls.Add(this.pnl_mainPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Toolbox";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Toolbox";
			this.Load += new System.EventHandler(this.Toolbox_Load);
			this.pnl_mainPanel.ResumeLayout(false);
			this.pnl_mainPanel.PerformLayout();
			this.pnl_addTools.ResumeLayout(false);
			this.pnl_Properties.ResumeLayout(false);
			this.pnl_Properties_Custom.ResumeLayout(false);
			this.pnl_Properties_Custom.PerformLayout();
			this.pnl_Properties_Rect.ResumeLayout(false);
			this.pnl_Properties_Rect.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_rectOLAlpha)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_rectFillAlpha)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_rectOLThickness)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_rectOLColor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_rectFillColor)).EndInit();
			this.pnl_Properties_Stick.ResumeLayout(false);
			this.pnl_Properties_Stick.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_alpha)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tkb_alpha)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_pnlStick_color)).EndInit();
			this.pnl_Properties_Line.ResumeLayout(false);
			this.pnl_Properties_Line.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_pnlLine_Transparency)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tkb_pnlLine_Transparency)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_pnlLine_color)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_pnlLine_thickness)).EndInit();
			this.pnl_mainTools.ResumeLayout(false);
			this.pnl_mainTools.PerformLayout();
			this.pnl_ctrlPanel.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.maskedTextBox1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.pnl_Drawing.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnl_mainPanel;
		private System.Windows.Forms.Panel pnl_ctrlPanel;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		public System.Windows.Forms.Label lbl_stickFigures;
		public System.Windows.Forms.Label lbl_jointLength;
		public System.Windows.Forms.Label lbl_selectedJoint;
		public System.Windows.Forms.Label lbl_yPos;
		public System.Windows.Forms.Label lbl_xPos;
		private System.Windows.Forms.Label lbl_selectionDummy;
		private System.Windows.Forms.Label lbl_frameCount;
		private System.Windows.Forms.Label lbl_FPS;
		public System.Windows.Forms.Button btn_playPause;
		private System.Windows.Forms.Panel pnl_mainTools;
		private System.Windows.Forms.Button btn_BGButton;
		private System.Windows.Forms.Button btn_poserButton;
		private System.Windows.Forms.Button btn_scaleButton;
		private System.Windows.Forms.Button fPropButton;
		private System.Windows.Forms.Button drawButton;
		private System.Windows.Forms.Button btn_addButton;
		private System.Windows.Forms.Panel pnl_addTools;
		private System.Windows.Forms.Timer animTimer;
		private System.Windows.Forms.Button btn_cancelButton;
		private System.Windows.Forms.Panel pnl_Drawing;
		private System.Windows.Forms.Button btn_cancelButtonDraw;
		private System.Windows.Forms.Panel pnl_paintPanel;
		private System.Windows.Forms.NumericUpDown maskedTextBox1;
		private System.Windows.Forms.Panel pnl_Properties;
		private System.Windows.Forms.Panel pnl_Properties_Line;
		private System.Windows.Forms.Label lbl_pnlLine_Color;
		private System.Windows.Forms.PictureBox pic_pnlLine_color;
		private System.Windows.Forms.NumericUpDown num_pnlLine_thickness;
		private System.Windows.Forms.Label lbl_pnlLine_thickness;
		private System.Windows.Forms.Button btn_pnlLine_Cancel;
		private System.Windows.Forms.ColorDialog dlg_Color;
		private System.Windows.Forms.Panel pnl_Properties_Stick;
		private System.Windows.Forms.Label lbl_pnlStick_figureColor;
		private System.Windows.Forms.PictureBox pic_pnlStick_color;
		private System.Windows.Forms.TrackBar tkb_alpha;
		private System.Windows.Forms.NumericUpDown num_alpha;
		private System.Windows.Forms.Label lbl_pnlStick_Transparency;
		private System.Windows.Forms.Label lbl_pnlLine_Transparency;
		private System.Windows.Forms.NumericUpDown num_pnlLine_Transparency;
		private System.Windows.Forms.TrackBar tkb_pnlLine_Transparency;
		private System.Windows.Forms.Panel pnl_Properties_Rect;
		private System.Windows.Forms.NumericUpDown num_rectOLThickness;
		private System.Windows.Forms.Label lbl_rectOLThickness;
		private System.Windows.Forms.Label lbl_rectOLAlpha;
		private System.Windows.Forms.Label lbl_rectFillAlpha;
		private System.Windows.Forms.PictureBox pic_rectOLColor;
		private System.Windows.Forms.Label lbl_rectOLColor;
		private System.Windows.Forms.PictureBox pic_rectFillColor;
		private System.Windows.Forms.CheckBox chk_rectFilled;
		private System.Windows.Forms.Label lbl_rectFillColor;
		private System.Windows.Forms.NumericUpDown num_rectOLAlpha;
		private System.Windows.Forms.NumericUpDown num_rectFillAlpha;
		private System.Windows.Forms.TreeView trv_addView;
		private System.Windows.Forms.CheckBox ckb_renderShadows;
		public System.Windows.Forms.Label lbl_dbgAngleToParent;
		private System.Windows.Forms.Panel pnl_Properties_Custom;
		private System.Windows.Forms.ComboBox com_Properties_Bitmap;
		private System.Windows.Forms.Button btn_Properties_Edit;
		private System.Windows.Forms.Label lbl_Properties_Bitmap;
		private System.Windows.Forms.Button btn_bitmapUseNone;
		private System.Windows.Forms.CheckBox ckb_LoopAnim;
	}
}