using System;
using DevExpress.XtraSplashScreen;

namespace DevExpress.StockMarketTrader {
    public partial class SplashScreen1 : SplashScreen {
        public enum SplashScreenCommand {
        }

        public SplashScreen1() {
            InitializeComponent();
            labelControl1.Text += DateTime.Now.Year.ToString();
        }
        #region Overrides
        public override void ProcessCommand(Enum cmd, object arg) {
            base.ProcessCommand(cmd, arg);
        }
        #endregion
    }
}
