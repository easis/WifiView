using NativeWifi;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace WifiView
{
    public static class Statistics
    {
        private static void AddStatisticConnectionInformation(ListView lst, WlanClient.WlanInterface wlanIface)
        {
            ListViewGroup group = new ListViewGroup("Connection");
            lst.Groups.Add(group);

            ListViewItem[] items =
            {
                Utils.MakeKeyValueItem("Channel", wlanIface.Channel.ToString(), group),
                Utils.MakeKeyValueItem("ConnectionMode", wlanIface.CurrentConnection.wlanConnectionMode.ToString(), group),
            };

            lst.Items.AddRange(items);
        }

        private static void AddStatisticPacketsInformation(ListView lst, WlanClient.WlanInterface wlanIface)
        {
            ListViewGroup group = new ListViewGroup("Packets");
            lst.Groups.Add(group);

            IPv4InterfaceStatistics interfaceStatistics = wlanIface.NetworkInterface.GetIPv4Statistics();
            ListViewItem[] items =
            {
                    Utils.MakeKeyValueItem("BytesReceived", Utils.BytesToString(interfaceStatistics.BytesReceived), group),
                    Utils.MakeKeyValueItem("BytesSent", Utils.BytesToString(interfaceStatistics.BytesSent), group),

                    Utils.MakeKeyValueItem("IncomingPacketsDiscarded", $"{interfaceStatistics.IncomingPacketsDiscarded}", group),
                    Utils.MakeKeyValueItem("IncomingPacketsWithErrors", $"{interfaceStatistics.IncomingPacketsWithErrors}", group),
                    Utils.MakeKeyValueItem("OutgoingPacketsDiscarded", $"{interfaceStatistics.OutgoingPacketsDiscarded}", group),
                    Utils.MakeKeyValueItem("OutgoingPacketsWithErrors", $"{interfaceStatistics.OutgoingPacketsWithErrors}", group),
            };

            lst.Items.AddRange(items);
        }

        private static void AddStatisticAddressesInformation(ListView lst, WlanClient.WlanInterface wlanIface)
        {
            ListViewGroup group = new ListViewGroup("Addresses");
            lst.Groups.Add(group);

            List<ListViewItem> items = new List<ListViewItem>();

            IPInterfaceProperties interfaceProperties = wlanIface.NetworkInterface.GetIPProperties();
            for (int i = 0; i < interfaceProperties.UnicastAddresses.Count; i++)
            {
                items.Add(
                    Utils.MakeKeyValueItem($"Addresses #{i}", $"{interfaceProperties.UnicastAddresses[i].Address.ToString()}", group)
                );
            }


            for (int i = 0; i < interfaceProperties.GatewayAddresses.Count; i++)
            {
                items.Add(
                    Utils.MakeKeyValueItem($"GatewayAddresses #{i}", $"{interfaceProperties.GatewayAddresses[i].Address.ToString()}", group)
                );
            }

            if (interfaceProperties.GetIPv4Properties().IsDhcpEnabled) {
                for (int i = 0; i < interfaceProperties.DhcpServerAddresses.Count; i++)
                {
                    items.Add(
                        Utils.MakeKeyValueItem($"DhcpServerAddress #{i}", $"{interfaceProperties.DhcpServerAddresses[i].ToString()}", group)
                    );
                }
            }

            for (int i = 0; i < interfaceProperties.DnsAddresses.Count; i++)
            {
                items.Add(
                    Utils.MakeKeyValueItem($"DnsAddress #{i}", $"{interfaceProperties.DnsAddresses[i].ToString()}", group)
                );
            }

            

            lst.Items.AddRange(items.ToArray());
        }

        public static void AddStatisticsInformation(ListView lst, WlanClient.WlanInterface wlanIface)
        {
            lst.Groups.Clear();
            lst.Items.Clear();

            if (wlanIface.InterfaceState == Wlan.WlanInterfaceState.Connected)
            {
                AddStatisticConnectionInformation(lst, wlanIface);
                AddStatisticPacketsInformation(lst, wlanIface);
                AddStatisticAddressesInformation(lst, wlanIface);
            }
            else
            {
                lst.Items.Add(Utils.MakeKeyValueItem("Status", wlanIface.InterfaceState.ToString()));
            }
        }
    }
}
