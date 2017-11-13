using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Utils;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class ConditionalFormattingModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public ConditionalFormattingModule() {
            InitializeComponent();
            OpenXmlLoadHelper.Load("ConditionalFormatting.docx", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();

            TableStyle style = this.richEditControl.Document.TableStyles[1];

            Table table = this.richEditControl.Document.Tables[0];
            table.Style = style;

            table.Style.TableCellBorders.Bottom.LineStyle = TableBorderLineStyle.None;
            table.Style.TableCellBorders.Left.LineStyle = TableBorderLineStyle.None;
            table.Style.TableCellBorders.Right.LineStyle = TableBorderLineStyle.None;
            table.Style.TableCellBorders.Top.LineStyle = TableBorderLineStyle.None;

            TableConditionalStyle wholeTable = style.ConditionalStyleProperties.CreateConditionalStyle(ConditionalTableStyleFormattingTypes.WholeTable);
            wholeTable.FontName = "Segoe UI Symbol";
            wholeTable.FontSize = 10;
            wholeTable.Alignment = ParagraphAlignment.Center;

            wholeTable.TableBorders.Bottom.LineStyle = TableBorderLineStyle.None;
            wholeTable.TableBorders.Left.LineStyle = TableBorderLineStyle.None;
            wholeTable.TableBorders.Right.LineStyle = TableBorderLineStyle.None;
            wholeTable.TableBorders.Top.LineStyle = TableBorderLineStyle.None;
            wholeTable.TableBorders.InsideHorizontalBorder.LineStyle = TableBorderLineStyle.None;
            wholeTable.TableBorders.InsideVerticalBorder.LineStyle = TableBorderLineStyle.None;

            TableConditionalStyle firstRow = style.ConditionalStyleProperties.CreateConditionalStyle(ConditionalTableStyleFormattingTypes.FirstRow);
            firstRow.FontName = "Segoe UI Semibold";
            firstRow.FontSize = 12;
            firstRow.CellBottomPadding = 100;
            firstRow.LineSpacing = 100;

            TableConditionalStyle firstColumn = style.ConditionalStyleProperties.CreateConditionalStyle(ConditionalTableStyleFormattingTypes.FirstColumn);
            firstColumn.FontName = "Segoe UI Semibold";
            firstColumn.FontSize = 12;
            firstColumn.Alignment = ParagraphAlignment.Right;

            TableConditionalStyle oddColumnBanding = style.ConditionalStyleProperties.CreateConditionalStyle(ConditionalTableStyleFormattingTypes.OddColumnBanding);

            oddColumnBanding.TableCellBorders.Left.LineColor = DXColor.FromArgb(216, 216, 216);
            oddColumnBanding.TableCellBorders.Left.LineStyle = TableBorderLineStyle.Single;
            oddColumnBanding.TableCellBorders.Left.LineThickness = 0.5F;

            oddColumnBanding.TableCellBorders.Right.LineColor = DXColor.FromArgb(216, 216, 216);
            oddColumnBanding.TableCellBorders.Right.LineStyle = TableBorderLineStyle.Single;
            oddColumnBanding.TableCellBorders.Right.LineThickness = 0.5F;

            TableConditionalStyle oddRowBanding = style.ConditionalStyleProperties.CreateConditionalStyle(ConditionalTableStyleFormattingTypes.OddRowBanding);
            oddRowBanding.CellBackgroundColor = DXColor.FromArgb(216, 223, 242);

            table.TableLook = TableLookTypes.ApplyFirstRow | TableLookTypes.ApplyFirstColumn;
        }
    }
}
