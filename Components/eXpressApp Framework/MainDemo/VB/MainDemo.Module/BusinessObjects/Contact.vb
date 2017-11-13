Imports System
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace MainDemo.Module.BusinessObjects
    <DefaultClassOptions()> _
    Public Class Contact
        Inherits Person
        Private webPageAddress_Renamed As String
        Private manager_Renamed As Contact
        Private nickName_Renamed As String
        Private spouseName_Renamed As String
        Private titleOfCourtesy_Renamed As TitleOfCourtesy
        Private notes_Renamed As String
        Private anniversary_Renamed As Nullable(Of DateTime)
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Property WebPageAddress() As String
            Get
                Return webPageAddress_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("WebPageAddress", webPageAddress_Renamed, value)
            End Set
        End Property
        <DataSourceProperty("Department.Contacts", DataSourcePropertyIsNullMode.SelectAll), DataSourceCriteria("Position.Title = 'Manager' AND Oid != '@This.Oid'")> _
        Public Property Manager() As Contact
            Get
                Return manager_Renamed
            End Get
            Set(ByVal value As Contact)
                SetPropertyValue("Manager", manager_Renamed, value)
            End Set
        End Property
        Public Property NickName() As String
            Get
                Return nickName_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("NickName", nickName_Renamed, value)
            End Set
        End Property
        Public Property SpouseName() As String
            Get
                Return spouseName_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("SpouseName", spouseName_Renamed, value)
            End Set
        End Property
        Public Property TitleOfCourtesy() As TitleOfCourtesy
            Get
                Return titleOfCourtesy_Renamed
            End Get
            Set(ByVal value As TitleOfCourtesy)
                SetPropertyValue("TitleOfCourtesy", titleOfCourtesy_Renamed, value)
            End Set
        End Property
        Public Property Anniversary() As Nullable(Of DateTime)
            Get
                Return anniversary_Renamed
            End Get
            Set(ByVal value As Nullable(Of DateTime))
                SetPropertyValue("Anniversary", anniversary_Renamed, value)
            End Set
        End Property
        <Size(4096)> _
        Public Property Notes() As String
            Get
                Return notes_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Notes", notes_Renamed, value)
            End Set
        End Property
        Private department_Renamed As Department
        <Association("Department-Contacts"), ImmediatePostData()> _
        Public Property Department() As Department
            Get
                Return department_Renamed
            End Get
            Set(ByVal value As Department)
                SetPropertyValue("Department", department_Renamed, value)
                If Not IsLoading Then
                    Position = Nothing
                    If Manager IsNot Nothing AndAlso Manager.Department IsNot value Then
                        Manager = Nothing
                    End If
                End If
            End Set
        End Property
        Private position_Renamed As Position
        Public Property Position() As Position
            Get
                Return position_Renamed
            End Get
            Set(ByVal value As Position)
                SetPropertyValue("Position", position_Renamed, value)
            End Set
        End Property
        <Association("Contact-DemoTask")> _
        Public ReadOnly Property Tasks() As XPCollection(Of DemoTask)
            Get
                Return GetCollection(Of DemoTask)("Tasks")
            End Get
        End Property
        Private changeHistory_Renamed As XPCollection(Of AuditDataItemPersistent)
        Public ReadOnly Property ChangeHistory() As XPCollection(Of AuditDataItemPersistent)
            Get
                If changeHistory_Renamed Is Nothing Then
                    changeHistory_Renamed = AuditedObjectWeakReference.GetAuditTrail(Session, Me)
                End If
                Return changeHistory_Renamed
            End Get
        End Property
    End Class
    Public Enum TitleOfCourtesy
        Dr
        Miss
        Mr
        Mrs
        Ms
    End Enum
End Namespace
