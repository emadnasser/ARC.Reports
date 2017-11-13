using System.Drawing;
using System.Globalization;
using DevExpress.Spreadsheet;
using System;

namespace DevExpress.Docs.Demos {
    public class CellArtDocumentGenerator {
        Bitmap image;

        public CellArtDocumentGenerator(Bitmap image) {
            this.image = image;
        }

        public IWorkbook Generate() {
            IWorkbook workbook = new Workbook();
            CreateCellArt(workbook, this.image);
            return workbook;
        }
        void CreateCellArt(IWorkbook book, Bitmap image) {
            book.Unit = Office.DocumentUnit.Point;
            Worksheet sheet = book.Worksheets[0];

            int width = image.Width;
            int height = image.Height;
            double c = 100000D / (width * height);
            double step = Math.Sqrt(c);
            if(c < 1) {
                width = (int)(width * step);
                height = (int)(height * step);
            } else
                step = 1;
            int cx = -1;
            int cy = -1;

            for(int x = 0; x < image.Width; x++) {
                for(int y = 0; y < image.Height; y++) {
                    if(cx != (int)(x * step) || cy != (int)(y * step)) {
                        cx = (int)(x * step);
                        cy = (int)(y * step);
                        Color pixel = image.GetPixel(x, y);
                        Cell cell = sheet.Cells[cy, cx];
                        if(!IsTransparentOrEmpty(pixel)) {
                            cell.Fill.PatternType = PatternType.Solid;
                            cell.Fill.BackgroundColor = pixel;
                        }
                    }
                }
            }
            sheet.ActiveView.ShowGridlines = false;
            Range range = sheet.Range.FromLTRB(0, 0, width, height);
            range.ColumnWidth = 0.75;
            range.RowHeight = 0.75;
        }
        bool IsTransparentOrEmpty(Color color) {
            return color.A == 0;
        }
    }
}
