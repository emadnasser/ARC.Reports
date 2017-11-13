using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class HorzScrollBar : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack && !IsCallback) {
            InitializeOptionsControls();
        } else {
            ApplyOptions();
        }
    }

    private void ApplyOptions() {
        pivotGrid.OptionsPager.ShowDisabledButtons = cbShowDisabledButtons.Checked;
        pivotGrid.OptionsPager.ShowNumericButtons = cbShowNumericButtons.Checked;
        pivotGrid.OptionsPager.PageSizeItemSettings.Visible = cbShowPageSizeItem.Checked;
        pivotGrid.OptionsPager.Summary.Visible = cbShowSummary.Checked;
        pivotGrid.OptionsPager.ShowSeparators = cbShowSeparators.Checked;

        pivotGrid.OptionsPager.Position = (PagerPosition)ddlPosition.SelectedIndex;
        pivotGrid.OptionsPager.PagerAlign = (DevExpress.Web.ASPxPivotGrid.PagerAlign)ddlPagerAlign.SelectedIndex;
        pivotGrid.OptionsPager.PageSizeItemSettings.Position = (PagerPageSizePosition)ddlPageSizeItemPosition.SelectedIndex;
    }

    private void InitializeOptionsControls() {
        cbShowDisabledButtons.Checked = pivotGrid.OptionsPager.ShowDisabledButtons;
        cbShowNumericButtons.Checked = pivotGrid.OptionsPager.ShowNumericButtons;
        cbShowPageSizeItem.Checked = pivotGrid.OptionsPager.PageSizeItemSettings.Visible;
        cbShowSummary.Checked = pivotGrid.OptionsPager.Summary.Visible;
        cbShowSeparators.Checked = pivotGrid.OptionsPager.ShowSeparators;

        foreach (PagerPosition type in Enum.GetValues(typeof(PagerPosition)))
            ddlPosition.Items.Add(new ListEditItem(type.ToString()));
        ddlPosition.SelectedIndex = (int)pivotGrid.OptionsPager.Position;
        
        foreach (PagerAlign type in Enum.GetValues(typeof(PagerAlign)))
            ddlPagerAlign.Items.Add(new ListEditItem(type.ToString()));
        ddlPagerAlign.SelectedIndex = (int)pivotGrid.OptionsPager.PagerAlign;

        foreach (PagerPageSizePosition type in Enum.GetValues(typeof(PagerPageSizePosition)))
            ddlPageSizeItemPosition.Items.Add(new ListEditItem(type.ToString()));
        ddlPageSizeItemPosition.SelectedIndex = (int)pivotGrid.OptionsPager.PageSizeItemSettings.Position;
    }
    protected void ddlPosition_SelectedIndexChanged(object sender, EventArgs e) {
        ApplyOptions();
    }
    protected void ddlPagerAlign_SelectedIndexChanged(object sender, EventArgs e) {
        ApplyOptions();
    }
    protected void ddlPageSizeItemPosition_SelectedIndexChanged(object sender, EventArgs e) {
        ApplyOptions();
    }
}
