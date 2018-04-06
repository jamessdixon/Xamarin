using MvvmCross.Uwp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossDemo.UWP.Configuration.Presenters
{
    // Extend MvxWindowsViewPresenter so you can so custom implementation:
    public class MvxUwpAppPresenter : MvxWindowsViewPresenter
    {
        public MvxUwpAppPresenter(IMvxWindowsFrame rootFrame) : base(rootFrame)
        {
        }
    }
}
