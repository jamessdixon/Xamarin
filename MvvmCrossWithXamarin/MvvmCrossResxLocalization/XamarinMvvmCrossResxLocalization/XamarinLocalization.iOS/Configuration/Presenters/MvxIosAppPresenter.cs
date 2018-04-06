using System;
using MvvmCross.iOS.Views.Presenters;
using UIKit;

namespace XamarinLocalization.iOS.Configuration.Presenters
{
    public class MvxIosAppPresenter : MvxIosViewPresenter
    {
        public MvxIosAppPresenter(IUIApplicationDelegate applicationDelegate, UIWindow window) 
            : base(applicationDelegate, window)
        {
        }
    }
}
