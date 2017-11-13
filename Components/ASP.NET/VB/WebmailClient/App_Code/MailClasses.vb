Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data.Linq
Imports System.Linq
Imports System.Web
Imports System.Web.SessionState
Imports DevExpress.Data.Filtering

Public Module QueryableExtensions
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertToMessages(ByVal source As IQueryable(Of DBMessage)) As IQueryable(Of Message)
		Return source.Select(Function(x) New Message With {.Date = x.Date, .Folder = x.Folder, .From = x.From, .HasAttachment = x.HasAttachment, .ID = x.ID, .IsReply = x.IsReply, .Subject = x.Subject, .Text = x.Text, .To = x.To, .Unread = x.Unread})
	End Function
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertToContacts(ByVal source As IQueryable(Of DBContact)) As IQueryable(Of Contact)
		Return source.Select(Function(x) New Contact With {.Address = x.Address, .City = x.City, .Collected = x.Collected, .Country = x.Country, .Email = x.Email, .ID = x.ID, .Name = x.Name, .Phone = x.Phone, .PhotoUrl = x.PhotoUrl})
	End Function
End Module

Public Class GetAddressFunction
	Implements ICustomFunctionOperator
	Private Shared ReadOnly instance As New GetAddressFunction()
	Public Shared Sub Register()
		CriteriaOperator.RegisterCustomFunction(instance)
	End Sub
	Public Shared Function Unregister() As Boolean
		Return CriteriaOperator.UnregisterCustomFunction(instance)
	End Function
	Private Function ResultType(ParamArray ByVal operands() As Type) As Type Implements ICustomFunctionOperator.ResultType
		Return GetType(String)
	End Function
	Private Function Evaluate(ParamArray ByVal operands() As Object) As Object Implements ICustomFunctionOperator.Evaluate
		Return String.Join(", ", operands.Where(Function(x) (Not String.IsNullOrEmpty(TryCast(x, String)))))
	End Function
	Private ReadOnly Property Name() As String Implements ICustomFunctionOperator.Name
		Get
			Return "GetAddress"
		End Get
	End Property
End Class

Public Class Message
	Private _date As DateTime
	Private _to As String

	Public Property ID() As Integer
	Public Property Subject() As String
	Public Property [Date]() As DateTime
		Get
			Return _date
		End Get
		Set(ByVal value As DateTime)
			_date = value
		End Set
	End Property
	Public Property From() As String
	Public Property [To]() As String
		Get
			Return _to
		End Get
		Set(ByVal value As String)
			_to = value
		End Set
	End Property
	Public Property Text() As String
	Public Property Folder() As String
	Public Property HasAttachment() As Boolean
	Public Property IsReply() As Boolean
	Public Property Unread() As Boolean
End Class

Public Class Contact
	Public Property ID() As Integer
	Public Property Name() As String
	Public Property Email() As String
	Public Property Address() As String
	Public Property Phone() As String
	Public Property Country() As String
	Public Property City() As String
	Public Property PhotoUrl() As String
	Public Property Collected() As Boolean
End Class

Public NotInheritable Class DemoModel
	Private Shared currentDataProvider As DataProviderBase
	Private Sub New()
	End Sub
	Public Shared ReadOnly Property DataProvider() As DataProviderBase
		Get
			If currentDataProvider Is Nothing Then
				currentDataProvider = CreateDataProvider()
			End If
			Return currentDataProvider
		End Get
	End Property
	Private Shared Function CreateDataProvider() As DataProviderBase
		If Utils.IsSiteMode Then
			Return New SiteModeDataProvider()
		End If
		Return New DBDataProvider()
	End Function
End Class

Public MustInherit Class DataProviderBase
	Public Shared NoUpdateContactPhoto As String = "NoUpdateContactPhoto"
	Public MustOverride ReadOnly Property Messages() As IEnumerable(Of Message)
	Public MustOverride ReadOnly Property UnreadMessages() As IEnumerable(Of Message)
	Public MustOverride ReadOnly Property Contacts() As IEnumerable(Of Contact)

	Public MustOverride Sub AddMessage(ByVal subject As String, ByVal [to] As String, ByVal text As String, ByVal folder As String)
	Public MustOverride Sub UpdateMessage(ByVal id As Integer, ByVal subject As String, ByVal [to] As String, ByVal text As String, ByVal folder As String)
	Public MustOverride Sub MarkMessagesAs(ByVal read As Boolean, ByVal ids As IEnumerable(Of Integer))
	Public MustOverride Sub DeleteMessages(ByVal ids As IEnumerable(Of Integer))

	Public MustOverride Sub AddContact(ByVal name As String, ByVal email As String, ByVal address As String, ByVal country As String, ByVal city As String, ByVal phone As String, ByVal photoUrl As String)
	Public MustOverride Sub UpdateContact(ByVal id As Integer, ByVal name As String, ByVal email As String, ByVal address As String, ByVal country As String, ByVal city As String, ByVal phone As String, ByVal photoUrl As String)
	Public MustOverride Sub DeleteContact(ByVal id As Integer)
End Class

Public Class DBDataProvider
	Inherits DataProviderBase
	Public Overrides ReadOnly Property Messages() As IEnumerable(Of Message)
		Get
			Return GetDataContext().DBMessages.ConvertToMessages()
		End Get
	End Property
	Public Overrides ReadOnly Property UnreadMessages() As IEnumerable(Of Message)
		Get
			Return Messages.Where(Function(m) m.Unread)
		End Get
	End Property
	Public Overrides ReadOnly Property Contacts() As IEnumerable(Of Contact)
		Get
			Return GetDataContext().DBContacts.ConvertToContacts()
		End Get
	End Property

	Protected Function GetDataContext() As WebmailClientDataContext
		Return New WebmailClientDataContextExt()
	End Function

	Public Overrides Sub AddMessage(ByVal subject As String, ByVal [to] As String, ByVal text As String, ByVal folder As String)
		Dim context = GetDataContext()
		context.DBMessages.InsertOnSubmit(New DBMessage() With {.Date = DateTime.Now, .Subject = subject, .From = Utils.ThomasEmail, .To = [to], .Text = text, .Folder = folder})
		context.SubmitChanges()
	End Sub


	Public Overrides Sub UpdateMessage(ByVal id As Integer, ByVal subject As String, ByVal [to] As String, ByVal text As String, ByVal folder As String)
		Dim context = GetDataContext()
		Dim m = context.DBMessages.FirstOrDefault(Function(i) i.ID = id)
		If m Is Nothing Then
			Return
		End If
		m.Date = DateTime.Now
		m.Subject = subject
		m.From = Utils.ThomasEmail
		m.To = [to]
		m.Text = text
		m.Folder = folder
		context.SubmitChanges()
	End Sub
	Public Overrides Sub MarkMessagesAs(ByVal read As Boolean, ByVal ids As IEnumerable(Of Integer))
		Dim context = GetDataContext()
		For Each m In context.DBMessages.Where(Function(i) ids.Contains(i.ID))
			m.Unread = Not read
		Next m
'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning disable 168
		Try
			context.SubmitChanges()
		Catch e As ChangeConflictException
		End Try
'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning restore 168
	End Sub
	Public Overrides Sub DeleteMessages(ByVal ids As IEnumerable(Of Integer))
		Dim context = GetDataContext()
		context.DBMessages.DeleteAllOnSubmit(context.DBMessages.Where(Function(i) ids.Contains(i.ID)))
		context.SubmitChanges()
	End Sub
	Public Overrides Sub AddContact(ByVal name As String, ByVal email As String, ByVal address As String, ByVal country As String, ByVal city As String, ByVal phone As String, ByVal photoUrl As String)
		Dim context = GetDataContext()
		context.DBContacts.InsertOnSubmit(New DBContact() With {.Name = name, .Email = email, .Address = address, .Country = country, .City = city, .Phone = phone, .PhotoUrl = photoUrl})
		context.SubmitChanges()
	End Sub
	Public Overrides Sub UpdateContact(ByVal id As Integer, ByVal name As String, ByVal email As String, ByVal address As String, ByVal country As String, ByVal city As String, ByVal phone As String, ByVal photoUrl As String)
		Dim context = GetDataContext()
		Dim c = context.DBContacts.FirstOrDefault(Function(i) i.ID = id)
		If c Is Nothing Then
			Return
		End If
		c.Name = name
		c.Email = email
		c.Address = address
		c.Country = country
		c.City = city
		c.Phone = phone
		If photoUrl <> DataProviderBase.NoUpdateContactPhoto Then
			c.PhotoUrl = photoUrl
		End If
		context.SubmitChanges()
	End Sub
	Public Overrides Sub DeleteContact(ByVal id As Integer)
		Dim context = GetDataContext()
		Dim c = context.DBContacts.FirstOrDefault(Function(i) i.ID = id)
		If c Is Nothing Then
			Return
		End If
		context.DBContacts.DeleteOnSubmit(c)
		context.SubmitChanges()
	End Sub
End Class

Public Class SiteModeDataProvider
	Inherits DataProviderBase
	Private Const MessagesContextKey As String = "65F741CC-9222-4DA5-AD98-1BD9124E54AF"
	Private Const ContactsContextKey As String = "1ADB0A67-3343-4D6D-90A3-780448DC747E"

	Protected Shared DBMessages As List(Of Message) = CreateDBMessageList()
	Protected Shared DBContacts As List(Of Contact) = CreateDBContactList()

	Public Sub New()
		Utils.StartClearExpiredFilesBackgroundThread()
	End Sub

	Private ReadOnly Property Context() As HttpContext
		Get
			Return HttpContext.Current
		End Get
	End Property
	Private ReadOnly Property Session() As HttpSessionState
		Get
			Return Context.Session
		End Get
	End Property

	Protected ReadOnly Property SessionMessages() As List(Of Message)
		Get
			Dim key = "07A5E5BF-4C38-4C6C-A324-B81D24730AAD"
			If Session(key) Is Nothing Then
				Session(key) = New List(Of Message)()
			End If
			Return CType(Session(key), List(Of Message))
		End Get
	End Property
	Protected ReadOnly Property DeletedDBMessagesKeys() As List(Of Integer)
		Get
			Dim key = "4200605D-F2A3-4192-90CC-F11E739654FC"
			If Session(key) Is Nothing Then
				Session(key) = New List(Of Integer)()
			End If
			Return CType(Session(key), List(Of Integer))
		End Get
	End Property
	Protected ReadOnly Property UnreadMessagesKeys() As List(Of Integer)
		Get
			Dim key = "7B2D4B7E-5A7B-457B-B9D5-6821F55DE59E"
			If Session(key) Is Nothing Then
				Session(key) = DBMessages.Where(Function(m) m.Unread).Select(Function(i) i.ID).ToList()
			End If
			Return CType(Session(key), List(Of Integer))
		End Get
	End Property
	Protected ReadOnly Property SessionContacts() As List(Of Contact)
		Get
			Dim key = "068191AC-A820-483E-B450-8AD9DD1A51A7"
			If Session(key) Is Nothing Then
				Session(key) = New List(Of Contact)()
			End If
			Return CType(Session(key), List(Of Contact))
		End Get
	End Property
	Protected ReadOnly Property DeletedDBContactsKeys() As List(Of Integer)
		Get
			Dim key = "07B7041A-9416-4267-B9DB-BF53FAB64D3C"
			If Session(key) Is Nothing Then
				Session(key) = New List(Of Integer)()
			End If
			Return CType(Session(key), List(Of Integer))
		End Get
	End Property

	Public Overrides ReadOnly Property Messages() As IEnumerable(Of Message)
		Get
			If Context.Items(MessagesContextKey) Is Nothing Then
				Context.Items(MessagesContextKey) = LoadMessages()
			End If
			Return CType(Context.Items(MessagesContextKey), IEnumerable(Of Message))
		End Get
	End Property
	Public Overrides ReadOnly Property UnreadMessages() As IEnumerable(Of Message)
		Get
			Return Messages.Where(Function(m) UnreadMessagesKeys.Contains(m.ID))
		End Get
	End Property
	Public Overrides ReadOnly Property Contacts() As IEnumerable(Of Contact)
		Get
			If Context.Items(ContactsContextKey) Is Nothing Then
				Context.Items(ContactsContextKey) = LoadContacts()
			End If
			Return CType(Context.Items(ContactsContextKey), IEnumerable(Of Contact))
		End Get
	End Property

	Protected Sub ForceReloadMessages()
		Context.Items(MessagesContextKey) = Nothing
	End Sub

	Protected Sub ForceReloadContacts()
		Context.Items(ContactsContextKey) = Nothing
	End Sub

	Protected Function LoadMessages() As List(Of Message)
		Dim list = DBMessages.Where(Function(dbM) (Not SessionMessages.Any(Function(m) m.ID = dbM.ID)) AndAlso (Not DeletedDBMessagesKeys.Contains(dbM.ID))).ToList()
		list.AddRange(SessionMessages)
		Return list
	End Function
	Protected Function LoadContacts() As List(Of Contact)
		Dim list = DBContacts.Where(Function(dbC) (Not SessionContacts.Any(Function(c) c.ID = dbC.ID)) AndAlso (Not DeletedDBContactsKeys.Contains(dbC.ID))).ToList()
		list.AddRange(SessionContacts)
		Return list
	End Function

	Public Overrides Sub AddMessage(ByVal subject As String, ByVal [to] As String, ByVal text As String, ByVal folder As String)
		SessionMessages.Add(New Message() With {.ID = Math.Max(DBMessages.Max(Function(m) m.ID), Messages.Max(Function(m) m.ID)) + 1, .Date = DateTime.Now, .Subject = subject, .From = Utils.ThomasEmail, .To = [to], .Text = text, .Folder = folder})
		ForceReloadMessages()
	End Sub

	Public Overrides Sub UpdateMessage(ByVal id As Integer, ByVal subject As String, ByVal [to] As String, ByVal text As String, ByVal folder As String)
		Dim m = SessionMessages.FirstOrDefault(Function(i) i.ID = id)
		Dim dbM = DBMessages.FirstOrDefault(Function(i) i.ID = id)

		If m Is Nothing AndAlso dbM IsNot Nothing Then
			m = CloneMessage(dbM)
			SessionMessages.Add(m)
		End If
		If m IsNot Nothing Then
			m.Date = DateTime.Now
			m.Subject = subject
			m.From = Utils.ThomasEmail
			m.To = [to]
			m.Text = text
			m.Folder = folder
			ForceReloadMessages()
		End If
	End Sub

	Public Overrides Sub MarkMessagesAs(ByVal read As Boolean, ByVal ids As IEnumerable(Of Integer))
		For Each id In ids
			Dim contains = UnreadMessagesKeys.Contains(id)
			If read AndAlso contains Then
				UnreadMessagesKeys.Remove(id)
			ElseIf (Not read) AndAlso (Not contains) Then
				UnreadMessagesKeys.Add(id)
			End If
		Next id
	End Sub

	Public Overrides Sub DeleteMessages(ByVal ids As IEnumerable(Of Integer))
		For Each id In ids
			Dim sessionMessage = SessionMessages.FirstOrDefault(Function(m) m.ID = id)
			If sessionMessage IsNot Nothing Then
				SessionMessages.Remove(sessionMessage)
			Else
				DeletedDBMessagesKeys.Add(id)
			End If
		Next id
		MarkMessagesAs(True, ids)
		ForceReloadMessages()
	End Sub

	Public Overrides Sub AddContact(ByVal name As String, ByVal email As String, ByVal address As String, ByVal country As String, ByVal city As String, ByVal phone As String, ByVal photoUrl As String)
		SessionContacts.Add(New Contact() With {.ID = Math.Max(DBContacts.Max(Function(c) c.ID), Contacts.Max(Function(c) c.ID)) + 1, .Name = name, .Email = email, .Address = address, .Country = country, .City = city, .Phone = phone, .PhotoUrl = photoUrl})
		ForceReloadContacts()

	End Sub

	Public Overrides Sub UpdateContact(ByVal id As Integer, ByVal name As String, ByVal email As String, ByVal address As String, ByVal country As String, ByVal city As String, ByVal phone As String, ByVal photoUrl As String)
		Dim c = SessionContacts.FirstOrDefault(Function(i) i.ID = id)
		Dim dbC = DBContacts.FirstOrDefault(Function(i) i.ID = id)

		If c Is Nothing AndAlso dbC IsNot Nothing Then
			c = CloneContact(dbC)
			SessionContacts.Add(c)
		End If
		If c IsNot Nothing Then
			c.Name = name
			c.Email = email
			c.Address = address
			c.Country = country
			c.City = city
			c.Phone = phone
			If photoUrl <> DataProviderBase.NoUpdateContactPhoto Then
				c.PhotoUrl = photoUrl
			End If
			ForceReloadContacts()
		End If
	End Sub

	Public Overrides Sub DeleteContact(ByVal id As Integer)
		Dim sessionContact = SessionContacts.FirstOrDefault(Function(c) c.ID = id)
		If sessionContact IsNot Nothing Then
			SessionContacts.Remove(sessionContact)
		End If
		DeletedDBContactsKeys.Add(id)
		ForceReloadContacts()
	End Sub

	Private Shared Function CreateDBMessageList() As List(Of Message)
		Return New WebmailClientDataContextExt().DBMessages.ConvertToMessages().ToList()
	End Function
	Private Shared Function CreateDBContactList() As List(Of Contact)
		Return New WebmailClientDataContextExt().DBContacts.ConvertToContacts().ToList()
	End Function

	Private Shared Function CloneMessage(ByVal source As Message) As Message
		Return New Message() With {.ID = source.ID, .Subject = source.Subject, .Date = source.Date, .From = source.From, .To = source.To, .Text = source.Text, .Folder = source.Folder, .HasAttachment = source.HasAttachment, .IsReply = source.IsReply, .Unread = source.Unread}
	End Function
	Private Shared Function CloneContact(ByVal source As Contact) As Contact
		Return New Contact() With {.ID = source.ID, .Name = source.Name, .Email = source.Email, .Address = source.Address, .Country = source.Country, .City = source.City, .Phone = source.Phone, .PhotoUrl = source.PhotoUrl, .Collected = source.Collected}
	End Function
End Class

