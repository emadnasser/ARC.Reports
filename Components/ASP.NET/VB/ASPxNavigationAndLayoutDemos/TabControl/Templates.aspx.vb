Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web.UI

Partial Public Class TabControl_Templates
	Inherits Page
	Private Const htmlLocation As String = "~/App_Data/Html"
	Public Function GetHtml(ByVal htmlFileName As String) As String
		Dim resolvedPath As String = MapPath(Path.Combine(htmlLocation, htmlFileName))
		Return File.ReadAllText(resolvedPath)
	End Function
	Public Function GetImageUrl(ByVal name As String) As String
		Return "../TabControl/Images/" & name & ".jpg"
	End Function
End Class
