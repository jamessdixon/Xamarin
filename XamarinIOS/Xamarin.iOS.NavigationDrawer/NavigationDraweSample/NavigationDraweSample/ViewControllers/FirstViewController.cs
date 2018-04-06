using Foundation;
using System;
using UIKit;
using FlyoutNavigation;
using MonoTouch.Dialog;

namespace NavigationDraweSample
{
    public partial class FirstViewController : UIViewController
    {
        public FirstViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			createNavigationFlyout();
		}

		void createNavigationFlyout()
		{
			var navigation = new FlyoutNavigationController
			{
				//Here are sections definied for the drawer:
				NavigationRoot = new RootElement("Navigation")
				{
						new Section ("Pages") 
						{
							new StringElement ("MainPage")
						}
				},

				//Here are controllers definied for the drawer (in this case navigation controller with one root):
				 ViewControllers = new[] 
					{
			     		(MainNavigationController)Storyboard.InstantiateViewController("MainNavigationController")
					}
			};

			View.AddSubview(navigation.View);
		}
    }
}