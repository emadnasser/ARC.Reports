<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HeaderFilter.aspx.cs"
    Inherits="Filtering_HeaderFilter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCheckBox ID="hFModeCheckBox" runat="server" Text="Enable CheckedList mode" Checked="true" AutoPostBack="true" />
    <br />
    <dx:ASPxVerticalGrid ID="VerticalGrid" runat="server" DataSourceID="HomesDataSource" OnHeaderFilterFillItems="VerticalGrid_HeaderFilterFillItems"
        Width="800" EnableRecordsCache="False" AutoGenerateRows="False">
        <Rows>
            <dx:VerticalGridImageRow FieldName="PhotoUrl" Caption="Photo" Settings-AllowHeaderFilter="False">
                <PropertiesImage ImageWidth="200" ImageHeight="132" />
            </dx:VerticalGridImageRow>
            <dx:VerticalGridTextRow FieldName="Price">
                <PropertiesTextEdit DisplayFormatString="c" />
                <RecordStyle Font-Bold="true" />
            </dx:VerticalGridTextRow>
            <dx:VerticalGridCategoryRow Caption="Information">
                <Rows>
                    <dx:VerticalGridDataRow FieldName="Address" Settings-AllowSort="False" Settings-AllowHeaderFilter="False" />
                    <dx:VerticalGridDataRow FieldName="Status" />
                </Rows>
            </dx:VerticalGridCategoryRow>
            <dx:VerticalGridCategoryRow Caption="Features">
                <Rows>
                    <dx:VerticalGridDataRow FieldName="Baths" />
                    <dx:VerticalGridDataRow FieldName="Beds" />
                    <dx:VerticalGridDataRow FieldName="HouseSize" />
                </Rows>
            </dx:VerticalGridCategoryRow>
        </Rows>
        <Settings ShowHeaderFilterButton="true" />
        <Settings HorizontalScrollBarMode="Visible" HeaderAreaWidth="150" RecordWidth="220" ShowCategoryIndents="false" />
        <SettingsPopup HeaderFilter-MinWidth="250" />
    </dx:ASPxVerticalGrid>
    <asp:ObjectDataSource ID="HomesDataSource" runat="server" SelectMethod="SelectHomes" TypeName="HomesDataProvider" />
</asp:Content>
