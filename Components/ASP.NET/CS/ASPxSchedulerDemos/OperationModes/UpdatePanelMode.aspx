<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UpdatePanelMode.aspx.cs" Inherits="OperationModes_UpdatePanelMode" %>
<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI" TagPrefix="asp" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="True" runat="server" />
    <asp:UpdatePanel runat="server" ID="UpdatePanel1">
        <ContentTemplate>
            <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" EnableCallBacks="False" Width="100%" GroupType="Resource"
                ActiveViewType="Day" AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
                <ResourceNavigator EnableIncreaseDecrease="false" />
                <Views>
                    <DayView ResourcesPerPage="1">
                        <DayViewStyles ScrollAreaHeight="400px" />
                    </DayView>
                    <WorkWeekView ResourcesPerPage="1">
                        <WorkWeekViewStyles ScrollAreaHeight="400px" />
                    </WorkWeekView>
                    <FullWeekView ResourcesPerPage="1" Enabled="true">
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
                <Storage EnableReminders="false" />
            </dx:ASPxScheduler>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    <asp:UpdateProgress runat="server" ID="UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="0" DynamicLayout="false">
        <ProgressTemplate>                    
            <img alt="" src="../Content/Demo/Progress.gif" />
        </ProgressTemplate>
    </asp:UpdateProgress>
    <demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
    <ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
        EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
    <ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>
