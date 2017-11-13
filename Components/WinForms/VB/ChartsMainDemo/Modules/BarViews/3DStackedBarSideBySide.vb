Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.BarViews
	Partial Public Class StackedBarSideBySide3dDemo
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
		End Sub

		Private Sub GroupSeries(ByVal seriesIndex As Integer, ByVal group As String)
			If seriesIndex < chart.Series.Count Then
				Dim view As ISupportStackedGroup = TryCast(chart.Series(seriesIndex).View, ISupportStackedGroup)
				If view IsNot Nothing Then
					view.StackedGroup = group
				End If
			End If
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

