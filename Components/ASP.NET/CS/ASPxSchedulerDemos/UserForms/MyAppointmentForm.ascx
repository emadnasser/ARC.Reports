﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MyAppointmentForm.ascx.cs"
    Inherits="Templates_MyAppointmentForm" %>
<table style="width: 100%; border-collapse: separate; border-spacing: 4px;">
    <tr>
        <td colspan="4" style="width: 100%">
            <dx:ASPxLabel ID="lblDemoShortDescription" runat="server" Text="Fill in the fields according to instructions provided.">
            </dx:ASPxLabel>
            <br />
            <dx:ASPxLabel ID="lblDemoLongDescription" runat="server" Text="The Subject field is required and cannot be left blank. Make sure that the End date does not come before the Start date.">
            </dx:ASPxLabel>
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td style="width: 57px; padding-right: 5px;">
            <dx:ASPxLabel ID="lblSubject" runat="server" Text="Subject:" AssociatedControlID="tbSubject">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxTextBox ID="tbSubject" runat="server" Width="100%" Text='<%# ((MyAppointmentFormTemplateContainer)Container).Subject %>'>
                <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                    <RequiredField ErrorText="The Subject must contain at least one character." IsRequired="True" />
                </ValidationSettings>
                <ClientSideEvents  ValueChanged="function(s, e) { OnUpdateControlValue(s, e); }" KeyUp="function(s,e) { OnUpdateControlValue(s,e); }" />
            </dx:ASPxTextBox>
        </td>
        <td style="padding-right: 5px;">
            <dx:ASPxLabel ID="lblLocation" runat="server" Text="Location:" AssociatedControlID="tbLocation">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxTextBox ID="tbLocation" Width="100%" runat="server" Text='<%#((MyAppointmentFormTemplateContainer)Container).Appointment.Location %>'>
                <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                    <RequiredField IsRequired="true" />
                </ValidationSettings>
                <ClientSideEvents  ValueChanged="function(s, e) { OnUpdateControlValue(s, e); }" KeyUp="function(s,e) { OnUpdateControlValue(s,e); }" />
            </dx:ASPxTextBox>
        </td>
    </tr>
    <tr>
        <td style="white-space: nowrap; padding-right: 5px;">
            <dx:ASPxLabel ID="lblStartTime" runat="server" Text="Start time:" AssociatedControlID="edtStartDate">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxDateEdit ID="edtStartDate" runat="server" Date='<%# ((MyAppointmentFormTemplateContainer)Container).Start %>'
                Width="100%" EditFormat="DateTime" ClientInstanceName="edtStartTimeAppointmentForm">
                <ValidationSettings ErrorDisplayMode="ImageWithTooltip" EnableCustomValidation="True"
                    ValidationGroup="DateValidatoinGroup">
                    <RequiredField ErrorText="The field cannot be blank." IsRequired="True" />
                </ValidationSettings>
                <ClientSideEvents Validation="function(s, e) { OnStartTimeValidate(s, e); }" ValueChanged="function(s, e) {	OnUpdateControlValue(s, e); }" />
            </dx:ASPxDateEdit>
        </td>
        <td style="white-space: nowrap; padding-right: 5px;">
            <dx:ASPxLabel ID="lblEndTime" runat="server" Text="End time:" AssociatedControlID="edtEndDate">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxDateEdit ID="edtEndDate" runat="server" Date='<%# ((MyAppointmentFormTemplateContainer)Container).End %>'
                Width="100%" EditFormat="DateTime" ClientInstanceName="edtEndTimeAppointmentForm">
                <ClientSideEvents Validation="function(s, e) {	OnEndTimeValidate(s, e); }" ValueChanged="function(s, e) { OnUpdateControlValue(s, e); }" />
                <ValidationSettings EnableCustomValidation="True" ErrorDisplayMode="ImageWithTooltip"
                    ValidationGroup="DateValidatoinGroup">
                    <RequiredField ErrorText="Cannot be empty" IsRequired="True" />
                </ValidationSettings>
            </dx:ASPxDateEdit>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <dx:ASPxLabel ID="lblDescription" runat="server" Text="Description:" AssociatedControlID="memDescription">
            </dx:ASPxLabel>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <dx:ASPxMemo ID="memDescription" runat="server" Rows="2" Text='<%#((MyAppointmentFormTemplateContainer)Container).Appointment.Description %>'
                Width="100%">
            </dx:ASPxMemo>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <dx:ASPxLabel ID="lblContactInfo" runat="server" Text="Contact information:" AssociatedControlID="memContacts">
            </dx:ASPxLabel>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <dx:ASPxMemo ID="memContacts" runat="server" Rows="3" Text='<%#((MyAppointmentFormTemplateContainer)Container).ContactInfo %>'
                Width="100%">
            </dx:ASPxMemo>
        </td>
    </tr>
</table>
<dx:AppointmentRecurrenceForm ID="AppointmentRecurrenceForm1" runat="server" IsRecurring='<%# ((AppointmentFormTemplateContainer)Container).Appointment.IsRecurring %>'
    DayNumber='<%# ((MyAppointmentFormTemplateContainer)Container).RecurrenceDayNumber %>'
    End='<%# ((MyAppointmentFormTemplateContainer)Container).RecurrenceEnd %>' Month='<%# ((AppointmentFormTemplateContainer)Container).RecurrenceMonth %>'
    OccurrenceCount='<%# ((MyAppointmentFormTemplateContainer)Container).RecurrenceOccurrenceCount %>'
    Periodicity='<%# ((MyAppointmentFormTemplateContainer)Container).RecurrencePeriodicity %>'
    RecurrenceRange='<%# ((MyAppointmentFormTemplateContainer)Container).RecurrenceRange %>'
    Start='<%# ((MyAppointmentFormTemplateContainer)Container).RecurrenceStart %>'
    WeekDays='<%# ((MyAppointmentFormTemplateContainer)Container).RecurrenceWeekDays %>'
    WeekOfMonth='<%# ((MyAppointmentFormTemplateContainer)Container).RecurrenceWeekOfMonth %>'
    RecurrenceType='<%# ((MyAppointmentFormTemplateContainer)Container).RecurrenceType %>'
    IsFormRecreated='<%# ((MyAppointmentFormTemplateContainer)Container).IsFormRecreated %>'>
</dx:AppointmentRecurrenceForm>
<table style="width: 100%; height: 35px;">
    <tr>
        <td style="width: 100%; height: 100%;" align="center">
            <table style="height: 100%;">
                <tr>
                    <td>
                        <dx:ASPxButton runat="server" ID="btnOk" Text="OK" UseSubmitBehavior="False" AutoPostBack="False"
                            ClientInstanceName="btnMyAppointmentFormOk" EnableViewState="False" Width="91px"
                            ValidationGroup="MyValidationGroup">
                            <ClientSideEvents Init="function(s, e) { OnUpdateControlValue(s, e); }" />
                        </dx:ASPxButton>
                    </td>
                    <td style="padding: 0 4px;">
                        <dx:ASPxButton runat="server" ID="btnCancel" Text="Cancel" UseSubmitBehavior="false"
                            AutoPostBack="false" EnableViewState="false" Width="91px" />
                    </td>
                    <td>
                        <dx:ASPxButton runat="server" ID="btnDelete" Text="Delete" UseSubmitBehavior="false"
                            AutoPostBack="false" EnableViewState="false" Width="91px" Enabled='<%# ((DevExpress.Web.ASPxScheduler.AppointmentFormTemplateContainer)Container).CanDeleteAppointment %>' />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
<table style="width: 100%;">
    <tr>
        <td style="width: 100%;" align="left">
            <dx:ASPxSchedulerStatusInfo runat="server" ID="schedulerStatusInfo" Priority="1"
                MasterControlID='<%# ((DevExpress.Web.ASPxScheduler.AppointmentFormTemplateContainer)Container).ControlId %>' />
        </td>
    </tr>
</table>
<script id="dxss_myAppoinmentForm007" type="text/javascript">
    function OnStartTimeValidate(s, e) {
        if(!e.isValid)
            return;
        var startDate = edtStartTimeAppointmentForm.GetDate();
        var endDate = edtEndTimeAppointmentForm.GetDate();
        e.isValid = startDate == null || endDate == null || startDate < endDate;
        e.errorText = "The Start Date must precede the End Date.";
    }
    function OnEndTimeValidate(s, e) {
        if(!e.isValid)
            return;
        var startDate = edtStartTimeAppointmentForm.GetDate();
        var endDate = edtEndTimeAppointmentForm.GetDate();
        e.isValid = startDate == null || endDate == null || startDate < endDate;
        e.errorText = "The Start Date must precede the End Date.";
    }
    function OnUpdateControlValue(s, e) {
        var isValid = ASPxClientEdit.ValidateEditorsInContainer(null);
        btnMyAppointmentFormOk.SetEnabled(isValid)
    }
    window.setTimeout("ASPxClientEdit.ValidateEditorsInContainer(null)", 0);
</script>