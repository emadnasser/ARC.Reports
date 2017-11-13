using System;
using System.Web.UI;
using DevExpress.Web.Demos;
using System.Threading;

public partial class CallbackPanel_Example : Page {

    protected void Page_Load(object sender, EventArgs e) {
        bool enableAnimation = cbEnableAnimation.Checked;
        Utils.RegisterCssLink(this, "~/CallbackPanel/CSS/Example.css");
        if(ASPxCallbackPanel1.IsCallback) {
            // Intentionally pauses server-side processing, 
            // to demonstrate the Loading Panel functionality.
            if(!enableAnimation)
                Thread.Sleep(500);
        }
        string selectedValue = string.Empty;
        if(IsPostBack && ASPxListBox1.SelectedItem != null) {
            selectedValue = ASPxListBox1.SelectedItem.Value.ToString();
            EmployeesDataSource2.WhereParameters["EmployeeID"].DefaultValue = selectedValue;
            DataBind();
        } else {
            DataBind();
            selectedValue = EmployeesDataSource2.WhereParameters["EmployeeID"].DefaultValue;
            ASPxListBox1.SelectedIndex = ASPxListBox1.Items.IndexOfValue(selectedValue);
        }
        ASPxCallbackPanel1.EnableCallbackAnimation = enableAnimation;
        ASPxCallbackPanel1.SettingsLoadingPanel.Enabled = !enableAnimation;
    }

}
