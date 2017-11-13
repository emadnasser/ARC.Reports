<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FullscreenSamplePage.aspx.cs" Inherits="ImageSlider_FullscreenSamplePage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fullscreen Mode - ASP.NET ImageSlider Control</title>
    <link href="css/FullscreenSample.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <div class="logo">
                <div class="text">Logo</div>
            </div>
            <div class="navigation">
                <div class="text">Home</div>
                <div class="text">News</div>
                <div class="text">Gallery</div>
                <div class="text">Contacts</div>
            </div>
        </div>
        <dx:ASPxImageSlider ID="imageSlider" runat="server" ImageSourceFolder="~\Content\Images\portraits\" Width="100%" Height="100%">
            <SettingsImageArea ImageSizeMode="FillAndCrop" NavigationButtonVisibility="Always" EnableLoopNavigation="true" />
            <SettingsNavigationBar Mode="Dots" ItemSpacing="0" />
        </dx:ASPxImageSlider>
    </form>
</body>
</html>
