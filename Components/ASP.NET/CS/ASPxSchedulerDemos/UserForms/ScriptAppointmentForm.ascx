<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ScriptAppointmentForm.ascx.cs"
    Inherits="UserForms_ScriptAppointmentForm" %>
<%@ Register Src="~/UserForms/ScriptRecurrenceForm.ascx" TagName="RecurrenceControl" TagPrefix="demo" %>
<table class="dxscAppointmentForm" id="ClientAppointmentForm" style="width: 500px;
    height: 100px;">
    <tr>
        <td class="dxscDoubleCell" colspan="2">
            <table class="dxscLabelControlPair">
                <tr>
                    <td class="dxscLabelCell">
                        <dx:ASPxLabel ID="lblSubject" runat="server" AssociatedControlID="tbSubject" Text="Subject:">
                        </dx:ASPxLabel>
                    </td>
                    <td class="dxscControlCell">
                        <dx:ASPxTextBox ID="tbSubject" runat="server" Width="100%" EnableClientSideAPI="true" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="dxscSingleCell">
            <table class="dxscLabelControlPair">
                <tr>
                    <td class="dxscLabelCell">
                        <dx:ASPxLabel ID="lblLocation" runat="server" AssociatedControlID="tbLocation" Text="Location:">
                        </dx:ASPxLabel>
                    </td>
                    <td class="dxscControlCell">
                        <dx:ASPxTextBox ID="tbLocation" runat="server" Width="100%" EnableClientSideAPI="true" />
                    </td>
                </tr>
            </table>
        </td>
        <td class="dxscSingleCell">
            <table class="dxscLabelControlPair">
                <tr>
                    <td class="dxscLabelCell" style="padding-left: 25px;">
                        <dx:ASPxLabel ID="lblLabel" runat="server" AssociatedControlID="edtLabel" Text="Label:">
                        </dx:ASPxLabel>
                    </td>
                    <td class="dxscControlCell">
                        <dx:ASPxComboBox ID="edtLabel" runat="server" Width="100%" DataSource='<%# LabelDataSource %>' />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="dxscSingleCell">
            <table class="dxscLabelControlPair">
                <tr>
                    <td class="dxscLabelCell">
                        <dx:ASPxLabel ID="lblStartDate" runat="server" AssociatedControlID="edtStartDate"
                            Text="Start time:">
                        </dx:ASPxLabel>
                    </td>
                    <td class="dxscControlCell">
                        <dx:ASPxDateEdit ID="edtStartDate" runat="server" Width="100%" EditFormat="DateTime" >
                            <ValidationSettings ErrorDisplayMode="ImageWithTooltip" EnableCustomValidation="True" Display="Dynamic"
                                ValidationGroup="DateValidatoinGroup">
                            </ValidationSettings>
                        </dx:ASPxDateEdit>
                    </td>
                </tr>
            </table>
        </td>
        <td class="dxscSingleCell">
            <table class="dxscLabelControlPair">
                <tr>
                    <td class="dxscLabelCell" style="padding-left: 25px;">
                        <dx:ASPxLabel runat="server" ID="lblEndDate" Text="End time:" AssociatedControlID="edtEndDate" />
                    </td>
                    <td class="dxscControlCell">
                        <dx:ASPxDateEdit ID="edtEndDate" runat="server" EditFormat="DateTime" Width="100%">
                            <ValidationSettings EnableCustomValidation="True" ErrorDisplayMode="ImageWithTooltip"  Display="Dynamic"
                                ValidationGroup="DateValidatoinGroup">
                            </ValidationSettings>
                        </dx:ASPxDateEdit>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="dxscSingleCell">
            <table class="dxscLabelControlPair">
                <tr>
                    <td class="dxscLabelCell">
                        <dx:ASPxLabel ID="lblStatus" runat="server" AssociatedControlID="edtStatus" Text="Show time as:">
                        </dx:ASPxLabel>
                    </td>
                    <td class="dxscControlCell">
                        <dx:ASPxComboBox ID="edtStatus" runat="server" Width="100%" DataSource='<%# StatusDataSource %>' />
                    </td>
                </tr>
            </table>
        </td>
        <td class="dxscSingleCell" style="padding-left: 22px;">
            <table class="dxscLabelControlPair">
                <tr>
                    <td style="width: 20px; height: 20px;">
                        <dx:ASPxCheckBox ID="chkAllDay" runat="server" />
                    </td>
                    <td style="padding-left: 2px;">
                        <dx:ASPxLabel ID="lblAllDay" runat="server" Text="All day event" AssociatedControlID="chkAllDay" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="dxscSingleCell" colspan="2">
            <table class="dxscLabelControlPair">
                <tr>
                    <td class="dxscLabelCell">
                        <dx:ASPxLabel ID="lblResource" runat="server" AssociatedControlID="edtResource" Text="Resource:">
                        </dx:ASPxLabel>
                    </td>
                    <td class="dxscControlCell">
                        <dx:ASPxComboBox ID="edtResource" runat="server" Width="100%" DataSource='<%# ResourceDataSource %>' />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="dxscDoubleCell" colspan="2" style="height: 90px;">
            <dx:ASPxMemo ID="tbDescription" runat="server" Width="100%" Rows="6" EnableClientSideAPI="true" />
        </td>
    </tr>
</table>
<dx:ASPxCheckBox ID="chkRecurrence" runat="server" Text="Recurrence">
</dx:ASPxCheckBox>
<demo:RecurrenceControl runat="server" ID="recurrenceControl"></demo:RecurrenceControl>
<table style="width: 500px; height: 35px;">
    <tr>
        <td style="width: 100%; height: 100%;">
            <table style="height: 100%; margin: 0 auto;">
                <tr>
                    <td>
                        <dx:ASPxButton runat="server" ID="btnOk" Text="OK" UseSubmitBehavior="false" AutoPostBack="false" EnableClientSideAPI="true"
                            EnableViewState="false" Width="91px" />
                    </td>
                    <td style="padding: 0 4px;">
                        <dx:ASPxButton runat="server" ID="btnCancel" Text="Cancel" UseSubmitBehavior="false"
                            AutoPostBack="false" EnableViewState="false" Width="91px" CausesValidation="False" />
                    </td>
                    <td>
                        <dx:ASPxButton runat="server" ID="btnDelete" Text="Delete" EnableClientSideAPI="true"
                            UseSubmitBehavior="false" AutoPostBack="false" EnableViewState="false" Width="91px" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
<script id="dxss_ASPxSchedulerClientAppoinmentForm" type="text/javascript">
// <![CDATA[
    ASPxClientAppointmentForm = ASPx.CreateClass(ASPxClientFormBase, {
        Initialize: function () {
            this.controls.btnOk.Click.AddHandler(ASPx.CreateDelegate(this.OnBtnOkClick, this));
            this.controls.btnCancel.Click.AddHandler(ASPx.CreateDelegate(this.OnBtnCancelClick, this));
            this.controls.btnDelete.Click.AddHandler(ASPx.CreateDelegate(this.OnBtnDeleteClick, this));
            this.controls.chkRecurrence.CheckedChanged.AddHandler(ASPx.CreateDelegate(this.OnChkRecurrenceChanged, this));
            this.controls.edtStartDate.Validation.AddHandler(ASPx.CreateDelegate(this.OnEdtStartDateValidate, this));
            this.controls.edtStartDate.ValueChanged.AddHandler(ASPx.CreateDelegate(this.OnUpdateStartEndValue, this));
            this.controls.edtEndDate.Validation.AddHandler(ASPx.CreateDelegate(this.OnEdtEndDateValidate, this));
            this.controls.edtEndDate.ValueChanged.AddHandler(ASPx.CreateDelegate(this.OnUpdateStartEndValue, this));
        },
        OnUpdateStartEndValue: function(s, e) {
            var isValid = ASPxClientEdit.ValidateEditorsInContainer(null);
            this.controls.btnOk.SetEnabled(isValid)
        },
        OnEdtStartDateValidate: function(s, e) {
            if(!e.isValid)
                return;
            var startDate = this.controls.edtStartDate.GetDate();
            var endDate = this.controls.edtEndDate.GetDate();
            e.isValid = startDate == null || endDate == null || startDate < endDate;
            e.errorText = "The Start Date must precede the End Date.";
        },
        OnEdtEndDateValidate: function(s, e) {
            if(!e.isValid)
                return;
            var startDate = this.controls.edtStartDate.GetDate();
            var endDate = this.controls.edtEndDate.GetDate();
            e.isValid = startDate == null || endDate == null || startDate < endDate;
            e.errorText = "The Start Date must precede the End Date.";
        },
        OnBtnOkClick: function (s, e) {
            var apt = this.Parse();
            var recurrenceInfo = apt.GetRecurrenceInfo();
            if(recurrenceInfo && recurrenceInfo.GetRange() == "EndByDate" && apt.GetStart() > recurrenceInfo.GetEnd())
                apt.GetRecurrenceInfo().SetEnd(apt.GetStart());
            this.Close();
            if(apt.appointmentId)
                this.scheduler.UpdateAppointment(apt);
            else
                this.scheduler.InsertAppointment(apt);
        },
        OnBtnCancelClick: function (s, e) {
            this.Close();
        },
        OnBtnDeleteClick: function (s, e) {
            var apt = this.Parse();
            this.Close();
            this.scheduler.DeleteAppointment(apt);
        },
        OnChkRecurrenceChanged: function (s, e) {
            var isChecked = s.GetChecked();
            this.controls.recurrenceControl.SetVisible(isChecked);
        },
        Parse: function () {
            var start = this.controls.edtStartDate.GetDate();
            var end = this.controls.edtEndDate.GetDate();
            var subject = this.controls.tbSubject.GetText();
            var description = this.controls.tbDescription.GetText();
            var location = this.controls.tbLocation.GetText();
            var labelId = this.controls.edtLabel.GetValue();
            var statusId = this.controls.edtStatus.GetValue();
            var allDay = this.controls.chkAllDay.GetChecked();
            var resourceId = this.controls.edtResource.GetValue();
            var apt = new ASPxClientAppointment();
            apt.SetAppointmentType(ASPxAppointmentType.Normal);
            apt.SetStart(start);
            apt.SetEnd(end);
            apt.SetSubject(subject);
            apt.SetDescription(description);
            apt.SetLocation(location);
            apt.SetLabelId(labelId);
            apt.SetStatusId(statusId);
            apt.SetAllDay(allDay);
            apt.AddResource(resourceId);
            if(this.appointmentCopy && this.appointmentCopy.GetId())
                apt.SetId(this.appointmentCopy.GetId());
            if(this.controls.chkRecurrence.GetChecked()) {
                apt.SetAppointmentType(ASPxAppointmentType.Pattern);
                var recurrenceInfo = this.controls.recurrenceControl.Parse();
                apt.SetRecurrenceInfo(recurrenceInfo);
            }
            return apt;
        },
        Update: function (apt) {
            this.appointmentCopy = apt;
            ASPxClientEdit.ClearEditorsInContainerById("ClientAppointmentForm", null, true);
            this.controls.btnOk.SetEnabled(true);
            this.controls.edtStartDate.SetDate(apt.GetStart());
            this.controls.edtEndDate.SetDate(apt.GetEnd());
            this.controls.tbDescription.SetText(apt.GetDescription());
            this.controls.tbSubject.SetText(apt.GetSubject());
            this.controls.chkAllDay.SetChecked(apt.GetAllDay());
            this.controls.edtLabel.SetValue(apt.GetLabelId());
            this.controls.edtStatus.SetValue(apt.GetStatusId());
            this.controls.tbLocation.SetText(apt.GetLocation());
            var resourceIdValue = apt.GetResource(0);
            resourceIdValue = (resourceIdValue == null) ? "null" : resourceIdValue;
            this.controls.edtResource.SetValue(resourceIdValue);
            var appointmentType = apt.GetAppointmentType();
            if(appointmentType) {
                if(appointmentType == ASPxAppointmentType.Normal || appointmentType == ASPxAppointmentType.Pattern) {
                    this.controls.chkRecurrence.SetVisible(true);
                    if(appointmentType == ASPxAppointmentType.Pattern) {
                        this.controls.recurrenceControl.SetVisible(true);
                        this.controls.chkRecurrence.SetVisible(true);
                        this.controls.chkRecurrence.SetChecked(true);
                        this.controls.recurrenceControl.Update(apt.GetStart(), apt.GetRecurrenceInfo());
                    }
                }
                else {
                    this.controls.chkRecurrence.SetVisible(false);
                }
            }
            this.controls.btnDelete.SetEnabled((apt.GetId()) ? true : false);
        },
        Clear: function () {
            this.controls.edtStartDate.SetDate();
            this.controls.edtEndDate.SetDate();
            this.controls.tbDescription.SetText('');
            this.controls.tbSubject.SetText('');
            this.controls.chkAllDay.SetChecked(false);
            this.controls.edtLabel.SetValue()
            this.controls.edtStatus.SetValue()
            this.controls.tbLocation.SetText('');
            this.controls.chkRecurrence.SetChecked(false);
            this.controls.edtResource.SetValue();
            this.controls.recurrenceControl.Clear();
        }
    });
// ]]> 
</script>
