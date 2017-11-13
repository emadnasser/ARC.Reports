<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ResourceHeaderTemplate.aspx.cs"
    Inherits="Templates_ResourceHeaderTemplate" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Group by">
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">
                <dx:ASPxRadioButtonList ID="rbVisibility" runat="server" ValueType="System.Int32"
                    SelectedIndex="1" RepeatDirection="Horizontal" TextWrap="False"
                    ItemSpacing="10px" EnableClientSideAPI="True">
                    <Border BorderStyle="None" />
                    <Items>
                        <dx:ListEditItem Text="None" Value="0" />
                        <dx:ListEditItem Text="Date" Value="1" />
                        <dx:ListEditItem Text="Resource" Value="2" />
                    </Items>
                    <Paddings Padding="0px" />
                    <ClientSideEvents SelectedIndexChanged="function(s, e) {
				switch(s.savedSelectedIndex) {
					case 0:
						ASPxClientScheduler1.SetGroupType(ASPxSchedulerGroupType.None);
						break;
					case 1:
						ASPxClientScheduler1.SetGroupType(ASPxSchedulerGroupType.Date);
						break;
					case 2:
						ASPxClientScheduler1.SetGroupType(ASPxSchedulerGroupType.Resource);
						break;
					}
						}" />
                </dx:ASPxRadioButtonList>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <br />
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" ActiveViewType="Day" GroupType="Resource"
        AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource"
        ClientInstanceName="ASPxClientScheduler1">
        <Views>
            <DayView ResourcesPerPage="2">
                <DayViewStyles ScrollAreaHeight="400px" />
            </DayView>
            <WorkWeekView ResourcesPerPage="2">
                <WorkWeekViewStyles ScrollAreaHeight="400px" />
            </WorkWeekView>
            <FullWeekView Enabled="true" ResourcesPerPage="2">
                <FullWeekViewStyles ScrollAreaHeight="400px" />
            </FullWeekView>
            <WeekView ResourcesPerPage="2" Enabled="false">
                <WeekViewStyles>
                    <DateCellBody Height="200px" />
                </WeekViewStyles>
            </WeekView>
            <MonthView ResourcesPerPage="2">
                <MonthViewStyles>
                    <DateCellBody Height="100px" />
                </MonthViewStyles>
            </MonthView>
            <TimelineView ResourcesPerPage="2">
                <TimelineViewStyles>
                    <TimelineCellBody Height="500px" />
                </TimelineViewStyles>
            </TimelineView>
        </Views>
        <Templates>
            <HorizontalResourceHeaderTemplate>
                <table style="width: 100%">
                    <tr>
                        <td style="text-align: center;">
                            <dx:ASPxImage runat="server" ImageUrl='<%# "ResourceHeaderTemplate.aspx?Image=" + Container.Resource.Id %>'
                                AlternateText='<%# Container.Resource.Caption %>' ToolTip='<%# Container.Resource.Caption %>'>
                                <Border BorderColor="#93c3d3" BorderStyle="solid" BorderWidth="1px" />
                            </dx:ASPxImage>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <%# Container.Resource.Caption %>
                        </td>
                    </tr>
                </table>
            </HorizontalResourceHeaderTemplate>
            <VerticalResourceHeaderTemplate>
                <table style="width: 100%">
                    <tr>
                        <td>
                            <dx:ASPxImage runat="server" ImageUrl='<%# "ResourceHeaderTemplate.aspx?Image=" + Container.Resource.Id %>'
                                AlternateText='<%# Container.Resource.Caption %>'>
                            </dx:ASPxImage>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <%# Container.Resource.Caption %>
                        </td>
                    </tr>
                </table>
            </VerticalResourceHeaderTemplate>
        </Templates>
        <Storage EnableReminders="false" />
    </dx:ASPxScheduler>
    <demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
    <ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
        EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
    <ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>
