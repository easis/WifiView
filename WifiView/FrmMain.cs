using NativeWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WifiView
{
    public partial class FrmMain : Form
    {
        private WlanClient wClient;
        public FrmMain()
        {
            this.wClient = new WlanClient();
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
                item.Text = wlanIface.InterfaceDescription;
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
            if (lstInterfaces.SelectedItems.Count > 0)
            {
                if(!tabOptions.Enabled)
                {
                    tabOptions.Enabled = true;
                }

                ListViewItem item = lstInterfaces.SelectedItems[0];
                if (item.Tag != null && item.Tag.GetType() == typeof(WlanClient.WlanInterface))
                {
                    WlanClient.WlanInterface wlanIface = item.Tag as WlanClient.WlanInterface;
                    InterfaceInfo.AddDeviceInformation(lstInterfaceInformation, wlanIface);
                    Profile.AddProfiles(lstProfiles, wlanIface);
                    Network.AddNetworks(tblNetworks, wlanIface);
                    Statistics.AddStatisticsInformation(lstStatistics, wlanIface);

#if !DEBUG
                    lstInterfaceInformation.SetGroupState(ListViewGroupCollapse.ListViewGroupState.Collapsible);
                    lstProfiles.SetGroupState(ListViewGroupCollapse.ListViewGroupState.Collapsible);
                    lstInterfaceInformation.SetGroupState(ListViewGroupCollapse.ListViewGroupState.Collapsible);
                    lstStatistics.SetGroupState(ListViewGroupCollapse.ListViewGroupState.Collapsible);
#endif
                }
            } else
            {
                tabOptions.Enabled = false;
                lstInterfaceInformation.Groups.Clear();
                lstInterfaceInformation.Items.Clear();
                tblNetworks.Rows.Clear();
            }
        }
   
        private void LstInterfaceInformation_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                e.Item.Selected = false;
            }
        }
    }
}
