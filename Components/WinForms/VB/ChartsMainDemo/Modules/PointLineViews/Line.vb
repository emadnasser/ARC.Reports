Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class LineDemo
		Inherits ChartDemoLineBase
		Private WithEvents chart As ChartControl

		Protected Overrides ReadOnly Property SeriesSelection() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chart_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chart.VisibleChanged
			If chart.Series.Count > 0 Then
				chart.SetObjectSelection(Me.chart.Series(0))
			End If
		End Sub
		Private ReadOnly Property IsLabelVisisble() As Boolean
			Get
				If seriesSelected IsNot Nothing AndAlso seriesSelected.Label IsNot Nothing AndAlso seriesSelected.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True Then
					Return True
				Else
					Return False
				End If
			End Get
		End Property

		Protected Overrides Sub checkEditShowLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If seriesSelected IsNot Nothing AndAlso seriesSelected.Label IsNot Nothing Then
				seriesSelected.LabelsVisibility = If(checkEditShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
			End If
			UpdateControls()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			Dim view As LineSeriesView = If(seriesSelected IsNot Nothing, TryCast(seriesSelected.View, LineSeriesView), Nothing)
			If view Is Nothing Then
				checkEditShowLabels.Enabled = False
				checkEditShowLabels.Checked = False
				Return
			End If
			checkEditShowLabels.Enabled = True
			checkEditShowLabels.Checked = IsLabelVisisble
		End Sub
	End Class
End Namespace
