Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Data.PivotGrid
Imports DevExpress.Web
Imports DevExpress.Web.ASPxPivotGrid

Partial Public Class SingleTotalsDemo
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) AndAlso (Not IsCallback) Then
			SetYearFilter()
			SetSummaryDropDownList()
			SetOptionsViewCheckBoxes()
			SetDataFieldsProperties()
		Else
			SetOptionsViewProperties()
		End If
	End Sub
	Private Sub SetYearFilter()
		pivotGrid.Fields("Year").FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included
		pivotGrid.Fields("Year").FilterValues.Add(1997)
	End Sub
	Private Sub SetOptionsViewCheckBoxes()
		cbShowColumnGrandTotals.Checked = pivotGrid.OptionsView.ShowColumnGrandTotals
		cbShowColumnTotals.Checked = pivotGrid.OptionsView.ShowColumnTotals
		cbShowRowGrandTotals.Checked = pivotGrid.OptionsView.ShowRowGrandTotals
		cbShowRowTotals.Checked = pivotGrid.OptionsView.ShowRowTotals
		cbShowGrandTotalsForSingleValues.Checked = pivotGrid.OptionsView.ShowGrandTotalsForSingleValues
		cbShowTotalsForSingleValues.Checked = pivotGrid.OptionsView.ShowTotalsForSingleValues
	End Sub
	Private Sub SetSummaryDropDownList()
		For Each type As PivotSummaryType In System.Enum.GetValues(GetType(PivotSummaryType))
			ddlSummaryType.Items.Add(New ListEditItem(type.ToString()))
		Next type
	End Sub
	Private Sub SetOptionsViewProperties()
		pivotGrid.OptionsView.ShowColumnGrandTotals = cbShowColumnGrandTotals.Checked
		pivotGrid.OptionsView.ShowColumnTotals = cbShowColumnTotals.Checked
		pivotGrid.OptionsView.ShowRowGrandTotals = cbShowRowGrandTotals.Checked
		pivotGrid.OptionsView.ShowRowTotals = cbShowRowTotals.Checked
		pivotGrid.OptionsView.ShowGrandTotalsForSingleValues = cbShowGrandTotalsForSingleValues.Checked
		pivotGrid.OptionsView.ShowTotalsForSingleValues = cbShowTotalsForSingleValues.Checked
	End Sub
	Private Sub SetDataFieldsProperties()
		For Each field As PivotGridField In pivotGrid.Fields
			If field.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea Then
				field.HeaderStyle.Font.Bold = False
				field.HeaderStyle.HoverStyle.Font.Bold = False
				field.Caption = String.Format("{0}({1})", field.FieldName, ddlSummaryType.Items(CInt(Fix(field.SummaryType))))
			End If
		Next field
		If SelectedDataField IsNot Nothing Then
			SelectedDataField.HeaderStyle.Font.Bold = True
			SelectedDataField.HeaderStyle.HoverStyle.Font.Bold = True
			If SelectedDataField.SummaryType <> CType(ddlSummaryType.SelectedIndex, PivotSummaryType) Then
				ddlSummaryType.SelectedIndex = CInt(Fix(SelectedDataField.SummaryType))
			End If
		End If
	End Sub
	Private ReadOnly Property SelectedDataField() As PivotGridField
		Get
			Return pivotGrid.Fields(ddlField.SelectedItem.Text.Replace(" ", String.Empty))
		End Get
	End Property
	Protected Sub ddlField_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		SetDataFieldsProperties()
	End Sub
	Protected Sub ddlSummaryType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		If SelectedDataField IsNot Nothing Then
			SelectedDataField.SummaryType = CType(ddlSummaryType.SelectedIndex, PivotSummaryType)
		End If
		SetDataFieldsProperties()
	End Sub
End Class
