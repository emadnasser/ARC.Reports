Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Utils

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class ConditionalFormattingModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl

		Public Sub New()
			InitializeComponent()
			OpenXmlLoadHelper.Load("ConditionalFormatting.docx", richEditControl)
			CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()

			Dim style As TableStyle = Me.richEditControl.Document.TableStyles(1)

			Dim table As Table = Me.richEditControl.Document.Tables(0)
			table.Style = style

			table.Style.TableCellBorders.Bottom.LineStyle = TableBorderLineStyle.None
			table.Style.TableCellBorders.Left.LineStyle = TableBorderLineStyle.None
			table.Style.TableCellBorders.Right.LineStyle = TableBorderLineStyle.None
			table.Style.TableCellBorders.Top.LineStyle = TableBorderLineStyle.None

			Dim wholeTable As TableConditionalStyle = style.ConditionalStyleProperties.CreateConditionalStyle(ConditionalTableStyleFormattingTypes.WholeTable)
			wholeTable.FontName = "Segoe UI Symbol"
			wholeTable.FontSize = 10
			wholeTable.Alignment = ParagraphAlignment.Center

			wholeTable.TableBorders.Bottom.LineStyle = TableBorderLineStyle.None
			wholeTable.TableBorders.Left.LineStyle = TableBorderLineStyle.None
			wholeTable.TableBorders.Right.LineStyle = TableBorderLineStyle.None
			wholeTable.TableBorders.Top.LineStyle = TableBorderLineStyle.None
			wholeTable.TableBorders.InsideHorizontalBorder.LineStyle = TableBorderLineStyle.None
			wholeTable.TableBorders.InsideVerticalBorder.LineStyle = TableBorderLineStyle.None

			Dim firstRow As TableConditionalStyle = style.ConditionalStyleProperties.CreateConditionalStyle(ConditionalTableStyleFormattingTypes.FirstRow)
			firstRow.FontName = "Segoe UI Semibold"
			firstRow.FontSize = 12
			firstRow.CellBottomPadding = 100
			firstRow.LineSpacing = 100

			Dim firstColumn As TableConditionalStyle = style.ConditionalStyleProperties.CreateConditionalStyle(ConditionalTableStyleFormattingTypes.FirstColumn)
			firstColumn.FontName = "Segoe UI Semibold"
			firstColumn.FontSize = 12
			firstColumn.Alignment = ParagraphAlignment.Right

			Dim oddColumnBanding As TableConditionalStyle = style.ConditionalStyleProperties.CreateConditionalStyle(ConditionalTableStyleFormattingTypes.OddColumnBanding)

			oddColumnBanding.TableCellBorders.Left.LineColor = DXColor.FromArgb(216, 216, 216)
			oddColumnBanding.TableCellBorders.Left.LineStyle = TableBorderLineStyle.Single
			oddColumnBanding.TableCellBorders.Left.LineThickness = 0.5F

			oddColumnBanding.TableCellBorders.Right.LineColor = DXColor.FromArgb(216, 216, 216)
			oddColumnBanding.TableCellBorders.Right.LineStyle = TableBorderLineStyle.Single
			oddColumnBanding.TableCellBorders.Right.LineThickness = 0.5F

			Dim oddRowBanding As TableConditionalStyle = style.ConditionalStyleProperties.CreateConditionalStyle(ConditionalTableStyleFormattingTypes.OddRowBanding)
			oddRowBanding.CellBackgroundColor = DXColor.FromArgb(216, 223, 242)

			table.TableLook = TableLookTypes.ApplyFirstRow Or TableLookTypes.ApplyFirstColumn
		End Sub
	End Class
End Namespace
