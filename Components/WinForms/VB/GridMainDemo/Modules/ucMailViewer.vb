Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraGrid.Demos
Imports DevExpress.Utils.Design

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ucMailViewer
        Inherits XtraUserControl
        Public Sub New()
            InitializeComponent()
            lcTitle.Text = String.Empty
            recMessage.Text = String.Empty
        End Sub
        Public Sub SetMenuManager(ByVal manager As IDXMenuManager)
            recMessage.MenuManager = manager
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If Not DesignTimeTools.IsDesignMode Then
                LookAndFeelStyleChanged()
            End If
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Not DesignTimeTools.IsDesignMode) Then
                RemoveHandler LookAndFeel.ActiveLookAndFeel.StyleChanged, AddressOf ActiveLookAndFeel_StyleChanged
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private Sub ActiveLookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            LookAndFeelStyleChanged()
        End Sub
        Private Sub LookAndFeelStyleChanged()
            Dim windowColor As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("Window")
            Dim windowTextColor As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("WindowText")
            lcTitle.Appearance.BackColor = windowColor
            lcTitle.Appearance.ForeColor = windowTextColor
        End Sub
        Private Sub ShowMessageAdditions(ByVal visible As Boolean)
            layoutControlItem5.Visibility = If(visible, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
            layoutControlItem4.Visibility = layoutControlItem5.Visibility
        End Sub
        Friend Sub ShowMessage(ByVal message As DevExpress.XtraGrid.Demos.Message)
            If message Is Nothing Then
                Return
            End If
            ShowMessageAdditions(True)
            lcTitle.Text = String.Format("<size=+3><b>{0}<br><br></b><size=-4>{3}: <size=+2>{1}<br><size=-2>{4}: <size=+2>{2:g}<br>", message.Subject, message.From, message.Date, GetFromString(message.MailType), dDate)
            recMessage.HtmlText = message.Text
        End Sub
        Private Function GetFromString(ByVal mailType As MailType) As String
            Return My.Resources.FromString
        End Function
        Friend Sub ShowMessagesInfo(ByVal messages As List(Of DevExpress.XtraGrid.Demos.Message))
            ShowMessageAdditions(False)
            lcTitle.Text = String.Format("<size=+7> <size=-3><b>{0}</b> <size=-3>{1}", messages.Count, MessageFromCount)
            Dim text As String = MessageTile
            For Each message As DevExpress.XtraGrid.Demos.Message In messages
                text &= String.Format(MessageTileEx, message.From, message.Date, message.Subject)
            Next message
            text &= MessageTileEnd
            recMessage.HtmlText = text
        End Sub
        Friend Sub ClearInfo()
            lcTitle.Text = String.Empty
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
        End Sub
        Private Sub bbiReplyAll_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bbiReplyAll.ItemClick
        End Sub
        Private Sub bbiForward_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bbiForward.ItemClick
        End Sub
        Const MessageTile As String = "<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.0 Transitional//EN""><html><body><style type=""text/css"">.style1{font-size: x-small;font-family: ""Segoe UI"";}.style2{font-family: ""Segoe UI"";color: #666666;}.style3{font-family: ""Segoe UI"";}</style>"
        Const MessageTileEx As String = "<span class=""style3"">{0} (</span><span class=""style1"">{1}</span><span class=""style3"">)</span><span class=""style2""><br />{2}<br /><br /></span>"
        Const MessageTileEnd As String = "</body></html>"
        Const MessageFromCount As String = "Message(s)"
        Const dDate As String = "Date"
    End Class
End Namespace
