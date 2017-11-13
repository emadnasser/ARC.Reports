<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DateHeaderTemplate.aspx.cs"
    Inherits="Templates_DateHeaderTemplate" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" ActiveViewType="Day" GroupType="Date"
        AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource"
        ClientInstanceName="ASPxClientScheduler1">
        <Views>
            <DayView ResourcesPerPage="2" DayCount="2">
                <Templates>
                    <DateHeaderTemplate>
                        <table class="OptionsTable">
                            <tr>
                                <td>
                                    <b>
                                        <%# Container.Interval.Start.Day%></b>
                                </td>
                                <td style="width: 100%; text-align: center;">
                                    <%# System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(Container.Interval.Start.DayOfWeek) %>
                                </td>
                            </tr>
                        </table>
                    </DateHeaderTemplate>
                </Templates>
            </DayView>
            <WorkWeekView Enabled="False" />
            <WeekView Enabled="False" />
            <MonthView Enabled="False" />
            <TimelineView Enabled="False" />
        </Views>
        <OptionsBehavior ShowViewSelector="False" />
        <ResourceNavigator Visibility="Never" />
        <Storage EnableReminders="false" />
    </dx:ASPxScheduler>
    <demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
    <ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
        EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
    <ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>
