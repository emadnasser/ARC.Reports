using System;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Internal;
using DevExpress.Web.Demos;

public partial class FormLayout_DataBindingToDatabase : Page {
    protected void Page_Init(object sender, EventArgs e) {
        string sqlExpressString = ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
        EmployeesDataSource.ConnectionString = DbEngineDetector.PatchConnectionString(sqlExpressString);
    }
    protected void Page_Load(object sender, EventArgs e) {
    }

    protected void navigateComboBox_SelectedIndexChanged(object sender, EventArgs e) {
        EmployeesDataSource.SelectParameters["EmployeeID"].DefaultValue = navigateComboBox.Value.ToString();
        formLayout.DataBind();
    }

    protected void updateButton_Click(object sender, EventArgs e) {
        try {
            EmployeesDataSource.UpdateParameters["EmployeeID"].DefaultValue = navigateComboBox.Value.ToString();
            EmployeesDataSource.Update();
        }
        catch (Exception ex) {
            errorMessageLabel.Text = ex.Message;
            errorMessageLabel.Visible = true;
        }
    }

    protected void EmployeesDataSource1_Modifying(object sender, SqlDataSourceCommandEventArgs e) {
        Utils.AssertNotReadOnly();
    }
}
