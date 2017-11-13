Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Drawing
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web

Partial Public Class PopupControl_ContentUrldata2
	Inherits Page
	Private Const SuccessText As String = "Your message has been successfully sent."

	Protected Sub ButtonSend_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim form As HtmlForm = TryCast(Page.FindControl("MailForm"), HtmlForm)
		If form IsNot Nothing Then
			form.Controls.Clear()
			Dim textControl As WebControl = CreateCentredText()
			textControl.ForeColor = Color.FromArgb(0, 51, 51)
			If textControl IsNot Nothing Then
				form.Controls.Add(textControl)
			End If
		End If
	End Sub

	Protected Overridable Function CreateCentredText() As WebControl
		Dim table As New Table()
		Dim row As New TableRow()
		Dim cell As New TableCell()

		table.Rows.Add(row)
		row.Cells.Add(cell)
		cell.Controls.Add(New LiteralControl(String.Format("<div id=""SuccessText"">{0}</div>", SuccessText)))

		cell.Controls.Add(New LiteralControl("&nbsp;"))

		Dim buttonSendNewMsg As New ASPxButton()
		buttonSendNewMsg.ID = "ButtonSendNewMsg"
		buttonSendNewMsg.RenderMode = ButtonRenderMode.Link
		buttonSendNewMsg.Text = "Send message"

		cell.Controls.Add(buttonSendNewMsg)

		table.Height = Unit.Percentage(100)
		table.Width = Unit.Percentage(100)
		table.BorderWidth = Unit.Pixel(0)

		cell.VerticalAlign = VerticalAlign.Middle
		cell.HorizontalAlign = HorizontalAlign.Center

		Return table
	End Function
End Class
