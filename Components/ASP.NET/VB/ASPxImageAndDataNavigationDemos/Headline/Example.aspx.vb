Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Headline_Example
	Inherits Page
	Protected Function ConvertToDate(ByVal dateObject As Object) As DateTime
		Return DateTime.Parse(dateObject.ToString().Replace(" PST", ""))
	End Function
End Class
