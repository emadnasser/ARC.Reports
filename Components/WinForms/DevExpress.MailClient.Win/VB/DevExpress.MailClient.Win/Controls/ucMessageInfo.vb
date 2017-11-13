Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
Imports System.Collections

Namespace DevExpress.MailClient.Win.Controls
	Partial Public Class ucMessageInfo
		Inherits XtraUserControl

		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub Init(ByVal message As Message, ByVal menuManager As IDXMenuManager)
			gridControl1.MenuManager = menuManager
			lcName.Text = message.From
			pictureEdit1.Image = My.Resources.Unknown_user
			gridControl1.DataSource = GetMailByContactData(message)
			lcgContact.Text = My.Resources.Contact
			lcgMail.Text = String.Format("{0} ({1})", My.Resources.Mail, gridView1.DataRowCount)
		End Sub
		Private Function GetMailByContactData(ByVal messageMain As Message) As Object
			Dim ret As IEnumerable = From message In DataHelper.Messages _
			                         Where message.From = messageMain.From AndAlso message.MailType = MailType.Inbox _
			                         Select message
			Return ret.Cast(Of Message)().ToList()
		End Function
	End Class
End Namespace
