Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Data.Filtering
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private Const PreviewMessageFormat As String = "<div class='MailPreview'>" & "<div class='Subject'>{0}</div>" & "<div class='Info'>" & "<div>From: {1}</div>" & "<div>To: {2}</div>" & "<div>Date: {3:g}</div>" & "</div>" & "<div class='Separator'></div>" & "<div class='Body'>{4}</div>" & "</div>", ReplyMessageFormat As String = "Hi,<br/><br/><br/><br/>Thanks,<br/>Thomas Hardy<br/><br/><br/>----- Original Message -----<br/>Subject: {0}<br/>From: {1}<br/>To: {2}<br/>Date: {3:g}<br/>{4}", NotFoundMessageFormat As String = "<h1>Can't find message with the key={0}</h1>"

	Protected ReadOnly Property SearchText() As String
		Get
			Return Utils.GetSearchText(Me)
		End Get
	End Property

	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		Utils.ApplyTheme(Me)
	End Sub

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			CheckMailTreeSelectedNode()
		End If
	End Sub

	Protected Sub Page_Load(ByVal s As Object, ByVal e As EventArgs)
		CheckMailTreeSelectedNode()
		If ShouldBindGrid() Then
			BindGrid()
		End If
		If MailFormPanel.IsCallback OrElse IsPostBack AndAlso (Not IsCallback) Then
			AddressesList.DataSource = DemoModel.DataProvider.Contacts.Select(Function(c) New With {Key .Text = c.Name, Key .Value = c.Email, Key .ImageUrl = Utils.GetContactPhotoUrl(c.PhotoUrl)})
			AddressesList.DataBind()
		End If

		MailGrid.DataColumns("To").Visible = ShowToColumn()
		MailGrid.DataColumns("From").Visible = Not ShowToColumn()
		If Utils.CurrentTheme Is "iOS" Then
			MailGrid.Columns(0).Width = Unit.Pixel(77)
		End If
		If Utils.CurrentTheme Is "Material" Then
			MailGrid.Columns(0).Width = Unit.Pixel(65)
		End If
	End Sub

	Private Sub BindGrid()
		MailGrid.DataSource = SelectMessages()
		MailGrid.DataBind()
	End Sub

	Private Function ShouldBindGrid() As Boolean
		Return (Not IsCallback) OrElse MailGrid.IsCallback
	End Function

	Protected Function ShowToColumn() As Boolean
		Return MailTree.SelectedNode.Name = "Sent Items" OrElse MailTree.SelectedNode.Name = "Drafts"
	End Function

	Protected Sub MailPreviewPanel_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
		Dim id As Integer
		Dim text = String.Format(NotFoundMessageFormat, e.Parameter)
		If Integer.TryParse(e.Parameter, id) Then
			Dim message = DemoModel.DataProvider.Messages.FirstOrDefault(Function(m) m.ID = id)
			If message IsNot Nothing Then
				DemoModel.DataProvider.MarkMessagesAs(True, New Integer() { id })
				Dim subject = message.Subject
				If message.IsReply Then
					subject = "Re: " & subject
				End If
				text = String.Format(PreviewMessageFormat, subject, message.From, message.To, message.Date, message.Text)
			End If
		End If
		MailPreviewPanel.Controls.Add(New LiteralControl(text))
	End Sub

	Protected Sub MailGrid_CustomDataCallback(ByVal sender As Object, ByVal e As ASPxGridViewCustomDataCallbackEventArgs)
		Dim args = e.Parameters.Split("|"c)
		If args(0) = "MailForm" AndAlso args(1) = "Reply" AndAlso args.Length = 3 Then
			Dim id As Integer
			If (Not Integer.TryParse(args(2), id)) Then
				Return
			End If
			Dim message = DemoModel.DataProvider.Messages.FirstOrDefault(Function(m) m.ID = id)
			If message Is Nothing Then
				Return
			End If
			Dim result = New Dictionary(Of String, String)()
			result("To") = message.To

			Dim subject = message.Subject
			If (Not subject.StartsWith("Re: ")) Then
				subject = "Re: " & subject
			End If
			result("Subject") = subject

			result("Text") = FormatMessageCore(message, ReplyMessageFormat)
			e.Result = result
		End If
		If args(0) = "MailForm" AndAlso args.Length = 3 AndAlso args(1) = "EditDraft" Then
			Dim id As Integer
			If (Not Integer.TryParse(args(2), id)) Then
				Return
			End If
			Dim message = DemoModel.DataProvider.Messages.FirstOrDefault(Function(m) m.ID = id)
			If message Is Nothing Then
				Return
			End If
			Dim result = New Dictionary(Of String, String)()
			result("To") = message.To
			result("Subject") = message.Subject
			result("Text") = message.Text
			e.Result = result
		End If
		If args(0) = "MarkAs" AndAlso args.Length > 2 Then
			Dim read = args(1) = "Read"
			Dim keys() As Integer = Nothing
			If (Not TryParseKeyValues(args.Skip(2), keys)) Then
				Return
			End If
			DemoModel.DataProvider.MarkMessagesAs(read, keys)
		End If
	End Sub

	Protected Sub MailGrid_CustomCallback(ByVal sender As Object, ByVal e As ASPxGridViewCustomCallbackEventArgs)
		If String.IsNullOrEmpty(e.Parameters) Then
			Return
		End If
		Dim args = e.Parameters.Split("|"c)
		If args(0) = "FolderChanged" OrElse args(0) = "Search" Then
			Dim filter As String = If(args(0) = "Search", SearchText, String.Empty)
			MailGrid.SearchPanelFilter = filter
			BindGrid()
			MailGrid.ExpandAll()
		End If
		If args(0) = "SendMail" OrElse args(0) = "SaveMail" Then
			Dim subject = SubjectEditor.Text
			Dim [to] = ToEditor.Text
			Dim messageText As String = If(MailEditor.Html.Length <= 10000, MailEditor.Html, MailEditor.Html.Substring(0, 10000))
			Dim folder As String = If(args(0) = "SendMail", "Sent Items", "Drafts")
			Dim id As Integer
			If args.Length = 2 AndAlso Integer.TryParse(args(1), id) Then
				DemoModel.DataProvider.UpdateMessage(id, subject, [to], messageText, folder)
			Else
				DemoModel.DataProvider.AddMessage(subject, [to], messageText, folder)
			End If
			BindGrid()
		End If
		If args(0) = "Delete" AndAlso args.Length > 1 Then
			Dim keys() As Integer = Nothing
			If (Not TryParseKeyValues(args.Skip(1), keys)) Then
				Return
			End If
			DemoModel.DataProvider.DeleteMessages(keys)
			BindGrid()
		End If
	End Sub

	Protected Sub MailGrid_CustomJSProperties(ByVal sender As Object, ByVal e As ASPxGridViewClientJSPropertiesEventArgs)
		If MailTree.SelectedNode.Name = "Inbox" Then
			Dim list = New List(Of Message)()
			For i = 0 To MailGrid.VisibleRowCount - 1
				If MailGrid.IsGroupRow(i) Then
					Continue For
				End If
				Dim message = TryCast(MailGrid.GetRow(i), Message)
				If message IsNot Nothing Then
					list.Add(message)
				End If
			Next i
			e.Properties("cpVisibleMailKeysHash") = GetMessagesKeyMap(list)
		End If
	End Sub

	Protected Sub MailTree_CustomJSProperties(ByVal sender As Object, ByVal e As CustomJSPropertiesEventArgs)
		e.Properties("cpUnreadMessagesHash") = GetMessagesKeyMap(DemoModel.DataProvider.UnreadMessages)
	End Sub

	Protected Sub MailGrid_CustomColumnDisplayText(ByVal sender As Object, ByVal e As ASPxGridViewColumnDisplayTextEventArgs)
		If e.Column.FieldName = "Subject" AndAlso CBool(e.GetFieldValue("IsReply")) Then
			e.DisplayText = String.Format("Re: {0}", e.Value)
		End If
		If e.Column.FieldName = "To" Then
			Dim list = New List(Of String)()
			For Each item In e.Value.ToString().Split(","c)
				Dim email = item.Trim()
				Dim contact = DemoModel.DataProvider.Contacts.FirstOrDefault(Function(c) c.Email = email)
				list.Add(If(contact IsNot Nothing, contact.Name, email))
			Next item
			e.DisplayText = String.Join(", ", list)
		End If
		If e.Column.FieldName = "From" Then
			Dim From = e.Value.ToString()
			Dim contact = DemoModel.DataProvider.Contacts.FirstOrDefault(Function(c) c.Email = From)
			e.DisplayText = If(contact IsNot Nothing, contact.Name, From)
		End If
	End Sub

	Protected Sub MailGrid_CustomGroupDisplayText(ByVal sender As Object, ByVal e As ASPxGridViewColumnDisplayTextEventArgs)
		If e.Column.FieldName = "Subject" Then
			e.DisplayText = HttpUtility.HtmlEncode(e.Value)
		End If
	End Sub

	Private Function SelectMessages() As List(Of Message)
		Dim result = DemoModel.DataProvider.Messages.AsQueryable()
		If MailTree.SelectedNode.Text = "Inbox" Then
			result = result.Where(Function(m) m.Folder <> "Sent Items" AndAlso m.Folder <> "Drafts")
		Else
			result = result.Where(Function(m) m.Folder = MailTree.SelectedNode.Text)
		End If
		Return result.ToList()
	End Function

	Private Function FormatMessageCore(ByVal message As Message, ByVal format As String) As String
		Dim subject = message.Subject
		If message.IsReply Then
			subject = "Re: " & subject
		End If
		Return String.Format(format, subject, message.From, message.To, message.Date, message.Text)
	End Function

	Private Sub CheckMailTreeSelectedNode()
		If MailTree.SelectedNode Is Nothing Then
			MailTree.SelectedNode = MailTree.Nodes.FindByText("Inbox")
		End If
	End Sub

	Protected Function TryParseKeyValues(ByVal stringKeys As IEnumerable(Of String), <System.Runtime.InteropServices.Out()> ByRef resultKeys() As Integer) As Boolean
		resultKeys = Nothing
		Dim list = New List(Of Integer)()
		For Each sKey In stringKeys
			Dim key As Integer
			If (Not Integer.TryParse(sKey, key)) Then
				Return False
			End If
			list.Add(key)
		Next sKey
		resultKeys = list.ToArray()
		Return True
	End Function

	Private Function GetMessagesKeyMap(ByVal messages As IEnumerable(Of Message)) As Dictionary(Of String, List(Of String))
		Dim dict = New Dictionary(Of String, List(Of String))()
		Dim query = messages.GroupBy(Function(m) m.Folder).Where(Function(g) g.Count() > 0)
		For Each item In messages.GroupBy(Function(m) m.Folder).Where(Function(g) g.Count() > 0)
			dict.Add(item.Key, item.Select(Function(m) m.ID.ToString()).ToList())
		Next item
		Return dict
	End Function
End Class
