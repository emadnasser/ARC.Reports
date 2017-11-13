Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web
Imports System.Collections.Generic
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Web.UI

Partial Public Class Multiselection
	Inherits ChartBasePage
	Private Const YearDataMember As String = "Year"
	Private Const RegionDataMember As String = "Region"

	Private colorIndices As Dictionary(Of String, Integer)
	Private paletteIndices As New List(Of Integer)()

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = WebChartControlBars.SeriesTemplate.LabelsVisibility = DefaultBoolean.True
			WebChartControlBars.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
			ComboBoxHelper.PrepareComboBox(cbSelectionMode, System.Enum.GetNames(GetType(ElementSelectionMode)), ElementSelectionMode.Multiple.ToString())
		Else
			WebChartControlBars.DataBind()
			WebChartControlPie.SelectionMode = CType(System.Enum.Parse(GetType(ElementSelectionMode), cbSelectionMode.SelectedItem.ToString()), ElementSelectionMode)
			WebChartControlBars.SeriesTemplate.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
			WebChartControlBars.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
			WebChartControlPie.Series(0).LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
			WebChartControlPie.ToolTipEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
		End If
	End Sub
	Private Sub InitColorIndices()
		colorIndices = New Dictionary(Of String, Integer)()
		For i As Integer = 0 To WebChartControlPie.Series(0).Points.Count - 1
			colorIndices.Add(WebChartControlPie.Series(0).Points(i).Argument, i)
		Next i
	End Sub

	Private Sub ChangeSeriesVisibility()
		InitColorIndices()
		paletteIndices = New List(Of Integer)()
		Dim filters As New List(Of DataFilter)()
		WebChartControlBars.SeriesTemplate.DataFilters.Clear()
		WebChartControlBars.SeriesTemplate.DataFilters.ConjunctionMode = ConjunctionTypes.Or
		For Each dataList As List(Of Object) In WebChartControlPie.SelectedItems
			If dataList.Count > 0 Then
				Dim dataRow As DataRowView = TryCast(dataList(0), DataRowView)
				Dim region As String = CStr(dataRow.Row("REGION"))
				Dim selectedSeriesFilter As New DataFilter("REGION", GetType(String).FullName, DataFilterCondition.Equal, region)
				filters.Add(selectedSeriesFilter)
				paletteIndices.Add(colorIndices(region))
			End If
		Next dataList
		WebChartControlBars.SeriesTemplate.DataFilters.AddRange(filters.ToArray())
	End Sub
	Private Sub UpdateSeriesColors(ByVal paletteIndices As List(Of Integer))
		Dim paletteEntries() As PaletteEntry = WebChartControlPie.GetPaletteEntries(WebChartControlPie.Series(0).Points.Count)
		For i As Integer = 0 To paletteIndices.Count - 1
			WebChartControlBars.Series(i).View.Color = paletteEntries(paletteIndices(i)).Color
			CType(WebChartControlBars.Series(i).View, BarSeriesView).FillStyle.FillMode = FillMode.Solid
		Next i
	End Sub

	Protected Sub WebChartControlPie_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs)
		If Not(TypeOf e.Object Is Series) Then
			e.Cancel = True
			WebChartControlPie.SelectedItems.Clear()
		End If
	End Sub
	Protected Sub WebChartControlPie_SelectedItemsChanged(ByVal sender As Object, ByVal e As SelectedItemsChangedEventArgs)
		ChangeSeriesVisibility()
	End Sub
	Protected Sub WebChartControlBars_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
		UpdateSeriesColors(paletteIndices)
	End Sub
End Class
