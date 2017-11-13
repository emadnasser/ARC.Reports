using System;
using System.Drawing;
using System.Globalization;
using DevExpress.DXperience.Demos;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Demos;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class EmployeeInformationModule : SpreadsheetRibbonTutorialControlBase {

        public EmployeeInformationModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            EmployeeInformationDocumentGenerator generator = new EmployeeInformationDocumentGenerator(this.spreadsheetControl1.Document);
            generator.Generate(DemoUtils.GetRelativePath("EmployeeInformation_template.xlsx"));
            spreadsheetControl1.Document.History.Clear();
        }
        void btnCalculate_Click(object sender, EventArgs e) {
            IWorkbook book = this.spreadsheetControl1.Document;
            if(book.Worksheets.Count > 2)
                book.Worksheets.ActiveWorksheet = book.Worksheets[2];
        }
        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
        }
    }
}
