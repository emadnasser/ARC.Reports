Imports DevExpress.Web
Imports HotelBooking
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls

Partial Public Class Pages_SpecialOffers
    Inherits System.Web.UI.UserControl
    Implements IPageUserControl

    Public CitiesNames() As String = { "Paris", "New York City", "London", "Los Angeles" }

    Public Sub LoadState(ByVal state As SearchState) Implements IPageUserControl.LoadState
        Dim cities = CitiesNames.Select(Function(cn) state.DataContext.Cities.First(Function(c) c.City_Name = cn)).ToList()
        Dim offers = New List(Of SpecialOffer)()
        For Each city In cities
            offers.Add(New SpecialOffer(city, city.CheapestHotel))
        Next city

        If PanelsRepeater.Items.Count = 0 Then
            PanelsRepeater.DataSource = offers
            PanelsRepeater.DataBind()
        End If
    End Sub
    Protected Sub DockPanel_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim panel = DirectCast(sender, ASPxDockPanel)
        Dim index = (TryCast(panel.NamingContainer, RepeaterItem)).ItemIndex + 1
        panel.ID = "DockPanel" & index.ToString()
        panel.PanelUID = "DockPanel" & index.ToString()
        panel.ClientInstanceName = "DockPanel" & index.ToString()
        panel.OwnerZoneUID = "DockZone" & index.ToString()
    End Sub
    Protected Function GetItemIndex(ByVal panel As ASPxDockPanel) As Integer
        Return (TryCast(panel.NamingContainer, RepeaterItem)).ItemIndex + 1
    End Function

    Protected Sub OfferFormPopup_WindowCallback(ByVal source As Object, ByVal e As DevExpress.Web.PopupWindowCallbackArgs)
        Dim index = Convert.ToInt32(e.Parameter) - 1

        Dim context_Renamed = New HotelBookingDataContextExt()
        Dim city = context_Renamed.Cities.First(Function(c) c.City_Name = CitiesNames(index))

        CheckInDateEdit.Value = Date.Now.Add(TimeSpan.FromDays(1))
        CheckInDateEdit.MinDate = Date.Now.Add(TimeSpan.FromDays(1))
        CheckOutDateEdit.Value = Date.Now.Add(TimeSpan.FromDays(3))

        CityNameHeader.InnerHtml = city.City_Name
        HotelNameHeader.InnerHtml = city.CheapestHotel.Hotel_Name
        CheckButton.ClientSideEvents.Click = String.Format("function() {{ onSpecialOfferCheckButtonClick({0}, {1}) }}", city.CheapestHotel.ID, city.Metro_Area_ID)
    End Sub
End Class
