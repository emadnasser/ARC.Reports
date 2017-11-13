Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Namespace DevExpress.Demos.DayAndNightLineCalculator
	Public NotInheritable Class DayAndNightLineCalculator
		Private Sub New()
		End Sub
		Private Shared Function CalculateCoordinates(ByVal mjt As Double, ByVal t0 As Double, ByVal eclipticalCoords() As Double) As Double()
			Dim x As Double = eclipticalCoords(0)
			Dim y As Double = eclipticalCoords(1)
			Dim z As Double = eclipticalCoords(2)

			Dim ra As Double = Rad2Degree(Math.Atan2(y, x))
			Dim dec As Double = Rad2Degree(Math.Atan2(z, Math.Sqrt(x * x + y * y)))
			If ra < 0 Then
				ra += 360.0
			End If

			Dim a1 As Double = 24110.54841
			Dim a2 As Double = 8640184.812
			Dim a3 As Double = 0.093104
			Dim a4 As Double = 0.0000062
			Dim s0 As Double = a1 + a2 * t0 + a3 * t0 * t0 - a4 * t0 * t0 * t0
			Dim nSec As Double = (mjt - CInt(Fix(mjt))) * 86400.0
			Dim ut1 As Double = nSec * 366.2422 / 365.2422
			s0 = Degree2Rad(((s0 + ut1) / 3600.0 * 15.0) Mod 360.0)
			Dim x0 As Double = Math.Cos(s0) * x + Math.Sin(s0) * y
			Dim y0 As Double = -Math.Sin(s0) * x + Math.Cos(s0) * y
			Dim result(2) As Double
			result(0) = Rad2Degree(Math.Atan2(y0, x0))
			result(1) = Rad2Degree(Math.Atan2(z, Math.Sqrt(x0 * x0 + y0 * y0)))
			result(2) = z
			Return result
		End Function
		Private Shared Function CalcJulianDateTime(ByVal dt As DateTime, ByVal ut As Double) As Double
			Dim mon As Double = If(dt.Month > 2, dt.Month, dt.Month + 12)
			Dim yr As Double = If(dt.Month > 2, dt.Year, dt.Year - 1)
			Dim var As Double = 365.0 * yr - 679004.0
			Dim b As Double = CInt(Fix(yr / 400)) - CInt(Fix(yr / 100)) + CInt(Fix(yr / 4))
			Dim res As Double = var + b + CInt(Fix(306001.0 * (mon + 1) / 10000)) + dt.Day
			Return res + ut / 24.0
		End Function
		Private Shared Function CalculateSunEclipticalCoordinates(ByVal ut As Double, ByVal t0 As Double) As Double()
			Dim m As Double = (357.528 + 35999.05 * t0 + 0.04107 * ut) Mod 360.0
			Dim l As Double = 280.46 + 36000.772 * t0 + 0.04107 * ut
			l = (l + (1.915 - 0.0048 * t0) * Math.Sin(Degree2Rad(m)) + 0.02 * Math.Sin(2.0 * Degree2Rad(m))) Mod 360
			Dim axisTilt As Double = Degree2Rad(23.439281)
			Dim result(2) As Double
			result(0) = Math.Cos(Degree2Rad(l))
			result(1) = Math.Sin(Degree2Rad(l)) * Math.Cos(axisTilt)
			result(2) = Math.Sin(Degree2Rad(l)) * Math.Sin(axisTilt)
			Return result
		End Function
		Private Shared Function CalculateUniversalTime(ByVal dt As DateTime) As Double
			Return dt.Hour + CDbl(dt.Minute) / 60.0 + CDbl(dt.Second) / 3600.0
		End Function
		Private Shared Function Degree2Rad(ByVal value As Double) As Double
			Return value * Math.PI / 180.0
		End Function
		Private Shared Function Rad2Degree(ByVal value As Double) As Double
			Return value * 180.0 / Math.PI
		End Function
		Public Shared Function CalculateSunPosition(ByVal [date] As DateTime) As Double()
			Dim ut As Double = CalculateUniversalTime([date])
			Dim mjt As Double = CalcJulianDateTime([date], ut)

			Dim t0 As Double = (CInt(Fix(mjt)) - 51544.5) / 36525.0
			Dim eclipticalCoords() As Double = CalculateSunEclipticalCoordinates(ut, t0)
			Return CalculateCoordinates(mjt, t0, eclipticalCoords)
		End Function
		Public Shared Function GetDayAndNightLineLatitudes(ByVal centerLat As Double, ByVal centerLon As Double, ByVal [step] As Double) As IList(Of Double)
			Dim result As IList(Of Double) = New List(Of Double)()
			Dim ct As Double = -1.0 / Math.Tan(Degree2Rad(centerLat))
			For lon As Double = -180 To 180 Step [step]
				Dim t As Double = ct * Math.Cos(Degree2Rad(lon) - Degree2Rad(centerLon))
				Dim lat As Double = Rad2Degree(Math.Atan(t))
				result.Add(lat)
			Next lon
			Return result
		End Function
		Public Shared Function CalculateIsNorthNight(ByVal sunPosition() As Double) As Boolean
			Dim lat As Double = Math.PI / 2.0
			Dim lon As Double = -Math.PI
			Dim x As Double = Math.Cos(lon) * Math.Cos(lat)
			Dim y As Double = Math.Sin(lon) * Math.Cos(lat)
			Dim z As Double = Math.Sin(lat)
			Return x * sunPosition(0) + y * sunPosition(1) + z * sunPosition(2) < 0
		End Function
	End Class
End Namespace