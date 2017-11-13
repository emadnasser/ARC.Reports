<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FormsVisibility.aspx.cs"
    Inherits="Miscellaneous_FormsVisibility" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Form Display Mode">
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">
                <dx:ASPxRadioButtonList ID="rbVisibility" runat="server" ValueType="System.Int32"
                    SelectedIndex="1" RepeatDirection="Horizontal" TextWrap="False"
                    ItemSpacing="10px">
                    <Border BorderStyle="None" />
                    <Items>
                        <dx:ListEditItem Text="None" Value="0" />
                        <dx:ListEditItem Text="Popup Window" Value="1" />
                        <dx:ListEditItem Text="Fill Control Area" Value="2" />
                    </Items>
                    <Paddings Padding="0px" PaddingTop="0px" />
                    <ClientSideEvents SelectedIndexChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                </dx:ASPxRadioButtonList>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <br />
    <dx:ASPxScheduler ID="ASPxScheduler1" ClientInstanceName="ASPxClientScheduler1" runat="server" GroupType="Resource"
        Width="100%" AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
        <ResourceNavigator EnableIncreaseDecrease="false" />
        <Views>
            <WorkWeekView ResourcesPerPage="2"/>
            <FullWeekView Enabled="true" ResourcesPerPage="2" />
            <WeekView Enabled="false" />
            <MonthView Enabled="false" />
            <TimelineView ResourcesPerPage="2">
                <TimelineViewStyles>
                    <TimelineCellBody Height="300px" />
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
