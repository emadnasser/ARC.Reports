Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.Spreadsheet
Imports System.Drawing

	Imports System.Globalization
	Imports System.Threading
	Imports DevExpress.Web.ASPxSpreadsheet
Namespace DevExpress.Web.Demos

	Public Class LoanAmortizationScheduleDemoHelper
		Private Const FirstTableRowIndex As Integer = 8
		Private Const WorksheetName As String = "Loan Amortization Schedule"

		Public Property LoanAmount() As Double
		Public Property AnnualInterestRate() As Decimal
		Public Property LoanPeriodInYears() As Integer
		Public Property NumberOfPayments() As Integer
		Public Property StartDate() As DateTime
		Public Property OptionalExtraPayments() As Double

		Protected Function GetWorksheet(ByVal document As IWorkbook) As Worksheet
			If document Is Nothing Then
				Return Nothing
			End If
			If document.Worksheets.Contains(WorksheetName) Then
				Return document.Worksheets(WorksheetName)
			End If
			Return document.Worksheets.First()
		End Function

		Public Sub PrepareSpreadsheetDocument(ByVal document As IWorkbook)
			Dim worksheet = GetWorksheet(document)
			If worksheet Is Nothing Then
				Return
			End If
			SetupGeneralSettings(document)
			ClearTableBody(worksheet)
			GenerateCalculationResultsFields(worksheet)

			GenerateTableBody(worksheet)
			ApplyStyleToTableBody(worksheet)

			PrepareColumnAndRows(worksheet)
			GenerateTitle(worksheet)
			GenerateTableHeaders(worksheet)
			document.History.Clear()
		End Sub
		Private Shared Function GetCurrentCulture() As CultureInfo
			Return Thread.CurrentThread.CurrentCulture
		End Function
		Private Shared Function GetCurrentCultureSeparator() As Char
			Return GetCurrentCulture().TextInfo.ListSeparator(0)
		End Function
		Private Shared Function GetCurrentCultureCurrencySymbol() As String
			Return GetCurrentCulture().NumberFormat.CurrencySymbol
		End Function
		Private Shared Function GetSummaryAccountingFormat() As String
			Dim currencySymbol As String = GetCurrentCultureCurrencySymbol()
			Return String.Format("\{0} #,##0.00;\{0} #,##0.00;\{0} "" - ""??;@", currencySymbol)
		End Function
		Private Shared Function GetCurrentCultureDateFormat() As String
			Return Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern
		End Function
		Private Sub SetupGeneralSettings(ByVal workbook As IWorkbook)
			workbook.Unit = DevExpress.Office.DocumentUnit.Point
			workbook.Styles.DefaultStyle.Font.Name = "Tahoma"
			workbook.Styles.DefaultStyle.Font.Size = 10

			Dim worksheet = GetWorksheet(workbook)
			worksheet.ActiveView.ShowGridlines = False
			worksheet.DefaultRowHeight = 15
			worksheet.Name = WorksheetName
			worksheet.DefinedNames.Clear()

			worksheet.DefinedNames.Add("_xlnm.Print_Titles", "'" & WorksheetName & "'!$11:$11")
			workbook.BeginUpdate()
			Try
				workbook.DefinedNames.Clear()
				workbook.DefinedNames.Add("Loan_Amount", LoanAmount.ToString())
				workbook.DefinedNames.Add("Interest_Rate", AnnualInterestRate.ToString())
				workbook.DefinedNames.Add("Loan_Years", LoanPeriodInYears.ToString())
				workbook.DefinedNames.Add("Number_of_Payments_Per_Year", NumberOfPayments.ToString())
				workbook.DefinedNames.Add("Loan_Start", String.Format("=DATEVALUE(""{0}"")", StartDate.ToShortDateString()))
				workbook.DefinedNames.Add("Extra_Payments", OptionalExtraPayments.ToString())
				workbook.DefinedNames.Add("Scheduled_payment", "'" & WorksheetName & "'!$E$4")
				workbook.DefinedNames.Add("Scheduled_Number_Payments", "'" & WorksheetName & "'!$E$5")
				workbook.DefinedNames.Add("Interest_Rate_Per_Month", "=Interest_Rate/Number_of_Payments_Per_Year")
				workbook.DefinedNames.Add("Actual_Number_Payments", String.Format("=NPER(Interest_Rate_Per_Month{0} {1}!$E$4+Extra_Payments{0} -Loan_Amount)", GetCurrentCultureSeparator(), "'" & WorksheetName & "'"))
			Finally
				workbook.EndUpdate()
			End Try
		End Sub
		Private Shared Sub PrepareColumnAndRows(ByVal worksheet As Worksheet)
			worksheet.DefaultColumnWidthInCharacters = 9f

			worksheet.Columns("A").WidthInCharacters = 3.43
			worksheet.Columns("B").WidthInCharacters = 4.00
			worksheet.Columns("C").WidthInCharacters = 12.29
			worksheet.Columns("D").WidthInCharacters = 15.71
			worksheet.Columns("E").WidthInCharacters = 9.71
			worksheet.Columns("F").WidthInCharacters = 12.57
			worksheet.Columns("G").WidthInCharacters = 13.14
			worksheet.Columns("H").WidthInCharacters = 10.71
			worksheet.Columns("I").WidthInCharacters = 10.00
			worksheet.Columns("J").WidthInCharacters = 13.71
			worksheet.Columns("K").WidthInCharacters = 9.71

			worksheet.Rows("2").Height = 31
			worksheet.Rows("8").Height = 35
		End Sub
		Private Shared Sub GenerateTitle(ByVal worksheet As Worksheet)
			worksheet("B2").Value = "Loan Amortization Schedule"
			worksheet("B2:K2").Merge()

			Dim formattedRange = worksheet("B2:K2")
			formattedRange.Font.Size = 26
			formattedRange.Font.Color = Color.FromArgb(0, 176, 80)
			formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
			formattedRange.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
		End Sub
		Private Shared Sub GenerateCalculationResultsFields(ByVal worksheet As Worksheet)
			worksheet("B4:D4").Merge()
			worksheet("B5:D5").Merge()
			worksheet("B6:D6").Merge()
			worksheet("F4:H4").Merge()
			worksheet("F5:H5").Merge()

			Dim formattedRange As Range = worksheet("B4:D8")
			formattedRange.Alignment.Indent = 1
			formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right
			formattedRange.Font.Size = 10

			formattedRange = worksheet("E4:E8")
			formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
			formattedRange.Font.Size = 10

			formattedRange = worksheet("F4:F5")
			formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right
			formattedRange.Font.Size = 10

			formattedRange = worksheet("I4:I8")
			formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
			formattedRange.Font.Size = 10

			worksheet("B4").Value = "First scheduled payment:"
			worksheet("B5").Value = "Scheduled number of payments:"
			worksheet("B6").Value = "Actual number of payments:"
			worksheet("F4").Value = "Total early payments:"
			worksheet("F5").Value = "Total interest:"

			Dim summaryAccountingFormat As String = GetSummaryAccountingFormat()
			worksheet("E4").NumberFormat = summaryAccountingFormat
			worksheet("I4").NumberFormat = summaryAccountingFormat
			worksheet("I5").NumberFormat = summaryAccountingFormat

			Dim actualLastRow As Integer = GetActualLastRow(worksheet)
			Dim formulaSeparator As Char = Thread.CurrentThread.CurrentCulture.TextInfo.ListSeparator(0)
			Dim currencyPattern As Integer = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyPositivePattern
			worksheet("E4").Formula = "=PMT(Interest_Rate_Per_Month" & formulaSeparator & "Scheduled_Number_Payments" & formulaSeparator & "-Loan_Amount)"
			worksheet("E5").FormulaInvariant = "=Loan_Years*Number_of_Payments_Per_Year"
			worksheet("E6").Formula = "=ROUNDUP(Actual_Number_Payments" & formulaSeparator & "0)"
			worksheet("I4").FormulaInvariant = "=SUM(F12:F" & actualLastRow & ")"
			worksheet("I5").FormulaInvariant = "=SUM($I$12:$I$" & actualLastRow & ")"
		End Sub
		Private Sub GenerateTableHeaders(ByVal worksheet As Worksheet)
			Dim formattedRange As Range = worksheet("B8:K8")
			formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			formattedRange.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			formattedRange.Alignment.WrapText = True
			formattedRange.Fill.BackgroundColor = Color.FromArgb(166, 166, 166)
			formattedRange.Font.Color = Color.White
			formattedRange.Font.Size = 10

			worksheet("B8").Value = "No."
			worksheet("C8").Value = "Payment Date"
			worksheet("D8").Value = "Beginning Balance"
			worksheet("E8").Value = "Scheduled Payment"
			worksheet("F8").Value = "Extra Payment"
			worksheet("G8").Value = "Total Payment"
			worksheet("H8").Value = "Principal"
			worksheet("I8").Value = "Interest"
			worksheet("J8").Value = "Ending Balance"
			worksheet("K8").Value = "Cumulative Interest"
		End Sub
		Private Shared Sub GenerateTableBody(ByVal worksheet As Worksheet)
			Dim scheduledNumberOfPayments As Integer = CInt(Fix(Math.Round(worksheet("E5").Value.NumericValue)))
			Dim actualNumberOfPayments As Integer = GetActualNumberOfPayments(worksheet)
			Dim actualLastRow As Integer = GetActualLastRow(worksheet)
			If scheduledNumberOfPayments = 0 Then
				Return
			End If
			Dim formulaSeparator As Char = GetCurrentCultureSeparator()
			For i As Integer = 0 To actualNumberOfPayments - 1
				worksheet("B" & (i + FirstTableRowIndex + 1)).Value = i + 1
			Next i
			worksheet("C9:C" & actualLastRow).Formula = "=DATE(YEAR(Loan_Start)" & formulaSeparator & "MONTH(Loan_Start)+(B9)*12/Number_of_Payments_Per_Year" & formulaSeparator & "DAY(Loan_Start))"
			worksheet("D9").FormulaInvariant = "=Loan_Amount"
			If scheduledNumberOfPayments > 1 Then
				worksheet("D10:D" & actualLastRow).FormulaInvariant = "=J9"
			End If
			worksheet("E9:E" & actualLastRow).Formula = String.Format("=IF(D9>0{0}IF(Scheduled_payment<D9{0} Scheduled_payment{0} D9){0}0)", formulaSeparator)
			worksheet("F9:F" & actualLastRow).Formula = String.Format("=IF(Extra_Payments<>0{0} IF(Scheduled_payment<D9{0} G9-E9{0} 0){0} 0)", formulaSeparator)
			worksheet("G9:G" & actualLastRow).FormulaInvariant = "=H9+I9"
			worksheet("H9:H" & actualLastRow).Formula = String.Format("=IF(J9>0{0}PPMT(Interest_Rate_Per_Month{0}B9{0}Actual_Number_Payments{0}-Loan_Amount){0}D9)", formulaSeparator)
			worksheet("I9:I" & actualLastRow).Formula = String.Format("=IF(D9>0{0}IPMT(Interest_Rate_Per_Month{0}B9{0}Actual_Number_Payments{0}-Loan_Amount){0}0)", formulaSeparator)
			worksheet("J9:J" & actualLastRow).Formula = String.Format("=IF(D9-PPMT(Interest_Rate_Per_Month{0}B9{0}Actual_Number_Payments{0}-Loan_Amount)>0{0}D9-PPMT(Interest_Rate_Per_Month{0}B9{0}Actual_Number_Payments{0}-Loan_Amount){0}0)", formulaSeparator)
			worksheet("K9:K" & actualLastRow).FormulaInvariant = "=SUM($I$9:$I9)"
		End Sub
		Private Sub ApplyStyleToTableBody(ByVal worksheet As Worksheet)
			Dim actualNumberOfPayments As Integer = GetActualNumberOfPayments(worksheet)
			Dim actualLastRow As Integer = GetActualLastRow(worksheet)

			Dim formattedRange As Range
			For i As Integer = 1 To actualNumberOfPayments - 1 Step 2
				formattedRange = worksheet.Range.FromLTRB(1, FirstTableRowIndex + i, 10, FirstTableRowIndex + i)
				formattedRange.Fill.BackgroundColor = Color.FromArgb(217, 217, 217)
			Next i

			formattedRange = worksheet("B8:K" & actualLastRow)
			formattedRange.Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.Thin
			formattedRange.Borders.InsideVerticalBorders.Color = Color.White
			formattedRange.Alignment.Vertical = SpreadsheetVerticalAlignment.Center

			formattedRange = worksheet("B9:C" & actualLastRow)
			formattedRange.RowHeight = 15
			formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right

			worksheet("C8:C" & actualLastRow).NumberFormat = GetCurrentCultureDateFormat()
			Dim currencySymbol As String = GetCurrentCultureCurrencySymbol()
			worksheet("D8:K" & actualLastRow).NumberFormat = String.Format("_(\{0}* #,##0.00_);_(\{0} (#,##0.00);_(\{0}* "" - ""??_);_(@_)", currencySymbol)
		End Sub

		Private Shared Sub ClearTableBody(ByVal worksheet As Worksheet)
			If worksheet.Rows.LastUsedIndex < FirstTableRowIndex Then
				Return
			End If
			Dim formattedRange As Range = worksheet("B9:K" & (worksheet.Rows.LastUsedIndex + 1))
			formattedRange.ClearFormats()
			worksheet("B9:K" & (worksheet.Rows.LastUsedIndex + 1)).Value = CellValue.Empty
		End Sub

		Private Shared Function GetActualLastRow(ByVal worksheet As Worksheet) As Integer
			Return FirstTableRowIndex + GetActualNumberOfPayments(worksheet)
		End Function
		Private Shared Function GetActualNumberOfPayments(ByVal worksheet As Worksheet) As Integer
			Return CInt(Fix(Math.Round(worksheet("E6").Value.NumericValue)))
		End Function
	End Class
End Namespace
