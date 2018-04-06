using System;
using CoreGraphics;
using UIKit;

namespace NavigationDraweSample
{
	public partial class NavigationDrawerController : UIViewController
	{
		public NavigationDrawerController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			NavigationItem.LeftBarButtonItem = getMenuItem();
			NavigationItem.RightBarButtonItem = new UIBarButtonItem { Width = 40 };
		}

		UIBarButtonItem getMenuItem()
		{
			var item = new UIBarButtonItem();
			item.Width = 40;
			item.Image = UIImage.FromFile("Images/menu_button@2x.png");
			item.Clicked += (sender, e) =>
			{
				if (ParentViewController is MainNavigationController)
					(ParentViewController as MainNavigationController).ToggleMenu();
			};

			return item;
		}
	}
}


