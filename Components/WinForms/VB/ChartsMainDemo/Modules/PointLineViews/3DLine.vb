Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class Line3dDemo
		Inherits ChartDemoBase3D
		Private Const DefaultPerspective As String = "Default"

		Private chart As ChartControl
		Private WithEvents comboBoxEditPerspective As ComboBoxEdit

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub comboBoxEditPerspective_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditPerspective.SelectedIndexChanged
			If comboBoxEditPerspective.SelectedIndex = -1 Then
				Return
			End If
			Dim perspectiveText As String = comboBoxEditPerspective.Text
			Dim perspectiveAngle As Integer = If(perspectiveText = DefaultPerspective, 50, Int32.Parse(perspectiveText))
			Dim diagram As Diagram3D = TryCast(ChartControl.Diagram, Diagram3D)
			If diagram IsNot Nothing Then
				diagram.PerspectiveAngle = perspectiveAngle
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			Dim perspectiveArray() As String = { DefaultPerspective, "0", "30", "45", "60", "90", "120", "135", "150" }
			Me.comboBoxEditPerspective.Properties.Items.AddRange(perspectiveArray)
			Me.comboBoxEditPerspective.Text = DefaultPerspective
			ShowLabels = False
			InitDataSource()
		End Sub
		Protected Overridable Sub InitDataSource()
			For Each series As Series In ChartControl.Series
				series.DataSource = SourceOfEnergy.GetCoalProduction()
			Next series
		End Sub
	End Class
End Namespace
