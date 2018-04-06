using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace ToolbarExample
{
	[Activity(MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : AppCompatActivity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);

			var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
			SetSupportActionBar(toolbar);
			SupportActionBar.Title = "Hello from Appcompat Toolbar";
		}
	}
}


