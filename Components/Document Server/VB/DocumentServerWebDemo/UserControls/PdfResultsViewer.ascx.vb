Imports Microsoft.VisualBasic
Imports System

Partial Public Class UserControls_PdfResultsViewer
	Inherits System.Web.UI.UserControl
	Public Sub SetText(ByVal text As String)
		ASPxMemo1.Text = text
	End Sub
End Class
