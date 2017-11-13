using System;
using System.Globalization;
using System.Threading;
using System.Web.UI;

public partial class ASPxSpinEdit_Features : Page {
    private string CultureName {
        get { return Request.Params["cult"] == "it-IT" ? "it-IT" : "en-US"; }
    }
    protected void Page_Load(object sender, EventArgs e) {
        cmbCultureSelector.SelectedIndex = CultureName == "it-IT" ? 1 : 0;
    }
    protected override void InitializeCulture() {
        CultureInfo culture = new CultureInfo(CultureName);
        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;
    }
}
