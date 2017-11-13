<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DateNavigator.aspx.cs"
    Inherits="Miscellaneous_DateNavigator" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Date Navigator Options">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <table class="OptionsTable">
                    <tr>
                        <td>
                            <dx:ASPxCheckBox ID="chkBoldAppointmentDates" runat="server" Text="Bold&nbsp;Appointment&nbsp;Dates"
                                Checked="True" Wrap="False">
                                <ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                            </dx:ASPxCheckBox>
                        </td>
                        <td>
                            <dx:ASPxCheckBox ID="chkShowTodayButton" runat="server" Text="Show&nbsp;Today&nbsp;Button"
                                Checked="True" Wrap="False">
                                <ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                            </dx:ASPxCheckBox>
                        </td>
                        <td>
                            <dx:ASPxCheckBox ID="chkShowWeekNumbers" runat="server" Text="Show&nbsp;Week&nbsp;Numbers"
                                Checked="True" Wrap="False">
                                <ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                            </dx:ASPxCheckBox>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <br />
    <table style="width: 100%">
        <tr>
            <td style="width: 100%">
                <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ClientInstanceName="ASPxClientScheduler1" GroupType="Resource"
                    AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
                    <ResourceNavigator EnableIncreaseDecrease="false" />
                    <Views>
                        <DayView ResourcesPerPage="1">
                            <DayViewStyles ScrollAreaHeight="400px" />
                        </DayView>
                        <WorkWeekView ResourcesPerPage="1">
                            <TimeRulers>
                                <dx:TimeRuler TimeZoneId="Greenwich" />
                            </TimeRulers>
                            <WorkWeekViewStyles ScrollAreaHeight="400px" />
                        </WorkWeekView>
                        <FullWeekView Enabled="true" ResourcesPerPage="1">
                            <FullWeekViewStyles ScrollAreaHeight="400px" />
                        </FullWeekView>
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
                    <OptionsBehavior ShowViewNavigator="False" ShowViewSelector="False" />
                    <Storage EnableReminders="false"/>
                </dx:ASPxScheduler>
            </td>
            <td style="vertical-align: top">
                <dx:ASPxDateNavigator runat="server" ID="ASPxDateNavigator1" MasterControlID="ASPxScheduler1"
                    Width="220px">
                    <Properties Rows="2" DayNameFormat="FirstLetter" />
                </dx:ASPxDateNavigator>
            </td>
        </tr>
    </table>
    <demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
    <ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
        EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
    <ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>
