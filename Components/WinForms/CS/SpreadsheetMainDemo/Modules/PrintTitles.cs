using System;
using System.IO;
using DevExpress.XtraSpreadsheet.Demos;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraSpreadsheet.Services;
using DevExpress.XtraSpreadsheet.Commands;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class PrintTitlesModule : SpreadSheetTutorialControlBase {
        public PrintTitlesModule() {
            InitializeComponent();

            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("PrintTitles_template.xlsx"), DocumentFormat.Xlsx);
            this.spreadsheetPreview1.PreviewZoom = SpreadhsheetPreviewZoom.WholePage;
            RefreshPreview();
        }

        void spreadsheetControl1_ContentChanged(object sender, EventArgs e) {
            RefreshPreview();
            xtraTabControl1.SelectedTabPageIndex = 1;
        }

        void btnPageSetup_Click(object sender, EventArgs e) {
            xtraTabControl1.SelectedTabPageIndex = 0;

            ISpreadsheetCommandFactoryService service = (ISpreadsheetCommandFactoryService)spreadsheetControl1.GetService(typeof(ISpreadsheetCommandFactoryService));
            SpreadsheetCommand command = service.CreateCommand(SpreadsheetCommandId.PageSetupSheet);
            command.ForceExecute(command.CreateDefaultCommandUIState());
        }

        void RefreshPreview() {
            using (MemoryStream ms = new MemoryStream()) {
                spreadsheetControl1.SaveDocument(ms, DocumentFormat.Xlsx);
                ms.Position = 0;
                Workbook workbook = new Workbook();
                workbook.LoadDocument(ms, DocumentFormat.Xlsx);
                this.spreadsheetPreview1.Workbook = workbook;
                this.spreadsheetPreview1.UpdatePreview();
            }
        }

        private void btnWholePage_Click(object sender, EventArgs e) {
            this.spreadsheetPreview1.PreviewZoom = SpreadhsheetPreviewZoom.WholePage;
        }

        private void btnManyPages_Click(object sender, EventArgs e) {
            this.spreadsheetPreview1.PreviewZoom = SpreadhsheetPreviewZoom.TwoPages;
        }
    }
}
