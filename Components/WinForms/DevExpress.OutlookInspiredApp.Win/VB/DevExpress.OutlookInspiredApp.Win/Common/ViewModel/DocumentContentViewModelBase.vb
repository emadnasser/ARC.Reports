Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm
Imports System.ComponentModel

Namespace DevExpress.DevAV

    Public MustInherit Class DocumentContentViewModelBase
        Implements IDocumentContent

        Protected Sub New()
        End Sub
        <Command>
        Public Sub Close()
            DirectCast(Me, IDocumentContent).DocumentOwner.Close(Me)
        End Sub
        #Region "IDocumentContent"
        Private Sub IDocumentContent_OnClose(ByVal e As CancelEventArgs) Implements IDocumentContent.OnClose
        End Sub
        Private Sub IDocumentContent_OnDestroy() Implements IDocumentContent.OnDestroy
        End Sub
        Private Property IDocumentContent_DocumentOwner() As IDocumentOwner Implements IDocumentContent.DocumentOwner
        Private ReadOnly Property IDocumentContent_Title() As Object Implements IDocumentContent.Title
            Get
                Return GetTitle()
            End Get
        End Property
        Protected Overridable Function GetTitle() As String
            Return Nothing
        End Function
        #End Region
    End Class
End Namespace
