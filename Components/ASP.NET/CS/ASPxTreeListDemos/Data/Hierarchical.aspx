<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Hierarchical.aspx.cs"
    Inherits="Data_Hierarchical" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource1"
        Width="100%">
        <Columns>
            <dx:TreeListDataColumn FieldName="title" Caption="Page Title" VisibleIndex="0" />
        </Columns>
        <SettingsBehavior ExpandCollapseAction="NodeDblClick" />
    </dx:ASPxTreeList>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/SiteMap.xml"
        XPath="/*/*/*" />
</asp:Content>
