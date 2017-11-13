<%@ Control Language="vb" %>
<script runat="server">
	Public Property MainMessage() As String
	Public Property Details() As String
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If DemosModel.Instance.DemoProducts.Count <= 1 Then
			dvProductsLinks.Visible = False
			Return
		End If
		dvProductsLinks.DataSource = DemosModel.Instance.DemoProducts.Where(Function(product) (Not product.IsRootDemo)).OrderBy(Function(product) product.NavItemTitle).Select(Function(product) New With {Key .Title = product.NavItemTitle, Key .NavigateUrl = Utils.GenerateDemoUrl(product.Intro)})
		dvProductsLinks.DataBind()
	End Sub
</script>
<div class="ErrorContainer">
	<div class="MainMessage">
		<%=MainMessage%></div>
	<div class="Details">
		<%=Details%></div>
	<div>
		<dx:ASPxDataView runat="server" ID="dvProductsLinks" CssClass="ProductsView" EnableTheming="False"
			AllowPaging="False" SettingsTableLayout-ColumnCount="3" ItemSpacing="0px">
			<PagerSettings Visible="False">
			</PagerSettings>
			<ItemTemplate>
				<a href="<%#ResolveClientUrl(CStr(Eval("NavigateUrl")))%>">
					<%#Eval("Title")%></a>
			</ItemTemplate>
			<ItemStyle CssClass="Product" />
			<EmptyItemStyle CssClass="EmptyProduct" />
		</dx:ASPxDataView>
	</div>
</div>