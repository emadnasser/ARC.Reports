Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web

Public Class DashboardBasePage
	Inherits Page
	Shared Sub New()
		DevExpress.Utils.UrlAccessSecurityLevelSetting.SecurityLevel = DevExpress.Utils.UrlAccessSecurityLevel.FilesFromBaseDirectory
	End Sub
	Protected Overrides Sub OnLoad(ByVal e As EventArgs)
		MyBase.OnLoad(e)

	End Sub
	Protected Overrides Sub OnInit(ByVal e As EventArgs)
		MyBase.OnInit(e)
		Dim dashboardName As String = Me.GetType().BaseType.Name
		If (Not String.IsNullOrEmpty(dashboardName)) Then
			Dim phContent As Control = Form.FindControl("ContentHolder")
			If phContent IsNot Nothing Then
				Dim div As New HtmlGenericControl("div")
				Dim link As ASPxHyperLink = New ASPxHyperLink With {.ForeColor = System.Drawing.Color.White, .Target = "_blank", .NavigateUrl = String.Format("~/FullScreenSamples/{0}.aspx", dashboardName)}
				link.Style.Add("text-decoration", "none")
				link.EnableTheming = False
				Dim innerDiv As New HtmlGenericControl("b")
				innerDiv.Attributes.Add("class", "fullScreenLink")
				innerDiv.InnerText = "Full Screen View"
				link.Controls.Add(innerDiv)
				div.Controls.Add(link)
				phContent.Controls.AddAt(0, div)
			End If
		End If
	End Sub
End Class
