using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace FeatureCenter.Module.Reports {
    public partial class ContactReport : DevExpress.XtraReports.UI.XtraReport {
        public ContactReport() {
            InitializeComponent();
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRSubreport subReport = (XRSubreport)sender;
            subReport.ReportSource.Parameters["MasterOid"].Value = ((ContactForReport)GetCurrentRow()).Oid;
        }

    }
}
