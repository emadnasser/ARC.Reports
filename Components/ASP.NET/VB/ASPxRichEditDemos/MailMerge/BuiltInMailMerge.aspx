<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BuiltInMailMerge.aspx.vb"
	Inherits="RichEditDemoBuiltInMailMerge" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRichEdit ID="DemoRichEdit" DataSourceID="linqDataSource" ActiveTabIndex="4"
		runat="server" Width="100%" Height="500px" ShowConfirmOnLosingChanges="false"
		OnPreRender="DemoRichEdit_PreRender">
	</dx:ASPxRichEdit>
	<asp:LinqDataSource ID="linqDataSource" runat="server"
		ContextTypeName="NorthwindDataContextExt" TableName="Employees"></asp:LinqDataSource>
</asp:Content>