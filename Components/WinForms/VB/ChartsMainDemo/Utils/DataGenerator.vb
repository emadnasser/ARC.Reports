Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System

Namespace DevExpress.XtraCharts.Demos

	Friend Class DataGenerator
		Private Const RndMax As Integer = 20
		Private Const RndMin As Integer = 10
		Private Const RndFinancialMax As Integer = 100

		Private rnd As Random
		Private [integer] As Integer = 0
		Private financialClose As Double
		Private value As Double
		Private value2 As Double = Double.NaN
		Private multiplier As Integer
		Private rndSeek As Integer

		Public Sub New(ByVal rndSeek As Integer, ByVal startValue As Double)
			Me.rndSeek = rndSeek
			Me.value = startValue
			If rndSeek Mod 2 = 0 Then
				multiplier = 1
			Else
				multiplier = -1
			End If
			rnd = New Random(rndSeek)
			financialClose = rnd.Next(RndMax)
		End Sub
		Public Sub New(ByVal rndSeek As Integer)
			Me.New(rndSeek, 0)
		End Sub
		Public Sub New()
			Me.New(0, 0)
		End Sub

		Private Function GenerateDataPoint(ByVal seriesType As SeriesDataType) As DataPoint
			Dim dataPoint As DataPoint
			Select Case seriesType
				Case SeriesDataType.Financial
					dataPoint = GenerateFinancialDataPoint()
				Case SeriesDataType.ArgumentValue
					dataPoint = GenerateArgValueDataPoint()
				Case SeriesDataType.Bubble
					dataPoint = GenerateBubblePoint()
				Case SeriesDataType.Range
					dataPoint = GenerateRangeDataPoint()
				Case SeriesDataType.Funnel
					dataPoint = GenerateFunnelPoint()
				Case Else
					Throw New NotImplementedException("Data generator for " & seriesType & "has not implemented")
			End Select
			Return dataPoint
		End Function

		Private Function GenerateFunnelPoint() As DataPoint
			Dim dataPoint As DataPoint = GenerateDataPointWithArgument()
			value -= rnd.Next(1, 7)
			dataPoint.Value = value
			Return dataPoint
		End Function
		Private Function GenerateBubblePoint() As DataPoint
			Dim dataPoint As DataPoint = GenerateDataPointWithArgument()
			dataPoint.Value = rnd.Next(RndMax)
			dataPoint.Weight = rnd.Next(RndMax)
			Return dataPoint
		End Function
		Private Function GenerateArgValueDataPoint() As DataPoint
			Dim dataPoint As DataPoint = GenerateDataPointWithArgument()
			value += multiplier * Math.Round(5 * rnd.NextDouble() - 2.2)
			dataPoint.Value = value
			Return dataPoint
		End Function
		Private Function GenerateFinancialDataPoint() As DataPoint
			Dim dataPoint As DataPoint = GenerateDataPointWithArgument()
			value += rnd.Next(-6, 5)
			dataPoint.Low = value
			dataPoint.Open = value + rnd.Next(1, 5)
			Dim close As Double = value + rnd.Next(1, 5)
			If dataPoint.Open = close Then
				close += 1.5
			End If
			dataPoint.Close = close
			dataPoint.High = Math.Max(dataPoint.Close, dataPoint.Open) + rnd.Next(1, 4)
			Return dataPoint
		End Function
		Private Function GenerateRangeDataPoint() As DataPoint
			If Double.IsNaN(value2) Then
				value2 = value + 20
			End If
			Dim dataPoint As DataPoint = GenerateDataPointWithArgument()
			value += rnd.Next(-3, 3)
			value2 += rnd.Next(-9, 3)
			dataPoint.Value = value
			dataPoint.Value2 = value2
			Return dataPoint
		End Function
		Private Function GenerateDataPointWithArgument() As DataPoint
			[integer] += 1
			Dim point = New DataPoint()
			point.Argument = [integer]
			Return point
		End Function

		Public Function GenerateData(ByVal seriesType As SeriesDataType, ByVal pointCount As Integer) As List(Of DataPoint)
			Dim data = New List(Of DataPoint)()
			For i As Integer = 0 To pointCount - 1
				Dim point As DataPoint = GenerateDataPoint(seriesType)
				data.Add(point)
			Next i
			Return data
		End Function
		Public Function GeneratePolarData(ByVal seriesType As SeriesDataType, ByVal pointCount As Integer) As List(Of DataPoint)
			Dim [step] As Double = 360.0 / pointCount
			Dim argument As Double = -[step]
			Dim data = New List(Of DataPoint)()
			For i As Integer = 0 To pointCount - 1
				Dim point As New DataPoint()
				argument += [step] + rnd.Next(-10, 10)
				point.Argument = argument
				point.Value = rnd.Next(RndMin, RndMax)
				If seriesType = SeriesDataType.Range Then
					point.Value2 = rnd.Next(RndMin + 10, RndMax + 7)
				End If
				data.Add(point)
			Next i
			Return data
		End Function
		Public Function GenerateXyScatterData() As List(Of DataPoint)
			Dim data = New List(Of DataPoint)()
			For i As Integer = 0 To 719 Step 10
				Dim t As Double = CDbl(i) / 180 * Math.PI
				Dim x As Double = t * Math.Cos(t)
				Dim y As Double = t * Math.Sin(t)
				data.Add(New DataPoint() With {.Argument = x, .Value = y})
			Next i
			Return data
		End Function
	End Class



	Public Class DataPoint
		Public Property Argument() As Double
		Public Property Value() As Double
		Public Property Value2() As Double
		Public Property Weight() As Double
		Public Property Low() As Double
		Public Property High() As Double
		Public Property Open() As Double
		Public Property Close() As Double
	End Class


	Public Enum SeriesDataType
		ArgumentValue
		Financial
		Bubble
		Range
		Funnel
	End Enum
End Namespace
