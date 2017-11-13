using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Native;
using DevExpress.DataAccess.Excel;

namespace XtraReportsDemos.PollingReport
{
	public class PreviewControl : XtraReportsDemos.PreviewControl
	{
        bool showResults = false;
        int pollCount = 3;
        IList<ResultingData> data = new List<ResultingData>();

        protected override XtraReport CreateReport() {
            if(showResults) {
                ResultingReport resultingReport = new XtraReportsDemos.PollingReport.ResultingReport();
                resultingReport.PollingLink.PreviewClick += Link_PreviewClick;
                resultingReport.ResultingReportDS.DataSource = data;
                resultingReport.Parameters["paramPollCount"].Value = ++pollCount;
                return resultingReport;
            } else {
                PollingReport pollingReport = new XtraReportsDemos.PollingReport.PollingReport();
                pollingReport.ResultingLink.PreviewClick += Link_PreviewClick;
                return pollingReport;
            }
        }
        void Link_PreviewClick(object sender, PreviewMouseEventArgs e) {
            showResults = !showResults;
            if(Report is PollingReport)
                ((PollingReport)Report).UpdateData(data);
            Report = null;
            Activate();
        }
    }
}

