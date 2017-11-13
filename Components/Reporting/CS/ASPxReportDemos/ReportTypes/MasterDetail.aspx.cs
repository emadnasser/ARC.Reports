using System.IO;
using DevExpress.XtraReports.Web;

public partial class ReportTypes_MasterDetail : PageBase<XtraReportsDemos.MasterDetailReport.Report> {
    MemoryStream DocumentStream {
        get { return Session[ReportTypeName] as MemoryStream; }
        set { Session[ReportTypeName] = value; }
    }

    protected void documentViewer_CacheReportDocument(object sender, CacheReportDocumentEventArgs e) {
        DocumentStream = e.SaveDocumentToMemoryStream();
    }

    protected void documentViewer_RestoreReportDocumentFromCache(object sender, RestoreReportDocumentFromCacheEventArgs e) {
        if(DocumentStream != null)
            e.RestoreDocumentFromStream(DocumentStream);
    }

    protected override void CleanDocument() {
        DocumentStream = null;
    }
}
