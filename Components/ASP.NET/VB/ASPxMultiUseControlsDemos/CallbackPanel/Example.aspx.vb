Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Demos
Imports System.Threading

Partial Public Class CallbackPanel_Example
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim enableAnimation As Boolean = cbEnableAnimation.Checked
		Utils.RegisterCssLink(Me, "~/CallbackPanel/CSS/Example.css")
		If ASPxCallbackPanel1.IsCallback Then
			' Intentionally pauses server-side processing, 
			' to demonstrate the Loading Panel functionality.
			If (Not enableAnimation) Then
				Thread.Sleep(500)
			End If
		End If
		Dim selectedValue As String = String.Empty
		If IsPostBack AndAlso ASPxListBox1.SelectedItem IsNot Nothing Then
			selectedValue = ASPxListBox1.SelectedItem.Value.ToString()
			EmployeesDataSource2.WhereParameters("EmployeeID").DefaultValue = selectedValue
			DataBind()
		Else
			DataBind()
			selectedValue = EmployeesDataSource2.WhereParameters("EmployeeID").DefaultValue
			ASPxListBox1.SelectedIndex = ASPxListBox1.Items.IndexOfValue(selectedValue)
		End If
		ASPxCallbackPanel1.EnableCallbackAnimation = enableAnimation
		ASPxCallbackPanel1.SettingsLoadingPanel.Enabled = Not enableAnimation
	End Sub

End Class
