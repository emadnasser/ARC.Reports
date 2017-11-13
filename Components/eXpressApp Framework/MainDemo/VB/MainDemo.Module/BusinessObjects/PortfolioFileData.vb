Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace MainDemo.Module.BusinessObjects
    <ImageName("BO_FileAttachment")> _
    Public Class PortfolioFileData
        Inherits FileAttachmentBase
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
            documentType_Renamed = DocumentType.Unknown
        End Sub
        Protected resume_Renamed As [Resume]
        <Association("Resume-PortfolioFileData")> _
        Public Property [Resume]() As [Resume]
            Get
                Return resume_Renamed
            End Get
            Set(ByVal value As [Resume])
                SetPropertyValue(Of [Resume])("Resume", resume_Renamed, value)
            End Set
        End Property
        Private documentType_Renamed As DocumentType
        Public Property DocumentType() As DocumentType
            Get
                Return documentType_Renamed
            End Get
            Set(ByVal value As DocumentType)
                SetPropertyValue(Of DocumentType)("DocumentType", documentType_Renamed, value)
            End Set
        End Property
    End Class
    Public Enum DocumentType
        SourceCode = 1
        Tests = 2
        Documentation = 3
        Diagrams = 4
        ScreenShots = 5
        Unknown = 6
    End Enum
End Namespace
