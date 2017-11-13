Imports Microsoft.VisualBasic
#Region "Using"
Imports System
Imports System.Drawing
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web
Imports DevExpress.Web
#End Region

Partial Public Class ImageAnnotationDemo
	Inherits ChartBasePage
	Private Sub AddAnnotation(ByVal point As SeriesPoint, ByVal isMaximum As Boolean)
		Dim annotation As ImageAnnotation = point.Annotations.AddImageAnnotation()
		If isMaximum Then
			annotation.Name = "Maximum"
			annotation.Image.ImageUrl = "~/Content/Demo/AnnotationMaximum.png"
		Else
			annotation.Name = "Minimum"
			annotation.Image.ImageUrl = "~/Content/Demo/AnnotationMinimum.png"
		End If
		Dim position As RelativePosition = TryCast(annotation.ShapePosition, RelativePosition)
		Dim anchorPoint As SeriesPointAnchorPoint = TryCast(annotation.AnchorPoint, SeriesPointAnchorPoint)
		If position IsNot Nothing AndAlso anchorPoint IsNot Nothing Then
			position.ConnectorLength = 75
			If anchorPoint.SeriesPoint.NumericalArgument > 5 Then
				position.Angle = 125
			End If
		End If
	End Sub
	Private Sub GeneratePoints()
		Dim random As New Random()
		Dim series As Series = WebChartControl1.Series(0)
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
	End Sub
	Private Sub Update()
		WebChartControl1.Series(0).LabelsVisibility = If(chbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
		For Each annotation As ImageAnnotation In WebChartControl1.AnnotationRepository
			If cbAngle.SelectedItem IsNot Nothing Then
				annotation.Angle = Convert.ToInt32(cbAngle.SelectedItem.Value)
			End If
			annotation.ConnectorStyle = CType(cbConnector.SelectedIndex, AnnotationConnectorStyle)
			annotation.ShapeKind = CType(cbShape.SelectedIndex, ShapeKind)
		Next annotation
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			GeneratePoints()
			For i As Integer = 0 To 359 Step 45
				cbAngle.Items.Add(New ListEditItem(i.ToString(), i))
			Next i
			cbAngle.SelectedIndex = 0
		End If
		Update()
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "Points" Then
			GeneratePoints()
		End If
		Update()
	End Sub
End Class
