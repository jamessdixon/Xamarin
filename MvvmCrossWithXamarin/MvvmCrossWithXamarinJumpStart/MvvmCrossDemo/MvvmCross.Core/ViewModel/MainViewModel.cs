using MvvmCrossDemo.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCrossDemo.Core.ViewModel.Base;

namespace MvvmCrossDemo.Core.ViewModel
{
    public class MainViewModel : BaseApplicationMvxViewModel
    {
        public MainViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }
    }
}
