Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports HotelBooking
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.Linq
Imports System.Web
Imports System.Collections.Specialized

Public Class DataProvider
    Private Const MaxDaysCountForReport As Integer = 15

    Public Shared ReadOnly Property CustomRatings() As Dictionary(Of Integer, Decimal)
        Get
            If HttpContext.Current.Session("CustomRatings") Is Nothing Then
                HttpContext.Current.Session("CustomRatings") = New Dictionary(Of Integer, Decimal)()
            End If
            Return DirectCast(HttpContext.Current.Session("CustomRatings"), Dictionary(Of Integer, Decimal))
        End Get
    End Property

    Public Shared LocationRatings As New List(Of String)() From {"BBB", "A", "AA", "AAA"}

    Public Shared Function GetMonths() As Dictionary(Of Integer, String)
        Dim results = New Dictionary(Of Integer, String)()
        For i As Integer = 0 To 11
            results.Add(i, DateTimeFormatInfo.CurrentInfo.MonthNames(i))
        Next i
        Return results
    End Function
    Public Shared Function GetCardExpiredYears() As List(Of Integer)
        Dim years = New List(Of Integer)()
        For i As Integer = 0 To 9
            years.Add(Date.Now.Year + i)
        Next i
        Return years
    End Function
    Public Shared Function GetStates() As List(Of String)
        Return New List(Of String)() From {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"}
    End Function
    Public Shared Function GetLocationRatings() As List(Of String)
        Return New List(Of String)() From {"", "AAA", "AA", "A", "BBB"}
    End Function
    Public Shared Function CreateReport(ByVal state As SearchState) As InvoiceReport
        Dim report = New InvoiceReport()
        report.HotelNameLabel1.Text = state.Hotel.Hotel_Name
        report.HotelNameLabel2.Text = state.Hotel.Hotel_Name

        report.RatingPictureBox.ImageUrl = String.Format("~/Content/Report/Rating{0}.png", state.Hotel.RoundRating)
        report.RatingPictureBox.Location = New Point(GetTextWidth(state.Hotel.Hotel_Name, report.HotelNameLabel1.Font), report.RatingPictureBox.Location.Y)

        report.HotelAddressLine1Label.Text = state.Hotel.Address & " " & state.Hotel.City.City_Name
        If Not String.IsNullOrEmpty(state.Hotel.City.State_Province) Then
            report.HotelAddressLine1Label.Text &= ", " & state.Hotel.City.State_Province
        End If
        report.HotelAddressLine1Label.Text &= ", " & state.Hotel.Postal_Code & ","
        report.HotelAddressLine2Label.Text = state.Hotel.City.Country

        report.HotelAddressLabel.Text = state.Hotel.Address & " " & state.Hotel.DetailsCity
        report.CheckInLabel.Text = state.CheckInDate.ToString("MMMM dd, yyyy")
        report.CheckOutLabel.Text = state.CheckOutDate.ToString("MMMM dd, yyyy")

        report.PriceTable.Rows.Clear()
        Dim i As Integer = 0
        Do While i < state.NightsCount AndAlso i < MaxDaysCountForReport
            Dim [date] = state.CheckInDate.Add(TimeSpan.FromDays(i))
            report.PriceTable.Rows.Add(CreateReportRow([date].ToString("MMMM dd, yyyy"), state.Room.Nighly_Rate.Value.ToString("C")))
            i += 1
        Loop
        If state.NightsCount > MaxDaysCountForReport Then
            Dim remainDays = state.NightsCount - MaxDaysCountForReport
            report.PriceTable.Rows.Add(CreateReportRow(String.Format("{0} days more", remainDays), (state.Room.Nighly_Rate.Value * remainDays).ToString("C")))
        End If

        report.TotalPriceLabel.Text = String.Format("{0:C}", state.Room.Nighly_Rate.Value * state.NightsCount)

        report.HotelDescriptionLabel.Text = state.Hotel.Description

        report.HotelSmallImagePictureBox.ImageUrl = state.Hotel.PrimaryPicture.Url
        report.HotelLargeImagePictureBox.ImageUrl = state.Hotel.SecondaryPicture.Url

        Return report
    End Function

    Public Shared Function GetQueryString(ByVal parameters As NameValueCollection) As String
        Dim array = (
            From key In parameters.AllKeys
            Select String.Format("{0}={1}", HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(parameters(key)))).ToArray()
        Return String.Join("&", array)
    End Function

    Private Shared Function GetTextWidth(ByVal text As String, ByVal font As Font) As Integer
        Dim gr = Graphics.FromHwnd(IntPtr.Zero)
        gr.PageUnit = GraphicsUnit.Inch
        Dim size As SizeF = gr.MeasureString(text, font)
        Return Convert.ToInt32(size.Width * 100)
    End Function

    Private Shared Function CreateReportRow(ByVal text As String, ByVal price As String) As XRTableRow
        Dim row = New DevExpress.XtraReports.UI.XRTableRow()
        Dim cell1 = New XRTableCell()
        Dim cell2 = New XRTableCell()
        cell1.Text = text
        cell2.Text = price
        cell2.TextAlignment = TextAlignment.MiddleRight
        row.Cells.Add(cell1)
        row.Cells.Add(cell2)
        Return row
    End Function

    Public Shared Function GetDefaultHotelLocations() As List(Of String)
        Return New List(Of String)() From {"Airport shuttle (available 24 hours)", "Cruise terminal shuttle"}
    End Function
End Class
