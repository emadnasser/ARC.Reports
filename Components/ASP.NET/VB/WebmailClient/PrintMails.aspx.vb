Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class PrintMails
	Inherits System.Web.UI.Page
	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		Utils.ApplyTheme(Me)
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim messages = DemoModel.DataProvider.Messages.Where(Function(m) m.Folder <> "Sent Items" AndAlso m.Folder <> "Drafts").Select(Function(m) New With {Key .From = m.From, Key .Subject = m.Subject, Key .Date = m.Date.ToShortDateString()})

		MailReportViewer.Report = New MailReport(messages)
	End Sub
End Class
