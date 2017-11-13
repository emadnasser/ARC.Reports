<%@ Control Language="vb" %>
<script runat="server">

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		AddHandler Page.Load, AddressOf OwnerPage_Load
	End Sub
	Protected Sub OwnerPage_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim page As Page = (TryCast(sender, Control)).Page
		Utils.RegisterCssLink(page, "~/Content/Site.css?v=" & Utils.GetVersionSuffix())
		Utils.RegisterCssLink(page, "~/Content/CodeFormatter.css")
	End Sub
</script>
<script type="text/javascript" src="<%=Page.ResolveClientUrl("~/Scripts/Demo.js?v=") + Utils.GetVersionSuffix()%>"></script>
<style>
	@font-face
	{
		font-family: "arima madurai";
		src:url("<%=Page.ResolveClientUrl("~/Content/Fonts/CustomFont0.woff")%>?v=<%=Utils.GetVersionSuffix()%>") format('woff');
	}
	@font-face
	{
		font-family: "comfortaa";
		src:url("<%=Page.ResolveClientUrl("~/Content/Fonts/CustomFont1.woff")%>?v=<%=Utils.GetVersionSuffix()%>") format('woff');
	}
	@font-face
	{
		font-family: "asap";
		src:url("<%=Page.ResolveClientUrl("~/Content/Fonts/CustomFont2.woff")%>?v=<%=Utils.GetVersionSuffix()%>") format('woff');
	}
</style>