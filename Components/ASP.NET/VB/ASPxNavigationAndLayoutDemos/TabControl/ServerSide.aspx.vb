Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Demos
Imports DevExpress.Web
Imports DevExpress.CodeParser
Imports DevExpress.Web.DemoUtils
Imports System.Web.UI.WebControls

Partial Public Class TabControl_ServerSide
	Inherits Page
	Protected Const CssCode As String = "div.SampleCSS span {" & Constants.vbLf & "    font-size: 8pt;" & Constants.vbLf & "    font-family: Verdana;" & Constants.vbLf & "    font-weight: bold;" & Constants.vbLf & "}"

	Protected Const HtmlCode As String = "<div class=""SampleCSS"">" & Constants.vbLf & "    <span>Sample content</span>" & Constants.vbLf & "</div>"

	Private ReadOnly Property CurrentTab() As TabPage
		Get
			Return ASPxPageControl1.TabPages.FindByName(ddlTabs.SelectedItem.Value.ToString())
		End Get
	End Property

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		CssCodeHolder.InnerHtml = CodeFormatter.GetFormattedCode(TokenLanguage.Css, CssCode)
		HtmlCodeHolder.InnerHtml = CodeFormatter.GetFormattedCode(TokenLanguage.Html, HtmlCode)
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/TabControl/CSS/ServerSide.css")
		If (Not IsPostBack) Then
			For Each tabPage As TabPage In ASPxPageControl1.TabPages
				ddlTabs.Items.Add(New ListEditItem(tabPage.Text, tabPage.Name))
			Next tabPage
			ddlTabs.SelectedIndex = 0
		End If
		If Utils.IsLargeTheme Then
			ddlTabs.Width = Unit.Pixel(95)
		Else
			ddlTabs.Width = Unit.Pixel(70)
		End If
	End Sub

	Protected Sub cbEnable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		CurrentTab.Enabled = cbEnable.Checked
		ddlTabs_SelectedIndexChanged(sender, e)
	End Sub

	Protected Sub cbVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		CurrentTab.Visible = cbVisible.Checked
		ddlTabs_SelectedIndexChanged(sender, e)
	End Sub

	Protected Sub cbActive_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		cbActive.Checked = cbEnable.Checked AndAlso cbVisible.Checked
		If cbActive.Checked Then
			ASPxPageControl1.ActiveTabPage = CurrentTab
		End If
	End Sub

	Protected Sub ASPxPageControl1_ActiveTabChanged(ByVal sender As Object, ByVal e As TabControlEventArgs)
		EventMonitor.TraceEvent(sender, e, "ActiveTabChanged")
		ddlTabs.Value = ASPxPageControl1.ActiveTabPage.Name
		ddlTabs_SelectedIndexChanged(sender, e)
	End Sub

	Protected Sub ASPxPageControl1_ActiveTabChanging(ByVal sender As Object, ByVal e As TabControlCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "ActiveTabChanging")
	End Sub

	Protected Sub ddlTabs_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		cbEnable.Checked = CurrentTab.Enabled
		cbVisible.Checked = CurrentTab.Visible
		cbActive.Checked = CurrentTab.IsActive
	End Sub
End Class
