<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Overview.aspx.cs" Inherits="Overview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="650px" ActiveViewType="Day"
        AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource" GroupType="Resource">
        <OptionsView>
            <ResourceHeaders RotateCaption="false" />
        </OptionsView>
        <Storage>
            <Appointments AutoRetrieveId="true">
                <Mappings
                    AppointmentId="ID"
                    Start="StartTime"
                    End="EndTime"
                    Subject="Subject"
                    Description="Description"
                    Location="Location"
                    AllDay="AllDay"
                    Type="EventType"
                    RecurrenceInfo="RecurrenceInfo"
                    ReminderInfo="ReminderInfo"
                    Label="Label"
                    Status="Status"
                    ResourceId="MedicId" />
            </Appointments>
            <Resources>
                <Mappings
                    Image="PhotoBytes"
                    Caption="DisplayName"
                    ResourceId="ID" />
            </Resources>
        </Storage>
        <Views>
            <DayView ResourcesPerPage="3" VisibleTime-Start="07:00" VisibleTime-End="19:00"/>
            <WorkWeekView ResourcesPerPage="1" VisibleTime-Start="07:00" VisibleTime-End="19:00"/>
            <WeekView ResourcesPerPage="1"/>
            <MonthView ResourcesPerPage="1"  AppointmentDisplayOptions-ShowRecurrence="true"/>
            <TimelineView ResourcesPerPage="2" IntervalCount="5">
                <TimelineViewStyles VerticalResourceHeader-Width="150px"/>
            </TimelineView>
        </Views>
    </dx:ASPxScheduler>
    <demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
    <ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
        EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
    <ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>
