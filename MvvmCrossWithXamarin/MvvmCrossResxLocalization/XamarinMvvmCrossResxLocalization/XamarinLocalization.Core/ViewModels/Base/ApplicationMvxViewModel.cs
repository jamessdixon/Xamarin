using System;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Localization;
using MvvmCross.Platform;
using XamarinLocalization.Core.ViewModels.Interfaces;

namespace XamarinLocalization.Core.ViewModels.Base
{
    public abstract class ApplicationMvxViewModel : MvxViewModel, IApplicationMvxViewModel
    {
        protected readonly IMvxNavigationService _navigationService;

        public MvxCommand CloseCommand => new MvxCommand(async () => await Close());

        public ApplicationMvxViewModel()
        {
            _navigationService = Mvx.Resolve<IMvxNavigationService>();
        }

        public virtual async Task Close()
        {
            await _navigationService.Close(this);
        }

        public async Task Navigate<TViewModel>() where TViewModel : IMvxViewModel
        {
            await _navigationService.Navigate<TViewModel>();
        }

        public async Task Navigate<TViewModel, TParameter>(TParameter param)
            where TViewModel : IMvxViewModel<TParameter>
            where TParameter : class
        {
            await _navigationService.Navigate<TViewModel, TParameter>(param);
        }

        public bool PresentationChanged(MvxPresentationHint presentationHint)
        {
            return ChangePresentation(presentationHint);
        }

        public IMvxLanguageBinder TextSource => new MvxLanguageBinder("", GetType().Name);
    }

    public abstract class ApplicationMvxViewModel<TInitParams> : ApplicationMvxViewModel,
        IMvxViewModel<TInitParams> where TInitParams : class
    {
        public virtual void Prepare(TInitParams parameter)
        {
        }
    }
}
