Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraCharts

Partial Public Class ChartsIntegration_GeneralOptions
	Inherits Page
	Private Sub SetFilter(ByVal field As PivotGridField, ByVal selectNumber As Integer)
		Dim values() As Object = field.GetUniqueValues()
		Dim includedValues As New List(Of Object)(values.Length / selectNumber)
		For i As Integer = 0 To values.Length - 1
			If i Mod selectNumber = 0 Then
				includedValues.Add(values(i))
			End If
		Next i
		field.FilterValues.ValuesIncluded = includedValues.ToArray()
	End Sub
	Private Sub SetChartType(ByVal text As String)
		WebChart.SeriesTemplate.ChangeView(CType(System.Enum.Parse(GetType(ViewType), text), ViewType))
		If WebChart.SeriesTemplate.Label IsNot Nothing Then
			PointLabels.Enabled = True
			WebChart.SeriesTemplate.LabelsVisibility = If(PointLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
		Else
			PointLabels.Enabled = False
		End If
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim restrictedTypes() As ViewType = { ViewType.PolarArea, ViewType.PolarLine, ViewType.ScatterPolarLine, ViewType.SideBySideGantt, ViewType.SideBySideRangeBar, ViewType.RangeBar, ViewType.Gantt, ViewType.PolarPoint, ViewType.Stock, ViewType.CandleStick, ViewType.Bubble }
			For Each type As ViewType In System.Enum.GetValues(GetType(ViewType))
				If Array.IndexOf(Of ViewType)(restrictedTypes, type) >= 0 Then
					Continue For
				End If
				ChartType.Items.Add(type.ToString())
			Next type
			ChartType.SelectedItem = ChartType.Items.FindByText(ViewType.Line.ToString())
			SetChartType(ChartType.SelectedItem.Text)
			PointLabels.Checked = WebChart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			ASPxPivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = ShowColumnGrandTotals.Checked
			ASPxPivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = ShowRowGrandTotals.Checked
			ASPxPivotGrid.OptionsChartDataSource.ProvideDataByColumns = ChartDataVertical.Checked
		End If
	End Sub
	Protected Sub ASPxPivotGrid_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			SetFilter(fieldCategoryName, 4)
			fieldOrderYear.FilterValues.SetValues(New Object() { 1996 }, DevExpress.XtraPivotGrid.PivotFilterType.Included, False)
		End If
	End Sub
	Protected Sub PointLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		WebChart.SeriesTemplate.LabelsVisibility = If(PointLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
	End Sub
	Protected Sub ChartType_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		SetChartType(ChartType.SelectedItem.Text)
	End Sub
	Protected Sub ShowColumnGrandTotals_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = ShowColumnGrandTotals.Checked
	End Sub
	Protected Sub ShowRowGrandTotals_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = ShowRowGrandTotals.Checked
	End Sub
	Protected Sub ChartDataVertical_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPivotGrid.OptionsChartDataSource.ProvideDataByColumns = ChartDataVertical.Checked
	End Sub
End Class
