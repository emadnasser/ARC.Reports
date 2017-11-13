Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Spreadsheet
Imports System.Globalization


Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetMailMergeModule
		Inherits SpreadsheetTutorialControl
		Public Sub New()
			InitializeComponent()
			RefreshPreview()
		End Sub

		Protected Overrides ReadOnly Property DefaultFileName() As String
			Get
				Return "Mail_Merge"
			End Get
		End Property

		Public Overrides Function CreateBook() As IWorkbook
			Dim statementNumber As String = statementNumberTE.Text
			Dim customerId As String = customerIDTE.Text
			Dim customerName As String = nameTE.Text
			Dim fitToPage As Boolean = FitToPageCheckEdit.Checked
			Dim relativePath As String = DemoUtils.GetRelativePath("Billing_statement.xlsx")
			Dim email As String = emailTE.Text
			Dim phone As String = phoneTE.Text
			Dim zipCode As String = zipCodeTE.Text
			Dim stateAddress As String = stateAddressTE.Text
			Dim cityAddress As String = cityAddressTE.Text
			Dim streetAddress As String = streetAddressTE.Text
			Dim generator As New MailMergeDocumentGenerator(DefaultCulture)
			generator.StatementNumber = statementNumber
			generator.CustomerId =customerId
			generator.CustomerName = customerName
			generator.Street = streetAddress
			generator.City = cityAddress
			generator.State = stateAddress
			generator.ZIP = zipCode
			generator.Phone = phone
			generator.Email = email
			generator.Path = relativePath
			generator.FitToPage = fitToPage
			Return generator.Generate()
		End Function

		Private Sub textEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles phoneTE.EditValueChanged, stateAddressTE.EditValueChanged, emailTE.EditValueChanged, zipCodeTE.EditValueChanged, statementNumberTE.EditValueChanged, customerIDTE.EditValueChanged, nameTE.EditValueChanged, streetAddressTE.EditValueChanged, cityAddressTE.EditValueChanged
			RefreshPreview()
		End Sub
	End Class
End Namespace
