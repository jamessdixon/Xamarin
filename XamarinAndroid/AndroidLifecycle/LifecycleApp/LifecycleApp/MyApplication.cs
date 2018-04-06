using System;
using Android.App;
using Android.Runtime;

namespace LifecycleApp
{
	[Application]
	public class MyApplication : Application
	{
		public MyApplication(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
		{
		}

		public override void OnCreate()
		{
			// Called when the application is starting, before any other application objects have been created (like MainActivity).
			base.OnCreate();
		}

		public override void OnTerminate()
		{
			//From the documentation: https://developer.android.com/reference/android/app/Application.html#onTerminate()
			// This method is for use in emulated process environments. 
			// It will never be called on a production Android device, where processes are removed by simply killing them;
			// No user code (including this callback) is executed when doing so.
			base.OnTerminate();
		}
	}
}
