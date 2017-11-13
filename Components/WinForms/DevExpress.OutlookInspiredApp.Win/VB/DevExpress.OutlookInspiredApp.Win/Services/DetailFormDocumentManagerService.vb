Imports DevExpress.Mvvm
Imports DevExpress.DevAV.Services
Imports DevExpress.DevAV.Modules
Imports System.Windows.Forms
Imports System

Namespace DevExpress.DevAV

    Friend MustInherit Class DetailFormDocumentManagerServiceBase
        Inherits DocumentManagerServiceBase

        Private ReadOnly viewModuleType As ModuleType
        Public Sub New(ByVal viewModuleType As ModuleType)
            Me.viewModuleType = viewModuleType
        End Sub
        #Region "Document"
        Protected Class DetailFormDocument
            Implements IDocument, IDocumentInfo

            Private ReadOnly contentCore As Object
            Private ReadOnly formCore As Form
            Private ReadOnly owner As DetailFormDocumentManagerServiceBase

            Private state_Renamed As DocumentState = DocumentState.Hidden
            Public Sub New(ByVal owner As DetailFormDocumentManagerServiceBase, ByVal form As Form, ByVal content As Object)
                Me.owner = owner
                Me.formCore = form
                Me.contentCore = content
                form.AutoValidate = AutoValidate.EnableAllowFocusChange
                AddHandler form.Closing, AddressOf form_Closing
                AddHandler form.Closed, AddressOf form_Closed
            End Sub
            Private Sub form_Closed(ByVal sender As Object, ByVal e As EventArgs)
                owner.RemoveDocument(Me)
                RemoveHandler formCore.Closing, AddressOf form_Closing
                RemoveHandler formCore.Closed, AddressOf form_Closed
                Dim documentContent As IDocumentContent = TryCast(GetContent(), IDocumentContent)
                If documentContent IsNot Nothing Then
                    documentContent.OnDestroy()
                End If
            End Sub
            Private Sub form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
                Dim documentContent As IDocumentContent = TryCast(GetContent(), IDocumentContent)
                If documentContent IsNot Nothing Then
                    documentContent.OnClose(e)
                End If
                If Not destroyOnCloseCore Then
                    Dim cancel As Boolean = e.Cancel
                    e.Cancel = True
                    If Not cancel Then
                        formCore.Hide()
                    End If
                End If
            End Sub
            Private Sub IDocument_Show() Implements IDocument.Show
                If Not formCore.Visible Then
                    formCore.Show(AppHelper.MainForm)
                Else
                    formCore.Activate()
                End If
                state_Renamed = DocumentState.Visible
            End Sub
            Private Sub IDocument_Hide() Implements IDocument.Hide
                formCore.Hide()
                state_Renamed = DocumentState.Hidden
            End Sub
            Private Sub IDocument_Close(Optional ByVal force As Boolean = True) Implements IDocument.Close
                If force Then
                    RemoveHandler formCore.Closing, AddressOf form_Closing
                    DevExpress.XtraEditors.Container.ContainerHelper.ClearUnvalidatedControl(formCore.ActiveControl, formCore)
                End If
                formCore.Close()
                state_Renamed = DocumentState.Hidden
            End Sub
            Private destroyOnCloseCore As Boolean = True
            Private Property IDocument_DestroyOnClose() As Boolean Implements IDocument.DestroyOnClose
                Get
                    Return destroyOnCloseCore
                End Get
                Set(ByVal value As Boolean)
                    destroyOnCloseCore = value
                End Set
            End Property
            Private Property IDocument_Id() As Object Implements IDocument.Id
            Private Property IDocument_Title() As Object Implements IDocument.Title
                Get
                    Return formCore.Text
                End Get
                Set(ByVal value As Object)
                    formCore.Text = Convert.ToString(value)
                End Set
            End Property
            Private ReadOnly Property IDocument_Content() As Object Implements IDocument.Content
                Get
                    Return GetContent()
                End Get
            End Property
            Private Function GetContent() As Object
                Return contentCore
            End Function
            Private ReadOnly Property IDocumentInfo_State() As DocumentState Implements IDocumentInfo.State
                Get
                    Return state_Renamed
                End Get
            End Property
            Private ReadOnly Property IDocumentInfo_DocumentType() As String Implements IDocumentInfo.DocumentType
                Get
                    Return Nothing
                End Get
            End Property
        End Class
        #End Region ' Document
        Protected Function IsDefaultViewModuleType(ByVal actualViewModuleType As ModuleType) As Boolean
            Return viewModuleType = actualViewModuleType
        End Function
        Protected Overridable Function GetActualViewModuleType(ByVal documentType As String, ByVal parentViewModel As Object) As ModuleType
            If documentType = "MapView" Then
                Dim resolver = GetService(Of Services.IModuleTypesResolver)(parentViewModel)
                Return resolver.GetMapModuleType(viewModuleType)
            End If
            If documentType = "MailMerge" Then
                Dim resolver = GetService(Of Services.IModuleTypesResolver)(parentViewModel)
                Return resolver.GetMailMergeModuleType(viewModuleType)
            End If
            If documentType = "Analysis" Then
                Dim resolver = GetService(Of Services.IModuleTypesResolver)(parentViewModel)
                Return resolver.GetAnalysisModuleType(viewModuleType)
            End If
            Return viewModuleType
        End Function
        Protected Shared Function CreateView(ByVal parameter As Object, ByVal actualModuleType As ModuleType, ByVal moduleLocator As IModuleLocator) As Object
            If TypeOf parameter Is System.Delegate Then
                Return moduleLocator.CreateModule(actualModuleType)
            End If
            If TypeOf parameter Is Long Then
                Return moduleLocator.GetModule(actualModuleType, DirectCast(parameter, Long))
            Else
                Return moduleLocator.GetModule(actualModuleType)
            End If
        End Function
        Protected Function RegisterDetailFormDocumentForModule(ByVal viewModel As Object, ByVal parentViewModel As Object, ByVal parameter As Object, ByVal actualModuleType As ModuleType) As IDocument
            Dim waitingService = GetService(Of Services.IWaitingService)(parentViewModel)
            Using waitingService.Enter(actualModuleType)
                Dim moduleLocator = GetService(Of Services.IModuleLocator)(parentViewModel)
                Dim view As Object = CreateView(parameter, actualModuleType, moduleLocator)
                viewModel = EnsureViewModel(viewModel, parameter, parentViewModel, view)
                Return RegisterDocument(view, Function(container) New DetailFormDocument(Me, container, viewModel), Function() New DetailForm(), parameter)
            End Using
        End Function
    End Class
    Friend Class DetailFormDocumentManagerService
        Inherits DetailFormDocumentManagerServiceBase
        Implements IDocumentManagerService

        Public Sub New(ByVal viewModuleType As ModuleType)
            MyBase.New(viewModuleType)
        End Sub
        Protected Overrides Function CreateDocumentCore(ByVal documentType As String, ByVal viewModel As Object, ByVal parentViewModel As Object, ByVal parameter As Object) As IDocument
            Dim actualModuleType = GetActualViewModuleType(documentType, parentViewModel)
            Return RegisterDetailFormDocumentForModule(viewModel, parentViewModel, parameter, actualModuleType)
        End Function
    End Class
    Friend Class NotImplementedDetailFormDocumentManagerService
        Inherits DetailFormDocumentManagerServiceBase
        Implements IDocumentManagerService

        Public Sub New(ByVal viewModuleType As ModuleType)
            MyBase.New(viewModuleType)
        End Sub
        Protected Overrides Function CreateDocumentCore(ByVal documentType As String, ByVal viewModel As Object, ByVal parentViewModel As Object, ByVal parameter As Object) As IDocument
            Dim actualModuleType = GetActualViewModuleType(documentType, parentViewModel)
            Return If(IsDefaultViewModuleType(actualModuleType), New DXOverviewDocument(), RegisterDetailFormDocumentForModule(viewModel, parentViewModel, parameter, actualModuleType))
        End Function
        #Region "DXAbout"
        Protected Class DXOverviewDocument
            Implements IDocument, IDocumentInfo

            Private form As Form = New DevExpress.XtraEditors.XtraForm()

            Private state_Renamed As DocumentState = DocumentState.Hidden
            Private Const captionText As String = "DevExpress"
            Private Const descriptionText As String = "You can easily create custom edit forms using the 40+ controls that ship as part of the DevExpress Data Editors Library.<br>" & "To see what you can build, <href=Employees>activate the Employees module.</href>"
            #Region "IDocument Members"
            Private Sub IDocument_Show() Implements IDocument.Show
                Dim overview As New OverviewControl()
                form.MinimizeBox = False
                form.MaximizeBox = False
                form.FormBorderStyle = FormBorderStyle.FixedDialog
                form.Text = captionText
                form.ClientSize = overview.Size
                form.MinimumSize = form.Size
                overview.SetDescription(descriptionText)
                overview.Dock = DockStyle.Fill
                overview.Parent = form
                form.StartPosition = FormStartPosition.CenterParent
                form.Icon = AppHelper.AppIcon
                Using form
                    form.ShowDialog(AppHelper.MainForm)
                End Using
                state_Renamed = DocumentState.Visible
            End Sub
            Private ReadOnly Property IDocument_Content() As Object Implements IDocument.Content
                Get
                    Return Nothing
                End Get
            End Property
            Private Property IDocument_DestroyOnClose() As Boolean Implements IDocument.DestroyOnClose
            Private Sub IDocument_Hide() Implements IDocument.Hide
                form.Close()
                state_Renamed = DocumentState.Hidden
            End Sub
            Private Sub IDocument_Close(Optional ByVal force As Boolean = True) Implements IDocument.Close
                form.Close()
                state_Renamed = DocumentState.Hidden
            End Sub
            Private Property IDocument_Title() As Object Implements IDocument.Title
            Private Property IDocument_Id() As Object Implements IDocument.Id
            #End Region

            Private ReadOnly Property IDocumentInfo_State() As DocumentState Implements IDocumentInfo.State
                Get
                    Return state_Renamed
                End Get
            End Property
            Private ReadOnly Property IDocumentInfo_DocumentType() As String Implements IDocumentInfo.DocumentType
                Get
                    Return Nothing
                End Get
            End Property
        End Class
        #End Region
    End Class
End Namespace
