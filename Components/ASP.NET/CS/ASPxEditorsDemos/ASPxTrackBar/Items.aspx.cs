using System;
using System.Web.UI;
using DevExpress.Web.Demos;

public partial class ASPxTrackBar_Items : Page {
    protected void Page_Load(object sender, EventArgs e) {
    }
    protected string GetImageUrl(object day) {
        return string.Format("Images/TimeLapse{0}.jpg", day);
    }
}
