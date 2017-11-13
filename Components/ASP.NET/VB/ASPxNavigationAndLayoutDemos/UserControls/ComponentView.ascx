<%@ Control Language="vb" %>
<script runat="server">
	Dim componentGroupName_Renamed As String
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		XmlDataSource1.XPath = String.Format("/Groups/Group[@Text='{0}']/*", ComponentGroupName)
	End Sub
	Public Property ComponentGroupName() As String
		Get
			Return componentGroupName_Renamed
		End Get
		Set(ByVal value As String)
			componentGroupName_Renamed = value
		End Set
	End Property
</script>
<dx:ASPxDataView runat="server" ID="DataView" DataSourceID="XmlDataSource1" EnableTheming="false" AllowPaging="false" Width="100%" ItemSpacing="0">
	<ItemTemplate>
		<div class="componentItem">
			<dx:ASPxImage CssClass="componentItemImage" runat="server" ID="Img" SpriteCssClass='<%#"componentImage_" & Eval("Index")%>' />
			<dx:ASPxHyperLink runat="server" ID="Text" Text='<%#Eval("Text")%>' NavigateUrl='<%#"javascript:void(" & Eval("Index") & ");"%>'
				Font-Underline="False">
			</dx:ASPxHyperLink>
		</div>
	</ItemTemplate>
	<ItemStyle BackColor="Transparent" Border-BorderWidth="0px" Height="0px" Paddings-Padding="0px" />
	<Paddings Padding="0px" />
</dx:ASPxDataView>
<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Components.xml" />