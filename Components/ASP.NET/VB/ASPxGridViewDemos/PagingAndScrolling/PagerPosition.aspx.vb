Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class PagingAndScrolling_PagerPosition
	Inherits Page
	Private ReadOnly Property CurrentPagerPosition() As PagerPosition
		Get
			Return CType(System.Enum.Parse(GetType(PagerPosition), cbPagerPosition.SelectedItem.Value.ToString()), PagerPosition)
		End Get
	End Property
	Private ReadOnly Property CurrentPageSizePosition() As PagerPageSizePosition
		Get
			Return CType(System.Enum.Parse(GetType(PagerPageSizePosition), cbPageSizeItemPosition.SelectedItem.Value.ToString()), PagerPageSizePosition)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		grid.SettingsPager.Position = CurrentPagerPosition
		grid.SettingsPager.ShowDisabledButtons = cbShowDisabledButtons.Checked
		grid.SettingsPager.ShowNumericButtons = cbShowNumericButtons.Checked
		grid.SettingsPager.ShowSeparators = cbShowSeparators.Checked
		grid.SettingsPager.Summary.Visible = cbShowSummary.Checked
		grid.SettingsPager.PageSizeItemSettings.Visible = cbShowPageSizeItem.Checked
		grid.SettingsPager.PageSizeItemSettings.Position = CurrentPageSizePosition
	End Sub
End Class
