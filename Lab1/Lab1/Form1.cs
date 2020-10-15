using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnButton.Visible = NetworkObserver.IsAdministrator;
            OffButton.Visible = NetworkObserver.IsAdministrator;

            NetworksComboBox.DataSource = NetworkObserver.AllInterfaces.Select(x=> x.Name).ToArray();

            NetworkObserver.InfoEvent += UpgradeInfo_Event;
            NetworkObserver.TrafficObserverEvent += UpgradeTraffic_Event;

            NetworkObserver.CurrentInterface =
                NetworkObserver.AllInterfaces.First(x => x.Name == NetworksComboBox.Text);
        }

        private void OnButton_Click(object sender, EventArgs e) => NetworkObserver.TurnNetworksInterface(true);

        private void OffButton_Click(object sender, EventArgs e) => NetworkObserver.TurnNetworksInterface(false);
       
        private void UpgradeInfo_Event(string IPv4, string IPv6, string state, string internet)
        {
            IPv4Label.Text = IPv4;
            IPv6Label.Text = IPv6;
            StateLabel.Text = state;
            InternetLabel.Text = internet;
        }

        private void UpgradeTraffic_Event(long inBytes, long outBytes)
        {
            InTrafficLabel.Text = inBytes + " bytes";
            OutTrafficLabel.Text = outBytes + " bytes";
        }

        private void NetworksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NetworkObserver.CurrentInterface =
                NetworkObserver.AllInterfaces.First(x => x.Name == NetworksComboBox.Text);
        }
    }
}
