using System;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;

namespace XtraReportsDemos.Subreports {
    public partial class MasterReport : DevExpress.XtraReports.UI.XtraReport {
        static MasterReport() {
            XtraReport.FilterComponentProperties += new EventHandler<FilterComponentPropertiesEventArgs>(OnFilterDesignProperties);
        }
        static void OnFilterDesignProperties(object sender, FilterComponentPropertiesEventArgs e) {
            if(e.Component is SubreportBase && sender is MasterReport) {
                e.Properties.Remove("ReportSource");
            }
        }
        public MasterReport() {
            InitializeComponent();
            Name = ReportNames.Subreports;
            DisplayName = ReportNames.Subreports;
        }
        void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            if(subreport1.ReportSource != null) {
                subreport1.ApplyParameterBindings();
                subreport1.ReportSource.ApplyFiltering();
                e.Cancel = subreport1.ReportSource.RowCount == 0;
            }
        }
        void MasterReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            if(subreport1.ReportSource != null)
                subreport1.ReportSource.FillDataSource();
        }
    }
}
