Imports HotelBooking
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Public Class SpecialOffer
    Public Sub New(ByVal city As City, ByVal hotel As Hotel)
        Me.City = city
        Me.Hotel = hotel
    End Sub
    Public Property City() As City
    Public Property Hotel() As Hotel
End Class
