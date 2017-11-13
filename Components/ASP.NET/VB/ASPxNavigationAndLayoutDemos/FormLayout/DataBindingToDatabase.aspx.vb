Imports Microsoft.VisualBasic
Imports System
Imports System.Configuration
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Internal
Imports DevExpress.Web.Demos

Partial Public Class FormLayout_DataBindingToDatabase
	Inherits Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim sqlExpressString As String = ConfigurationManager.ConnectionStrings("NorthwindConnectionString").ConnectionString
		EmployeesDataSource.ConnectionString = DbEngineDetector.PatchConnectionString(sqlExpressString)
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub

	Protected Sub navigateComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		EmployeesDataSource.SelectParameters("EmployeeID").DefaultValue = navigateComboBox.Value.ToString()
		formLayout.DataBind()
	End Sub

	Protected Sub updateButton_Click(ByVal sender As Object, ByVal e As EventArgs)
		Try
			EmployeesDataSource.UpdateParameters("EmployeeID").DefaultValue = navigateComboBox.Value.ToString()
			EmployeesDataSource.Update()
		Catch ex As Exception
			errorMessageLabel.Text = ex.Message
			errorMessageLabel.Visible = True
		End Try
	End Sub

	Protected Sub EmployeesDataSource1_Modifying(ByVal sender As Object, ByVal e As SqlDataSourceCommandEventArgs)
		Utils.AssertNotReadOnly()
	End Sub
End Class
