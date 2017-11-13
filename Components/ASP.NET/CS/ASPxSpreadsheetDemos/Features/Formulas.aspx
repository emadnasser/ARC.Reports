<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Formulas.aspx.cs" Inherits="Features_Formulas" Culture="en-US" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
    <script type="text/javascript" src="<%= Page.ResolveClientUrl("~/Scripts/StartEditFormula.js") %>"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" Runat="Server">
    <div style="padding-bottom:5px;">
        On the AutoComplete list, double-click on the <b>SUMIFS</b> function (or press the Tab key if SUMIFS is selected) to insert this function into the cell formula, and then press Enter to evaluate the formula.
    </div>
    <dx:ASPxSpreadsheet ID="Spreadsheet" runat="server" Width="100%" Height="700px" ActiveTabIndex="3" ShowConfirmOnLosingChanges="false">
        <ClientSideEvents EndSynchronization="function (s, e) { StartEditSpreadsheetFormula(s); }" />
    </dx:ASPxSpreadsheet>
</asp:Content>
