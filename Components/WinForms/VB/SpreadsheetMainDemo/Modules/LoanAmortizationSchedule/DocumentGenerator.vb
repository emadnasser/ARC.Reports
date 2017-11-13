Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Office
Imports System.Drawing
Imports SpreadsheetFormatting = DevExpress.Spreadsheet.Formatting
Imports System.Globalization

Namespace DevExpress.Spreadsheet.Demos
	Public Class LoanAmortizationScheduleDocumentGenerator
		#Region "Fields"

		Private titleColor As Color = Color.FromArgb(0, 176, 80)
		Private headerColor As Color = Color.FromArgb(166, 166, 166)
		Private Const SummaryAccounting As String = "\$ #,##0.00;\$ #,##0.00;\$ "" - ""??;@"
		Private Const Accounting As String = "_(\$* #,##0.00_);_(\$ (#,##0.00);_(\$* "" - ""??_);_(@_)"
		Private Const DateFormat As String = "m/d/yyyy"

		Private workbook_Renamed As IWorkbook
		Private worksheet As Worksheet
		Private columns As ColumnCollection
		Private rows As RowCollection
		Private cells As CellCollection
		Private previousScheduledNumberOfPayments As Integer
		Private separator As Char

		#End Region

		#Region "Properties"

		Public ReadOnly Property Workbook() As IWorkbook
			Get
				Return workbook_Renamed
			End Get
		End Property
		Public Property LoanAmount() As Double
			Get
				Return cells("E4").Value.NumericValue
			End Get
			Set(ByVal value As Double)
				cells("E4").Value = value
			End Set
		End Property
		Public Property InterestRate() As Double
			Get
				Return cells("E5").Value.NumericValue
			End Get
			Set(ByVal value As Double)
				cells("E5").Value = value
			End Set
		End Property
		Public Property PeriodInYears() As Integer
			Get
				Return CInt(Fix(cells("E6").Value.NumericValue))
			End Get
			Set(ByVal value As Integer)
				cells("E6").Value = value
			End Set
		End Property
		Public Property StartDateOfLoan() As DateTime
			Get
				Return cells("E8").Value.DateTimeValue
			End Get
			Set(ByVal value As DateTime)
				cells("E8").Value = value
			End Set
		End Property
		Public Property FitToPage() As Boolean
			Get
				Return worksheet.PrintOptions.FitToPage
			End Get
			Set(ByVal value As Boolean)
				If value Then
					worksheet.PrintOptions.FitToPage = True
					worksheet.PrintOptions.FitToWidth = 1
					worksheet.PrintOptions.FitToHeight = 0 ' automatic
				Else
					worksheet.PrintOptions.FitToPage = False
				End If
			End Set
		End Property

		Public Property AnnuityPayments() As Boolean

		Private ReadOnly Property ActualNumberOfPayments() As Integer
			Get
				Return CInt(Fix(Math.Round(cells("I6").Value.NumericValue)))
			End Get
		End Property
		Private ReadOnly Property ActualLastRow() As String
			Get
				Return (11 + ActualNumberOfPayments).ToString()
			End Get
		End Property
		Private ReadOnly Property ScheduledNumberOfPayments() As Integer
			Get
				Return CInt(Fix(Math.Round(cells("I5").Value.NumericValue)))
			End Get
		End Property
		Private ReadOnly Property ScheduledLastRow() As String
			Get
				Return (11 + ScheduledNumberOfPayments).ToString()
			End Get
		End Property
		Private ReadOnly Property PreviousLastRow() As String
			Get
				Return (previousScheduledNumberOfPayments + 11).ToString()
			End Get
		End Property

		#End Region

		Public Sub New(ByVal culture As CultureInfo)
			workbook_Renamed = New Workbook()
			workbook_Renamed.Options.Culture = culture
			InitCultureParams(culture)
			AnnuityPayments = True
			InitializeWorkbook()
			SetupColumnsAndRows()
			GenerateTitle()
			GenerateFieldsForDataEntry()
			GenerateFieldsForCalculationResults()
			GenerateTableHeader()
			SetBasicData()
		End Sub

		Public Sub New(ByVal book As IWorkbook)
			AnnuityPayments = True
			workbook_Renamed = book
			InitCultureParams(workbook_Renamed.Options.Culture)
			InitializeWorkbook()
			SetupColumnsAndRows()
			GenerateTitle()
			GenerateFieldsForDataEntry()
			GenerateFieldsForCalculationResults()
			GenerateTableHeader()
			SetBasicData()
		End Sub

		Private Sub InitCultureParams(ByVal culture As CultureInfo)
			Me.separator = culture.TextInfo.ListSeparator(0)
		End Sub

		Public Function Generate() As IWorkbook
			ClearTable()
			If AnnuityPayments Then
				AddDefinedNamesForAnnuity()
				GenerateAnnuityTableBody()
			Else
				AddDefinedNamesForScaled()
				GenerateScaledTableBody()
			End If
			GenerateTableGrid()
			previousScheduledNumberOfPayments = ScheduledNumberOfPayments
			Return Workbook
		End Function

		#Region "Workbook generation"

		Private Sub InitializeWorkbook()
			workbook_Renamed.Unit = DocumentUnit.Point

			workbook_Renamed.Styles.DefaultStyle.Font.Name = "Tahoma"
			workbook_Renamed.Styles.DefaultStyle.Font.Size = 10

			worksheet = workbook_Renamed.Worksheets(0)
			worksheet.ActiveView.ShowGridlines = False
			worksheet.DefaultRowHeight = 15
			worksheet.Name = "Loan Amortization Schedule"
			worksheet.DefinedNames.Add("_xlnm.Print_Titles", "'Loan Amortization Schedule'!$11:$11")

			columns = worksheet.Columns
			rows = worksheet.Rows
			cells = worksheet.Cells
		End Sub
		Private Sub SetupColumnsAndRows()
			worksheet.DefaultColumnWidthInCharacters = 9f

			columns("A").WidthInCharacters = 3.43
			columns("B").WidthInCharacters = 5.14
			worksheet("C:K").ColumnWidthInCharacters = 11.71

			rows("2").Height = 31
			rows("11").Height = 35
		End Sub
		Private Sub GenerateTitle()
			cells("B2").Value = "Loan Amortization Schedule"
			worksheet("B2:K2").Merge()

			Dim formattedRange As Range = worksheet("B2:K2")
			Dim formatting As SpreadsheetFormatting = formattedRange.BeginUpdateFormatting()
			Try
				formatting.Font.Size = 26
				formatting.Font.Color = titleColor
				formatting.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
				formatting.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			Finally
				formattedRange.EndUpdateFormatting(formatting)
			End Try
		End Sub
		Private Sub GenerateFieldsForDataEntry()
			worksheet("B4:D4").Merge()
			worksheet("B5:D5").Merge()
			worksheet("B6:D6").Merge()
			worksheet("B7:D7").Merge()
			worksheet("B8:D8").Merge()
			worksheet("B9:D9").Merge()

			Dim formattedRange As Range = worksheet("B4:D9")
			Dim formatting As SpreadsheetFormatting = formattedRange.BeginUpdateFormatting()
			Try
				formatting.Alignment.Indent = 1
				formatting.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right
				formatting.Font.Size = 10
			Finally
				formattedRange.EndUpdateFormatting(formatting)
			End Try

			formattedRange = worksheet("E4:E9")
			formatting = formattedRange.BeginUpdateFormatting()
			Try
				formatting.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
				formatting.Font.Size = 10
			Finally
				formattedRange.EndUpdateFormatting(formatting)
			End Try

			cells("B4").Value = "Loan amount:"
			cells("B5").Value = "Annual interest rate:"
			cells("B6").Value = "Loan period in years:"
			cells("B7").Value = "Number of payments per year:"
			cells("B8").Value = "Start date of loan:"
			cells("B9").Value = "Optional extra payments:"

			cells("E4").NumberFormat = SummaryAccounting
			cells("E5").NumberFormat = "0.00%"
			cells("E8").NumberFormat = DateFormat
			cells("E9").NumberFormat = SummaryAccounting
		End Sub
		Private Sub GenerateFieldsForCalculationResults()
			worksheet("F4:H4").Merge()
			worksheet("F5:H5").Merge()
			worksheet("F6:H6").Merge()
			worksheet("F7:H7").Merge()
			worksheet("F8:H8").Merge()

			Dim formattedRange As Range = worksheet("F4:H8")
			Dim formatting As SpreadsheetFormatting = formattedRange.BeginUpdateFormatting()
			Try
				formatting.Alignment.Indent = 1
				formatting.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right
				formatting.Font.Size = 10
			Finally
				formattedRange.EndUpdateFormatting(formatting)
			End Try

			formattedRange = worksheet("I4:I8")
			formatting = formattedRange.BeginUpdateFormatting()
			Try
				formatting.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
				formatting.Font.Size = 10
			Finally
				formattedRange.EndUpdateFormatting(formatting)
			End Try

			cells("F4").Value = "First scheduled payment:"
			cells("F5").Value = "Scheduled number of payments:"
			cells("F6").Value = "Actual number of payments:"
			cells("F7").Value = "Total early payments:"
			cells("F8").Value = "Total interest:"

			cells("I4").NumberFormat = SummaryAccounting
			cells("I7").NumberFormat = SummaryAccounting
			cells("I8").NumberFormat = SummaryAccounting
		End Sub
		Private Sub GenerateTableHeader()
			Dim formattedRange As Range = worksheet("B11:K11")
			Dim formatting As SpreadsheetFormatting = formattedRange.BeginUpdateFormatting()
			Try
				formatting.Alignment.Horizontal = DevExpress.Spreadsheet.SpreadsheetHorizontalAlignment.Center
				formatting.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
				formatting.Alignment.WrapText = True
				formatting.Fill.BackgroundColor = headerColor
				formatting.Font.Color = Color.White
				formatting.Font.Size = 10
			Finally
				formattedRange.EndUpdateFormatting(formatting)
			End Try

			cells("B11").Value = "No."
			cells("C11").Value = "Payment Date"
			cells("D11").Value = "Beginning Balance"
			cells("E11").Value = "Scheduled Payment"
			cells("F11").Value = "Extra Payment"
			cells("G11").Value = "Total Payment"
			cells("H11").Value = "Principal"
			cells("I11").Value = "Interest"
			cells("J11").Value = "Ending Balance"
			cells("K11").Value = "Cumulative Interest"
		End Sub
		Private Sub SetBasicData()
			cells("E4").Value = 19900
			cells("E5").Value = 0.055
			cells("E6").Value = 2
			cells("E7").Value = 12
			cells("E8").Value = DateTime.Now
			cells("E9").Value = 200
		End Sub
		Private Sub ClearTable()
			If previousScheduledNumberOfPayments <> 0 Then
				Dim formattedRange As Range = worksheet("B12:K" & PreviousLastRow)
				formattedRange.ClearFormats()
				worksheet("B12:K" & PreviousLastRow).ClearContents()
				worksheet("I4").ClearContents()
				worksheet("I6:I8").ClearContents()
			End If
		End Sub

		Private Function GetSheetNameWrappedInQuotes() As String
			Return "'" & worksheet.Name & "'"
		End Function

		Private Sub AddDefinedNamesForAnnuity()
			Dim sheetName As String = GetSheetNameWrappedInQuotes()
			Dim definedNames As DefinedNameCollection = workbook_Renamed.DefinedNames
			definedNames.Clear()
			definedNames.Add("Loan_Amount", sheetName & "!$E$4")
			definedNames.Add("Interest_Rate", sheetName & "!$E$5")
			definedNames.Add("Loan_Years", sheetName & "!$E$6")
			definedNames.Add("Number_of_Payments_Per_Year", sheetName & "!$E$7")
			definedNames.Add("Loan_Start", sheetName & "!$E$8")
			definedNames.Add("Extra_Payments", sheetName & "!$E$9")
			definedNames.Add("Scheduled_payment", sheetName & "!$I$4")
			definedNames.Add("Scheduled_Number_Payments", sheetName & "!$I$5")
			definedNames.Add("Interest_Rate_Per_Month", "=Interest_Rate/Number_of_Payments_Per_Year")
			definedNames.Add("Actual_Number_Payments", "=NPER(Interest_Rate_Per_Month" & separator & " " & sheetName & "!$I$4+Extra_Payments" & separator & " -Loan_Amount)")
		End Sub

		Private Sub AddDefinedNamesForScaled()
			Dim sheetName As String = GetSheetNameWrappedInQuotes()
			Dim definedNames As DefinedNameCollection = workbook_Renamed.DefinedNames
			definedNames.Clear()
			definedNames.Add("Values_Entered", "IF(Loan_Amount*Interest_Rate*Loan_Years*Loan_Start>0" & separator & "1" & separator & "0)")
			definedNames.Add("Full_Print", sheetName & "!$A:$K")
			definedNames.Add("Loan_Amount", sheetName & "!$E$4")
			definedNames.Add("Interest_Rate", sheetName & "!$E$5")
			definedNames.Add("Loan_Years", sheetName & "!$E$6")
			definedNames.Add("Number_of_Payments_Per_Year", sheetName & "!$E$7")
			definedNames.Add("Loan_Start", sheetName & "!$E$8")
			definedNames.Add("Extra_Payments", sheetName & "!$E$9")
			definedNames.Add("Scheduled_Monthly_Payment", "Loan_Amount/(Loan_Years*Number_of_Payments_Per_Year)")
			definedNames.Add("Scheduled_Number_Payments", sheetName & "!$I$5")
			definedNames.Add("Real_Number_Payments", sheetName & "!$I$6")
			definedNames.Add("Total_Early_Payments", sheetName & "!$I$7")
			definedNames.Add("Total_Interest", sheetName & "!$I$8")
			definedNames.Add("Beg_Bal", sheetName & "!$D$12:$D$" & ScheduledLastRow)
			definedNames.Add("Cum_Int", sheetName & "!$K$12:$K$" & ScheduledLastRow)
			definedNames.Add("Data", sheetName & "!$B$12:$K$" & ScheduledLastRow)
			definedNames.Add("End_Bal", sheetName & "!$J$12:$J$" & ScheduledLastRow)
			definedNames.Add("Extra_Pay", sheetName & "!$F$12:$F$" & ScheduledLastRow)
			definedNames.Add("Header_Row", "ROW(" & sheetName & "!$17:$17)")
			definedNames.Add("Int", sheetName & "!$I$12:$I$" & ScheduledLastRow)
			definedNames.Add("Last_Row", "IF(Values_Entered" & separator & "Header_Row+Number_of_Payments" & separator & "Header_Row)")
			definedNames.Add("Number_of_Payments", "=MATCH(0.01" & separator & "End_Bal" & separator & "-1)+1")
			definedNames.Add("Pay_Date", sheetName & "!$C$12:$C$" & ScheduledLastRow)
			definedNames.Add("Pay_Num", sheetName & "!$B$12:$B$" & ScheduledLastRow)
			definedNames.Add("Payment_Date", "DATE(YEAR(Loan_Start)" & separator & "MONTH(Loan_Start)+Payment_Number" & separator & "DAY(Loan_Start))")
			definedNames.Add("Princ", sheetName & "!$H$12:$H$" & ScheduledLastRow)
			definedNames.Add("Print_Area_Reset", "OFFSET(Full_Print" & separator & "0" & separator & "0" & separator & "Last_Row)")
			definedNames.Add("Sched_Pay", sheetName & "!$E$12:$E$" & ScheduledLastRow)
			definedNames.Add("Total_Pay", sheetName & "!$G$12:$G$" & ScheduledLastRow)
			definedNames.Add("Total_Payment", "Scheduled_Payment+Extra_Payment")
			definedNames.Add("Payment_Number", "ROW()-Header_Row")
			definedNames.Add("Loan_Not_Paid", "IF(Payment_Number<=Number_of_Payments" & separator & "1" & separator & "0)")
		End Sub

		Private Sub GenerateAnnuityTableBody()
			cells("I4").FormulaInvariant = "=PMT(Interest_Rate_Per_Month,Scheduled_Number_Payments,-Loan_Amount)"
			cells("I5").FormulaInvariant = "=Loan_Years*Number_of_Payments_Per_Year"
			cells("I6").FormulaInvariant = "=ROUNDUP(Actual_Number_Payments,0)"
			workbook_Renamed.Calculate()
			cells("I7").FormulaInvariant = "=SUM(F12:F" & ActualLastRow & ")"
			cells("I8").FormulaInvariant = "=SUM($I$12:$I$" & ActualLastRow & ")"

			If ScheduledNumberOfPayments = 0 Then
				Return
			End If

			For i As Integer = 0 To ActualNumberOfPayments - 1
				cells("B" & (i + 12).ToString()).Value = i + 1
			Next i
			worksheet("C12:C" & ActualLastRow).FormulaInvariant = "=DATE(YEAR(Loan_Start),MONTH(Loan_Start)+(B12)*12/Number_of_Payments_Per_Year,DAY(Loan_Start))"
			cells("D12").Formula = "=Loan_Amount"
			If ScheduledNumberOfPayments > 1 Then
				worksheet("D13:D" & ActualLastRow).Formula = "=J12"
			End If
			worksheet("E12:E" & ActualLastRow).FormulaInvariant = "=IF(D12>0,IF(Scheduled_payment<D12, Scheduled_payment, D12),0)"
			worksheet("F12:F" & ActualLastRow).FormulaInvariant = "=IF(Extra_Payments<>0, IF(Scheduled_payment<D12, G12-E12, 0), 0)"
			worksheet("G12:G" & ActualLastRow).Formula = "=H12+I12"
			worksheet("H12:H" & ActualLastRow).FormulaInvariant = "=IF(J12>0,PPMT(Interest_Rate_Per_Month,B12,Actual_Number_Payments,-Loan_Amount),D12)"
			worksheet("I12:I" & ActualLastRow).FormulaInvariant = "=IF(D12>0,IPMT(Interest_Rate_Per_Month,B12,Actual_Number_Payments,-Loan_Amount),0)"
			worksheet("J12:J" & ActualLastRow).FormulaInvariant = "=IF(D12-PPMT(Interest_Rate_Per_Month,B12,Actual_Number_Payments,-Loan_Amount)>0,D12-PPMT(Interest_Rate_Per_Month,B12,Actual_Number_Payments,-Loan_Amount),0)"
			worksheet("K12:K" & ActualLastRow).Formula = "=SUM($I$12:$I12)"
		End Sub
		Private Sub GenerateScaledTableBody()
			cells("I4").FormulaInvariant = "=IF(Values_Entered,Scheduled_Monthly_Payment,"""")"
			cells("I5").FormulaInvariant = "=IF(Values_Entered,Loan_Years*Number_of_Payments_Per_Year,"""")"
			cells("I6").FormulaInvariant = "=IF(Values_Entered,Number_of_Payments,"""")"
			cells("I7").FormulaInvariant = "=IF(Values_Entered,SUMIF(Beg_Bal,"">0"",Extra_Pay),"""")"
			cells("I8").FormulaInvariant = "=IF(Values_Entered,SUMIF(Beg_Bal,"">0"",Int),"""")"
			workbook_Renamed.Calculate()

			If ScheduledNumberOfPayments = 0 Then
				Return
			End If
			cells("B12").Formula = "=1"
			If ScheduledNumberOfPayments > 1 Then
				worksheet("B13:B" & ScheduledLastRow).FormulaInvariant = "=IF(NOT(OR(J12=0,J12="""")),B12+1,"""")"
			End If
			worksheet("C12:C" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",DATE(YEAR(Loan_Start),MONTH(Loan_Start)+(Pay_Num)*12/Number_of_Payments_Per_Year,DAY(Loan_Start)),"""")"
			cells("D12").FormulaInvariant = "=IF(Values_Entered,Loan_Amount,"""")"
			If ScheduledNumberOfPayments > 1 Then
				worksheet("D13:D" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",J12,"""")"
			End If
			worksheet("E12:E" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",Scheduled_Monthly_Payment,"""")"
			worksheet("F12:F" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",IF(Sched_Pay+Extra_Payments<Beg_Bal,Extra_Payments,IF(AND(Pay_Num<>"""",Beg_Bal-Sched_Pay>0),Beg_Bal-Sched_Pay,IF(Pay_Num<>"""",0,""""))),"""")"
			worksheet("G12:G" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",IF(Sched_Pay+Extra_Pay<Beg_Bal,Princ+Int+Extra_Pay,IF(Pay_Num<>"""",Beg_Bal,"""")),"""")"
			worksheet("H12:H" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",Scheduled_Monthly_Payment,"""")"
			worksheet("I12:I" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",Beg_Bal*(Interest_Rate/Number_of_Payments_Per_Year),"""")"
			worksheet("J12:J" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",IF(Sched_Pay+Extra_Pay<Beg_Bal,Beg_Bal-Princ,IF(Pay_Num<>"""",0,"""")),"""")"
			worksheet("K12:K" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",SUM($I$12:$I12),"""")"
		End Sub

		Private Sub GenerateTableGrid()
			workbook_Renamed.Calculate()
			Dim formattedRange As Range
			For i As Integer = 1 To ActualNumberOfPayments - 1 Step 2
				formattedRange = worksheet.Range.FromLTRB(1, 11 + i, 10, 11 + i)
				formattedRange.Fill.BackgroundColor = Color.FromArgb(217, 217, 217)
			Next i

			formattedRange = worksheet("B11:K" & ActualLastRow)
			Dim formatting As SpreadsheetFormatting = formattedRange.BeginUpdateFormatting()
			Try
				formatting.Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.Thin
				formatting.Borders.InsideVerticalBorders.Color = Color.White
				formatting.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			Finally
				formattedRange.EndUpdateFormatting(formatting)
			End Try

			formattedRange = worksheet("B12:C" & ActualLastRow)
			formattedRange.RowHeight = 15
			formatting = formattedRange.BeginUpdateFormatting()
			Try
				formatting.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right
			Finally
				formattedRange.EndUpdateFormatting(formatting)
			End Try

			formattedRange = worksheet("C11:C" & ActualLastRow)
			formattedRange.NumberFormat = DateFormat
			formattedRange = worksheet("D11:K" & ActualLastRow)
			formattedRange.NumberFormat = Accounting
		End Sub

		#End Region
	End Class
End Namespace
