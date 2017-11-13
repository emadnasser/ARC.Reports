Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos
Imports DevExpress.XtraReports.Web

Public MustInherit Class PageBase(Of TReport)
	Inherits Page
	Public ReadOnly Property IsASPViewer() As Boolean
		Get
			Return Request.Params(ViewerSelectorState.Key) = ViewerSelectorState.ClassicViewer
		End Get
	End Property

	Public ReadOnly Property IsHTML5Viewer() As Boolean
		Get
			Return Request.Params(ViewerSelectorState.Key) Is Nothing
		End Get
	End Property

	Public ReadOnly Property IsMobileViewer() As Boolean
		Get
			Return Request.Params(ViewerSelectorState.Key) = ViewerSelectorState.MobileViewer

		End Get
	End Property
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) AndAlso String.Equals(Request("fromDesigner"), Boolean.TrueString, StringComparison.OrdinalIgnoreCase) Then
			CleanDocument()

			Dim redirectUrl = Request.RawUrl.Substring(Request.ApplicationPath.Length)
			redirectUrl = ReportDesignerUrlLogic.CleanUrl(redirectUrl, False)
			Response.Redirect("~/" & redirectUrl)
		End If

		Dim topRightMenuRegion = Master.FindControl("TopRightMenuRegion")
		Dim showDesignerButton = TryCast(topRightMenuRegion.FindControl("showDesignerButton"), IShowDesignerButtonControl)
		If showDesignerButton IsNot Nothing Then
			showDesignerButton.ReportTypeName = ReportTypeName
		End If

		Dim contentPlaceHolder = Master.FindControl("ContentHolder")
		Dim documentViewer = TryCast(contentPlaceHolder.FindControl("documentViewer"), ASPxDocumentViewer)
		If documentViewer IsNot Nothing Then
			documentViewer.Report = ReportStorageHelper.LoadReport(ReportTypeName, Session)
		End If
		Dim webDocumentViewer = TryCast(contentPlaceHolder.FindControl("webDocumentViewer"), ASPxWebDocumentViewer)
		If webDocumentViewer IsNot Nothing Then
			webDocumentViewer.OpenReport(ReportStorageHelper.LoadReport(ReportTypeName, Session))
		End If
		Dim mobileEmulator = TryCast(contentPlaceHolder.FindControl("mobileEmulator"), IMobileEmulator)
		If mobileEmulator IsNot Nothing Then
			mobileEmulator.ReportTypeName = ReportTypeName
		End If
		Dim viewerSelector = TryCast(topRightMenuRegion.FindControl("viewerSelector"), IMobileEmulator)
		If viewerSelector IsNot Nothing Then
			viewerSelector.ReportTypeName = ReportTypeName
		End If
	End Sub

	Protected ReadOnly Property ReportTypeName() As String
		Get
			Return GetType(TReport).FullName
		End Get
	End Property

	Protected Overridable Sub CleanDocument()
	End Sub
End Class
