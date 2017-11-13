<%@ Application Language="vb" %>

<script runat="server">

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        DemoUtils.ImageLoader.EnsureImages()
        AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf CallbackError
    End Sub

    Sub CallbackError(ByVal sender As Object, ByVal e As EventArgs)
        ' Logging exceptions occur on callback events of DevExpress ASP.NET controls. 
        ' To learn more, see http://www.devexpress.com/Support/Center/Example/Details/E2398
    End Sub
</script>