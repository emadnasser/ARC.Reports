using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.Demos;

public partial class Overview : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        SpreadsheetDemoUtils.CreateOverviewRibbon(Spreadsheet);
        if(!IsPostBack)
            Spreadsheet.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "MonthlyBudget.xlsx"));
    }
}
