using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using MvvmCross.iOS.Views.Presenters.Attributes;
using MvvmCrossDemo.iOS.ViewControllers.Base;
using MvvmCrossDemo.Core.ViewModel;
using MvvmCrossDemo.Core.Model;
using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using CoreGraphics;

namespace MvvmCrossDemo.iOS.ViewControllers
{
    [MvxModalPresentation]
    public class DetailsViewController : ApplicationBaseMvxViewController<DetailsViewModel>
    {
        private UILabel _welcomeLabel;
        private UIButton _dismissButton;
        private UIImageView _mainImage;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SetupView();
            SetupBindings();
        }

        private void SetupView()
        {
            View.BackgroundColor = UIColor.White;

            _welcomeLabel = new UILabel();
            _welcomeLabel.Text = "Congratulations! You found secret ingredient!";
            _welcomeLabel.Font = UIFont.FromName("ArialMT", 12f);
            _welcomeLabel.TextColor = UIColor.Black;

            _mainImage = new UIImageView();
            _mainImage.Image = UIImage.FromBundle("details_logo");
            _mainImage.Frame = new CGRect(0, 0, _mainImage.Image.CGImage.Width, _mainImage.Image.CGImage.Height);
            _mainImage.ContentMode = UIViewContentMode.ScaleAspectFit;

            _dismissButton = new UIButton(UIButtonType.RoundedRect);
            _dismissButton.SetTitle("Dismiss", UIControlState.Normal);
            _dismissButton.Font = UIFont.FromName("HelveticaNeue-Bold", 15f);
            _dismissButton.SetTitleColor(UIColor.FromRGB(36, 183, 128), UIControlState.Normal);

            Add(_welcomeLabel);
            Add(_mainImage);
            Add(_dismissButton);

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();


            View.AddConstraints(
                _welcomeLabel.WithSameCenterY(View),
                _welcomeLabel.WithSameCenterX(View),

                _mainImage.Below(_welcomeLabel, 20),
                              _mainImage.Height().EqualTo(70),
                              _mainImage.Width().EqualTo(70),
                              _mainImage.WithSameCenterX(_welcomeLabel),
                _dismissButton.AtBottomOf(View, 40),
                                _dismissButton.WithSameCenterX(_mainImage),
                                _dismissButton.AtLeftOf(View, 40),
                               _dismissButton.AtRightOf(View, 40)
                );
        }

        private void SetupBindings()
        {
            var bindingSet = this.CreateBindingSet<DetailsViewController, DetailsViewModel>();

            bindingSet.Bind(_dismissButton)
                .To(x => x.Dismiss);

            bindingSet.Apply();
        }
    }
}