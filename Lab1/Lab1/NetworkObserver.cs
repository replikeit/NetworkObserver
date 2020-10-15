using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Principal;

namespace Lab1
{
    static class NetworkObserver
    {
        private static NetworkInterface currentInterface;
        public static NetworkInterface CurrentInterface
        {
            get => currentInterface;
            set
            {
                currentInterface = value;
                SendInfo();
            }
        }

        public static NetworkInterface[] AllInterfaces { get; } = NetworkInterface.GetAllNetworkInterfaces();
        public static bool IsAdministrator { get; }

        public static event Action<string, string, string, string> InfoEvent;
        public static event Action<long, long> TrafficObserverEvent;

        static NetworkObserver()
        {
            WindowsIdentity wi = WindowsIdentity.GetCurrent();
            WindowsPrincipal princ = new WindowsPrincipal(wi);

            IsAdministrator = princ.IsInRole(WindowsBuiltInRole.Administrator);
            SendTraffic();
        }

        public static void TurnNetworksInterface(bool on)
        {
            string nameArg = currentInterface.Name;
            string optionArg = on ? "ENABLE" : "DISABLE";
            ProcessStartInfo procInfo = new ProcessStartInfo("netsh", $"interface set interface \"{nameArg}\" {optionArg}");
            Process proc = new Process();
            proc.StartInfo = procInfo;
            proc.Start();
        }

        private static void SendInfo()
        {
            UnicastIPAddressInformationCollection unicast = currentInterface.GetIPProperties().UnicastAddresses;
            
            string IPv4 = unicast.First(x => x.Address.AddressFamily == AddressFamily.InterNetwork).Address.ToString();
            string IPv6 = unicast.First(x => x.Address.AddressFamily == AddressFamily.InterNetworkV6).Address.ToString();
            string state = currentInterface.OperationalStatus.ToString();
            string internetConnection = GetInternetConnection();

            InfoEvent?.Invoke(IPv4, IPv6, state, internetConnection);
        }

        private static async void SendTraffic()
        {
            while (true)
            {
                if (currentInterface != null)
                {
                    long inBytes = currentInterface.GetIPStatistics().BytesReceived;
                    long outBytes = currentInterface.GetIPStatistics().BytesSent;
                    TrafficObserverEvent?.Invoke(inBytes, outBytes);
                }

                await Task.Delay(1000);
            }
        }

        private static string GetInternetConnection()
        {
            string InternetConnection = "Not Available";
            if (currentInterface.NetworkInterfaceType != NetworkInterfaceType.Tunnel && 
                currentInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            {
                IPv4InterfaceStatistics statistics = currentInterface.GetIPv4Statistics();

                if ((statistics.BytesReceived > 0) && (statistics.BytesSent > 0))  InternetConnection = "Available"; 
            }

            return InternetConnection;
        }


    }
}
