<%@ Control Language="vb" AutoEventWireup="true" CodeFile="AppointmentForm.ascx.vb"
	Inherits="UserControls_AppointmentForm" %>
<div class="aptDetails">
	<span class="attending" id="lblAttending" runat="server">You're going to attend this
		session. </span>
	<div class="column left">
		<div class="itemHolder">
			<div class="itemName">
				Level:
			</div>
			<div class="itemData">
				<dx:ASPxRatingControl ID="rating" runat="server" ReadOnly="true" FillPrecision="Full"
					CssClass="rating" ItemCount="3" Value='<%#CDec(CInt(Fix((CType(Container, AppointmentFormTemplateContainer)).Appointment.CustomFields(CustomFileldNames.Level))))%>'
					ToolTip='<%#rcGetToolTip()%>'>
				</dx:ASPxRatingControl>
			</div>
		</div>
		<div class="itemHolder">
			<div class="itemName">
				Category:
			</div>
			<div class="itemData">
				<dx:ASPxLabel ID="lblCategory" runat="server" Wrap="false" Text='<%#(CType(Container, AppointmentFormTemplateContainer)).Appointment.CustomFields(CustomFileldNames.CategoryName).ToString()%>' />
			</div>
		</div>
		<div class="itemHolder">
			<div class="itemName">
				Location:
			</div>
			<div class="itemData">
				<dx:ASPxLabel ID="lblLocation" runat="server" Text='<%#(CType(Container, AppointmentFormTemplateContainer)).Appointment.ResourceId%>'
					Wrap="false" />
			</div>
		</div>
	</div>
	<div class="column right">
		<div class="itemHolder">
			<div class="itemName">
				Speaker:
			</div>
			<div class="itemData">
				<dx:ASPxLabel ID="lblSpeaker" runat="server" Text='<%#(CType(Container, AppointmentFormTemplateContainer)).Appointment.CustomFields(CustomFileldNames.Speaker)%>'
					Wrap="false" />
			</div>
		</div>
		<div class="itemHolder">
			<div class="itemName">
				Date:
			</div>
			<div class="itemData">
				<dx:ASPxLabel ID="lblDay" runat="server" Text='<%#(CType(Container, AppointmentFormTemplateContainer)).Appointment.Start.ToShortDateString()%>' />
			</div>
		</div>
		<div class="itemHolder">
			<div class="itemName">
				Time:
			</div>
			<div class="itemData">
				<dx:ASPxLabel ID="lblTime" runat="server" Text='<%#String.Format("{0} - {1}", (CType(Container, AppointmentFormTemplateContainer)).Appointment.Start.ToShortTimeString(), (CType(Container, AppointmentFormTemplateContainer)).Appointment.End.ToShortTimeString())%>' />
			</div>
		</div>
	</div>
	<div class="description">
		<dx:ASPxLabel ID="lblDescription" runat="server" Text='<%#(CType(Container, AppointmentFormTemplateContainer)).Appointment.Description%>' />
	</div>
</div>