using System;
using System.Threading;
using System.Web.UI;

public partial class ASPxCaptcha_CustomAppearance : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if (IsPostBack) {
            bool captchaValid = Captcha.Code == Request.Params["tbCode"];
            lblIncorrectCodeMessage.Visible = !captchaValid;
            lblCorrectCodeMessage.Visible = captchaValid;
        }
        if (IsCallback)
            Thread.Sleep(500);  // Intentionally pauses server-side processing, to demonstrate the RefreshButton animation.
    }
}
