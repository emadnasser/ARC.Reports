<%@ Control Language="vb" AutoEventWireup="true" CodeFile="MyInplaceEditor.ascx.vb"  Inherits="Templates_MyInplaceEditor" %>
<table style="height: 100%; border-collapse: collapse" width="100%">
	<tr>
		<td>
			<div style="background: #73a2bb; color: white; font-weight: bold; padding: 3px; border-bottom: solid 1px #4986a2">
				<table style="width: 100%">
					<tr>
						<td>
							<asp:Label ID="lbAptTime" runat="server" Text='<%#(CType(Container, AppointmentInplaceEditorTemplateContainer)).Appointment.Start.Date.ToShortDateString() & ", " & (CType(Container, AppointmentInplaceEditorTemplateContainer)).Appointment.Start.ToShortTimeString() & " - " & (CType(Container, AppointmentInplaceEditorTemplateContainer)).Appointment.End.ToShortTimeString()%>'></asp:Label>
						</td>
						<td style="text-align: right">
							<img onclick='<%#(CType(Container, AppointmentInplaceEditorTemplateContainer)).CancelScript%>'
								src="../Content/Demo/Close.png" alt="Close" />
						</td>
					</tr>
				</table>
			</div>
			<table style="width: 100%">
				<tr>
					<td style="padding: 8px;">
						<b>Subject:</b>
					</td>
					<td style="width: 100%; padding: 8px;">
						<asp:TextBox ID="txSubject" Text="<%#(CType(Container, AppointmentInplaceEditorTemplateContainer)).Appointment.Subject%>"
							runat="server" Width="100%"></asp:TextBox>
						<div style="font-size: 8pt; margin-top: 4px;">
							for instance, Meeting with friends
						</div>
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr>
		<td style="padding: 8px;">
			<table style="width: 100%">
				<tr>
					<td>
						<input type="button" value="Update" onclick='<%#(CType(Container, AppointmentInplaceEditorTemplateContainer)).SaveScript%>' />
					</td>
					<td style="text-align: right">
						<span style="cursor: pointer; color: blue; text-decoration: underline;" onclick='<%#(CType(Container, AppointmentInplaceEditorTemplateContainer)).EditFormScript%>'>
							More Information&hellip; </span>
					</td>
				</tr>
			</table>
		</td>
	</tr>
</table>