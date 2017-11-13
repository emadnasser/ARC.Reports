using System;
using System.Web.UI;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Drawing;
using DevExpress.Web;
using DevExpress.Web.Internal;
using DevExpress.XtraScheduler;

public partial class UserControls_VerticalAppointment : System.Web.UI.UserControl {
    VerticalAppointmentTemplateContainer Container { get { return (VerticalAppointmentTemplateContainer)Parent; } }
    Appointment CurAppointment { get { return Container.AppointmentViewInfo.Appointment; } }
    VerticalAppointmentTemplateItems Items { get { return Container.Items; } }

    protected void Page_Load(object sender, EventArgs e) {
        PrepareChildControls();
    }

    void PrepareChildControls() {
        AppointmentDiv.Style.Value = Items.AppointmentStyle.GetStyleAttributes(Page).Value;
        StatusContainer.Controls.Add(Items.StatusControl);

        object speaker = CurAppointment.CustomFields[CustomFileldNames.Speaker];
        if(speaker != DBNull.Value) {
            lblSpeaker.Text = (string)speaker;
        }
        cmbAttendingSwitch.SelectedIndex = (int)CurAppointment.LabelKey;
        cmbAttendingSwitch.ClientSideEvents.ValueChanged = "function(s, e) { ResizeSwitcher(s, e); ChangeAppointmentLabel('" + CurAppointment.Id.ToString() + "', s.GetValue()); }";
    }
}
