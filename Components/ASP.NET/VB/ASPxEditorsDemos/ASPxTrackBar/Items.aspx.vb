Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Demos

Partial Public Class ASPxTrackBar_Items
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Function GetImageUrl(ByVal day As Object) As String
		Return String.Format("Images/TimeLapse{0}.jpg", day)
	End Function
End Class
