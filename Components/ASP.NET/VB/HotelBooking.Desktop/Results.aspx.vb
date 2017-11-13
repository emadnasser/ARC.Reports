Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports HotelBooking
Imports DevExpress.Web

Partial Public Class Results
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
        If Not SearchState.ValidateResultsPageParameters(Request.Params) Then
            Response.Redirect("Default.aspx")
        End If
        State = New SearchState("Results", Request.Params, New HotelBookingDataContextExt())

        If Not IsPostBack Then
            LocationComboBox.DataBindItems()
            LocationComboBox.SelectedItem = LocationComboBox.Items.FindByValue(State.Metro_Area.ID)

            NightlyRateTrackBar.MaxValue = Math.Floor(State.Metro_Area.MaxRoomPrice)
            NightlyRateTrackBar.MinValue = Math.Floor(State.Metro_Area.MinRoomPrice)

            NightlyRateTrackBar.PositionStart = GetDecimalValue(State.FilterMinPrice, NightlyRateTrackBar.MinValue, NightlyRateTrackBar.MaxValue, NightlyRateTrackBar.MinValue)
            NightlyRateTrackBar.PositionEnd = GetDecimalValue(State.FilterMaxPrice, NightlyRateTrackBar.MinValue, NightlyRateTrackBar.MaxValue, NightlyRateTrackBar.MaxValue)

            CustomerRatingTrackBar.Position = GetDecimalValue(State.FilterCustomerRating, CustomerRatingTrackBar.MinValue, CustomerRatingTrackBar.MaxValue, CustomerRatingTrackBar.MinValue)

            LocationRatingComboBox.Value = If(State.FilterLocationRating, "BBB")

            MapImage.ImageUrl = State.Metro_Area.Map_ImageUrl

            For i As Integer = 0 To 4
                OurRatingCheckBoxList.Items(i).Selected = State.FilterOurRatingArray.Contains(i + 1)
            Next i
            EnsureTokensList(False)
        End If

        Dim hotels = FindHotels().ToList()
        HotelsDataView.DataSource = hotels
        HotelsDataView.DataBind()
        HotelsCountLabel.Text = String.Format("{0} HOTELS", hotels.Count())
    End Sub

    Private Sub EnsureTokensList(ByVal updateFilter As Boolean)
        If Not updateFilter Then
            FilterTokenBox.Tokens.Clear()
        End If
        EnsureToken(State.Metro_Area.Area_Name, updateFilter, Sub() Response.Redirect("Default.aspx"))
        If NightlyRateTrackBar.PositionStart <> NightlyRateTrackBar.MinValue OrElse NightlyRateTrackBar.PositionEnd <> NightlyRateTrackBar.MaxValue Then
            EnsureToken(String.Format("${0}-${1}", NightlyRateTrackBar.PositionStart, NightlyRateTrackBar.PositionEnd), updateFilter, Sub()
                State.FilterMaxPrice = Nothing
                State.FilterMinPrice = Nothing
            End Sub)
        End If
        If CustomerRatingTrackBar.Position > 1 Then
            EnsureToken(String.Format("{0}+ Customer Rating", CustomerRatingTrackBar.Position), updateFilter, Sub() State.FilterCustomerRating = Nothing)
        End If
        If State.FilterOurRatingArray.Length < 5 Then
            EnsureToken(String.Format("{0} Stars", String.Join(", ", State.FilterOurRatingArray)), updateFilter, Sub() State.FilterOurRating = Nothing)
        End If
        If (Not String.IsNullOrEmpty(State.FilterLocationRating)) AndAlso State.FilterLocationRating <> "BBB" Then
            EnsureToken(String.Format("{0}+ Location Rating", State.FilterLocationRating), updateFilter, Sub() State.FilterLocationRating = Nothing)
        End If
        If updateFilter Then
            Response.Redirect("Results.aspx?" & DataProvider.GetQueryString(State.GetQueryParameters(True)))
        End If
    End Sub
    Private Sub EnsureToken(ByVal text As String, ByVal updateFilter As Boolean, ByVal changeFilterAction As Action)
        If updateFilter AndAlso (Not FilterTokenBox.Tokens.Contains(text)) Then
            changeFilterAction()
        ElseIf Not updateFilter Then
            FilterTokenBox.Tokens.Add(text)
        End If
    End Sub

    Private Function FindHotels() As IEnumerable(Of Hotel)
        Return State.DataContext.Hotels.ToList().Where(Function(h) CheckHotelFilters(h))
    End Function
    Private Function CheckHotelFilters(ByVal hotel As Hotel) As Boolean
        Return hotel.City.Metro_Area_ID = State.Metro_Area.ID AndAlso NightlyRateTrackBar.PositionStart <= hotel.EndPrice AndAlso hotel.StartPrice <= (NightlyRateTrackBar.PositionEnd + 1) AndAlso hotel.Customer_Rating >= CustomerRatingTrackBar.Position AndAlso State.FilterOurRatingArray.Contains(CInt((Math.Floor(hotel.Our_Rating.Value)))) AndAlso DataProvider.LocationRatings.IndexOf(hotel.Location_Rating) >= DataProvider.LocationRatings.IndexOf(LocationRatingComboBox.Value.ToString())
    End Function

    Protected Function GetHotelDetailsUrl(ByVal hotelID As Object) As String
        Dim parameters = State.GetQueryParameters(False)
        parameters("hotelID") = hotelID.ToString()
        Return String.Format("~/Details.aspx?{0}", DataProvider.GetQueryString(parameters))
    End Function

    Protected Sub ApplyFilterButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim parameters = State.GetQueryParameters(False)
        parameters("location") = LocationComboBox.Value.ToString()
        If NightlyRateTrackBar.PositionStart > NightlyRateTrackBar.MinValue Then
            parameters("minprice") = NightlyRateTrackBar.PositionStart.ToString()
        End If
        If NightlyRateTrackBar.PositionEnd < NightlyRateTrackBar.MaxValue Then
            parameters("maxprice") = NightlyRateTrackBar.PositionEnd.ToString()
        End If
        If CustomerRatingTrackBar.Value IsNot Nothing Then
            parameters("custrating") = CustomerRatingTrackBar.Value.ToString()
        End If
        If LocationRatingComboBox.Value IsNot Nothing Then
            parameters("locrating") = LocationRatingComboBox.Value.ToString()
        End If
        If OurRatingCheckBoxList.SelectedValues.Count > 0 Then
            parameters("ourrating") = String.Join(",", OurRatingCheckBoxList.SelectedValues.Cast(Of Integer)())
        End If
        Response.Redirect("Results.aspx?" & DataProvider.GetQueryString(parameters))
    End Sub
    Protected Function GetDecimalValue(ByVal textValue As String, ByVal minValue As Decimal, ByVal maxValue As Decimal, ByVal defaultValue As Decimal) As Decimal
        If String.IsNullOrEmpty(textValue) Then
            Return defaultValue
        End If
        Dim value = Convert.ToDecimal(textValue)
        Return Math.Min(Math.Max(minValue, value), maxValue)
    End Function

    Protected Sub NightyRateTrackBar_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.CustomJSPropertiesEventArgs)
        e.Properties.Add("cpLeftLabelID", "NightyRateTrackBarLabel_L")
        e.Properties.Add("cpRightLabelID", "NightyRateTrackBarLabel_R")
        e.Properties.Add("cpLabelPrefix", "$")
    End Sub
    Protected Sub CustomerRatingTrackBar_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.CustomJSPropertiesEventArgs)
        e.Properties.Add("cpRightLabelID", "CustomerRatingTrackbarLabel_R")
    End Sub
    Protected Sub BookItButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim container = TryCast(DirectCast(sender, ASPxButton).BindingContainer, DataViewItemTemplateContainer)
        Dim hotel = TryCast(container.DataItem, Hotel)
        Dim parameters = State.GetQueryParameters(False)
        parameters("hotelID") = hotel.ID.ToString()
        parameters("roomID") = hotel.Rooms.Aggregate(Function(room, r) (If(room Is Nothing OrElse r.Nighly_Rate.Value < room.Nighly_Rate.Value, room, r))).ID.ToString()
        Response.Redirect("Booking.aspx?" & DataProvider.GetQueryString(parameters))
    End Sub
    Protected Sub FilterTokenBox_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        EnsureTokensList(True)
    End Sub
End Class
