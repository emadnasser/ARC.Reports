Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports DevExpress.XtraCharts
Imports DevExpress.Utils
Imports DevExpress.XtraCharts.Web

Partial Public Class StockSeries
	Inherits ChartBasePage
	Private ReadOnly Property AxisX() As Axis
		Get
			Return (CType(WebChartControl1.Diagram, XYDiagram)).AxisX
		End Get
	End Property
	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property View() As StockSeriesView
		Get
			Return CType(Series.View, StockSeriesView)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbWorkdaysOnly.Checked = AxisX.DateTimeScaleOptions.WorkdaysOnly
			cbShowLabels.Checked = Series.LabelsVisibility = DefaultBoolean.True
			ComboBoxHelper.PrepareComboBox(cbStockType, View.ShowOpenClose)
			ComboBoxHelper.PrepareComboBox(cbReductionLevel, View.ReductionOptions.Level)
			ComboBoxHelper.PrepareComboBox(cbLabelLevel, New String() { "Low", "High", "Open", "Close" }, "Close")
		End If
		lblLabelLevel.ClientEnabled = cbShowLabels.Checked
		cbLabelLevel.ClientEnabled = cbShowLabels.Checked
	End Sub
	Private Sub PerformStockTypeAction()
		View.ShowOpenClose = CType(ComboBoxHelper.GetSelectedItem(cbStockType, GetType(StockType)), StockType)
	End Sub
	Private Sub PerformReductionLevelAction()
		View.ReductionOptions.Level = CType(ComboBoxHelper.GetSelectedItem(cbReductionLevel, GetType(StockLevel)), StockLevel)
	End Sub
	Private Sub PerformLabelLevelAction()
		Dim pattern As String = "{CV:F2}"
		Select Case cbLabelLevel.SelectedItem.Text
			Case "Low"
				pattern = "{LV:F2}"
			Case "High"
				pattern = "{HV:F2}"
			Case "Open"
				pattern = "{OV:F2}"
			Case Else
				pattern = "{CV:F2}"
		End Select
		Series.Label.TextPattern = pattern
	End Sub
	Private Sub PerformShowLabelsAction()
		Series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Private Sub PerformWorkdaysOnlyAction()
		AxisX.DateTimeScaleOptions.WorkdaysOnly = cbWorkdaysOnly.Checked
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "StockType" Then
			PerformStockTypeAction()
		ElseIf e.Parameter = "ReductionLevel" Then
			PerformReductionLevelAction()
		ElseIf e.Parameter = "LabelLevel" Then
			PerformLabelLevelAction()
		ElseIf e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "WorkdaysOnly" Then
			PerformWorkdaysOnlyAction()
		End If
	End Sub
End Class
