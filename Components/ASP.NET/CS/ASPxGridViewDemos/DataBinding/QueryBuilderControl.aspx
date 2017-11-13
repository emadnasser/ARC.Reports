<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="QueryBuilderControl.aspx.cs" Inherits="DataBinding_QueryBuilderControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
    <style>
        .textAlignLeft {
            text-align: left;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="<%= Page.ResolveClientUrl("~/Content/RunQueryBuilder.css") %>" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TopRightMenuRegion" runat="Server">
    <dx:ShowQueryBuilderButtonControl ID="showQueryBuilderButton" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxGridView ID="grid"
        Settings-HorizontalScrollBarMode="Auto"
        SettingsBehavior-AllowSort="false"
        Styles-Cell-CssClass="textAlignLeft"
        ClientInstanceName="grid"
        Width="100%"
        runat="server"
        OnDataBound="grid_DataBound"
        DataSourceID="NorthwindDataSource">
        <SettingsBehavior AllowEllipsisInText="true"/>
        <SettingsResizing ColumnResizeMode="Control" />
    </dx:ASPxGridView>
    <asp:SqlDataSource ID="NorthwindDataSource" runat="server" OnInit="NorthwindDataSource_Init" />
</asp:Content>
