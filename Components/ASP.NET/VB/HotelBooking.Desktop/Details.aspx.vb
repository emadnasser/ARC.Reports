Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports HotelBooking

Partial Public Class Details
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

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        If Not SearchState.ValidateDetailsPageParameters(Request.Params) Then
            Response.Redirect("Default.aspx")
        End If
        State = New SearchState("Details", Request.Params, New HotelBookingDataContextExt())
        SearchPanel.State = State
        BindRoomsNavBar(State.Hotel)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        HotelSummaryControl.hotel = State.Hotel
        DescriptionLabel.Text = State.Hotel.Description
        HotelPicturesImageSlider.DataSource = State.Hotel.Pictures
        HotelPicturesImageSlider.DataBind()
        ReviewsDataView.DataSource = State.Hotel.Reviews
        ReviewsDataView.DataBind()

        HotelFeaturesDataView.DataSource = State.Hotel.Hotel_Features.Take(6)
        HotelFeaturesDataView.DataBind()

        RoomFeaturesDataView.DataSource = State.Hotel.Rooms(0).Room_Features
        RoomFeaturesDataView.DataBind()

        HotelLocationDataView.DataSource = DataProvider.GetDefaultHotelLocations()
        HotelLocationDataView.DataBind()
    End Sub

    Private Sub BindRoomsNavBar(ByVal hotel As Hotel)
        RoomsNavBar.Groups.Clear()
        For Each room In hotel.Rooms
            Dim group = New NavBarGroup(room.Room_Type.Type_Name, room.ID.ToString())
            group.Expanded = False
            group.DataItem = room
            RoomsNavBar.Groups.Add(group)
            group.Items.Add()
        Next room
    End Sub

    Protected Sub FeaturesDataView_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim dv = TryCast(sender, ASPxDataView)
        Dim room = State.Hotel.Rooms((TryCast(dv.NamingContainer, NavBarGroupTemplateContainer)).Group.VisibleIndex)
        dv.DataSource = room.Room_Features
        dv.DataBind()
    End Sub

    Protected Sub RoomImageSlider_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim slider = TryCast(sender, ASPxImageSlider)
        Dim room = State.Hotel.Rooms((TryCast(slider.NamingContainer, NavBarGroupTemplateContainer)).Group.VisibleIndex)
        slider.ClientInstanceName = "RoomSlider" & (TryCast(slider.NamingContainer, NavBarGroupTemplateContainer)).Group.VisibleIndex.ToString()
        slider.DataSource = room.Pictures
        slider.DataBind()
    End Sub

    Protected Sub ImagePopupControl_WindowCallback(ByVal source As Object, ByVal e As DevExpress.Web.PopupWindowCallbackArgs)
        Dim roomID = Convert.ToInt32(e.Parameter.Substring(0, e.Parameter.IndexOf("|")))
        Dim imageName = e.Parameter.Substring(e.Parameter.IndexOf("|") + 1)

        Dim context_Renamed = New HotelBookingDataContextExt()
        Dim room = context_Renamed.Rooms.First(Function(r) r.ID = roomID)

        RoomPopupImageSlider.DataSource = room.Pictures
        RoomPopupImageSlider.DataBind()
        RoomPopupImageSlider.ActiveItemIndex = RoomPopupImageSlider.Items.IndexOf(Function(isi) CType(isi.DataItem, Picture).Picture_Id = imageName)
    End Sub
    Protected Sub RoomBookItButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim button = TryCast(sender, ASPxButton)
        Dim room = State.Hotel.Rooms((TryCast(button.NamingContainer, NavBarGroupTemplateContainer)).Group.VisibleIndex)
        Dim parameters = State.GetQueryParameters(False)
        parameters("roomID") = room.ID.ToString()
        Response.Redirect("Booking.aspx?" & DataProvider.GetQueryString(parameters))
    End Sub
End Class
