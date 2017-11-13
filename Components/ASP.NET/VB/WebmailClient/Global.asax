<%@ Application Language="vb" %>

<script runat="server">
	Sub Application_PreRequestHandlerExecute(ByVal sender As Object, ByVal e As EventArgs)
		DevExpress.Web.ASPxWebControl.GlobalTheme = Utils.CurrentTheme
	End Sub
	Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
		DevExpress.Web.Internal.DemoUtils.RegisterDemo("WebMailClient")
		AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf CallbackError
	End Sub

	Sub CallbackError(ByVal sender As Object, ByVal e As EventArgs)
		' Logging exceptions occur on callback events of DevExpress ASP.NET controls. 
		' To learn more, see http://www.devexpress.com/Support/Center/Example/Details/E2398      
	End Sub
</script>