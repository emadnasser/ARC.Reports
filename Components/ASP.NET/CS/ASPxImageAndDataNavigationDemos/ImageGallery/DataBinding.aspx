<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.cs"
    Inherits="ImageGallery_DataBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <asp:XmlDataSource ID="xmlImages" runat="server" DataFile="~/App_Data/ImageGallery/cities.xml"
        XPath="//items/*"></asp:XmlDataSource>
    <dx:ASPxImageGallery ID="imageGallery" runat="server"  ClientInstanceName="imageGallery" DataSourceID="xmlImages" FullscreenViewerThumbnailUrlField="ThumbnailUrl" ThumbnailUrlField="MediumImageUrl" EnableViewState="False">
    </dx:ASPxImageGallery>
</asp:Content>
