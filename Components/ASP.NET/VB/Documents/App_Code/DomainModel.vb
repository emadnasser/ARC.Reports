Imports System
Imports System.Collections.Generic
Imports System.IO

Public Class Item
    Public Sub New()
        ChildItems = New List(Of Item)()
    End Sub
    Public Property Id() As Long
    Public Property Name() As String
    Public Property IsFolder() As Boolean
    Public Overridable Property Content() As BinaryContent
    Public Overridable Property Owner() As User
    Public Property CreationTime() As Date
    Public Property LastAccessTime() As Date
    Public Property LastWriteTime() As Date
    Public Overridable Property ChildItems() As List(Of Item)
    Public Overridable Property ParentItem() As Item
    Public ReadOnly Property IsRoot() As Boolean
        Get
            Return ParentItem Is Nothing
        End Get
    End Property

    Public Sub UpdateContent(ByVal content() As Byte)
        Me.Content.Data = content
        LastWriteTime = Date.Now
    End Sub
End Class

Public Class BinaryContent
    Public Property Id() As Long
    Public Overridable Property Data() As Byte()
End Class

Public Class User
    Public Property Id() As Long
    Public Property AccountName() As String
    Public Property Name() As String
    Public Property Password() As String
    Public Overridable Property Avatar() As BinaryContent
End Class
