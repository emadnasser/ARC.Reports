Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class NavBar_HeaderTemplate
	Inherits UserControl
	Implements ITemplate

	Private Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
		container.Controls.Add(Me)
	End Sub

End Class
