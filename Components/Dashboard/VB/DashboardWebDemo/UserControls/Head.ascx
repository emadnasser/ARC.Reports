<%@ Control Language="vb" %>
<script runat="server">

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		AddHandler Page.Load, AddressOf OwnerPage_Load
	End Sub
	Protected Sub OwnerPage_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim page As Page = (TryCast(sender, Control)).Page
		Utils.RegisterCssLink(page, "~/Content/Site.css")
		Utils.RegisterCssLink(page, "~/Content/DashboardSite.css")
		Utils.RegisterCssLink(page, "~/Content/CodeFormatter.css")
		If Utils.IsIE6() Then
			Utils.RegisterCssLink(page, "~/Content/ie6.css")
		End If
	End Sub

</script>
<script type="text/javascript" src="<%=Page.ResolveClientUrl("~/Scripts/Demo.js")%>"></script>