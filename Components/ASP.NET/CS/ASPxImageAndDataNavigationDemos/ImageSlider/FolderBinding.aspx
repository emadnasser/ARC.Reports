<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FolderBinding.aspx.cs"
    Inherits="ImageSlider_FolderBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox ID="cbSelectFolder" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cbSelectFolder_SelectedIndexChanged"
        SelectedIndex="0" Caption="Select Folder">
        <RootStyle CssClass="OptionsBottomMargin"></RootStyle>
        <Items>
            <dx:ListEditItem Selected="True" Text="Landscapes" Value="~\Content\Images\landscapes\" />
            <dx:ListEditItem Text="People" Value="~\Content\Images\people\" />
            <dx:ListEditItem Text="Photo Gallery" Value="~\Content\Images\photo_gallery\" />
        </Items>
    </dx:ASPxComboBox>
    
    <dx:ASPxImageSlider ID="ASPxImageSlider1" runat="server" EnableTheming="false">
    </dx:ASPxImageSlider>
</asp:Content>
