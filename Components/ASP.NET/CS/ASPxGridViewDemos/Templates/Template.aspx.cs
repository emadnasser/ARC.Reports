using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

public partial class Templates_Template : Page {
    protected void Page_Load(object sender, EventArgs e) {
    }
    protected void callbackPanel_Callback(object source, DevExpress.Web.CallbackEventArgsBase e) {
        using(var context = new NorthwindContext()) { 
            int employeeId = Convert.ToInt32(e.Parameter);
            var employee = context.Employees.Single(em => em.EmployeeID == employeeId);
            edBinaryImage.Value = employee.Photo;
            litText.Text = employee.Notes;
        }
    }
}
