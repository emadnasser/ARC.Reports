<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="XPOBoundMode.aspx.cs"
    Inherits="DataBinding_XPOBoundMode" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" OnAppointmentRowInserted="ASPxScheduler1_AppointmentRowInserted">
        <Views>
            <FullWeekView Enabled="true"/>
            <WeekView Enabled="false"/>
        </Views>
        <Storage EnableReminders="false"/>
    </dx:ASPxScheduler>
    <dx:XpoDataSource ID="appointmentDataSource" runat="server" TypeName="Task"/>
    <dx:XpoDataSource ID="resourceDataSource" runat="server" TypeName="Employee" />
</asp:Content>
