Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class PopupControl_ServerSide
	Inherits Page
	Private Const WindowText As String = "[Enter some text here and then press the Create Note button]"

	Private Property StartLeft() As Integer
		Set(ByVal value As Integer)
			ViewState("StartLeft") = value
		End Set
		Get
			Return If(ViewState("StartLeft") IsNot Nothing, CInt(Fix(ViewState("StartLeft"))), 650)
		End Get
	End Property
	Private Property StartTop() As Integer
		Set(ByVal value As Integer)
			ViewState("StartTop") = value
		End Set
		Get
			Return If(ViewState("StartTop") IsNot Nothing, CInt(Fix(ViewState("StartTop"))), 270)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub

	Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim pcWindow As New PopupWindow(ASPxMemo1.Text)
		pcWindow.FooterText = DateTime.Now.ToString("MM/dd/yyyy HH:mm")
		pcWindow.ShowOnPageLoad = True
		pcWindow.Left = StartLeft
		pcWindow.Top = StartTop
		StartLeft += 20
		StartTop += 20
		ASPxPopupControl1.Windows.Add(pcWindow)
		ASPxMemo1.Text = WindowText
		ASPxMemo1.Style(HtmlTextWriterStyle.Color) = "gray"
	End Sub

	Protected Sub hlClearAllNotes_Click(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPopupControl1.Windows.Clear()
		StartLeft = 650
		StartTop = 270
	End Sub
End Class
