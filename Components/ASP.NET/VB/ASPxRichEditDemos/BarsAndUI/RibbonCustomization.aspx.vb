Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxRichEdit

Partial Public Class RichEditDemoRibbonCustomization
	Inherits OfficeDemoPage
	Private ReadOnly Property CurrentRibbonMode() As RichEditRibbonMode
		Get
			Return CType(System.Enum.Parse(GetType(RichEditRibbonMode), ddlRibbonMode.SelectedItem.Value.ToString()), RichEditRibbonMode)
		End Get
	End Property
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			DemoRichEdit.RibbonMode = CurrentRibbonMode
			DemoRichEdit.ShowStatusBar = cbShowStatusBar.Checked

			If CurrentRibbonMode.Equals(RichEditRibbonMode.ExternalRibbon) Then
				ExternalRibbon.Visible = True
				DemoRichEdit.AssociatedRibbonID = ExternalRibbon.ID
			Else
				ExternalRibbon.Visible = False
			End If
		End If
	End Sub
	Protected Sub DemoRichEdit_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		DemoRichEdit.Focus()
	End Sub
End Class
