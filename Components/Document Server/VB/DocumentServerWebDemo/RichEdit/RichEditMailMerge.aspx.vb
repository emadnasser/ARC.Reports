Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports System.Net
Imports DevExpress.Office.Services
Imports DevExpress.Web.Demos
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Partial Public Class RichEdit_MailMerge
	Inherits System.Web.UI.Page
	#Region "Fields"
	Private Const defaultFileName As String = "RichEditMailMerge"
	Private Const ServerFilePath As String = "~/App_Data/MailMerge.rtf"
	Private Const TargetIsPreview As Integer = 10

	Private mailMergeDataTable As DataTable = Nothing
	Private docServer As RichEditDocumentServer = Nothing
	Private data As InMemoryNWindData
	#End Region

	Public Sub New()
		MyBase.New()
		data = New InMemoryNWindData()
		InitializeData()
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If Request.QueryString.Count > 0 AndAlso Request.QueryString(0).StartsWith("preview") Then
			Dim strEmployeeId As String = Request.Params("employee")
			Dim employeeId As Integer = If(String.IsNullOrEmpty(strEmployeeId), Convert.ToInt32(cbEmployee.Value), Convert.ToInt32(strEmployeeId))
			Dim customerId As String = Request.Params("customer")
			If String.IsNullOrEmpty(customerId) Then
				customerId = Convert.ToString(cbCustomer.Value)
			End If
			RefreshPreview(employeeId, customerId)
		End If
	End Sub

	Private Sub RefreshPreview(ByVal employeeId As Integer, ByVal customerId As String)
		Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
		Response.ContentType = "text/html"
		If EnforceDocServer() Then
			Using outputStream As Stream = ExecuteMerge(TargetIsPreview, employeeId, customerId)
				If outputStream IsNot Nothing Then
					outputStream.Seek(0, SeekOrigin.Begin)
					outputStream.CopyTo(Response.OutputStream)
				End If
			End Using
		End If
		Response.End()
	End Sub

	Private Sub InitializeData()
		mailMergeDataTable = New DataTable()
		AddDataColumns()
	End Sub

	Private Sub AddDataColumns()
		mailMergeDataTable.Columns.Add("EmployeeID", GetType(Integer))
		mailMergeDataTable.Columns.Add("FirstName", GetType(String))
		mailMergeDataTable.Columns.Add("LastName", GetType(String))
		mailMergeDataTable.Columns.Add("ContactName", GetType(String))
		mailMergeDataTable.Columns.Add("Employees.Address", GetType(String))
		mailMergeDataTable.Columns.Add("Employees.City", GetType(String))
		mailMergeDataTable.Columns.Add("Employees.PostalCode", GetType(String))
		mailMergeDataTable.Columns.Add("ContactTitle", GetType(String))
		mailMergeDataTable.Columns.Add("CompanyName", GetType(String))
		mailMergeDataTable.Columns.Add("Customers.Address", GetType(String))
		mailMergeDataTable.Columns.Add("Customers.City", GetType(String))
		mailMergeDataTable.Columns.Add("Customers.PostalCode", GetType(String))
		mailMergeDataTable.Columns.Add("Title", GetType(String))
		mailMergeDataTable.Columns.Add("Photo", GetType(Object))
	End Sub

	Private Function PutMergeData(ByVal employeeId As Integer, ByVal customerId As String) As Boolean
		Dim currentEmployee As Employee = data.GetEmployee(employeeId)
		Dim currentCustomer As Customer = data.GetCustomer(customerId)
		If currentEmployee Is Nothing OrElse currentCustomer Is Nothing Then
			Return False
		End If
		mailMergeDataTable.Rows.Clear()
		mailMergeDataTable.Rows.Add(currentEmployee.EmployeeID, currentEmployee.FirstName, currentEmployee.LastName, currentCustomer.ContactName, currentEmployee.Address, currentEmployee.City, currentEmployee.PostalCode, currentCustomer.ContactTitle, currentCustomer.CompanyName, currentCustomer.Address, currentCustomer.City, currentCustomer.PostalCode, currentEmployee.Title, Nothing)
		Return True
	End Function

	Private Function ExecuteMerge(ByVal downloadType As Integer, ByVal employeeId As Integer, ByVal customerId As String) As Stream
		Dim result As Stream = Nothing
		If (Not PutMergeData(employeeId, customerId)) Then
			Return Nothing
		End If
		docServer.LoadDocument(Page.MapPath(ServerFilePath))
		docServer.Options.MailMerge.DataSource = mailMergeDataTable
		docServer.Options.MailMerge.ViewMergedData = True
		docServer.Options.Export.Html.EmbedImages = True
		result = New MemoryStream()
		If EnforceDocServer() Then
			If downloadType = 4 Then
				docServer.Options.MailMerge.ActiveRecord = 0
				docServer.ExportToPdf(result)
			Else
				Dim format As DocumentFormat = ConvertIndexToFormat(downloadType)
				MergeToDoc(result, format)
			End If
		End If
		Return result
	End Function

	Private Function EnforceDocServer() As Boolean
		If docServer Is Nothing Then
			docServer = New RichEditDocumentServer()
		End If
		If docServer Is Nothing Then
			Return False
		End If
		Dim uriService As IUriStreamService = CType(docServer.GetService(GetType(IUriStreamService)), IUriStreamService)
		uriService.RegisterProvider(New DevExpress.Docs.Demos.RichEditMailMergeDBUriStreamProvider(mailMergeDataTable, "Photo", Me))
		Return True
	End Function

	Protected Sub btnDownload_Click(ByVal sender As Object, ByVal e As EventArgs)
		If (Not EnforceDocServer()) Then
			Return
		End If
		Dim downloadType As Integer = CInt(Fix(cbDownloadType.Value))
		Using outputStream As Stream = ExecuteMerge(downloadType, Convert.ToInt32(cbEmployee.Value), Convert.ToString(cbCustomer.Value))
			If outputStream Is Nothing Then
				Return
			End If
			outputStream.Seek(0, SeekOrigin.Begin)
			outputStream.CopyTo(Response.OutputStream)
		End Using
		Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
		Response.ContentType = ConvertIndexToContentType(downloadType)
		Response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}.{1}", defaultFileName, ConvertIndexToFileExtension(downloadType)))
		Response.End()
	End Sub

	Private Sub MergeToDoc(ByVal stream As Stream, ByVal docFormat As DocumentFormat)
		Dim options As MailMergeOptions = docServer.CreateMailMergeOptions()
		options.DataSource = mailMergeDataTable
		options.FirstRecordIndex = 0
		options.LastRecordIndex = 0
		docServer.MailMerge(options, stream, docFormat)
	End Sub

	Private Function ConvertIndexToFormat(ByVal value As Integer) As DocumentFormat
		Select Case value
			Case 1
				Return DocumentFormat.Rtf
			Case 2
				Return DocumentFormat.Doc
			Case 3
				Return DocumentFormat.OpenXml
			Case 5
				Return DocumentFormat.PlainText
			Case 6
				Return DocumentFormat.Mht
			Case 7
				Return DocumentFormat.OpenDocument
			Case 8
				Return DocumentFormat.WordML
			Case 9
				Return DocumentFormat.ePub
			Case 10
				Return DocumentFormat.Html
		End Select
		Return DocumentFormat.Undefined
	End Function
	Private Function ConvertIndexToContentType(ByVal value As Integer) As String
		Select Case value
			Case 1
				Return "application/msword"
			Case 2
				Return "application/msword"
			Case 3
				Return "application/msword"
			Case 4
				Return "application/msword"
			Case 5
				Return "text/plain"
			Case 6
				Return "message/rfc822"
			Case 7
				Return "application/msword"
			Case 8
				Return "text/xml"
			Case 9
				Return "application/msword"
		End Select
		Return String.Empty
	End Function
	Private Function ConvertIndexToFileExtension(ByVal value As Integer) As String
		Select Case value
			Case 1
				Return "rtf"
			Case 2
				Return "doc"
			Case 3
				Return "docx"
			Case 4
				Return "pdf"
			Case 5
				Return "txt"
			Case 6
				Return "mht"
			Case 7
				Return "odt"
			Case 8
				Return "xml"
			Case 9
				Return "epub"
		End Select
		Return String.Empty
	End Function


	Private Sub FillEmployeeCombo()
		Dim comboItems As New DevExpress.Web.ListEditItemCollection()
		For Each item As Employee In data.Employees
			comboItems.Add(item.FirstName & " " & item.LastName, item.EmployeeID)
		Next item
		cbEmployee.Items.Assign(comboItems)
	End Sub

	Private Sub ApplyEmployee(ByVal employeeId As Integer)
		If employeeId < 0 Then
			Return
		End If
		Dim customersList As List(Of Customer) = data.GetCustomersList(employeeId)
		Dim comboItems As New DevExpress.Web.ListEditItemCollection()
		For Each item As Customer In customersList
			comboItems.Add(item.ContactName, item.CustomerID)
		Next item
		cbCustomer.Items.Assign(comboItems)
		If cbCustomer.Items.Count > 0 Then
			cbCustomer.SelectedIndex = 0
		End If
	End Sub

	Protected Sub cbCustomer_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
		If (Not String.IsNullOrEmpty(e.Parameter)) Then
			ApplyEmployee(Convert.ToInt32(e.Parameter))
		End If
	End Sub

	Protected Sub cbEmployee_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
		If e.Parameter = "init" Then
			FillEmployeeCombo()
			If cbEmployee.Items.Count > 0 Then
				cbEmployee.SelectedIndex = 0
			End If
		End If
	End Sub
	Protected Sub cbCustomer_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
End Class

Namespace DevExpress.Docs.Demos
	Public Class RichEditMailMergeDBUriStreamProvider
		Implements IUriStreamProvider
		Private Shared ReadOnly prefix As String = "dbimg://"
		Private table As DataTable
		Private columnName As String
		Private page As System.Web.UI.Page

		Public Sub New(ByVal table As DataTable, ByVal columnName As String, ByVal page As System.Web.UI.Page)
			Me.table = table
			Me.columnName = columnName
			Me.page = page
		End Sub

		Private Function GetStream(ByVal uri As String) As Stream Implements IUriStreamProvider.GetStream
			uri = uri.Trim()
			If (Not uri.StartsWith(prefix)) Then
				Return Nothing
			End If
			Dim strId As String = uri.Substring(prefix.Length).Trim()
			Dim id As Integer
			If (Not Integer.TryParse(strId, id)) Then
				Return Nothing
			End If
			Dim pictureRoot As String = page.MapPath("~/App_Data/")
			Dim fileName As String = String.Format("{0}Photo{1}.jpeg", pictureRoot, id)
			Dim bytes() As Byte = Nothing
			Using fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)
				Dim length As Integer = CInt(Fix(fs.Length))
				bytes = New Byte(length - 1){}
				fs.Read(bytes, 0, length)
			End Using
			Return New MemoryStream(bytes)
		End Function
	End Class
End Namespace
