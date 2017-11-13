using System;
using System.Drawing;
using System.Globalization;
using DevExpress.DXperience.Demos;
using DevExpress.Spreadsheet;
using DevExpress.Docs.Demos;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class ExpenseReportModule : SpreadsheetRibbonTutorialControlBase {
        IWorkbook book;
        CultureInfo culture;
        ExpenseReportDocumentGenerator generator;

        public ExpenseReportModule() {
            this.culture = DefaultCulture;
            InitializeComponent();
            this.spreadsheetControl1.Options.Culture = culture;
            spreadsheetControl1.BeginUpdate();
            book = spreadsheetControl1.Document;
            generator = new ExpenseReportDocumentGenerator(book);
            book = generator.Generate();
            spreadsheetControl1.EndUpdate();
            spreadsheetControl1.Document.History.Clear();
        }
    }
}
