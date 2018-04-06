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
using MvvmCrossDemo.Core.ViewModel;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCrossDemo.Core.ViewModel.Base;

namespace MvvmCrossDemo.Droid.Fragments.Base
{
    public abstract class BaseMvxFragment<TViewModel, TInitParams> : BaseMvxFragment<TViewModel>
        where TViewModel : BaseApplicationMvxViewModel<TInitParams> where TInitParams : class
    {

    }

    public abstract class BaseMvxFragment<TViewModel> : MvxFragment<TViewModel>
    where TViewModel : BaseApplicationMvxViewModel
    {
        protected abstract int FragmentId { get; }

        public MvxCachingFragmentCompatActivity ParentActivity
        {
            get
            {
                return ((MvxCachingFragmentCompatActivity)Activity);
            }
        }

        public new TViewModel ViewModel
        {
            get { return base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(FragmentId, null);

            return view;
        }
    }

}