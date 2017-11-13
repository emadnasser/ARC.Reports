Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace MainDemo.Module.BusinessObjects
    <DefaultClassOptions(), ImageName("BO_Resume")> _
    Public Class [Resume]
        Inherits BaseObject
        Private contact_Renamed As Contact
        Private file_Renamed As FileData
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        <Aggregated(), ExpandObjectMembers(ExpandObjectMembers.Never)> _
        Public Property File() As FileData
            Get
                Return file_Renamed
            End Get
            Set(ByVal value As FileData)
                SetPropertyValue("File", file_Renamed, value)
            End Set
        End Property
        Public Property Contact() As Contact
            Get
                Return contact_Renamed
            End Get
            Set(ByVal value As Contact)
                SetPropertyValue("Contact", contact_Renamed, value)
            End Set
        End Property
        <Aggregated(), Association("Resume-PortfolioFileData")> _
        Public ReadOnly Property Portfolio() As XPCollection(Of PortfolioFileData)
            Get
                Return GetCollection(Of PortfolioFileData)("Portfolio")
            End Get
        End Property
    End Class
End Namespace
