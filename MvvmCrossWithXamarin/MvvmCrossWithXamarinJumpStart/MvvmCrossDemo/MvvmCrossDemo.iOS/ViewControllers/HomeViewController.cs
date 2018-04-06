using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using MvvmCrossDemo.iOS.ViewControllers.Base;
using MvvmCrossDemo.Core.ViewModel;
using MvvmCrossDemo.Core.Model;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using CoreGraphics;

namespace MvvmCrossDemo.iOS.ViewControllers
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public class HomeViewController : ApplicationBaseMvxViewController<HomeViewModel, UserData>
    {
        private UILabel _helloLabel;
        private UILabel _userNameLabel;
        private UIButton _showDetailsButton;
        private UIImageView _mainImage;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SetupView();
            SetupBindings();
        }

        private void SetupView()
        {
            NavigationController.SetNavigationBarHidden(true, true);
            View.BackgroundColor = UIColor.White;

            _helloLabel = new UILabel();
            _helloLabel.Text = "Welcome to Mvvm Cross!";
            _helloLabel.TextColor = UIColor.Black;

            _userNameLabel = new UILabel();
            _userNameLabel.TextColor = UIColor.Black;

            _mainImage = new UIImageView();
            _mainImage.Image = UIImage.FromBundle("main_logo");
            _mainImage.Frame = new CGRect(0, 0, _mainImage.Image.CGImage.Width, _mainImage.Image.CGImage.Height);
            _mainImage.ContentMode = UIViewContentMode.ScaleAspectFit;

            _showDetailsButton = new UIButton(UIButtonType.RoundedRect);
            _showDetailsButton.SetTitle("Show details", UIControlState.Normal);
            _showDetailsButton.SetTitleColor(UIColor.White, UIControlState.Normal);
            _showDetailsButton.Font = UIFont.FromName("ArialMT", 15f);
            _showDetailsButton.BackgroundColor = UIColor.FromRGB(36, 183, 128);
            _showDetailsButton.Layer.BorderWidth = 1;
            _showDetailsButton.Layer.CornerRadius = 10;
            _showDetailsButton.Layer.BorderColor = UIColor.Black.CGColor;

            Add(_helloLabel);
            Add(_userNameLabel);
            Add(_mainImage);
            Add(_showDetailsButton);

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();


            View.AddConstraints(
                _userNameLabel.AtTopOf(View, 40),
                _userNameLabel.WithSameCenterX(View),
                _helloLabel.Below(_userNameLabel, 40),
                _helloLabel.WithSameCenterX(_userNameLabel),
                _mainImage.Below(_helloLabel, 40),
                              _mainImage.Height().EqualTo(70),
                              _mainImage.Width().EqualTo(70),
                              _mainImage.WithSameCenterX(_helloLabel),
                               _showDetailsButton.Below(_mainImage, 40),
                               _showDetailsButton.WithSameCenterX(_mainImage),
                               _showDetailsButton.AtLeftOf(View, 40),
                              _showDetailsButton.AtRightOf(View, 40)
                );
        }

        private void SetupBindings()
        {
            var bindingSet = this.CreateBindingSet<HomeViewController, HomeViewModel>();

            bindingSet.Bind(_showDetailsButton)
                .To(x => x.ShowDetails);

            bindingSet.Bind(_userNameLabel)
               .To(x => x.Username);

            bindingSet.Apply();
        }
    }
}