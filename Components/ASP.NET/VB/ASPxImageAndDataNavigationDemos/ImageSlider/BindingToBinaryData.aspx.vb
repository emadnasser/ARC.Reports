Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ImageSlider_BinaryImage
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If rbFiltering.SelectedIndex <> 0 Then
			ImagesDataSource.Where = String.Format("it.CategoryID = {0}", rbFiltering.Value)
		End If
	End Sub
End Class
