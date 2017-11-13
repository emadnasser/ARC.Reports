using System;
using DevExpress.Web;
using DevExpress.XtraReports.Web;

public partial class ReportTypes_Subreports : PageBase<XtraReportsDemos.Subreports.MasterReport> {
    protected void documentViewer_CustomizeParameterEditors(object sender, CustomizeParameterEditorsEventArgs e) {
        var dateEdit = (ASPxDateEdit)e.Editor;
        dateEdit.MinDate = new DateTime(2016, 1, 1);
        dateEdit.MaxDate = new DateTime(2016, 12, 31);
        dateEdit.ValidationSettings.ErrorText = "The end date should be grater than the start date.";
        dateEdit.ClientInstanceName = e.Parameter.Name;
        dateEdit.ID = e.Parameter.Name;
        dateEdit.ClientSideEvents.Init = "editorInitialized";
        if(dateEdit.ID == "toDateParameter") {
            dateEdit.DateRangeSettings.StartDateEditID = "fromDateParameter";
        }
    }
}
