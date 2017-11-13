using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Native;

namespace XtraReportsDemos.ReportMerging {
    public class PreviewControl : XtraReportsDemos.PreviewControl {
        public PreviewControl() {
            printControl.SetDocumentMapVisibility(false);
            printControl.SetThumbnailsVisibility(false);
            printControl.SetPageView(3, 2);
            printControl.PrintingSystem = null;
            barButtonItem2.Enabled = false;
        }
        protected override XtraReport CreateReport() {
            return new XtraReportsDemos.ReportMerging.MergedReport();
        }
    }
}
