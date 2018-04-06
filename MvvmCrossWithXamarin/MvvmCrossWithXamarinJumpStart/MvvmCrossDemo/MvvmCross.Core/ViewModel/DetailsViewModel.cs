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
    public class DetailsViewModel : BaseApplicationMvxViewModel
    {
        public IMvxCommand Dismiss => new MvxCommand(async () => await Close());

        public DetailsViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }
    }
}
