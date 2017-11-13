using System;
using System.Web.UI;
using System.Threading;

public partial class Docking_Callbacks : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsCallback) {
            // Intentionally pauses server-side processing,
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(500);
        }
    }

    protected void employeesPanel_Load(object sender, EventArgs e) {
        string controlUrl = "~/Docking/Callbacks/FloatModeContent.ascx";
        if(employeesPanel.OwnerZone != null) {
            if(employeesPanel.OwnerZone.Equals(designDepartmentZone))
                controlUrl = "~/Docking/Callbacks/DesignDepartmentEmployees.ascx";
            else if(employeesPanel.OwnerZone.Equals(developmentDepartmentZone))
                controlUrl = "~/Docking/Callbacks/DevelopmentDepartmentEmployees.ascx";
        }

        employeesPanel.Controls.Clear();
        employeesPanel.Controls.Add(LoadControl(controlUrl));
    }
}
