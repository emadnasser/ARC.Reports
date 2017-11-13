<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="GridLines.aspx.cs"
    Inherits="Rows_GridLines" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox runat="server" ID="ddlGridLines" AutoPostBack="true" OnSelectedIndexChanged="ddlGridLines_SelectedIndexChanged"
        SelectedIndex="2" Caption="Grid lines">
        <RootStyle CssClass="OptionsBottomMargin"></RootStyle>
        <CaptionCellStyle>
            <Paddings PaddingRight="4px" />
        </CaptionCellStyle>
        <Items>
            <dx:ListEditItem Value="Both" />
            <dx:ListEditItem Value="Horizontal" />
            <dx:ListEditItem Value="Vertical" />
            <dx:ListEditItem Value="None" />
        </Items>
    </dx:ASPxComboBox>
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource"
        KeyFieldName="CustomerID" Width="100%">
        <Columns>
            <dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="1" />
            <dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="2" />
            <dx:GridViewDataColumn FieldName="City" VisibleIndex="3" />
            <dx:GridViewDataColumn FieldName="Region" VisibleIndex="4" />
            <dx:GridViewDataColumn FieldName="Country" VisibleIndex="5" />
        </Columns>
        <Settings GridLines="Vertical" ShowGroupPanel="true" ShowFilterRow="true" />
    </dx:ASPxGridView>
    <ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>
