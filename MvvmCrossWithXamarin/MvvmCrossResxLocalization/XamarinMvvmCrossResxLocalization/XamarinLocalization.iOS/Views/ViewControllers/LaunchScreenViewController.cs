using System;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using UIKit;
using XamarinLocalization.Core.ViewModels.Initial;

namespace XamarinLocalization.iOS.Views.ViewControllers
{
    [MvxRootPresentation(WrapInNavigationController = false)]
    public class LaunchScreenViewController : MvxViewController<LaunchScreenViewModel>
    {
        public LaunchScreenViewController()
        {
        }

        public LaunchScreenViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.DarkGray;
        }
    }
}
