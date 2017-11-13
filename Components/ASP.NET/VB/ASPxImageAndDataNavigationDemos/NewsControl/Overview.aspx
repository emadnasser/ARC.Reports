<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<dx:ASPxNewsControl ID="ASPxNewsControl1" NavigateUrlFormatString="javascript:void('{0}');" DataSourceID="XmlDataSource1" runat="server" RowPerPage="1" Height="230px" EnablePagingCallbackAnimation="true">
		<ItemSettings ShowImageAsLink="True" MaxLength="100" TailText="Details"/>
	</dx:ASPxNewsControl>
	<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/NewsControl/OverviewRSS.xml"
		TransformFile="~/App_Data/NewsControl/RSS.xslt" XPath="//item" />
</asp:Content>