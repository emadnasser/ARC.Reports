using System;
using System.IO;
using DevExpress.Spreadsheet;
using DevExpress.Web.Demos;

public partial class API_ClientSideEvents : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        if(!Page.IsPostBack) {
            var filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "ClientSideEvents.xlsx");
            
            Spreadsheet.Open(filePath);
        }
    }
}
