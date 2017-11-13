Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class RoundPanel_Features
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		UpdateSettings()
	End Sub
	Protected Sub UpdateSettings()
		Dim collapsingEnabled As Boolean = IsCollapsingEnabled
		rpShowCollapseButton.Enabled = collapsingEnabled
		rpEnableAnimation.Enabled = collapsingEnabled
		rpAllowCollapsingByHeaderClick.Enabled = IsCollapsingEnabled

		ASPxFormLayout1.FindItemOrGroupByName("CollapsingSettingsGroup").Visible = View = View.Standard

		ASPxRoundPanel1.ShowHeader = rpShowHeader.Checked
		ASPxRoundPanel1.ShowCollapseButton = rpShowCollapseButton.Checked
		ASPxRoundPanel1.View = View
		ASPxRoundPanel1.EnableAnimation = rpEnableAnimation.Checked
		ASPxRoundPanel1.AllowCollapsingByHeaderClick = rpAllowCollapsingByHeaderClick.Checked
	End Sub
	Protected ReadOnly Property IsCollapsingEnabled() As Boolean
		Get
			Return View = View.Standard AndAlso rpShowHeader.Checked
		End Get
	End Property
	Protected ReadOnly Property View() As View
		Get
			Return CType(rpView.Value, View)
		End Get
	End Property
End Class
