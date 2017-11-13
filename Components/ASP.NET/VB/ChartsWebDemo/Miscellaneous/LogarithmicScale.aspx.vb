Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts
Imports DevExpress.Utils
Imports DevExpress.XtraCharts.Web

Partial Public Class LogarithmicScale
	Inherits ChartBasePage
	Private ReadOnly Property AxisY() As AxisY
		Get
			Return (CType(WebChartControl1.Diagram, XYDiagram)).AxisY
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = WebChartControl1.Series(0).LabelsVisibility = DefaultBoolean.True
			cbLogarithmic.Checked = AxisY.Logarithmic
			cbLogarithmicBase.Enabled = AxisY.Logarithmic
			ComboBoxHelper.PrepareLogarithmicBaseComboBox(cbLogarithmicBase, AxisY.LogarithmicBase)
		End If
		lblLogarithmicBase.ClientEnabled = cbLogarithmic.Checked
		cbLogarithmicBase.ClientEnabled = cbLogarithmic.Checked
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		AxisY.Logarithmic = cbLogarithmic.Checked
		AxisY.LogarithmicBase = Double.Parse(cbLogarithmicBase.SelectedItem.Text)
		For Each series As Series In WebChartControl1.Series
			series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		Next series
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
End Class
