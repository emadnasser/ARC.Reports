<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="LoadOnDemand.aspx.cs" Inherits="PopupControl_LoadOnDemand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="height: 130px">
        <dx:ASPxButton ID="ShowButton" runat="server" Text="Show Popup Window" AutoPostBack="False" />
    </div>
    <dx:ASPxPopupControl ID="PopupControl" runat="server" CloseAction="OuterMouseClick" LoadContentViaCallback="OnFirstShow"
                         PopupElementID="ShowButton" PopupVerticalAlign="Below" PopupHorizontalAlign="LeftSides" AllowDragging="True"
                         ShowFooter="True" Width="310px" Height="160px" HeaderText="Updatable content" ClientInstanceName="ClientPopupControl">
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl" runat="server">
                <div style="vertical-align:middle">
                    The content of this popup control was updated at<br /> <b> <%= DateTime.Now.ToLongTimeString() %></b>
                </div>
            </dx:PopupControlContentControl>
        </ContentCollection>
        <FooterTemplate>
                <dx:ASPxButton ID="UpdateButton" runat="server" Text="Update Content" AutoPostBack="False" style="margin: 6px 6px 6px 210px" 
                               ClientSideEvents-Click="function(s, e) { ClientPopupControl.PerformCallback(); }"/>
        </FooterTemplate>
    </dx:ASPxPopupControl>
</asp:Content>
