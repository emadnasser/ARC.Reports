using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraPrinting;

namespace XtraReportsDemos.CharacterComb {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        public Report() {
            InitializeComponent();
        }
        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            ccDay.Text = string.Format("{0:dd}", DateTime.Today);
            ccMonth.Text = string.Format("{0:MM}", DateTime.Today);
            ccYear.Text = string.Format("{0:yyyy}", DateTime.Today);
        }
    }
}
