using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Menu_Features : Page {
    RepeatDirection CurrentRepeatDirection {
        get {
            return (RepeatDirection)Enum.Parse(typeof(RepeatDirection),
                ddlRepeatDirection.SelectedItem.Value.ToString());
        }
    }

    protected void btnApply_Click(object sender, EventArgs e) {
        SetProperties();
    }

    protected void ddlRepeatDirection_SelectedIndexChanged(object sender, EventArgs e) {
        SetProperties();
    }

    protected void SetProperties() {
        int result = 0;

        lblColumnCountError.Visible = 
            !int.TryParse(tbColumnCount.Text, out result) || result < 0;
        if(!lblColumnCountError.Visible)
             smpMain.ColumnCount = (byte)result;

        lblMaximumDisplayLevelsError.Visible = 
            !int.TryParse(tbMaximumDisplayLevels.Text, out result) || result < 0;
        if(!lblMaximumDisplayLevelsError.Visible)
            smpMain.MaximumDisplayLevels = result;

        smpMain.RepeatDirection = CurrentRepeatDirection;
    }
}
