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
using MvvmCrossDemo.Droid.Fragments.Base;
using MvvmCrossDemo.Core.ViewModel;
using MvvmCrossDemo.Core.Model;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace MvvmCrossDemo.Droid.Fragments
{
    [Register("com.mvvmcross.demo.fragments.HomeFragment")]
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
    public class HomeFragment : BaseMvxFragment<HomeViewModel, UserData>
    {
        protected override int FragmentId => Resource.Layout.HomeFragment;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var parentActivity = (MvxAppCompatActivity)Activity;
            parentActivity.SupportActionBar.Title = Resources.GetString(Resource.String.HomeFragmentTitle);
            parentActivity.SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            parentActivity.SupportActionBar.SetDisplayShowHomeEnabled(false);
            return base.OnCreateView(inflater, container, savedInstanceState);
        }

    }
}