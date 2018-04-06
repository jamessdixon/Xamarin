using System;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using XamarinLocalization.Core.ViewModels.Initial;

namespace XamarinLocalization.Core.Configuration.ApplicationSetup
{
    public class MvxAppExtendedStart : IMvxAppStart
    {
        private readonly IMvxNavigationService _navigationService;

        public MvxAppExtendedStart(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void Start(object hint = null)
        {
            _navigationService.Navigate<LaunchScreenViewModel>();
        }
    }
}
