using System;
using System.Linq;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.Core;
using MvvmCross.Platform.IoC;
using MvvmCross.Platform.Logging;
using UIKit;
using XamarinLocalization.Core.Configuration.ApplicationSetup;

namespace XamarinLocalization.iOS.Configuration
{
    public class Setup : MvxIosSetup
    {

        public Setup(MvxApplicationDelegate appDelegate, IMvxIosViewPresenter presenter)
        : base(appDelegate, presenter)
        {

        }

        protected override IMvxApplication CreateApp() => new AppSetup();

        protected override MvxLogProviderType GetDefaultLogProviderType()             => MvxLogProviderType.None;
    }
}
