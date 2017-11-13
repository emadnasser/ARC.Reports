Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class StepLine3dDemo
		Inherits ChartDemoBase3D
		Private Const DefaultPerspective As String = "Default"

		Private chartControl_Renamed As ChartControl
		Private WithEvents comboBoxEditPerspective As ComboBoxEdit

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chartControl_Renamed
			End Get
		End Property
		Protected ReadOnly Property Series() As Series
			Get
				Return If(ChartControl.Series.Count > 0, ChartControl.Series(0), Nothing)
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
		Private Sub checkEditInverted_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditInverted.CheckedChanged
			Dim line As StepLine3DSeriesView = TryCast(Series.View, StepLine3DSeriesView)
			If line IsNot Nothing Then
				line.InvertedStep = Me.checkEditInverted.Checked
				Return
			End If
			Dim area As StepArea3DSeriesView = TryCast(Series.View, StepArea3DSeriesView)
			If area IsNot Nothing Then
				area.InvertedStep = Me.checkEditInverted.Checked
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			Dim perspectiveArray() As String = { DefaultPerspective, "0", "30", "45", "60", "90", "120", "135", "150" }
			comboBoxEditPerspective.Properties.Items.AddRange(perspectiveArray)
			comboBoxEditPerspective.Text = DefaultPerspective
			Dim view As StepLine3DSeriesView = TryCast(Series.View, StepLine3DSeriesView)
			If view IsNot Nothing Then
				checkEditInverted.Checked = view.InvertedStep
			End If
			Series.DataSource = SourceOfEnergy.GetGasolinePrices()
			ShowLabels = False
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			Dim view As StepLine3DSeriesView = TryCast(Series.View, StepLine3DSeriesView)
			If view IsNot Nothing Then
				checkEditInverted.Checked = view.InvertedStep
			End If
		End Sub
	End Class
End Namespace
