
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinLocalization.Andro.Views.Activities.Base;
using XamarinLocalization.Core.Localization;
using XamarinLocalization.Core.ViewModels.Initial;

namespace XamarinLocalization.Andro.Views.Activities
{
    [Register("com.mobileprogrammer.XamarinMvvmCross_Andro.views.activities.MainActivity")]
    [Activity(ClearTaskOnLaunch = true, LaunchMode = LaunchMode.SingleTask)]
    public class MainActivity : ApplicationMvxActivity<MainViewModel>
    {
        public override int LayoutId => Resource.Layout.main_activity;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
        }
    }
}
