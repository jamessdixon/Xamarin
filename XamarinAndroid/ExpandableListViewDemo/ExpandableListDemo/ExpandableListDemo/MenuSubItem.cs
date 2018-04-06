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

namespace ExpandableListDemo
{
    class MenuSubItem: Java.Lang.Object
    {
        public string Name { get; set; }
        public int Drawable { get; set; }
    }
}