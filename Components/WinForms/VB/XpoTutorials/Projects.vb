Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace DevExpress.Xpo.Demos
    Public Enum ProjectStatus
        Fixed
        [New]
        Postponed
        Rejected
    End Enum
    Public Enum ProjectType
        Bug
        Request
    End Enum

    Public Class Project
        Inherits XPObject
        Public Sub New()
        End Sub
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal projectName As String, ByVal name As String, ByVal owner As String, ByVal createdDate As DateTime, ByVal status As ProjectStatus, ByVal projectType As ProjectType)
            MyBase.New(session)
            Me.fProjectName = projectName
            Me.fName = name
            Me.fOwner = owner
            Me.fCreatedDate = createdDate
            Me.fStatus = status
            Me.fProjectType = projectType
        End Sub

        Private fProjectName As String
        Private fName As String
        Private fOwner As String
        Private fCreatedDate As DateTime
        Private fStatus As ProjectStatus
        Private fProjectType As ProjectType

        Public Property ProjectName() As String
            Get
                Return fProjectName
            End Get
            Set(ByVal value As String)
                ' The old value of the ProjectName property.
                Dim oldValue As String = ProjectName
                If oldValue = Value Then
                    Return
                End If
                fProjectName = Value
                ' Keep track of every change made to the ProjectName property.
                OnChanged("ProjectName", oldValue, Value)
            End Set
        End Property

        Public Property Name() As String
            Get
                Return fName
            End Get
            Set(ByVal value As String)
                Dim oldValue As String = Name
                If oldValue = Value Then
                    Return
                End If
                fName = Value
                OnChanged("Name", oldValue, Value)
            End Set
        End Property

        Public Property Owner() As String
            Get
                Return fOwner
            End Get
            Set(ByVal value As String)
                Dim oldValue As String = Owner
                If oldValue = Value Then
                    Return
                End If
                fOwner = Value
                OnChanged("Owner", oldValue, Value)
            End Set
        End Property

        Public Property CreatedDate() As DateTime
            Get
                Return fCreatedDate
            End Get
            Set(ByVal value As DateTime)
                Dim oldValue As DateTime = CreatedDate
                If oldValue = Value Then
                    Return
                End If
                fCreatedDate = Value
                OnChanged("CreatedDate", oldValue, Value)
            End Set
        End Property

        Public Property Status() As ProjectStatus
            Get
                Return fStatus
            End Get
            Set(ByVal value As ProjectStatus)
                Dim oldValue As ProjectStatus = Status
                If oldValue = Value Then
                    Return
                End If
                fStatus = Value
                OnChanged("Status", oldValue, Value)
            End Set
        End Property

        Public Property ProjectType() As ProjectType
            Get
                Return fProjectType
            End Get
            Set(ByVal value As ProjectType)
                Dim oldValue As ProjectType = ProjectType
                If oldValue = Value Then
                    Return
                End If
                fProjectType = Value
                OnChanged("ProjectType", oldValue, Value)
            End Set
        End Property
    End Class
End Namespace
