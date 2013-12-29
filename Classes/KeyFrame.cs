﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace TISFAT_Zero
{
	internal abstract class KeyFrame
	{
		#region Properties

		//Default properties
		protected ushort frameType;

		public int Position;
		public List<StickJoint> FrameJoints;
		public Color figColor;
		//public Layer parentLayer;

		//Dynamic properties
		protected Attributes Properties;

		//This is used to specify what type of stickobject it is. ie StickFigure, StickLine, etc.
		public static Type ObjectType
		{
			get { return null; }
		}

		public ushort FrameType
		{
			get { return frameType; }
		}

		#endregion Properties

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="KeyFrame"/> class equivalent to the inputted keyframe.
		/// </summary>
		/// <param name="original">The keyframe to copy properties from.</param>
		/// <param name="NewPosition">A new position to give the new keyframe. Leave blank to keep the same position.</param>
		protected KeyFrame(KeyFrame original, int NewPosition = -1)
		{
			KeyFrame New = original.createClone();

			frameType = New.frameType;
			Position = NewPosition == -1 ? New.Position : NewPosition;
			FrameJoints = New.FrameJoints;
			figColor = New.figColor;
			Properties = New.Properties;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="KeyFrame"/> class.
		/// </summary>
		/// <param name="framePosition">The position of the keyframe inside the timeline.</param>
		protected KeyFrame(int framePosition, ushort ftype = 0)
		{
			frameType = ftype;
			FrameJoints = (List<StickJoint>)(((Type)(this.GetType().GetProperty("ObjectType").GetValue(this, null))).GetProperty("DefaultPose").GetValue(this, null));

			Properties = new Attributes();

			foreach (StickJoint j in FrameJoints)
			{
				if (j.parentJoint != null)
				{
					j.CalcLength();
					j.parentJoint.childJoints.Add(j);
				}
			}

			Position = framePosition;
		}

		public KeyFrame() : this(0)
		{ }

		#endregion Constructors

		#region Methods

		/// <summary>
		/// Creates a clone of the current instance with all equivalent properties.
		/// </summary>
		/// <returns>A new KeyFrame instance.</returns>
		public KeyFrame createClone()
		{
			//Honestly not sure how to use all this, it was given to me in a StackOverflow question that I asked.
			var method = typeof(KeyFrame).GetMethod("copyKeyFrameStep1", BindingFlags.NonPublic | BindingFlags.Instance).MakeGenericMethod(this.GetType());
			var value = method.Invoke(this, null);
			return (KeyFrame)value;
		}

		protected virtual void copyKeyFrameStep2(Attributes oldAttributes)
		{
			//Do nothing by default. If there are special properties to be copied over, each inherited class will do that on it's own.
		}

		protected T copyKeyFrameStep1<T>() where T : KeyFrame, new()
		{
			T newKeyFrame = new T();

			//Copy all default properties
			newKeyFrame.frameType = frameType;
			newKeyFrame.Position = Position;
			newKeyFrame.FrameJoints = StickObject.copyJoints(FrameJoints);
			newKeyFrame.figColor = figColor;

			//The copyKeyFrameStep2 method is overridden by each keyframe class which has custom properties, and will make a new instance of the attributes class with values equivalent to the original.
			newKeyFrame.copyKeyFrameStep2(Properties);

			return newKeyFrame;
		}

		#endregion Methods
	}

	internal class StickFrame : KeyFrame
	{
		new public static Type ObjectType
		{
			get { return typeof(StickFigure); }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StickFrame"/> class at the specified position.
		/// </summary>
		/// <param name="Position">The position of the KeyFrame inside the timeline.</param>
		public StickFrame(int Position) : base(Position, 0)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="StickFrame"/> class at the position 0.
		/// </summary>
		public StickFrame() : this(0)
		{ }
	}

	internal class LineFrame : KeyFrame
	{
		new public static Type ObjectType
		{
			get { return typeof(StickLine); }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LineFrame"/> class at the specified position.
		/// </summary>
		/// <param name="Position">The position of the KeyFrame inside the timeline.</param>
		public LineFrame(int Position) : base(Position, 1)
		{ }

		public LineFrame() : this(0)
		{ }
	}

	internal class RectFrame : KeyFrame
	{
		new public static Type ObjectType
		{
			get { return typeof(StickRect); }
		}

		public bool isFilled
		{
			get { return Properties["isFilled"]; }

			set { Properties["isFilled"] = value; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RectFrame"/> class at the specified position.
		/// </summary>
		/// <param name="Position">The position of the KeyFrame inside the timeline.</param>
		public RectFrame(int Position)
			: base(Position, 2)
		{
			Properties.addAttribute(true, "isFilled");
		}

		public RectFrame() : this(0)
		{ }

		protected override void copyKeyFrameStep2(Attributes oldAttributes)
		{
			Properties = new Attributes();
			Properties.addAttribute(oldAttributes["isFilled"], "isFilled");
		}
	}

	internal class CustomFrame : KeyFrame
	{
		new public static Type ObjectType
		{
			get { return typeof(StickCustom); }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CustomFrame"/> class at the specified position.
		/// </summary>
		/// <param name="Position">The position of the KeyFrame inside the timeline.</param>
		public CustomFrame(int Position) : base(Position, 3)
		{ }

		public CustomFrame() : this(0)
		{ }
	}

	internal class BitmapFrame : KeyFrame
	{
		new public static Type ObjectType
		{
			get { return typeof(StickRect); }
		}

		public uint BitmapID
		{
			get { return (uint)Properties["BitmapID"]; }
			set { Properties["BitmapID"] = value; }
		}

		public BitmapFrame(int Position) : base(Position, 4)
		{
			Properties.addAttribute(-1, "BitmapID");
		}

		public BitmapFrame() : this(0)
		{ }
	}
}