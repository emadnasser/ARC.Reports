using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.ShrinkGrow {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {

        public Report() {
            /// <summary>
            /// Required for Windows.Forms Class Composition Designer support
            /// </summary>
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            Name = ReportNames.ShrinkGrow;
            DisplayName = ReportNames.ShrinkGrow;
        }


        private void xrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            ((XRLabel)sender).Text = String.Format("{0} {1}", GetCurrentColumnValue<string>("FirstName"), GetCurrentColumnValue("LastName"));
        }

        private void xrLabel5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            ((XRLabel)sender).Text = String.Format("{0}, {1}, {2}", GetCurrentColumnValue<string>("Country"), GetCurrentColumnValue<string>("City"), GetCurrentColumnValue("Address"));
        }

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            DateTime dateTime = GetCurrentColumnValue<DateTime>("BirthDate");
            ((XRLabel)sender).Text = dateTime.ToLongDateString();
        }
    }
}
