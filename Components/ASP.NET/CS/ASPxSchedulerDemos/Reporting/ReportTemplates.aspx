<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReportTemplates.aspx.cs"
    Inherits="ReportTemplates" %>
<%@ Register Src="~/Reporting/ReportPreview.ascx" TagName="ReportPreview" TagPrefix="rp" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function scheduler_VisibleIntervalChanged(s, e) {
            var intervals = s.GetVisibleIntervals();
            var count = intervals.length;
            if(count <= 0) return;
            fromDate.SetDate(intervals[0].GetStart());
            toDate.SetDate(intervals[count - 1].GetEnd());
        }
        function btnShowPreview_Click(s, e) {
            if(window.ClientReportViewer) {
                scheduler.ShowLoadingPanel();
                window.ClientReportViewer.Refresh();
            }
            else {
                ASPxPopupControl1.Show();
                ASPxCallbackPanel1.PerformCallback();
            }
        }
        function ValidateDates() {
            var startDate = fromDate.GetDate();
            var endDate = toDate.GetDate();
            if(endDate < startDate)
                toDate.SetDate(startDate);
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <demo:DefaultDataSources runat="server" ID="DataSource1" UseTemporaryDataSource="true" />
    <dx:ASPxGlobalEvents ID="ASPxGlobalEvents1" runat="server">
        <ClientSideEvents BeginCallback="function(s, e) { btnShowPreview.SetEnabled(false); }"
            EndCallback="function(s, e) { btnShowPreview.SetEnabled(true); }" />
    </dx:ASPxGlobalEvents>
    <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" Modal="True" ClientInstanceName="ASPxPopupControl1" Theme="Metropolis"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Width="680px"
        Height="600px" HeaderText="Print Preview" AllowDragging="true" PopupAnimationType="None">
        <ContentCollection>
            <dx:PopupControlContentControl runat="server" ID="PCC">
                <dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" OnCallback="ASPxCallbackPanel1_Callback"
                    ClientInstanceName="ASPxCallbackPanel1">
                    <PanelCollection>
                        <dx:PanelContent runat="server">
                            <asp:Panel ID="PreviewPanel" runat="server" Visible="false">
                            </asp:Panel>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxCallbackPanel>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
    <dx:ASPxSchedulerControlPrintAdapter ID="ASPxSchedulerControlPrintAdapter1" runat="server"
        SchedulerControlID="ASPxScheduler1">
    </dx:ASPxSchedulerControlPrintAdapter>
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Preview Options" Theme="Metropolis">
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">
                <table class="OptionsTable">
                    <tr>
                        <td>
                            Select a template file to load...
                        </td>
                        <td>
                            Print From:
                        </td>
                        <td>
                            Print To:
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td class="edit">
                            <dx:ASPxComboBox ID="ReportTemplateCombo" runat="server" Width="195px" SelectedIndex="0" Theme="Metropolis"
                                ValueType="System.Int32" ClientInstanceName="clientReportTemplateCombo">
                                <Items>
                                    <dx:ListEditItem Text="TrifoldStandard.schrepx" Value="9"></dx:ListEditItem>
                                    <dx:ListEditItem Text="TrifoldResource.schrepx" Value="10"></dx:ListEditItem>
                                    <dx:ListEditItem Text="TimetableStyle.schrepx" Value="11"></dx:ListEditItem>
                                    <dx:ListEditItem Text="DailyStyleFitToPage.schrepx" Value="0"></dx:ListEditItem>
                                    <dx:ListEditItem Text="DailyStyleFixedCellHeight.schrepx" Value="1"></dx:ListEditItem>
                                    <dx:ListEditItem Text="MonthlyStyle.schrepx" Value="2"></dx:ListEditItem>
                                    <dx:ListEditItem Text="MonthlyStyle2Columns.schrepx" Value="3"></dx:ListEditItem>
                                    <dx:ListEditItem Text="TimelineStyle.schrepx" Value="4"></dx:ListEditItem>
                                    <dx:ListEditItem Text="TimelineStyle2Columns.schrepx" Value="5"></dx:ListEditItem>
                                    <dx:ListEditItem Text="WeeklyStyle.schrepx" Value="6"></dx:ListEditItem>
                                    <dx:ListEditItem Text="WeeklyStyle2Columns.schrepx" Value="7"></dx:ListEditItem>
                                    <dx:ListEditItem Text="WeeklyStyle2Weeks.schrepx" Value="8"></dx:ListEditItem>
                                </Items>
                            </dx:ASPxComboBox>
                        </td>
                        <td class="edit">
                            <dx:ASPxDateEdit ID="ASPxDateEdit1" ClientInstanceName="fromDate" runat="server" Theme="Metropolis"
                                Width="113px">
                                <ClientSideEvents DateChanged="function(s, e) { ValidateDates(); }"></ClientSideEvents>
                            </dx:ASPxDateEdit>
                        </td>
                        <td class="edit">
                            <dx:ASPxDateEdit ID="ASPxDateEdit2" ClientInstanceName="toDate" runat="server" Width="126px" Theme="Metropolis">
                                <ClientSideEvents DateChanged="function(s, e) { ValidateDates(); }"></ClientSideEvents>
                            </dx:ASPxDateEdit>
                        </td>
                        <td>
                            <dx:ASPxButton ID="btnPreview" runat="server" Text="Show Preview" AutoPostBack="False" Theme="Metropolis"
                                UseSubmitBehavior="False" ClientInstanceName="btnShowPreview" EnableClientSideAPI="true">
                                <ClientSideEvents Click="btnShowPreview_Click"></ClientSideEvents>
                            </dx:ASPxButton>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <br /><br />
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="Week"
        GroupType="Resource" ClientInstanceName="scheduler">
        <Views>
            <DayView ResourcesPerPage="3">
                <DayViewStyles ScrollAreaHeight="300px">
                </DayViewStyles>
                <TimeRulers>
                    <dx:TimeRuler />
                </TimeRulers>
            </DayView>
            <WorkWeekView ResourcesPerPage="3">
                <WorkWeekViewStyles ScrollAreaHeight="300px">
                </WorkWeekViewStyles>
                <TimeRulers>
                    <dx:TimeRuler />
                </TimeRulers>
            </WorkWeekView>
            <WeekView ResourcesPerPage="3">
            </WeekView>
            <MonthView ResourcesPerPage="3">
            </MonthView>
            <TimelineView ResourcesPerPage="3">
            </TimelineView>
        </Views>
        <ClientSideEvents VisibleIntervalChanged="scheduler_VisibleIntervalChanged" />
        <Storage EnableReminders="False">
        </Storage>
    </dx:ASPxScheduler>
</asp:Content>
