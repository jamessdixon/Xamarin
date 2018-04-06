using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using MvvmCross.Droid.Support.V7.AppCompat;
using XamarinLocalization.Core.ViewModels.Initial;

namespace XamarinLocalization.Andro.Views.Activities
{
    [Register("com.mobileprogrammer.XamarinMvvmCross_Andro.views.activities.LaunchScreenActivity")]
    [Activity(Label = "XamarinMvvmCross", ClearTaskOnLaunch = true, MainLauncher = true, NoHistory = true,
              LaunchMode = LaunchMode.SingleTask, Theme = "@style/Theme.Launch")]
    public class LaunchScreenActivity : MvxAppCompatActivity<LaunchScreenViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }
    }
}
