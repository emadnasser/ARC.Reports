Imports System
Imports System.Drawing
Imports System.Linq
Imports DevExpress.Web
Imports HotelBooking

Partial Public Class UserControls_ShowRooms
    Inherits System.Web.UI.UserControl
    Implements IPageUserControl

    Public Property SearchState() As SearchState

    Public Sub LoadState(ByVal state As SearchState) Implements IPageUserControl.LoadState
        SearchState = state
        HotelRatingControl.Value = state.Hotel.Customer_Rating
        BindRoomsNavBar(state.Hotel)
        StartFilter.SearchState = state
    End Sub

    Private Sub BindRoomsNavBar(ByVal hotel As Hotel)
        RoomsNavBar.Groups.Clear()
        For Each room In hotel.Rooms
            Dim group = New NavBarGroup(room.Room_Type.Type_Name, room.ID.ToString())
            group.DataItem = room
            group.Expanded = False
            RoomsNavBar.Groups.Add(group)
            group.Items.Add()
        Next room
    End Sub

    Protected Sub FeaturesDataView_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim dv = TryCast(sender, ASPxDataView)
        Dim room = TryCast((TryCast(dv.NamingContainer, NavBarGroupTemplateContainer)).Group.DataItem, Room)
        dv.DataSource = room.Room_Features
        dv.DataBind()
    End Sub
    Protected Sub RoomImageSlider_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim slider = TryCast(sender, ASPxImageSlider)
        Dim room = TryCast((TryCast(slider.NamingContainer, NavBarGroupTemplateContainer)).Group.DataItem, Room)
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
    Protected Sub HotelRatingControl_Load(ByVal sender As Object, ByVal e As EventArgs)
        HotelRatingControl.ImageMapUrl = "~/Content/Images/rating-map.png"
        HotelRatingControl.BackColor = Color.Transparent
        HotelRatingControl.ItemHeight = 32
        HotelRatingControl.ItemWidth = 34
    End Sub
    Protected Sub HotelDetailsCallbackPanel_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
        Dim value = Convert.ToDecimal(e.Parameter)
        DataProvider.CustomRatings(SearchState.Hotel.ID) = value
        HotelRatingControl.Value = SearchState.Hotel.Customer_Rating
    End Sub
End Class
