Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.BarCodes
Imports DevExpress.Docs.Demos
Imports DevExpress.Docs.Text
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos
Imports DevExpress.Spreadsheet.Functions
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class CustomDrawModule
		Inherits SpreadsheetRibbonTutorialControlBase
		#Region "Fields"
		Private Const IncorectData As String = "Incorrect parameter values"
		Private Shared tipFont As New System.Drawing.Font("Arial", 11)
		Private book As IWorkbook
		Private generator As CustomDrawDocumentGenerator
		Private definedNames As DefinedNameCollection
		Private areaFormulaValidators As New List(Of IAreaFormulaValidator)()
		#End Region

		Public Sub New()
			InitializeComponent()
			spreadsheetControl1.Options.Culture = DefaultCulture
			spreadsheetControl1.BeginUpdate()
			book = spreadsheetControl1.Document
			generator = New CustomDrawDocumentGenerator(book)
			book = generator.Generate(DemoUtils.GetRelativePath("CalculatorOfArea_template.xlsx"))
			definedNames = book.DefinedNames
			FillAreaFormulaValidators()
			AddHandler spreadsheetControl1.CustomDrawCell, AddressOf DrawFormulaTip
			AddHandler spreadsheetControl1.CustomDrawCellBackground, AddressOf spreadsheetControl1_CustomDrawCellBackground
			spreadsheetControl1.EndUpdate()
			spreadsheetControl1.Document.History.Clear()
		End Sub
		Private Sub FillAreaFormulaValidators()
			areaFormulaValidators.Add(New Triangle1AreaFormulaValidator(definedNames))
			areaFormulaValidators.Add(New Triangle2AreaFormulaValidator(definedNames))
			areaFormulaValidators.Add(New Triangle3AreaFormulaValidator(definedNames))
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			spreadsheetControl1.Focus()
		End Sub
		Private Sub spreadsheetControl1_CustomDrawCellBackground(ByVal sender As Object, ByVal e As CustomDrawCellBackgroundEventArgs)
			If String.IsNullOrEmpty(e.Cell.Formula) Then
				Return
			End If

			For Each validator As IAreaFormulaValidator In areaFormulaValidators
				If validator.IsAreaFormulaCell(e.Cell) Then
					DrawCellFill(e, (Not validator.IsValidParams()) AndAlso cуHighlightErrors.Checked)

					Return
				End If
			Next validator
		End Sub
		Private Sub DrawCellFill(ByVal e As CustomDrawCellBackgroundEventArgs, ByVal isError As Boolean)
			e.BackColor = If(isError, DXColor.FromArgb(&HFF, &HA5, &HA5), DXColor.Empty)
		End Sub
		Private Sub DrawFormulaTip(ByVal sender As Object, ByVal e As CustomDrawCellEventArgs)
			If String.IsNullOrEmpty(e.Cell.Formula) Then
				Return
			End If

			For Each validator As IAreaFormulaValidator In areaFormulaValidators
				If ceDisplayFCallouts.Checked AndAlso validator.IsAreaFormulaCell(e.Cell) Then
					DrawErrorTooltip(e, (Not validator.IsValidParams()))

					Return
				End If
			Next validator
		End Sub
		Private Sub DrawErrorTooltip(ByVal e As CustomDrawCellEventArgs, ByVal isError As Boolean)
			e.Handled = True
			e.DrawDefault()

			Const alpha As Integer = 255
			Dim foreColor As Color = GetSemitransparentColor(SystemColors.InfoText, alpha)
			Dim backColor As Color = GetSemitransparentColor(SystemColors.Info, alpha)
			Dim font As System.Drawing.Font = tipFont
			Dim bounds As Rectangle = e.Bounds
			Dim text As String = If(isError, IncorectData, e.Cell.Formula)
			Dim size As SizeF = e.Graphics.MeasureString(text, font, Int32.MaxValue, StringFormat.GenericDefault)
			Dim tooltipSize As New Size(CInt(Fix(Math.Round(size.Width))), CInt(Fix(Math.Round(size.Height))))
			Dim textBounds As New Rectangle(bounds.X + 1, bounds.Y - tooltipSize.Height - 2, tooltipSize.Width+3, tooltipSize.Height)
			Dim markerBounds As Rectangle = textBounds
			markerBounds.Inflate(2, 1)
			Dim points() As Point = { New Point(markerBounds.Left, markerBounds.Top), New Point(markerBounds.Right, markerBounds.Top), New Point(markerBounds.Right, markerBounds.Bottom), New Point(markerBounds.Left + Math.Min(e.FillBounds.Height \ 4, markerBounds.Height \ 2), markerBounds.Bottom), New Point(markerBounds.Left, markerBounds.Bottom + e.FillBounds.Height \ 2), New Point(markerBounds.Left, markerBounds.Top) }
			e.Graphics.FillPolygon(e.Cache.GetSolidBrush(backColor), points)
			e.Graphics.DrawPolygon(e.Cache.GetPen(foreColor), points)
			e.Graphics.DrawString(text, font, e.Cache.GetSolidBrush(foreColor), textBounds, StringFormat.GenericDefault)
		End Sub
		Private Function GetSemitransparentColor(ByVal color As Color, ByVal alpha As Integer) As Color
			Return Color.FromArgb(alpha, color.R, color.G, color.B)
		End Function

		Private Sub checkEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceDisplayFCallouts.CheckedChanged, cуHighlightErrors.CheckedChanged
			spreadsheetControl1.Refresh()
		End Sub
	End Class
	Public Interface IAreaFormulaValidator
		Function IsAreaFormulaCell(ByVal cell As Cell) As Boolean
		Function IsValidParams() As Boolean
		ReadOnly Property AreaFormulaDefinedName() As String
	End Interface
	Public MustInherit Class AreaFormulaValidatorBase
		Implements IAreaFormulaValidator
		Private ReadOnly definedNames As DefinedNameCollection
		Protected Const MaxAnglesInQuadrangle As Integer = 180

		Protected Sub New(ByVal definedNames As DefinedNameCollection)
			Me.definedNames = definedNames
		End Sub

		Public MustOverride ReadOnly Property AreaFormulaDefinedName() As String Implements IAreaFormulaValidator.AreaFormulaDefinedName
		Public MustOverride Function IsValidParams() As Boolean Implements IAreaFormulaValidator.IsValidParams

		Public Function IsAreaFormulaCell(ByVal cell As Cell) As Boolean Implements IAreaFormulaValidator.IsAreaFormulaCell
			If (Not definedNames.Contains(AreaFormulaDefinedName)) Then
				Return False
			End If
			Dim definedNameRange As Range = definedNames.GetDefinedName(AreaFormulaDefinedName).Range
			Return cell.Worksheet.Name = definedNameRange.Worksheet.Name AndAlso cell.TopRowIndex = definedNameRange.TopRowIndex AndAlso cell.LeftColumnIndex = definedNameRange.LeftColumnIndex AndAlso cell.BottomRowIndex = definedNameRange.BottomRowIndex AndAlso cell.RightColumnIndex = definedNameRange.RightColumnIndex
		End Function
		Protected Function IsNumericAndGreaterThenZero(ByVal value As CellValue) As Boolean
			Return value.IsNumeric AndAlso value.NumericValue > 0
		End Function
		Protected Function DefinedNameNamericCellValue(ByVal df As String) As CellValue
			Return definedNames.GetDefinedName(df).Range.Value
		End Function
	End Class
	Public Class Triangle1AreaFormulaValidator
		Inherits AreaFormulaValidatorBase
		Private Const DF_Triangle1_A As String = "Triangle1_A"
		Private Const DF_Triangle1_B As String = "Triangle1_B"
		Private Const DF_Triangle1_Alpha As String = "Triangle1_Alpha"
		Private Const DF_Triangle1_Area As String = "Triangle1_Area"
		Protected Const AnglesSumInTriangle As Integer = 180

		Public Sub New(ByVal definedNames As DefinedNameCollection)
			MyBase.New(definedNames)
		End Sub

		Public Overrides ReadOnly Property AreaFormulaDefinedName() As String
			Get
				Return DF_Triangle1_Area
			End Get
		End Property
		Public Overrides Function IsValidParams() As Boolean
			Dim a As CellValue = DefinedNameNamericCellValue(DF_Triangle1_A)
			Dim b As CellValue = DefinedNameNamericCellValue(DF_Triangle1_B)
			Dim alpha As CellValue = DefinedNameNamericCellValue(DF_Triangle1_Alpha)

			Return IsNumericAndGreaterThenZero(a) AndAlso IsNumericAndGreaterThenZero(b) AndAlso IsNumericAndGreaterThenZero(alpha) AndAlso alpha.NumericValue < AnglesSumInTriangle
		End Function
	End Class
	Public Class Triangle2AreaFormulaValidator
		Inherits AreaFormulaValidatorBase
		Private Const DF_Triangle2_A As String = "Triangle2_A"
		Private Const DF_Triangle2_H As String = "Triangle2_H"
		Private Const DF_Triangle2_Area As String = "Triangle2_Area"

		Public Sub New(ByVal definedNames As DefinedNameCollection)
			MyBase.New(definedNames)
		End Sub

		Public Overrides ReadOnly Property AreaFormulaDefinedName() As String
			Get
				Return DF_Triangle2_Area
			End Get
		End Property
		Public Overrides Function IsValidParams() As Boolean
			Dim a As CellValue = DefinedNameNamericCellValue(DF_Triangle2_A)
			Dim h As CellValue = DefinedNameNamericCellValue(DF_Triangle2_H)

			Return IsNumericAndGreaterThenZero(a) AndAlso IsNumericAndGreaterThenZero(h)
		End Function
	End Class
	Public Class Triangle3AreaFormulaValidator
		Inherits AreaFormulaValidatorBase
		Private Const DF_Triangle3_A As String = "Triangle3_A"
		Private Const DF_Triangle3_B As String = "Triangle3_B"
		Private Const DF_Triangle3_C As String = "Triangle3_С"
		Private Const DF_Triangle3_Area As String = "Triangle3_Area"

		Public Sub New(ByVal definedNames As DefinedNameCollection)
			MyBase.New(definedNames)
		End Sub

		Public Overrides ReadOnly Property AreaFormulaDefinedName() As String
			Get
				Return DF_Triangle3_Area
			End Get
		End Property
		Public Overrides Function IsValidParams() As Boolean
			Dim a As CellValue = DefinedNameNamericCellValue(DF_Triangle3_A)
			Dim b As CellValue = DefinedNameNamericCellValue(DF_Triangle3_B)
			Dim c As CellValue = DefinedNameNamericCellValue(DF_Triangle3_C)

			Return IsNumericAndGreaterThenZero(a) AndAlso IsNumericAndGreaterThenZero(b) AndAlso IsNumericAndGreaterThenZero(c) AndAlso a.NumericValue + b.NumericValue > c.NumericValue AndAlso a.NumericValue + c.NumericValue>b.NumericValue AndAlso b.NumericValue + c.NumericValue >a.NumericValue
		End Function
	End Class
End Namespace
