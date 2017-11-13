<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AdditionalControls.aspx.cs"
    Inherits="Miscellaneous_AdditionalControls" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
        <table>
            <tr>
                <td colspan="2">
                    <dx:ASPxResourceNavigator runat="server" ID="ASPxResourceNavigator1" MasterControlID="ASPxScheduler1" style="margin-left: -6px" Width="200px">
                    </dx:ASPxResourceNavigator>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 170px">
                    <dx:ASPxViewNavigator runat="server" ID="ASPxViewNavigator1" MasterControlID="ASPxScheduler1" />
                </td>
                <td>
                    <dx:ASPxViewVisibleInterval ID="ASPxViewVisibleInterval1" runat="server" MasterControlID="ASPxScheduler1">
                    </dx:ASPxViewVisibleInterval>
                </td>
            </tr>
        </table>
        <table class="OptionsTable" style="width: 100%; margin-top: 10px">
            <tr>
                <td>
                    <table>
                        <tr>
                            <td>
                                <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="Day"
                                    GroupType="Date" AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
                                    <ResourceNavigator EnableIncreaseDecrease="false" />
                                    <Views>
                                        <DayView ResourcesPerPage="1">
                                            <DayViewStyles ScrollAreaHeight="400px" />
                                        </DayView>
                                        <WorkWeekView ResourcesPerPage="1">
                                            <WorkWeekViewStyles ScrollAreaHeight="400px" />
                                        </WorkWeekView>
                                        <FullWeekView Enabled="true" ResourcesPerPage="2">
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
                                    <OptionsBehavior ShowViewNavigator="False" ShowViewSelector="False" ShowViewVisibleInterval="False" />
                                    <ResourceNavigator Visibility="Never" />
                                    <Storage EnableReminders="false">
                                    </Storage>
                                </dx:ASPxScheduler>
                            </td>
                        </tr>
                    </table>
                </td>
                <td style="vertical-align: top;">
                    <div style="padding-left: 40px;">
                        <dx:ASPxViewSelector runat="server" ID="ASPxViewSelector1" MasterControlID="ASPxScheduler1"
                            ButtonsRepeatDirection="Vertical">
                            <Styles ButtonSpacing="2px">
                                <ControlStyle BackColor="Transparent">
                                    <BackgroundImage ImageUrl="None" />
                                    <Paddings Padding="0px" PaddingBottom="0px" />
                                </ControlStyle>
                            </Styles>
                        </dx:ASPxViewSelector>
                    </div>
                    <br />
                    <dx:ASPxDateNavigator Width="240px" runat="server" ID="ASPxDateNavigator1" MasterControlID="ASPxScheduler1">
                        <Properties DayNameFormat="FirstLetter" />
                    </dx:ASPxDateNavigator>
                </td>
            </tr>
        </table>
    <demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
    <ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
        EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
    <ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>
