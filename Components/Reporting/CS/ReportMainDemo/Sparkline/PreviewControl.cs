using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XtraReportsDemos.Sparkline {
    class PreviewControl : XtraReportsDemos.PreviewControl {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new Report();
        }
    }
}
