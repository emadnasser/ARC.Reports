Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos
	Friend Enum PolarDiagramFunctions
		Circles = 0
		Cardioid = 1
		Lemniscate = 2
	End Enum

	Friend NotInheritable Class PolarDiagramPointsGenerator
		Private Const DefaultPointsCount As Integer = 72

		Private Sub New()
		End Sub
		Private Shared Function GenerateSeriesPoint(ByVal m As Double, ByVal value As Double, ByVal pointsInSeries As Integer) As SeriesPoint
			Dim points(pointsInSeries - 1) As Double
			For i As Integer = 0 To pointsInSeries - 1
				Dim factor As Double = If((i = 0), m, 0)
				points(i) = [Function](factor, value)
			Next i
			Return New SeriesPoint(value, points)
		End Function
		Private Shared Function [Function](ByVal m As Double, ByVal angle As Double) As Double
			Dim cos As Double = Math.Cos(m * ToRadian(90.0 + angle))
			Return Math.Pow(Math.Abs(cos), m)
		End Function
		Private Shared Function ToRadian(ByVal angle As Double) As Double
			Return angle * Math.PI / 180.0
		End Function
		Private Shared Function GenerateFunctionPoints(ByVal m As Double, ByVal pointCount As Integer, ByVal pointsInSeries As Integer) As SeriesPoint()
			Dim [step] As Integer = 360 \ pointCount
			Dim points(pointCount - 1) As SeriesPoint
			For i As Integer = 0 To pointCount - 1
				points(i) = GenerateSeriesPoint(m, i * [step], pointsInSeries)
			Next i
			Return points
		End Function
		Private Shared Function GetLineFactor(ByVal functionType As PolarDiagramFunctions) As Double
			Select Case functionType
				Case PolarDiagramFunctions.Circles
					Return 1
				Case PolarDiagramFunctions.Cardioid
					Return 0.5
				Case Else
					Return 2
			End Select
		End Function
		Public Shared Function GenerateFunctionPoints(ByVal functionType As PolarDiagramFunctions, ByVal pointsInSeries As Integer) As SeriesPoint()
			Dim lineFactor As Double = GetLineFactor(functionType)
			Return GenerateFunctionPoints(lineFactor, DefaultPointsCount, pointsInSeries)
		End Function
	End Class
End Namespace
