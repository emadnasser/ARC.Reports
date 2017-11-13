<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomAppointments.aspx.cs"
    Inherits="Customization_CustomAppointments" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Appointment Display Options">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <table class="OptionsTable">
                    <tr >
                        <td>
                            <dx:ASPxLabel ID="lblStartTime" runat="server" AssociatedControlID="cbStartTime"
                                Text="Start Time:">
                            </dx:ASPxLabel>
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbStartTime" runat="server" Width="90px" SelectedIndex="0" ValueType="System.Int32">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { schedulerClientControl1.Refresh(); }" />
                                <Items>
                                    <dx:ListEditItem Text="Auto" Value="0" />
                                    <dx:ListEditItem Text="Always" Value="1" />
                                    <dx:ListEditItem Text="Never" Value="2" />
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                        <td>
                            <dx:ASPxLabel ID="lblStatus" runat="server" Text="Status:" AssociatedControlID="cbStatus" />
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbStatus" runat="server" Width="90px" SelectedIndex="1" ValueType="System.Int32">
                                <Items>
                                    <dx:ListEditItem Text="Never" Value="0" />
                                    <dx:ListEditItem Text="Time" Value="1" />
                                    <dx:ListEditItem Text="Bounds" Value="2" />
                                </Items>
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { schedulerClientControl1.Refresh();	}" />
                            </dx:ASPxComboBox>
                        </td>
                        <td>
                            <dx:ASPxLabel ID="lblContinueArrow" runat="server" Text="Continue Arrow:" AssociatedControlID="cbContinueArrow" />
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbContinueArrow" runat="server" Width="150px" SelectedIndex="2"
                                ValueType="System.Int32">
                                <Items>
                                    <dx:ListEditItem Text="Never" Value="0" />
                                    <dx:ListEditItem Text="Arrow" Value="1" />
                                    <dx:ListEditItem Text="ArrowWithText" Value="2" />
                                </Items>
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { schedulerClientControl1.Refresh();	}" />
                            </dx:ASPxComboBox>
                        </td>
                        <td>
                            <dx:ASPxCheckBox ID="chkRecurrence" runat="server" Text="Recurrence" Checked="True">
                                <ClientSideEvents CheckedChanged="function(s, e) { schedulerClientControl1.Refresh(); }" />
                            </dx:ASPxCheckBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxLabel ID="lblEndTime" runat="server" Text="End Time:" AssociatedControlID="cbEndTime" />
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbEndTime" runat="server" Width="90px" SelectedIndex="0" ValueType="System.Int32">
                                <Items>
                                    <dx:ListEditItem Text="Auto" Value="0" />
                                    <dx:ListEditItem Text="Always" Value="1" />
                                    <dx:ListEditItem Text="Never" Value="2" />
                                </Items>
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { schedulerClientControl1.Refresh(); }" />
                            </dx:ASPxComboBox>
                        </td>
                        <td>
                            <dx:ASPxLabel ID="lblTime" runat="server" Text="Time:" AssociatedControlID="cbTime" />
                        </td>
                        <td class="edit">
                            <dx:ASPxComboBox ID="cbTime" runat="server" Width="90px" SelectedIndex="0" ValueType="System.Int32">
                                <Items>
                                    <dx:ListEditItem Text="Auto" Value="0" />
                                    <dx:ListEditItem Text="Clock" Value="1" />
                                    <dx:ListEditItem Text="Text" Value="2" />
                                </Items>
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { schedulerClientControl1.Refresh(); }" />
                            </dx:ASPxComboBox>
                        </td>
                        <td>
                            <dx:ASPxLabel ID="lblImages" runat="server" Text="Images:" AssociatedControlID="rbListCustomImages" />
                        </td>
                        <td>
                            <dx:ASPxComboBox ID="rbListCustomImages" runat="server" Width="150px" ValueType="System.Int32"
                                SelectedIndex="0">
                                <ClientSideEvents SelectedIndexChanged="function(s, e) { schedulerClientControl1.Refresh(); }" />
                                <Items>
                                    <dx:ListEditItem Text="Default" Value="0" />
                                    <dx:ListEditItem Text="External" Value="1" />
                                    <dx:ListEditItem Text="Custom" Value="2" />
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                        <td>
                            <dx:ASPxCheckBox ID="chkCustomText" runat="server" Text="Custom text" Wrap="false">
                                <ClientSideEvents CheckedChanged="function(s, e) { schedulerClientControl1.Refresh(); }" />
                            </dx:ASPxCheckBox>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <br />
    <dx:ASPxScheduler ID="ASPxScheduler1" ClientInstanceName="schedulerClientControl1"
        runat="server" Width="100%" ActiveViewType="Day" OnInitAppointmentDisplayText="ASPxSchedulerControl1_InitAppointmentDisplayText"
        OnInitAppointmentImages="ASPxSchedulerControl1_InitAppointmentImages" OnActiveViewChanged="ASPxScheduler1_ActiveViewChanged"
        AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource" GroupType="Resource">
        <ResourceNavigator EnableIncreaseDecrease="false" />
        <Views>
            <DayView ResourcesPerPage="1" />
            <WorkWeekView ResourcesPerPage="1" />
            <FullWeekView Enabled="true" ResourcesPerPage="1" />
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
