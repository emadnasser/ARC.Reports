Imports System
Imports System.Configuration
Imports System.Web
Imports System.Web.UI
Imports System.Linq
Imports DevExpress.Web.Internal

Partial Public Class TabletViewer_Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        If RenderUtils.Browser.Platform.IsTouchUI Then
            Response.Redirect("../default.aspx")
        ElseIf RenderUtils.Browser.IsIE AndAlso RenderUtils.Browser.Version < 9 Then
            simulatorFrame.Attributes("src") = "UnsupportedBrowser.aspx"
        Else
            Dim siteModeSetting As String = ConfigurationManager.AppSettings("SiteMode")
            If (Not String.IsNullOrEmpty(siteModeSetting)) AndAlso siteModeSetting.Equals("true", StringComparison.InvariantCultureIgnoreCase) Then
                qrcodeContainer.Visible = True
                Dim url As String = String.Format("http://{0}{1}", Request.Url.Host, Page.ResolveUrl("~/default.aspx"))
                qrcodeLink.Attributes("href") = url & "?noredirect=true"
                qrcodeImg.Attributes("src") = String.Format("http://chart.apis.google.com/chart?cht=qr&chs=140x140&chl={0}&chld=H|0", HttpUtility.UrlEncode(url))
            End If
        End If
        If Application.AllKeys.Contains("PageTitle") Then
            Page.Title = Application("PageTitle").ToString()
        End If
    End Sub
End Class
