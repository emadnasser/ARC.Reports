<%@ Control Language="vb" AutoEventWireup="true" CodeFile="ContactsImageSlider.ascx.vb" Inherits="UserControls_ViewControls_ContactsImageSlider" %>
<dx:ASPxImageSlider ID="ImageSlider" runat="server" ShowImageArea="false" EnableTheming="False" CssClass="imageSlider" EnableViewState="false">
    <ItemThumbnailTemplate>
        <dx:ASPxImage ID="EditImage" runat="server" ImageUrl="~/Content/Images/Buttons/EditContactButton.png" CssClass="editButton" OnLoad="EditImage_Load">
            <ClientSideEvents Click="DevAV.Page.CustomerEmployeeButton_Click" />
        </dx:ASPxImage>
        <dx:ASPxImage ID="ThumbnailImage" runat="server" ImageUrl="<%#GetThumbnailImageUrl(Container)%>" Height="150" />
        <span><%#Container.EvalDataItem("FullName")%></span>
        <%#Container.EvalDataItem("Position")%><br />
        <%#Container.EvalDataItem("Address")%>
    </ItemThumbnailTemplate>
    <SettingsNavigationBar VisibleItemsCount="6" ThumbnailsNavigationButtonPosition="Outside" />
    <Styles>
        <Thumbnail ImageWidth="160px" ImageHeight="215px" BackColor="White" />
    </Styles>
</dx:ASPxImageSlider>