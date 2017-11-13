Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Web.Demos

<Persistent("Emails")> _
Friend Class XpoEmailEntity
	Inherits XPLiteObject
	Private _id As Integer
	Private _subject As String
	Private _from As String
	Private _sent As DateTime
	Private _size As Long
	Private _hasAttachment As Boolean

	Public Sub New(ByVal session As Session)
		MyBase.New(session)
	End Sub

	<Key(True)> _
	Public Property ID() As Integer
		Get
			Return _id
		End Get
		Set(ByVal value As Integer)
			_id = value
		End Set
	End Property

	Public Property Subject() As String
		Get
			Return _subject
		End Get
		Set(ByVal value As String)
			_subject = value
		End Set
	End Property

	Public Property [From]() As String
		Get
			Return _from
		End Get
		Set(ByVal value As String)
			_from = value
		End Set
	End Property

	Public Property Sent() As DateTime
		Get
			Return _sent
		End Get
		Set(ByVal value As DateTime)
			_sent = value
		End Set
	End Property

	Public Property Size() As Long
		Get
			Return _size
		End Get
		Set(ByVal value As Long)
			_size = value
		End Set
	End Property

	Public Property HasAttachment() As Boolean
		Get
			Return _hasAttachment
		End Get
		Set(ByVal value As Boolean)
			_hasAttachment = value
		End Set
	End Property

	Protected Overrides Sub OnSaving()
		Utils.AssertNotReadOnly()
	End Sub

	Protected Overrides Sub OnDeleting()
		Utils.AssertNotReadOnly()
	End Sub
End Class
