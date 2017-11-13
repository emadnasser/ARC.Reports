Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class Modules_ASPxGridView
	Inherits Page
	Private Const SessionID As String = "SCDemo.UpdatedRowMarker"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxWebControl.RegisterBaseScript(Page)
		If (Not IsPostBack) AndAlso (Not IsCallback) Then
			ASPxGridView1.StartEdit(1)
		End If
	End Sub
	Protected Sub ASPxGridView1_CellEditorInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewEditorEventArgs)
		If CheckSessionUpdateRowMarker(e.KeyValue) AndAlso (TypeOf e.Editor Is ASPxTextBox OrElse TypeOf e.Editor Is ASPxMemo) AndAlso e.Value IsNot Nothing Then
			Dim text As String = e.Value.ToString()
			Dim words() As String = text.Split(New Char() { " "c })
			For i As Integer = 0 To words.Length - 1
				If words(i).Length > 5 Then
					words(i) &= "a"
				End If
			Next i
			e.Editor.Value = String.Join(" ", words)
		End If
	End Sub
	Protected Sub SetSessionUpdateRowMarker(ByVal id As Object)
		Dim marker As String = CStr(Session(SessionID))
		Dim newMarker As String = String.Format("[{0}]", id)
		If String.IsNullOrEmpty(marker) OrElse (Not marker.Contains(newMarker)) Then
			marker &= newMarker
			Session(SessionID) = marker
		End If
	End Sub
	Protected Function CheckSessionUpdateRowMarker(ByVal id As Object) As Boolean
		Dim marker As String = CStr(Session(SessionID))
		Return String.IsNullOrEmpty(marker) OrElse Not marker.Contains(String.Format("[{0}]", id))
	End Function
	Protected Sub EmployeesDataSource_Updating(ByVal sender As Object, ByVal e As Microsoft.AspNet.EntityDataSource.EntityDataSourceChangingEventArgs)
		SetSessionUpdateRowMarker((TryCast(e.Entity, Employee)).EmployeeID)
	End Sub
End Class
