using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MvvmCrossDemo.Core.Configuration.Startup;
using MvvmCrossDemo.Core.Infrastructure.Services;
using MvvmCrossDemo.Core.Infrastructure.Services.Interfaces;
using MvvmCrossDemo.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossDemo.Core
{
    // McxApplication should be extended:
    public class App : MvxApplication
    {

        private void ConfigureIoC()
        {
            Mvx.RegisterType<IAuthenticationService, AuthenticationService>();
        }

        public override void Initialize()
        {
            base.Initialize();

            ConfigureIoC();

            // We can change login state to see control navigation flow:
            Mvx.Resolve<IAuthenticationService>().LoggedIn = false;
            //Register extended app startup in IoC container:
            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, MvxAppExtendedStart>();
            var appStart = Mvx.Resolve<IMvxAppStart>();
            // register the appstart object:
            RegisterAppStart(appStart);
        }
    }
}
