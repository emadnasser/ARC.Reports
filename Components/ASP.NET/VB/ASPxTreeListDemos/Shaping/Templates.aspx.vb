Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxTreeList

Partial Public Class Shaping_Templates
	Inherits Page
	Protected Sub treList_CustomDataCallback(ByVal sender As Object, ByVal e As TreeListCustomDataCallbackEventArgs)
		Dim node As TreeListNode = treeList.FindNodeByFieldValue("ID", Int32.Parse(e.Argument))
		If node IsNot Nothing Then
			e.Result = node("Notes").ToString()
		End If
	End Sub
End Class
