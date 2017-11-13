Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxTreeList
Imports System.Web.UI

Partial Public Class Editing_Validation
	Inherits Page
	Private Const StringEmptyError As String = "The value cannot be empty."

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			NewsGroupDataProvider.Restore()
			NewsGroupDataProvider.Corrupt()
			treeList.DataBind()
			treeList.ExpandToLevel(2)
			treeList.StartEdit("1")
		End If
	End Sub

	Protected Sub treeList_NodeValidating(ByVal sender As Object, ByVal e As TreeListNodeValidationEventArgs)
		If (Not IsStringValueNotEmpty(e.NewValues("From"))) Then
			e.Errors("From") = StringEmptyError
		End If
		If (Not IsStringValueNotEmpty(e.NewValues("Subject"))) Then
			e.Errors("Subject") = StringEmptyError
		End If
		If (Not IsDateValid(e.NewValues("DateCreated"))) Then
			e.Errors("Date") = "The date must be after 1980 year."
		End If
		If e.HasErrors Then
			e.NodeError = "Please, correct all errors."
		End If
	End Sub
	Protected Sub treeList_StartNodeEditing(ByVal sender As Object, ByVal e As TreeListNodeEditingEventArgs)
		treeList.DoNodeValidation()
	End Sub
	Protected Sub treeList_HtmlRowPrepared(ByVal sender As Object, ByVal e As TreeListHtmlRowEventArgs)
		If Object.Equals(e.RowKind, TreeListRowKind.Data) Then
			If (Not IsStringValueNotEmpty(e.GetValue("From"))) OrElse (Not IsStringValueNotEmpty(e.GetValue("Subject"))) OrElse (Not IsDateValid(e.GetValue("DateCreated"))) Then
				e.Row.ForeColor = System.Drawing.Color.Red
			End If
		End If
	End Sub

	Private Function IsStringValueNotEmpty(ByVal value As Object) As Boolean
		Return value IsNot Nothing AndAlso value.ToString().Trim().Length > 0
	End Function
	Private Function IsDateValid(ByVal value As Object) As Boolean
		If TypeOf value Is DateTime Then
			Return (CDate(value)).Year >= 1980
		End If
		Return False
	End Function
End Class
