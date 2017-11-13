using System;
using System.Web.UI;
using DevExpress.XtraScheduler;
using DevExpress.Web;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Internal;
using System.Collections;
using System.Collections.Generic;
using DevExpress.XtraScheduler.Localization;

public partial class UserControls_AppointmentForm : SchedulerFormControl {
    static readonly Dictionary<int, string> Levels = new Dictionary<int, string>();
    static UserControls_AppointmentForm() {
        Levels.Add(1, "Beginner (100)");
        Levels.Add(2, "Intermediate (200)");
        Levels.Add(3, "Expert (300)");
    }
 
    protected void Page_Load(object sender, EventArgs e) {
        lblAttending.Visible = Page.Items["attending"] != null;
    }

    protected override void PrepareChildControls() {

        base.PrepareChildControls();
    }

    protected override Control[] GetChildControls() {
        List<Control> result = new List<Control>(base.GetChildControls());
        result.AddRange(GetChildRatingControls());
        return result.ToArray();
    }


    protected ASPxRatingControl[] GetChildRatingControls() {
        ASPxRatingControl[] ratingControls = new ASPxRatingControl[] {
             rating
        };
        return ratingControls;
    }

    protected override ASPxEditBase[] GetChildEditors() {
        ASPxEditBase[] edits = new ASPxEditBase[] {
            lblLocation,
            lblDescription, 
            lblSpeaker,
            lblDay,
            lblTime,
            lblCategory
        };

        return edits;
    }
    protected override ASPxButton[] GetChildButtons() {
        ASPxButton[] buttons = new ASPxButton[] {
        };
        return buttons;
    }
    public string rcGetToolTip() {
        return Levels[(int)rating.Value];
    }
}
