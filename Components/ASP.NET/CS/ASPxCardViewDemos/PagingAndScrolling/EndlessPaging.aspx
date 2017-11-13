<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EndlessPaging.aspx.cs" Inherits="PagingAndScrolling_EndlessPaging" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable BottomMargin">
        <tr>
            <td><dx:ASPxLabel ID="EnableScrollingLabel" runat="server" Text="Enable scrolling:" AssociatedControlID="EnableScrollingCheckBox" /></td>
            <td><dx:ASPxCheckBox ID="EnableScrollingCheckBox" runat="server" AutoPostBack="true" /></td>
        </tr>
        <tr>
            <td><dx:ASPxLabel ID="EndlessPagingModeLabel" runat="server" Text="Endless paging mode:" AssociatedControlID="EndlessPagingModeComboBox" /></td>
            <td><dx:ASPxComboBox ID="EndlessPagingModeComboBox" runat="server" AutoPostBack="true" /></td>
        </tr>
    </table>
    <dx:ASPxCardView ID="CardView" runat="server" DataSourceID="HomesDataSource" KeyFieldName="ID" EnableCardsCache="false" Width="100%">
        <Columns>
            <dx:CardViewColumn FieldName="Address" />
            <dx:CardViewColumn FieldName="Baths" />
            <dx:CardViewColumn FieldName="Beds" />
            <dx:CardViewColumn FieldName="HouseSize" />
            <dx:CardViewTextColumn FieldName="Price">
                <PropertiesTextEdit DisplayFormatString="c" />
            </dx:CardViewTextColumn>
            <dx:CardViewColumn FieldName="Status" />            
            <dx:CardViewImageColumn FieldName="PhotoUrl" Settings-AllowSort="False">
                <PropertiesImage ImageWidth="200" />
            </dx:CardViewImageColumn>
        </Columns>
        <CardLayoutProperties ColCount="2">
            <Items>
                <dx:CardViewColumnLayoutItem ColumnName="PhotoUrl" ShowCaption="False" RowSpan="6" VerticalAlign="Top" />
                <dx:CardViewColumnLayoutItem ColumnName="Baths" />
                <dx:CardViewColumnLayoutItem ColumnName="Beds" />
                <dx:CardViewColumnLayoutItem ColumnName="HouseSize" />
                <dx:CardViewColumnLayoutItem ColumnName="Price" />
                <dx:CardViewColumnLayoutItem ColumnName="Address" />
            </Items>
        </CardLayoutProperties>
        <Settings VerticalScrollableHeight="600" />
        <SettingsPager Mode="EndlessPaging" SettingsTableLayout-ColumnCount="2" />
        <Styles>
            <Card Width="450" />
        </Styles>
    </dx:ASPxCardView>
    <asp:ObjectDataSource ID="HomesDataSource" runat="server" SelectMethod="SelectHomes" TypeName="HomesDataProvider" />
</asp:Content>
