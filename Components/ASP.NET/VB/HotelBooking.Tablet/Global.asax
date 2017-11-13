<%@ Application Language="vb" %>

<script RunAt="server">
    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        RegisterRoutes(System.Web.Routing.RouteTable.Routes)
        AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf CallbackError
    End Sub

    Sub CallbackError(ByVal sender As Object, ByVal e As EventArgs)
        ' Logging exceptions occur on callback events of DevExpress ASP.NET controls. 
        ' To learn more, see http://www.devexpress.com/Support/Center/Example/Details/E2398      
    End Sub
    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
    Sub RegisterRoutes(ByVal routes As System.Web.Routing.RouteCollection)
        Dim pages = New String() { "ShowHotels", "ShowDetails", "ShowRooms", "Booking", "PrintInvoice", "SpecialOffers" }

        For Each page_Renamed In pages
            RegisterRoute(routes, page_Renamed, page_Renamed, "~/Default.aspx")
        Next page_Renamed
    End Sub
    Sub RegisterRoute(ByVal routes As System.Web.Routing.RouteCollection, ByVal key As String, ByVal url As String, ByVal path As String)
        Dim route = routes.MapPageRoute(key, url, path)
        route.DataTokens = New System.Web.Routing.RouteValueDictionary()
        route.DataTokens("Key") = key
    End Sub
</script>