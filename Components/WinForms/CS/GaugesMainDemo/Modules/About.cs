using System.Drawing;
using DevExpress.Tutorials;

namespace DevExpress.XtraGauges.Demos {
    public partial class About : ucOverviewPage {
        public About() {
            InitializeComponent();
        }
        protected override string Line1Text {
            get { return "The XtraGauge Suite"; }
        }
        protected override string Line2Text {
            get { return "Dashboard and analytics controls for the WinForms platform."; }
        }
        protected override string Line3Text {
            get { return "DevExpress Desktop Controls"; }
        }
        protected override string Line4Text {
            get { return votedVSM; }
        }
    }
}
