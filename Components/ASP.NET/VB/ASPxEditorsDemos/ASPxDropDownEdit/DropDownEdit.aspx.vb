Imports Microsoft.VisualBasic
Imports System.Collections
Imports System.Web.UI
Imports DevExpress.Web.ASPxTreeList

Partial Public Class ASPxDropDownEdit_DropDownEdit
	Inherits Page
	Protected Sub TreeList_CustomJSProperties(ByVal sender As Object, ByVal e As TreeListCustomJSPropertiesEventArgs)
		Dim treeList As ASPxTreeList = TryCast(sender, ASPxTreeList)
		Dim nameTable As New Hashtable()
		For Each node As TreeListNode In treeList.GetVisibleNodes()
			nameTable.Add(node.Key, String.Format("{0} {1}", node("FirstName"), node("LastName")))
		Next node
		e.Properties("cpEmployeeNames") = nameTable
	End Sub
End Class
