<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Invoice.aspx.vb" Inherits="SampleDocuments_Invoice" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<dx:ASPxSpreadsheet ID="Spreadsheet" runat="server" Width="100%" Height="700px" ActiveTabIndex="0" ShowConfirmOnLosingChanges="false">
	</dx:ASPxSpreadsheet>
</asp:Content>