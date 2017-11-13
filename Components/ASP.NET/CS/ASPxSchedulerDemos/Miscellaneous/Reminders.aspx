<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Reminders.aspx.cs"
    Inherits="Miscellaneous_Reminders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <script type="text/javascript">
        function OnBtnCreateAptClick() {
            scheduler.RaiseCallback("CREATAPTWR|");
        }
    </script>
    <demo:DefaultDataSources runat="server" ID="schedulerDataSource" InitAppointments="false" UniqueSessionPrefix="Reminders" />
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Demo Options">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <dx:ASPxButton ID="btnCreateApt" runat="server" Text="Create Appointment With Reminder"
                    AutoPostBack="false">
                    <ClientSideEvents Click="function(s, e) { OnBtnCreateAptClick(); }" />
                </dx:ASPxButton>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <br />
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="WorkWeek"
        ClientInstanceName="scheduler" OnBeforeExecuteCallbackCommand="SPxScheduler1_OnBeforeExecuteCallbackCommand">
        <Views>
            <DayView ResourcesPerPage="2">
                <DayViewStyles ScrollAreaHeight="400px" />
            </DayView>
            <WorkWeekView ResourcesPerPage="2">
                <TimeRulers>
                    <dx:TimeRuler />
                </TimeRulers>
                <WorkWeekViewStyles ScrollAreaHeight="400px" />
            </WorkWeekView>
            <WeekView ResourcesPerPage="2" Enabled="false">
                <WeekViewStyles>
                    <DateCellBody Height="200px" />
                </WeekViewStyles>
            </WeekView>
            <FullWeekView Enabled="true" ResourcesPerPage="2">
                <FullWeekViewStyles ScrollAreaHeight="400px" />
            </FullWeekView>
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
    </dx:ASPxScheduler>
</asp:Content>
