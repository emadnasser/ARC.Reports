<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AppointmentForm.ascx.cs"
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
                    CssClass="rating" ItemCount="3" Value='<%# (decimal)(int)((AppointmentFormTemplateContainer)Container).Appointment.CustomFields[CustomFileldNames.Level] %>'
                    ToolTip='<%# rcGetToolTip() %>'>
                </dx:ASPxRatingControl>
            </div>
        </div>
        <div class="itemHolder">
            <div class="itemName">
                Category:
            </div>
            <div class="itemData">
                <dx:ASPxLabel ID="lblCategory" runat="server" Wrap="false" Text='<%# ((AppointmentFormTemplateContainer)Container).Appointment.CustomFields[CustomFileldNames.CategoryName].ToString() %>' />
            </div>
        </div>
        <div class="itemHolder">
            <div class="itemName">
                Location:
            </div>
            <div class="itemData">
                <dx:ASPxLabel ID="lblLocation" runat="server" Text='<%# ((AppointmentFormTemplateContainer)Container).Appointment.ResourceId %>'
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
                <dx:ASPxLabel ID="lblSpeaker" runat="server" Text='<%# ((AppointmentFormTemplateContainer)Container).Appointment.CustomFields[CustomFileldNames.Speaker] %>'
                    Wrap="false" />
            </div>
        </div>
        <div class="itemHolder">
            <div class="itemName">
                Date:
            </div>
            <div class="itemData">
                <dx:ASPxLabel ID="lblDay" runat="server" Text='<%# ((AppointmentFormTemplateContainer)Container).Appointment.Start.ToShortDateString() %>' />
            </div>
        </div>
        <div class="itemHolder">
            <div class="itemName">
                Time:
            </div>
            <div class="itemData">
                <dx:ASPxLabel ID="lblTime" runat="server" Text='<%# string.Format("{0} - {1}", ((AppointmentFormTemplateContainer)Container).Appointment.Start.ToShortTimeString(), ((AppointmentFormTemplateContainer)Container).Appointment.End.ToShortTimeString())  %>' />
            </div>
        </div>
    </div>
    <div class="description">
        <dx:ASPxLabel ID="lblDescription" runat="server" Text='<%# ((AppointmentFormTemplateContainer)Container).Appointment.Description %>' />
    </div>
</div>
