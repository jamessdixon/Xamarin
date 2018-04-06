using MvvmCross.Uwp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCrossDemo.Core.ViewModel;
using MvvmCrossDemo.Core.ViewModel.Base;

namespace MvvmCrossDemo.UWP.Pages.Base
{

    public abstract class BaseApplicationMvxActivity<TViewModel, TInitParams> : BaseApplicationMvxPage<TViewModel> where TViewModel : BaseApplicationMvxViewModel<TInitParams> where TInitParams : class
    {
    }

    public abstract class BaseApplicationMvxPage<TViewModel> : MvxWindowsPage<TViewModel> where TViewModel : BaseApplicationMvxViewModel
    {

    }
}
