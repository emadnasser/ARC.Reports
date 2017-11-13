Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class ImageSlider_FolderBinding
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ASPxImageSlider1.ImageSourceFolder = cbSelectFolder.Value.ToString()
		End If
	End Sub
	Protected Sub cbSelectFolder_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxImageSlider1.ImageSourceFolder = cbSelectFolder.Value.ToString()
	End Sub
End Class
