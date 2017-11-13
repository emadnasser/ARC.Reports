Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Linq
Imports System.Web
Imports DevExpress.Internal

Namespace HotelBooking
    Public Class HotelBookingDataContextExt
        Inherits HotelBookingDataContext

        Private Shared ReadOnly Property ConnectionString() As String
            Get
                Dim sqlExpressString As String = ConfigurationManager.ConnectionStrings("HotelBookingConnectionString").ConnectionString
                Return DbEngineDetector.PatchConnectionString(sqlExpressString)
            End Get
        End Property
        Public Sub New()
            MyBase.New(ConnectionString)
        End Sub
    End Class

    Partial Public Class City
        Public ReadOnly Property DisplayName() As String
            Get
                If String.IsNullOrEmpty(State_Province) Then
                    Return String.Format("{0}, {1}", City_Name, Country)
                Else
                    Return String.Format("{0}, {1}, {2}", City_Name, State_Province, Country)
                End If
            End Get
        End Property
        Public ReadOnly Property CheapestHotel() As Hotel
            Get
                Return Hotels.Aggregate(Function(h1, h2) If(h1.StartPrice < h2.StartPrice, h1, h2))
            End Get
        End Property
        Public ReadOnly Property City_Image_Url() As String
            Get
                Return String.Format("~/Content/Cities/{0}", City_Image).Replace(".png", ".jpg")
            End Get
        End Property
    End Class

    Partial Public Class Hotel
        Public ReadOnly Property StartPrice() As Decimal
            Get
                Return Rooms.Min(Function(r) r.Nighly_Rate).Value
            End Get
        End Property
        Public ReadOnly Property EndPrice() As Decimal
            Get
                Return Rooms.Max(Function(r) r.Nighly_Rate).Value
            End Get
        End Property
        Public ReadOnly Property DetailsCity() As String
            Get
                If Not String.IsNullOrEmpty(City.State_Province) Then
                    Return String.Format("{0}, {1} {2}, {3}", City.City_Name, City.State_Province, Postal_Code, City.Country)
                End If
                Return String.Format("{0} {1}, {2}", City.City_Name, Postal_Code, City.Country)
            End Get
        End Property
        Public ReadOnly Property PrimaryPicture() As Picture
            Get
                If Pictures.Any() Then
                    Return Pictures(0)
                End If
                Return New Picture()
            End Get
        End Property
        Public ReadOnly Property SecondaryPicture() As Picture
            Get
                If Pictures.Count > 1 Then
                    Return Pictures(1)
                End If
                Return New Picture()
            End Get
        End Property
        Public ReadOnly Property RoundRating() As Integer
            Get
                Return CInt((Math.Round(Customer_Rating)))
            End Get
        End Property
        Public ReadOnly Property Customer_Rating() As Decimal
            Get
                Return If(DataProvider.CustomRatings.ContainsKey(ID), DataProvider.CustomRatings(ID), Convert.ToDecimal(Avg_Customer_Rating.Value))
            End Get
        End Property
    End Class

    Partial Public Class Picture
        Public ReadOnly Property Url() As String
            Get
                If Not String.IsNullOrEmpty(Picture_Id) Then
                    Return "~/Content/Pictures/" & Picture_Id
                End If
                Return "~/Content/Images/no-image.png"
            End Get
        End Property
    End Class

    Partial Public Class Room_Feature
        Public ReadOnly Property ImageUrl() As String
            Get
                Return String.Format("~/Content/RoomFeatures/{0}", Feature_Image)
            End Get
        End Property
    End Class

    Partial Public Class Room
        Public ReadOnly Property PriceAvailableDate() As Date
            Get
                Return Date.Now
            End Get
        End Property
    End Class

    Partial Public Class Metro_Area
        Public ReadOnly Property Map_ImageUrl() As String
            Get
                Return String.Format("~/Content/Maps/{0}", Map_Image)
            End Get
        End Property
        Public ReadOnly Property Hotels_Count() As Integer
            Get
                Return Cities.SelectMany(Function(c) c.Hotels).Count()
            End Get
        End Property

        Public ReadOnly Property MinRoomPrice() As Decimal
            Get
                Return Cities.SelectMany(Function(c) c.Hotels).SelectMany(Function(h) h.Rooms).Min(Function(r) r.Nighly_Rate).Value
            End Get
        End Property
        Public ReadOnly Property MaxRoomPrice() As Decimal
            Get
                Return Cities.SelectMany(Function(c) c.Hotels).SelectMany(Function(h) h.Rooms).Max(Function(r) r.Nighly_Rate).Value
            End Get
        End Property
    End Class
End Namespace
