<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomImageViewer.aspx.cs" Inherits="ImageGallery_CustomImageViewer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
    <link type="text/css" rel="stylesheet" href="css/CustomImageViewer.css" />
<%--start highlighted block--%>
    <script>
        var imageIndex = 0;
        function OnFullscreenViewerShowing(s, e) {
            imageIndex = e.index;
            cb.PerformCallback(imageIndex);
            popup.Show();
        }
        function OnImageInit(s, e) {
            ASPxClientUtils.AttachEventToElement(s.GetMainElement(), "load", function () {
                lp.Hide();
                popup.UpdatePosition();
            });
        }
        function OnBeginCallback(s, e) {
            lp.Show();
        }
        function OnCallbackComplete(s, e) {
            largeImg.SetImageUrl(e.result);
            document.getElementById("text").innerHTML = imageIndex + 1 + "/" + GetCount();
        }
        function OnPrevBtnClick(e) {
            PrevImage();
            ASPxClientUtils.PreventEvent(e);
        }
        function OnNextBtnClick(e) {
            NextImage();
            ASPxClientUtils.PreventEvent(e);
        }
        function NextImage() {
            imageIndex++;
            if (imageIndex == GetCount())
                imageIndex = 0;
            cb.PerformCallback(imageIndex);
        }
        function PrevImage() {
            imageIndex--;
            if (imageIndex < 0)
                imageIndex = GetCount() - 1;
            cb.PerformCallback(imageIndex);
        }
        function GetCount() {
            return imageGallery.cpCount;
        }
    </script>
<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCallback ID="cb" ClientInstanceName="cb" runat="server" OnCallback="cb_Callback">
        <ClientSideEvents CallbackComplete="OnCallbackComplete" BeginCallback="OnBeginCallback" />
    </dx:ASPxCallback>
    <dx:ASPxPopupControl ID="popup" ClientInstanceName="popup" runat="server" Modal="true" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowCloseButton="false" ShowHeader="false" EnableTheming="false">
        <HeaderStyle HorizontalAlign="Center" />
        <ContentCollection>
            <dx:PopupControlContentControl>
                <dx:ASPxLoadingPanel ClientInstanceName="lp" runat="server" ContainerElementID="largeImg" EnableTheming="true"></dx:ASPxLoadingPanel>
                <div class="btn prev" onclick="OnPrevBtnClick(event)">
                </div>
                <div class="btn next" onclick="OnNextBtnClick(event)">
                </div>
                <dx:ASPxImage ID="largeImg" ClientInstanceName="largeImg" runat="server" CssClass="largeImg">
                    <ClientSideEvents Init="OnImageInit" Click="NextImage" />
                </dx:ASPxImage>
                <div id="text">123123123123</div>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    <dx:ASPxImageGallery ID="imageGallery" ClientInstanceName="imageGallery" runat="server" OnDataBound="imageGallery_DataBound" TextVisibility="None" EnableViewState="false">
        <SettingsFullscreenViewer Visible="false" />
        <SettingsFolder ImageCacheFolder="~\Thumb\" ImageSourceFolder="~\Content\Images\landscapes\" />
        <ClientSideEvents FullscreenViewerShowing="OnFullscreenViewerShowing" />
    </dx:ASPxImageGallery>
</asp:Content>
