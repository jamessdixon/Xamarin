using System;
using System.Globalization;
using CoreGraphics;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views.Presenters.Attributes;
using MvvmCross.Localization;
using MvvmCross.Platform;
using UIKit;
using XamarinLocalization.Core.Localization;
using XamarinLocalization.Core.ViewModels.Initial;
using XamarinLocalization.iOS.Views.ViewControllers.Base;

namespace XamarinLocalization.iOS.Views.ViewControllers
{
    [MvxRootPresentation(WrapInNavigationController = false)]
    public class MainViewController : ApplicationBaseMvxViewController<MainViewModel>
    {
        UILabel _welcomeTextLabel;

        public MainViewController()
        {
        }

        public MainViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.White;

            _welcomeTextLabel = new UILabel(new CGRect(0, View.Frame.Height / 2, View.Frame.Width, 30));
            _welcomeTextLabel.TextAlignment = UITextAlignment.Center;
            View.Add(_welcomeTextLabel);

            SetupBindings();
        }

        private void SetupBindings()
        {
            var bindingSet = this.CreateBindingSet<MainViewController, MainViewModel>();

            bindingSet.Bind(_welcomeTextLabel).To(ViewModel => ViewModel.TextSource)
                      .WithConversion(new MvxLanguageConverter(), "WelcomeText");

            bindingSet.Apply();
        }
    }
}
