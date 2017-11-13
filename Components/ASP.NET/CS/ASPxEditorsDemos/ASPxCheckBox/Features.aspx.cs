using System;
using System.Web.UI;
using DevExpress.Web;

public partial class ASPxComboBox_Features : Page {
    protected void Page_Load(object sender, EventArgs e) {
        ASPxCheckBox.AllowGrayed = AllowGrayedCheckBox.Checked;
        ASPxCheckBox.Native = NativeCheckBox.Checked;
        ASPxCheckBox.AllowGrayedByClick = AllowGrayedByClickCheckBox.Checked;

        if (NativeCheckBox.Checked)
            AllowGrayedByClickCheckBox.Enabled = AllowGrayedCheckBox.Enabled = CustomImagesCheckBox.Enabled = false;
        else if (!AllowGrayedCheckBox.Checked)
            AllowGrayedByClickCheckBox.Enabled = false;

        if (CustomImagesCheckBox.Checked) {
            ASPxCheckBox.CheckedImage.Url = "Images/Checked.png";
            ASPxCheckBox.CheckedImage.ToolTip = ASPxCheckBox.CheckedImage.AlternateText = "Checked";
            ASPxCheckBox.UncheckedImage.Url = "Images/Unchecked.png";
            ASPxCheckBox.UncheckedImage.ToolTip = ASPxCheckBox.UncheckedImage.AlternateText = "Unchecked";
            ASPxCheckBox.GrayedImage.Url = "Images/Grayed.png";
            ASPxCheckBox.GrayedImage.ToolTip = ASPxCheckBox.GrayedImage.AlternateText = "Indeterminate";

            ASPxCheckBox.CheckedImage.Width = ASPxCheckBox.UncheckedImage.Width = ASPxCheckBox.GrayedImage.Width = 50;
            ASPxCheckBox.CheckedImage.Height = ASPxCheckBox.UncheckedImage.Height = ASPxCheckBox.GrayedImage.Height = 50;
            ASPxCheckBox.CssPostfix = "CustomImage";
        }
    }
    protected void OnSwitchButtonClick(object sender, EventArgs e) {      
        switch(ASPxCheckBox.CheckState) {
            case CheckState.Checked : ASPxCheckBox.CheckState = CheckState.Unchecked; return;
            case CheckState.Unchecked: ASPxCheckBox.CheckState = 
                (ASPxCheckBox.AllowGrayed && !ASPxCheckBox.Native) ? CheckState.Indeterminate : CheckState.Checked; return;
            case CheckState.Indeterminate : ASPxCheckBox.CheckState = CheckState.Checked; return;
        }
    }
}
