<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
    <dx:ASPxDataView runat="server" DataSourceID="XmlDataSource1">
        <SettingsTableLayout RowsPerPage="1" />
        <ItemStyle Height="100%" />
        <ItemTemplate>
            <dx:ASPxImage ID="imgCover" runat="server" ImageUrl='<%# Eval("PhotoUrl") %>' Width="140px" Height="140px" />
        </ItemTemplate>
    </dx:ASPxDataView>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Contacts.xml" XPath="//Contact" />
</asp:Content>
