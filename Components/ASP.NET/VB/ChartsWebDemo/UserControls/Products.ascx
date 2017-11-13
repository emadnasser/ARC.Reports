<%@ Control Language="vb" %>
<script runat="server">

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		dvProducts.DataSource = Utils.GenerateProductDemos(False)
		dvProducts.DataBind()
		rpLargeProducts.DataSource = Utils.GenerateProductDemos(True)
		rpLargeProducts.DataBind()
	End Sub
</script>
<div class="ProductsView Large">
	<asp:Repeater runat="server" ID="rpLargeProducts">
		<ItemTemplate>
			<div class="Product">
				<h3>
					<a href="<%#ResolveClientUrl(CStr(Eval("NavigateUrl")))%>"><%#Eval("Title")%></a>
				</h3>
				<div class="SmallScreenshotShadow">
					<a href="<%#ResolveClientUrl(CStr(Eval("NavigateUrl")))%>">
						<img src="<%#ResolveClientUrl(CStr(Eval("ImageUrl")))%>" alt="<%#Eval("Title")%>" /></a>
				</div>
				<div class="Description">
					<%#Eval("Description")%>
				</div>
			</div>
		</ItemTemplate>
	</asp:Repeater>
</div>
<dx:ASPxDataView runat="server" ID="dvProducts" CssClass="ProductsView Small" ItemSpacing="24px"
	EnableTheming="false" AllowPaging="False" SettingsTableLayout-ColumnCount="4" Width="910px">
	<itemtemplate>
			<div class="ProductWrapper">
					<h3>
						<a href="<%#ResolveClientUrl(CStr(Eval("NavigateUrl")))%>"><%#Eval("Title")%></a>
					</h3>
				<div class="SmallScreenshotShadow">
					<a href="<%#ResolveClientUrl(CStr(Eval("NavigateUrl")))%>">
						<img src="<%#ResolveClientUrl(CStr(Eval("ImageUrl")))%>" alt="<%#Eval("Title")%>" /></a>
				</div>
				<a href="<%#ResolveClientUrl(CStr(Eval("NavigateUrl")))%>"><%#Eval("Description")%></a>
			</div>
		</itemtemplate>
	<itemstyle cssclass="Product" HorizontalAlign="Center" VerticalAlign="Bottom" width="255px" />
</dx:ASPxDataView>