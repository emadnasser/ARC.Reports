Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class SeriesTitlesDemo
		Inherits ChartDemoBase2D

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles chart.CustomDrawSeriesPoint
			If chart.Series.Count > 0 AndAlso (Not chart.Series(0).Equals(e.Series)) Then
				e.LegendText = ""
			End If
		End Sub
		Private Sub comboBoxEditSeriesDataMember_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxViewType.SelectedIndexChanged
			Dim viewType As ViewType
			Select Case CStr(comboBoxViewType.SelectedItem)
				Case "Pie 3D"
					viewType = ViewType.Pie3D
				Case "Doughnut"
					viewType = ViewType.Doughnut
				Case "Doughnut 3D"
					viewType = ViewType.Doughnut3D
				Case Else
					viewType = ViewType.Pie
			End Select
			chart.SeriesTemplate.ChangeView(viewType)
			Dim diagram As Diagram3D = TryCast(chart.Diagram, Diagram3D)
			If diagram IsNot Nothing Then
				diagram.RuntimeRotation = True
				diagram.RuntimeScrolling = True
				diagram.RuntimeZooming = True
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ChartControl.DataSource = DevAV.GetSalesMixByRegion()
		End Sub
		Protected Overrides Sub checkEditShowLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.chart.SeriesTemplate.LabelsVisibility = If(ShowLabels, DefaultBoolean.True, DefaultBoolean.False)
		End Sub
	End Class
End Namespace
