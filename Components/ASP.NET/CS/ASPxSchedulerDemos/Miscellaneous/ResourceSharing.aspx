<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ResourceSharing.aspx.cs"
    Inherits="Miscellaneous_ResourceSharing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <demo:DefaultDataSources runat="server" ID="DataSource1" UniqueSessionPrefix="ResourceSharing" ResourceSharing="true" />
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="Day" GroupType="Resource">
        <Views>
            <DayView ResourcesPerPage="2">
                <DayViewStyles ScrollAreaHeight="400px" />
            </DayView>
            <WorkWeekView ResourcesPerPage="2">
                <WorkWeekViewStyles ScrollAreaHeight="400px" />
            </WorkWeekView>
            <WeekView ResourcesPerPage="2" Enabled="false">
                <WeekViewStyles>
                    <DateCellBody Height="150px" />
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
                    <TimelineCellBody Height="250px" />
                </TimelineViewStyles>
            </TimelineView>
        </Views>
        <Storage EnableReminders="false">
            <Appointments ResourceSharing="true">
            </Appointments>
        </Storage>
    </dx:ASPxScheduler>
</asp:Content>
