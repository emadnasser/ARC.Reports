Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.Web.Demos.PdfPager
	Public Class PdfPager
		Inherits ASPxPager
		Protected Overrides Sub CreateControlHierarchy()
			MyBase.CreateControlHierarchy()
			Summary.Text = "Page {0} of {1}"
		End Sub
		Protected Overrides Function GetItemElementOnClick(ByVal id As String) As String
			Return String.Format("aspxPagerOnClick('{0}','{1}');", ClientID, id)
		End Function
	End Class
End Namespace
