using System;
using System.Net.NetworkInformation;
using System.Windows.Threading;
using System.Windows;

namespace DevExpress.StockMarketTrader.Model {
    public class NetworkMonitor2 {

        DispatcherTimer timer;
        Ping ping;
        bool isInit = false;
        public NetworkMonitor2() {
            ping = new Ping();
            ping.PingCompleted += ping_PingCompleted;
            timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 0, 0, 1) };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public bool IsInternetAvaliable { get; private set; }
        public event EventHandler<EventArgs> InternetAvaliableChanged;

        void timer_Tick(object sender, EventArgs e) {
            timer.Stop();
            ping.SendAsync("google.com", null);
        }

        void ping_PingCompleted(object sender, PingCompletedEventArgs e) {
            timer.Start();
            bool isAvaliable = e.Reply == null || e.Reply.Status != IPStatus.Success ? false : true;
            if (isAvaliable != IsInternetAvaliable) {
                isInit = true;
                IsInternetAvaliable = isAvaliable;
                RaiseInternetAvaliableChanged();
            }
            else if (!isInit) {
                isInit = true;
                RaiseInternetAvaliableChanged();
            }
        }

        private void RaiseInternetAvaliableChanged() {
            if (this.InternetAvaliableChanged != null)
                this.InternetAvaliableChanged(this, EventArgs.Empty);
        }

    }
    public class NetworkMonitor {

        public static bool IsNetworkAvaliable() {
            var networks = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var net in networks) {
                if (net.NetworkInterfaceType != NetworkInterfaceType.Loopback && net.NetworkInterfaceType != NetworkInterfaceType.Tunnel && net.OperationalStatus == OperationalStatus.Up)
                    return true;
            }
            return false;
        }

        public event EventHandler IsAvailableChanged;
        public NetworkMonitor() {
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);
            CheckConnection();
        }

        bool isAvailable = false;
        public bool IsAvailable {
            get { return isAvailable; }
            private set {
                isAvailable = value;
                RaiseIsAvailableChanged();
            }
        }

        private void OnPingCompleted(object sender, PingCompletedEventArgs e) {
            IsAvailable = e.Reply == null || e.Reply.Status != IPStatus.Success ? false : true;
        }

        private void RaiseIsAvailableChanged() {
            this.IsAvailableChanged(this, EventArgs.Empty);
        }
        private void CheckConnection() {
            Ping ping = new Ping();
            ping.SendAsync("www.devexpress.com", null);
            ping.PingCompleted += new PingCompletedEventHandler(OnPingCompleted);

        }
        private void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e) {
            IsAvailable = e.IsAvailable;
        }
    }
}
