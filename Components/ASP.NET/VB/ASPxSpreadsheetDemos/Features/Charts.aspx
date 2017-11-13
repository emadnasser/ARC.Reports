<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Charts.aspx.vb" Inherits="Features_Charts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxSpreadsheet ID="Spreadsheet" runat="server" Width="100%" Height="700px" 
		ActiveTabIndex="1" ShowConfirmOnLosingChanges="false">
	</dx:ASPxSpreadsheet>
</asp:Content>