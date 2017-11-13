<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomTooltip.aspx.cs"
    Inherits="Customization_CustomTooltip" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <link href="../Content/CustomToolTip/styles.css" rel="stylesheet" type="text/css" />
    <%--start highlighted block--%>
    <script type="text/javascript">
        var globalMouseX = 0;
        var globalMouseY = 0;
        var detectedMouseUp = false;
        var detectedSelectionChanged = false        
        function OnMouseMove(evt) {
            globalMouseX = ASPx.Evt.GetEventX(evt);
            globalMouseY = ASPx.Evt.GetEventY(evt);
            detectedSelectionChanged = false;
            detectedMouseUp = false;
        }
        function OnMouseUp(evt) {
            detectedMouseUp = true;
            ShowToolTip();
        }
        function createEventHandler(funcName) {
            return new Function("event", funcName + "(event);");
        }
        function OnSelectionChanged(s, e) {
            if(!scheduler.isAllowEvent)
                return;
            detectedSelectionChanged = true;
            ShowToolTip();
        }
        function ShowToolTip() {
            if(detectedSelectionChanged && detectedMouseUp && scheduler.GetSelectedAppointmentIds().length == 0) {
                scheduler.ShowSelectionToolTip(globalMouseX, globalMouseY);
                detectedSelectionChanged = false;
                detectedMouseUp = false;
            }
        }
        function OnBeginCallback() {
            delete scheduler.isAllowEvent;
        }
        function OnEndCallback() {
            scheduler.isAllowEvent = true;
        }
        function OnControlInitialized() {
            ASPx.Evt.AttachEventToElement(document, "mousemove", createEventHandler("OnMouseMove"));
            ASPx.Evt.AttachEventToElement(document, "mouseup", createEventHandler("OnMouseUp"));
            scheduler.isAllowEvent = true;
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel2" runat="server" Width="100%" HeaderText="Enable ToolTips">
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">
                <table class="OptionsTable">
                    <tr>
                        <td>
                            <dx:ASPxCheckBox ID="chkEnableSelectionToolTip" runat="server" Text="Enable Selection ToolTip"
                                Checked="True" Wrap="False">
                                <ClientSideEvents CheckedChanged="function(s, e) { scheduler.RaiseCallback('EnableToolTipCallback|selection=' + s.GetChecked()); }" />
                            </dx:ASPxCheckBox>
                        </td>
                        <td>
                            <dx:ASPxCheckBox ID="chkEnableAppointmentToolTip" runat="server" Text="Enable Appointment ToolTip"
                                Checked="True" Wrap="False">
                                <ClientSideEvents CheckedChanged="function(s, e) { scheduler.RaiseCallback('EnableToolTipCallback|appointment=' + s.GetChecked()); }" />
                            </dx:ASPxCheckBox>
                        </td>
                        <td>
                            <dx:ASPxCheckBox ID="chkEnableAppointmentDragToolTip" runat="server" Text="Enable Appointment Drag ToolTip"
                                Checked="True" Wrap="False">
                                <ClientSideEvents CheckedChanged="function(s, e) { scheduler.RaiseCallback('EnableToolTipCallback|drag=' + s.GetChecked()); }" />
                            </dx:ASPxCheckBox>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <br />
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" GroupType="Resource"
        ClientInstanceName="scheduler" OnBeforeExecuteCallbackCommand="OnSchedulerBeforeExecuteCallbackCommand"
        AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
        <ResourceNavigator EnableIncreaseDecrease="false" />
        <ClientSideEvents SelectionChanged="function(s,e) { OnSelectionChanged(s, e); }"
            BeginCallback="function(s,e) { OnBeginCallback(s, e); }" EndCallback="function(s,e) {OnEndCallback(s,e); }" />
        <Storage EnableReminders="False">
            <Appointments>
                <CustomFieldMappings>
                    <dx:ASPxAppointmentCustomFieldMapping Member="ContactInfo" Name="ContactInfo"></dx:ASPxAppointmentCustomFieldMapping>
                </CustomFieldMappings>
            </Appointments>
        </Storage>
        <OptionsToolTips AppointmentToolTipUrl="~/UserForms/CustomAppointmentTooltip.ascx"
            AppointmentDragToolTipUrl="~/UserForms/CustomDragAppointmentTooltip.ascx" SelectionToolTipUrl="~/UserForms/CustomSelectionTooltip.ascx"
            AppointmentToolTipCornerType="None" SelectionToolTipCornerType="None" />
        <Views>
            <DayView ResourcesPerPage="1" />
            <WorkWeekView ResourcesPerPage="1" />
            <FullWeekView Enabled="true" ResourcesPerPage="1" />
            <WeekView Enabled="false"/>
            <TimelineView ResourcesPerPage="1" />
        </Views>
    </dx:ASPxScheduler>
    <demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
    <ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
        EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
    <ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
    <dx:ASPxGlobalEvents ID="ASPxGlobalEvents1" runat="server">
        <ClientSideEvents ControlsInitialized="function(s, e) { OnControlInitialized(s,e); }" />
    </dx:ASPxGlobalEvents>
</asp:Content>
