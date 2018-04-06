using System;
using ObjCRuntime;

namespace YLProgressBarXamarin
{
	[Native]
	public enum YLProgressBarType : long
	{
		Rounded = 0,
		Flat = 1
	}

	[Native]
	public enum YLProgressBarStripesOrientation : long
	{
		Right = 0,
		Left = 1,
		Vertical = 2
	}

	[Native]
	public enum YLProgressBarStripesDirection : long
	{
		Left = -1,
		Right = 1
	}

	[Native]
	public enum YLProgressBarBehavior : long
	{
		Default = 0,
		Indeterminate = 1,
		Waiting = 2
	}

	[Native]
	public enum YLProgressBarIndicatorTextDisplayMode : long
	{
		None = 0,
		Track = 1,
		Progress = 2,
		FixedRight = 3
	}
}
