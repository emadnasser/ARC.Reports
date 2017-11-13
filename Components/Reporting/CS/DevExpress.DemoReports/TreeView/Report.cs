using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace XtraReportsDemos.TreeView
{
    public partial class Report : DevExpress.XtraReports.UI.XtraReport
	{
        [
        Browsable(false),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
        ]
        public DevExpress.XtraReports.UI.PrintableComponentContainer WinControlContainer {
            get { return this.winControlContainer1; }
        }
		public Report()
		{
			InitializeComponent();

            Name = ReportNames.TreeView;
            DisplayName = ReportNames.TreeView;
		}
	}
}
