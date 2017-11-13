<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Categorized.aspx.cs"
    Inherits="SiteMap_CompositeSiteMap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxSiteMapControl EnableTheming="False" ID="ASPxSiteMapControl1"
        runat="server" DataSourceID="ASPxSiteMapDataSource1" Categorized="True" RepeatDirection="Horizontal"
        CssFilePath="~/SiteMap/Resources/MultiColumnCategorized/styles.css" CssPostfix="MultiColumn"
        Width="100%">
        <Columns>
            <dx:SiteMapColumn />
            <dx:SiteMapColumn />
            <dx:SiteMapColumn />
            <dx:SiteMapColumn />
        </Columns>
        <LevelProperties>
            <dx:LevelProperties>
                <ChildNodesPaddings PaddingBottom="13px" PaddingTop="0px" />
            </dx:LevelProperties>
            <dx:LevelProperties BulletStyle="None">
                <ChildNodesPaddings PaddingLeft="0px" PaddingTop="9px" />
            </dx:LevelProperties>
            <dx:LevelProperties ImageSpacing="4px" NodeSpacing="4px" VerticalAlign="Middle">
                <Image Url="~/SiteMap/Resources/MultiColumnCategorized/csmBullet.gif" Width="3px" />
            </dx:LevelProperties>
        </LevelProperties>
        <Paddings Padding="21px" PaddingBottom="8px" />
        <ColumnSeparatorStyle Width="10px">
            <Paddings Padding="0px" />
        </ColumnSeparatorStyle>
    </dx:ASPxSiteMapControl>
    <dx:ASPxSiteMapDataSource ID="ASPxSiteMapDataSource1" runat="server" SiteMapFileName="~/App_Data/SiteMap/CategorizedData.sitemap" />
</asp:Content>
