<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Templates.aspx.cs"
    Inherits="ImageGallery_DataBinding" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
    <link type="text/css" rel="stylesheet" href="css/Templates.css" />
    <%--start highlighted block--%>
    <script type="text/javascript">
        function ShowViewer(index) {
            imageGallery.ShowFullscreenViewer(index);
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <asp:XmlDataSource ID="xmlImages" runat="server" DataFile="~/App_Data/Contacts.xml"
        XPath="//Contacts/*"></asp:XmlDataSource>
    <dx:ASPxImageGallery ID="imageGallery" runat="server" DataSourceID="xmlImages"
        ImageUrlField="LargePhotoUrl" ThumbnailUrlField="PhotoUrl" TextField="Name"
        Theme="Metropolis" EnableViewState="False" ClientInstanceName="imageGallery" CssClass="customGallery">
        <PagerSettings EndlessPagingMode="OnClick" />
        <settingstablelayout rowsperpage="2" />
        <SettingsFullscreenViewer NavigationBarVisibility="None" ShowPlayPauseButton="False" />
        <ItemTextTemplate>
            <div class="item">
                <div class="item_text"><a onclick="javascript:ShowViewer(<%# Container.ItemIndex %>);"
                    href="#dxig<%# Container.ItemIndex %>" title="Show Details..."><%# Container.EvalDataItem("Name") %></a></div>
                <div class="item_email"><%# Container.EvalDataItem("Email") %></div>
            </div>
        </ItemTextTemplate>
         <FullscreenViewerItemTextTemplate>
            <div class="details">
                <div class="details_header"><%# Container.EvalDataItem("Name") %></div>
                <div class="details_text"><%# Container.EvalDataItem("Email") %></div>
                <div class="details_text"><%# Container.EvalDataItem("Phone") %></div>
            </div>
        </FullscreenViewerItemTextTemplate>
    </dx:ASPxImageGallery>
</asp:Content>
