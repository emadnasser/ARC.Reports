Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.BarViews
	Partial Public Class FullStackedBarSideBySide3dDemo
		Inherits ChartDemoBase3D
		Private Const DefaultPerspective As String = "Default"

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Dim perspectiveArray() As String = { DefaultPerspective, "0", "30", "45", "60", "90", "120", "135", "150" }
			comboBoxEditPerspective.Properties.Items.AddRange(perspectiveArray)
			comboBoxEditPerspective.Text = DefaultPerspective
			radioGroup.SelectedIndex = 0
			checkEditValueAsPercent.Checked = True
		End Sub
		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			checkEditValueAsPercent.Enabled = ShowLabels
		End Sub
		Private Sub radioGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup.SelectedIndexChanged
			ChartControl.RefreshData()
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
		Private Sub checkEditValueAsPercent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditValueAsPercent.CheckedChanged
			Dim labelTextPattern As String = If(Me.checkEditValueAsPercent.Checked, "{VP:P0}", "{V:0,,.00}")
			For Each series As Series In Me.chart.Series
				Dim view As FullStackedBar3DSeriesView = TryCast(series.View, FullStackedBar3DSeriesView)
				If view IsNot Nothing Then
					series.Label.TextPattern = labelTextPattern
				End If
			Next series
			ChartControl.SeriesTemplate.Label.TextPattern = labelTextPattern
		End Sub
		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.BoundDataChanged
			For Each series As Series In ChartControl.Series
				Dim view As ISupportStackedGroup = TryCast(series.View, ISupportStackedGroup)
				Dim genderAge As GenderAgeInfo = CType(series.Tag, GenderAgeInfo)
				If view IsNot Nothing Then
					view.StackedGroup = If(radioGroup.SelectedIndex = 0, genderAge.Gender, genderAge.Age)
				End If
			Next series
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = chart.SeriesTemplate.ActualLabelsVisibility
			ChartControl.DataSource = AgeStructure.GetDataByAgeAndGender()
		End Sub
	End Class
End Namespace

