Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Property UserControl() As Control

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        If ((Not IsPostBack) AndAlso (Not IsCallback)) OrElse (Not HiddenField.Contains("page")) Then

            Dim page_Renamed = If(RouteData.Route IsNot Nothing, RouteData.DataTokens("Key").ToString(), String.Empty)
            LoadUserControl(page_Renamed, Request.QueryString)
            HiddenField.Set("page", page_Renamed)
            HiddenField.Set("parameters", Request.QueryString.ToString())
        Else
            LoadUserControl(HiddenField.Get("page").ToString(), HttpUtility.ParseQueryString(HiddenField.Get("parameters").ToString()))
        End If
        If Request.UserAgent.Contains("iPad") AndAlso Request.UserAgent.Contains("Version/7") Then
            Body.Attributes.Add("class", "ios")
        End If
    End Sub
    Protected Sub MainCallbackPanel_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)

        Dim page_Renamed As String = e.Parameter
        Dim parameters As New NameValueCollection()
        If e.Parameter.Contains("?") Then
            page_Renamed = e.Parameter.Substring(0, e.Parameter.IndexOf("?"c))
            Dim queryString As String = e.Parameter.Substring(e.Parameter.IndexOf("?"c) + 1)
            parameters = HttpUtility.ParseQueryString(queryString)
        End If
        TryCast(UserControl, IPageUserControl).LoadState(New SearchState(page_Renamed, parameters, New HotelBooking.HotelBookingDataContextExt()))
    End Sub

    Private Sub LoadUserControl(ByVal page As String, ByVal parameters As NameValueCollection)
        MenuButton.Visible = False
        BackButton.Visible = True
        Select Case page
            Case "ShowHotels"
                UserControl = LoadControl("~/Pages/ShowHotels.ascx")
            Case "ShowDetails"
                UserControl = LoadControl("~/Pages/ShowDetails.ascx")
            Case "ShowRooms"
                UserControl = LoadControl("~/Pages/ShowRooms.ascx")
            Case "Booking", "PrintInvoice"
                UserControl = LoadControl("~/Pages/Booking.ascx")
            Case "SpecialOffers"
                UserControl = LoadControl("~/Pages/SpecialOffers.ascx")
            Case Else
                UserControl = LoadControl("~/Pages/Index.ascx")
                MenuButton.Visible = True
                BackButton.Visible = False
        End Select
        ContentPane.Controls.Add(UserControl)
        TryCast(UserControl, IPageUserControl).LoadState(New SearchState(page, parameters, New HotelBooking.HotelBookingDataContextExt()))
    End Sub
End Class
