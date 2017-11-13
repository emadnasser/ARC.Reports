Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web

Partial Public Class WebSpecificFeatures_Thumbnails
	Inherits System.Web.UI.Page
	Public Class ThumbnailsFiller
		Inherits BookmarkFillerBase(Of Control)
		Public Shared Sub FillThumbnails(ByVal panel As ASPxPanel, ByVal documentViewer As ASPxDocumentViewer)
			CType(New ThumbnailsFiller(documentViewer), ThumbnailsFiller).Fill(panel)
		End Sub

		Protected Overrides ReadOnly Property Document() As Document
			Get
				Dim printingSystem = documentViewer.Report.PrintingSystem
				If printingSystem.PageCount = 0 Then
					documentViewer.Report.CreateDocument()
				End If
				Return printingSystem.Document
			End Get
		End Property

		Private documentViewer As ASPxDocumentViewer

		Private Sub New(ByVal documentViewer As ASPxDocumentViewer)
			MyBase.New(documentViewer.ClientID)
			Me.documentViewer = documentViewer
		End Sub

		Protected Overrides Function FillNode(ByVal parent As Control, ByVal bookmarkNode As BookmarkNode, ByVal navigationScript As String) As Control
			Dim aspxPanel As ASPxPanel = TryCast(parent, ASPxPanel)
			If aspxPanel IsNot Nothing Then
				Dim holder As New PlaceHolder()
				aspxPanel.Controls.Add(holder)
				Return holder
			End If

			Dim imageBrick As ImageBrick = TryCast(Document.GetBrick(bookmarkNode), ImageBrick)
			If imageBrick IsNot Nothing Then
				Dim fileName As String = bookmarkNode.Text & ".png"
				Dim filePath As String = HttpContext.Current.Server.MapPath("~/App_Data/Thumbnails/" & fileName)
				If (Not Directory.Exists(Path.GetDirectoryName(filePath))) Then
					Directory.CreateDirectory(Path.GetDirectoryName(filePath))
				End If
				Try
					If (Not File.Exists(filePath)) Then
						imageBrick.Image.Save(filePath, ImageFormat.Png)
					End If
				Catch e1 As System.Runtime.InteropServices.ExternalException
				End Try

				Dim image As New Image()
				image.BorderColor = imageBrick.BorderColor
				image.BorderWidth = New Unit(imageBrick.BorderWidth, UnitType.Pixel)
				image.AlternateText = bookmarkNode.Text
				image.ImageUrl = New Uri(parent.Page.Request.Url, "ThumbnailsImageHandler.ashx?img=" & System.Web.HttpUtility.UrlEncode(fileName)).ToString()
				image.Width = New Unit(imageBrick.Image.Width / 2, UnitType.Pixel)
				image.Height = New Unit(imageBrick.Image.Height / 2, UnitType.Pixel)

				Dim fullName As New LiteralControl()
				fullName.Text = bookmarkNode.Text

				Dim anchor As New HtmlAnchor()
				anchor.HRef = "javascript:void(" & navigationScript & ")"
				anchor.Controls.Add(image)
				anchor.Controls.Add(New LiteralControl("<br />"))
				anchor.Controls.Add(fullName)

				Dim div As New WebControl(HtmlTextWriterTag.Div)
				div.Style("margin-left") = "10px"
				div.Style("margin-top") = "10px"
				div.Style("margin-bottom") = "20px"
				div.Style("text-align") = "center"
				div.Controls.Add(anchor)

				parent.Controls.Add(div)
			End If
			Return Nothing
		End Function
	End Class

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim report = New XtraReportsDemos.ShrinkGrow.Report With {.PaperKind = PaperKind.A5, .Landscape = True}
		report.Margins.Left = 90
		report.Margins.Right = 85
		AddHandler report.xrPictureBox1.BeforePrint, AddressOf xrPictureBox1_BeforePrint
		documentViewer.Report = report
	End Sub

	Protected Overrides Sub OnPreRender(ByVal e As EventArgs)
		ThumbnailsFiller.FillThumbnails(Panel1, documentViewer)
		MyBase.OnPreRender(e)
	End Sub

	Private Sub xrPictureBox1_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs)
		Dim picture = CType(sender, XRPictureBox)
		Dim report = picture.RootReport
		picture.Bookmark = report.GetCurrentColumnValue(Of String)("FirstName") & " " & report.GetCurrentColumnValue(Of String)("LastName")
	End Sub
End Class
