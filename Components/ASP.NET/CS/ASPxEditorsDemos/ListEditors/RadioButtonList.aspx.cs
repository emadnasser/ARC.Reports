using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.Demos;

public partial class ListEditors_RadioButtonList : Page {
    protected void Page_Load(object sender, EventArgs e) {
        radioButtonList.RepeatLayout = (RepeatLayout)Enum.Parse(typeof(RepeatLayout), cmbRepeatLayout.Text);
        radioButtonList.RepeatDirection = (RepeatDirection)Enum.Parse(typeof(RepeatDirection), cmbDirection.Text);
        radioButtonList.RepeatColumns = (int)spnColumnCount.Number;
    }
}
