using System;
using System.Web.UI;
using DevExpress.XtraGauges.Base;

public partial class StylesPage : Page {
    protected IGaugeContainer GaugeContainer {
        get { return gaugeControl as IGaugeContainer; }
    }
    protected void Page_Load(object sender, EventArgs e) {
        GaugeContainer.ForceClearOnRestore = true;
        GaugeContainer.RestoreLayoutFromXml(MapPath("~/App_Data/Styles/" + (string)style.Value));
    }
}
