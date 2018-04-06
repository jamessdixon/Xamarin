using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCrossDemo.Core.ViewModel;
using MvvmCross.Droid.Platform;
using System.Threading.Tasks;
using MvvmCrossDemo.Core.ViewModel.Base;

namespace MvvmCrossDemo.Droid.Activities.Base
{
    public abstract class BaseApplicationMvxFragmentActivity<TViewModel, TInitParams> : BaseApplicationMvxFragmentActivity<TViewModel> where TViewModel : BaseApplicationMvxViewModel<TInitParams> where TInitParams : class
    {
    }

    public abstract class BaseApplicationMvxFragmentActivity<TViewModel> : MvxCachingFragmentCompatActivity<TViewModel> where TViewModel : BaseApplicationMvxViewModel
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