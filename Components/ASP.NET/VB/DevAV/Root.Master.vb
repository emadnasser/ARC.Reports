Imports System
Imports System.Web.UI

Partial Public Class Root
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim pageNameScript = String.Format("<script type='text/javascript'>DevAVPageName = '{0}';</script>", PageName)
        Page.Header.Controls.AddAt(0, New LiteralControl(pageNameScript))
    End Sub

    Protected ReadOnly Property PageName() As String
        Get

            Dim page_Renamed = TryCast(Page, BasePage)
            Return If(page_Renamed IsNot Nothing, page_Renamed.PageName, String.Empty)
        End Get
    End Property
End Class
