Imports HotelBooking
Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Globalization
Imports System.Linq
Imports System.Web

Public Class SearchState

    Private validState_Renamed As Boolean = True

    Public Sub New(ByVal page As String, ByVal parameters As NameValueCollection, ByVal context As HotelBookingDataContext)
        Me.Page = page
        DataContext = context
        If Not String.IsNullOrEmpty(parameters("location")) Then
            Try
                CheckInDate = Date.ParseExact(parameters("checkin"), "M-d-yyyy", CultureInfo.InvariantCulture)
                CheckOutDate = Date.ParseExact(parameters("checkout"), "M-d-yyyy", CultureInfo.InvariantCulture)
                RoomsCount = Convert.ToInt32(parameters("rooms"))
                AdultsCount = Convert.ToInt32(parameters("adults"))
                ChildrenCount = Convert.ToInt32(parameters("children"))
                Metro_Area = context.Metro_Areas.First(Function(c) c.ID = Convert.ToInt32(parameters("location")))
                If Not String.IsNullOrEmpty(parameters("hotelID")) Then
                    Hotel = context.Hotels.First(Function(h) h.ID = Convert.ToInt32(parameters("hotelID")))
                End If
                If Not String.IsNullOrEmpty(parameters("roomID")) Then
                    Room = context.Rooms.First(Function(r) r.ID = Convert.ToInt32(parameters("roomID")))
                End If
            Catch
                ValidState = False
            End Try
        End If

        FilterCustomerRating = parameters("custrating")
        FilterLocationRating = parameters("locrating")
        FilterMaxPrice = parameters("maxprice")
        FilterMinPrice = parameters("minprice")
        FilterOurRating = parameters("ourrating")
    End Sub

    Public Property Page() As String

    Public Property DataContext() As HotelBookingDataContext
    Public Property CheckInDate() As Date
    Public Property CheckOutDate() As Date
    Public Property RoomsCount() As Integer
    Public Property AdultsCount() As Integer
    Public Property ChildrenCount() As Integer

    Public Property Hotel() As Hotel
    Public Property Metro_Area() As Metro_Area
    Public Property Room() As Room
    Public Property ValidState() As Boolean
        Get
            Return validState_Renamed
        End Get
        Set(ByVal value As Boolean)
            validState_Renamed = value
        End Set
    End Property

    Public ReadOnly Property NightsCount() As Integer
        Get
            Return (CheckOutDate.Subtract(CheckInDate)).Days
        End Get
    End Property

    Public ReadOnly Property StartFilterText() As String
        Get
            Dim paramsList = New List(Of String)()
            paramsList.Add(String.Format("{0} {1}", NightsCount,If(NightsCount > 1, "nights", "night")))
            paramsList.Add(String.Format("{0} {1}", RoomsCount,If(RoomsCount > 1, "rooms", "room")))
            paramsList.Add(String.Format("{0} {1}", AdultsCount,If(AdultsCount > 1, "adults", "adult")))
            If ChildrenCount > 0 Then
                paramsList.Add(String.Format("{0} {1}", ChildrenCount,If(ChildrenCount > 1, "child", "children")))
            End If
            Return String.Format("{0} - {1}<br/>{2}", CheckInDate.ToString("MMM d"), CheckOutDate.ToString("MMM d, yyyy"), String.Join(", ", paramsList))
        End Get
    End Property

    Public Property FilterMinPrice() As String
    Public Property FilterMaxPrice() As String
    Public Property FilterCustomerRating() As String
    Public Property FilterOurRating() As String
    Public ReadOnly Property FilterOurRatingArray() As Integer()
        Get
            If String.IsNullOrEmpty(FilterOurRating) Then
                Return New Integer() { 1,2,3,4,5 }
            Else
                Return FilterOurRating.Split(","c).Select(Function(s) Convert.ToInt32(s)).ToArray()
            End If
        End Get
    End Property
    Public Property FilterLocationRating() As String

    Public Function GetQueryParameters(ByVal addFilterParameters As Boolean) As NameValueCollection
        Dim parameters = New NameValueCollection()
        parameters("location") = Metro_Area.ID.ToString()
        parameters("checkin") = CheckInDate.ToString("M-d-yyyy")
        parameters("checkout") = CheckOutDate.ToString("M-d-yyyy")
        parameters("rooms") = RoomsCount.ToString()
        parameters("adults") = AdultsCount.ToString()
        parameters("children") = ChildrenCount.ToString()
        If Hotel IsNot Nothing Then
            parameters("hotelID") = Hotel.ID.ToString()
        End If
        If Room IsNot Nothing Then
            parameters("roomID") = Room.ID.ToString()
        End If
        If addFilterParameters Then
            If Not String.IsNullOrEmpty(FilterCustomerRating) Then
                parameters("custrating") = FilterCustomerRating
            End If
            If Not String.IsNullOrEmpty(FilterLocationRating) Then
                parameters("locrating") = FilterLocationRating
            End If
            If Not String.IsNullOrEmpty(FilterMaxPrice) Then
                parameters("maxprice") = FilterMaxPrice
            End If
            If Not String.IsNullOrEmpty(FilterMinPrice) Then
                parameters("minprice") = FilterMinPrice
            End If
            If Not String.IsNullOrEmpty(FilterOurRating) Then
                parameters("ourrating") = FilterOurRating
            End If
        End If
        Return parameters
    End Function

    Public Shared Function ValidateResultsPageParameters(ByVal parameters As NameValueCollection) As Boolean
        Return (Not String.IsNullOrEmpty(parameters("rooms"))) AndAlso (Not String.IsNullOrEmpty(parameters("adults"))) AndAlso (Not String.IsNullOrEmpty(parameters("children"))) AndAlso (Not String.IsNullOrEmpty(parameters("checkin"))) AndAlso (Not String.IsNullOrEmpty(parameters("checkout"))) AndAlso Not String.IsNullOrEmpty(parameters("location"))
    End Function
    Public Shared Function ValidateDetailsPageParameters(ByVal parameters As NameValueCollection) As Boolean
        Return ValidateResultsPageParameters(parameters) AndAlso Not String.IsNullOrEmpty(parameters("hotelID"))
    End Function
    Public Shared Function ValidateBookingPageParameters(ByVal parameters As NameValueCollection) As Boolean
        Return ValidateDetailsPageParameters(parameters) AndAlso Not String.IsNullOrEmpty(parameters("roomID"))
    End Function
End Class
