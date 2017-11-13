<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="DataBinding.aspx.cs" Inherits="TreeView_DataBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxTreeView ID="treeView" runat="server" DataSourceID="XmlDataSource1" AllowSelectNode="true"
        OnNodeDataBound="treeView_NodeDataBound" TextField="Title" NavigateUrlField="HelpUrl"
        ImageUrlField="NodeTypeImage">
        <Images>
            <NodeImage Width="16px" Height="16px">
            </NodeImage>
        </Images>
        <Styles>
            <NodeImage Paddings-PaddingTop="3px">
            </NodeImage>
        </Styles>
    </dx:ASPxTreeView>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/TreeView/HelpNav.xml" XPath="/namespace/*">
    </asp:XmlDataSource>
</asp:Content>
