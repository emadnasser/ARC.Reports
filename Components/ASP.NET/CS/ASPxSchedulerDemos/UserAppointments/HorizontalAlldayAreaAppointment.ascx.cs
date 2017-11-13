using System;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Drawing;
using System.Web;

public partial class HorizontalAlldayAreaAppointment : System.Web.UI.UserControl {
    HorizontalAppointmentTemplateContainer Container { get { return (HorizontalAppointmentTemplateContainer)Parent; } }
    HorizontalAppointmentTemplateItems Items { get { return Container.Items; } }

    protected void Page_Load(object sender, EventArgs e) {
        this.lblSubject.Text = HttpUtility.HtmlEncode(Container.AppointmentViewInfo.Appointment.Subject);
        this.lblLocation.Text = GetLocationText();

        startTimeClockContainer.Controls.Add(Items.StartTimeClock);
        endTimeClockContainer.Controls.Add(Items.EndTimeClock);
    }
    string GetLocationText() {
        String location = HttpUtility.HtmlEncode(Container.AppointmentViewInfo.Appointment.Location);
        if(String.IsNullOrEmpty(location))
            return String.Empty;
        else
            return String.Format("({0})", location);

    }
}
