using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System.Linq;

namespace ExpandableListDemo
{
    [Activity(Label = "ExpandableListDemo", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    public class MainActivity : Activity
    {

        ExpandableListView _menuExpandableListView;
        ExpandableMenuListAdapter _menuListAdapter;
        Dictionary<MenuItem, List<MenuSubItem>> _menuictionary;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            _menuExpandableListView = FindViewById<ExpandableListView>(Resource.Id.MenuExpandableListView);
            _menuExpandableListView.GroupClick += (s, e) =>
              {
                  Console.WriteLine(_menuictionary.ElementAt(e.GroupPosition).Key.Name);
              };
            _menuExpandableListView.ChildClick += (s, e)=>
            {
                MenuSubItem clickedSubItem = (MenuSubItem) _menuListAdapter.GetChild(e.GroupPosition, e.ChildPosition);
                Console.WriteLine(clickedSubItem.Name);
            };
            MenuItem menuItem = new MenuItem { Name = "Home" };
            MenuItem menuItem2 = new MenuItem { Name = "Ashghal" };
            MenuItem menuItem3 = new MenuItem { Name = "Contact us" };

            _menuictionary = new Dictionary<MenuItem, List<MenuSubItem>>()
            {
                {menuItem, new List<MenuSubItem> { new MenuSubItem { Name = "SubItem1", Drawable = Resource.Drawable.Icon}, new MenuSubItem { Name = "SubItem2", Drawable = Resource.Drawable.Icon } } },
                {menuItem2, new List<MenuSubItem> { new MenuSubItem { Name = "SubItem3", Drawable = Resource.Drawable.Icon}, new MenuSubItem { Name = "SubItem4", Drawable = Resource.Drawable.Icon } } },
                {menuItem3, new List<MenuSubItem> { new MenuSubItem { Name = "SubItem5", Drawable = Resource.Drawable.Icon}, new MenuSubItem { Name = "SubItem6", Drawable = Resource.Drawable.Icon } } }
            };

            _menuListAdapter = new ExpandableMenuListAdapter(this, _menuictionary);
            _menuExpandableListView.SetAdapter(_menuListAdapter);
        }

    }
}

