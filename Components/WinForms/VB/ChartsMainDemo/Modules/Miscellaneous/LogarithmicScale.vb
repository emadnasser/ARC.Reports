Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class LogarithmicScaleDemo
		Inherits ChartDemoBase2D
		Private Property Logarithmic() As Boolean
			Get
				Dim axis As AxisBase = GetAxisY()
				Return If(axis IsNot Nothing, axis.Logarithmic, False)
			End Get
			Set(ByVal value As Boolean)
				Dim axis As AxisBase = GetAxisY()
				If axis IsNot Nothing Then
					axis.Logarithmic = value
				End If
			End Set
		End Property
		Private Property LogarithmicBase() As Double
			Get
				Dim axis As AxisBase = GetAxisY()
				Return If(axis IsNot Nothing, axis.LogarithmicBase, 10.0)
			End Get
			Set(ByVal value As Double)
				Dim axis As AxisBase = GetAxisY()
				If axis IsNot Nothing Then
					axis.LogarithmicBase = value
				End If
			End Set
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chLogarithmic_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chLogarithmic.CheckedChanged
			Logarithmic = chLogarithmic.Checked
			UpdateControls()
			ChartControl.Animate()
		End Sub
		Private Sub cbLogarithmicBase_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLogarithmicBase.SelectedIndexChanged
			If cbLogarithmicBase.SelectedIndex <> -1 Then
				LogarithmicBase = Double.Parse(cbLogarithmicBase.Text)
			End If
		End Sub
		Private Function GetAxisY() As AxisBase
			If TypeOf chart.Diagram Is XYDiagram Then
				Return (CType(chart.Diagram, XYDiagram)).AxisY
			End If
			If TypeOf chart.Diagram Is XYDiagram3D Then
				Return (CType(chart.Diagram, XYDiagram3D)).AxisY
			End If
			If TypeOf chart.Diagram Is RadarDiagram Then
				Return (CType(chart.Diagram, RadarDiagram)).AxisY
			End If
			Return Nothing
		End Function

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			chLogarithmic.Checked = Logarithmic
			cbLogarithmicBase.Properties.Items.AddRange(New String() { "2", "5", "10", "20", "50", "100" })
			cbLogarithmicBase.Text = LogarithmicBase.ToString()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			lblLogarithmicBase.Enabled = Logarithmic
			cbLogarithmicBase.Enabled = Logarithmic
		End Sub
	End Class
End Namespace
