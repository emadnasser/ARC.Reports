using System.Web;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using XtraReportsDemos.PollingReport;

public class WebDocumentViewerDrillThroughProcessor : IWebDocumentViewerDrillThroughProcessor {
    IList<ResultingData> GetResultingData() {
        if(HttpContext.Current.Session["resultingData"] == null) {
            HttpContext.Current.Session["resultingData"] = new List<ResultingData>();
        }
        return (List<ResultingData>)HttpContext.Current.Session["resultingData"];
    }
    int IncrementPollCount() {
        int pollCount = 3;
        if(HttpContext.Current.Session["pollCount"] != null) {
            pollCount = (int)HttpContext.Current.Session["pollCount"];
        }
        HttpContext.Current.Session["pollCount"] = ++pollCount;
        return pollCount;
    }
    XtraReport IWebDocumentViewerDrillThroughProcessor.CreateReport(DrillThroughContext context) {
        if(context.CustomData == "showResults") {
            context.AssignEditingFieldValuesToReport();
            IList<ResultingData> data = GetResultingData();
            ((PollingReport)context.Report).UpdateData(data);
            var resultingReport = new ResultingReport();
            resultingReport.ResultingReportDS.DataSource = data;
            resultingReport.Parameters["paramPollCount"].Value = IncrementPollCount();
            return resultingReport;
        } else {
            return new PollingReport();
        }
    }
}
