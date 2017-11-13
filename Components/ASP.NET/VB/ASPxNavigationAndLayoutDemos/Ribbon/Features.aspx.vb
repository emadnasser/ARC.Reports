Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Ribbon_Features
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			ASPxRibbon.AllowMinimize = cbAllowMinimize.Checked
			ASPxRibbon.ShowFileTab = cbShowFileTab.Checked
			ASPxRibbon.ShowTabs = cbShowTabs.Checked
			ASPxRibbon.ShowGroupLabels = cbShowGroupNames.Checked
		Else
			cbShowFileTab.Checked = ASPxRibbon.ShowFileTab
			cbShowTabs.Checked = ASPxRibbon.ShowTabs
			cbAllowMinimize.Checked = ASPxRibbon.AllowMinimize
			cbShowGroupNames.Checked = ASPxRibbon.ShowGroupLabels
		End If
	End Sub
End Class
