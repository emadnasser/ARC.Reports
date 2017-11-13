<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CellValueChanged.aspx.vb" Inherits="ServerSideFunctionality_CellValueChanged" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<dx:ASPxSpreadsheet ID="Spreadsheet" runat="server" 
		Width="100%" ShowFormulaBar="false" RibbonMode="None" ShowSheetTabs="false"
		ShowConfirmOnLosingChanges="false">
	</dx:ASPxSpreadsheet>
</asp:Content>