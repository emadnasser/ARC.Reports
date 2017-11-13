using System;

namespace XtraReportsDemos.MailMerge
{
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {

		public Report() {
			InitializeComponent();

            Name = ReportNames.MailMerge;
            DisplayName = ReportNames.MailMerge;
		}

        private void xrRichText1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            const string wrongString = " and reports to ";
            if(string.IsNullOrEmpty(GetCurrentColumnValue("ReportsToInfo") as string))
                xrRichText1.Rtf = xrRichText1.Rtf.Replace(wrongString, string.Empty);
        }
	}
}
