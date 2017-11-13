Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class Summarization
	Inherits ChartBasePage
	Private Shared Function CalcStdDev(ByVal series As Series, ByVal argument As Object, ByVal functionArguments() As String, ByVal values() As DataSourceValues, ByVal colors() As Object) As SeriesPoint()
		Dim amount(values.Length - 1) As Double
		Dim sum As Double = 0.0
		For i As Integer = 0 To values.Length - 1
			amount(i) = Convert.ToDouble(values(i)(functionArguments(0)))
			sum += amount(i)
		Next i
		Dim averageAmount As Double = sum / values.Length
		Dim standardDeviationSquareSum As Double = 0.0
		For i As Integer = 0 To values.Length - 1
			Dim deviation As Double = amount(i) - averageAmount
			standardDeviationSquareSum += deviation * deviation
		Next i
		Return New SeriesPoint() { New SeriesPoint(argument, Math.Sqrt(standardDeviationSquareSum / values.Length)) }
	End Function

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		RegisterSummaryFunction()
		If (Not IsPostBack) Then
			cbShowLabels.Checked = WebChartControl1.Series(0).LabelsVisibility = DefaultBoolean.True
			ComboBoxHelper.PrepareSummaryFunctionsComboBox(cbSummaryFunction)
			cbSummaryFunction.SelectedIndex = 0
			PerformSummaryFunctionAction()
		End If
	End Sub
	Private Sub RegisterSummaryFunction()
		Dim argumentDescription As New SummaryFunctionArgumentDescription("Argument", ScaleType.Numerical)
		WebChartControl1.RegisterSummaryFunction("STDDEV", "STDDEV", 1, New SummaryFunctionArgumentDescription() { argumentDescription }, AddressOf CalcStdDev)
	End Sub
	Private Sub PerformSummaryFunctionAction()
		Dim functionName As String = cbSummaryFunction.SelectedItem.Text
		Dim suffixIndex As Integer = functionName.IndexOf(" (Custom)")
		If suffixIndex >= 0 Then
			functionName = functionName.Substring(0, suffixIndex)
		End If
		Select Case functionName
			Case "SUM"
				WebChartControl1.Titles(0).Text = "Sales Volume"
				CType(WebChartControl1.Diagram, XYDiagram).AxisY.Title.Text = "Volume (USD)"
			Case "MIN"
				WebChartControl1.Titles(0).Text = "Minimal Order Amount"
				CType(WebChartControl1.Diagram, XYDiagram).AxisY.Title.Text = "Amount (USD)"
			Case "MAX"
				WebChartControl1.Titles(0).Text = "Maximal Order Amount"
				CType(WebChartControl1.Diagram, XYDiagram).AxisY.Title.Text = "Amount (USD)"
			Case "AVERAGE"
				WebChartControl1.Titles(0).Text = "Average Order Amount"
				CType(WebChartControl1.Diagram, XYDiagram).AxisY.Title.Text = "Amount (USD)"
			Case "COUNT"
				WebChartControl1.Titles(0).Text = "Overall Orders Count"
				CType(WebChartControl1.Diagram, XYDiagram).AxisY.Title.Text = "Count"
			Case "STDDEV"
				WebChartControl1.Titles(0).Text = "Standard Deviation from Average Order Amout"
				CType(WebChartControl1.Diagram, XYDiagram).AxisY.Title.Text = "Deviation (USD)"
		End Select
		If functionName = "COUNT" Then
			WebChartControl1.Series(0).SummaryFunction = functionName & "()"
		Else
			WebChartControl1.Series(0).SummaryFunction = functionName & "([Sum])"
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		For Each series As Series In WebChartControl1.Series
			series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		Next series
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "SummaryFunction" Then
			PerformSummaryFunctionAction()
		ElseIf e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		End If
	End Sub
	Protected Sub WebChartControl1_CallbackStateLoad(ByVal sender As Object, ByVal e As CallbackStateLoadEventArgs)
		RegisterSummaryFunction()
	End Sub
End Class
