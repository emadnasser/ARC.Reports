Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm
Imports System.ComponentModel
Imports System

Namespace DevExpress.DevAV.ViewModels

    Public MustInherit Class MailMergeViewModelBase(Of TMailTemplate As Structure)
        Implements ISupportParameter, IDocumentContent

        Public Overridable Property MailTemplate() As TMailTemplate?
        Protected Overridable Sub OnMailTemplateChanged()
            RaiseMailTemplateChanged()
        End Sub
        Public Overridable Property IsMailTemplateSelected() As Boolean
        Protected Overridable Sub OnIsMailTemplateSelectedChanged()
            RaiseMailTemplateSelectedChanged()
        End Sub
        Private Property ISupportParameter_Parameter() As Object Implements ISupportParameter.Parameter
            Get
                Return MailTemplate
            End Get
            Set(ByVal value As Object)
                IsMailTemplateSelected = TypeOf value Is TMailTemplate
                If IsMailTemplateSelected Then
                    MailTemplate = DirectCast(value, TMailTemplate)
                Else
                    MailTemplate = Nothing
                End If
            End Set
        End Property
        Public Event MailTemplateChanged As EventHandler
        Public Event MailTemplateSelectedChanged As EventHandler
        Private Sub RaiseMailTemplateChanged()
            Dim handler As EventHandler = MailTemplateChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Private Sub RaiseMailTemplateSelectedChanged()
            Dim handler As EventHandler = MailTemplateSelectedChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Protected ReadOnly Property MessageBoxService() As IMessageBoxService
            Get
                Return Me.GetService(Of IMessageBoxService)()
            End Get
        End Property
        Public Property Modified() As Boolean
        <DevExpress.Mvvm.DataAnnotations.Command>
        Public Function Close() As Boolean
            Dim result As MessageResult = MessageResult.Yes
            If Modified Then
                If MessageBoxService IsNot Nothing Then
                    result = MessageBoxService.Show("Do you want to save changes?", "Mail Merge", MessageButton.YesNoCancel, MessageIcon.Question, MessageResult.Yes)
                    If result = MessageResult.Yes Then
                        RaiseSave()
                    End If
                End If
            End If
            If result <> MessageResult.Cancel AndAlso DocumentOwner IsNot Nothing Then
                DocumentOwner.Close(Me)
            End If
            Return result <> MessageResult.Cancel
        End Function
        Public Event Save As EventHandler
        Private Sub RaiseSave()
            Dim handler As EventHandler = SaveEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Private privateDocumentOwner As IDocumentOwner
        Protected Property DocumentOwner() As IDocumentOwner
            Get
                Return privateDocumentOwner
            End Get
            Private Set(ByVal value As IDocumentOwner)
                privateDocumentOwner = value
            End Set
        End Property
        #Region "IDocumentContent"
        Private ReadOnly Property IDocumentContent_Title() As Object Implements IDocumentContent.Title
            Get
                Return "Mail Merge"
            End Get
        End Property
        Private Sub IDocumentContent_OnClose(ByVal e As CancelEventArgs) Implements IDocumentContent.OnClose
            e.Cancel = Not Close()
        End Sub
        Private Sub IDocumentContent_OnDestroy() Implements IDocumentContent.OnDestroy
        End Sub
        Private Property IDocumentContent_DocumentOwner() As IDocumentOwner Implements IDocumentContent.DocumentOwner
            Get
                Return DocumentOwner
            End Get
            Set(ByVal value As IDocumentOwner)
                DocumentOwner = value
            End Set
        End Property
        #End Region
    End Class
End Namespace
