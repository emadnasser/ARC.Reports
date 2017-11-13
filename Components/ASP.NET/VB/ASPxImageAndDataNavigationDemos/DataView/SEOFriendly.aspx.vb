Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class DataViewControl_Example
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			' Rebind is called, since BinaryImage doesn't store its content in 
			' View State by default. To change this behavior, 
			' toggle the StoreContentBytesInViewState option.
			ASPxDataView1.DataBind()
		End If
	End Sub
End Class
