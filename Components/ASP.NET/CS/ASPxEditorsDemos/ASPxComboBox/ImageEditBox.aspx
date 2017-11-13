<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ImageEditBox.aspx.cs"
    Inherits="ASPxComboBox_ImageEditBox" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" DataSourceID="XmlDataSource1"
        ImageUrlField="ImageUrl" TextField="Text" ValueField="Name" ValueType="System.String"
        ShowImageInEditBox="True" SelectedIndex="0">
        <ItemImage Height="24px" Width="23px" />
    </dx:ASPxComboBox>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Charts.xml"
        XPath="//Chart" />
</asp:Content>
