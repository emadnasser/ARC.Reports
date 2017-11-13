<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PostbackMode.aspx.cs"
    Inherits="OperationModes_PostbackMode" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" EnableCallBacks="False" Width="100%" GroupType="Resource"
        ActiveViewType="Day" AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
        <ResourceNavigator EnableIncreaseDecrease="false" />
        <Views>
            <DayView ResourcesPerPage="1">
                <DayViewStyles ScrollAreaHeight="400px" />
            </DayView>
            <WorkWeekView ResourcesPerPage="1">
                <WorkWeekViewStyles ScrollAreaHeight="400px" />
            </WorkWeekView>
            <FullWeekView ResourcesPerPage="1" Enabled="true">
                <FullWeekViewStyles ScrollAreaHeight="400px" />
            </FullWeekView>
            <WeekView Enabled="false" />
            <MonthView ResourcesPerPage="1">
                <MonthViewStyles>
                    <DateCellBody Height="100px" />
                </MonthViewStyles>
            </MonthView>
            <TimelineView ResourcesPerPage="1">
                <TimelineViewStyles>
                    <TimelineCellBody Height="500px" />
                </TimelineViewStyles>
            </TimelineView>
        </Views>
        <Storage EnableReminders="false" />
    </dx:ASPxScheduler>
    <demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
    <ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
        EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
    <ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>
