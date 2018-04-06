using MvvmCrossDemo.Core.Model;
using MvvmCrossDemo.Core.ViewModel;
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
    public class HomeViewModel : BaseApplicationMvxViewModel<UserData>
    {

        public IMvxCommand ShowDetails => new MvxCommand(async () =>
        {
            await Navigate<DetailsViewModel>();
        });

        private string _userName;
        public string Username
        {
            get { return _userName; }
            set
            {
                SetProperty(ref _userName, value);
            }
        }
        public HomeViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }

        public override Task Initialize(UserData userData)
        {
            Username = userData.Name;
            return base.Initialize(userData);
        }
    }
}
