Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class Area3dDemoBase
		Inherits ChartDemoBase3D
		Private Const DefaultPerspective As String = "Default"

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub comboTransparencies_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboTransparencies.SelectedIndexChanged
			Dim transp As Byte = Convert.ToByte(comboTransparencies.Text)
			Dim view As Area3DSeriesView = TryCast(ChartControl.SeriesTemplate.View, Area3DSeriesView)
			If view IsNot Nothing Then
				view.Transparency = transp
			End If
		End Sub
		Private Sub comboBoxEditPerspective_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditPerspective.SelectedIndexChanged
			If Me.comboBoxEditPerspective.SelectedIndex = -1 Then
				Return
			End If
			Dim perspectiveText As String = Me.comboBoxEditPerspective.Text
			Dim perspectiveAngle As Integer = If(perspectiveText = DefaultPerspective, 50, Int32.Parse(perspectiveText))
			Dim diagram As Diagram3D = TryCast(ChartControl.Diagram, Diagram3D)
			If diagram IsNot Nothing Then
				diagram.PerspectiveAngle = perspectiveAngle
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			Me.comboTransparencies.Properties.Items.AddRange(New String() { "0", "45", "90", "135", "180", "225", "255" })
			Me.comboBoxEditPerspective.Properties.Items.AddRange(New String() { DefaultPerspective, "0", "30", "45", "60", "90", "120", "135", "150" })
			Me.comboBoxEditPerspective.Text = DefaultPerspective

			Dim view As Area3DSeriesView
			If ChartControl.Series.Count > 0 Then
				ShowLabels = ChartControl.Series(0).LabelsVisibility <> DevExpress.Utils.DefaultBoolean.False
				view = TryCast(ChartControl.Series(0).View, Area3DSeriesView)
			Else
				ShowLabels = ChartControl.SeriesTemplate.LabelsVisibility <> DevExpress.Utils.DefaultBoolean.False
				view = TryCast(ChartControl.SeriesTemplate.View, Area3DSeriesView)
			End If
			If view IsNot Nothing Then
				Me.comboTransparencies.Text = view.Transparency.ToString()
			End If
		End Sub
	End Class
End Namespace
