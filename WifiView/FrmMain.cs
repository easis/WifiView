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
                    AddDeviceInformation(wlanIface);
                    AddProfiles(wlanIface);

                }
            } else
            {
                tabOptions.Enabled = false;
                lstInterfaceInformation.Groups.Clear();
                lstInterfaceInformation.Items.Clear();
                
            }
        }

        private ListViewItem MakeKeyValueItem(string key, string value, ListViewGroup group)
        {
            ListViewItem item = new ListViewItem(key);
            item.Group = group;
            item.SubItems.Add(value);

            return item;
        }

        #region "Device information"
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

            List<ListViewItem> networkItems = new List<ListViewItem>
            {
                MakeKeyValueItem("Name", wlanIface.NetworkInterface.Name, groupNetwork),
                MakeKeyValueItem("Description", wlanIface.NetworkInterface.Description, groupNetwork),
                MakeKeyValueItem("MAC", wlanIface.NetworkInterface.GetPhysicalAddress().ToString(), groupNetwork),
                MakeKeyValueItem("Status", wlanIface.NetworkInterface.OperationalStatus.ToString(), groupNetwork),
                MakeKeyValueItem("Id", wlanIface.NetworkInterface.Id, groupNetwork),
                MakeKeyValueItem("Type", wlanIface.NetworkInterface.NetworkInterfaceType.ToString(), groupNetwork),
                MakeKeyValueItem("Supports multicast?", wlanIface.NetworkInterface.SupportsMulticast ? "YES" : "NO", groupNetwork),
            };

            if (wlanIface.NetworkInterface.Speed > 0)
            {
                networkItems.Add(
                    MakeKeyValueItem("Speed", wlanIface.NetworkInterface.Speed.ToString(), groupNetwork)
                );
            }

            lstInterfaceInformation.Items.AddRange(networkItems.ToArray());
        }

        private void AddDeviceInformation(WlanClient.WlanInterface wlanIface)
        {
            lstInterfaceInformation.Groups.Clear();
            lstInterfaceInformation.Items.Clear();            

            AddDeviceNetworkInformation(wlanIface);
            AddDeviceInterfaceInformation(wlanIface);

#if !DEBUG
            lstInterfaceInformation.SetGroupState(ListViewGroupCollapse.ListViewGroupState.Collapsible);
#endif
        }
        #endregion

        #region "Profiles"
        private void AddProfilesInformation(WLANProfile wlanProfile)
        {
            ListViewGroup groupSsid = new ListViewGroup(wlanProfile.Name);
            lstProfiles.Groups.Add(groupSsid);

            string password = "";
            try
            {
                password = wlanProfile.MSM.Security.SharedKey.KeyMaterial;
            }
            catch { }

            List<ListViewItem> networkItems = new List<ListViewItem>
            {
                MakeKeyValueItem("Name", wlanProfile.Name, groupSsid),
                MakeKeyValueItem("Authentication", wlanProfile.MSM.Security.AuthEncryption.Authentication, groupSsid),
                MakeKeyValueItem("Encryption", wlanProfile.MSM.Security.AuthEncryption.Encryption, groupSsid),
                MakeKeyValueItem("Password", password, groupSsid),
            };

            lstProfiles.Items.AddRange(networkItems.ToArray());
        }

        private void AddProfiles(WlanClient.WlanInterface wlanIface)
        {
            lstProfiles.Groups.Clear();
            lstProfiles.Items.Clear();

            foreach (Wlan.WlanProfileInfo profileInfo in wlanIface.GetProfiles())
            {
                if(string.IsNullOrEmpty(profileInfo.profileName)) {
                    continue;
                }

                XmlSerializer deserializer = new XmlSerializer(typeof(WLANProfile));
                object profile = null;
                using (TextReader reader = new StringReader(wlanIface.GetProfileXmlUnencrypted(profileInfo.profileName)))
                {
                    profile = deserializer.Deserialize(reader);
                }

                if(profile == null)
                {
                    continue;
                }                

                AddProfilesInformation(profile as WLANProfile);
            }

#if !DEBUG
            lstProfiles.SetGroupState(ListViewGroupCollapse.ListViewGroupState.Collapsible);
#endif
        }
        #endregion

        private void LstInterfaceInformation_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                e.Item.Selected = false;
            }
        }
    }
}
