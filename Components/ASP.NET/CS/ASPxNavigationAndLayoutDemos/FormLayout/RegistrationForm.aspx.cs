using System;
using System.Web.UI;
using DevExpress.Web;

public partial class FormLayout_RegistrationForm : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if (IsPostBack && captcha.IsValid && ASPxEdit.ValidateEditorsInContainer(this))
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alert",
                    @"<script type=""text/javascript"">alert('You have successfully registered');</script>");
    }
}
