Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Utils.OAuth

Partial Public Class UserControls_SearchPanel
    Inherits System.Web.UI.UserControl

    Public Property IsPopup() As Boolean
    Public Property State() As SearchState

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        If SearchState.ValidateDetailsPageParameters(Request.Params) Then
            State = New SearchState("Details", Request.Params, New HotelBooking.HotelBookingDataContextExt())
        End If

        CheckInDateEdit.MinDate = Date.Now.Add(TimeSpan.FromDays(1))

        If State IsNot Nothing Then
            LocationComboBox.DataBindItems()
            LocationComboBox.SelectedItem = LocationComboBox.Items.FindByValue(State.Metro_Area.ID)
            CheckOutDateEdit.Value = State.CheckOutDate
            CheckInDateEdit.Value = State.CheckInDate
            RoomsComboBox.Value = State.RoomsCount
            AdultsSpinEdit.Value = State.AdultsCount
            ChildrenSpinEdit.Value = State.ChildrenCount
        Else
            CheckOutDateEdit.Value = Date.Now.Add(TimeSpan.FromDays(3))
            CheckInDateEdit.Value = Date.Now.Add(TimeSpan.FromDays(1))
        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If IsPopup Then
            Search.Attributes("class") = "searchPanelPopUp"
            SearchButton.Text = "Apply"
        End If
    End Sub

    Protected Sub SearchButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim parameters As New NameValueCollection() From {
            { "location", LocationComboBox.Value.ToString() },
            { "checkin", CheckInDateEdit.Date.ToString("M-d-yyyy") },
            { "checkout", CheckOutDateEdit.Date.ToString("M-d-yyyy") },
            { "rooms", RoomsComboBox.Value.ToString() },
            { "adults", AdultsSpinEdit.Value.ToString() },
            { "children", ChildrenSpinEdit.Value.ToString() }
        }
        Dim redirectUrl = "Results.aspx?" & DataProvider.GetQueryString(parameters)
        If Page.IsCallback Then
            DevExpress.Web.ASPxWebControl.RedirectOnCallback(redirectUrl)
        Else
            Response.Redirect(redirectUrl)
        End If
    End Sub
End Class
