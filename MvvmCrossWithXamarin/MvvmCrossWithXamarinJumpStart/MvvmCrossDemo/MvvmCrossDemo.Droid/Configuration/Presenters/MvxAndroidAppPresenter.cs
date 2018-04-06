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
using MvvmCross.Droid.Shared.Presenter;
using System.Reflection;
using MvvmCross.Core.ViewModels;
using MvvmCrossDemo.Core.ViewModel;
using MvvmCrossDemo.Droid.Activities;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Graphics;

namespace MvvmCrossDemo.Droid.Configuration.Presenters
{
    public class MvxAndroidAppPresenter : MvxFragmentsPresenter
    {
        //Extend default constructor which register all Android views available in the application:
        public MvxAndroidAppPresenter(IEnumerable<Assembly> androidViewAssemblies) : base(androidViewAssemblies) { }

        // This method helps configure some system preferences like animaton when navigating from splash screen to login screen:
        protected override Intent CreateIntentForRequest(MvxViewModelRequest request)
        {
            var intent = base.CreateIntentForRequest(request);

            if (request.ViewModelType == typeof(LoginViewModel) && Activity.GetType() == typeof(SplashActivity))
                intent.AddFlags(ActivityFlags.NoAnimation);

            if (request.ViewModelType == typeof(MainViewModel) || request.ViewModelType == typeof(LoginViewModel))
                intent.AddFlags(ActivityFlags.ClearTask);

            return intent;
        }
    }
}