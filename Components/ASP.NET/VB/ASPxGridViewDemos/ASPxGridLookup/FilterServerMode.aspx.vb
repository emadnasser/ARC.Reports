Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Xpo
Imports DevExpress.Web.Demos
Imports DevExpress.Web

Partial Public Class ASPxGridLookup_FilterServerMode
	Inherits Page
	Shared Sub New()
		PersonDataGenerator.Register()

	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsCallback) AndAlso (Not IsPostBack) Then
			RadioButtonList.SelectedIndex = 0
		End If
		UpdateFilteringMode()
		GridLookup.GridView.Width = 370
	End Sub
	Protected Sub ASPxGridLookup_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim ready As Boolean = DatabaseGenerator.IsReady(CreateDatabaseControl.TableKey)
		CreateDatabaseControl.Visible = Not ready
		Demo.Visible = ready
		Dim session As Session = XpoHelper.GetNewSession()
		XpoDataSource.Session = session
	End Sub
	Protected Sub UpdateFilteringMode()
		Select Case RadioButtonList.SelectedItem.Value.ToString()
			Case "StartsWith"
				GridLookup.IncrementalFilteringMode = IncrementalFilteringMode.StartsWith
				GridLookup.GridViewProperties.Settings.ShowFilterRow = False
				GridLookupCaptionLabel.Text = "Start typing to invoke filtering:"
			Case "Contains"
				GridLookup.IncrementalFilteringMode = IncrementalFilteringMode.Contains
				GridLookup.GridViewProperties.Settings.ShowFilterRow = False
				GridLookupCaptionLabel.Text = "Start typing to invoke filtering:"
			Case "Filter Row"
				GridLookup.IncrementalFilteringMode = IncrementalFilteringMode.None
				GridLookup.GridViewProperties.Settings.ShowFilterRow = True
				GridLookupCaptionLabel.Text = "Type within the grid filter row to start filtering:"
		End Select
	End Sub
End Class





