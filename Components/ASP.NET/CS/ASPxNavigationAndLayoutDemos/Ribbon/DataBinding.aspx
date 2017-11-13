<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.cs"
    Inherits="Ribbon_DataBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRibbon ID="ASPxRibbon1" runat="server" DataSourceID="XmlDataSource1">
    </dx:ASPxRibbon>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Ribbon/MathInterface.xml" XPath="/MathInterface/*"></asp:XmlDataSource>
</asp:Content>
