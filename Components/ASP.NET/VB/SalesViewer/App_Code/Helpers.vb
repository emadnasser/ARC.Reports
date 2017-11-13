Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Web
Imports DataAccess
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Public NotInheritable Class DateTimeHelper

    Private Sub New()
    End Sub

    Public Shared Function GetIntervalStartDate(ByVal [date] As Date, ByVal interval As SelectionInterval) As Date
        Dim lastDay As Integer = If(interval = SelectionInterval.Day, [date].Day, 1)
        Return New Date([date].Year, [date].Month, lastDay, 0, 0, 0)
    End Function
    Public Shared Function GetIntervalEndDate(ByVal [date] As Date, ByVal interval As SelectionInterval) As Date
        Dim firstDay As Integer = If(interval = SelectionInterval.Day, [date].Day, DateTime.DaysInMonth([date].Year, [date].Month))
        Return (New Date([date].Year, [date].Month, firstDay, 23, 59, 59))
    End Function

    Public Shared Function GetDateString(ByVal [date] As Date, ByVal formatString As String) As String
        If [date].Date = Date.Now.Date Then
            Return "Today"
        End If
        If [date].Date = (Date.Now.AddDays(-1)).Date Then
            Return "Yesterday"
        End If
        Return [date].ToString(formatString)
    End Function
    Public Shared Function GetDateRangeString(ByVal startDate As Date, ByVal endDate As Date) As String
        If HasSameYearAndMonth(startDate, endDate) Then
            Return startDate.ToString("MMM yyyy").ToUpper()
        End If
        Return String.Format("{0:MMM yyyy} - {1:MMM yyyy}", startDate, endDate).ToUpper()
    End Function
    Public Shared Function HasSameYearAndMonth(ByVal dt1 As Date, ByVal dt2 As Date) As Boolean
        Return dt1.Year = dt2.Year AndAlso dt1.Month = dt2.Month
    End Function
End Class
Public NotInheritable Class ScaleHelper

    Private Sub New()
    End Sub

    Public Shared Function GetAbbreviationMask(ByVal text As String, ByVal type As AbbreviationType) As String
        Dim value As Double = Nothing
        If Double.TryParse(text, value) Then
            Select Case type
                Case AbbreviationType.Millions
                    Return String.Format("{0:0.#;;0}M", (value / 1000000))
                Case AbbreviationType.Thousands
                    Return String.Format("{0:0.#;;0}K", (value / 1000))
            End Select
        End If
        Return text
    End Function
    Public Shared Function GetCurrencyAbbreviationMask(ByVal text As String, ByVal type As AbbreviationType) As String
        Return String.Format(GetCurrencyPattern(), GetAbbreviationMask(text, type), CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol)
    End Function
    Private Shared Function GetCurrencyPattern() As String
        Select Case CultureInfo.CurrentCulture.NumberFormat.CurrencyPositivePattern
            Case 0
                Return "{1}{0}"
            Case 1
                Return "{0}{1}"
            Case 2
                Return "{1} {0}"
            Case 3
                Return "{0} {1}"
            Case Else
                Return "{0}"
        End Select
    End Function
End Class

Public NotInheritable Class PaletteHelper

    Private Sub New()
    End Sub
    Private Const PalettePath As String = "~/Content/SalesViewerPalette.xcp"

    Private Shared ReadOnly commonPaletteLock As New Object()
    Private Shared fCommonPallete As Palette = Nothing
    Private Shared ReadOnly Property CommonPallete() As Palette
        Get
            SyncLock commonPaletteLock
                If fCommonPallete Is Nothing Then
                    fCommonPallete = GetCommonPalette()
                End If
                Return fCommonPallete
            End SyncLock
        End Get
    End Property
    Public Shared Sub LoadCommonPalette(ByVal control As WebChartControl)
        control.PaletteWrappers.Add(New PaletteWrapper(CommonPallete))
        control.PaletteName = CommonPallete.Name
    End Sub
    Public Shared Function GetCommonPalletePointColor(ByVal index As Integer) As Color
        index = index Mod CommonPallete.Count
        Return CommonPallete(index).Color
    End Function
    Public Shared Function GetCommonPalletePointCssColor(ByVal index As Integer) As String
        Dim c As Color = GetCommonPalletePointColor(index)
        Return String.Format("rgb({0}, {1}, {2})", c.R, c.G, c.B)
    End Function

    Private Shared Function GetCommonPalette() As Palette
        Dim palette As New Palette("common")
        palette.LoadFromXml(HttpContext.Current.Server.MapPath(PalettePath))
        Return palette
    End Function
End Class

Public Enum AbbreviationType
    NoAbbreviation
    Millions
    Thousands
End Enum
Public Enum SelectionInterval
    Day = 0
    Month = 1
End Enum
