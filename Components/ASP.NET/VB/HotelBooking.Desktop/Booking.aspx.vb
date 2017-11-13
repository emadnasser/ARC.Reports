Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports HotelBooking

Partial Public Class Booking
    Inherits System.Web.UI.Page

    Private privateState As SearchState
    Protected Property State() As SearchState
        Get
            Return privateState
        End Get
        Private Set(ByVal value As SearchState)
            privateState = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not SearchState.ValidateBookingPageParameters(Request.Params) Then
            Response.Redirect("Default.aspx")
        End If
        State = New SearchState("Booking", Request.Params, New HotelBookingDataContextExt())

        HotelImage.ImageUrl = State.Hotel.PrimaryPicture.Url

        HotelSummaryControl.hotel = State.Hotel

        RoomFeaturesDataView.DataSource = State.Room.Room_Features
        RoomFeaturesDataView.DataBind()

        BindPriceRepeater()
    End Sub

    Private Sub BindPriceRepeater()
        Dim prices As New List(Of Object)()
        If State.NightsCount < 4 Then
            For i As Integer = 0 To State.NightsCount - 1
                Dim [date] = State.CheckInDate.Add(TimeSpan.FromDays(i))
                prices.Add(New With {Key .Period = [date].ToString("dddd, MMMM dd, yyyy"), Key .Price = State.Room.Nighly_Rate})
            Next i
        Else
            prices.Add(New With {Key .Period = State.CheckInDate.ToString("dddd, MMMM dd, yyyy"), Key .Price = State.Room.Nighly_Rate})
            prices.Add(New With {Key .Period = String.Format("{0:MMM d} - {1:MMM d}", State.CheckInDate.Add(TimeSpan.FromDays(1)), State.CheckOutDate.Subtract(TimeSpan.FromDays(1))), Key .Price = State.Room.Nighly_Rate * (State.NightsCount - 2)})

            prices.Add(New With {Key .Period = State.CheckOutDate.ToString("dddd, MMMM dd, yyyy"), Key .Price = State.Room.Nighly_Rate})
        End If
        PriceRepeater.DataSource = prices
        PriceRepeater.DataBind()
    End Sub
    Protected Sub InvoiceDocumentViewer_Load(ByVal sender As Object, ByVal e As EventArgs)
        InvoiceDocumentViewer.Report = DataProvider.CreateReport(State)
    End Sub
    Protected Sub CheckCaptchaButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        AccountCaptchaEditor.IsValid = AccountCaptcha.Code = AccountCaptchaEditor.Text
    End Sub
End Class
