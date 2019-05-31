using NativeWifi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WifiView
{
    public static class Utils
    {
        public static ListViewItem MakeKeyValueItem(string key, string value, ListViewGroup group = null)
        {
            ListViewItem item = new ListViewItem(key);            
            item.SubItems.Add(value);
            if(group != null)
            {
                item.Group = group;
            }

            return item;
        }

        public static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }

        // https://stackoverflow.com/a/21450118
        public static String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }
    }
}
