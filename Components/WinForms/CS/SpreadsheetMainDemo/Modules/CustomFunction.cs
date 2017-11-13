using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using DevExpress.Docs.Demos;
using DevExpress.Docs.Text;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Demos;
using DevExpress.Spreadsheet.Functions;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class CustomFunctionModule : SpreadsheetRibbonTutorialControlBase {
        Worksheet sheet;

        public CustomFunctionModule() {
            InitializeComponent();
            IWorkbook book = spreadsheetControl1.Document;
            GenerateDocument(book);
            sheet = book.Worksheets[0];
            AutoFitColumns();
            spreadsheetControl1.CellValueChanged += spreadsheetControl1_CellValueChanged;
            spreadsheetControl1.Options.Behavior.Selection.MoveActiveCellMode = MoveActiveCellModeOnEnterPress.None;
            book.History.Clear();
        }
        void GenerateDocument(IWorkbook book) {
            spreadsheetControl1.BeginUpdate();
            try {
                CustomFunctionDocumentGenerator generator = new CustomFunctionDocumentGenerator(book);
                generator.Generate();
            }
            finally {
                spreadsheetControl1.EndUpdate();
            }
        }

        void spreadsheetControl1_CellValueChanged(object sender, SpreadsheetCellEventArgs e) {
            if (e.SheetName == sheet.Name && e.RowIndex == 3 && e.ColumnIndex == 2) {
                AutoFitColumns();
            }
        }
        void AutoFitColumns() {
            sheet.Columns[2].AutoFit();
            sheet.Columns[4].AutoFit();
        }
    }
}
