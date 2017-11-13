Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Spreadsheet
Imports System.IO
Imports System.Net

Partial Public Class UserControls_SpreadsheetDocumentDownloader
	Inherits System.Web.UI.UserControl

	Public Sub New()
		Inline = True
	End Sub

	Public Property Inline() As Boolean

	Public Event RequestWorkbook As RequestWorkbookEventHandler

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub

	Protected Sub btnDownload_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim book As IWorkbook = RaiseRequestWorkbook()
		If book Is Nothing Then
			Return
		End If
		Dim stream As New MemoryStream()
		Dim value As Integer = CInt(Fix(cbDownloadType.Value))
		If value = 4 Then
			book.ExportToPdf(stream)
		Else
			Dim format As DocumentFormat = ConvertIndexToFormat(value)
			book.SaveDocument(stream, format)
		End If
		stream.Seek(0, SeekOrigin.Begin)
		stream.CopyTo(Response.OutputStream)

		Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
		Response.ContentType = ConvertIndexToContentType(value)
		Response.AddHeader("Content-Disposition", String.Format("attachment; filename=ExpenseReport.{0}", ConvertIndexToFileExtension(value)))
		Response.End()
	End Sub

	Private Function RaiseRequestWorkbook() As IWorkbook
		If RequestWorkbookEvent Is Nothing Then
			Return Nothing
		End If
		Dim args As New RequestWorkbookEventArgs()
		RaiseEvent RequestWorkbook(Me, args)
		Return args.Workbook
	End Function
	Private Function ConvertIndexToFormat(ByVal value As Integer) As DocumentFormat
		Select Case value
			Case 1
				Return DocumentFormat.OpenXml
			Case 2
				Return DocumentFormat.Xls
			Case 3
				Return DocumentFormat.Csv
		End Select
		Return DocumentFormat.Undefined
	End Function
	Private Function ConvertIndexToContentType(ByVal value As Integer) As String
		Select Case value
			Case 1
				Return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
			Case 2
				Return "application/vnd.ms-excel"
			Case 3
				Return "text/comma-separated-values"
			Case 4
				Return "application/pdf"
		End Select
		Return String.Empty
	End Function
	Private Function ConvertIndexToFileExtension(ByVal value As Integer) As String
		Select Case value
			Case 1
				Return "xlsx"
			Case 2
				Return "xls"
			Case 3
				Return "csv"
			Case 4
				Return "pdf"
		End Select
		Return String.Empty
	End Function
End Class

Public Class RequestWorkbookEventArgs
	Public Property Workbook() As IWorkbook
End Class
Public Delegate Sub RequestWorkbookEventHandler(ByVal sender As Object, ByVal args As RequestWorkbookEventArgs)
