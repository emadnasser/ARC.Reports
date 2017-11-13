using System;
using DevExpress.Spreadsheet;
using System.Drawing;

namespace SpreadsheetExamples {
    public static class RowAndColumnActions {
        static void InsertRows(IWorkbook workbook) {
            #region #InsertRows
            Worksheet worksheet = workbook.Worksheets[0];
            for (int i = 0; i < 10; i++) {
                worksheet.Cells[i, 0].Value = i + 1;
                worksheet.Cells[0, i].Value = i + 1;
            }
            worksheet.Rows.Insert(2);
            worksheet.Rows.Insert(7, 5);
            #endregion #InsertRows
        }
        static void InsertColumns(IWorkbook workbook) {
            #region #InsertColumns
            Worksheet worksheet = workbook.Worksheets[0];
            for (int i = 0; i < 10; i++) {
                worksheet.Cells[i, 0].Value = i + 1;
                worksheet.Cells[0, i].Value = i + 1;
            }
            worksheet.Columns.Insert(4);
            worksheet.Columns.Insert(6, 3);
            #endregion #InsertColumns
        }

        static void DeleteRowsColumns(IWorkbook workbook) {
            #region #DeleteRows
            Worksheet worksheet = workbook.Worksheets["Sheet1"];
            for (int i = 0; i < 15; i++) {
                worksheet.Cells[i, 0].Value = i + 1;
                worksheet.Cells[0, i].Value = i + 1;
            }
            worksheet.Rows.Remove(1);
            worksheet.Rows[2].Delete();
            workbook.Worksheets[0].Rows.Remove(9, 3);
            #endregion #DeleteRows

            #region #DeleteRowsBasedOnCondition

            Worksheet worksheet1 = workbook.Worksheets["Sheet1"];
            Func<int, bool> rowRemovalCondition = x => worksheet1.Cells[x, 0].Value.NumericValue > 3.0 && worksheet1.Cells[x, 0].Value.NumericValue < 14.0;
            for (int i = 0; i < 15; i++) {
                worksheet1.Cells[i, 0].Value = i + 1;
                worksheet1.Cells[0, i].Value = i + 1;
            }
            worksheet1.Rows.Remove(7, rowRemovalCondition);


            #endregion #DeleteRowsBasedOnCondition

            #region #DeleteColumns
            Worksheet worksheet2 = workbook.Worksheets["Sheet1"];
            for (int i = 0; i < 15; i++) {
                worksheet2.Cells[i, 0].Value = i + 1;
                worksheet2.Cells[0, i].Value = i + 1;
            }
            worksheet2.Columns.Remove(1);
            worksheet2.Columns[2].Delete();
            workbook.Worksheets[0].Columns.Remove(9, 3);
            #endregion #DeleteColumns

            #region #DeleteColumnsBasedOnCondition

            Worksheet sheet = workbook.Worksheets["Sheet1"];
            Func<int, bool> columnRemovalCondition = x => sheet.Cells[0, x].Value.NumericValue > 3.0 && sheet.Cells[0, x].Value.NumericValue < 14.0;
            for (int i = 0; i < 15; i++) {
                sheet.Cells[i, 0].Value = i + 1;
                sheet.Cells[0, i].Value = i + 1;
            }
            sheet.Columns.Remove(7, columnRemovalCondition);


            #endregion #DeleteColumnsBasedOnCondition
        }

        static void CopyRowsColumns(IWorkbook workbook) {
            #region CopyRows

            #endregion CopyRows

            #region CopyColumns

            #endregion CopyColumns
        }

        static void ShowHideRowsColumns(IWorkbook workbook) {
            #region ShowHideRowsColumns
            Worksheet worksheet = workbook.Worksheets[0];
            worksheet.Rows[7].Visible = false;
            worksheet.Columns[3].Visible = false;
            for (int i = 0; i < 10; i++) {
                worksheet.Cells[i, 0].Value = i + 1;
                worksheet.Cells[0, i].Value = i + 1;
            }
            #endregion ShowHideRowsColumns
        }

        static void SpecifyRowsHeightColumnsWidth(IWorkbook workbook) {
            #region #RowHeightAndColumnWidth
            Worksheet worksheet = workbook.Worksheets[0];
            workbook.Unit = DevExpress.Office.DocumentUnit.Point;
            worksheet.Rows[1].Height = 50;
            workbook.Unit = DevExpress.Office.DocumentUnit.Inch;
            worksheet.Cells["C3"].RowHeight = 1;
            worksheet.Rows["4"].Height = worksheet.Rows["2"].Height;
            workbook.Unit = DevExpress.Office.DocumentUnit.Point;
            worksheet.DefaultRowHeight = 30;
            worksheet.Columns["B"].WidthInCharacters = 15;
            workbook.Unit = DevExpress.Office.DocumentUnit.Millimeter;
            worksheet.Columns["C"].Width = 15;
            workbook.Unit = DevExpress.Office.DocumentUnit.Point;
            worksheet.Cells["E15"].ColumnWidth = 100;
            worksheet.Range["F4:H7"].ColumnWidth = 70;
            worksheet.Columns["J"].Width = worksheet.Columns["B"].Width;
            worksheet.DefaultColumnWidthInPixels = 40;
            worksheet.Range["B1:J1"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Cells["B1"].Value = "15 characters";
            worksheet.Cells["C1"].Value = "15 mm";
            worksheet.Cells["E1"].Value = "100 pt";
            worksheet.Cells["F1"].Value = "70 pt";
            worksheet.Cells["G1"].Value = "70 pt";
            worksheet.Cells["H1"].Value = "70 pt";
            worksheet.Cells["J1"].Value = "15 characters";

            worksheet.Cells["A2"].Value = "50 pt";
            worksheet.Cells["A3"].Value = "1\"";
            worksheet.Cells["A4"].Value = "50 pt";
            Range range = worksheet.Range["A2:A5"];
            Formatting rowHeightValues = range.BeginUpdateFormatting();
            rowHeightValues.Alignment.RotationAngle = 90;
            rowHeightValues.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
            rowHeightValues.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            range.EndUpdateFormatting(rowHeightValues);

            #endregion RowHeightAndColumnWidth
        }
    }
}
