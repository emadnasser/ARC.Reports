using System;
using System.Web.UI;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPivotGrid.Customization;

public partial class FieldsCustomizationDemo : Page {

    protected void Page_Load(object sender, EventArgs e) {
        ASPxPivotGrid1.OptionsCustomization.AllowDrag = allowDrag.Checked;
        ASPxPivotGrid1.OptionsCustomization.AllowDragInCustomizationForm = allowDragCF.Checked;
    }

    protected void pivotGrid_CustomUnboundFieldData(object sender, CustomFieldDataEventArgs e) {
        if(object.ReferenceEquals(e.Field, ASPxPivotGrid1.Fields["OrderAmount"])) {
            e.Value = Convert.ToDouble(e.GetListSourceColumnValue("UnitPrice")) * Convert.ToDouble(e.GetListSourceColumnValue("Quantity"));
        }
    }
    protected void FieldListStyle_SelectedIndexChanged(object sender, EventArgs e) {
        if(FieldListStyle.SelectedItem.Value.ToString() == "Simple")
            ASPxPivotGrid1.OptionsCustomization.CustomizationFormStyle = CustomizationFormStyle.Simple;
        else
            ASPxPivotGrid1.OptionsCustomization.CustomizationFormStyle = CustomizationFormStyle.Excel2007;
    }

    protected void FieldListLayout_SelectedIndexChanged(object sender, EventArgs e) {
        ASPxPivotGrid1.OptionsCustomization.CustomizationFormLayout = (CustomizationFormLayout)Enum.Parse(typeof(CustomizationFormLayout), FieldListLayout.SelectedItem.Value.ToString());
    }
}
