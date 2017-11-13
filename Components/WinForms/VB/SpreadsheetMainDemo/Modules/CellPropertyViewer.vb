Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Globalization
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Events
Imports DevExpress.Spreadsheet
Imports System.Diagnostics

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class CellPropertiesViewerModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Private workbook As IWorkbook
		Private sheet As Worksheet
		Private selectedCell As Range

		Public Sub New()
			InitializeComponent()
			InitializePropertyGrid()
			InitializeWorkbook()
			Me.spreadsheetControl1.Document.History.Clear()
		End Sub

		Protected Friend Overrides Sub SubscribeEvents()
			MyBase.SubscribeEvents()
			AddHandler spreadsheetControl1.ContentChanged, AddressOf spreadsheetControl1_ContentChanged
			AddHandler spreadsheetControl1.SelectionChanged, AddressOf spreadsheetControl1_SelectionChanged
		End Sub

		Private Sub spreadsheetControl1_ContentChanged(ByVal sender As Object, ByVal e As EventArgs)
			workbook = spreadsheetControl1.Document
			sheet = workbook.Worksheets.ActiveWorksheet
			selectedCell = sheet.SelectedCell
			propertyGridControl1.SelectedObject = New RangeAdapter(selectedCell)
		End Sub

		Private Sub spreadsheetControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			workbook = spreadsheetControl1.Document
			sheet = workbook.Worksheets.ActiveWorksheet
			If (Not sheet.SelectedCell.Equals(selectedCell)) Then
				selectedCell = sheet.SelectedCell
				propertyGridControl1.SelectedObject = New RangeAdapter(selectedCell)
			End If
		End Sub

		#Region "PropertyGrid initialization"
		Private Sub InitializePropertyGrid()
			Dim contentCategory As CategoryRow = AddCategoryRow(Nothing, "CellContent", "Cell content")
			AddEditorRow(contentCategory, "Cell.Formula", "Formula")
			AddEditorRow(contentCategory, "Cell.ArrayFormula", "ArrayFormula")

			Dim valueCategory As CategoryRow = AddCategoryRow(contentCategory, "Value", "Value")
			AddEditorRow(valueCategory, "Value.TextValue", "TextValue")
			AddEditorRow(valueCategory, "Value.BooleanValue", "BooleanValue")
			AddEditorRow(valueCategory, "Value.NumericValue", "NumericValue")
			AddEditorRow(valueCategory, "Value.ErrorValue", "ErrorValue")
			AddEditorRow(valueCategory, "Value.Type", "Type")

			Dim formattingCategory As CategoryRow = AddCategoryRow(Nothing, "Formatting", "Formatting")

			Dim numberFormatCategory As CategoryRow = AddCategoryRow(formattingCategory, "NumberFormat", "NumberFormat")
			AddEditorRow(numberFormatCategory, "NumberFormat", "NumberFormat")
			AddEditorRow(numberFormatCategory, "Cell.IsDisplayedAsDateTime", "IsDisplayedAsDateTime")

			Dim alignmentCategory As CategoryRow = AddCategoryRow(formattingCategory, "Alignment", "Alignment")
			AddEditorRow(alignmentCategory, "Alignment.Horizontal", "Horizontal")
			AddEditorRow(alignmentCategory, "Alignment.Vertical", "Vertical")
			AddEditorRow(alignmentCategory, "Alignment.Indent", "Indent")
			AddEditorRow(alignmentCategory, "Alignment.WrapText", "WrapText")

			Dim fillCategory As CategoryRow = AddCategoryRow(formattingCategory, "Fill", "Fill")
			AddEditorRow(fillCategory, "Fill.BackgroundColor", "Color")

			Dim fontCategory As CategoryRow = AddCategoryRow(formattingCategory, "Font", "Font")
			AddEditorRow(fontCategory, "Font.Color", "Color")
			AddEditorRow(fontCategory, "Font.Name", "Name")
			AddEditorRow(fontCategory, "Font.FontStyle", "FontStyle")
			AddEditorRow(fontCategory, "Font.Script", "Script")
			AddEditorRow(fontCategory, "Font.Size", "Size")
			AddEditorRow(fontCategory, "Font.Strikethrough", "Strikethrough")
			AddEditorRow(fontCategory, "Font.UnderlineType", "UnderlineType")

			Dim bordersCategory As CategoryRow = AddCategoryRow(formattingCategory, "Borders", "Borders")
			Dim diagBorderCategory As CategoryRow = AddCategoryRow(bordersCategory, "DiagonalBorder", "Diagonal")
			AddEditorRow(diagBorderCategory, "Borders.DiagonalBorderColor", "Color")
			AddEditorRow(diagBorderCategory, "Borders.DiagonalBorderLineStyle", "LineStyle")
			AddEditorRow(diagBorderCategory, "Borders.DiagonalBorderType", "Type")

			Dim leftBorderCategory As CategoryRow = AddCategoryRow(bordersCategory, "LeftBorder", "Left")
			AddEditorRow(leftBorderCategory, "LeftBorder.Color", "Color")
			AddEditorRow(leftBorderCategory, "LeftBorder.LineStyle", "LineStyle")

			Dim topBorderCategory As CategoryRow = AddCategoryRow(bordersCategory, "TopBorder", "Top")
			AddEditorRow(topBorderCategory, "TopBorder.Color", "Color")
			AddEditorRow(topBorderCategory, "TopBorder.LineStyle", "LineStyle")

			Dim rightBorderCategory As CategoryRow = AddCategoryRow(bordersCategory, "RightBorder", "Right")
			AddEditorRow(rightBorderCategory, "RightBorder.Color", "Color")
			AddEditorRow(rightBorderCategory, "RightBorder.LineStyle", "LineStyle")

			Dim bottomBorderCategory As CategoryRow = AddCategoryRow(bordersCategory, "BottomBorder", "Bottom")
			AddEditorRow(bottomBorderCategory, "BottomBorder.Color", "Color")
			AddEditorRow(bottomBorderCategory, "BottomBorder.LineStyle", "LineStyle")

			Dim styleCategory As CategoryRow = AddCategoryRow(formattingCategory, "Style", "Style")
			AddEditorRow(styleCategory, "Style.Name", "Name")

			Dim layoutCategory As CategoryRow = AddCategoryRow(Nothing, "Layout", "Layout")
			AddEditorRow(layoutCategory, "Cell.ColumnWidth", "Width")
			AddEditorRow(layoutCategory, "Cell.ColumnWidthInCharacters", "WidthInCharacters")
			AddEditorRow(layoutCategory, "Cell.RowHeight", "Height")

			Dim protectionCategory As CategoryRow = AddCategoryRow(Nothing, "Protection", "Protection")
			AddEditorRow(protectionCategory, "Protection.Locked", "Locked")

			bordersCategory.Expanded = False
		End Sub
		Private Function AddCategoryRow(ByVal parent As CategoryRow, ByVal name As String, ByVal caption As String) As CategoryRow
			Dim result As New CategoryRow(name)
			result.Properties.Caption = caption
			If parent Is Nothing Then
				propertyGridControl1.Rows.Add(result)
			Else
				parent.ChildRows.Add(result)
			End If
			Return result
		End Function
		Private Sub AddEditorRow(ByVal parent As CategoryRow, ByVal name As String, ByVal caption As String)
			Dim row As New EditorRow(name)
			row.Properties.Caption = caption
			parent.ChildRows.Add(row)
		End Sub
		#End Region
		#Region "Sample workbook initialization"
		Private Sub InitializeWorkbook()
			workbook = spreadsheetControl1.Document
			workbook.LoadDocument(DemoUtils.GetRelativePath("CellPropertiesViewer_template.xlsx"))
		End Sub
		#End Region

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			spreadsheetControl1.Focus()
		End Sub
	End Class
	Public Class RangeAdapter
		Private range As Range

		Public Sub New(ByVal range As Range)
			Me.range = range
		End Sub

		Public ReadOnly Property Cell() As Cell
			Get
				Return range.Worksheet.Cells(range.TopRowIndex, range.LeftColumnIndex)
			End Get
		End Property
		Public ReadOnly Property Value() As CellValue
			Get
				Return range.Value
			End Get
		End Property
		Public ReadOnly Property Alignment() As Alignment
			Get
				Return range.Alignment
			End Get
		End Property
		Public ReadOnly Property Borders() As Borders
			Get
				Return range.Borders
			End Get
		End Property
		Public ReadOnly Property LeftBorder() As Border
			Get
				Return range.Borders.LeftBorder
			End Get
		End Property
		Public ReadOnly Property TopBorder() As Border
			Get
				Return range.Borders.TopBorder
			End Get
		End Property
		Public ReadOnly Property RightBorder() As Border
			Get
				Return range.Borders.RightBorder
			End Get
		End Property
		Public ReadOnly Property BottomBorder() As Border
			Get
				Return range.Borders.BottomBorder
			End Get
		End Property
		Public ReadOnly Property Fill() As Fill
			Get
				Return range.Fill
			End Get
		End Property
		Public ReadOnly Property Font() As DevExpress.Spreadsheet.SpreadsheetFont
			Get
				Return range.Font
			End Get
		End Property
		Public ReadOnly Property Protection() As Protection
			Get
				Return range.Protection
			End Get
		End Property
		Public ReadOnly Property Style() As Style
			Get
				Return range.Style
			End Get
		End Property
		Public Property NumberFormat() As String
			Get
				Return Cell.NumberFormat
			End Get
			Set(ByVal value As String)
				Cell.NumberFormat = value
			End Set
		End Property
	End Class
End Namespace
