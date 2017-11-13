Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Linq

Partial Public Class Templates_Template
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Sub callbackPanel_Callback(ByVal source As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
		Using context = New NorthwindContext()
			Dim employeeId As Integer = Convert.ToInt32(e.Parameter)
			Dim employee = context.Employees.Single(Function(em) em.EmployeeID = employeeId)
			edBinaryImage.Value = employee.Photo
			litText.Text = employee.Notes
		End Using
	End Sub
End Class
