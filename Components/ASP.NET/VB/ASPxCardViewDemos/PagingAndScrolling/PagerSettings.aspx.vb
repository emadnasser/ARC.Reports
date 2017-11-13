Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web.UI.WebControls

Partial Public Class PagingAndScrolling_PagerSettings
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		CardView.SettingsPager.Position = CType(System.Enum.Parse(GetType(PagerPosition), Position.Text), PagerPosition)
		CardView.SettingsPager.ShowDisabledButtons = ShowDisabledButtons.Checked
		CardView.SettingsPager.ShowNumericButtons = ShowNumericButtons.Checked
		CardView.SettingsPager.ShowSeparators = ShowSeparators.Checked
		CardView.SettingsPager.Summary.Visible = ShowSummary.Checked
		CardView.SettingsPager.PageSizeItemSettings.Visible = ShowPageSizeItems.Checked
		CardView.SettingsPager.PageSizeItemSettings.Position = CType(System.Enum.Parse(GetType(PagerPageSizePosition), PageSizePosition.Text), PagerPageSizePosition)
	End Sub
End Class
