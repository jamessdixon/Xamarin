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
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Platform;
using MvvmCrossDemo.Core.ViewModel;
using MvvmCrossDemo.Core.ViewModel.Base;

namespace MvvmCrossDemo.Droid.Activities.Base
{
    public abstract class BaseApplicationMvxActivity<TViewModel, TInitParams> : BaseApplicationMvxActivity<TViewModel> where TViewModel : BaseApplicationMvxViewModel<TInitParams> where TInitParams : class
    {
    }

    public abstract class BaseApplicationMvxActivity<TViewModel> : MvxAppCompatActivity<TViewModel> where TViewModel : BaseApplicationMvxViewModel
    {
        public abstract int LayoutId { get; }
        public virtual int LayoutRootId => Resource.Id.LayoutRoot;

        protected override void OnCreate(Bundle bundle)
        {
            var setup = MvxAndroidSetupSingleton.EnsureSingletonAvailable(ApplicationContext);
            setup.EnsureInitialized();
            base.OnCreate(bundle);
            SetContentView(LayoutId);
        }
    }
}