using System;
using Android.Graphics;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Support.V7.AppCompat;
using XamarinLocalization.Core.ViewModels.Base;

namespace XamarinLocalization.Andro.Views.Activities.Base
{
    public abstract class ApplicationMvxActivity<TViewModel, TInitParams> : ApplicationMvxActivity<TViewModel>
        where TViewModel : ApplicationMvxViewModel<TInitParams> where TInitParams : class
    {
    }

    public abstract class ApplicationMvxActivity<TViewModel> : MvxAppCompatActivity<TViewModel> 
        where TViewModel : ApplicationMvxViewModel
    {
        public abstract int LayoutId { get; }

        protected override void OnCreate(Bundle bundle)
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Window.ClearFlags(WindowManagerFlags.TranslucentStatus);
                Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
                Window.SetStatusBarColor(Resources.GetColor(Resource.Color.primaryDark));
            }

            base.OnCreate(bundle);
            var setup = MvxAndroidSetupSingleton.EnsureSingletonAvailable(ApplicationContext);
            setup.EnsureInitialized();
            SetContentView(LayoutId);
        }
    }
}
