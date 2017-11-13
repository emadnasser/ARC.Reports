﻿Namespace DevExpress.SalesDemo.Model
    Public Class SalesForecastMaker
        Public Shared Function GetForecast(ByVal currentSales As Decimal, ByVal elapsedPeriodPart As Decimal) As Decimal
            If elapsedPeriodPart = 0 Then
                Return currentSales
            Else
                Return currentSales / elapsedPeriodPart
            End If
        End Function
        Public Shared Function GetYtdForecast(ByVal currentSales As Decimal) As Decimal
            Dim ytdRange As DateTimeRange = DateTimeUtils.GetYtdRange()
            Dim wholeIntervalLength As Decimal = ytdRange.End.Ticks - ytdRange.Start.Ticks
            Dim elapsedTimeIntervalLength As Decimal = Date.Today.Ticks - ytdRange.Start.Ticks
            Dim elapsedPeriodPart As Decimal = elapsedTimeIntervalLength / wholeIntervalLength
            Return GetForecast(currentSales, elapsedPeriodPart)
        End Function
    End Class
End Namespace