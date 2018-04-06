using Foundation;
using FlyoutNavigation;
using System;
using UIKit;

namespace NavigationDraweSample
{
    public partial class MainNavigationController : UINavigationController
    {
        public MainNavigationController (IntPtr handle) : base (handle)
        {
        }
		//Responsible for opening/closing drawer:
		public void ToggleMenu()
		{
			if (ParentViewController is FlyoutNavigationController)
				(ParentViewController as FlyoutNavigationController).ToggleMenu();
		}
    }
}