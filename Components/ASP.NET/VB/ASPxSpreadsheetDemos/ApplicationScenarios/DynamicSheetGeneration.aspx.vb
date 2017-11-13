Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.Demos

Partial Public Class ApplicationScenarios_DynamicSheetGeneration
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim isDocumentLoaded As Boolean = Not Page.IsPostBack
		If isDocumentLoaded Then
			InitializeReportParameters()
		End If

		Dim demoHelper As LoanAmortizationScheduleDemoHelper = New LoanAmortizationScheduleDemoHelper With {.LoanAmount = CDbl(LoanAmount.Number), .AnnualInterestRate = AnnualInterestRate.Number, .LoanPeriodInYears = CInt(Fix(LoanPeriodInYears.Number)), .NumberOfPayments = CInt(Fix(NumberOfPayments.Number)), .StartDate = CDate(StartDate.Value), .OptionalExtraPayments = CDbl(OptionalExtraPayments.Number)}
		demoHelper.PrepareSpreadsheetDocument(Spreadsheet.Document)
		SpreadsheetDemoUtils.HideFileTab(Spreadsheet)
	End Sub
	Private Sub InitializeReportParameters()
		LoanAmount.Value = 19900
		AnnualInterestRate.Value = 0.055
		LoanPeriodInYears.Value = 2
		NumberOfPayments.Value = 12
		StartDate.Value = DateTime.Now
		OptionalExtraPayments.Value = 200
	End Sub
End Class
