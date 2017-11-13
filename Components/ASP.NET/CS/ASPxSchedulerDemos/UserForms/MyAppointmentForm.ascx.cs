using System;
using DevExpress.Web;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Internal;

public partial class Templates_MyAppointmentForm : SchedulerFormControl {
    protected void Page_Load(object sender, EventArgs e) {
        PrepareChildControls();
        tbSubject.Focus();
    }
    public override void DataBind() {
        base.DataBind();
        MyAppointmentFormTemplateContainer container = (MyAppointmentFormTemplateContainer)Parent;
        AppointmentRecurrenceForm1.Visible = container.ShouldShowRecurrence;

        btnOk.ClientSideEvents.Click = container.SaveHandler;
        btnCancel.ClientSideEvents.Click = container.CancelHandler;
        btnDelete.ClientSideEvents.Click = container.DeleteHandler;
    }
    protected override void PrepareChildControls() {
        AppointmentFormTemplateContainer container = (AppointmentFormTemplateContainer)Parent;
        ASPxScheduler control = container.Control;

        AppointmentRecurrenceForm1.EditorsInfo = new EditorsInfo(control, control.Styles.FormEditors, control.Images.FormEditors, control.Styles.Buttons);
        base.PrepareChildControls();
    }
    protected override ASPxEditBase[] GetChildEditors() {
        ASPxEditBase[] edits = new ASPxEditBase[] {
			lblDemoShortDescription, lblDemoLongDescription, lblSubject, tbSubject, 
			lblLocation, tbLocation, lblStartTime, edtStartDate,
			lblEndTime, edtEndDate, lblDescription, memDescription, lblContactInfo
		};
        return edits;
    }
    protected override ASPxButton[] GetChildButtons() {
        ASPxButton[] buttons = new ASPxButton[] {
			btnOk, btnCancel, btnDelete
		};
        return buttons;
    }
}
