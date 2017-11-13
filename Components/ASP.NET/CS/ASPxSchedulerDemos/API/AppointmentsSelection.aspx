<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AppointmentsSelection.aspx.cs"
    Inherits="ClientSide_AppointmentSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <script type="text/javascript">
    // <![CDATA[
        function OnAppointmentsSelectionChanged(scheduler, appointmentIds) {
            if(appointmentIds != null && appointmentIds.length == 1) {
                scheduler.GetAppointmentProperties(appointmentIds[0], 'Subject;Location;Start;End;Description;ContactInfo', OnGetAppointmentProps);
            } else
                OnGetAppointmentProps(null);
        }
        function OnGetAppointmentProps(values) {
            var subj = document.getElementById('aptsubj');
            var loc = document.getElementById('aptloc');
            var start = document.getElementById('aptstart');
            var end = document.getElementById('aptend');
            var desc = document.getElementById('aptdesc');
            var contact = document.getElementById('aptcontact');
            if(values != null) {
                subj.innerHTML = values[0];
                loc.innerHTML = values[1];
                var formatter = new ASPx.DateFormatter();
                formatter.SetFormatString("dd.MM.yyyy HH:mm");
                start.innerHTML = formatter.Format(values[2]);
                end.innerHTML = formatter.Format(values[3]);
                desc.innerHTML = values[4];
                contact.innerHTML = (values[5] == null) ? "" : values[5];
            } else {
                var emptyStr = '&nbsp';
                subj.innerHTML = emptyStr;
                loc.innerHTML = emptyStr;
                start.innerHTML = emptyStr;
                end.innerHTML = emptyStr;
                desc.innerHTML = emptyStr;
                contact.innerHTML = emptyStr;
            }
        }
    // ]]> 
    </script>
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="Timeline" GroupType="Resource"
        AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource" ClientInstanceName="ASPxClientScheduler1">
        <ResourceNavigator EnableIncreaseDecrease="false" />
        <Views>
            <DayView Enabled="false" />
            <WorkWeekView Enabled="false" />
            <WeekView Enabled="false" />
            <FullWeekView Enabled="true" ResourcesPerPage="1"/>
            <MonthView Enabled="false" />
            <TimelineView ResourcesPerPage="1">
                <Scales>
                    <dx:TimeScaleMonth />
                    <dx:TimeScaleDay />
                </Scales>
                <TimelineViewStyles>
                    <TimelineCellBody Height="250px" />
                </TimelineViewStyles>
            </TimelineView>
        </Views>
        <ClientSideEvents AppointmentsSelectionChanged="function(s, e) { OnAppointmentsSelectionChanged(s, e.appointmentIds); }" />
        <Storage EnableReminders="false">
            <Appointments>
                <CustomFieldMappings>
                    <dx:ASPxAppointmentCustomFieldMapping Member="ContactInfo" Name="ContactInfo" />
                </CustomFieldMappings>
            </Appointments>
        </Storage>
    </dx:ASPxScheduler>
    <demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
    <ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
        EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
    <ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
    <br />
    <dx:ASPxRoundPanel ID="pnlAptSelection" runat="server" Width="100%" HeaderText="Appointment Details">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <div>
                    <table class="OptionsTable">
                        <tr>
                            <td style="width: 20%">
                                Subject:
                            </td>
                            <td style="width: 80%">
                                <div id="aptsubj"></div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Location:
                            </td>
                            <td>
                                <div id="aptloc"></div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Start time:
                            </td>
                            <td>
                                <div id="aptstart"></div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                End time:
                            </td>
                            <td>
                                <div id="aptend"></div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Description:
                            </td>
                            <td>
                                <div id="aptdesc"></div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Contact information:
                            </td>
                            <td>
                                <div id="aptcontact"></div>
                            </td>
                        </tr>
                    </table>
                </div>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
</asp:Content>
