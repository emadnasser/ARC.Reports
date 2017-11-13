<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CellAutoHeight.aspx.cs" Inherits="Miscellaneous_CellAutoHeight" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Demo Options">
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">
                <dx:ASPxRadioButtonList ID="rbCellAutoHeghtMode" runat="server" ValueType="System.String" 
                    SelectedIndex="1" RepeatDirection="Horizontal" TextWrap="False" ItemSpacing="5px"
                    EnableClientSideAPI="True">
                    <Border BorderStyle="None" />
                    <Items>
                        <dx:ListEditItem Text="None" Value="None" />
                        <dx:ListEditItem Text="FitToContent" Value="FitToContent" />
                        <dx:ListEditItem Text="LimitHeight" Value="LimitHeight" />
                    </Items>
                    <Paddings Padding="0px" />
                    <ClientSideEvents SelectedIndexChanged="function(s, e) {
                    switch(s.savedSelectedIndex) {
                        case 0:
                            ASPxClientScheduler1.Refresh(ASPxClientSchedulerRefreshAction.ActiveViewTypeChanged);
                            break;
                        case 1:
                            ASPxClientScheduler1.Refresh();
                            break;
                        case 2:
                            ASPxClientScheduler1.Refresh();
                            break;
                    }
                    }" />
                </dx:ASPxRadioButtonList>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <br />
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="Timeline" GroupType="Date"
        ClientInstanceName="ASPxClientScheduler1" AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
        <Views>
            <DayView Enabled="false" />
            <WorkWeekView Enabled="false" />
            <WeekView ResourcesPerPage="2">
                <AppointmentDisplayOptions StatusDisplayType="Bounds" />
            </WeekView>
            <MonthView ResourcesPerPage="2" WeekCount="3" ShowWeekend="false">
                <AppointmentDisplayOptions ShowRecurrence="true" StatusDisplayType="Bounds" />
                <MonthViewStyles>
                    <DateCellBody Height="100px" />
                </MonthViewStyles>
            </MonthView>
            <TimelineView ResourcesPerPage="2" IntervalCount="12">
                <TimelineViewStyles>
                    <TimelineCellBody Height="120px" />
                </TimelineViewStyles>
                <Scales>
                    <dx:TimeScaleMonth />
                    <dx:TimeScaleDay />
                </Scales>
            </TimelineView>
        </Views>
        <Storage EnableReminders="false">
        </Storage>
    </dx:ASPxScheduler>
    <demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
    <ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
        EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
    <ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>
