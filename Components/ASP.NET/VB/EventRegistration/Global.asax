<%@ Application Language="vb" %>
<%@ Import Namespace="System.Collections.Generic" %>

<script runat="server">
	Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
		DataHelper.LoadDataBase()
		Application("Sessions") = DataHelper.Data.Sessions
		DevExpress.Web.Internal.DemoUtils.RegisterDemo("EventRegistration")
	End Sub
</script>