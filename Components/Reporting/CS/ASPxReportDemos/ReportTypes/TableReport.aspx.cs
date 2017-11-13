using DevExpress.Web;
using DevExpress.XtraReports.Web;

public partial class ReportTypes_TableReport : PageBase<XtraReportsDemos.TableReport.Report> {
    protected void documentViewer_CustomizeParameterEditors(object sender, CustomizeParameterEditorsEventArgs e) {
        var spinEdit = e.Editor as ASPxSpinEdit;
        if(spinEdit == null)
            return;
        switch(e.Parameter.Name) {
            case "OrderIdParameter":
                SetSpinEditParametrs(spinEdit, 10248, 11077);
                break;
            case "MaxRowCountParameter":
                SetSpinEditParametrs(spinEdit, 1, int.MaxValue);
                break;
        }
    }

    static void SetSpinEditParametrs(ASPxSpinEdit spinEdit, int minValue, int maxValue) {
        spinEdit.MinValue = minValue;
        spinEdit.MaxValue = maxValue;
    }
}
