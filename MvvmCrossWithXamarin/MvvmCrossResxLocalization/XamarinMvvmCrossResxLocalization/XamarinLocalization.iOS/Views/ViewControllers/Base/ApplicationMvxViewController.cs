using System;
using MvvmCross.iOS.Views;
using XamarinLocalization.Core.ViewModels.Base;

namespace XamarinLocalization.iOS.Views.ViewControllers.Base
{
    public abstract class ApplicationMvxViewController<TViewModel, TInitParams> 
        : ApplicationBaseMvxViewController<TViewModel> 
            where TViewModel : ApplicationMvxViewModel<TInitParams>
                where TInitParams : class
    {
    }

    public abstract class ApplicationBaseMvxViewController<TViewModel> 
        : MvxViewController<TViewModel>
            where TViewModel : ApplicationMvxViewModel
    {

        public ApplicationBaseMvxViewController()
        {
        }

        public ApplicationBaseMvxViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }
    }
}
