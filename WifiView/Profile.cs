using NativeWifi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WifiView
{
    public class Profile
    {
        private static void AddProfilesInformation(ListView lst, WLANProfile wlanProfile)
        {
            ListViewGroup groupSsid = new ListViewGroup(wlanProfile.Name);
            lst.Groups.Add(groupSsid);

            string password = "";
            try
            {
                password = wlanProfile.MSM.Security.SharedKey.KeyMaterial;
            }
            catch { }

            List<ListViewItem> networkItems = new List<ListViewItem>
            {
                Utils.MakeKeyValueItem("Name", wlanProfile.Name, groupSsid),
                Utils.MakeKeyValueItem("Authentication", wlanProfile.MSM.Security.AuthEncryption.Authentication, groupSsid),
                Utils.MakeKeyValueItem("Encryption", wlanProfile.MSM.Security.AuthEncryption.Encryption, groupSsid),
                Utils.MakeKeyValueItem("Password", password, groupSsid),
            };

            lst.Items.AddRange(networkItems.ToArray());
        }

        public static void AddProfiles(ListView lst, WlanClient.WlanInterface wlanIface)
        {
            lst.Groups.Clear();
            lst.Items.Clear();

            foreach (Wlan.WlanProfileInfo profileInfo in wlanIface.GetProfiles())
            {
                if (string.IsNullOrEmpty(profileInfo.profileName))
                {
                    continue;
                }

                XmlSerializer deserializer = new XmlSerializer(typeof(WLANProfile));
                object profile = null;
                using (TextReader reader = new StringReader(wlanIface.GetProfileXmlUnencrypted(profileInfo.profileName)))
                {
                    profile = deserializer.Deserialize(reader);
                }

                if (profile == null)
                {
                    continue;
                }

                AddProfilesInformation(lst, (WLANProfile) profile);
            }

#if !DEBUG
            lstProfiles.SetGroupState(ListViewGroupCollapse.ListViewGroupState.Collapsible);
#endif
        }
    }
}
