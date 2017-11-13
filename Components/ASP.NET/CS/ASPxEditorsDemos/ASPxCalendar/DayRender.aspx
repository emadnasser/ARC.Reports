<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DayRender.aspx.cs"
    Inherits="ASPxCalendar_DayRender" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function ShowNotes(dateString) {
            ClientPopup.Hide();
            ClientCallback.PerformCallback(dateString);
        }
        function ClientCallback_CallbackComplete(s, e) {
            var parts = e.result.split("|");
            ClientPopup.SetHeaderText(parts[0]);
            ClientPopup.SetContentHTML(parts[1]);
            ClientPopup.Show();
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <p>
        Click a highlighted date
    </p>
    <div style="float: left">
        <dx:ASPxCalendar ID="ASPxCalendar1" runat="server" VisibleDate="2010-10-1" ReadOnly="True"
            EnableMonthNavigation="false" EnableYearNavigation="false" 
            OnDayCellInitialize="ASPxCalendar_DayCellInitialize"
            OnDayCellPrepared="ASPxCalendar_DayCellPrepared" />
    </div>
    <div id="popupAnchor" style="float: left; margin-left: 5px">
    </div>
    <dx:ASPxCallback ID="ASPxCallback1" runat="server" OnCallback="ASPxCallback1_Callback"
        ClientInstanceName="ClientCallback">
        <ClientSideEvents CallbackComplete="ClientCallback_CallbackComplete" />
    </dx:ASPxCallback>
    <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" Width="222px" ClientInstanceName="ClientPopup"
        PopupElementID="popupAnchor" PopupAction="None" CloseAction="CloseButton">
    </dx:ASPxPopupControl>
</asp:Content>
