Imports HotelBooking
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class UserControls_Booking
    Inherits System.Web.UI.UserControl
    Implements IPageUserControl

    Public Property SearchState() As SearchState

    Public Sub LoadState(ByVal state As SearchState) Implements IPageUserControl.LoadState
        SearchState = state
        SummaryHotelImage.ImageUrl = state.Hotel.PrimaryPicture.Url
        RoomFeaturesDataView.DataSource = state.Room.Room_Features
        RoomFeaturesDataView.DataBind()

        BindPriceRepeater(state)

        InvoicePanel.Visible = state.Page Is "PrintInvoice"

        If Not String.IsNullOrEmpty(AccountCaptchaEditor.Text) Then
            AccountCaptchaEditor.IsValid = AccountCaptcha.Code = AccountCaptchaEditor.Text
            AccountCaptchaHiddenField.Set("IsCaptchaValid", AccountCaptchaEditor.IsValid)
        End If
    End Sub

    Private Sub BindPriceRepeater(ByVal state As SearchState)
        Dim prices As New List(Of Object)()
        If state.NightsCount < 4 Then
            For i As Integer = 0 To state.NightsCount - 1
                Dim [date] = state.CheckInDate.Add(TimeSpan.FromDays(i))
                prices.Add(New With {Key .Period = [date].ToString("dddd, MMMM dd, yyyy"), Key .Price = state.Room.Nighly_Rate})
            Next i
        Else
            prices.Add(New With {Key .Period = state.CheckInDate.ToString("dddd, MMMM dd, yyyy"), Key .Price = state.Room.Nighly_Rate})

            prices.Add(New With {Key .Period = String.Format("{0:MMM d} - {1:MMM d}", state.CheckInDate.Add(TimeSpan.FromDays(1)), state.CheckOutDate.Subtract(TimeSpan.FromDays(1))), Key .Price = state.Room.Nighly_Rate * (state.NightsCount - 2)})

            prices.Add(New With {Key .Period = state.CheckOutDate.ToString("dddd, MMMM dd, yyyy"), Key .Price = state.Room.Nighly_Rate})
        End If
        PriceRepeater.DataSource = prices
        PriceRepeater.DataBind()
    End Sub
    Protected Sub PrintInvoicePopup_WindowCallback(ByVal source As Object, ByVal e As DevExpress.Web.PopupWindowCallbackArgs)
        Dim report = DataProvider.CreateReport(SearchState)
        InvoiceDocumentViewer.Report = report
    End Sub
    Protected Sub InvoiceDocumentViewer_Load(ByVal sender As Object, ByVal e As EventArgs)
        If SearchState.Page Is "PrintInvoice" Then
            InvoiceDocumentViewer.Report = DataProvider.CreateReport(SearchState)
        End If
    End Sub
    Protected Sub AccountCaptcha_Load(ByVal sender As Object, ByVal e As EventArgs)
        AccountCaptcha.ChallengeImage.BackgroundColor = Color.FromArgb(178, 178, 178)
    End Sub
End Class
