<%@ Control Language="vb" AutoEventWireup="true" CodeFile="HorizontalAlldayAreaAppointment.ascx.vb"
	Inherits="HorizontalAlldayAreaAppointment" %>
<div class="HorizontalAptTemplateDiv">
	<div style="position: absolute; height: 25px; width: 100%; overflow: hidden; left: 2px; top: 2px;">
		<div style="height: 100%; padding: 0 6px;">
			<table style="width: 100%; height: 100%; border-spacing: 1px">
				<tr>
					<td runat="server" id="startTimeClockContainer">
					</td>
					<td style="width: 100%; text-align: center">
						<span style="white-space: normal; color: black;">
							<asp:Label ID="lblSubject" runat="server" Style="font: bold 8pt Tahoma;"></asp:Label>
							<asp:Label ID="lblLocation" runat="server" Style="font: 8pt Tahoma;"></asp:Label>
						</span>
					</td>
					<td runat="server" id="endTimeClockContainer">
					</td>
				</tr>
			</table>
		</div>
	</div>
	<table style="height: 100%; width: 100%; filter: alpha(opacity=80); opacity: 1;">
		<tr>
			<td style="background: url(../Content/AppointmentTemplates/hTopLeftCorner.gif) no-repeat;
				font-size: 0; width: 9px;">
				<div style="width: 9px;">
				</div>
			</td>
			<td style="border-top: solid 1px #7eacb1; background: #f3fef7;width:100%;">
				<div style="height: 5px;">
					&nbsp;</div>
			</td>
			<td style="background: url(../Content/AppointmentTemplates/hTopRightCorner.gif) no-repeat right top;
				font-size: 0; width: 9px;">
				<div style="width: 9px;">
				</div>
			</td>
		</tr>
		<tr>
			<td style="background: url(../Content/AppointmentTemplates/hBottomLeftCorner.gif) no-repeat left bottom;
				font-size: 0">
				<div style="width: 9px;">
				</div>
			</td>
			<td style="border-bottom: solid 1px #7eacb1; background: #f3fef7">
				<div style="height: 5px;">
					&nbsp;</div>
			</td>
			<td style="background: url(../Content/AppointmentTemplates/hBottomRightCorner.gif) no-repeat right bottom;
				font-size: 0">
				<div style="width: 9px;">
				</div>
			</td>
		</tr>
	</table>
</div>