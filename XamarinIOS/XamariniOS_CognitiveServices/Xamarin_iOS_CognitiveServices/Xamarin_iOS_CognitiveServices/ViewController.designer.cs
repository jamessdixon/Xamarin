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

namespace Xamarin_iOS_CognitiveServices
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel AnalysisLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SelectButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView SelectedPictureImageView { get; set; }

        [Action ("SelectButtonClick:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SelectButtonClick (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AnalysisLabel != null) {
                AnalysisLabel.Dispose ();
                AnalysisLabel = null;
            }

            if (SelectButton != null) {
                SelectButton.Dispose ();
                SelectButton = null;
            }

            if (SelectedPictureImageView != null) {
                SelectedPictureImageView.Dispose ();
                SelectedPictureImageView = null;
            }
        }
    }
}