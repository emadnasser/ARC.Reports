Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class UserControls_ShowQueryBuilderButtonControl
	Inherits UserControl
	Public Sub New()
		MyBase.New()
		AddHandler Me.Init, AddressOf showQueryBuilderButton_Init
	End Sub
	Protected Sub showQueryBuilderButton_Init(ByVal sender As Object, ByVal e As EventArgs)
		Me.hfShowTooltip("showTooltip") = QueryBuilderHelper.NeedToShowTooltip(Session)
	End Sub
End Class
