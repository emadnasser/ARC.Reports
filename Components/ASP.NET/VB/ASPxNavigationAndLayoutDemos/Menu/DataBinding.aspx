<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.vb"
	Inherits="Menu_DataBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="height: 250px;">
		 <dx:ASPxMenu ID="ASPxMenu1" runat="server" DataSourceID="ASPxSiteMapDataSource1" OnItemDataBound="ASPxMenu1_ItemDataBound" 
			EncodeHtml="False" AllowSelectItem="True" Orientation="Vertical" />
		<dx:ASPxSiteMapDataSource ID="ASPxSiteMapDataSource1" runat="server" SiteMapFileName="~/App_Data/Menu/WorldCup2010.sitemap" />
	</div>
</asp:Content>