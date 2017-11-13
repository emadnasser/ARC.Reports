using System;
using System.Drawing.Printing;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;

namespace XtraReportsDemos.DrillDownReport {
    public partial class DrillDownReport : DevExpress.XtraReports.UI.XtraReport {
        public DrillDownReport() {
            InitializeComponent();
            lbShowHide.BeforePrint += lbShowHide_BeforePrint;
        }
        void lbShowHide_BeforePrint(object sender, PrintEventArgs e) {
            lbShowHide.Text = DetailReport.DrillDownExpanded ? "Hide Details" : "Show Details";
        }
    }
}
