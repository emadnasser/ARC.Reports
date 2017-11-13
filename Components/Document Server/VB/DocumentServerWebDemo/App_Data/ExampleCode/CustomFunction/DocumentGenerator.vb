Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.Office
Imports DevExpress.Spreadsheet
Imports System.Drawing
Imports SpreadsheetFormatting = DevExpress.Spreadsheet.Formatting
Imports System.Globalization
Imports DevExpress.Spreadsheet.Functions
Imports DevExpress.Docs.Text

Namespace DevExpress.Spreadsheet.Demos
	Public Class CustomFunctionDocumentGenerator
		Private Const languageCount As Integer = 14
		Private Const firstValueRowIndex As Integer = 8
		Private Const lastValueRowIndex As Integer = firstValueRowIndex + (languageCount - 1) * 2

		Private Const borderRowHeight As Double = 16.5
		Private Const separateRowHeight As Double = 6
		Private Const valueRowHeight As Double = 16.5

		Private book As IWorkbook
		Private sheet As Worksheet
		Private columns As ColumnCollection
		Private rows As RowCollection
		Private cells As CellCollection
		Private styles As StyleCollection
		Private separator As Char

		Public Sub New(ByVal culture As CultureInfo)
			Me.book = New Workbook()
			Me.book.Options.Culture = culture
			InitCultureParams(culture)
		End Sub
		Public Sub New(ByVal book As IWorkbook)
			Me.book = book
			InitCultureParams(book.Options.Culture)
		End Sub
		Private Sub InitCultureParams(ByVal culture As CultureInfo)
			Me.separator = culture.TextInfo.ListSeparator(0)
		End Sub
		Public Function Generate() As IWorkbook
			InitializeBook()
			Return book
		End Function

		Private Sub InitializeBook()
			InitWorkbook()
			SetRowsHeight()
			CreateStyles()
			FormatCells()
			ApplyStyles()
			SetBorders()
			FillData()
			ApplyCustomFunction()
			SetColumnsWidth()
			sheet("C4").Select()
		End Sub
		Private Sub InitWorkbook()
			book.Unit = DevExpress.Office.DocumentUnit.Point

			book.Styles.DefaultStyle.Font.Name = "Calibri"
			book.Styles.DefaultStyle.Font.Size = 11

			sheet = book.Worksheets(0)
			columns = sheet.Columns
			rows = sheet.Rows
			cells = sheet.Cells

			sheet.ActiveView.Zoom = 100
			sheet.ActiveView.ShowGridlines = False

			sheet.DefaultRowHeight = 12.75
			sheet.Name = "Number In Words"
			sheet.ActiveView.Orientation = PageOrientation.Landscape
			sheet.PrintOptions.FitToPage = True

			styles = book.Styles
		End Sub
		Private Sub ApplyCustomFunction()
			Dim cultureIndex As Integer = 1
			For i As Integer = firstValueRowIndex To lastValueRowIndex Step 2
				cells("C" & i).Formula = String.Format("=SPELLNUMBER(C4{0}{1})", separator, cultureIndex)
				cells("E" & i).Formula = String.Format("=SPELLNUMBER(C4{0}{1}{0}true)", separator, cultureIndex)
				cultureIndex += 1
			Next i
		End Sub
		Private Sub ApplyStyles()
			sheet("C4").Style = styles("Style 1")

			For i As Integer = firstValueRowIndex To lastValueRowIndex Step 2
				sheet("C" & i).Style = styles("Style 1")
				sheet("E" & i).Style = styles("Style 1")
			Next i
		End Sub
		Private Sub CreateStyles()
			Dim style1 As Style = styles.Add("Style 1")
			style1.Font.Size = 12
			style1.Fill.PatternType = PatternType.Solid
			style1.Fill.BackgroundColor = Color.FromArgb(255, 255, 255, 255)
			style1.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
			style1.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			style1.Alignment.Indent = 1
		End Sub
		Private Sub SetBorders()
			sheet("C4").Borders.SetOutsideBorders(Color.FromArgb(255, 191, 191, 191), BorderLineStyle.Thin)

			For i As Integer = firstValueRowIndex To lastValueRowIndex Step 2
				sheet("C" & i).Borders.SetOutsideBorders(Color.FromArgb(255, 191, 191, 191), BorderLineStyle.Thin)
				sheet("E" & i).Borders.SetOutsideBorders(Color.FromArgb(255, 191, 191, 191), BorderLineStyle.Thin)
			Next i
		End Sub
		Private Sub FormatCells()
			Dim range1 As Range = sheet("B2")
			Dim rangeFormatting1 As Formatting = range1.BeginUpdateFormatting()
			rangeFormatting1.Font.Color = Color.FromArgb(255, 64, 64, 64)
			rangeFormatting1.Font.Size = 28
			rangeFormatting1.Font.Name = "Calibri Light"
			rangeFormatting1.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			range1.EndUpdateFormatting(rangeFormatting1)

			Dim range2 As Range = sheet("B3:F" & (lastValueRowIndex + 1))
			Dim rangeFormatting2 As Formatting = range2.BeginUpdateFormatting()
			rangeFormatting2.Fill.PatternType = PatternType.Solid
			rangeFormatting2.Fill.BackgroundColor = Color.FromArgb(255, 242, 242, 242)
			rangeFormatting2.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			range2.EndUpdateFormatting(rangeFormatting2)

			Dim range3 As Range = sheet("B4:B" & lastValueRowIndex)
			Dim rangeFormatting3 As Formatting = range3.BeginUpdateFormatting()
			rangeFormatting3.Font.Size = 14
			rangeFormatting3.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
			rangeFormatting3.Alignment.Indent = 2
			range3.EndUpdateFormatting(rangeFormatting3)

			Dim range4 As Range = sheet("C6:E6")
			Dim rangeFormatting4 As Formatting = range4.BeginUpdateFormatting()
			rangeFormatting4.Font.Color = Color.FromArgb(255, 128, 128, 128)
			rangeFormatting4.Font.Size = 14
			range4.EndUpdateFormatting(rangeFormatting4)
		End Sub
		Private Sub SetRowsHeight()
			rows(1).Height = 36
			rows(2).Height = borderRowHeight
			rows(3).Height = valueRowHeight

			For i As Integer = 4 To lastValueRowIndex - 1 Step 2
				rows(i).Height = separateRowHeight
				rows(i + 1).Height = valueRowHeight
			Next i

			rows(lastValueRowIndex).Height = borderRowHeight
		End Sub
		Private Sub SetColumnsWidth()
			columns(0).WidthInCharacters = 2.29
			columns(1).WidthInCharacters = 33.77
			columns(3).WidthInCharacters = 3.09
			columns(5).WidthInCharacters = 3.09

			columns(2).AutoFit()
			columns(4).AutoFit()
		End Sub
		Private Sub FillData()
			Dim customFunction As New NumberInWordsFunction()
			If (Not book.GlobalCustomFunctions.Contains((CType(customFunction, ICustomFunction)).Name)) Then
				book.GlobalCustomFunctions.Add(customFunction)
			End If

			cells("B2").Value = "NUMBER IN WORDS"
			cells("B4").Value = "number"
			cells("C4").Value = 1235
			cells("C6").Value = "cardinal number in words                  "
			cells("E6").Value = "ordinal number in words                   "

			cells("B8").Value = "English"
			cells("B10").Value = "English(United Kingdom)"
			cells("B12").Value = "French(Français)"
			cells("B14").Value = "German(Deutsch)"
			cells("B16").Value = "Greek(Ελληνικά)"
			cells("B18").Value = "Hindi(हिन्दी)"
			cells("B20").Value = "Italian(Italiano)"
			cells("B22").Value = "Portuguese(Português)"
			cells("B24").Value = "Russian(Русский)"
			cells("B26").Value = "Spanish(Español)"
			cells("B28").Value = "Swedish(Svensk)"
			cells("B30").Value = "Thai(ไทย)"
			cells("B32").Value = "Turkish(Türkçe)"
			cells("B34").Value = "Ukrainian(Український)"
		End Sub
	End Class

	Public Class NumberInWordsFunction
		Inherits Object
		Implements ICustomFunction
		Private Const functionName As String = "SPELLNUMBER"
		Private ReadOnly functionParameters() As ParameterInfo
		Private Shared cultureInfoParamTable As List(Of CultureInfo) = CreateCultureInfoParamTable()

		Public Sub New()
			Me.functionParameters = New ParameterInfo() { New ParameterInfo(ParameterType.Value), New ParameterInfo(ParameterType.Value), New ParameterInfo(ParameterType.Value, ParameterAttributes.Optional) }
		End Sub

		Private ReadOnly Property Name() As String Implements IFunction.Name
			Get
				Return functionName
			End Get
		End Property
		Private ReadOnly Property Parameters() As ParameterInfo() Implements IFunction.Parameters
			Get
				Return functionParameters
			End Get
		End Property
		Private ReadOnly Property ReturnType() As ParameterType Implements IFunction.ReturnType
			Get
				Return ParameterType.Value
			End Get
		End Property
		Private ReadOnly Property Volatile() As Boolean Implements IFunction.Volatile
			Get
				Return True
			End Get
		End Property

		Private Function Evaluate(ByVal parameters As IList(Of ParameterValue), ByVal context As EvaluationContext) As ParameterValue Implements IFunction.Evaluate
			Dim isOrdinal As Boolean = False
			Dim numberValue As ParameterValue = parameters(0)
			If numberValue.IsError Then
				Return numberValue
			End If

			Dim cultureValue As ParameterValue = parameters(1)
			If cultureValue.IsError Then
				Return cultureValue
			End If
			If cultureValue.NumericValue < 1 OrElse cultureValue.NumericValue > cultureInfoParamTable.Count Then
				Return ParameterValue.ErrorNumber
			End If

			If parameters.Count = 3 Then
				Dim ordinalValue As ParameterValue = parameters(1)
				If ordinalValue.IsError Then
					Return ordinalValue
				End If

				isOrdinal = ordinalValue.BooleanValue
			End If

			Dim number As Double = numberValue.NumericValue
			Dim culture As CultureInfo = cultureInfoParamTable(CInt(Fix(cultureValue.NumericValue)) - 1)

			If number < 0 OrElse number > Long.MaxValue Then
				Return ParameterValue.ErrorNumber
			End If

			If isOrdinal Then
				Return NumberInWords.Ordinal.ConvertToText(CLng(Fix(Math.Round(number))), culture)
			Else
				Return NumberInWords.Cardinal.ConvertToText(CLng(Fix(Math.Round(number))), culture)
			End If
		End Function
		Private Function GetName(ByVal culture As CultureInfo) As String Implements IFunction.GetName
			Return functionName
		End Function
		Private Shared Function CreateCultureInfoParamTable() As List(Of CultureInfo)
			Dim result As New List(Of CultureInfo)()
			result.Add(CultureInfo.GetCultureInfo("en-US"))
			result.Add(CultureInfo.GetCultureInfo("en-GB"))
			result.Add(CultureInfo.GetCultureInfo("fr-FR"))
			result.Add(CultureInfo.GetCultureInfo("de-DE"))
			result.Add(CultureInfo.GetCultureInfo("el-GR"))
			result.Add(CultureInfo.GetCultureInfo("hi-IN"))
			result.Add(CultureInfo.GetCultureInfo("it-IT"))
			result.Add(CultureInfo.GetCultureInfo("pt-PT"))
			result.Add(CultureInfo.GetCultureInfo("ru-RU"))
			result.Add(CultureInfo.GetCultureInfo("es-ES"))
			result.Add(CultureInfo.GetCultureInfo("sv-SE"))
			result.Add(CultureInfo.GetCultureInfo("th-TH"))
			result.Add(CultureInfo.GetCultureInfo("tr-TR"))
			result.Add(CultureInfo.GetCultureInfo("uk-UA"))
			Return result
		End Function
	End Class
End Namespace
