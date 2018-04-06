using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCrossDemo.Core.ViewModel;
using MvvmCrossDemo.Droid.Fragments.Base;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace MvvmCrossDemo.Droid.Fragments
{
    [Register("com.mvvmcross.demo.fragments.DetailsFragment")]
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    public class DetailsFragment : BaseMvxFragment<DetailsViewModel>
    {
        protected override int FragmentId => Resource.Layout.DetailsFragment;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var parentActivity = (MvxAppCompatActivity)Activity;
            parentActivity.SupportActionBar.Title = Resources.GetString(Resource.String.DetailsFragmentTitle);
            parentActivity.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            parentActivity.SupportActionBar.SetDisplayShowHomeEnabled(true);
            return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}