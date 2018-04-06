using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCrossDemo.Core.Model;
using MvvmCross.Core.ViewModels;
using MvvmCrossDemo.Core.ViewModel.Base;

namespace MvvmCrossDemo.Core.ViewModel
{
    public class LoginViewModel : BaseApplicationMvxViewModel
    {
        public IMvxCommand Login => new MvxCommand(async () => await SignIn());
        public bool CanSignIn => !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);

        private string _userName;
        public string Username
        {
            get { return _userName; }
            set
            {
                if (SetProperty(ref _userName, value))
                    RaisePropertyChanged(nameof(CanSignIn));
            }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (SetProperty(ref _password, value))
                    RaisePropertyChanged(nameof(CanSignIn));
            }
        }

        public LoginViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }


        private async Task SignIn()
        {
            System.Diagnostics.Debug.WriteLine("Sign in CLICKED");
            var userData = new UserData()
            {
                Name = Username
            };
            await Navigate<HomeViewModel, UserData>(userData);
        }

    }
}
