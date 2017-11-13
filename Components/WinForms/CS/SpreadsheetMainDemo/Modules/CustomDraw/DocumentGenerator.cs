using System;
using System.Collections.Generic;
using DevExpress.Office;
using DevExpress.Spreadsheet;
using System.Drawing;
using SpreadsheetFormatting = DevExpress.Spreadsheet.Formatting;
using System.Globalization;
using DevExpress.Spreadsheet.Functions;
using DevExpress.Docs.Text;

namespace DevExpress.Spreadsheet.Demos {
    public class CustomDrawDocumentGenerator {
        IWorkbook book;
        string path;

        public CustomDrawDocumentGenerator() {
            this.book = new Workbook();
        }
        public CustomDrawDocumentGenerator(IWorkbook book) {
            this.book = book;
        }
        public IWorkbook Generate(string path) {
            this.path = path;
            InitializeBook();
            return book;
        }

        void InitializeBook() {
            InitWorkbook();
        }
        void InitWorkbook() {
            book.Unit = DevExpress.Office.DocumentUnit.Point;
            book.Styles.DefaultStyle.Font.Name = "Calibri";
            book.Styles.DefaultStyle.Font.Size = 11;
            book.LoadDocument(this.path);
        }
    }
}
