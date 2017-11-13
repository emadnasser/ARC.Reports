Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports HotelBooking

Partial Public Class UserControls_HotelSummaryControl
    Inherits System.Web.UI.UserControl

    Public Property hotel() As Hotel

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        lblAddress.Text = hotel.Address & "<br />" & hotel.DetailsCity
        HotelRating.Value = hotel.Customer_Rating
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Protected Sub HotelRating_Load(ByVal sender As Object, ByVal e As EventArgs)
        HotelRating.ImageMapUrl = "~/Content/Images/rating-map.png"
        HotelRating.BackColor = System.Drawing.Color.Transparent
        HotelRating.ItemHeight = 32
        HotelRating.ItemWidth = 34
    End Sub
    Protected Sub HotelRating_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Web.RatingControlItemEventArgs)
        DataProvider.CustomRatings(hotel.ID) = e.ItemIndex + 1
        HotelRating.Value = DataProvider.CustomRatings(hotel.ID)
    End Sub
End Class
