Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.Annotations
	Partial Public Class AnnotationDemoBase
		Inherits ChartDemoBase2D
		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property
		Protected Overrides ReadOnly Property CrosshairEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.False
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			GeneratePoints()
		End Sub
		Private Sub GeneratePoints()
			Dim random As New Random()
			If chart.Series.Count > 0 Then
				chart.BeginInit()
				Dim series As Series = chart.Series(0)
				series.Points.Clear()
				Dim maxPoint As SeriesPoint = Nothing
				Dim minPoint As SeriesPoint = Nothing
				For i As Integer = 0 To 9
					Dim value As Double = Math.Round(random.NextDouble() * 8, 2) + 2
					Dim point As New SeriesPoint(i + 1, value)
					If maxPoint Is Nothing OrElse value > maxPoint.Values(0) Then
						maxPoint = point
					End If
					If minPoint Is Nothing OrElse value < minPoint.Values(0) Then
						minPoint = point
					End If
					series.Points.Add(point)
				Next i
				AddAnnotation(maxPoint, True)
				AddAnnotation(minPoint, False)
				UpdatePosition()
				UpdateAngle()
				UpdateConnector()
				UpdateShape()
				chart.EndInit()
			End If
		End Sub
		Private Sub UpdatePosition()
			For Each annotation As Annotation In chart.AnnotationRepository
				Dim position As RelativePosition = TryCast(annotation.ShapePosition, RelativePosition)
				Dim anchorPoint As SeriesPointAnchorPoint = TryCast(annotation.AnchorPoint, SeriesPointAnchorPoint)
				If position IsNot Nothing AndAlso anchorPoint IsNot Nothing Then
					position.ConnectorLength = 75
					If anchorPoint.SeriesPoint.NumericalArgument > 5 Then
						position.Angle = 125
					End If
				End If
			Next annotation
		End Sub
		Private Sub UpdateAngle()
			For Each annotation As Annotation In chart.AnnotationRepository
				annotation.Angle = tbcAngle.Value
				OnUpdateAngle(annotation)
			Next annotation
		End Sub
		Private Sub UpdateConnector()
			For Each annotation As Annotation In chart.AnnotationRepository
				annotation.ConnectorStyle = CType(cbeConnector.SelectedIndex, AnnotationConnectorStyle)
			Next annotation
		End Sub
		Private Sub UpdateShape()
			For Each annotation As Annotation In chart.AnnotationRepository
				annotation.ShapeKind = CType(cbeShape.SelectedIndex, ShapeKind)
			Next annotation
		End Sub
		Private Sub tbcAngle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbcAngle.EditValueChanged
			UpdateAngle()
		End Sub
		Private Sub cbeConnector_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeConnector.SelectedIndexChanged
			UpdateConnector()
		End Sub
		Private Sub cbeShape_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeShape.SelectedIndexChanged
			UpdateShape()
		End Sub
		Private Sub sbGeneratePoints_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbGeneratePoints.Click
			GeneratePoints()
		End Sub
		Protected Overridable Sub AddAnnotation(ByVal point As SeriesPoint, ByVal isMaximum As Boolean)
		End Sub
		Protected Overridable Sub OnUpdateAngle(ByVal annotation As Annotation)
		End Sub
	End Class
End Namespace
