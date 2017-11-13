Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Threading
Imports DevExpress.Web
Imports System.ComponentModel

Partial Public Class NewsControl_DataBinding
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsCallback Then
			' Intentionally pauses server-side processing, 
			' to demonstrate the Loading Panel functionality.
			Thread.Sleep(500)
		End If
	End Sub

	Protected Sub ASPxCallback1_Callback(ByVal sender As Object, ByVal e As CallbackEventArgs)
		Dim newsID As Integer = Integer.Parse(e.Parameter)
		Dim dataSource As IHierarchicalDataSource = TryCast(XmlDataSource1, IHierarchicalDataSource)
		Dim view As HierarchicalDataSourceView = dataSource.GetHierarchicalView("")
		Dim enumerable As IHierarchicalEnumerable = view.Select()
		Dim index As Integer = 1
		Dim text As String = ""

		For Each obj As Object In enumerable
			If newsID = index Then
				Dim data As IHierarchyData = enumerable.GetHierarchyData(obj)
				Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(data)
				Dim descriptor As PropertyDescriptor = properties.Find("Text", True)
				text = descriptor.GetValue(obj).ToString()
				Exit For
			End If
			index += 1
		Next obj
		e.Result = text
	End Sub
End Class
