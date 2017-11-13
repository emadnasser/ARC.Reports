<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="WeekView.aspx.cs"
    Inherits="ViewTypes_WeekView" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" Theme="Metropolis">
        <Items>
            <dx:LayoutGroup Caption="Common options" GroupBoxDecoration="HeadingLine" ColCount="3">
                <Items>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxCheckBox ID="ShowViewNavigatorCheckBox" runat="server" Checked="true" Wrap="False" Text="Show View Navigator" Theme="Metropolis">
                                    <ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                                </dx:ASPxCheckBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxCheckBox ID="ShowViewVisibleIntervalCheckBox" runat="server" Checked="true" Wrap="False" Text="Show View Visible Interval" Theme="Metropolis">
                                    <ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                                </dx:ASPxCheckBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="AppointmentSelection Appearance Mode">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxComboBox ID="SelectionAppearanceModeComboBox" runat="server" Width="90px" SelectedIndex="0" Theme="Metropolis"
                                    ValueType="System.Int32">
                                    <ClientSideEvents SelectedIndexChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                                    <Items>
                                        <dx:ListEditItem Text="Auto" Value="0" />
                                        <dx:ListEditItem Text="BackgroundOpacity" Value="1" />
                                        <dx:ListEditItem Text="BoundaryFrame" Value="2" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
    <br />
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="Week" GroupType="Resource"  AppointmentDataSourceID="AppointmentDataSource" 
        ResourceDataSourceID="efResourceDataSource" ClientInstanceName="ASPxClientScheduler1">
        <ResourceNavigator EnableIncreaseDecrease="false" />
        <Views>
            <DayView Enabled="false"/>
            <WorkWeekView Enabled="false"/>
            <WeekView ResourcesPerPage="1" />
            <MonthView Enabled="false" />
            <TimelineView Enabled="false" />
        </Views>
        <OptionsBehavior ShowViewSelector="false" />
        <Storage EnableReminders="false" />
    </dx:ASPxScheduler>
    <demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
    <ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
        EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
    <ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>
