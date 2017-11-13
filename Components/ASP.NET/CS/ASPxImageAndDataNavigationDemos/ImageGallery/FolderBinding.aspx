<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FolderBinding.aspx.cs"
    Inherits="ImageGallery_FolderBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox ID="cbSelectFolder" runat="server" AutoPostBack="True" SelectedIndex="0" Style="margin-top: 4px; margin-bottom: 11px;" Caption="Select Folder">
        <CaptionSettings Position="Top" />
        <Items>
            <dx:ListEditItem Selected="True" Text="Landscapes" Value="~\Content\Images\landscapes\" />
            <dx:ListEditItem Text="People" Value="~\Content\Images\people\" />
            <dx:ListEditItem Text="Photo Gallery" Value="~\Content\Images\photo_gallery\" />
        </Items>
    </dx:ASPxComboBox>
    <dx:ASPxCheckBox ID="chWatermark" runat="server" Text="Apply watermark" AutoPostBack="true" CssClass="OptionsBottomMargin"></dx:ASPxCheckBox>
    <dx:ASPxImageGallery ID="imageGallery" runat="server">
    </dx:ASPxImageGallery>
</asp:Content>
