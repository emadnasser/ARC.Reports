Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Common_RightToLeft
	Inherits Page
	Protected Function GetRatingValue(ByVal value As Object) As Decimal
		Return If(value IsNot Nothing, Decimal.Parse(CStr(value)), 0)
	End Function
End Class
