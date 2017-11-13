<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="IListDataSource.aspx.cs"
    Inherits="DataBinding_IListDataSource" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
    <link rel="stylesheet" type="text/css" href="<%= Page.ResolveClientUrl("~/Content/RunDesignerButton.css") %>" />
    <link rel="stylesheet" type="text/css" href="<%= Page.ResolveClientUrl("~/Content/ViewerSelector.css") %>" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopRightMenuRegion" runat="Server">
    <dx:ViewerSelector ID="viewerSelector" runat="server" />
    <dx:ShowDesignerButton ID="showDesignerButton" runat="server" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <% if(IsASPViewer) { %>
    <dx:ASPxDocumentViewer runat="server" ID="documentViewer" Width="680px" EnableViewState="False">
        <SettingsSplitter SidePaneVisible="False" />
    </dx:ASPxDocumentViewer>
    <% } else if(IsHTML5Viewer) { %>
    <dx:ASPxWebDocumentViewer runat="server" ID="webDocumentViewer" ClientInstanceName="webDocumentViewer" EnableViewState="False" />
    <% } else if(IsMobileViewer) { %>
    <dx:MobileEmulator ID="mobileEmulator" runat="server" />
    <% } %>
</asp:Content>
