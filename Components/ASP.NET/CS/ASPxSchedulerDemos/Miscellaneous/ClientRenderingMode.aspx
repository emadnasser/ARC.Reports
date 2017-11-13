<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientRenderingMode.aspx.cs" Inherits="Miscellaneous_ClientRenderingMode" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <script type="text/javascript">
        function UpdateScheduler(s, e) {
            DemoScheduler.Refresh();
        }
        function OnBeginCallback(s, e) {
            ClientCommandNameLabel.SetText(e.command);
            ClientTimeLabel.SetText("working...");
            this.startCallbackTime = performance.now();
        }
        function OnEndCallback(s, e) {
            ClientTimeLabel.SetText(Math.round(performance.now() - this.startCallbackTime));
        }
    </script>
    <dx:ASPxFormLayout ID="FormLayout" runat="server" Theme="Metropolis" ShowItemCaptionColon="false" Width="100%" ColCount="2">
        <Items>
            <dx:LayoutGroup Caption="Options" GroupBoxDecoration="HeadingLine" Width="200px">
                <ParentContainerStyle>
                    <Paddings PaddingRight="20px" />
                </ParentContainerStyle>
                <Items>
                    <dx:LayoutItem ShowCaption="False">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxCheckBox ID="cbEnableClientRender" runat="server" Text="EnableClientRender" Theme="Metropolis">
                                    <ClientSideEvents CheckedChanged="UpdateScheduler" />
                                </dx:ASPxCheckBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
            <dx:LayoutGroup Caption="Test Results" GroupBoxDecoration="HeadingLine" Width="100%">
                <Items>
                    <dx:LayoutItem Caption="Command:">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxLabel runat="server" ID="CommandNameLabel" ClientInstanceName="ClientCommandNameLabel" Text="" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Time taken (ms):">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxLabel runat="server" ID="TimeLabel" ClientInstanceName="ClientTimeLabel" Text="..." />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
    <br />
    <dx:ASPxScheduler ID="DemoScheduler" runat="server" Width="100%" ClientInstanceName="DemoScheduler" ActiveViewType="FullWeek" GroupType="Resource"
        AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
        <ClientSideEvents 
            BeginCallback="OnBeginCallback"
            EndCallback="OnEndCallback"
        />
        <Views>
            <DayView ResourcesPerPage="3">
                <DayViewStyles ScrollAreaHeight="600px" />
            </DayView>
            <WorkWeekView ResourcesPerPage="3">
                <WorkWeekViewStyles ScrollAreaHeight="600px" />
            </WorkWeekView>
            <FullWeekView Enabled="true" ResourcesPerPage="3">
                <FullWeekViewStyles ScrollAreaHeight="600px" />
            </FullWeekView>
            <WeekView ResourcesPerPage="3" />
            <MonthView ResourcesPerPage="3" />
            <TimelineView ResourcesPerPage="3" />
        </Views>
        <Storage EnableReminders="false">
        </Storage>
    </dx:ASPxScheduler>
    <demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
    <ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
        EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
    <ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>
