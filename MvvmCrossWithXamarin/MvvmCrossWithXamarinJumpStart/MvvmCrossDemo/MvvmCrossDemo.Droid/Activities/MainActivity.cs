using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCrossDemo.Core.ViewModel;
using MvvmCrossDemo.Droid.Activities.Base;

namespace MvvmCrossDemo.Droid.Activities
{
    [Register("com.mvvmcross.demo.activities.MainActivity")]
    [Activity(Label = "MainActivity")]
    public class MainActivity : BaseApplicationMvxFragmentActivity<MainViewModel>
    {
        public override int LayoutId => Resource.Layout.MainActivity;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var myToolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(myToolbar);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Android.Resource.Id.Home)
            {
                OnBackPressed();
                return true;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}