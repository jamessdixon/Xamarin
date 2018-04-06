using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Localization;
using MvvmCross.Platform;
using MvvmCross.Plugins.ResxLocalization;
using XamarinLocalization.Core.Localization;

namespace XamarinLocalization.Core.Configuration.ApplicationSetup
{
    public class AppSetup : MvxApplication
    {
        public AppSetup()
        {
        }

        public override void Initialize()
        {
            base.Initialize();

            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, MvxAppExtendedStart>();

            Mvx.RegisterSingleton<IMvxTextProvider>(new MvxResxTextProvider(AppResources.ResourceManager));

            RegisterCustomAppStart<MvxAppExtendedStart>();
        }
    }
}
