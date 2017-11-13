Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Docs.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraReports.UI
Imports System.Globalization

Partial Public Class Spreadsheet_MailMerge
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If Me.previewControl.CanShowPreview() Then
			Dim previewParams As MailMergePreviewParams = ParsePreview(Request.Params)
			RefreshPreview(previewParams)
			Return
		End If
		Me.previewControl.Workbook = CreateWorkbook()
	End Sub
	Private Function CreateWorkbook() As IWorkbook
		Return CreateWorkbook(teStatementNumber.Text, teCustomerID.Text, teCustomerName.Text, teStreetAddress.Text, teCity.Text, teState.Text, teZipCode.Text, tePhone.Text, teEmail.Text, True)
	End Function

	Private Function CreateWorkbook(ByVal statementNumber As String, ByVal customerId As String, ByVal customerName As String, ByVal streetAddress As String, ByVal city As String, ByVal state As String, ByVal zipCode As String, ByVal phone As String, ByVal email As String, ByVal fitToPage As Boolean) As IWorkbook
		Dim example As New MailMergeDocumentGenerator(New CultureInfo("en-US"))
		example.StatementNumber = statementNumber
		example.CustomerId = customerId
		example.CustomerName = customerName
		example.Street = streetAddress
		example.City = city
		example.State = state
		example.ZIP = zipCode
		example.Phone = phone
		example.Email = email
		example.Path = Page.MapPath("~/App_Data/Billing_statement.xlsx")
		example.FitToPage = fitToPage
		Return example.Generate()
	End Function
	Protected Sub OnDocumentDownloaderRequestWorkbook(ByVal sender As Object, ByVal args As RequestWorkbookEventArgs)
		args.Workbook = CreateWorkbook()
	End Sub
	Private Sub RefreshPreview(ByVal previewParams As MailMergePreviewParams)
		Dim book As IWorkbook = CreateWorkbook(previewParams.StatementNumber, previewParams.CustomerID, previewParams.CustomerName, previewParams.StreetAddress, previewParams.City, previewParams.State, previewParams.ZipCode, previewParams.Phone, previewParams.Email, previewParams.FitToPage)
		Me.previewControl.Workbook = book
		Me.previewControl.RenderSpreadsheetPreview()
	End Sub
	Private Function ParsePreview(ByVal nameValueCollection As System.Collections.Specialized.NameValueCollection) As MailMergePreviewParams
		Dim previewParams As New MailMergePreviewParams()
		Dim statementNumberStringValue As String = nameValueCollection("statementNumber")
		Dim streetAddressStringValue As String = nameValueCollection("streetAddress")
		Dim zipCodeStringValue As String = nameValueCollection("zipCode")
		Dim customerIDStringValue As String = nameValueCollection("customerID")
		Dim сityStringValue As String = nameValueCollection("city")
		Dim phoneStringValue As String = nameValueCollection("phone")
		Dim customerNameStringValue As String = nameValueCollection("customerName")
		Dim stateStringValue As String = nameValueCollection("state")
		Dim emailStringValue As String = nameValueCollection("email")

		previewParams.StatementNumber = If((String.IsNullOrEmpty(statementNumberStringValue)), Me.teStatementNumber.Text, statementNumberStringValue)
		previewParams.StreetAddress = If((String.IsNullOrEmpty(streetAddressStringValue)), Me.teStreetAddress.Text, streetAddressStringValue)
		previewParams.ZipCode = If((String.IsNullOrEmpty(zipCodeStringValue)), Me.teZipCode.Text, zipCodeStringValue)
		previewParams.CustomerID = If((String.IsNullOrEmpty(customerIDStringValue)), Me.teCustomerID.Text, customerIDStringValue)
		previewParams.City = If((String.IsNullOrEmpty(сityStringValue)), Me.teCity.Text, сityStringValue)
		previewParams.Phone = If((String.IsNullOrEmpty(phoneStringValue)), Me.tePhone.Text, phoneStringValue)
		previewParams.CustomerName = If((String.IsNullOrEmpty(customerNameStringValue)), Me.teCustomerName.Text, customerNameStringValue)
		previewParams.State = If((String.IsNullOrEmpty(stateStringValue)), Me.teState.Text, stateStringValue)
		previewParams.Email = If((String.IsNullOrEmpty(emailStringValue)), Me.teEmail.Text, emailStringValue)
		previewParams.FitToPage = True
		Return previewParams
	End Function
End Class
Public Class MailMergePreviewParams
	Public Property StatementNumber() As String
	Public Property StreetAddress() As String
	Public Property ZipCode() As String
	Public Property CustomerID() As String
	Public Property City() As String
	Public Property Phone() As String
	Public Property CustomerName() As String
	Public Property State() As String
	Public Property Email() As String
	Public Property FitToPage() As Boolean
End Class
