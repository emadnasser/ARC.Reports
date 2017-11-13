Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos
	Partial Public Class ChartDemoBase3D
		Inherits ChartDemoBase
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overridable Sub UpdateRotationAngles(ByVal diagram As Diagram3D)
		End Sub
		Protected Function IsFacetEnabled(ByVal barModel As Bar3DModel) As Boolean
			Return (barModel.Equals(Bar3DModel.Box) OrElse barModel.Equals(Bar3DModel.Cylinder))
		End Function
		Private Sub btnDefaultAngles_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDefaultAngles.Click
			Dim diagram As Diagram3D = TryCast(ChartControl.Diagram, Diagram3D)
			If diagram Is Nothing Then
				Return
			End If
			diagram.RotationType = RotationType.UseAngles
			UpdateRotationAngles(diagram)
			diagram.RotationType = RotationType.UseMouseAdvanced
		End Sub
	End Class
End Namespace

