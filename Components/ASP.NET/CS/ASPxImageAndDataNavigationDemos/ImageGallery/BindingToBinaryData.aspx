<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BindingToBinaryData.aspx.cs"
    Inherits="ImageGallery_BinaryData" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxImageGallery ID="imageGallery" runat="server" DataSourceID="ImagesDataSource"
        EnableViewState="False" ImageContentBytesField="Picture" AllowPaging="False">
        <SettingsFolder ImageCacheFolder="~\Thumb\" />
        <SettingsFullscreenViewer NavigationBarVisibility="Always" />
    </dx:ASPxImageGallery>
    <ef:EntityDataSource ID="ImagesDataSource" runat="server" ContextTypeName="BinaryImagesContext" EntitySetName="BinaryImages" />
</asp:Content>
