<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.vb"
	Inherits="TabControl_DataBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxTabControl ID="tcDemos" runat="server" NavigateUrlField="id" NavigateUrlFormatString="?id={0}"
		DataSourceID="XmlDataSource1">
	</dx:ASPxTabControl>
	<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Platforms.xml"
		XPath="//product"></asp:XmlDataSource>
</asp:Content>