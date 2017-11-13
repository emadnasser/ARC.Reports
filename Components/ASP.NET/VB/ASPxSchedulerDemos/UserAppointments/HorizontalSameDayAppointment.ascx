<%@ Control Language="vb" AutoEventWireup="true" CodeFile="HorizontalSameDayAppointment.ascx.vb"
	Inherits="HorizontalSameDayAppointment" %>
<div class="HorizontalAptTemplateDiv">
	<table style="height: 100%; width: 100%; filter: alpha(opacity=80); opacity: 0.80;">
		<tr>
			<td style="background: url(../Content/AppointmentTemplates/hTopLeftCorner.gif) no-repeat;
				font-size: 0; width: 9px;">
				<div style="width: 9px;">
				</div>
			</td>
			<td style="border-top: solid 1px #7eacb1; background: #f3fef7; width:100%;">
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
	<div style="position: absolute; height: 35px; width: 100%; overflow: hidden; left: 2px;
		top: 2px; text-align: center;">
		<table style="width: 100%">
			<tr>
				<td>
					<asp:Label ID="lblStartTime" runat="server" Style="white-space: normal; font: 8pt Tahoma;
						color: #37414D;" Text='<%#(CType(Container, HorizontalAppointmentTemplateContainer)).Items.StartTimeText.Text%>'
						Visible='<%#(CType(Container, HorizontalAppointmentTemplateContainer)).Items.StartTimeText.Visible%>'></asp:Label>
					-
					<asp:Label ID="lblEndtTime" runat="server" Style="white-space: normal; font: 8pt Tahoma;
						color: #37414D;" Text='<%#(CType(Container, HorizontalAppointmentTemplateContainer)).Items.EndTimeText.Text%>'
						Visible='<%#(CType(Container, HorizontalAppointmentTemplateContainer)).Items.EndTimeText.Visible%>'></asp:Label>
					<table id="imageContainer" runat="server" style="vertical-align: middle;
						display: inline">
					</table>
				</td>
			</tr>
			<tr>
				<td colspan="2">
					<span style="white-space: normal; color: black;">
						<asp:Label ID="lblSubject" runat="server" Style="font: bold 8pt Tahoma;"></asp:Label>
						<asp:Label ID="lblLocation" runat="server" Style="font: 8pt Tahoma;"></asp:Label>
					</span>
				</td>
			</tr>
		</table>
	</div>
</div>