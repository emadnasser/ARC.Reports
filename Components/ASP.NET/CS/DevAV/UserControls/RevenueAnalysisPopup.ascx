<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RevenueAnalysisPopup.ascx.cs" Inherits="UserControls_RevenueAnalysisPopup" %>
<dx:ASPxPopupControl ID="RevenueAnalysisPopup" ClientInstanceName="revenueAnalysisPopup" runat="server" Width="960" Height="430" CssClass="revenuePopup" HeaderText="Revenue Analysis"
    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter"
    ShowFooter="True" AllowDragging="true" DragElement="Header" PopupAnimationType="Fade" Modal="true" CloseAction="None" CloseOnEscape="true" ShowCloseButton="False">
    <FooterTemplate>
        <dx:ASPxButton ID="RevenueAnalysisCloseButton" runat="server" Text="Close" AutoPostBack="false" UseSubmitBehavior="False">
            <ClientSideEvents Click="DevAV.RevenueAnalysisCloseButton_Click" />
        </dx:ASPxButton>
    </FooterTemplate>
    <ClientSideEvents Shown="DevAV.RevenueAnalysisPopup_Shown" CloseUp="DevAV.RevenueAnalysisPopup_CloseUp" />
</dx:ASPxPopupControl>
<%--TODO rename revenuePopup revenueAnalysisPopup--%>
