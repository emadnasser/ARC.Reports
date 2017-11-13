Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class RadarDemoBase
		Inherits RadarPolarDemoBase
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub comboBoxEditTextDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditTextDirection.SelectedIndexChanged
			Dim textDirection As RadarAxisXLabelTextDirection = CType(comboBoxEditTextDirection.EditValue, RadarAxisXLabelTextDirection)
			Dim diagram As RadarDiagram = TryCast(ChartControl.Diagram, RadarDiagram)
			If diagram IsNot Nothing Then
				diagram.AxisX.Label.TextDirection = textDirection
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			Dim directions As Array = System.Enum.GetValues(GetType(RadarAxisXLabelTextDirection))
			For Each direction As RadarAxisXLabelTextDirection In directions
				comboBoxEditTextDirection.Properties.Items.Add(direction)
			Next direction
			Dim diagram As RadarDiagram = TryCast(ChartControl.Diagram, RadarDiagram)
			If diagram IsNot Nothing Then
				comboBoxEditTextDirection.EditValue = diagram.AxisX.Label.TextDirection
			End If
		End Sub
	End Class
End Namespace
