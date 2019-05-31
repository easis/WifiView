using NativeWifi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WifiView
{
    public static class InterfaceInfo
    {
        private static void AddDeviceInterfaceInformation(ListView lst, WlanClient.WlanInterface wlanIface)
        {
            ListViewGroup groupIface = new ListViewGroup("Interface");
            lst.Groups.Add(groupIface);

            ListViewItem[] ifaceItems =
            {
                Utils.MakeKeyValueItem("Name", wlanIface.InterfaceName, groupIface),
                Utils.MakeKeyValueItem("Description", wlanIface.InterfaceDescription, groupIface),
                Utils.MakeKeyValueItem("GUID", wlanIface.InterfaceGuid.ToString(), groupIface),
                Utils.MakeKeyValueItem("State", wlanIface.InterfaceState.ToString(), groupIface),
            };

            lst.Items.AddRange(ifaceItems);
        }

        private static void AddDeviceNetworkInformation(ListView lst, WlanClient.WlanInterface wlanIface)
        {
            ListViewGroup groupNetwork = new ListViewGroup("Network");
            lst.Groups.Add(groupNetwork);

            List<ListViewItem> networkItems = new List<ListViewItem>
            {
                Utils.MakeKeyValueItem("Name", wlanIface.NetworkInterface.Name, groupNetwork),
                Utils.MakeKeyValueItem("Description", wlanIface.NetworkInterface.Description, groupNetwork),
                Utils.MakeKeyValueItem("MAC", wlanIface.NetworkInterface.GetPhysicalAddress().ToString(), groupNetwork),
                Utils.MakeKeyValueItem("Status", wlanIface.NetworkInterface.OperationalStatus.ToString(), groupNetwork),
                Utils.MakeKeyValueItem("Id", wlanIface.NetworkInterface.Id, groupNetwork),
                Utils.MakeKeyValueItem("Type", wlanIface.NetworkInterface.NetworkInterfaceType.ToString(), groupNetwork),
                Utils.MakeKeyValueItem("Supports multicast?", wlanIface.NetworkInterface.SupportsMulticast ? "YES" : "NO", groupNetwork),
            };

            if (wlanIface.NetworkInterface.Speed > 0)
            {
                networkItems.Add(
                    Utils.MakeKeyValueItem("Speed", $"{(wlanIface.NetworkInterface.Speed / 1000000)}  Mbps", groupNetwork)
                );
            }

            lst.Items.AddRange(networkItems.ToArray());
        }

        public static void AddDeviceInformation(ListView lst, WlanClient.WlanInterface wlanIface)
        {
            lst.Groups.Clear();
            lst.Items.Clear();

            AddDeviceNetworkInformation(lst, wlanIface);
            AddDeviceInterfaceInformation(lst, wlanIface);
        }
    }
}
