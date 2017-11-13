<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FullWeekView.aspx.cs" Inherits="ViewTypes_FullWeekView" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="3" Theme="Metropolis" Width="100%">
        <items>
            <dx:LayoutGroup Caption="Current Time Visualization"  GroupBoxDecoration="HeadingLine">
                <Items>
                    <dx:LayoutItem Caption="TimeIndicator Visibility">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxComboBox ID="cbTimeIndicatorVisibility" runat="server" Width="90px" SelectedIndex="1" Theme="Metropolis"
                                    ValueType="System.Int32" >
                                    <ClientSideEvents SelectedIndexChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                                    <Items>
                                        <dx:ListEditItem Text="Never" Value="0" />
                                        <dx:ListEditItem Text="Always" Value="1" />
                                        <dx:ListEditItem Text="TodayView" Value="2" />
                                        <dx:ListEditItem Text="CurrentDate" Value="3" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="TimeMarker Visibility">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxComboBox ID="cbTimeMarkerVisibility" runat="server" Width="90px" SelectedIndex="1" Theme="Metropolis"
                                    ValueType="System.Int32">
                                    <ClientSideEvents SelectedIndexChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                                    <Items>
                                        <dx:ListEditItem Text="Never" Value="0" />
                                        <dx:ListEditItem Text="Always" Value="1" />
                                        <dx:ListEditItem Text="TodayView" Value="2" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
            <dx:LayoutGroup Caption="View Layout Options"  GroupBoxDecoration="HeadingLine">
                <Items>
                     <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxComboBox ID="cbSnapToCellsMode" runat="server" Width="90px" SelectedIndex="0" Theme="Metropolis"
                                    ValueType="System.Int32" Caption="Snap&nbsp;To&nbsp;Cells&nbsp;Mode">
                                    <ClientSideEvents SelectedIndexChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                                    <Items>
                                        <dx:ListEditItem Text="Auto" Value="0" />
                                        <dx:ListEditItem Text="Always" Value="1" />
                                        <dx:ListEditItem Text="Never" Value="2" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>   
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection >
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxCheckBox ID="chkShowAllDayArea" runat="server" Text="Show All Day Area" Checked="True" Wrap="False" Theme="Metropolis">
                                     <ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                                </dx:ASPxCheckBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                     </dx:LayoutItem>
                     <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxCheckBox ID="chkShowDayHeaders" runat="server" Text="Show Day Headers" Checked="True" Wrap="False" Theme="Metropolis">
                                    <ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                                </dx:ASPxCheckBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                     </dx:LayoutItem>
                     <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxCheckBox ID="chkShowWorkTimeOnly" runat="server" Text="Show Work Time Only" Checked="true" Wrap="False" Theme="Metropolis">
                                    <ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                                </dx:ASPxCheckBox>
                            </dx:LayoutItemNestedControlContainer>
                         </LayoutItemNestedControlCollection>
                     </dx:LayoutItem>                 
                 </items>
            </dx:LayoutGroup>
            <dx:LayoutGroup Caption="Common options" GroupBoxDecoration="HeadingLine" ColCount="1">
                <Items>
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
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxCheckBox ID="HighlightSelectionCheckBox" runat="server" Checked="true" Wrap="False" Text="Highlight Selection Headers" Theme="Metropolis">
                                    <ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
                                </dx:ASPxCheckBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </items>
    </dx:ASPxFormLayout>
    <br />
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="FullWeek" GroupType="Resource" AppointmentDataSourceID="AppointmentDataSource" 
        ResourceDataSourceID="efResourceDataSource" ClientInstanceName="ASPxClientScheduler1">
        <ResourceNavigator EnableIncreaseDecrease="false" />
        <views>
            <DayView Enabled="false" />
            <FullWeekView Enabled="true" ResourcesPerPage="1">
                <WorkTime Start="07:00:00" End="20:00:00" />
            </FullWeekView>
            <WorkWeekView Enabled="false" />
            <WeekView Enabled="false" />
            <MonthView Enabled="false" />
            <TimelineView Enabled="false" />
        </views>
        <optionsbehavior showviewselector="false" />
        <storage enablereminders="false" />
    </dx:ASPxScheduler>
    <demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
    <ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
        EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
    <ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>
