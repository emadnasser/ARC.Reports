using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class PagingAndScrolling_EndlessPaging : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            EndlessPagingModeComboBox.DataSource = Enum.GetValues(typeof(CardViewEndlessPagingMode));
            EndlessPagingModeComboBox.DataBind();
            EndlessPagingModeComboBox.SelectedIndex = 0;
        }
        CardView.SettingsPager.EndlessPagingMode = (CardViewEndlessPagingMode)Enum.Parse(typeof(CardViewEndlessPagingMode), EndlessPagingModeComboBox.Text);
        CardView.Settings.VerticalScrollBarMode = EnableScrollingCheckBox.Checked ? ScrollBarMode.Visible : ScrollBarMode.Hidden;
    }
}
