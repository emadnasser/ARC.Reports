Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.DataBinding
	Partial Public Class UsingSeriesTemplatesDemo
		Inherits ChartDemoBase2D
		Private chart As ChartControl
		Private WithEvents comboBoxEditSeriesDataMember As ComboBoxEdit
		Private Const yearSeries As String = "Year"
		Private Const countrySeries As String = "Country"

		Protected Overrides ReadOnly Property SeriesSelection() As Boolean
			Get
				Return False
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub comboBoxEditSeriesDataMember_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditSeriesDataMember.SelectedIndexChanged
			If comboBoxEditSeriesDataMember.SelectedIndex = -1 Then
				Return
			End If
			chart.SeriesDataMember = comboBoxEditSeriesDataMember.Text
			Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
			If comboBoxEditSeriesDataMember.Text = yearSeries Then
				chart.SeriesTemplate.ArgumentDataMember = countrySeries
				diagram.AxisX.Title.Text = "Countries"
			Else
				chart.SeriesTemplate.ArgumentDataMember = yearSeries
				diagram.AxisX.Title.Text = "Years"
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = False
			comboBoxEditSeriesDataMember.Properties.Items.Add(yearSeries)
			comboBoxEditSeriesDataMember.Properties.Items.Add(countrySeries)
			comboBoxEditSeriesDataMember.SelectedIndex = 0
			ChartControl.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:F3}"
			ChartControl.DataSource = GDPofG7.GetData()
			Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
			diagram.AxisY.GridLines.MinorVisible = True
			diagram.AxisX.Title.Visibility = DefaultBoolean.True
		End Sub
	End Class
End Namespace
