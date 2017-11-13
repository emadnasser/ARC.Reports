using System;
using System.IO;
using DevExpress.XtraSpreadsheet.Demos;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraSpreadsheet.Services;
using DevExpress.XtraSpreadsheet.Commands;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class HeaderFooterModule : SpreadSheetTutorialControlBase {
        public HeaderFooterModule() {
            InitializeComponent();

            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("HeaderFooter_template.xlsx"), DocumentFormat.Xlsx);
            RefreshPreview();
        }

        private void btnPageSetup_Click(object sender, EventArgs e) {
            ISpreadsheetCommandFactoryService service = (ISpreadsheetCommandFactoryService)spreadsheetControl1.GetService(typeof(ISpreadsheetCommandFactoryService));
            SpreadsheetCommand command = service.CreateCommand(SpreadsheetCommandId.PageSetupHeaderFooter);
            command.ForceExecute(command.CreateDefaultCommandUIState());
            RefreshPreview();
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
    }
}
