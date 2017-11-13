Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.DataBinding
	Partial Public Class SummarizationDemo
		Inherits ChartDemoBase2D
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

		Private chart As ChartControl

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries
			Dim argumentDescription As New SummaryFunctionArgumentDescription("Argument", ScaleType.Numerical)
			chart.RegisterSummaryFunction("STDDEV", "STDDEV", 1, New SummaryFunctionArgumentDescription() { argumentDescription }, AddressOf CalcStdDev)
			chart.DataSource = dS41.Categories
			Dim path As String = Utils.GetRelativePath("nwind.mdb")
			If path.Length > 0 Then
				Utils.SetConnectionString(oleDbConnection1, path)
			Else
				XtraMessageBox.Show("The ""nwind.mdb"" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
			Try
				oleDbDataAdapter1.Fill(dS41)
			Catch e As OleDbException
				XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End Try
			chart.DataAdapter = oleDbDataAdapter1
			comboBoxFunction.SelectedIndex = 0
		End Sub

		Private Sub SetTitleText(ByVal text As String)
			If chart.Titles.Count > 0 Then
				chart.Titles(0).Text = text
			End If
		End Sub
		Private Sub SetAxisYTitle(ByVal text As String)
			Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
			If diagram IsNot Nothing Then
				diagram.AxisY.Title.Text = text
			End If
		End Sub
		Private Sub comboBoxMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxFunction.SelectedIndexChanged
			Dim functionName As String = CStr(comboBoxFunction.EditValue)
			Dim suffixIndex As Integer = functionName.IndexOf(" (Custom)")
			If suffixIndex >= 0 Then
				functionName = functionName.Substring(0, suffixIndex)
			End If
			Select Case functionName
				Case "SUM"
					SetTitleText("Sales Volume")
					SetAxisYTitle("Volume (USD)")
				Case "MIN"
					SetTitleText("Minimal Order Amount")
					SetAxisYTitle("Amount (USD)")
				Case "MAX"
					SetTitleText("Maximal Order Amount")
					SetAxisYTitle("Amount (USD)")
				Case "AVERAGE"
					SetTitleText("Average Order Amount")
					SetAxisYTitle("Amount (USD)")
				Case "COUNT"
					SetTitleText("Overall Orders Count")
					SetAxisYTitle("Count")
				Case "STDDEV"
					SetTitleText("Standard Deviation from Average Order Amout")
					SetAxisYTitle("Deviation (USD)")
			End Select
			If chart.Series.Count > 0 Then
				If functionName = "COUNT" Then
					chart.Series(0).SummaryFunction = functionName & "()"
				Else
					chart.Series(0).SummaryFunction = functionName & "([Sum])"
				End If
			End If
			ChartControl.Animate()
		End Sub
	End Class
End Namespace
