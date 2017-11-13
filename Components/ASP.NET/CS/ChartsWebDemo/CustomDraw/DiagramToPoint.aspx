<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DiagramToPoint.aspx.cs" Inherits="DiagramToPoint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <script type="text/javascript">
<!--
    window.onload = function() {
        ASPxClientUtils.AttachEventToElement(this, "mousedown", OnMouseDown, false);
        ASPxClientUtils.AttachEventToElement(this, "mouseup", OnMouseUp, false);
        ASPxClientUtils.AttachEventToElement(this, "mousemove", OnMouseMove, false);
        PreventChartDragAndSelect();
    }
    var firstLocationRelativeX;
    var firstLocationRelativeY;
    var firstLocationX;
    var firstLocationY;
    var canManuallyCustomize = false;
    var frame;
    function PreventChartDragAndSelect() {
        ASPx.Evt.PreventElementDragAndSelect(chart.GetMainDOMElement(), false, false);
    }
    function CalculateRelativeX(x,clickedElement) {
        var left = ASPxClientUtils.GetAbsoluteX(clickedElement);
        return x - left;
    }
    function CalculateRelativeY(y,clickedElement) {
        var top = ASPxClientUtils.GetAbsoluteY(clickedElement);
        return y - top;
    }
    function GetDiagramBounds() {
        var diagram = chart.GetChart().diagram;
        var minCoord = diagram.DiagramToPoint(diagram.axisX.range.minValue,diagram.axisY.range.minValue,diagram.axisX,diagram.axisY,diagram.defaultPane);
        var maxCoord = diagram.DiagramToPoint(diagram.axisX.range.maxValue,diagram.axisY.range.maxValue,diagram.axisX,diagram.axisY,diagram.defaultPane);
        minX = minCoord.x;
        minY = maxCoord.y;
        maxX = maxCoord.x;
        maxY = minCoord.y;
        return { left: minX,top: minY,right: maxX,bottom: maxY };
    }
    function IsPointInBounds() {
        var diagram = chart.GetChart().diagram;
        var bounds = GetDiagramBounds();
        if (bounds.left < firstLocationRelativeX && firstLocationRelativeX < bounds.right &&
            bounds.top < firstLocationRelativeY && firstLocationRelativeY < bounds.bottom)
            return true;
        return false;
    }
    function GetLastLocationCoordinates(x,y) {
        var diagram = chart.GetChart().diagram;
        var bounds = GetDiagramBounds();
        if (x < bounds.left)
            x = bounds.left;
        else if (x > bounds.right)
            x = bounds.right;
        if (y < bounds.top)
            y = bounds.top;
        else if (y > bounds.bottom)
            y = bounds.bottom;
        return { x: x,y: y };
    }
    function CreateFrame() {
        var element = chart.mainElement;
        frame = document.createElement("DIV");
        element.parentNode.appendChild(frame);
        frame.style.backgroundColor = "#f1ea6f";
        frame.style.border = "1px solid";
        frame.style.borderColor = "#baa500";
        if (ASPxClientUtils.ie)
            frame.style.filter = "alpha(opacity=50)";
        else
            frame.style.opacity = "0.5";
        frame.style.position = "absolute";
        frame.style.display = "none";
    }
    function SetFrameBounds(transientLocationX,transientLocationY) {
        var width,height,top,left;
        var bounds = GetDiagramBounds();
        if (transientLocationX >= firstLocationX) {
            width = transientLocationX - firstLocationX;
            if (firstLocationRelativeX + width > bounds.right)
                width = bounds.right - firstLocationRelativeX - 1;
            left = firstLocationX;
        }
        else {
            width = firstLocationX - transientLocationX;
            if (firstLocationRelativeX - width < bounds.left)
                width = firstLocationRelativeX - bounds.left;
            left = firstLocationX - width;
        }
        if (transientLocationY >= firstLocationY) {
            height = transientLocationY - firstLocationY;
            if (firstLocationRelativeY + height > bounds.bottom)
                height = bounds.bottom - firstLocationRelativeY - 1;
            top = firstLocationY;
        }
        else {
            height = firstLocationY - transientLocationY;
            if (firstLocationRelativeY - height < bounds.top)
                height = firstLocationRelativeY - bounds.top;
            top = firstLocationY - height;
        }
        ASPxClientUtils.SetAbsoluteX(frame, left);
        ASPxClientUtils.SetAbsoluteY(frame, top);
        frame.style.width = width + "px";
        frame.style.height = height + "px";
    }
    function OnMouseDown(evt) {
        if (ASPx.Evt.IsLeftButtonPressed(evt)) {
            var srcElement = ASPxClientUtils.GetEventSource(evt);
            if (!ASPxClientUtils.GetIsParent(chart.GetMainDOMElement(),srcElement))
                return false;
            if (!canManuallyCustomize) {
                CreateFrame();
                firstLocationX = ASPxClientUtils.GetEventX(evt);
                firstLocationY = ASPxClientUtils.GetEventY(evt);
                firstLocationRelativeX = CalculateRelativeX(firstLocationX,chart.GetMainDOMElement());
                firstLocationRelativeY = CalculateRelativeY(firstLocationY,chart.GetMainDOMElement());
            }
            canManuallyCustomize = false;
            if (chbAutoMode.GetChecked()) {
                var parameter = Math.ceil(firstLocationRelativeX) + " " + Math.ceil(firstLocationRelativeY);
                callbackPanel.PerformCallback(parameter);
            }
            else {
                if (IsPointInBounds()) {
                    canManuallyCustomize = true;
                    frame.style.display = "";
                }
            }
        }
        if (!ASPxClientUtils.ie || ASPxClientUtils.BrowserVersion >= 9) {
            evt.preventDefault();
            return false;
        }
    }
    function OnMouseMove(evt) {
        if (canManuallyCustomize) {
            var transientLocationX = ASPxClientUtils.GetEventX(evt) 
            var transientLocationY = ASPxClientUtils.GetEventY(evt) 
            SetFrameBounds(transientLocationX,transientLocationY);
        }
    }
    function OnMouseUp(evt) {
        if (canManuallyCustomize) {
            canManuallyCustomize = false;
            lastLocationX = CalculateRelativeX(ASPxClientUtils.GetEventX(evt), chart.GetMainDOMElement());
            lastLocationY = CalculateRelativeY(ASPxClientUtils.GetEventY(evt), chart.GetMainDOMElement());
            lastLocationX = GetLastLocationCoordinates(lastLocationX,lastLocationY).x;
            lastLocationY = GetLastLocationCoordinates(lastLocationX,lastLocationY).y;
            if (lastLocationX == firstLocationRelativeX && lastLocationY == firstLocationRelativeY)
                return;
            var diagram = chart.GetChart().diagram;
            var firstCoord = diagram.PointToDiagram(firstLocationRelativeX,firstLocationRelativeY);
            var lastCoord = diagram.PointToDiagram(lastLocationX,lastLocationY);
            var parameter = firstCoord.numericalArgument + " " + firstCoord.numericalValue + " " + lastCoord.numericalArgument + " " + lastCoord.numericalValue;
            callbackPanel.PerformCallback(parameter);
        }
    }
    //-->
    </script>
    <dx:ASPxCallbackPanel ID="callbackPanel" runat="server" OnCallback="callbackPanel_Callback" ClientInstanceName="callbackPanel">
        <ClientSideEvents EndCallback="function(){ PreventChartDragAndSelect(); }" />
        <PanelCollection>
            <dx:PanelContent runat="server">
                <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" ShowHeader="False">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent2" runat="server">
                            <table style="width: 100%;">
                                <tr>
                                    <td>
                                        <dx:ASPxCheckBox ID="cbShowLabels" runat="server" Text="Show Labels" Width="95px">
                                            <ClientSideEvents CheckedChanged="function(s, e) { callbackPanel.PerformCallback(&quot;ShowLabels&quot;); }" />
                                        </dx:ASPxCheckBox>
                                    </td>
                                    <td>
                                        <div class="Spacer" style="width: 20px;"></div>
                                    </td>
                                    <td style="width: 100%;">
                                        <dx:ASPxCheckBox ID="cbAutoMode" runat="server" Text="Auto Mode" Width="95px" ClientInstanceName="chbAutoMode">
                                            <ClientSideEvents CheckedChanged="function(s, e) { callbackPanel.PerformCallback(&quot;AutoMode&quot;); }" />
                                        </dx:ASPxCheckBox>
                                    </td>
                                    <td>
                                        <dx:ASPxButton ID="btnCreatePoints" runat="server" Text="Create Points" Width="140px" AutoPostBack="False">
                                            <ClientSideEvents Click="function(s, e) { callbackPanel.PerformCallback(&quot;CreatePoints&quot;); }" />
                                        </dx:ASPxButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="Spacer" style="width: 100%;height: 5px"></div>
                                    </td>
                                </tr>
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxRoundPanel>
                <dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" 
                    Width="550px"  ClientInstanceName="chart" CssClass="TopLargeMargin" style="float: left;"
                    OnCustomPaint="WebChartControl1_CustomPaint" EnableClientSideAPI="True" 
                    EnableViewState="False" CrosshairEnabled="False" ToolTipEnabled="False">
                    <SeriesSerializable>
                        <dx:Series Name="RangomSeries" ArgumentScaleType="Numerical" LabelsVisibility="False">
                            <ViewSerializable>
                                <dx:PointSeriesView></dx:PointSeriesView>
                            </ViewSerializable>
                            <LabelSerializable>
                                <dx:PointSeriesLabel Font="Tahoma, 6pt" ResolveOverlappingMode="HideOverlapped" TextPattern="{V:F2}">
                                </dx:PointSeriesLabel>
                            </LabelSerializable>
                        </dx:Series>
                    </SeriesSerializable>
                    <Legend Visibility="False"></Legend>
                    <BorderOptions Visibility="False" />
                    <Titles>
                        <dx:ChartTitle Text="Random Points Generator"></dx:ChartTitle>
                    </Titles>
                    <DiagramSerializable>
                        <dx:XYDiagram>
                            <AxisX VisibleInPanesSerializable="-1">
                                
                                <GridLines Visible="True" MinorVisible="True"></GridLines>
                            </AxisX>
                            <AxisY VisibleInPanesSerializable="-1" MinorCount="4">
                                
                                <GridLines MinorVisible="True"></GridLines>
                            </AxisY>
                        </dx:XYDiagram>
                    </DiagramSerializable>
                </dx:WebChartControl>
                <dx:ASPxListBox  ID="lbSelectedPoints" runat="server" Height="383px" Width="141px" Font-Names="Courier New" EnableViewState="False" CssClass="TopLargeMargin" style="float: left; margin-left: 16px">
                    <ItemStyle>
                        <Paddings Padding="0px" PaddingBottom="1px" PaddingLeft="6px" PaddingTop="0px" />
                    </ItemStyle>
                </dx:ASPxListBox>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
</asp:Content>
