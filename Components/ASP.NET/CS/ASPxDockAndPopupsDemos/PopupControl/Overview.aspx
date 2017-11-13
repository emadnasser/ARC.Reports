<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
    <dx:ASPxPopupControl ID="ASPxPopupControl1" PopupElementID="popupArea" HeaderText="Area of Countries" CloseAction="CloseButton" AllowDragging="true" ShowOnPageLoad="true" runat="server">
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupContent" runat="server">
                <dx:ASPxImage ImageUrl="~/PopupControl/Images/CountriesArea.png" ID="ASPxImage1" runat="server" />
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    <div id="popupArea" style="height: 300px;">Click here to invoke a popup window</div>
</asp:Content>
