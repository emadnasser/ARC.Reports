Imports DevExpress.Web
Imports HotelBooking
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class UserControls_ShowDetails
    Inherits System.Web.UI.UserControl
    Implements IPageUserControl

    Public Property SearchState() As SearchState

    Public Sub LoadState(ByVal state As SearchState) Implements IPageUserControl.LoadState
        SearchState = state
        HotelRatingControl.Value = state.Hotel.Customer_Rating

        HotelImageSlider.DataSource = state.Hotel.Pictures.Where(Function(p) p.Room Is Nothing)
        HotelImageSlider.DataBind()

        CommentsDataView.DataSource = state.Hotel.Reviews
        CommentsDataView.DataBind()

        StartFilter.SearchState = state
    End Sub
    Protected Sub HotelRatingControl_Load(ByVal sender As Object, ByVal e As EventArgs)
        HotelRatingControl.ImageMapUrl = "~/Content/Images/rating-map.png"
        HotelRatingControl.BackColor = Color.Transparent
        HotelRatingControl.ItemHeight = 32
        HotelRatingControl.ItemWidth = 34
    End Sub
    Protected Sub CommentRatingControl_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim ratingControl = DirectCast(sender, ASPxRatingControl)
        ratingControl.ImageMapUrl = "~/Content/Images/rating-map-s.png"
        ratingControl.BackColor = Color.Transparent
        ratingControl.ItemHeight = 24
        ratingControl.ItemWidth = 26
    End Sub
    Protected Sub HotelDetailsCallbackPanel_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
        Dim value = Convert.ToDecimal(e.Parameter)
        DataProvider.CustomRatings(SearchState.Hotel.ID) = value
        HotelRatingControl.Value = SearchState.Hotel.Customer_Rating
    End Sub
End Class
