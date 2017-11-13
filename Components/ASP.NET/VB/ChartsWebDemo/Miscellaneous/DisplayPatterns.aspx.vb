Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class DisplayPatterns
	Inherits ChartBasePage
	Private Shared ReadOnly SeriesLabelPatternItems() As String = { "{V:## ##0.0}", "{A}", "{V}", "{A}: {V}", "{S}" }
	Private Shared ReadOnly LegendPatternItems() As String = { "{A}", "{V}", "{A}: {V}", "{S}" }
	Private Shared ReadOnly AxisXPatternItems() As String = { "{A}", "Country: {A}" }
	Private Shared ReadOnly AxisYPatternItems() As String = { "{V:#,0}", "{V}" }

	Private ReadOnly Property Label() As SeriesLabelBase
		Get
			Return WebChartControl1.Series(0).Label
		End Get
	End Property
	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property AxisX() As AxisBase
		Get
			Return (CType(WebChartControl1.Diagram, XYDiagram)).AxisX
		End Get
	End Property
	Private ReadOnly Property AxisY() As AxisBase
		Get
			Return (CType(WebChartControl1.Diagram, XYDiagram)).AxisY
		End Get
	End Property


	Private Sub InitControls()
		ComboBoxHelper.PrepareComboBox(cbSeriesLabels, SeriesLabelPatternItems)
		ComboBoxHelper.PrepareComboBox(cbLegend, LegendPatternItems)
		ComboBoxHelper.PrepareComboBox(cbAxisX, AxisXPatternItems)
		ComboBoxHelper.PrepareComboBox(cbAxisY, AxisYPatternItems)
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			Label.TextPattern = cbSeriesLabels.Text
			Series.LegendTextPattern = cbLegend.Text
			AxisX.Label.TextPattern = cbAxisX.Text
			AxisY.Label.TextPattern = cbAxisY.Text
		Else
			InitControls()
		End If
	End Sub
	Protected Sub callbackPanel_Callback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		Select Case e.Parameter
			Case "label"
				Label.TextPattern = cbSeriesLabels.Text
			Case "legend"
				Series.LegendTextPattern = cbLegend.Text
			Case "axisx"
				AxisX.Label.TextPattern = cbAxisX.Text
			Case "axisy"
				AxisY.Label.TextPattern = cbAxisY.Text
		End Select
	End Sub
	Public Overrides Function FindWebChartControl() As WebChartControl
		Return WebChartControl1
	End Function
End Class
