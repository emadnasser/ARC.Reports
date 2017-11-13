using System;
using System.Web.UI;
using DevExpress.XtraGauges.Core.Model;

public partial class DigitalGaugePage : Page {
    protected void Page_Load(object sender, EventArgs e) {
        dGauge1.DigitCount = (int)digitCount.Number;
        dGauge1.DisplayMode = (DigitalGaugeDisplayMode)displayMode.Value;
    }
}
