<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSide.aspx.vb"
	Inherits="Timer_ClientSide" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		var demoCounter;
		function demoGetTextElement(index) {
			return document.getElementById("demoInfo" + index);
		}
		function demoGetButtonElement() {
			return document.getElementById("demoButton");
		}
		function demoInit() {
			demoCounter = 15;
			demoGetButtonElement().disabled = true;
			demoGetTextElement(1).style.display = "block";
			demoGetTextElement(2).style.display = "none";
			demoUpdate();
		}
		function demoTick() {
			demoCounter -= 1;
			demoUpdate();
		}
		function demoUpdate() {
			if (demoCounter > 0)
				document.getElementById("demoCountdown").innerHTML = demoCounter;
			else {
				Timer1.SetEnabled(false);
				demoGetButtonElement().disabled = false;
				demoGetTextElement(1).style.display = "none";
				demoGetTextElement(2).style.display = "block";
			}
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table style="width:100%; height: 170px;">
		<tr>
			<td style="text-align: center">
				<p id="demoInfo1" style="display: none">
					You have requested a file for downloading.
					<br />
					<br />
					Download ticket reserved. Your download will be ready in <span id="demoCountdown"
						style="font-weight: bold; color: #59A1E9;">&nbsp;</span> seconds.
				</p>
				<p id="demoInfo2" style="text-align: center; display: none;">
					Click the button to run again.
				</p>
				<input style="width: 150px; height: 36px; font-size: 14px; margin: 16px 0 32px" id="demoButton" type="button"
					disabled="disabled" value="Download" onclick="Timer1.SetEnabled(true); demoInit()" />
			</td>
		</tr>
	</table>
	<dx:ASPxTimer ID="ASPxTimer1" runat="server" Interval="1000" ClientInstanceName="Timer1">
		<ClientSideEvents Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init'); demoInit(); }"
			Tick="function(s, e) { DXEventMonitor.Trace(s, e, 'Tick'); demoTick(); }" />
	</dx:ASPxTimer>
	<dx:EventMonitor runat="server" ID="EventMonitor" EventNames="Init Tick" EventLogWidth="690" />
</asp:Content>