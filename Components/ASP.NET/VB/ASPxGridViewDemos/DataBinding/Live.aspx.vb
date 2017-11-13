Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class DataBinding_Live
	Inherits Page

	Protected Function GetIconImageUrl(ByVal container As GridViewDataItemTemplateContainer) As String
		Dim quote As Quote = CType(grid.GetRow(container.VisibleIndex), Quote)
		Return String.Format("Images/{0}.gif",If(quote.Change >= 0, "Up", "Down"))
	End Function

	Protected Function GetPercentageText(ByVal container As GridViewDataItemTemplateContainer) As String
		Dim quote As Quote = CType(grid.GetRow(container.VisibleIndex), Quote)
		Return quote.Change.ToString("P")
	End Function

End Class
