Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web.UI.WebControls

Partial Public Class PagingAndScrolling_PagerSettings
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		VerticalGrid.SettingsPager.Position = CType(System.Enum.Parse(GetType(PagerPosition), Position.Text), PagerPosition)
		VerticalGrid.SettingsPager.ShowDisabledButtons = ShowDisabledButtons.Checked
		VerticalGrid.SettingsPager.ShowNumericButtons = ShowNumericButtons.Checked
		VerticalGrid.SettingsPager.ShowSeparators = ShowSeparators.Checked
		VerticalGrid.SettingsPager.Summary.Visible = ShowSummary.Checked
		VerticalGrid.SettingsPager.PageSizeItemSettings.Visible = ShowPageSizeItems.Checked
		VerticalGrid.SettingsPager.PageSizeItemSettings.Position = CType(System.Enum.Parse(GetType(PagerPageSizePosition), PageSizePosition.Text), PagerPageSizePosition)
	End Sub
End Class
