using System;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.XtraCharts.Web;

public partial class ChartDemoToolbar : System.Web.UI.UserControl {
    const string appearanceKey = "appearanceKey";
    const string paletteKey = "paletteKey";
    WebChartControl webChartControl;
    ASPxComboBox cbAppearance;
    ASPxComboBox cbPalette;

    void webChartControl_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (webChartControl != null) {
            switch (e.Parameter) {
                case "Palette":
                    if (cbPalette != null) {
                        string paletteName = Convert.ToString(cbPalette.Value);
                        webChartControl.PaletteName = paletteName;
                        Page.Session[paletteKey] = paletteName;
                    }
                    break;
                case "Appearance":
                    if (cbAppearance != null) {
                        string appearanceName = Convert.ToString(cbAppearance.Value);
                        webChartControl.AppearanceName = appearanceName;
                        Page.Session[appearanceKey] = appearanceName;
                    }
                    if (cbPalette != null) {
                        cbPalette.SelectedIndex = cbPalette.Items.IndexOfValue(webChartControl.PaletteName);
                        Page.Session[paletteKey] = cbPalette.Value;
                    }
                    break;
            }
        }
    }
    void PrepareComboBox(ASPxComboBox comboBox, string[] items, string defaultItem) {
        comboBox.Items.Clear();
        comboBox.Items.AddRange(items);
        comboBox.SelectedIndex = defaultItem != null ? comboBox.Items.IndexOfValue(defaultItem) : 0;
    }
    void SetWebChartControl(WebChartControl webChartControl) {
        if (this.webChartControl != null)
            this.webChartControl.CustomCallback -= new CustomCallbackEventHandler(webChartControl_CustomCallback);
        this.webChartControl = webChartControl;
        if (webChartControl != null) {
            if (string.IsNullOrEmpty(webChartControl.ClientSideEvents.EndCallback))
                webChartControl.ClientSideEvents.EndCallback = "function (s, e) { SetPaletteComboBox(s, e); }";
            else {
                int index = webChartControl.ClientSideEvents.EndCallback.LastIndexOf('}');
                webChartControl.ClientSideEvents.EndCallback = webChartControl.ClientSideEvents.EndCallback.Insert(index, "\tSetPaletteComboBox(s, e);\n");
            }
            webChartControl.CustomCallback += new CustomCallbackEventHandler(webChartControl_CustomCallback);
            string currentAppearanceName = Page.Session[appearanceKey] as string;
            if (!string.IsNullOrEmpty(currentAppearanceName))
                webChartControl.AppearanceName = currentAppearanceName;
            string currentPaletteName = Page.Session[paletteKey] as string;
            if (!string.IsNullOrEmpty(currentPaletteName))
                webChartControl.PaletteName = currentPaletteName;
            if (cbAppearance != null)
                PrepareComboBox(cbAppearance, webChartControl.GetAppearanceNames(), webChartControl.AppearanceName);
            if (cbPalette != null)
                PrepareComboBox(cbPalette, webChartControl.GetPaletteNames(), webChartControl.PaletteName);
        }
    }
    protected void Page_Init(object sender, EventArgs e) {
        ChartBasePage page = Page as ChartBasePage;
        if (page == null)
            return;
        page.ClientScript.RegisterClientScriptBlock(typeof(string), "SetPaletteComboBox", 
            "<script type=\"text/javascript\">\n"+
            "<!--\n"+
                "function SetPaletteComboBox(s, e) {\n"+
                    "\t if (typeof cbPalette != 'undefined') {\n" +
                        "\t\t for (var i = 0; i < cbPalette.GetItemCount(); i++) {\n" +
                            "\t\t\t if (cbPalette.GetItem(i).value == s.GetChart().paletteName) {\n" +
                                    "\t\t\t\t cbPalette.SetSelectedIndex(i);\n" +
                                  "\t\t\t }\n" +
                            "\t\t }\n" +
                    "\t }\n"+
                "}\n"+
             "// -->\n"+
             "</script>");
        mnuToolbar.AutoSeparators = DevExpress.Web.AutoSeparatorMode.None;
        mnuToolbar.Items[5].Visible = page.ShowPaletteComboBox(); 
        WebChartControl webChartControl = page.FindWebChartControl();
        if (webChartControl != null) {
            DevExpress.Web.MenuItem mnuAppearance = mnuToolbar.Items.FindByName("mnuAppearance");
            if (mnuAppearance != null)
                cbAppearance = mnuAppearance.FindControl("cbAppearance") as ASPxComboBox;
            DevExpress.Web.MenuItem mnuPalette = mnuToolbar.Items.FindByName("mnuPalette");
            if (mnuPalette != null)
                cbPalette = mnuPalette.FindControl("cbPalette") as ASPxComboBox;
            SetWebChartControl(webChartControl);
        }
    }
}
