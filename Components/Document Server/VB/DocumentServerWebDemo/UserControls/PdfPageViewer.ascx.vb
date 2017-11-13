Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Web.Hosting
Imports DevExpress.Pdf
Imports DevExpress.Web

Partial Public Class UserControls_PdfPageViewer
	Inherits System.Web.UI.UserControl
	Public Property PageIndex() As Integer
		Get
			Return CInt(Fix(Session(Page.AppRelativeVirtualPath & "PageIndex")))
		End Get
		Private Set(ByVal value As Integer)
			Session(Page.AppRelativeVirtualPath & "PageIndex") = value
		End Set
	End Property

	Public Property DocumentData() As Byte()
		Get
			Return CType(Session(Page.AppRelativeVirtualPath & "DocumentData"), Byte())
		End Get
		Private Set(ByVal value As Byte())
			Session(Page.AppRelativeVirtualPath & "DocumentData") = value
			PageIndex = 0
		End Set
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not ASPxCallbackPanel.IsCallback) Then
			OnCallback(Nothing, New CallbackEventArgsBase("PN" & PageIndex))
		End If
	End Sub
	Protected Sub OnCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		Update(e.Parameter)
	End Sub

	Private Sub Update(ByVal parameter As String)
		Try
			Dim documentData() As Byte = Me.DocumentData
			If documentData IsNot Nothing Then
				Using documentProcessor As New PdfDocumentProcessor()
				Using dataStream As New MemoryStream(documentData)
					documentProcessor.LoadDocument(dataStream, True)
					pager.ItemCount = documentProcessor.Document.Pages.Count
					Dim pageIndex As Integer
					If String.IsNullOrEmpty(parameter) Then
						pageIndex = 0
					Else
						parameter = parameter.Substring(2)
						If (Not Int32.TryParse(parameter, pageIndex)) Then
							If parameter.Equals("P") Then
								pageIndex = 0
							Else
								pageIndex = pager.PageCount - 1
							End If
						End If
					End If
					Me.PageIndex = pageIndex
					pager.PageIndex = pageIndex
					Try
						Using bitmap As Bitmap = documentProcessor.CreateBitmap(pageIndex + 1, 900)
						Using stream As New MemoryStream()
							bitmap.Save(stream, ImageFormat.Png)
							pageImage.Src = "data:image/png;base64," & Convert.ToBase64String(stream.GetBuffer())
						End Using
						End Using
					Catch
						pageImage.Src = String.Empty
					End Try
				End Using
				End Using
			End If
		Catch
		End Try
	End Sub
	Public Sub UpdateDocument(ByVal stream As Stream, ByVal parameter As String)
		Using reader As New BinaryReader(stream)
			DocumentData = reader.ReadBytes(CInt(Fix(stream.Length)))
		End Using
		Update(parameter)
	End Sub
	Public Sub LoadDocument(ByVal path As String)
		Using document As Stream = New FileStream(HostingEnvironment.MapPath(path), FileMode.Open, FileAccess.Read)
			LoadDocument(document)
		End Using
	End Sub
	Public Sub LoadDocument(ByVal document As Stream)
		Using reader As New BinaryReader(document)
			DocumentData = reader.ReadBytes(CInt(Fix(document.Length)))
		End Using
	End Sub
	Public Function LoadDocument(ByVal uploadControl As ASPxUploadControl) As String
		Dim uploadedFile As UploadedFile = uploadControl.UploadedFiles(0)
		If (Not uploadedFile.IsValid) Then
			Return Nothing
		End If
		DocumentData = uploadedFile.FileBytes
		Try
			Using processor As New PdfDocumentProcessor()
				Using ms As New MemoryStream(DocumentData)
					processor.LoadDocument(ms, True)
				End Using
			End Using
		Catch
			LoadDocument("~/App_Data/Error.pdf")
		End Try
		Return uploadedFile.FileName
	End Function
End Class
