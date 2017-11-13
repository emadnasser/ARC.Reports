using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace XtraReportsDemos.PivotGridAndChart {
    public partial class PreviewControl : XtraReportsDemos.PreviewControl {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new XtraReportsDemos.PivotGridAndChart.Report();
        }
    }
}
