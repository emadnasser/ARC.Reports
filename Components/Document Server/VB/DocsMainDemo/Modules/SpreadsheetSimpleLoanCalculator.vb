Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Spreadsheet
Imports System.Globalization
Imports DevExpress.Spreadsheet.Demos

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetSimpleLoanCalculatorModule
		Inherits SpreadsheetTutorialControl
		Public Sub New()
			InitializeComponent()
			'SuppressRefreshPreview();
			Me.FitToPageCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked
			'ResumeRefreshPreview();
			'RefreshPreview(); // not needed
		End Sub

		Protected Overrides ReadOnly Property DefaultFileName() As String
			Get
				Return "Simple_Loan_Calculator"
			End Get
		End Property

		Public Overrides Function CreateBook() As IWorkbook
			Dim generator As New LoanAmortizationScheduleDocumentGenerator(DefaultCulture)
			generator.LoanAmount = CDbl(Me.loanAmountSE.Value)
			generator.InterestRate = CDbl(annualInterestRateSE.Value)
			generator.PeriodInYears = CInt(Fix(loanPeriodinYearsSE.Value))
			generator.StartDateOfLoan = startDateofLoanDE.DateTime
			generator.FitToPage = FitToPageCheckEdit.Checked
			Return generator.Generate()
		End Function

		Private Sub loanAmountSE_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles loanAmountSE.ValueChanged
			RefreshPreview()
		End Sub
		Private Sub annualInterestRateSE_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles annualInterestRateSE.ValueChanged
			RefreshPreview()
		End Sub
		Private Sub loanPeriodinYearsSE_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles loanPeriodinYearsSE.ValueChanged
			RefreshPreview()
		End Sub
		Private Sub startDateofLoanTE_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles startDateofLoanDE.EditValueChanged
			RefreshPreview()
		End Sub
	End Class
End Namespace
