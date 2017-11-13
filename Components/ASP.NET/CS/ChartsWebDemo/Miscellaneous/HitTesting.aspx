<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HitTesting.aspx.cs" Inherits="HitTesting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <script type="text/javascript">
<!--
    var defaultMessage = "<span style=\"white-space:nowrap\">Move the mouse pointer over the chart to see information on hovered chart elements.</span>";
    window.onload = function() {
        var panel = document.getElementById("panel");
        panel.innerHTML = defaultMessage;
        ASPxClientUtils.AttachEventToElement(this, "mousemove", OnMouseMove, false);
        ASPxClientUtils.AttachEventToElement(this, "mouseup", OnMouseUp, false);
    }
    function CalculateRelativeX(x, clickedElement) {
        var left = ASPxClientUtils.GetAbsoluteX(clickedElement);
        return Math.abs(x - left);
    }
    function CalculateRelativeY(y, clickedElement) {
        var top = ASPxClientUtils.GetAbsoluteY(clickedElement);
        return Math.abs(y - top);
    }
    function GetArgumentString(value) {
        if (!(value instanceof Date))
            return value.toString();
        var minutes = value.getMinutes();
        return (value.getMonth() + 1) + "/" + value.getDate() + " " + value.getHours() + ":" + Math.round(minutes / 10).toString() + (minutes % 10).toString();
    }
    function CalculateHitInfo(evt) {
        var x = CalculateRelativeX(ASPxClientUtils.GetEventX(evt), chart.GetMainDOMElement());
        var y = CalculateRelativeY(ASPxClientUtils.GetEventY(evt), chart.GetMainDOMElement());
        var hitObjects = chart.HitTest(x, y);
        return new ASPxClientWebChartHitInfo(hitObjects);
    }
    function IsElementInsideChart(srcElement) {
        return ASPxClientUtils.GetIsParent(chart.GetMainDOMElement(), srcElement);
    }
    function OnMouseUp(evt) {
        var srcElement = ASPxClientUtils.GetEventSource(evt);
        if (!IsElementInsideChart(srcElement))
            return;
        var hitInfo = CalculateHitInfo(evt);
        if (hitInfo.inHyperlink)
            window.open(hitInfo.hyperlink, "_parent ")
    }
    function OnMouseMove(evt) {
        var srcElement = ASPxClientUtils.GetEventSource(evt);
        if (!IsElementInsideChart(srcElement))
            return;
        var hitInfo = CalculateHitInfo(evt);
        var text = "";
        if (hitInfo.inDiagram)
            text += "<br>In diagram";
        if (hitInfo.inNonDefaultPane)
            text += "<br>In non-default pane: " + hitInfo.nonDefaultPane.name;
        if (hitInfo.inAxis) {
            text += "<br>In axis: " + hitInfo.axis.name;
            if (hitInfo.inAxisLabelItem)
                text += "<br>Label item: " + hitInfo.axisLabelItem.text;
            if (hitInfo.inAxisTitle)
                text += "<br>Axis title: " + hitInfo.axisTitle.text;
        }
        if (hitInfo.inChartTitle)
            text += "<br>In chart title: " + hitInfo.chartTitle.lines[0];
        if (hitInfo.inLegend) {
            text += "<br>In legend";
            if (hitInfo.series != null && !hitInfo.inSeries)
                text += "<br>Series: " + hitInfo.series.name;
        }
        if (hitInfo.inSeries)
            text += "<br>In series: " + hitInfo.series.name;
        if (hitInfo.inSeriesLabel) {
            text += "<br>In series label";
            if (!hitInfo.inSeries)
                text += "<br>Series: " + hitInfo.seriesLabel.series.name;
        }
        if (hitInfo.inSeriesPoint) {
            var seriesPoint = hitInfo.seriesPoint;
            text += "<br>Argument: " + GetArgumentString(seriesPoint.argument);
            text += "<br>Value: " + seriesPoint.values[0];
        }
        if (hitInfo.inAnnotation)
            text += "<br>In annotation: " + hitInfo.annotation.name;
        if (hitInfo.inHyperlink) {
            text += "<br>In hyperlink: " + hitInfo.hyperlink;
            srcElement.style.cursor = "pointer";
        }
        else {
            srcElement.style.cursor = "default";
        }
        
        var panel = document.getElementById("panel");
        if (text.length > 0)
            panel.innerHTML = "<span style=\"white-space:nowrap\">Hit-testing results:" + text + "</span>";
        else
            panel.innerHTML = defaultMessage;
    }
    //-->
    </script>
    <table style="width: 100%;">
        <tr>
            <td style="height: 105px" id="panel"></td>
        </tr>
    </table>
    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="480px"
        Width="700px" ClientInstanceName="chart" CrosshairEnabled="False" CssClass="AlignCenter TopLargeMargin"
        ToolTipEnabled="False">
        <SeriesSerializable>
            <dx:Series Name="Temperature (&#176;F)" ArgumentScaleType="DateTime" LabelsVisibility="True">
                <Points>
                    <dx:SeriesPoint Values="56.48" ArgumentSerializable="06/11/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="53.78" ArgumentSerializable="06/11/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="57.74" ArgumentSerializable="06/11/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="64.4" ArgumentSerializable="06/10/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="72.5" ArgumentSerializable="06/10/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="72.68" ArgumentSerializable="06/10/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="69.62" ArgumentSerializable="06/10/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="67.28" ArgumentSerializable="06/10/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="62.42" ArgumentSerializable="06/10/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="60.62" ArgumentSerializable="06/10/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="62.6" ArgumentSerializable="06/10/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="71.96" ArgumentSerializable="06/09/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="77.9" ArgumentSerializable="06/09/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="78.98" ArgumentSerializable="06/09/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="76.28" ArgumentSerializable="06/09/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="71.06" ArgumentSerializable="06/09/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="60.8" ArgumentSerializable="06/09/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="58.64" ArgumentSerializable="06/09/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="63.14" ArgumentSerializable="06/09/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="68.54" ArgumentSerializable="06/08/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="75.2" ArgumentSerializable="06/08/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="77.18" ArgumentSerializable="06/08/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="74.48" ArgumentSerializable="06/08/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="64.58" ArgumentSerializable="06/08/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="59.36" ArgumentSerializable="06/08/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="60.08" ArgumentSerializable="06/08/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="61.16" ArgumentSerializable="06/08/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="63.86" ArgumentSerializable="06/07/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="65.66" ArgumentSerializable="06/07/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="65.12" ArgumentSerializable="06/07/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="63.86" ArgumentSerializable="06/07/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="61.52" ArgumentSerializable="06/07/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="51.8" ArgumentSerializable="06/07/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="52.34" ArgumentSerializable="06/07/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="57.2" ArgumentSerializable="06/07/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="60.44" ArgumentSerializable="06/06/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="65.48" ArgumentSerializable="06/06/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="66.56" ArgumentSerializable="06/06/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="64.04" ArgumentSerializable="06/06/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="60.26" ArgumentSerializable="06/06/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="51.44" ArgumentSerializable="06/06/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="50.18" ArgumentSerializable="06/06/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="56.12" ArgumentSerializable="06/06/2008 00:00:00.000"></dx:SeriesPoint>
                </Points>
                <viewserializable>
                    <dx:LineSeriesView></dx:LineSeriesView>
                </viewserializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel ResolveOverlappingMode="HideOverlapped"></dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Pressure (mbar)" ArgumentScaleType="DateTime" LabelsVisibility="False">
                <Points>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/11/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/11/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/11/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/10/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1020" ArgumentSerializable="06/10/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/10/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/10/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/10/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/10/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/10/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/10/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/09/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/09/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/09/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1024" ArgumentSerializable="06/09/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1024" ArgumentSerializable="06/09/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1024" ArgumentSerializable="06/09/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/09/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1024" ArgumentSerializable="06/09/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1023" ArgumentSerializable="06/08/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/08/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/08/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/08/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1021" ArgumentSerializable="06/08/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1020" ArgumentSerializable="06/08/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1019" ArgumentSerializable="06/08/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1019" ArgumentSerializable="06/08/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1019" ArgumentSerializable="06/07/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1017" ArgumentSerializable="06/07/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1017" ArgumentSerializable="06/07/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1017" ArgumentSerializable="06/07/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1017" ArgumentSerializable="06/07/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1017" ArgumentSerializable="06/07/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1016" ArgumentSerializable="06/07/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1016" ArgumentSerializable="06/07/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1016" ArgumentSerializable="06/06/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1015" ArgumentSerializable="06/06/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1015" ArgumentSerializable="06/06/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1015" ArgumentSerializable="06/06/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1015" ArgumentSerializable="06/06/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1015" ArgumentSerializable="06/06/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1015" ArgumentSerializable="06/06/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="1015" ArgumentSerializable="06/06/2008 00:00:00.000"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:AreaSeriesView Transparency="0" PaneName="Pane 1" AxisYName="secondaryAxisY1" MarkerVisibility="False"></dx:AreaSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:PointSeriesLabel Angle="90" LineLength="5"></dx:PointSeriesLabel>
                </LabelSerializable>
            </dx:Series>
            <dx:Series Name="Relative humidity (%)" ArgumentScaleType="DateTime" LabelsVisibility="False">
                <Points>
                    <dx:SeriesPoint Values="69" ArgumentSerializable="06/11/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="76" ArgumentSerializable="06/11/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="66" ArgumentSerializable="06/11/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="49" ArgumentSerializable="06/10/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="45" ArgumentSerializable="06/10/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="48" ArgumentSerializable="06/10/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="57" ArgumentSerializable="06/10/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="66" ArgumentSerializable="06/10/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="78" ArgumentSerializable="06/10/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="83" ArgumentSerializable="06/10/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="72" ArgumentSerializable="06/10/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="52" ArgumentSerializable="06/09/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="40" ArgumentSerializable="06/09/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="41" ArgumentSerializable="06/09/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="37" ArgumentSerializable="06/09/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="41" ArgumentSerializable="06/09/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="68" ArgumentSerializable="06/09/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="78" ArgumentSerializable="06/09/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="71" ArgumentSerializable="06/09/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="63" ArgumentSerializable="06/08/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="47" ArgumentSerializable="06/08/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="44" ArgumentSerializable="06/08/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="48" ArgumentSerializable="06/08/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="68" ArgumentSerializable="06/08/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="81" ArgumentSerializable="06/08/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="85" ArgumentSerializable="06/08/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="76" ArgumentSerializable="06/08/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="65" ArgumentSerializable="06/07/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="57" ArgumentSerializable="06/07/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="62" ArgumentSerializable="06/07/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="53" ArgumentSerializable="06/07/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="62" ArgumentSerializable="06/07/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="76" ArgumentSerializable="06/07/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="80" ArgumentSerializable="06/07/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="82" ArgumentSerializable="06/07/2008 00:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="73" ArgumentSerializable="06/06/2008 21:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="57" ArgumentSerializable="06/06/2008 18:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="55" ArgumentSerializable="06/06/2008 15:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="64" ArgumentSerializable="06/06/2008 12:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="74" ArgumentSerializable="06/06/2008 09:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="89" ArgumentSerializable="06/06/2008 06:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="87" ArgumentSerializable="06/06/2008 03:00:00.000"></dx:SeriesPoint>
                    <dx:SeriesPoint Values="80" ArgumentSerializable="06/06/2008 00:00:00.000"></dx:SeriesPoint>
                </Points>
                <ViewSerializable>
                    <dx:SideBySideBarSeriesView BarWidth="1.5" PaneName="Pane 2" AxisYName="secondaryAxisY2"></dx:SideBySideBarSeriesView>
                </ViewSerializable>
                <LabelSerializable>
                    <dx:SideBySideBarSeriesLabel Position="Center"></dx:SideBySideBarSeriesLabel>
                </LabelSerializable>
            </dx:Series>
        </SeriesSerializable>
        <Legend AlignmentHorizontal="Left" Direction="LeftToRight" AlignmentVertical="BottomOutside"></Legend>
        <BorderOptions Visibility="False"></BorderOptions>
        <Titles>
            <dx:ChartTitle Text="Weather in London"></dx:ChartTitle>
        </Titles>
        <DiagramSerializable>
            <dx:XYDiagram PaneDistance="4">
                <AxisX Title-Text="Date" VisibleInPanesSerializable="1" Interlaced="True">
                    <DateTimeScaleOptions MeasureUnit="Hour" GridAlignment="Hour" GridSpacing="10" AutoGrid="False"/>
                    <Label Staggered="True" textPattern="{A:dd/MM HH:mm}">
                    </Label>
                    <WholeRange Auto="False" MinValueSerializable="06/05/2008 22:00:00.000" MaxValueSerializable="06/11/2008 08:00:00.000" AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                    <GridLines Visible="True"></GridLines>
                </AxisX>
                <AxisY Title-Text="Temperature, &#176;F" Title-Visibility="True" Title-Font="Tahoma, 9.75pt" VisibleInPanesSerializable="-1">
                    <WholeRange AlwaysShowZeroLevel="False"  ></WholeRange>
                    <GridLines MinorVisible="True"></GridLines>
                </AxisY>
                <SecondaryAxesY>
                    <dx:SecondaryAxisY AxisID="0" Title-Text="Pressure, mbar" Title-Visibility="True" Title-Font="Tahoma, 10pt" Alignment="Near" VisibleInPanesSerializable="0" Name="secondaryAxisY1">
                        <WholeRange Auto="False" MinValueSerializable="1014" MaxValueSerializable="1025" AlwaysShowZeroLevel="False" AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                        <GridLines Visible="True" MinorVisible="True"></GridLines>
                        <NumericScaleOptions AutoGrid="False" GridSpacing="4"/>
                    </dx:SecondaryAxisY>
                    <dx:SecondaryAxisY AxisID="1" Title-Text="Humidity, %" Title-Visibility="True" Title-Font="Tahoma, 10pt" Alignment="Near" VisibleInPanesSerializable="1" Name="secondaryAxisY2">
                        <ConstantLines>
                            <dx:ConstantLine AxisValueSerializable="100" ShowInLegend="False" Title-Visible="False" Name="ConstantLine1"></dx:ConstantLine>
                        </ConstantLines>
                        <WholeRange Auto="False" MinValueSerializable="0" MaxValueSerializable="120" AlwaysShowZeroLevel="False" AutoSideMargins="False" SideMarginsValue="0"></WholeRange>
                        <GridLines Visible="True" MinorVisible="True"></GridLines>
                        <NumericScaleOptions AutoGrid="False" GridSpacing="50"/>
                    </dx:SecondaryAxisY>
                </SecondaryAxesY>
                <DefaultPane Weight="2"></DefaultPane>
                <Panes>
                    <dx:XYDiagramPane PaneID="0" Name="Pane 1"></dx:XYDiagramPane>
                    <dx:XYDiagramPane PaneID="1" Weight="1.7" Name="Pane 2"></dx:XYDiagramPane>
                </Panes>
            </dx:XYDiagram>
        </DiagramSerializable>
        <AnnotationRepository>
            <dx:TextAnnotation ConnectorStyle="None" Font="Tahoma, 10pt" Name="Text Annotation 1" Text="From <href=http://www.weather.com>www.weather.com</href>" TextColor="Gray">
                <Border Visibility="False" />
                <AnchorPointSerializable>
                    <dx:ChartAnchorPoint />
                </AnchorPointSerializable>
                <ShapePositionSerializable>
                    <dx:FreePosition DockCorner="RightBottom">
                    </dx:FreePosition>
                </ShapePositionSerializable>
            </dx:TextAnnotation>
        </AnnotationRepository>
    </dx:WebChartControl>
</asp:Content>
