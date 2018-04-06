
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace LifecycleApp
{
	public class MainFragment : Fragment
	{
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your fragment here
			// You should initialize essential components of the fragment
			// that you want to retain when the fragment is paused or stopped, then resumed.
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// The system calls this when it's time for the fragment to draw its user interface for the first time.

			var mainView = inflater.Inflate(Resource.Layout.MainFragment, container, false);
			return mainView;
		}

		public override void OnPause()
		{
			// The system calls this method as the first indication that the user is leaving the fragment 

			base.OnPause();
		}
	}
}
