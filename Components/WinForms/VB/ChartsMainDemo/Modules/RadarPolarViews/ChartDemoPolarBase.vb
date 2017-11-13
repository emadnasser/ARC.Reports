Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class PolarDemoBase
		Inherits RadarPolarDemoBase
		Private Const defaultPointsCount As Integer = 72
		Protected Overrides ReadOnly Property SeriesSelection() As Boolean
			Get
				Return False
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub comboBoxEditFunctionType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditFunctionType.SelectedIndexChanged
			If ChartControl.Series.Count > 0 AndAlso TypeOf ChartControl.Diagram Is PolarDiagram Then
				Dim points() As SeriesPoint = PolarDiagramPointsGenerator.GenerateFunctionPoints(CType(comboBoxEditFunctionType.SelectedIndex, PolarDiagramFunctions), 1)
				ChartControl.Series(0).Points.Clear()
				ChartControl.Series(0).Points.AddRange(points)
				ChartControl.Animate()
			End If
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			Me.seriesSelected = ChartControl.Series(0)
			For Each [function] As PolarDiagramFunctions In System.Enum.GetValues(GetType(PolarDiagramFunctions))
				comboBoxEditFunctionType.Properties.Items.Add([function].ToString())
			Next [function]
			comboBoxEditFunctionType.SelectedIndex = 2
		End Sub

	End Class
End Namespace
