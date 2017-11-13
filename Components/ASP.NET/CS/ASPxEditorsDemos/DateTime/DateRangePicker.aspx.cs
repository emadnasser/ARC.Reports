using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Features_DateRangePicker : Page {
    protected void Page_Load(object sender, EventArgs e) {
        deEnd.DateRangeSettings.MinDayCount = Convert.ToInt32(seMinDayCount.Value);
        int maxDayCount = Convert.ToInt32(seMaxDayCount.Value);
        if(maxDayCount > 0 && maxDayCount < deEnd.DateRangeSettings.MinDayCount)
            maxDayCount = deEnd.DateRangeSettings.MinDayCount;
        deEnd.DateRangeSettings.MaxDayCount = maxDayCount;
        seMaxDayCount.Value = deEnd.DateRangeSettings.MaxDayCount;
    }
    protected void btnSubmit_Click(object sender, EventArgs e) {
        if(IsPostBack && ASPxEdit.ValidateEditorsInContainer(this))
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
                    @"<script type=""text/javascript"">alert('The form has been submitted successfully.');</script>");
    }
}
