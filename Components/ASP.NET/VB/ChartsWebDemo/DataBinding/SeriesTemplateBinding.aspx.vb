Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class SeriesTemplateBinding
	Inherits ChartBasePage
	Private Const YearDataMember As String = "Year"
	Private Const RegionDataMember As String = "Country"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = WebChartControl1.SeriesTemplate.LabelsVisibility = DefaultBoolean.True
			WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
			ComboBoxHelper.PrepareComboBox(cbSeriesDataMember, New String() { YearDataMember, RegionDataMember }, WebChartControl1.SeriesDataMember)
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		WebChartControl1.SeriesTemplate.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Private Sub PerformSeriesDataMemberAction()
		Dim seriesDataMember As String
		Dim argumentDataMember As String
		If cbSeriesDataMember.SelectedItem.Text = YearDataMember Then
			seriesDataMember = YearDataMember
			argumentDataMember = RegionDataMember
			CType(WebChartControl1.Diagram, XYDiagram).AxisX.Label.Staggered = True
		Else
			seriesDataMember = RegionDataMember
			argumentDataMember = YearDataMember
			CType(WebChartControl1.Diagram, XYDiagram).AxisX.Label.Staggered = False
			CType(WebChartControl1.Diagram, XYDiagram).AxisX.NumericScaleOptions.AutoGrid = False
			CType(WebChartControl1.Diagram, XYDiagram).AxisX.NumericScaleOptions.GridSpacing = 1
		End If
		WebChartControl1.SeriesDataMember = seriesDataMember
		WebChartControl1.SeriesTemplate.ArgumentDataMember = argumentDataMember
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "SeriesDataMember" Then
			PerformSeriesDataMemberAction()
		End If
	End Sub
End Class
