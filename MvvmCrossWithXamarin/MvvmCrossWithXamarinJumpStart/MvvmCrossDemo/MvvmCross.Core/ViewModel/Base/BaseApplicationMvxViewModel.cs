using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCrossDemo.Core.ViewModel.Interfaces;

namespace MvvmCrossDemo.Core.ViewModel.Base
{

    //Base class for each ViewModel without initial parameter:
    public abstract class BaseApplicationMvxViewModel : MvxViewModel, IBaseApplicationMvxViewModel
    {
        protected readonly IMvxNavigationService _navigationService;

        //Dependency injection to get navigation service:
        public BaseApplicationMvxViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        //Method to navigate to other ViewModel without passing any parameters:
        public async Task Navigate<TViewModel>() where TViewModel : IMvxViewModel
        {
            await _navigationService.Navigate<TViewModel>();
        }


        //Method to navigate to other ViewModel with option to pass a parameter:
        public async Task Navigate<TViewModel, TParameter>(TParameter param)
            where TViewModel : IMvxViewModel<TParameter>
            where TParameter : class
        {
            await _navigationService.Navigate<TViewModel, TParameter>(param);
        }

        // Method responsible for closing ViewModel:
        public async Task Close()
        {
            await _navigationService.Close(this);
        }

        //Method responsible for handling Presentation Hints during navigation:
        public bool PresentationChanged(MvxPresentationHint presentationHint)
        {
            return ChangePresentation(presentationHint);
        }
    }

    //Base class for each ViewModel which requires initial parameter (it extends BaseApplicationMvxViewModel class written above):
    public abstract class BaseApplicationMvxViewModel<TInitParams> : BaseApplicationMvxViewModel, IMvxViewModel<TInitParams> where TInitParams : class
    {
        public BaseApplicationMvxViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }

        // Access passed parameter:
        public virtual Task Initialize(TInitParams parameter)
        {
            return Task.FromResult(true);
        }
    }

}
