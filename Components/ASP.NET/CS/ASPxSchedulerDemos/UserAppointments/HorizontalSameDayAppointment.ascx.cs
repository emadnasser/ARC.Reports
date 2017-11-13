using System;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Drawing;
using System.Web;

public partial class HorizontalSameDayAppointment : System.Web.UI.UserControl {
	HorizontalAppointmentTemplateContainer Container { get { return (HorizontalAppointmentTemplateContainer)Parent; } }
	HorizontalAppointmentTemplateItems Items { get { return Container.Items; } }

	protected void Page_Load(object sender, EventArgs e) {
		this.lblSubject.Text = HttpUtility.HtmlEncode(Container.AppointmentViewInfo.Appointment.Subject);
		this.lblLocation.Text = GetLocationText();		
		LayoutAppointmentImages();
	}			
	string GetLocationText() {
		String location = HttpUtility.HtmlEncode(Container.AppointmentViewInfo.Appointment.Location);
		if (String.IsNullOrEmpty(location))
			return String.Empty;
		else
			return String.Format("({0})", location);
	}	

	void LayoutAppointmentImages() {
		int count = Items.Images.Count;
		HtmlTableRow row = new HtmlTableRow();
		row.Cells.Add(new HtmlTableCell());
		for (int i = 0; i < count; i++) {
			HtmlTableCell cell = new HtmlTableCell();
			AddImage(cell, Items.Images[i]);
			row.Cells.Add(cell);
		}
		imageContainer.Rows.Add(row);
	}
	void AddImage(HtmlTableCell targetCell, AppointmentImageItem imageItem) {
		Image image = new Image();
		imageItem.ImageProperties.AssignToControl(image, false);
		targetCell.Controls.Add(image);
	}
}
