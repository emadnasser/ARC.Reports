<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind = "Default.aspx.vb" Inherits="_Default" %>
<asp:Content ID="TitleText" ContentPlaceHolderID="TitleTextPlaceHolder" Runat="Server">
DevExpress ASP.NET Control - Touch Demo - Mobile browsers support
</asp:Content>
<asp:Content ID="Header2Text" ContentPlaceHolderID="Header2TextPlaceHolder" Runat="Server">
   Dashboards, Your Way.
</asp:Content>
<asp:Content ID="Header3Text" ContentPlaceHolderID="Header3TextPlaceHolder" Runat="Server">
	FROM DESKTOPS AND BROWSERS TO TABLETS
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
	<script type="text/javascript">
		document.onreadystatechange = function () {
			if (document.readyState == 'complete') {
				var frame = document.getElementById("tbIframe");
				linkTouchEndHandlers(frame);
			}
		}
		function linkTouchEndHandlers(frame) {
			var frameWindow = frame.contentWindow,
				events = [{
					handleEventType: 'pointerout',
					handleEvent: {
						fireEvent: 'pointerup',
						target: frame
					},
				}, {
					handleEventType: 'touchend',
					handleEvent: {
						fireEvent: 'touchend',
						target: window.document
					},
				}, {
					handleEventType: 'mouseup',
					handleEvent: {
						fireEvent: 'mouseup',
						target: window.document
					}
				}, {
					handleEventType: 'mousemove',
					handleEvent: {
						fireEvent: 'mousemove',
						target: window.document
					}
				}];
			events.forEach(function (entry) {
				if (frameWindow.$) {
					var handleEventType = entry.handleEventType,
						handleEvent = entry.handleEvent;
					frameWindow.$(handleEvent.target).off(handleEventType).on(handleEventType, function (event) {
						frameWindow.$(frameWindow.document).trigger(
							createFrameEvent(frameWindow, frame, event, handleEvent.fireEvent)
						);
					});
				}
			});
		}
		function createFrameEvent(frameWindow, frame, sourceEvent, newEventType) {
			var event = frameWindow.$.Event(sourceEvent),
				originalEvent = event.originalEvent,
				propNames = frameWindow.$.event.props.slice(),
				fitCoordinateToLimits = function (coordinate, startValue, length) {
					if (coordinate >= startValue) {
						var fittedValue = coordinate - startValue;
						return fittedValue > length ? length : fittedValue;
					} else {
						return 0;
					}
				};
			frameWindow.$.merge(propNames, frameWindow.$.event.mouseHooks.props);
			propNames.forEach(function (entry) {
				event[entry] = originalEvent[entry];
			});
			var framedX = fitCoordinateToLimits(originalEvent.clientX, frame.offsetLeft, frame.offsetWidth),
				framedY = fitCoordinateToLimits(originalEvent.clientY, frame.offsetTop, frame.offsetHeight);
			(['client', 'page', 'offset', 'screen']).forEach(function (entry) {
				event[entry + 'X'] = framedX;
				event[entry + 'Y'] = framedY;
			});
			return frameWindow.$.extend(event, {
				srcElement: frameWindow.document,
				currentTarget: frameWindow.document,
				target: frameWindow.document,
				view: frameWindow,
				type: newEventType
			});
		}
	</script>
	<div id="tabletViewer" class="horizontal">
		<iframe name="tbIframe" id="tbIframe" scrolling="no" frameborder="0" src='<%=DemoUrl%>'></iframe>
	<%--   <div class="QRCode">
			<a href='<%=DemoUrl%>' target="_blank"><img src='<%=QRCodeUrl%>' alt="QRCode" /></a>
			<div>View on a Tablet</div>
		</div>--%>
	</div>
	<script type="text/javascript" src="<%=Page.ResolveClientUrl("~/Scripts/Demo.js")%>"></script>
</asp:Content>
<asp:Content ID="Links" ContentPlaceHolderID="LinksPlaceHolder" Runat="Server">
	<a class="L1" onclick="if(typeof _gaq != 'undefined') _gaq.push(['_trackEvent', 'ShowTrialRegistration', 'Universal']);" href="http://go.devexpress.com/DevExpressDownload_UniversalTrial.aspx">
		<span class="Head">DOWNLOAD THE FREE TRIAL</span>
		<span class="Body">The DevExpress Universal Trial includes 30 days of free technical support. The DevExpress team is here to help you hit the ground running so you can master our award-winning product in the shortest possible time.</span>
	</a>
	<a class="L2" href="http://go.devexpress.com/DashboardTabletDemo_Video.aspx">
		<span class="Head">WATCH THE VIDEO</span>
		<span class="Body">See how you can quickly create professional dashboards that target multiple devices and web browsers quickly, without hassles.</span>
	</a>
	<a class="L3">
		<span class="Head">BUILD YOUR OWN</span>
		<span class="Body">Reproduce the capabilities in this demo and create dashboards that address the needs of your customers.</span>
	</a>
</asp:Content>