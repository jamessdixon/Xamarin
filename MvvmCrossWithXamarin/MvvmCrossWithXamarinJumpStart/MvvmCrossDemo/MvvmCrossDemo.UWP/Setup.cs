using MvvmCross.Core.ViewModels;
using MvvmCross.Uwp.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using MvvmCross.Uwp.Views;
using MvvmCross.Platform;
using MvvmCrossDemo.UWP.Configuration.Presenters;

namespace MvvmCrossDemo.UWP
{
    // MvxWindowsSetup should be extended:
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new MvvmCrossDemo.Core.App();
        }

        // Create View Presenter for UWP application: 
        protected override IMvxWindowsViewPresenter CreateViewPresenter(IMvxWindowsFrame rootFrame)
        {
            //Create UWP View Presenter object:
            var mvxUwpPresenter = new MvxUwpAppPresenter(rootFrame);
            return mvxUwpPresenter;
        }
    }
}
