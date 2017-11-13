Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class Shaping_Paging
	Inherits Page
	Private ReadOnly Property CurrentPagerPosition() As PagerPosition
		Get
			Return CType(System.Enum.Parse(GetType(PagerPosition), cmbPosition.SelectedItem.Value.ToString()), PagerPosition)
		End Get
	End Property
	Private ReadOnly Property CurrentPageSizePosition() As PagerPageSizePosition
		Get
			Return CType(System.Enum.Parse(GetType(PagerPageSizePosition), cmbPageSizeItemPosition.SelectedItem.Value.ToString()), PagerPageSizePosition)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		treeList.SettingsPager.Position = CurrentPagerPosition
		treeList.SettingsPager.ShowDisabledButtons = cbShowDisabledButtons.Checked
		treeList.SettingsPager.ShowNumericButtons = cbShowNumericButtons.Checked
		treeList.SettingsPager.ShowSeparators = cbShowSeparators.Checked
		treeList.SettingsPager.Summary.Visible = cbShowSummary.Checked
		treeList.SettingsPager.PageSizeItemSettings.Visible = cbShowPageSizeItem.Checked
		treeList.SettingsPager.PageSizeItemSettings.Position = CurrentPageSizePosition
	End Sub
End Class
