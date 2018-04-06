using System;
using System.Threading.Tasks;
using XamarinLocalization.Core.ViewModels.Base;

namespace XamarinLocalization.Core.ViewModels.Initial
{
    public class LaunchScreenViewModel : ApplicationMvxViewModel
    {

        public LaunchScreenViewModel()
        {
        }

        public async override void ViewAppeared()
        {
            base.ViewAppeared();
            await Task.Delay(2000);
            await _navigationService.Navigate<MainViewModel>();
        }
    }
}
