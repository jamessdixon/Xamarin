// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinRealm
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddCarButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField CarBrandTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField CarModelTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel InfoLabel { get; set; }

        [Action ("AddCarButtonClick:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AddCarButtonClick (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AddCarButton != null) {
                AddCarButton.Dispose ();
                AddCarButton = null;
            }

            if (CarBrandTextField != null) {
                CarBrandTextField.Dispose ();
                CarBrandTextField = null;
            }

            if (CarModelTextField != null) {
                CarModelTextField.Dispose ();
                CarModelTextField = null;
            }

            if (InfoLabel != null) {
                InfoLabel.Dispose ();
                InfoLabel = null;
            }
        }
    }
}