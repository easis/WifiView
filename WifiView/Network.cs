using NativeWifi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WifiView
{
    public static class Network
    {

        private static string AlgorithmToString(Wlan.Dot11CipherAlgorithm algo)
        {
            switch(algo)
            {
                case Wlan.Dot11CipherAlgorithm.CCMP:
                    return "AES";
                case Wlan.Dot11CipherAlgorithm.WEP40:
                case Wlan.Dot11CipherAlgorithm.WEP104:
                case Wlan.Dot11CipherAlgorithm.WEP:
                    return "WEP";
                case Wlan.Dot11CipherAlgorithm.TKIP:
                    return "TKIP";
                case Wlan.Dot11CipherAlgorithm.None:
                    return "None";
                case Wlan.Dot11CipherAlgorithm.WPA_UseGroup:
                    return "WPA";
                default:
                    return "Unknown";
            }
        }

        public static void AddNetworks(DataGridView table, WlanClient.WlanInterface wlanIface)
        {
            table.Rows.Clear();

            Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
            foreach (Wlan.WlanAvailableNetwork network in networks)
            {
                try
                {
                    table.Rows.Add(new string[]
                    {
                        Utils.GetStringForSSID(network.dot11Ssid),
                        AlgorithmToString(network.dot11DefaultCipherAlgorithm),
                        network.dot11DefaultAuthAlgorithm.ToString(),
                        $"{network.wlanSignalQuality} %"
                    });
                } catch {
                    Console.WriteLine($"error");
                    continue;
                }
            }
        }
    }
}
