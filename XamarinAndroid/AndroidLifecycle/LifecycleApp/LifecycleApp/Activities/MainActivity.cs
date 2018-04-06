using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace LifecycleApp
{
	[Activity(Label = "LifecycleApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			Log.Debug("OnCreate", "OnCreate called, Activity components are being created");

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.MainActivity);
		}

		protected override void OnStart()
		{
			Log.Debug("OnStart", "OnStart called, App is Active");
			base.OnStart();
		}

		protected override void OnResume()
		{
			Log.Debug("OnResume", "OnResume called, app is ready to interact with the user");
			base.OnResume();
		}

		protected override void OnPause()
		{
			Log.Debug("OnPause", "OnPause called, App is moving to background");
			base.OnPause();
		}

		protected override void OnStop()
		{
			Log.Debug("OnStop", "OnStop called, App is in the background");
			base.OnStop();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			Log.Debug("OnDestroy", "OnDestroy called, App is Terminating");
		}
	}
}

