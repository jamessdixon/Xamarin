using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using MvvmCross.iOS.Views.Presenters;

namespace MvvmCrossDemo.iOS.Configuration.Presenters
{
    // Extend MvxIosViewPresenter so you can so custom implementation:
    public class MvxIosAppPresenter : MvxIosViewPresenter
    {
        public MvxIosAppPresenter(IUIApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
        {
        }
    }
}