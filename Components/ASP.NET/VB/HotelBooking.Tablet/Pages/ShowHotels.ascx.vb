Imports HotelBooking
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class UserControls_ShowHotels
    Inherits System.Web.UI.UserControl
    Implements IPageUserControl

    Public Property SearchState() As SearchState

    Public Sub LoadState(ByVal state As SearchState) Implements IPageUserControl.LoadState
        SearchState = state
        LocationComboBox.DataBindItems()
        LocationComboBox.SelectedItem = LocationComboBox.Items.FindByValue(state.Metro_Area.ID)
        NightyRateTrackBar.MaxValue = SearchState.Metro_Area.MaxRoomPrice
        NightyRateTrackBar.MinValue = SearchState.Metro_Area.MinRoomPrice
        NightyRateTrackBar.PositionStart = GetDecimalValue(state.FilterMinPrice, NightyRateTrackBar.MinValue, NightyRateTrackBar.MaxValue, NightyRateTrackBar.MinValue)
        NightyRateTrackBar.PositionEnd = GetDecimalValue(state.FilterMaxPrice, NightyRateTrackBar.MinValue, NightyRateTrackBar.MaxValue, NightyRateTrackBar.MaxValue)
        AreaMapImage.ImageUrl = SearchState.Metro_Area.Map_ImageUrl

        CustomerRatingTrackBar.Position = GetDecimalValue(state.FilterCustomerRating, CustomerRatingTrackBar.MinValue, CustomerRatingTrackBar.MaxValue, CustomerRatingTrackBar.MinValue)

        Dim stars() As Integer = { 1, 2, 3, 4, 5 }
        If Not String.IsNullOrEmpty(state.FilterOurRating) Then
            stars = state.FilterOurRating.Split(","c).Select(Function(s) Convert.ToInt32(s)).ToArray()
        End If
        For i As Integer = 0 To 4
            OurRatingCheckBoxList.Items(i).Selected = stars.Contains(i + 1)
        Next i

        Dim hotels = FindHotels(state, state.Metro_Area.ID, stars).ToList()
        If hotels.Any() Then
            ResultsPanel.Visible = True
            NoResultsPanel.Visible = False
            SearchResultsDataView.DataSource = hotels
            SearchResultsDataView.DataBind()
        Else
            ResultsPanel.Visible = False
            NoResultsPanel.Visible = True
        End If

        StartFilter.SearchState = state
    End Sub

    Private Function FindHotels(ByVal state As SearchState, ByVal metroAreaID As Integer, ByVal stars() As Integer) As IEnumerable(Of Hotel)
        Return state.DataContext.Hotels.ToList().Where(Function(h) CheckHotelFilters(h, metroAreaID, stars))
    End Function

    Private Function CheckHotelFilters(ByVal hotel As Hotel, ByVal metroAreaID As Integer, ByVal stars() As Integer) As Boolean
        Return hotel.City.Metro_Area_ID = metroAreaID AndAlso NightyRateTrackBar.PositionStart <= hotel.EndPrice AndAlso hotel.StartPrice <= (NightyRateTrackBar.PositionEnd + 1) AndAlso hotel.Customer_Rating >= CustomerRatingTrackBar.Position AndAlso stars.Contains(CInt((Math.Floor(hotel.Our_Rating.Value))))
    End Function

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
End Class
