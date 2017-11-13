Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.BarViews
	Partial Public Class StackedBar3dDemo
		Inherits ChartDemoBase3D
		Private Const DefaultPerspective As String = "Default"
		Private Const DefaultBar3DModel As String = "Box"

		Private chart As ChartControl

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
			Dim diagram As Diagram3D = TryCast(chart.Diagram, Diagram3D)
			If diagram IsNot Nothing Then
				diagram.PerspectiveAngle = perspectiveAngle
			End If
		End Sub
		Private Sub comboBoxBar3DModel_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxBar3DModel.SelectedIndexChanged
			If comboBoxBar3DModel.SelectedIndex = -1 Then
				Return
			End If
			Dim bar3DModelIndex As Integer = comboBoxBar3DModel.SelectedIndex
			Dim barModel As Bar3DModel = CType(bar3DModelIndex, Bar3DModel)
			Dim seriesView As Bar3DSeriesView = TryCast(ChartControl.SeriesTemplate.View, Bar3DSeriesView)
			If seriesView IsNot Nothing Then
				seriesView.Model = barModel
			End If
			checkEditShowFacet.Enabled = IsFacetEnabled(barModel)
		End Sub
		Private Sub checkEditShowFacet_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditShowFacet.CheckedChanged
			Dim seriesView As Bar3DSeriesView = TryCast(ChartControl.SeriesTemplate.View, Bar3DSeriesView)
			If seriesView IsNot Nothing Then
				seriesView.ShowFacet = checkEditShowFacet.Checked
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			Dim perspectiveArray() As String = { DefaultPerspective, "0", "30", "45", "60", "90", "120", "135", "150" }
			comboBoxEditPerspective.Properties.Items.AddRange(perspectiveArray)
			comboBoxEditPerspective.Text = DefaultPerspective
			Dim bar3DModelArray() As String = { DefaultBar3DModel, "Cylinder", "Cone", "Pyramid" }
			comboBoxBar3DModel.Properties.Items.AddRange(bar3DModelArray)
			comboBoxBar3DModel.Text = DefaultBar3DModel
			checkEditShowFacet.Checked = True
			ShowLabels = True
			ChartControl.DataSource = AgeStructure.GetDataByFemaleAge()
		End Sub
	End Class
End Namespace