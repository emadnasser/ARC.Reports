Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class SplineDemo
		Inherits ChartDemoLineBase
		Private WithEvents chart As ChartControl

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property
		Protected Overrides ReadOnly Property SeriesSelection() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.BoundDataChanged
			If Me.chart.Series.Count > 0 Then
				chart.SetObjectSelection(Me.chart.Series(0))
			End If
			chart.Animate()
		End Sub
		Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxLineTension.SelectedIndexChanged
			If Me.seriesSelected IsNot Nothing Then
				Dim splineSeriesView As SplineSeriesView = TryCast(seriesSelected.View, SplineSeriesView)
				If splineSeriesView IsNot Nothing Then
					splineSeriesView.LineTensionPercent = Integer.Parse(CStr(Me.comboBoxLineTension.SelectedItem))
				End If
			End If
		End Sub

		Protected Overrides Sub checkEditShowLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If seriesSelected IsNot Nothing AndAlso seriesSelected.Label IsNot Nothing Then
				seriesSelected.LabelsVisibility = If(Me.checkEditShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
			End If
			UpdateControls()
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ChartControl.DataSource = PowerConsumption.GetData()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			Dim view As SplineSeriesView = If(seriesSelected IsNot Nothing, TryCast(seriesSelected.View, SplineSeriesView), Nothing)
			If view Is Nothing Then
				labelLineTension.Enabled = False
				comboBoxLineTension.Enabled = False
				checkEditShowLabels.Enabled = False
				comboBoxLineTension.SelectedItem = Nothing
				checkEditShowLabels.Checked = False
				Return
			End If
			labelLineTension.Enabled = True
			comboBoxLineTension.Enabled = True
			checkEditShowLabels.Enabled = True
			comboBoxLineTension.SelectedItem = view.LineTensionPercent.ToString()
			If seriesSelected.Label Is Nothing OrElse seriesSelected.LabelsVisibility <> DefaultBoolean.True Then
				checkEditShowLabels.Checked = False
			Else
				checkEditShowLabels.Checked = True
			End If
		End Sub
	End Class
End Namespace
