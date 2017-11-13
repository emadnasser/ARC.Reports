using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.Extensions;

namespace XtraReportsDemos.DrillDownReport
{
    public class PreviewControl : XtraReportsDemos.PreviewControl {

        protected override XtraReport CreateReport() {
             return new XtraReportsDemos.DrillDownReport.DrillDownReport();
        }
    }
}

