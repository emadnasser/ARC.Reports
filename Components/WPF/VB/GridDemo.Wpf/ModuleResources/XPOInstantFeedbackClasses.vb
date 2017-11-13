Imports System
Imports System.Windows.Input
Imports DevExpress.Xpo

Namespace GridDemo
    <Persistent("dbo.SCIssuesDemo")>
    Public Class Question
        Inherits XPLiteObject

        <Key(True)>
        Public Property Oid() As Guid
        Public Property Id() As String
        Public Property Subject() As String
        Public Property ModifiedOn() As Date
        Public Property CreatedOn() As Date
        Public Property ProductName() As String
        Public Property TechnologyName() As String
        Public Property Urgent() As Boolean
        Public Property Status() As String
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New()
            MyBase.New(Session.DefaultSession)
        End Sub
    End Class
End Namespace
