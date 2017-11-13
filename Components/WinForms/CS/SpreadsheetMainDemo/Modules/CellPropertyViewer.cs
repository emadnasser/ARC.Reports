using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using DevExpress.DXperience.Demos;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.Spreadsheet;
using System.Diagnostics;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class CellPropertiesViewerModule : SpreadsheetRibbonTutorialControlBase {
        IWorkbook workbook;
        Worksheet sheet;
        Range selectedCell;

        public CellPropertiesViewerModule() {
            InitializeComponent();
            InitializePropertyGrid();
            InitializeWorkbook();
            this.spreadsheetControl1.Document.History.Clear();
        }

        protected internal override void SubscribeEvents() {
            base.SubscribeEvents();
            spreadsheetControl1.ContentChanged += spreadsheetControl1_ContentChanged;
            spreadsheetControl1.SelectionChanged += spreadsheetControl1_SelectionChanged;
        }

        void spreadsheetControl1_ContentChanged(object sender, EventArgs e) {
            workbook = spreadsheetControl1.Document;
            sheet = workbook.Worksheets.ActiveWorksheet;
            selectedCell = sheet.SelectedCell;
            propertyGridControl1.SelectedObject = new RangeAdapter(selectedCell);
        }

        void spreadsheetControl1_SelectionChanged(object sender, EventArgs e) {
            workbook = spreadsheetControl1.Document;
            sheet = workbook.Worksheets.ActiveWorksheet;
            if (!sheet.SelectedCell.Equals(selectedCell)) {
                selectedCell = sheet.SelectedCell;
                propertyGridControl1.SelectedObject = new RangeAdapter(selectedCell);
            }
        }

        #region PropertyGrid initialization
        void InitializePropertyGrid() {
            CategoryRow contentCategory = AddCategoryRow(null, "CellContent", "Cell content");
            AddEditorRow(contentCategory, "Cell.Formula", "Formula");
            AddEditorRow(contentCategory, "Cell.ArrayFormula", "ArrayFormula");

            CategoryRow valueCategory = AddCategoryRow(contentCategory, "Value", "Value");
            AddEditorRow(valueCategory, "Value.TextValue", "TextValue");
            AddEditorRow(valueCategory, "Value.BooleanValue", "BooleanValue");
            AddEditorRow(valueCategory, "Value.NumericValue", "NumericValue");
            AddEditorRow(valueCategory, "Value.ErrorValue", "ErrorValue");
            AddEditorRow(valueCategory, "Value.Type", "Type");

            CategoryRow formattingCategory = AddCategoryRow(null, "Formatting", "Formatting");

            CategoryRow numberFormatCategory = AddCategoryRow(formattingCategory, "NumberFormat", "NumberFormat");
            AddEditorRow(numberFormatCategory, "NumberFormat", "NumberFormat");
            AddEditorRow(numberFormatCategory, "Cell.IsDisplayedAsDateTime", "IsDisplayedAsDateTime");

            CategoryRow alignmentCategory = AddCategoryRow(formattingCategory, "Alignment", "Alignment");
            AddEditorRow(alignmentCategory, "Alignment.Horizontal", "Horizontal");
            AddEditorRow(alignmentCategory, "Alignment.Vertical", "Vertical");
            AddEditorRow(alignmentCategory, "Alignment.Indent", "Indent");
            AddEditorRow(alignmentCategory, "Alignment.WrapText", "WrapText");

            CategoryRow fillCategory = AddCategoryRow(formattingCategory, "Fill", "Fill");
            AddEditorRow(fillCategory, "Fill.BackgroundColor", "Color");

            CategoryRow fontCategory = AddCategoryRow(formattingCategory, "Font", "Font");
            AddEditorRow(fontCategory, "Font.Color", "Color");
            AddEditorRow(fontCategory, "Font.Name", "Name");
            AddEditorRow(fontCategory, "Font.FontStyle", "FontStyle");
            AddEditorRow(fontCategory, "Font.Script", "Script");
            AddEditorRow(fontCategory, "Font.Size", "Size");
            AddEditorRow(fontCategory, "Font.Strikethrough", "Strikethrough");
            AddEditorRow(fontCategory, "Font.UnderlineType", "UnderlineType");

            CategoryRow bordersCategory = AddCategoryRow(formattingCategory, "Borders", "Borders");
            CategoryRow diagBorderCategory = AddCategoryRow(bordersCategory, "DiagonalBorder", "Diagonal");
            AddEditorRow(diagBorderCategory, "Borders.DiagonalBorderColor", "Color");
            AddEditorRow(diagBorderCategory, "Borders.DiagonalBorderLineStyle", "LineStyle");
            AddEditorRow(diagBorderCategory, "Borders.DiagonalBorderType", "Type");

            CategoryRow leftBorderCategory = AddCategoryRow(bordersCategory, "LeftBorder", "Left");
            AddEditorRow(leftBorderCategory, "LeftBorder.Color", "Color");
            AddEditorRow(leftBorderCategory, "LeftBorder.LineStyle", "LineStyle");

            CategoryRow topBorderCategory = AddCategoryRow(bordersCategory, "TopBorder", "Top");
            AddEditorRow(topBorderCategory, "TopBorder.Color", "Color");
            AddEditorRow(topBorderCategory, "TopBorder.LineStyle", "LineStyle");

            CategoryRow rightBorderCategory = AddCategoryRow(bordersCategory, "RightBorder", "Right");
            AddEditorRow(rightBorderCategory, "RightBorder.Color", "Color");
            AddEditorRow(rightBorderCategory, "RightBorder.LineStyle", "LineStyle");

            CategoryRow bottomBorderCategory = AddCategoryRow(bordersCategory, "BottomBorder", "Bottom");
            AddEditorRow(bottomBorderCategory, "BottomBorder.Color", "Color");
            AddEditorRow(bottomBorderCategory, "BottomBorder.LineStyle", "LineStyle");

            CategoryRow styleCategory = AddCategoryRow(formattingCategory, "Style", "Style");
            AddEditorRow(styleCategory, "Style.Name", "Name");

            CategoryRow layoutCategory = AddCategoryRow(null, "Layout", "Layout");
            AddEditorRow(layoutCategory, "Cell.ColumnWidth", "Width");
            AddEditorRow(layoutCategory, "Cell.ColumnWidthInCharacters", "WidthInCharacters");
            AddEditorRow(layoutCategory, "Cell.RowHeight", "Height");

            CategoryRow protectionCategory = AddCategoryRow(null, "Protection", "Protection");
            AddEditorRow(protectionCategory, "Protection.Locked", "Locked");

            bordersCategory.Expanded = false;
        }
        CategoryRow AddCategoryRow(CategoryRow parent, string name, string caption) {
            CategoryRow result = new CategoryRow(name);
            result.Properties.Caption = caption;
            if (parent == null)
                propertyGridControl1.Rows.Add(result);
            else
                parent.ChildRows.Add(result);
            return result;
        }
        void AddEditorRow(CategoryRow parent, string name, string caption) {
            EditorRow row = new EditorRow(name);
            row.Properties.Caption = caption;
            parent.ChildRows.Add(row);
        }
        #endregion
        #region Sample workbook initialization
        void InitializeWorkbook() {
            workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(DemoUtils.GetRelativePath("CellPropertiesViewer_template.xlsx"));
        }
        #endregion

        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
        }
    }
    public class RangeAdapter {
        Range range;

        public RangeAdapter(Range range) {
            this.range = range;
        }

        public Cell Cell { get { return range.Worksheet.Cells[range.TopRowIndex, range.LeftColumnIndex]; } }
        public CellValue Value { get { return range.Value; } }
        public Alignment Alignment { get { return range.Alignment; } }
        public Borders Borders { get { return range.Borders; } }
        public Border LeftBorder { get { return range.Borders.LeftBorder; } }
        public Border TopBorder { get { return range.Borders.TopBorder; } }
        public Border RightBorder { get { return range.Borders.RightBorder; } }
        public Border BottomBorder { get { return range.Borders.BottomBorder; } }
        public Fill Fill { get { return range.Fill; } }
        public DevExpress.Spreadsheet.SpreadsheetFont Font { get { return range.Font; } }
        public Protection Protection { get { return range.Protection; } }
        public Style Style { get { return range.Style; } }
        public string NumberFormat { get { return Cell.NumberFormat; } set { Cell.NumberFormat = value; } }
    }
}
