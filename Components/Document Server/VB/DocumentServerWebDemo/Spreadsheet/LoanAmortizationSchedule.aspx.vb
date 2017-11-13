Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Spreadsheet
Imports System.Globalization
Imports DevExpress.Spreadsheet.Demos

Partial Public Class Spreadsheet_LoanAmortizationSchedule
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If Me.previewControl.CanShowPreview() Then
			Dim previewParams As LoanAmortizationSchedulePreviewParams = ParsePreview(Request.Params)
			RefreshPreview(previewParams)
			Return
		End If
		Me.previewControl.Workbook = CreateWorkbook()
	End Sub
	Private Function CreateWorkbook() As IWorkbook
		Dim generator As New LoanAmortizationScheduleDocumentGenerator(New CultureInfo("en-US"))
		Dim loanAmount As Integer = CInt(Fix(spnLoanAmount.Number))
		Dim interestRate As Double = CDbl(spnInterestRate.Number)
		Dim periodInYears As Integer = CInt(Fix(spnLoanPeriod.Number))
		Dim startDateOfLoan As DateTime = edStartDate.Date
		Return CreateWorkbook(loanAmount, periodInYears, interestRate, startDateOfLoan, True)
	End Function
	Private Function CreateWorkbook(ByVal loanAmount As Integer, ByVal loanPeriod As Integer, ByVal interestRate As Double, ByVal startDate As DateTime, ByVal fitToPage As Boolean) As IWorkbook
		Dim generator As New LoanAmortizationScheduleDocumentGenerator(New CultureInfo("en-US"))
		generator.LoanAmount = loanAmount
		generator.InterestRate = interestRate
		generator.PeriodInYears = loanPeriod
		generator.StartDateOfLoan = startDate
		generator.FitToPage = fitToPage
		Return generator.Generate()
	End Function
	Protected Sub OnDocumentDownloaderRequestWorkbook(ByVal sender As Object, ByVal args As RequestWorkbookEventArgs)
		args.Workbook = CreateWorkbook()
	End Sub
	Private Sub RefreshPreview(ByVal previewParams As LoanAmortizationSchedulePreviewParams)
		Dim book As IWorkbook = CreateWorkbook(previewParams.LoanAmount, previewParams.LoanPeriod, previewParams.InterestRate, previewParams.StartDate, previewParams.FitToPage)
		Me.previewControl.Workbook = book
		Me.previewControl.RenderSpreadsheetPreview()
	End Sub
	Private Function ParsePreview(ByVal nameValueCollection As System.Collections.Specialized.NameValueCollection) As LoanAmortizationSchedulePreviewParams
		Dim spnLoanAmountStringValue As String = Request.Params("spnLoanAmount")
		Dim spnLoanPeriodStringValue As String = Request.Params("spnLoanPeriod")
		Dim spnInterestRateStringValue As String = Request.Params("spnInterestRate")
		Dim edStartDateStringValue As String = Request.Params("edStartDate")
		Dim previewParams As New LoanAmortizationSchedulePreviewParams()
		previewParams.LoanAmount = If((String.IsNullOrEmpty(spnLoanAmountStringValue)), CInt(Fix(Me.spnLoanAmount.Number)), Convert.ToInt32(spnLoanAmountStringValue))
		previewParams.LoanPeriod = If((String.IsNullOrEmpty(spnLoanPeriodStringValue)), CInt(Fix(Me.spnLoanPeriod.Number)), Convert.ToInt32(spnLoanPeriodStringValue))
		previewParams.InterestRate = If((String.IsNullOrEmpty(spnInterestRateStringValue)), CDbl(Me.spnInterestRate.Number), Convert.ToDouble(spnInterestRateStringValue))
		previewParams.StartDate = If((String.IsNullOrEmpty(edStartDateStringValue)), DateTime.Now.Date, DateTime.ParseExact(edStartDateStringValue, "dd/MM/yyyy", CultureInfo.InvariantCulture))
		previewParams.FitToPage = True
		Return previewParams
	End Function
End Class
Public Class LoanAmortizationSchedulePreviewParams
	Public Property LoanAmount() As Integer
	Public Property LoanPeriod() As Integer
	Public Property InterestRate() As Double
	Public Property StartDate() As DateTime
	Public Property FitToPage() As Boolean
End Class

