using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListEditors_CheckBoxList : Page {
    protected void Page_Load(object sender, EventArgs e) {
        checkBoxList.RepeatLayout = (RepeatLayout)Enum.Parse(typeof(RepeatLayout), cmbRepeatLayout.Text);
        checkBoxList.RepeatDirection = (RepeatDirection)Enum.Parse(typeof(RepeatDirection), cmbDirection.Text);
        checkBoxList.RepeatColumns = (int)spnColumnCount.Number;
    }
}
