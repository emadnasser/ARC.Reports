using System;
using System.Collections.Generic;
using System.Web;
using DevExpress.Spreadsheet;
using System.Drawing;
using System.Globalization;

namespace DevExpress.Docs.Demos {
    public class SimplifiedMultiplicationTableDocumentGenerator {
        CultureInfo culture;
        public SimplifiedMultiplicationTableDocumentGenerator(CultureInfo culture) {
            this.culture = culture;
        }

        public int TableCount { get; set; }
        public int ColumnCount { get; set; }
        public bool FitToPage { get; set; }

        public IWorkbook Generate() {
            Workbook book = new Workbook();
            book.Options.Culture = culture;
            book.Worksheets[0].DefaultColumnWidthInCharacters = TableCount.ToString().Length + 1;
            book.DocumentSettings.R1C1ReferenceStyle = true;
            CreateFormula(book);
            book.Worksheets[0].PrintOptions.FitToPage = FitToPage;
            return book;
        }
        void CreateFormula(Workbook book) {
            for(int i = 1; i <= TableCount; i++)
                CreateSingleTable(book, i);
        }
        void CreateSingleTable(Workbook book, int multiplier) {
            int hMultiplier = multiplier % ColumnCount == 0 ? ColumnCount : multiplier % ColumnCount;
            int vMultiplier = multiplier % ColumnCount == 0 ? (int)(multiplier / ColumnCount) : (int)(multiplier / ColumnCount) + 1;
            int startRowIndex = vMultiplier * 11 - 11;
            int endRowIndex = startRowIndex + 9;
            int startColumnIndex = hMultiplier * 7 - 7;
            int endColumnIndex = startColumnIndex + 4;

            Range range = book.Worksheets[0].Range.FromLTRB(startColumnIndex, startRowIndex, endColumnIndex, endRowIndex);
            range.Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin);
            range.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            range.Value = multiplier;

            book.Worksheets[0].Range.FromLTRB(startColumnIndex + 1, startRowIndex, startColumnIndex + 1, endRowIndex).Value = "x";
            book.Worksheets[0].Range.FromLTRB(startColumnIndex + 3, startRowIndex, startColumnIndex + 3, endRowIndex).Value = "=";

            range = book.Worksheets[0].Range.FromLTRB(startColumnIndex + 4, startRowIndex, startColumnIndex + 4, endRowIndex);
            range.Formula = "=RC[-4]*RC[-2]";
            range.Font.Color = Color.Red;

            for(int i = startRowIndex; i <= endRowIndex; i++)
                book.Worksheets[0].Cells[i, startColumnIndex + 2].Value = i - startRowIndex + 1;
        }
    }
}
