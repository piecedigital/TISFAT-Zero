﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TISFAT.Util;

namespace TISFAT.Entities
{
	public partial class BitmapObject : IEntity
	{
		public Bitmap Texture;
		public int TextureID;

		public BitmapObject() { }

		public IEntityState Interpolate(float t, IEntityState _current, IEntityState _target)
		{
			State current = _current as State;
			State target = _target as State;
			State state = new State();

			state.Bounds = Interpolation.Linear(t, current.Bounds, target.Bounds);

			return state;
		}

		public void Draw(IEntityState _state)
		{
			State state = _state as State;
			Drawing.Bitmap(state.Bounds.Location, state.Bounds.Size, TextureID);
		}

		private void DrawHandle(State state, Color c)
		{
			float size = Math.Min(12, Texture.Width / 2);

			Drawing.RectangleLine(state.Bounds.Location, state.Bounds.Size, c);
			Drawing.Rectangle(new PointF(state.Bounds.Left, state.Bounds.Top), new SizeF(size, size), c);
			Drawing.Rectangle(new PointF(state.Bounds.Right - size, state.Bounds.Top), new SizeF(size, size), c);
			Drawing.Rectangle(new PointF(state.Bounds.Left, state.Bounds.Bottom - size), new SizeF(size, size), c);
			Drawing.Rectangle(new PointF(state.Bounds.Right - size, state.Bounds.Bottom - size), new SizeF(size, size), c);
		}

		public void DrawEditable(IEntityState _state)
		{
			State state = _state as State;

			Drawing.Bitmap(state.Bounds.Location, state.Bounds.Size, TextureID);
			DrawHandle(state, Color.Cyan);
		}

		public class ManipulateParams : IManipulatableParams
		{
			public bool AbsoluteDrag;
			public PointF AbsoluteOffset;

			public int CornerGrabbed;

			public bool KeepAspectRatio;
		}

		public ManipulateResult TryManipulate(IEntityState _state, Point location, System.Windows.Forms.MouseButtons button, System.Windows.Forms.Keys modifiers)
		{
			State state = _state as State;

			ManipulateResult result = new ManipulateResult();
			ManipulateParams mparams = new ManipulateParams();
			result.Params = mparams;

			if (modifiers == Keys.Shift)
				mparams.KeepAspectRatio = true;

			if (button == System.Windows.Forms.MouseButtons.Right)
			{
				result.Target = state;
				mparams.AbsoluteDrag = true;
				mparams.AbsoluteOffset = new PointF(location.X - state.Bounds.X, location.Y - state.Bounds.Y);
			}
			else
			{
				mparams.CornerGrabbed = state.HandleAtLocation(location);

				if (mparams.CornerGrabbed == -1)
					return null;

				result.Target = state;
				mparams.AbsoluteDrag = false;
			}

			return result;
		}

		public void ManipulateStart(IManipulatable _target, IManipulatableParams mparams, Point location)
		{

		}

		public void ManipulateUpdate(IManipulatable _target, IManipulatableParams mparams, Point location)
		{
			State target = _target as State;
			target.Move(location, (ManipulateParams)mparams);
		}

		public void ManipulateEnd(IManipulatable target, IManipulatableParams mparams, Point location)
		{
			
		}

		public Layer CreateDefaultLayer(uint StartTime, uint EndTime, LayerCreationArgs e)
		{
			Texture = (Bitmap)Bitmap.FromFile(e.Arguments, true);
			TextureID = Drawing.GenerateTexID(Texture);

			if (!Program.Form.ActiveProject.LayerCount.ContainsKey(typeof(StickFigure)))
				Program.Form.ActiveProject.LayerCount.Add(typeof(StickFigure), 0);

			int CreatedLayerCount = ++Program.Form.ActiveProject.LayerCount[typeof(StickFigure)];

			Layer layer = new Layer(this);
			layer.Name = "Bitmap " + CreatedLayerCount;

			layer.Framesets.Add(new Frameset());
			layer.Framesets[0].Keyframes.Add(new Keyframe(StartTime, CreateRefState()));
			layer.Framesets[0].Keyframes.Add(new Keyframe(EndTime, CreateRefState()));

			return layer;
		}

		public IEntityState CreateRefState()
		{
			return new State() { Bounds = new RectangleF(10, 10, Texture.Width, Texture.Height), TexWidth = Texture.Width, TexHeight = Texture.Height };
		}

		public void Write(BinaryWriter writer)
		{
			FileFormat.WriteBitmap(Texture, writer);
		}

		public void Read(BinaryReader reader, UInt16 version)
		{
			Texture = FileFormat.ReadBitmap(reader);
			TextureID = Drawing.GenerateTexID(Texture);
		}
	}
}