Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class UserControls_StartFilter
    Inherits System.Web.UI.UserControl

    Public Property SearchState() As SearchState

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        CheckInDateEdit.Value = SearchState.CheckInDate
        CheckInDateEdit.MinDate = Date.Now.Add(TimeSpan.FromDays(1))
        CheckOutDateEdit.Value = SearchState.CheckOutDate

        RoomsNumberSpinEdit.Value = SearchState.RoomsCount
        AdultsNumberSpinEdit.Value = SearchState.AdultsCount
        ChildrenNumberSpinEdit.Value = SearchState.ChildrenCount
    End Sub
End Class
