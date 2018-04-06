using System;
using System.Collections.Generic;
using System.Reflection;
using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using XamarinLocalization.Andro.Views.Activities;
using XamarinLocalization.Core.ViewModels.Initial;

namespace XamarinLocalization.Andro.Configuration.Presenters
{
    public class MvxAndroidAppPresenter : MvxAppCompatViewPresenter
    {
        public MvxAndroidAppPresenter(IEnumerable<Assembly> androidViewAssemblies) : base(androidViewAssemblies)
        {
        }

        protected override Intent CreateIntentForRequest(MvxViewModelRequest request)
        {
            var intent = base.CreateIntentForRequest(request);

            if (request.ViewModelType == typeof(MainViewModel) 
                && CurrentActivity.GetType() == typeof(LaunchScreenActivity))
                intent.AddFlags(ActivityFlags.ClearTask | ActivityFlags.NewTask);

            return intent;
        }
    }
}
