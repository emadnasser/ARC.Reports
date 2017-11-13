Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class PolarAreaDemo
		Inherits PolarDemoBase
		Private chart As ChartControl

		Protected Overrides Property ShowMarkers() As Boolean
			Get
				Return If(Me.seriesSelected IsNot Nothing AndAlso TypeOf seriesSelected.View Is RadarAreaSeriesView, (CType(seriesSelected.View, RadarAreaSeriesView)).MarkerVisibility <> DefaultBoolean.False, MyBase.ShowMarkers)
			End Get
			Set(ByVal value As Boolean)
				If seriesSelected Is Nothing Then
					Return
				End If
				Dim view As RadarAreaSeriesView = TryCast(seriesSelected.View, RadarAreaSeriesView)
				If view IsNot Nothing Then
					view.MarkerVisibility = If(value, DefaultBoolean.True, DefaultBoolean.False)
				End If
			End Set
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub checkEditShowMarkers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditShowMarkers.CheckedChanged
			If seriesSelected IsNot Nothing Then
				Dim view As PolarAreaSeriesView = TryCast(seriesSelected.View, PolarAreaSeriesView)
				If view IsNot Nothing Then
					view.MarkerVisibility = If(checkEditShowMarkers.Checked, DefaultBoolean.True, DefaultBoolean.False)
				End If
			End If
			UpdateControls()
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			For Each series As Series In chart.Series
				series.ToolTipPointPattern = "{A}: {V:F2}"
			Next series

		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If seriesSelected Is Nothing Then
				checkEditShowMarkers.Checked = False
				checkEditShowMarkers.Enabled = False
			Else
				Dim view As PolarAreaSeriesView = TryCast(seriesSelected.View, PolarAreaSeriesView)
				If view IsNot Nothing Then
					checkEditShowMarkers.Enabled = True
					checkEditShowMarkers.Checked = view.MarkerVisibility <> DefaultBoolean.False
					EnableMarkerControls(checkEditShowMarkers.Checked)
				End If
			End If
		End Sub
	End Class
End Namespace
