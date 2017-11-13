<%@ Page Language="vb" MasterPageFile="~/Root.master" AutoEventWireup="true" CodeFile="Spreadsheet.aspx.vb" Inherits="Spreadsheet" %>
<asp:Content ID="Content2" ContentPlaceHolderID="RootPlaceHolder" Runat="Server">
<div class="spreadsheetContainer">
    <dx:ASPxSpreadsheet ID="SpreadsheetControl" runat="server" ClientInstanceName="spreadsheet" Height="800" OnCallback="SpreadsheetControl_Callback" />
</div>
</asp:Content>