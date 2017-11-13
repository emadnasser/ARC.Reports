<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ResponsiveLayoutPage.aspx.cs" Inherits="ImageGallery_ResponsiveLayoutPage" EnableViewState="false" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASPxImageGallery Fullscreen demo - Responsive Layout - ASP.NET AJAX ImageGallery Control</title>
    <meta id="IECompatibilityMeta" http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, user-scalable=no, maximum-scale=1.0, minimum-scale=1.0" />
    <meta name="apple-mobile-web-app-capable" content="yes" />
    <style type="text/css">
        body, html {
            margin: 0;
            padding: 0;
            font-family: 'Segoe UI Light', 'HelveticaNeue-Light', Tahoma, Geneva, sans-serif;
            background-color: white;
        }
        h1 {
            font-weight: normal;
            font-size: 38px;
            margin: 0;
            padding: 10px;
            padding-top: 26px;
        }
        .container {
            margin: 0 auto;
            align-content: center;
        }
        .topmenu {
            background-image: url('images/sky_bk.jpg');
            background-color: #162747;
            color: #ffffff;
            padding: 0px;
        }
        .menu {
            font-size: 18pt;
            background-color: rgba(0, 1, 9, 0.5);
            padding: 10px;
            padding-top: 6px;
            padding-bottom: 8px;
        }
        .menu > a {
            color: #fff;
            cursor: pointer;
            margin-right: 12px;
            text-decoration: none;
        }
        .content {
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="topmenu">
                <h1>ASPxImageGallery</h1>
                <div class="menu">
                    <a href="javascript:void(1);">Home</a>
                    <a href="javascript:void(2);">Portfolio</a>
                    <a href="javascript:void(3);">Contacts</a>
                </div>
            </div>
            <div class="content">
                <asp:XmlDataSource ID="xmlImages" runat="server" DataFile="~/App_Data/ImageGallery/cities.xml" XPath="//items/*"></asp:XmlDataSource>
                <dx:ASPxImageGallery ID="imageGallery" runat="server" Layout="Flow" EnableTheming="false"
                    ThumbnailWidth="138" ThumbnailHeight="138" ClientInstanceName="imageGallery"
                    DataSourceID="xmlImages" ImageUrlField="ImageUrl" FullscreenViewerThumbnailUrlField="ThumbnailUrl" 
                    ThumbnailUrlField="MediumImageUrl" TextVisibility="None">
                    <SettingsFlowLayout ItemsPerPage="30" />
                    <PagerSettings EndlessPagingMode="OnScroll" />
                    <Paddings Padding="0"></Paddings>
                </dx:ASPxImageGallery>
            </div>
        </div>
    </form>
</body>
</html>
