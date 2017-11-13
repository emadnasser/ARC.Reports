<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MailMerge.aspx.cs" Inherits="MailMerge_MailMerge" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" Runat="Server">
    <div class="BottomMargin">
        <dx:ASPxLabel ID="lblChosen" runat="server" Text="Choose mail merge mode:" />
    </div>
    <dx:ASPxRadioButtonList ID="rblMailMergeMode" runat="server" AutoPostBack="true">
        <Items>
            <dx:ListEditItem Text="Single Sheet (merged ranges for all data source records are inserted one after another into a single worksheet)" Value="OneWorksheet" Selected="true" />
            <dx:ListEditItem Text="Multiple Sheets (the merged range for each data source record is inserted into a separate worksheet in a single workbook)" Value="Worksheets" />
        </Items>
    </dx:ASPxRadioButtonList>
    <br />
    <dx:ASPxSpreadsheet ID="Spreadsheet" runat="server" Width="100%" Height="740px" ActiveTabIndex="0" ShowConfirmOnLosingChanges="false">
    </dx:ASPxSpreadsheet>
</asp:Content>
