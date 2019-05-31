using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WifiView
{
    public static class Utils
    {
        public static ListViewItem MakeKeyValueItem(string key, string value, ListViewGroup group)
        {
            ListViewItem item = new ListViewItem(key);
            item.Group = group;
            item.SubItems.Add(value);

            return item;
        }
    }
}
