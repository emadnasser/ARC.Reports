using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet.Services;
using DevExpress.XtraSpreadsheet.Services.Implementation;

public partial class Spreadsheet_BreakevenAnalysis : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        this.previewControl.Workbook = CreateWorkbook();
        if (this.previewControl.CanShowPreview())
            this.previewControl.RenderSpreadsheetPreview();
    }
    IWorkbook CreateWorkbook() {
        IWorkbook workbook = new Workbook();
        workbook.AddService(typeof(IChartControllerFactoryService), new ChartControllerFactoryService());
        workbook.AddService(typeof(IChartImageService), new ChartImageService());
        workbook.LoadDocument(MapPath("~/App_Data/BreakevenAnalysis.xlsx"));
        return workbook;
    }
    protected void OnDocumentDownloaderRequestWorkbook(object sender, RequestWorkbookEventArgs args) {
        args.Workbook = CreateWorkbook();
    }
}
