<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="GanttSideBySideSeries.aspx.vb" Inherits="GanttSideBySideSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<script type="text/javascript">
<!--
	window.onload = function() {
		ASPxClientUtils.AttachEventToElement(this, "mousedown", OnMouseDown, false);
		ASPxClientUtils.AttachEventToElement(this, "mouseup", OnMouseUp, false);
		ASPxClientUtils.AttachEventToElement(this, "mousemove", OnMouseMove, false);
		ASPx.Evt.PreventElementDragAndSelect(chart.GetMainDOMElement(), false, false);
	}
	function CalculateRelativeX(x,clickedElement) {
		var left = ASPxClientUtils.GetAbsoluteX(clickedElement);
		return Math.abs(x - left);
	}
	function CalculateRelativeY(y,clickedElement) {
		var top = ASPxClientUtils.GetAbsoluteY(clickedElement);
		return Math.abs(y - top);
	}
	var series = null;
	var seriesPoint = null;
	var coords = null;
	var draggingIndex = -1;
	var dragging = false;
	function ProcessEvent(evt) {
		var srcElement = ASPxClientUtils.GetEventSource(evt);
		return ASPxClientUtils.GetIsParent(chart.GetMainDOMElement(), srcElement);
	}
	function ProcessDragging(evt) {
		if (series == null)
			draggingIndex = -1;
		var x = CalculateRelativeX(ASPxClientUtils.GetEventX(evt), chart.GetMainDOMElement());
		var y = CalculateRelativeY(ASPxClientUtils.GetEventY(evt), chart.GetMainDOMElement());
		var diagram = chart.GetChart().diagram;
		coords = diagram.PointToDiagram(x,y);
		if (coords.isEmpty)
			return dragging;
		return dragging || BeginDrag(x,y);
	}
	function BeginDrag(x,y) {
		series = null;
		seriesPoint = null;
		var hitInfo = chart.HitTest(x,y);
		for (var i = 0;i < hitInfo.length;i++) {
			if ((hitInfo[i].object instanceof ASPxClientSeries) && (hitInfo[i].additionalObject instanceof ASPxClientSeriesPoint)) {
				series = hitInfo[i].object;
				seriesPoint = hitInfo[i].additionalObject;
				if (series.name.indexOf('Current Plan') != -1) {
					draggingIndex = GetDraggingIndex();
					return draggingIndex != -1;
				}
			}
		}
		return false;
	}
	function GetDraggingIndex() {
		if (DateEquals(coords.dateTimeValue, seriesPoint.values[0])) return 0;
		if (DateEquals(coords.dateTimeValue, seriesPoint.values[1])) return 1;
		return -1;
	}
	function DateEquals(date1, date2) {
		return Math.abs(date1.getDate() - date2.getDate()) <= 1 && date1.getMonth() == date2.getMonth();
	}
	function OnMouseDown(evt) {
		if (!ProcessEvent(evt)) {
			dragging = false;
			return false;
		}
		if (ASPx.Evt.IsLeftButtonPressed(evt))
			dragging = ProcessDragging(evt);
		if (dragging) {
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
			var parameter = series.name + ";" + seriesPoint.argument + ";" + draggingIndex + ";" + GetDateString(seriesPoint.values[draggingIndex]);
			chart.PerformCallback(parameter);
			DraggingToolTip.Hide();
		}
	}
	function OnMouseMove(evt) {
		if (ProcessEvent(evt) && ProcessDragging(evt)) {
			chart.SetCursor('e-resize');
			if (dragging && draggingIndex >= 0 && !coords.IsEmpty()) {
				seriesPoint.values[draggingIndex] = coords.dateTimeValue;
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
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
		<PanelCollection>
		<dx:PanelContent ID="PanelContent1" runat="server">  
			<table style="width: 100%;">
				<tr>
					<td style="width: 100%;">
						<dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels">
							<ClientSideEvents CheckedChanged="function(s, e) { chart.PerformCallback(&quot;ShowLabels&quot;); }" />
						</dx:ASPxCheckBox>
					</td>
				</tr>
			</table>
		</dx:PanelContent>
	</PanelCollection>
	</dx:ASPxRoundPanel>
	<dx:aspxpopupcontrol id="ASPxPopupControl1" runat="server" clientinstancename="DraggingToolTip"
		CloseAction="None" PopupAnimationType="None" EnableHotTrack="False" ShowHeader="False" PopupHorizontalAlign="Center" Height="1px" PopupVerticalAlign="TopSides" Width="1px">
		<ContentStyle>
		<Paddings Padding="0px" />
	</ContentStyle>
		<Border BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
	</dx:aspxpopupcontrol>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
		ClientInstanceName="chart" EnableClientSideAPI="True" OnCustomCallback="WebChartControl1_CustomCallback" CrosshairEnabled="False">
		<Titles>
			<dx:ChartTitle Text="Project Comparison"></dx:ChartTitle>
			<dx:ChartTitle Dock="Left" Text="Tasks" Font="Tahoma, 12pt"></dx:ChartTitle>
		</Titles>
		<SeriesSerializable>
			<dx:Series Name="Project 1 : Orignal Plan" ValueScaleType="DateTime" LabelsVisibility="False">
				<Points>
					<dx:SeriesPoint DateTimeValues="03/27/2005 00:00:00.000;05/30/2005 00:00:00.000" ArgumentSerializable="Project 1" SeriesPointID="0"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="03/27/2005 00:00:00.000;04/29/2005 00:00:00.000" ArgumentSerializable="task 1" SeriesPointID="1"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="04/19/2005 00:00:00.000;05/30/2005 00:00:00.000" ArgumentSerializable="task 2" SeriesPointID="2"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="04/18/2005 00:00:00.000;05/07/2005 00:00:00.000" ArgumentSerializable="task 3" SeriesPointID="3"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="04/17/2005 00:00:00.000;05/06/2005 00:00:00.000" ArgumentSerializable="task 4" SeriesPointID="4"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="04/23/2005 00:00:00.000;05/12/2005 00:00:00.000" ArgumentSerializable="task 5" SeriesPointID="6"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:SideBySideGanttSeriesView></dx:SideBySideGanttSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:RangeBarSeriesLabel Indent="3" TextPattern="{V:m}">
					</dx:RangeBarSeriesLabel>
				</LabelSerializable>
			</dx:Series>
			<dx:Series Name="Project 1 : Current Plan" ValueScaleType="DateTime" LabelsVisibility="False">
				<Points>
					<dx:SeriesPoint DateTimeValues="04/22/2005 00:00:00.000;06/17/2005 00:00:00.000" ArgumentSerializable="Project 1" SeriesPointID="0"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="04/22/2005 00:00:00.000;05/17/2005 00:00:00.000" ArgumentSerializable="task 1" SeriesPointID="1"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="05/01/2005 00:00:00.000;06/10/2005 00:00:00.000" ArgumentSerializable="task 2" SeriesPointID="2"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="05/08/2005 00:00:00.000;05/28/2005 00:00:00.000" ArgumentSerializable="task 3" SeriesPointID="3"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="05/09/2005 00:00:00.000;05/30/2005 00:00:00.000" ArgumentSerializable="task 4" SeriesPointID="4"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="05/28/2005 00:00:00.000;06/17/2005 00:00:00.000" ArgumentSerializable="task 5" SeriesPointID="6"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:SideBySideGanttSeriesView></dx:SideBySideGanttSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:RangeBarSeriesLabel Indent="3" TextPattern="{V:m}">
					</dx:RangeBarSeriesLabel>
				</LabelSerializable>
			</dx:Series>
			<dx:Series Name="Project 2 : Original Plan" ValueScaleType="DateTime" LabelsVisibility="False">
				<Points>
					<dx:SeriesPoint DateTimeValues="03/14/2005 00:00:00.000;05/15/2005 00:00:00.000" ArgumentSerializable="Project 2" SeriesPointID="7"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="03/14/2005 00:00:00.000;04/23/2005 00:00:00.000" ArgumentSerializable="task 1" SeriesPointID="8"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="03/21/2005 00:00:00.000;04/09/2005 00:00:00.000" ArgumentSerializable="task 2" SeriesPointID="9"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="03/28/2005 00:00:00.000;04/16/2005 00:00:00.000" ArgumentSerializable="task 3" SeriesPointID="10"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="04/04/2005 00:00:00.000;04/23/2005 00:00:00.000" ArgumentSerializable="task 4" SeriesPointID="11"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="04/26/2005 00:00:00.000;05/15/2005 00:00:00.000" ArgumentSerializable="task 5" SeriesPointID="12"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:SideBySideGanttSeriesView PaneName="Pane 1" AxisXName="secondaryAxisX1"></dx:SideBySideGanttSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:RangeBarSeriesLabel Indent="3" TextPattern="{V:m}">
					</dx:RangeBarSeriesLabel>
				</LabelSerializable>
			</dx:Series>
			<dx:Series Name="Project 2 : Current Plan" ValueScaleType="DateTime" LabelsVisibility="False">
				<Points>
					<dx:SeriesPoint DateTimeValues="04/11/2005 00:00:00.000;06/09/2005 00:00:00.000" ArgumentSerializable="Project 2" SeriesPointID="7"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="04/11/2005 00:00:00.000;05/06/2005 00:00:00.000" ArgumentSerializable="task 1" SeriesPointID="8"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="04/17/2005 00:00:00.000;05/06/2005 00:00:00.000" ArgumentSerializable="task 2" SeriesPointID="9"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="04/29/2005 00:00:00.000;05/17/2005 00:00:00.000" ArgumentSerializable="task 3" SeriesPointID="10"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="05/09/2005 00:00:00.000;05/25/2005 00:00:00.000" ArgumentSerializable="task 4" SeriesPointID="11"></dx:SeriesPoint>
					<dx:SeriesPoint DateTimeValues="05/25/2005 00:00:00.000;06/09/2005 00:00:00.000" ArgumentSerializable="task 5" SeriesPointID="12"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:SideBySideGanttSeriesView PaneName="Pane 1" AxisXName="secondaryAxisX1"></dx:SideBySideGanttSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:RangeBarSeriesLabel Indent="3" TextPattern="{V:m}">
					</dx:RangeBarSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<DiagramSerializable>
			<dx:GanttDiagram PaneDistance="3">
				<AxisX Title-Text="Project 1" VisibleInPanesSerializable="-1">
				</AxisX>
				<AxisY Title-Text="Date" VisibleInPanesSerializable="0" MinorCount="4" Interlaced="True">
					<DateTimeScaleOptions  GridAlignment="Month" AutoGrid="False" GridSpacing="0.5"/>
					<WholeRange Auto="False" MinValueSerializable="03/14/2005 00:00:00.000" MaxValueSerializable="06/21/2005 00:00:00.000" AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
					<GridLines MinorVisible="True"></GridLines>
					<Label TextPattern="{V:m}">
					</Label>
				</AxisY>
				<SecondaryAxesX>
					<dx:SecondaryAxisX AxisID="0" Reverse="True" Title-Text="Project 2" Alignment="Near" VisibleInPanesSerializable="0" Name="secondaryAxisX1">
						<DateTimeScaleOptions ScaleMode="Manual" />                        
					</dx:SecondaryAxisX>
				</SecondaryAxesX>
				<Panes>
					<dx:XYDiagramPane PaneID="0" Weight="1.25" Name="Pane 1"></dx:XYDiagramPane>
				</Panes>
			</dx:GanttDiagram>
		</DiagramSerializable>
		<BorderOptions Visibility="False" />
	</dx:WebChartControl>
</asp:Content>