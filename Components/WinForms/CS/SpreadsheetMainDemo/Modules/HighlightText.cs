using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using DevExpress.BarCodes;
using DevExpress.Docs.Demos;
using DevExpress.Docs.Text;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Demos;
using DevExpress.Spreadsheet.Functions;
using DevExpress.Utils;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class HighlightTextModule : SpreadsheetRibbonTutorialControlBase {
        public HighlightTextModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("HighlightText_template.xlsx"));
            spreadsheetControl1.CustomDrawCell += HighlightCellText;
        }
        void HighlightCellText(object sender, CustomDrawCellEventArgs e) {
            if (String.IsNullOrEmpty(teHighlightText.Text))
                return;

            string cellText = e.Cell.DisplayText;
            int index = cellText.IndexOf(teHighlightText.Text, StringComparison.InvariantCultureIgnoreCase);
            if (index >= 0) {
                StringFormat format = (StringFormat)StringFormat.GenericTypographic.Clone();
                format.Alignment = CalculateStringAlignment(e.Cell.Alignment.Horizontal);
                format.SetMeasurableCharacterRanges(new CharacterRange[] { new CharacterRange(index, teHighlightText.Text.Length) });
                Region[] regions = e.Graphics.MeasureCharacterRanges(cellText, e.Font, e.Bounds, format);
                RectangleF firstChar = regions[0].GetBounds(e.Graphics);
                RectangleF lastChar = regions[regions.Length - 1].GetBounds(e.Graphics);
                RectangleF highlightBounds = RectangleF.FromLTRB(Math.Min(firstChar.Left, lastChar.Left), e.Bounds.Top + 2, Math.Max(firstChar.Right, lastChar.Right), e.Bounds.Bottom - 2);
                e.Cache.FillRectangle(e.Cache.GetSolidBrush(Color.Yellow), highlightBounds);
            }
        }
        StringAlignment CalculateStringAlignment(SpreadsheetHorizontalAlignment cellHorizontalAlignment) {
            switch (cellHorizontalAlignment) {
                case SpreadsheetHorizontalAlignment.Center:
                    return StringAlignment.Center;
                case SpreadsheetHorizontalAlignment.CenterContinuous:
                    return StringAlignment.Center;

                case SpreadsheetHorizontalAlignment.Right:
                    return StringAlignment.Far;
                default:
                    return StringAlignment.Near;
            }
        }
        void teHighlightText_EditValueChanging(object sender, XtraEditors.Controls.ChangingEventArgs e) {
            spreadsheetControl1.Refresh();
            teHighlightText.Focus();
        }
    }
}
