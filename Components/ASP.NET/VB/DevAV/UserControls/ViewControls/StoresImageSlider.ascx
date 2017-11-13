<%@ Control Language="vb" AutoEventWireup="true" CodeFile="StoresImageSlider.ascx.vb" Inherits="UserControls_ViewControls_StoresImageSlider" %>
<dx:ASPxImageSlider ID="ImageSlider" runat="server" ShowImageArea="false" EnableTheming="False" CssClass="imageSlider" EnableViewState="false">
    <ItemThumbnailTemplate>
        <div>
            <dx:ASPxImage ID="ThumbnailImage" runat="server" ImageUrl="<%#GetThumbnailImageUrl(Container)%>" Height="150" />
            <span><%#Container.EvalDataItem("Crest.CityName")%></span>
            <%#Container.EvalDataItem("Address.Line")%><br />
            <%#Container.EvalDataItem("Address.City").ToString() & " " & Container.EvalDataItem("Address.ZipCode")%>
        </div>
    </ItemThumbnailTemplate>
    <SettingsNavigationBar VisibleItemsCount="6" ThumbnailsNavigationButtonPosition="Outside" />
    <Styles>
        <Thumbnail ImageWidth="160px" ImageHeight="215px" BackColor="White" />
    </Styles>
</dx:ASPxImageSlider>