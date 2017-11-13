Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraRichEdit

Namespace DevExpress.MailClient.Win
	Partial Public Class ucMailViewer
		Inherits BaseControl

        Private _parent As BaseModule = Nothing
		Public Sub New()
			InitializeComponent()
			'lcTitle.Text = string.Empty;
			recMessage.Text = String.Empty
			bbiReply.Hint = My.Resources.ReplyDescription
			bbiReplyAll.Hint = My.Resources.ReplyAllDescription
			bbiForward.Hint = My.Resources.ForwardDescription
		End Sub
		Friend Sub SetParentModule(ByVal [module] As BaseModule)
            _parent = [module]
		End Sub
		Public Sub SetMenuManager(ByVal manager As IDXMenuManager)
			recMessage.MenuManager = manager
		End Sub
		Protected Overrides Sub LookAndFeelStyleChanged()
			MyBase.LookAndFeelStyleChanged()
			Dim windowColor As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("Window")
			Dim windowTextColor As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("WindowText")
			lgMessageInfo.AppearanceGroup.ForeColor = windowTextColor
			lgMessageInfo.AppearanceGroup.BackColor = windowColor
			'lcTitle.Appearance.BackColor = windowColor;
			lbSubject.ForeColor = windowTextColor
			lbFrom.ForeColor = lbSubject.ForeColor
			lbDate.ForeColor = lbFrom.ForeColor
			'lcTitle.Appearance.ForeColor = windowTextColor;
		End Sub
		Private Sub ShowMessageInfo(ByVal visible As Boolean)
			lgMessageInfo.Visibility = If(visible, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
		End Sub
		Friend Sub ShowMessage(ByVal message As Message)
			If message Is Nothing Then
				Return
			End If
			ShowMessageInfo(True)
			lbSubject.Text = message.Subject
			lbFrom.Text = message.From
			lbDate.Text = message.Date.ToString()
			'message.MailType
			'lcTitle.Text = string.Format("<size=+3><b>{0}<br><br></b><size=-4>{3}: <size=+2>{1}<br><size=-2>{4}: <size=+2>{2:g}<br>", message.Subject, message.From, message.Date, GetFromString(message.MailType), Properties.Resources.Date);
			recMessage.HtmlText = message.Text
		End Sub
		Private Function GetFromString(ByVal mailType As MailType) As String
			If mailType = MailType.Inbox Then
				Return My.Resources.FromInbox
			End If
			If mailType = MailType.Deleted Then
				Return My.Resources.FromDeleted
			End If
			Return My.Resources.FromOutbox
		End Function
		Friend Sub ShowMessagesInfo(ByVal messages As List(Of Message))
			ShowMessageInfo(False)
			'lcTitle.Text = string.Format("<size=+7> <size=-3><b>{0}</b> <size=-3>{1}", messages.Count, StringResources.GetMessagesString(messages.Count));
			Dim text As String = StringResources.Get("MessageTile")
			For Each message As Message In messages
				text &= String.Format(StringResources.Get("MessageTileEx"), message.From, message.Date, message.Subject)
			Next message
			text &= StringResources.Get("MessageTileEnd")
			recMessage.HtmlText = text
		End Sub
		Friend Sub ShowFeed(ByVal feed As FeedItem, ByVal showUrl As Boolean)
			ShowMessageInfo(False)
			If showUrl Then
				layoutControlItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Always
			Else
				layoutControlItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Never
			End If
			linkView.Text = feed.Url
			'lcTitle.Text = string.Format("<size=+3><b>{0}<br><br></b><size=-4>{3}: <size=+2>{1}<br><size=-2>{4}: <size=+2>{2:g}<br>", feed.Title, feed.From, feed.Date, Properties.Resources.From, Properties.Resources.Date);
			recMessage.HtmlText = feed.Description
		End Sub
		Friend Sub ClearInfo()
			'lcTitle.Text = string.Empty;
			recMessage.Text = String.Empty
			layoutControlItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Never
		End Sub
		Public Property ZoomFactor() As Single
			Get
				Return recMessage.Views.SimpleView.ZoomFactor
			End Get
			Set(ByVal value As Single)
				recMessage.Views.SimpleView.ZoomFactor = value
			End Set
		End Property
		Public ReadOnly Property RichEdit() As RichEditControl
			Get
				Return recMessage
			End Get
		End Property

		Private Sub bbiReply_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bbiReply.ItemClick
            _parent.ButtonClick(TagResources.Reply)
		End Sub
		Private Sub bbiReplyAll_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bbiReplyAll.ItemClick
            _parent.ButtonClick(TagResources.ReplyAll)
		End Sub
		Private Sub bbiForward_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bbiForward.ItemClick
            _parent.ButtonClick(TagResources.Forward)
		End Sub
	End Class
End Namespace
