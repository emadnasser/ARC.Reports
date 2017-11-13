<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ListBoundMode.aspx.cs"
    Inherits="DataBinding_ListBoundMode" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server">
        <Views>
            <FullWeekView Enabled="true"/>
            <WeekView Enabled="false"/>
        </Views>
        <Storage EnableReminders="false">
            <Appointments AutoRetrieveId="true" />               
        </Storage>
    </dx:ASPxScheduler>
    <asp:ObjectDataSource ID="appointmentDataSource" runat="server" DataObjectTypeName="CustomEvent"
        TypeName="CustomEventDataSource" DeleteMethod="DeleteMethodHandler" SelectMethod="SelectMethodHandler"
        InsertMethod="InsertMethodHandler" UpdateMethod="UpdateMethodHandler" OnObjectCreated="appointmentsDataSource_ObjectCreated"/>
</asp:Content>
