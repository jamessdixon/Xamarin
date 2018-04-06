using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCrossDemo.Droid.Activities.Base;
using MvvmCrossDemo.Core.ViewModel;
using Android.Content.PM;

namespace MvvmCrossDemo.Droid.Activities
{
    [Activity(ClearTaskOnLaunch = true, LaunchMode = LaunchMode.SingleTask)]
    [Register("com.mvvmcross.demo.activities.LoginActivity")]
    public class LoginActivity: BaseApplicationMvxActivity<LoginViewModel>
    {
        public override int LayoutId => Resource.Layout.LoginActivity;

        public LoginActivity()
        {

        }
    }
}