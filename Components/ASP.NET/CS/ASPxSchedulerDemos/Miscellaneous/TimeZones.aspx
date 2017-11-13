<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TimeZones.aspx.cs"
    Inherits="Miscellaneous_TimeZones" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Choose the Client Time Zone">
        <Panelcollection>
            <dx:PanelContent runat="server">
               <table class="OptionsTable">
                    <tr>
                        <td class="edit">
                             <dx:ASPxTimeZoneEdit ID="timeZoneEdit1" runat="server" MasterControlID="ASPxScheduler1"
                                Width="350px" />
                        </td>                        
                     </tr>
                </table>                
            </dx:PanelContent>
        </Panelcollection>
    </dx:ASPxRoundPanel>
    <br />
    <dx:ASPxScheduler ID="ASPxScheduler1" ClientInstanceName="ASPxClientScheduler1" runat="server" Width="100%" ActiveViewType="Workweek" GroupType="Resource"
        OnAfterExecuteCallbackCommand="ASPxScheduler1_AfterExecuteCallbackCommand" AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
        <ResourceNavigator EnableIncreaseDecrease="false" />
        <Views>
            <DayView ResourcesPerPage="1">
                <TimeRulers>
                    <dx:TimeRuler TimeZoneId="Greenwich Standard Time" Caption="Greenwich" ShowMinutes="True" />
                    <dx:TimeRuler Caption="Server" ShowMinutes="True" />
                    <dx:TimeRuler ShowMinutes="True" />
                </TimeRulers>
            </DayView>
            <WorkWeekView ResourcesPerPage="1">
                <TimeRulers>
                    <dx:TimeRuler TimeZoneId="Greenwich Standard Time" Caption="Greenwich" ShowMinutes="True" />
                    <dx:TimeRuler Caption="Server" ShowMinutes="True" />
                    <dx:TimeRuler ShowMinutes="True" />
                </TimeRulers>
            </WorkWeekView>
            <FullWeekView Enabled="true" ResourcesPerPage="1">
                 <TimeRulers>
                    <dx:TimeRuler TimeZoneId="Greenwich Standard Time" Caption="Greenwich" ShowMinutes="True" />
                    <dx:TimeRuler Caption="Server" ShowMinutes="True" />
                    <dx:TimeRuler ShowMinutes="True" />
                </TimeRulers>
            </FullWeekView>
            <WeekView Enabled="false" />
            <MonthView ResourcesPerPage="1" WeekCount="4" ShowWeekend="false">
                <AppointmentDisplayOptions ShowRecurrence="true" />
                <MonthViewStyles>
                    <DateCellBody Height="100px" />
                </MonthViewStyles>
            </MonthView>
            <TimelineView ResourcesPerPage="1">
                <Scales>
                    <dx:TimeScaleMonth />
                    <dx:TimeScaleDay />
                </Scales>
                <TimelineViewStyles>
                    <TimelineCellBody Height="300px" />
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
