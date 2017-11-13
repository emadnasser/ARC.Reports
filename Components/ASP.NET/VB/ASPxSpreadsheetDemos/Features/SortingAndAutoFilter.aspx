<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SortingAndAutoFilter.aspx.vb" Inherits="Features_SortingAndAutoFilter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxSpreadsheet ID="Spreadsheet" runat="server" Width="100%" Height="700px" 
		ActiveTabIndex="2" ShowConfirmOnLosingChanges="false">
	</dx:ASPxSpreadsheet>
</asp:Content>