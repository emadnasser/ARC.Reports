using DevExpress.Web;
using System;
using System.Web.UI;

public partial class Editing_EditModes : Page {
    protected void Page_Load(object sender, EventArgs e) {
        CardView.SettingsEditing.Mode = (CardViewEditingMode)Enum.Parse(typeof(CardViewEditingMode), EditModeComboBox.Text, true); ;
        if(!IsPostBack)
            CardView.StartEdit(1);
    }
}
