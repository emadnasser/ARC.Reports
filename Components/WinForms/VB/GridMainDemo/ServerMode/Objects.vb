Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.IO
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos
	<DeferredDeletion(False)> _
	Public Class ServerSideLookUpTest
		Inherits XPObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public AssignTo As String
		Public Issue As ServerSideGridTest
		Public DueDate As Date
		Public PercentComplete As Integer
	End Class
	<DeferredDeletion(False)> _
	Public Class ServerSideGridTest
		Inherits XPObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		<Indexed> _
		Public Subject As String
		<Indexed> _
		Public [From] As String
		<Indexed> _
		Public Sent As Date
		<Indexed> _
		Public Size As Int64
		<Indexed> _
		Public HasAttachment As Boolean
		<Indexed> _
		Public Priority As Integer
	End Class
	Public Class MemoWriter
		Inherits TextWriter

		Public Memo As MemoEdit
		Public Sub New()
		End Sub
		Private ReadOnly enc As Encoding = New UnicodeEncoding(False, False)
		Public Overrides ReadOnly Property Encoding() As Encoding
			Get
				Return enc
			End Get
		End Property
		Public Overrides Sub Write(ByVal value As Char)
			Write(value.ToString())
		End Sub
		Public Overrides Sub Write(ByVal value As String)
			If Memo Is Nothing Then
				Return
			End If
			Memo.Text += value
			Memo.SelectionStart = Integer.MaxValue
		End Sub
	End Class
	Public Class WaitCursorWrapper
		Implements IDataStore

		Public ReadOnly Nested As IDataStore
		Public Sub New(ByVal nested As IDataStore)
			Me.Nested = nested
		End Sub
		Public ReadOnly Property AutoCreateOption() As AutoCreateOption Implements IDataStore.AutoCreateOption
			Get
				Return Nested.AutoCreateOption
			End Get
		End Property
		Public Function ModifyData(ParamArray ByVal dmlStatements() As ModificationStatement) As ModificationResult Implements IDataStore.ModifyData
			Try
				Cursor.Current = Cursors.WaitCursor
				Return Nested.ModifyData(dmlStatements)
			Finally
				Cursor.Current = Cursors.Default
			End Try
		End Function
		Public Function SelectData(ParamArray ByVal selects() As SelectStatement) As SelectedData Implements IDataStore.SelectData
			Try
				Cursor.Current = Cursors.WaitCursor
				Return Nested.SelectData(selects)
			Finally
				Cursor.Current = Cursors.Default
			End Try
		End Function
		Public Function UpdateSchema(ByVal dontCreateIfFirstTableNotExist As Boolean, ParamArray ByVal tables() As DBTable) As UpdateSchemaResult Implements IDataStore.UpdateSchema
			Try
				Cursor.Current = Cursors.WaitCursor
				Return Nested.UpdateSchema(dontCreateIfFirstTableNotExist, tables)
			Finally
				Cursor.Current = Cursors.Default
			End Try
		End Function
	End Class
	Public Class ServerModeStrings
		Public Shared SQLConnectionString As String = String.Empty
		Public Shared failedConnection As String = My.Resources.FailedConnection
		Public Shared failedConnectionCaption As String = My.Resources.FailedConnectionCaption
		Public Shared dataAdding As String = My.Resources.DataAdding
		Public Shared recordCount As String = My.Resources.CurrentRecordCount
	End Class
End Namespace
