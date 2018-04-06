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
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCrossDemo.Droid.Configuration.Presenters;
using MvvmCross.Core.ViewModels;
using MvvmCrossDemo.Core;

namespace MvvmCrossDemo.Droid
{
    // MvxAndroidSetup should be extended:
    public class Setup: MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        // Create new App instance and register dependencies:
        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        // Create View Presenter for Android application: 
        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            //Create Android View Presenter object:
            var mvxFragmentsPresenter = new MvxAndroidAppPresenter(AndroidViewAssemblies);
            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentsPresenter);
            return mvxFragmentsPresenter;
        }

        // This code is required to be able to use some bindings with AppCompat:
        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            MvxAppCompatSetupHelper.FillTargetFactories(registry);
            base.FillTargetFactories(registry);
        }
    }
}