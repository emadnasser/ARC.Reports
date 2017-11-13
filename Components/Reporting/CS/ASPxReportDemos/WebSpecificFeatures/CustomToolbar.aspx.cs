using System;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class WebSpecificFeatures_CustomToolbar : PageBase<XtraReportsDemos.OddEvenStyles.Report> {
    protected void ASPxRibbon1_Init(object sender, EventArgs e) {
        foreach(RibbonTab tab in ASPxRibbon1.Tabs) {
            RibbonGroup reportGroup = tab.Groups.FindByName("CustomReportGroup");
            if(reportGroup == null)
                continue;
            var showParametersPanelCommand = (RibbonToggleButtonItem)reportGroup.Items.FindByName("ShowParametersPanelToggleCommand");
            var showDocumentMapCommand = (RibbonToggleButtonItem)reportGroup.Items.FindByName("ShowDocumentMapToggleCommand");
            var isMetro = Utils.CurrentTheme == "Moderno"
                || Utils.CurrentTheme == "Mulberry"
                || Utils.CurrentTheme == "Metropolis"
                || Utils.CurrentTheme == "MetropolisBlue";
            string imageUrlSuffix = isMetro ? "_Metro" : string.Empty;
            showDocumentMapCommand.SmallImage.Url = string.Format("~/Content/CustomToolbar/DocumentMap_16x16{0}.png", imageUrlSuffix);
            showDocumentMapCommand.LargeImage.Url = string.Format("~/Content/CustomToolbar/DocumentMap_32x32{0}.png", imageUrlSuffix);
            showParametersPanelCommand.SmallImage.Url = string.Format("~/Content/CustomToolbar/Parameters_16x16{0}.png", imageUrlSuffix);
            showParametersPanelCommand.LargeImage.Url = string.Format("~/Content/CustomToolbar/Parameters_32x32{0}.png", imageUrlSuffix);
            showParametersPanelCommand.Checked = true;
            showDocumentMapCommand.Checked = true;
        }
    }
}
