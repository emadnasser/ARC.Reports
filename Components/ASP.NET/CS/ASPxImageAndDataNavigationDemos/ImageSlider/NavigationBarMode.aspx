<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="NavigationBarMode.aspx.cs" Inherits="ImageSlider_NavigationBarMode" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
    <link href="css/NavigationBarMode.css" rel="Stylesheet" type="text/css" />
    <style>
        .CustomBottomMargin 
        {
            margin-bottom: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox runat="server" ID="ddlItemCount" AutoPostBack="True" SelectedIndex="1" ValueType="System.Int32" Width="50" Caption="VisibleItemCount">
        <RootStyle CssClass="CustomBottomMargin"></RootStyle>
        <Items>
            <dx:ListEditItem Value="3" Text="3" />
            <dx:ListEditItem Value="5" Text="5" />
        </Items>
    </dx:ASPxComboBox>
    <dx:ASPxImageSlider ID="ImageSlider" runat="server" DataSourceID="xmlItems" EnableViewState="False" EnableTheming="False" ShowImageArea="false">
        <ItemThumbnailTemplate>
            <a class="url" href='<%# Container.EvalDataItem("Link") %>' target="_blank">
                <dx:ASPxImage runat="server" ImageUrl='<%# Container.EvalDataItem("ImageUrl") %>' AlternateText='<%# Container.EvalDataItem("Name") %>' ShowLoadingImage="true"></dx:ASPxImage>
                <span class="name"><%# Container.EvalDataItem("Name") %></span>
            </a>
        </ItemThumbnailTemplate>
        <SettingsBehavior ExtremeItemClickMode="Select" />
        <SettingsNavigationBar ThumbnailsModeNavigationButtonVisibility="Always" ThumbnailsNavigationButtonPosition="Outside" PagingMode="Single" />
    </dx:ASPxImageSlider>
    <asp:XmlDataSource ID="xmlItems" runat="server" DataFile="~/App_Data/ImageSlider/persons.xml"
        XPath="//items/*"></asp:XmlDataSource>
</asp:Content>
