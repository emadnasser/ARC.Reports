using System;
using System.Windows.Forms;

namespace DevExpress.ApplicationUI.Demos {
    public partial class Clock : UserControl {
        Timer timer = new Timer();
        public Clock() {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += OnTick;
            timer.Start();
            OnTick(null, null);
        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
                DisableTimer();
            }
            base.Dispose(disposing);
        }
        void DisableTimer() {
            timer.Stop();
            timer = null;
        }
        void OnTick(object sender, EventArgs e) {
            if(IsDisposed) {
                DisableTimer();
                return;
            }
            System.DateTime currentDate = System.DateTime.Now;
            labelControl1.Text = "<b>" + string.Format("{0:T}", currentDate) + "</b><br><size=10>" + currentDate.ToString("D");
        }
    }
}
