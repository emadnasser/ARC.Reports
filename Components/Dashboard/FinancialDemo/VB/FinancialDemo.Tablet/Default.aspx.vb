Imports Microsoft.VisualBasic
Imports System
Imports System.Web
Imports DevExpress.Web.Internal
Imports DashboardDemos.Core

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private Const LOCAL_TOUCHBOARD_RELATIVE_PATH As String = "/DashboardViewer.aspx"
	Private Const QRCODE_URL As String = "http://go.devexpress.com/DashboardTabletDemo.aspx"

	Protected Overrides Sub OnInit(ByVal e As EventArgs)
		MyBase.OnInit(e)
		If DashboardDemosUtils.ShouldRecreateDatabases(Nothing) Then
			Response.Redirect("DatabaseGenerationForm.aspx")
		End If
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If RenderUtils.Browser.Platform.IsTouchUI OrElse (Not String.IsNullOrEmpty(Request.Params("noredirect"))) Then
			Response.Redirect(DemoUrl)
		End If
	End Sub
	Public ReadOnly Property DemoUrl() As String
		Get
			Dim fullUrl As String = Page.Request.Url.ToString().ToLower()
			Return fullUrl.Remove(fullUrl.LastIndexOf("/")) & LOCAL_TOUCHBOARD_RELATIVE_PATH
		End Get
	End Property
	Public ReadOnly Property QRCodeSize() As Integer
		Get
			Return 124
		End Get
	End Property
	Public ReadOnly Property QRCodeUrl() As String
		Get
			Return String.Format("http://chart.apis.google.com/chart?cht=qr&chs={0}x{1}&chl={2}&chld=H|0", QRCodeSize, QRCodeSize, HttpUtility.UrlEncode(QRCODE_URL))
		End Get
	End Property
End Class
