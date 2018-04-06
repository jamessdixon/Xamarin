using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using MvvmCross.iOS.Views;
using MvvmCrossDemo.Core.ViewModel;
using MvvmCrossDemo.Core.ViewModel.Base;

namespace MvvmCrossDemo.iOS.ViewControllers.Base
{
    public abstract class ApplicationBaseMvxViewController<TViewModel, TInitParams> : ApplicationBaseMvxViewController<TViewModel> where TViewModel : BaseApplicationMvxViewModel<TInitParams> where TInitParams : class
    {
    }

    public abstract class ApplicationBaseMvxViewController<TViewModel> : MvxViewController<TViewModel> where TViewModel : BaseApplicationMvxViewModel
    {
    }
}