using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;

public partial class Appearance_CompactLayout : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack && !IsCallback) {
            ASPxPivotGrid1.CollapseAll();
            ASPxPivotGrid1.ExpandValue(false, new object[] { "UK" });
            ASPxPivotGrid1.ExpandValue(false, new object[] { "UK", "Condiments" });
            ASPxPivotGrid1.ExpandValue(false, new object[] { "UK", "Condiments", "Chef Anton's Cajun Seasoning" });
            ASPxPivotGrid1.ExpandValue(false, new object[] { "UK", "Condiments", "Chef Anton's Cajun Seasoning", "Robert King" });
            ASPxPivotGrid1.ExpandValue(false, new object[] { "UK", "Condiments", "Chef Anton's Cajun Seasoning", "Robert King", 1994});
            ASPxPivotGrid1.ExpandValue(false, new object[] { "UK", "Condiments", "Chef Anton's Cajun Seasoning", "Robert King", 1996 });
            ASPxPivotGrid1.ExpandValue(false, new object[] { "UK", "Condiments", "Genen Shouyu" });
            ASPxPivotGrid1.ExpandValue(false, new object[] { "UK", "Condiments", "Genen Shouyu", "Michael Suyama" });
        }
        if(LayoutMode.SelectedIndex == 0)
            SetCompactLayout();
        else
            SetFullLayout();
    }

    void SetCompactLayout() {
        ASPxPivotGrid1.Width = Unit.Pixel(500);
        ASPxPivotGrid1.OptionsView.ShowColumnHeaders = false;
        ASPxPivotGrid1.OptionsView.ShowRowHeaders = false;
        ASPxPivotGrid1.OptionsView.ShowDataHeaders = false;
        ASPxPivotGrid1.OptionsView.ShowFilterHeaders = false;
        ASPxPivotGrid1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Tree;
        ASPxPivotGrid1.Styles.FieldValueStyle.Wrap = DefaultBoolean.False;
        ASPxPivotCustomizationControl1.Width = Unit.Pixel(300);
        ASPxPivotCustomizationControl1.ASPxPivotGridID = "ASPxPivotGrid1";
        ASPxPivotCustomizationControl1.Visible = true;
    }

    void SetFullLayout() {
        ASPxPivotGrid1.Width = Unit.Pixel(800);
        ASPxPivotGrid1.OptionsView.ShowColumnHeaders = true;
        ASPxPivotGrid1.OptionsView.ShowRowHeaders = true;
        ASPxPivotGrid1.OptionsView.ShowDataHeaders = true;
        ASPxPivotGrid1.OptionsView.ShowFilterHeaders = true;
        ASPxPivotGrid1.Styles.FieldValueStyle.Wrap = DefaultBoolean.Default;
        ASPxPivotGrid1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Far;
        ASPxPivotCustomizationControl1.ASPxPivotGridID = "NoControl";
        ASPxPivotCustomizationControl1.Visible = false;
    }
}
