using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class Appearance_GridLines : Page {
    protected void Page_Load(object sender, EventArgs e) {
        switch(cmbGridLines.SelectedIndex) {
            case 0:
                treeList.Settings.GridLines = GridLines.None;
                break;
            case 1:
                treeList.Settings.GridLines = GridLines.Horizontal;
                break;
            case 2:
                treeList.Settings.GridLines = GridLines.Vertical;
                break;
            case 3:
                treeList.Settings.GridLines = GridLines.Both;
                break;
        }
        treeList.Settings.ShowTreeLines = chkTreeLines.Checked;
        treeList.Border.BorderStyle = chkBorder.Checked ? BorderStyle.Solid : BorderStyle.None;
        treeList.Settings.SuppressOuterGridLines = chkBorder.Checked;

        infoPanel.Visible = !CanChangeTreeLines || !CanChangeGridLines;
        cmbGridLines.Enabled = CanChangeGridLines;
        chkTreeLines.Enabled = CanChangeTreeLines;
    }

    static string[] NoGridLinesThemes = new string[] { "DevEx", "Office2010Blue", "Office2010Black", "Office2010Silver" };
    static string[] NoTreeLinesThemes = new string[] { "DevEx", "Metropolis", "MetropolisBlue", "Moderno", "Office2010Blue", "Office2010Black", "Office2010Silver" };
    bool CanChangeGridLines { 
        get { return !NoGridLinesThemes.Contains(ASPxWebControl.GlobalTheme); } 
    }
    bool CanChangeTreeLines {
        get { return !NoTreeLinesThemes.Contains(ASPxWebControl.GlobalTheme); }
    }
}
