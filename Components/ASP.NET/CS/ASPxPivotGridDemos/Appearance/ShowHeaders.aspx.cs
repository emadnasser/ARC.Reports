using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxPivotGrid;

public partial class Appearance_ShowHeaders : Page
{
    protected void Page_Load(object sender, EventArgs e) {
		if(!IsPostBack && !IsCallback) {
			SetAreasOptions();
		} else {
			ChangeAreasOptions(ASPxPivotGrid1);
		}
	}

	void SetAreasOptions() {
        cbShowFilterHeaders.Checked = ASPxPivotGrid1.OptionsView.ShowFilterHeaders;
        cbShowDataHeaders.Checked = ASPxPivotGrid1.OptionsView.ShowDataHeaders;
        cbShowColumnHeaders.Checked = ASPxPivotGrid1.OptionsView.ShowColumnHeaders;
        cbShowRowHeaders.Checked = ASPxPivotGrid1.OptionsView.ShowRowHeaders;
	}

	void ChangeAreasOptions(ASPxPivotGrid ASPxPivotGrid1) {
        ASPxPivotGrid1.OptionsView.ShowFilterHeaders = cbShowFilterHeaders.Checked;
        ASPxPivotGrid1.OptionsView.ShowDataHeaders = cbShowDataHeaders.Checked;
        ASPxPivotGrid1.OptionsView.ShowColumnHeaders = cbShowColumnHeaders.Checked;
        ASPxPivotGrid1.OptionsView.ShowRowHeaders = cbShowRowHeaders.Checked;
	}
}
