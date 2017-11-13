using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Globalization;
using DevExpress.Web;

public partial class Accessibility_Localization : System.Web.UI.Page {
    protected override void InitializeCulture() {
        if(!string.IsNullOrEmpty(GetDXCurrentLanguageValue())) {
            //for regional server standards 
            Culture = GetDXCurrentLanguageValue(); 
            //for DevExpress localizable strings 
            UICulture = GetDXCurrentLanguageValue();
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!string.IsNullOrEmpty(GetDXCurrentLanguageValue()))
            LanguageComboBox.SelectedItem = LanguageComboBox.Items.FindByValue(GetDXCurrentLanguageValue());
        else
            LanguageComboBox.SelectedIndex = 0;
    }

    protected string GetDXCurrentLanguageValue() {
        return Request.Cookies["DXCurrentLanguage"] == null ? "" : Request.Cookies["DXCurrentLanguage"].Value;
    }
}
