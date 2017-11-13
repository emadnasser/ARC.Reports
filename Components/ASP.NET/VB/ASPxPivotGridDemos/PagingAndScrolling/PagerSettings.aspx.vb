Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class HorzScrollBar
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) AndAlso (Not IsCallback) Then
			InitializeOptionsControls()
		Else
			ApplyOptions()
		End If
	End Sub

	Private Sub ApplyOptions()
		pivotGrid.OptionsPager.ShowDisabledButtons = cbShowDisabledButtons.Checked
		pivotGrid.OptionsPager.ShowNumericButtons = cbShowNumericButtons.Checked
		pivotGrid.OptionsPager.PageSizeItemSettings.Visible = cbShowPageSizeItem.Checked
		pivotGrid.OptionsPager.Summary.Visible = cbShowSummary.Checked
		pivotGrid.OptionsPager.ShowSeparators = cbShowSeparators.Checked

		pivotGrid.OptionsPager.Position = CType(ddlPosition.SelectedIndex, PagerPosition)
		pivotGrid.OptionsPager.PagerAlign = CType(ddlPagerAlign.SelectedIndex, DevExpress.Web.ASPxPivotGrid.PagerAlign)
		pivotGrid.OptionsPager.PageSizeItemSettings.Position = CType(ddlPageSizeItemPosition.SelectedIndex, PagerPageSizePosition)
	End Sub

	Private Sub InitializeOptionsControls()
		cbShowDisabledButtons.Checked = pivotGrid.OptionsPager.ShowDisabledButtons
		cbShowNumericButtons.Checked = pivotGrid.OptionsPager.ShowNumericButtons
		cbShowPageSizeItem.Checked = pivotGrid.OptionsPager.PageSizeItemSettings.Visible
		cbShowSummary.Checked = pivotGrid.OptionsPager.Summary.Visible
		cbShowSeparators.Checked = pivotGrid.OptionsPager.ShowSeparators

		For Each type As PagerPosition In System.Enum.GetValues(GetType(PagerPosition))
			ddlPosition.Items.Add(New ListEditItem(type.ToString()))
		Next type
		ddlPosition.SelectedIndex = CInt(Fix(pivotGrid.OptionsPager.Position))

		For Each type As PagerAlign In System.Enum.GetValues(GetType(PagerAlign))
			ddlPagerAlign.Items.Add(New ListEditItem(type.ToString()))
		Next type
		ddlPagerAlign.SelectedIndex = CInt(Fix(pivotGrid.OptionsPager.PagerAlign))

		For Each type As PagerPageSizePosition In System.Enum.GetValues(GetType(PagerPageSizePosition))
			ddlPageSizeItemPosition.Items.Add(New ListEditItem(type.ToString()))
		Next type
		ddlPageSizeItemPosition.SelectedIndex = CInt(Fix(pivotGrid.OptionsPager.PageSizeItemSettings.Position))
	End Sub
	Protected Sub ddlPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		ApplyOptions()
	End Sub
	Protected Sub ddlPagerAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		ApplyOptions()
	End Sub
	Protected Sub ddlPageSizeItemPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		ApplyOptions()
	End Sub
End Class
