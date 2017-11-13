<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ResourceHeaderLayout.aspx.cs" Inherits="Customization_ResourceHeaderLayout" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <script type="text/javascript">
        function UpdateScheduler(s, e) {
            DemoScheduler.Refresh();
        }
    </script>
    <dx:ASPxFormLayout ID="FormLayout" runat="server" Theme="Metropolis" ShowItemCaptionColon="false"  ColCount="2">
        <Items>
            <dx:LayoutGroup Caption="Resource Headers Settings" ColCount="3" GroupBoxDecoration="HeadingLine">
                <Items>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxCheckBox ID="cbRotateCaption" runat="server" Text="RotateCaption" Theme="Metropolis">
                                    <ClientSideEvents CheckedChanged="UpdateScheduler" />
                                </dx:ASPxCheckBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxCheckBox ID="cbShowCaption" runat="server" Text="ShowCaption" Theme="Metropolis">
                                    <ClientSideEvents CheckedChanged="UpdateScheduler" />
                                </dx:ASPxCheckBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="ImageAlign:">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                    <dx:ASPxComboBox ID="cbImageAlign" runat="server" Width="70px" ValueType="System.Int32" Theme="Metropolis">
                                        <ClientSideEvents TextChanged="UpdateScheduler" />
                                        <Items>
                                            <dx:ListEditItem Text="Left" Value="0" />
                                            <dx:ListEditItem Text="Top" Value="1" />
                                            <dx:ListEditItem Text="Right" Value="2" />
                                            <dx:ListEditItem Text="Bottom" Value="3" />
                                        </Items>
                                    </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
            <dx:LayoutGroup Caption="Common Settings" GroupBoxDecoration="HeadingLine">
                <Items>
                    <dx:LayoutItem Caption="ResourceColorFillArea:">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                    <dx:ASPxComboBox ID="cbResourceColorFillArea" runat="server" Width="120px" ValueType="System.Int32" Theme="Metropolis">
                                        <ClientSideEvents TextChanged="UpdateScheduler" />
                                        <Items>
                                            <dx:ListEditItem Text="TimeCells" Value="0" />
                                            <dx:ListEditItem Text="ResourceHeader" Value="1" />
                                            <dx:ListEditItem Text="Both" Value="2" />
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
    <dx:ASPxScheduler ID="DemoScheduler" runat="server" ActiveViewType="Day" GroupType="Resource" ClientInstanceName="DemoScheduler"
        AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
        <Storage>
            <Appointments ResourceSharing="false"></Appointments>
        </Storage>
        <OptionsView>
            <ResourceHeaders ImageAlign="Top" />
        </OptionsView>
        <Views>
            <DayView ResourcesPerPage="3" />
            <WorkWeekView ResourcesPerPage="3" />
            <FullWeekView Enabled="true" ResourcesPerPage="3" />
            <WeekView Enabled="false" />
            <MonthView ResourcesPerPage="3">
                <AppointmentDisplayOptions ShowRecurrence="true" />
                <MonthViewStyles>
                    <DateCellBody Height="150px" />
                </MonthViewStyles>
            </MonthView>
            <TimelineView ResourcesPerPage="3">
                <TimelineViewStyles>
                    <VerticalResourceHeader Width="170px">
                    </VerticalResourceHeader>
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
