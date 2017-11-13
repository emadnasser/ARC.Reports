<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="TagInspector.aspx.vb" Inherits="Features_TagInspector" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Width="100%" Height="480px">
		<Settings ShowTagInspector="true" />
		<CssFiles>
			<dx:HtmlEditorCssFile FilePath="~/Content/Demo/Css/TableSupport.css" />
		</CssFiles>
	</dx:ASPxHtmlEditor>
</asp:Content>