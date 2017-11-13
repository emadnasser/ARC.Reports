using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DashboardDemos.Core;

namespace FinancialDemo.Web {
    public partial class DatabaseGenerationForm : System.Web.UI.Page {
        protected override void OnInit(EventArgs e) {
            string dashboardStorageConnectionString = DashboardDemosUtils.DashboardStorageConnectionString;
            if (string.IsNullOrEmpty(dashboardStorageConnectionString)) {
                Control phContent = Form.FindControl("Content");
                if (phContent != null) {
                    LiteralControl div = new LiteralControl("This demo requires SQL Server Express installed to automatically create a sample database. Alternatively, you can manually specify a connection string to the server where the database should be created. You can do this in the connections.config file.");
                    phContent.Controls.RemoveAt(1);
                    phContent.Controls.AddAt(1, div);                    
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e) {

        }

    }
}
