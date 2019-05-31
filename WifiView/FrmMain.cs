using NativeWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WifiView
{
    public partial class FrmMain : Form
    {
        private WlanClient wClient;
        public FrmMain()
        {
            this.wClient = wClient = new WlanClient();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddInterfacesToList();
        }

        private void AddInterfacesToList()
        {
            foreach (WlanClient.WlanInterface wlanIface in this.wClient.Interfaces)
            {
                ListViewItem item = new ListViewItem();
                item.Text = wlanIface.InterfaceName;
                item.Tag = wlanIface;
                lstInterfaces.Items.Add(item);

            }
        }

        private void MnuInterfacesReload_Click(object sender, EventArgs e)
        {
            lstInterfaces.Items.Clear();
            AddInterfacesToList();
        }

        private void LstInterfaces_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(lstInterfaces.SelectedItems.Count > 0)
            {
                ListViewItem item = lstInterfaces.SelectedItems[0];
                if(item.Tag != null && item.Tag.GetType() == typeof(WlanClient.WlanInterface))
                {
                    AddDeviceInformation(item.Tag as WlanClient.WlanInterface);
                }
            }
        }

        private ListViewItem MakeKeyValueItem(string key, string value, ListViewGroup group)
        {
            ListViewItem item = new ListViewItem(key);
            item.Group = group;
            item.SubItems.Add(value);

            return item;
        }

        private void AddDeviceInterfaceInformation(WlanClient.WlanInterface wlanIface)
        {
            ListViewGroup groupIface = new ListViewGroup("Interface");
            lstInterfaceInformation.Groups.Add(groupIface);

            ListViewItem[] ifaceItems =
            {
                MakeKeyValueItem("Name", wlanIface.InterfaceName, groupIface),
                MakeKeyValueItem("Description", wlanIface.InterfaceDescription, groupIface),
                MakeKeyValueItem("GUID", wlanIface.InterfaceGuid.ToString(), groupIface),
                MakeKeyValueItem("State", wlanIface.InterfaceState.ToString(), groupIface),
            };

            lstInterfaceInformation.Items.AddRange(ifaceItems);
        }

        private void AddDeviceNetworkInformation(WlanClient.WlanInterface wlanIface)
        {
            ListViewGroup groupNetwork = new ListViewGroup("Network");
            lstInterfaceInformation.Groups.Add(groupNetwork);

            ListViewItem[] networkItems =
            {
                MakeKeyValueItem("Name", wlanIface.NetworkInterface.Name, groupNetwork),
                MakeKeyValueItem("Description", wlanIface.NetworkInterface.Description, groupNetwork),
                MakeKeyValueItem("MAC", wlanIface.NetworkInterface.GetPhysicalAddress().ToString(), groupNetwork),
                MakeKeyValueItem("Status", wlanIface.NetworkInterface.OperationalStatus.ToString(), groupNetwork),
                MakeKeyValueItem("Id", wlanIface.NetworkInterface.Id, groupNetwork),
                MakeKeyValueItem("Type", wlanIface.NetworkInterface.NetworkInterfaceType.ToString(), groupNetwork),
                MakeKeyValueItem("Supports multicast?", wlanIface.NetworkInterface.SupportsMulticast ? "YES" : "NO", groupNetwork),
                MakeKeyValueItem("Speed", wlanIface.NetworkInterface.Speed.ToString(), groupNetwork),                
            };

            lstInterfaceInformation.Items.AddRange(networkItems);
        }

        private void AddDeviceInformation(WlanClient.WlanInterface wlanIface)
        {
            lstInterfaceInformation.Items.Clear();
            lstInterfaceInformation.Groups.Clear();

            AddDeviceNetworkInformation(wlanIface);
            AddDeviceInterfaceInformation(wlanIface);                    
        }

        private void LstInterfaceInformation_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(e.IsSelected)
            {
                e.Item.Selected = false;
            }
        }
    }
}
