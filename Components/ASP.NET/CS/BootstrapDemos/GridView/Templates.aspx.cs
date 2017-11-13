using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridView_Templates : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void Callback1_Callback(object source, DevExpress.Web.CallbackEventArgs e) {
        using(var context = new NorthwindContext()) {
            int employeeId = Convert.ToInt32(e.Parameter);
            var employee = context.Employees.Single(em => em.EmployeeID == employeeId);
            e.Result = employee.Notes;
        }
    }
}
