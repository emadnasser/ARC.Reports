<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FlowLayout.aspx.cs"
    Inherits="SiteMap_FlowLayout" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
       .CustomBottomMargin
       {
           margin-bottom: 2px;
       }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox SelectedIndex="1" ID="ddlFlowLayoutMaximumDisplayItems" runat="server"
        AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Caption="Display SubItems">
        <RootStyle CssClass="CustomBottomMargin"></RootStyle>
        <Items>
            <dx:ListEditItem Text="5" Value="5" />
            <dx:ListEditItem Text="10" Value="10" />
            <dx:ListEditItem Text="All" Value="20" />
        </Items>
    </dx:ASPxComboBox>
    <dx:ASPxSiteMapControl SkinID="None" ID="ASPxSiteMapControl1" BackColor="Transparent"
        runat="server" DataSourceID="ASPxSiteMapDataSource2" MaximumDisplayLevels="2"
        FlowLayoutLevel="1" Width="100%">
        <LevelProperties>
            <dx:LevelProperties Font-Bold="True" Font-Names="Arial" Font-Size="16px" ForeColor="#0505D6"
                NodeSpacing="13px">
                <ChildNodesPaddings PaddingBottom="0px" PaddingLeft="0px" PaddingTop="0px" />
                <NodePaddings Padding="0px" />
                <BorderBottom BorderStyle="None" />
            </dx:LevelProperties>
            <dx:LevelProperties Font-Names="Arial" Font-Size="11px" Font-Underline="False" ForeColor="#0505D6"
                Wrap="True">
            </dx:LevelProperties>
        </LevelProperties>
        <LinkStyle Color="#0000DE" VisitedColor="#683399">
            <Font Underline="True"></Font>
        </LinkStyle>
        <Border BorderStyle="None" />
        <Paddings PaddingBottom="29px" PaddingLeft="0px" PaddingRight="0px" PaddingTop="26px" />
    </dx:ASPxSiteMapControl>
    <dx:ASPxSiteMapDataSource ID="ASPxSiteMapDataSource2" runat="server" SiteMapFileName="~/App_Data/SiteMap/FlowLayout.sitemap" />
</asp:Content>
