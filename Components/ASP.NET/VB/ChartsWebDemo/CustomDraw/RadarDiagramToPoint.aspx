<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RadarDiagramToPoint.aspx.vb" Inherits="RadarDiagramToPoint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<script type="text/javascript">
<!--
	var target1,target2,target3;
	var image1,image2,image3;
	var hitImage1,hitImage2,hitImage3;
	var isHit1 = false;
	var isHit2 = false;
	var isHit3 = false;
	var angle1 = Math.PI / 2;
	var angle2 = 0;
	var angle3 = -Math.PI / 2;
	var horizontalLine,verticalLine;
	var previousTime = new Date();
	var delayTime = 0;
	var centerX;
	var centerY;
	var radius;
	window.onload = function() {
		ASPx.Evt.PreventElementDragAndSelect(chart.GetMainDOMElement(), false, false);
		ASPxClientUtils.AttachEventToElement(this, "mousedown", OnMouseDown, false);
		ASPxClientUtils.AttachEventToElement(this, "mousemove", OnMouseMove, false);
		CreateElements();
		MoveTargets();
	}
	function CreateElements() {
		var diagram = window.chart.GetChart().diagram;
		var first = CreateTarget(0,diagram.axisY.range.minValue);
		target1 = first.target;
		image1 = first.image;
		var second = CreateTarget(45,diagram.axisY.range.maxValue / 2);
		target2 = second.target;
		image2 = second.image;
		var third = CreateTarget(315,diagram.axisY.range.maxValue / 2);
		target3 = third.target;
		image3 = third.image;
		CreateHitImages();
		CreateCross();
	}
	function CreateTarget(valueAxisX,valueAxisY) {
		var element = chart.mainElement;
		var target = document.createElement("DIV");
		element.parentNode.appendChild(target);
		target.style.position = "absolute";
		var image = document.createElement("img");
		image.setAttribute("src","../Content/Demo/Bug.png");
		target.appendChild(image);
		var diagram = window.chart.GetChart().diagram;
		var point = diagram.DiagramToPoint(valueAxisX,valueAxisY);
		ASPxClientUtils.SetAbsoluteX(target, CalculateAbsoluteX(point.x, element));
		ASPxClientUtils.SetAbsoluteY(target, CalculateAbsoluteY(point.y, element));
		return { target: target,image: image }
	}
	function CreateHitImages() {
		hitImage1 = document.createElement("img");
		hitImage1.setAttribute("src","../Content/Demo/NoBug.png");
		hitImage2 = document.createElement("img");
		hitImage2.setAttribute("src","../Content/Demo/NoBug.png");
		hitImage3 = document.createElement("img");
		hitImage3.setAttribute("src","../Content/Demo/NoBug.png");
	}
	function CreateCross() {
		var element = chart.mainElement;
		horizontalLine = CreateLine(48,0);
		verticalLine = CreateLine(0,48);
		element.parentNode.appendChild(horizontalLine);
		element.parentNode.appendChild(verticalLine);
	}
	function CreateLine(width,height) {
		var line = document.createElement("DIV");
		line.style.border = "1px solid";
		line.style.borderColor = "#494b6c";
		line.style.position = "absolute";
		line.style.display = "none";
		line.style.width = width + "px";
		line.style.height = height + "px";
		return line;
	}
	function CalculateCircle() {
		var diagram = window.chart.GetChart().diagram;
		var center = diagram.DiagramToPoint(0,diagram.axisY.range.minValue);
		var circlePoint = diagram.DiagramToPoint(0,diagram.axisY.range.maxValue);
		raduis = center.y - circlePoint.y;
		centerX = CalculateAbsoluteX(center.x,chart.mainElement);
		centerY = CalculateAbsoluteY(center.y,chart.mainElement);
	}
	function MoveTargets() {
		var currentTime = new Date();
		var timeSpan = currentTime - previousTime;
		if (timeSpan >= 100) {
			previousTime = currentTime;
			if (isHit1 && isHit2 && isHit3) {
				if (delayTime > 20) {
					delayTime = 0;
					isHit1 = false;
					isHit2 = false;
					isHit3 = false;
					ChangeImages(hitImage1,image1,target1);
					ChangeImages(hitImage2,image2,target2);
					ChangeImages(hitImage3,image3,target3);
				}
				else
					delayTime += 1;
			}
			else {
				CalculateCircle();
				if (!isHit1)
					angle1 = MoveTarget(target1,image1,angle1);
				if (!isHit2)
					angle2 = MoveTarget(target2,image2,angle2);
				if (!isHit3)
					angle3 = MoveTarget(target3,image3,angle3);
			}
		}
		window.setTimeout("MoveTargets()",100);
	}
	function MoveTarget(target,image,angle) {
		var left = ASPxClientUtils.GetAbsoluteX(target);
		var top = ASPxClientUtils.GetAbsoluteY(target);
		var imageCenterX = left + image.width / 2;
		var imageCenterY = top + image.height / 2;
		do {
			var extraAngle = GetRandom(-Math.PI / 8,Math.PI / 8);
			angle = angle + extraAngle;
			var stepX = 5 * Math.cos(angle);
			var stepY = 5 * Math.sin(angle);
			var deltaX = centerX - imageCenterX - stepX;
			var deltaY = centerY - imageCenterY - stepY;
			var r = Math.sqrt(deltaX * deltaX + deltaY * deltaY);
		} while (r > raduis);
		ASPxClientUtils.SetAbsoluteX(target, left + stepX);
		ASPxClientUtils.SetAbsoluteY(target, top + stepY);
		return angle;
	}
	function GetRandom(min,max) {
		return Math.random() * (max - min) + min;
	}
	function ChangeImages(oldImage,newImage,target) {
		target.removeChild(oldImage);
		target.appendChild(newImage);
	}
	function CheckHit(x,y,target,image,hitImage,isHit) {
		var left = ASPxClientUtils.GetAbsoluteX(target);
		var top = ASPxClientUtils.GetAbsoluteY(target);
		if (!isHit && left + 13 <= x && x <= left + image.width - 13 && top + 8 <= y && y <= top + image.height - 8) {
			ChangeImages(image,hitImage,target);
			isHit = true;
		}
		return isHit;
	}
	function CalculateAbsoluteX(relativeX,element) {
		var left = ASPxClientUtils.GetAbsoluteX(element);
		return relativeX + left;
	}
	function CalculateAbsoluteY(relativeY,element) {
		var top = ASPxClientUtils.GetAbsoluteY(element);
		return relativeY + top;
	}
	function IsPointInChartBounds(x,y) {
		var left = ASPxClientUtils.GetAbsoluteX(chart.GetMainDOMElement());
		var right = left + chart.GetWidth();
		var top = ASPxClientUtils.GetAbsoluteY(chart.GetMainDOMElement());
		var bottom = top + chart.GetHeight();
		if (left < x && x < right && top < y && y < bottom)
			return true;
		return false;
	}
	function OnMouseDown(evt) {
		var x = ASPxClientUtils.GetEventX(evt);
		var y = ASPxClientUtils.GetEventY(evt);
		isHit1 = CheckHit(x,y,target1,image1,hitImage1,isHit1);
		isHit2 = CheckHit(x,y,target2,image2,hitImage2,isHit2);
		isHit3 = CheckHit(x,y,target3,image3,hitImage3,isHit3);
	}
	function OnMouseMove(evt) {
		var x = ASPxClientUtils.GetEventX(evt);
		var y = ASPxClientUtils.GetEventY(evt);
		if (!IsPointInChartBounds(x,y)) {
			horizontalLine.style.display = "none";
			verticalLine.style.display = "none";
			return false;
		}
		horizontalLine.style.display = "";
		verticalLine.style.display = "";
		ASPxClientUtils.SetAbsoluteX(horizontalLine, x - horizontalLine.clientWidth / 2);
		ASPxClientUtils.SetAbsoluteY(horizontalLine, y);
		ASPxClientUtils.SetAbsoluteX(verticalLine, x);
		ASPxClientUtils.SetAbsoluteY(verticalLine, y - verticalLine.clientHeight / 2);
		if (ASPxClientUtils.ie)
			MoveTargets();
	}
	//-->
	</script>
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px" Width="700px" CssClass="AlignCenter TopLargeMargin"
		ClientInstanceName="chart" EnableClientSideAPI="True" EnableViewState="False">
		<SeriesSerializable>
			<dx:Series Name="Population 1" ArgumentScaleType="Numerical" LabelsVisibility="False">
				<ViewSerializable>
					<dx:PolarPointSeriesView></dx:PolarPointSeriesView>
				</ViewSerializable>
				<LabelSerializable>
					<dx:RadarPointSeriesLabel Font="Tahoma, 6pt" ResolveOverlappingMode="HideOverlapped"></dx:RadarPointSeriesLabel>
				</LabelSerializable>
			</dx:Series>
		</SeriesSerializable>
		<Legend Visibility="False"></Legend>
		<BorderOptions Visibility="False" />
		<Titles>
			<dx:ChartTitle Text="Hit the Target"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:PolarDiagram>
				<AxisX Interlaced="True"></AxisX>
				<AxisY Visible="False">
					<WholeRange Auto="False" MinValueSerializable="0" MaxValueSerializable="20"  ></WholeRange>
				</AxisY>
			</dx:PolarDiagram>
		</DiagramSerializable>
	</dx:WebChartControl>
</asp:Content>