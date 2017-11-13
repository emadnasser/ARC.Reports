using System.Drawing;
using System.Globalization;
using DevExpress.Spreadsheet;

namespace DevExpress.Docs.Demos {
    public class MultiplicationTableDocumentGenerator {
        CultureInfo culture;
        public MultiplicationTableDocumentGenerator(CultureInfo culture) {
            this.culture = culture;
        }
         
        #region Properties
        public int Width { get; set; }
        public int Height { get; set; }
        public bool FitToPage { get; set; }
        public bool CreateInfoCells { get; set; }
        public bool UseSharedFormula { get; set; }
        #endregion

        public IWorkbook Generate() {
            Workbook book = new Workbook();
            book.Options.Culture = culture;
            Worksheet worksheet = book.Worksheets[0];
            PutData(worksheet);
            worksheet.PrintOptions.FitToPage = FitToPage;
            return book;
        }

        Worksheet PutData(Worksheet worksheet) {
            int offset = 0;
            string formula = "=ROW()*COLUMN()";
            if(CreateInfoCells) {
                offset = 1;
                formula = UseSharedFormula ? "=B$1*$A2" : "=(ROW()-1)*(COLUMN()-1)";
                PutInfoCells(worksheet);
            }
            Range formulaRange = worksheet.Range.FromLTRB(offset, offset, Width + offset - 1, Height + offset - 1);
            formulaRange.Formula = formula;
            return worksheet;
        }

        void PutColumnsInfo(Range range) {
            range.Formula = "=COLUMN() - 1";
            Formatting formatting = range.BeginUpdateFormatting();
            try {
                formatting.Borders.BottomBorder.LineStyle = BorderLineStyle.Thin;
                formatting.Borders.BottomBorder.Color = Color.Black;
            }
            finally {
                range.EndUpdateFormatting(formatting);
            }
        }

        void PutRowsInfo(Range range) {
            range.Formula = "=ROW() - 1";
            Formatting formatting = range.BeginUpdateFormatting();
            try {
                formatting.Borders.RightBorder.LineStyle = BorderLineStyle.Thin;
                formatting.Borders.RightBorder.Color = Color.Black;
            }
            finally {
                range.EndUpdateFormatting(formatting);
            }
        }

        void PutInfoCells(Worksheet worksheet) {
            PutColumnsInfo(worksheet.Range.FromLTRB(0, 0, Width, 0));
            PutRowsInfo(worksheet.Range.FromLTRB(0, 0, 0, Height));
            worksheet.ClearContents(worksheet.Cells[0, 0]);
        }
    }
}
