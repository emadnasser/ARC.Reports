<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="GanttSeries.aspx.cs" Inherits="GanttSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <script type="text/javascript">
<!--
    window.onload = function() {
        ASPxClientUtils.AttachEventToElement(this, "mousedown", OnMouseDown, false);
        ASPxClientUtils.AttachEventToElement(this, "mouseup", OnMouseUp, false);
        ASPxClientUtils.AttachEventToElement(this, "mousemove", OnMouseMove, false);
        ASPx.Evt.PreventElementDragAndSelect(chart.GetMainDOMElement(), false, false);
    }
    function ProcessEvent(evt) {
        var srcElement = ASPxClientUtils.GetEventSource(evt);
        return ASPxClientUtils.GetIsParent(chart.GetMainDOMElement(), srcElement);
    }
    function ProcessDragging(evt) {
        var x = CalculateRelativeX(ASPxClientUtils.GetEventX(evt), chart.GetMainDOMElement());
        var y = CalculateRelativeY(ASPxClientUtils.GetEventY(evt), chart.GetMainDOMElement());
        var diagram = chart.GetChart().diagram;
        coords = diagram.PointToDiagram(x,y);
        if (coords.isEmpty)
            return dragging;
        return dragging || BeginDrag(x,y);
    }
    function BeginDrag(x,y) {
        constLine = null;
        var hitInfo = chart.HitTest(x,y);
        for (var i = 0;i < hitInfo.length;i++) {
            if (hitInfo[i].object instanceof ASPxClientConstantLine) {
                constLine = hitInfo[i].object;
                return true;
            }
        }
        return false;
    }
    function CalculateRelativeX(x,clickedElement) {
        var left = ASPxClientUtils.GetAbsoluteX(clickedElement);
        return Math.abs(x - left);
    }
    function CalculateRelativeY(y,clickedElement) {
        var top = ASPxClientUtils.GetAbsoluteY(clickedElement);
        return Math.abs(y - top);
    }
    var dragging = false;
    var coords = null;
    var constLine = null;
    function OnMouseDown(evt) {
        if (!ProcessEvent(evt)) {
            dragging = false;
            return false;
        }
        if (ASPx.Evt.IsLeftButtonPressed(evt))
            dragging = ProcessDragging(evt);
        if (dragging && !coords.IsEmpty()) {
            var x = ASPxClientUtils.GetEventX(evt) + 5;
            var y = ASPxClientUtils.GetEventY(evt) + 10;
            DraggingToolTip.ShowAtPos(x,y);
            UpdateDraggingText();
        }
        if (!ASPxClientUtils.WebKitTouchUI && (!ASPxClientUtils.ie || ASPxClientUtils.BrowserVersion >= 9)) {
            evt.preventDefault();
            return false;
        }
    }
    function OnMouseUp(evt) {
        if (dragging) {
            dragging = false;
            var parameter = GetDateString(constLine.value);
            chart.PerformCallback(parameter);
            DraggingToolTip.Hide();
        }
    }
    function OnMouseMove(evt) {
        if (ProcessEvent(evt) && ProcessDragging(evt)) {
            chart.SetCursor('e-resize');
            if (dragging && !coords.IsEmpty()) {
                constLine.value = coords.dateTimeValue;
                UpdateDraggingText();
            }
            if (ASPx.TouchUIHelper.isTouchEvent(evt))
                evt.preventDefault();
        }
        else
            chart.SetCursor('');
    }
    function UpdateDraggingText() {
        DraggingToolTip.SetContentHTML("<span style=\"white-space:nowrap\">" + GetDateString(coords.dateTimeValue) + "</span>");
    }
    function GetDateString(date) {
        return (date.getMonth() + 1) + "/" + date.getDate() + "/" + date.getFullYear();
    }
    //-->
    </script>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin" CrosshairEnabled="False"
        ClientInstanceName="chart" EnableClientSideAPI="True" OnCustomCallback="WebChartControl1_CustomCallback">
        <Legend AlignmentHorizontal="Right" Direction="LeftToRight">
            <Margins Bottom="10" Left="10" Right="10" Top="10" />
        </Legend>
        <Titles>
            <dx:ChartTitle Text="R&amp;D Schedule"></dx:ChartTitle>
        </Titles>
        <SeriesSerializable>
            <dx:Series Name="Planned" ValueScaleType="DateTime" LabelsVisibility="False">
                <Points>
                    <dx:SeriesPoint DateTimeValues="08/16/2006 00:00:00.000;08/23/2006 00:00:00.000" ArgumentSerializable="Market Analysis" SeriesPointID="0"></dx:SeriesPoint>
                    <dx:SeriesPoint DateTimeValues="08/23/2006 00:00:00.000;08/25/2006 00:00:00.000" ArgumentSerializable="Feature Planning" SeriesPointID="1">
                        <Relations>
                            <dx:TaskLink ChildPointID="0"></dx:TaskLink>
                        </Relations>
                    </dx:SeriesPoint>
                    <dx:SeriesPoint DateTimeValues="08/25/2006 00:00:00.000;10/18/2006 00:00:00.000" ArgumentSerializable="Feature 1: Implementation" SeriesPointID="2">
                        <Relations>
                            <dx:TaskLink ChildPointID="1"></dx:TaskLink>
                        </Relations>
                    </dx:SeriesPoint>
                    <dx:SeriesPoint DateTimeValues="10/18/2006 00:00:00.000;10/26/2006 00:00:00.000" ArgumentSerializable="Feature 1: Demos&amp;Docs" SeriesPointID="7">
                        <Relations>
                            <dx:TaskLink ChildPointID="2"></dx:TaskLink>
                        </Relations>
                    </dx:SeriesPoint>
                    <dx:SeriesPoint DateTimeValues="09/07/2006 00:00:00.000;10/18/2006 00:00:00.000" ArgumentSerializable="Feature 2: Implementation" SeriesPointID="3">
                        <Relations>
                            <dx:TaskLink ChildPointID="1"></dx:TaskLink>
                        </Relations>
                    </dx:SeriesPoint>
                    <dx:SeriesPoint DateTimeValues="10/18/2006 00:00:00.000;10/26/2006 00:00:00.000" ArgumentSerializable="Feature 2: Demos&amp;Docs" SeriesPointID="8">
                        <Relations>
                            <dx:TaskLink ChildPointID="3"></dx:TaskLink>
                        </Relations>
                    </dx:SeriesPoint>
                    <dx:SeriesPoint DateTimeValues="09/21/2006 00:00:00.000;10/18/2006 00:00:00.000" ArgumentSerializable="Feature 3: Implementation" SeriesPointID="4">
                        <Relations>
                            <dx:TaskLink ChildPointID="1"></dx:TaskLink>
                        </Relations>
                    </dx:SeriesPoint>
                    <dx:SeriesPoint DateTimeValues="10/18/2006 00:00:00.000;10/26/2006 00:00:00.000" ArgumentSerializable="Feature 3: Demos&amp;Docs" SeriesPointID="9">
                        <Relations>
                            <dx:TaskLink ChildPointID="4"></dx:TaskLink>
                        </Relations>
                    </dx:SeriesPoint>
                    <dx:SeriesPoint DateTimeValues="10/26/2006 00:00:00.000;11/10/2006 00:00:00.000" ArgumentSerializable="Testing &amp; Bug Fixing" SeriesPointID="10">
                        <Relations>
                            <dx:TaskLink ChildPointID="7"></dx:TaskLink>
                            <dx:TaskLink ChildPointID="8"></dx:TaskLink>
                            <dx:TaskLink ChildPointID="9"></dx:TaskLink>
                        </Relations>
                    </dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:OverlappedGanttSeriesView></dx:OverlappedGanttSeriesView>
                </ViewSerializable>
            </dx:Series>
            <dx:Series Name="Completed" ValueScaleType="DateTime" LabelsVisibility="False">
                <Points>
                    <dx:SeriesPoint DateTimeValues="08/16/2006 00:00:00.000;08/23/2006 00:00:00.000" ArgumentSerializable="Market Analysis" SeriesPointID="0"></dx:SeriesPoint>
                    <dx:SeriesPoint DateTimeValues="08/23/2006 00:00:00.000;08/25/2006 00:00:00.000" ArgumentSerializable="Feature Planning" SeriesPointID="1"></dx:SeriesPoint>
                    <dx:SeriesPoint DateTimeValues="08/25/2006 00:00:00.000;09/25/2006 00:00:00.000" ArgumentSerializable="Feature 1: Implementation" SeriesPointID="2"></dx:SeriesPoint>
                    <dx:SeriesPoint DateTimeValues="09/07/2006 00:00:00.000;09/25/2006 00:00:00.000" ArgumentSerializable="Feature 2: Implementation" SeriesPointID="3"></dx:SeriesPoint>
                    <dx:SeriesPoint DateTimeValues="09/21/2006 00:00:00.000;09/25/2006 00:00:00.000" ArgumentSerializable="Feature 3: Implementation" SeriesPointID="4"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:OverlappedGanttSeriesView BarWidth="0.30000001192092896"></dx:OverlappedGanttSeriesView>
                </ViewSerializable>
            </dx:Series>
        </SeriesSerializable>
        <DiagramSerializable>
            <dx:GanttDiagram>
                <AxisX Title-Text="Tasks" Title-Visibility="True" VisibleInPanesSerializable="-1">                    
                    <GridLines Visible="True"></GridLines>
                </AxisX>
                <AxisY Title-Text="Date" VisibleInPanesSerializable="-1" MinorCount="4" Interlaced="True">
                    <DateTimeScaleOptions GridAlignment="Month" AutoGrid="False" GridSpacing="0.5"/>
                    <ConstantLines>
                        <dx:ConstantLine AxisValueSerializable="09/25/2006 00:00:00.000" ShowInLegend="False" Name="Progress Line"></dx:ConstantLine>
                    </ConstantLines>
                    <WholeRange Auto="False" MinValueSerializable="08/16/2006 00:00:00.000" MaxValueSerializable="11/16/2006 00:00:00.000" AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                    <GridLines MinorVisible="True"></GridLines>
                    <Label TextPattern="{V:m}">
                    </Label>
                </AxisY>
            </dx:GanttDiagram>
        </DiagramSerializable>
        <BorderOptions Visibility="False" />
    </dx:WebChartControl>
    <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" ClientInstanceName="DraggingToolTip" PopupAnimationType="None" Height="1px" ShowHeader="False" Width="1px" CloseAction="None" EnableHotTrack="False" PopupHorizontalAlign="Center" PopupVerticalAlign="TopSides">
        <ContentStyle>
        <Paddings Padding="0px" />
    </ContentStyle>
    </dx:ASPxPopupControl>
</asp:Content>
