using System;
using Realms;
using UIKit;

namespace XamarinRealm
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();

		}

		private void addNewCar()
		{
			var realm = Realm.GetInstance();
			realm.Write(() =>
			 {
				 var newCar = realm.CreateObject<Car>();
				 newCar.Brand = CarBrandTextField.Text;
				 newCar.Model = CarModelTextField.Text;
			 });
			var cars = realm.All<Car>();
			InfoLabel.Text = "Count cars: " + cars.Count();
			CarModelTextField.ResignFirstResponder();

		}

		partial void AddCarButtonClick(UIButton sender)
		{

			addNewCar();
		}
	}
}

