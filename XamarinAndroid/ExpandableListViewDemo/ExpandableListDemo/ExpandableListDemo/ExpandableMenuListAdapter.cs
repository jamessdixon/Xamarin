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
using Java.Lang;

namespace ExpandableListDemo
{
    class ExpandableMenuListAdapter : BaseExpandableListAdapter
    {

        Activity _context;
        List<MenuSubItem> _dataList { get; set; }
        Dictionary<MenuItem, List<MenuSubItem>> _menuictionary;

        public ExpandableMenuListAdapter(Activity newContext, Dictionary<MenuItem, List<MenuSubItem>> menuItemsDictionary)
            : base()
        {
            _context = newContext;
            _dataList = new List<MenuSubItem>();
            _menuictionary = menuItemsDictionary;
        }

        public override int GroupCount
        {
            get
            {
                return _menuictionary.Keys.Count;
            }
        }

        public override bool HasStableIds
        {
            get
            {
                return true;
            }
        }

        public override Java.Lang.Object GetChild(int groupPosition, int childPosition)
        {
            return _menuictionary[_menuictionary.ElementAt(groupPosition).Key].ElementAt(childPosition);
        }

        public override long GetChildId(int groupPosition, int childPosition)
        {
            return childPosition;
        }

        public override int GetChildrenCount(int groupPosition)
        {

            _dataList = _menuictionary[_menuictionary.ElementAt(groupPosition).Key];

            return _dataList.Count;
        }

        public override View GetChildView(int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
        {
            HeaderSubItemHolder headerSubItemHolder;
            View row = convertView;
            if (row == null)
            {
                row = _context.LayoutInflater.Inflate(Resource.Layout.CustomMenuSubRow, null);
                headerSubItemHolder = new HeaderSubItemHolder(row.FindViewById<ImageView>(Resource.Id.MenuSubItem_ImageView), row.FindViewById<TextView>(Resource.Id.MenuSubItem_TextView));
                row.Tag = headerSubItemHolder;
            }
            else
                headerSubItemHolder = (HeaderSubItemHolder)row.Tag;

            headerSubItemHolder.SubMenuItem_TextView.Text = _menuictionary[_menuictionary.ElementAt(groupPosition).Key][childPosition].Name;
            return row;
        }

        public override Java.Lang.Object GetGroup(int groupPosition)
        {
            return _menuictionary.Keys.ElementAt(groupPosition);
        }

        public override long GetGroupId(int groupPosition)
        {
            return groupPosition;
        }

        public override View GetGroupView(int groupPosition, bool isExpanded, View convertView, ViewGroup parent)
        {
            HeaderItemHolder headerHolder;
            View header = convertView;
            ExpandableListView menuExpandableListView = (ExpandableListView)parent;
            if (header == null)
            {
                header = _context.LayoutInflater.Inflate(Resource.Layout.CustomMenuHeaderRow, null);
                headerHolder = new HeaderItemHolder(header.FindViewById<ImageView>(Resource.Id.MenuHeader_ImageView), header.FindViewById<TextView>(Resource.Id.MenuHeader_TextView), header.FindViewById<ImageView>(Resource.Id.MenuHeaderIndicator_ImageView));
                header.Tag = headerHolder;
            }
            else
                headerHolder = (HeaderItemHolder)header.Tag;


            if (groupPosition < _menuictionary.Keys.Count)
            {
                headerHolder.MenuHeaderIndicator_ImageView.Touch += (s, e) =>
                {

                    switch (_menuictionary.ElementAt(groupPosition).Key.Expanded)
                    {
                        case true:
                            menuExpandableListView.CollapseGroup(groupPosition);
                            _menuictionary.ElementAt(groupPosition).Key.Expanded = false;
                            headerHolder.MenuHeaderIndicator_ImageView.SetImageResource(Resource.Drawable.ic_down);
                            break;
                        case false:
                            menuExpandableListView.ExpandGroup(groupPosition);
                            _menuictionary.ElementAt(groupPosition).Key.Expanded = true;
                            headerHolder.MenuHeaderIndicator_ImageView.SetImageResource(Resource.Drawable.ic_up);
                            break;
                        default:
                            break;
                    }
                };
            }

            return header;
        }

        public override bool IsChildSelectable(int groupPosition, int childPosition)
        {
            return true;
        }
    }

    public class HeaderItemHolder : Java.Lang.Object
    {
        public ImageView MenuHeader_ImageView;
        public TextView MenuHeader_TextView;
        public ImageView MenuHeaderIndicator_ImageView;


        public HeaderItemHolder(ImageView menuHeader_ImageView, TextView menuHeader_TextView, ImageView menuHeaderIndicator_ImageView)
        {
            MenuHeader_ImageView = menuHeader_ImageView;
            MenuHeader_ImageView.SetImageResource(Resource.Drawable.Icon);
            MenuHeader_TextView = menuHeader_TextView;
            MenuHeaderIndicator_ImageView = menuHeaderIndicator_ImageView;
        }
    }

    public class HeaderSubItemHolder : Java.Lang.Object
    {
        public ImageView SubMenuItem_ImageView;
        public TextView SubMenuItem_TextView;


        public HeaderSubItemHolder(ImageView menuHeader_ImageView, TextView menuHeader_TextView)
        {
            SubMenuItem_ImageView = menuHeader_ImageView;
            SubMenuItem_ImageView.SetImageResource(Resource.Drawable.Icon);
            SubMenuItem_TextView = menuHeader_TextView;
        }
    }
}