Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Native
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Xpf.Docking
Imports Microsoft.Win32

Namespace DockingDemo.ViewModels
    Public MustInherit Class ViewModel
        Implements IDisposable

        Protected Sub New()
        End Sub
        Private privateDisplayName As String
        Public Overridable Property DisplayName() As String
            Get
                Return privateDisplayName
            End Get
            Protected Set(ByVal value As String)
                privateDisplayName = value
            End Set
        End Property
        Public Overridable Property Glyph() As ImageSource
        #Region "IDisposable Members"
        Public Sub Dispose() Implements IDisposable.Dispose
            OnDispose()
        End Sub
        Protected Overridable Sub OnDispose()
        End Sub
#If DEBUG Then
        Protected Overrides Sub Finalize()
            Dim msg As String = String.Format("{0} ({1}) ({2}) Finalized", Me.GetType().Name, DisplayName, GetHashCode())
            System.Diagnostics.Debug.WriteLine(msg)
        End Sub
#End If
        #End Region 'IDisposable Members
    End Class
    Public MustInherit Class WorkspaceViewModel
        Inherits ViewModel

        Protected Sub New()
            IsClosed = True
        End Sub

        Public Event RequestClose As EventHandler

        Public Overridable Property IsActive() As Boolean
        <BindableProperty(OnPropertyChangedMethodName := "OnIsClosedChanged")>
        Public Overridable Property IsClosed() As Boolean
        Public Overridable Property IsOpened() As Boolean

        Public Sub Close()
            Dim handler As EventHandler = RequestCloseEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Protected Overridable Sub OnIsClosedChanged()
            IsOpened = Not IsClosed
        End Sub
    End Class
    Public Class CommandViewModel
        Inherits ViewModel

        Public Sub New()
        End Sub
        Public Sub New(ByVal displayName As String, ByVal subCommands As List(Of CommandViewModel))
            Me.New(displayName, Nothing, Nothing, subCommands)
        End Sub
        Public Sub New(ByVal displayName As String, Optional ByVal command As ICommand = Nothing)
            Me.New(displayName, Nothing, command, Nothing)
        End Sub
        Public Sub New(ByVal owner As WorkspaceViewModel, ByVal command As ICommand)
            Me.New(String.Empty, owner, command)
        End Sub
        Private Sub New(ByVal displayName As String, Optional ByVal owner As WorkspaceViewModel = Nothing, Optional ByVal command As ICommand = Nothing, Optional ByVal subCommands As List(Of CommandViewModel) = Nothing)
            IsEnabled = True
            Me.Owner = owner
            If Me.Owner IsNot Nothing Then
                Me.DisplayName = Me.Owner.DisplayName
                Glyph = Me.Owner.Glyph
            Else
                Me.DisplayName = displayName
            End If
            Me.Command = command
            Commands = subCommands
        End Sub

        Private privateCommand As ICommand
        Public Property Command() As ICommand
            Get
                Return privateCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateCommand = value
            End Set
        End Property
        Public Property Commands() As List(Of CommandViewModel)
        Public Property IsEnabled() As Boolean
        Public Property IsSeparator() As Boolean
        Public Property IsSubItem() As Boolean
        Public Property KeyGesture() As KeyGesture
        Private privateOwner As WorkspaceViewModel
        Public Property Owner() As WorkspaceViewModel
            Get
                Return privateOwner
            End Get
            Private Set(ByVal value As WorkspaceViewModel)
                privateOwner = value
            End Set
        End Property
    End Class
    Public MustInherit Class PanelWorkspaceViewModel
        Inherits WorkspaceViewModel
        Implements IMVVMDockingProperties

        Protected Sub New()
            DirectCast(Me, IMVVMDockingProperties).TargetName = WorkspaceName
        End Sub
        Protected Sub New(ByVal supportPinnedState As Boolean)
            ShowPinButton = supportPinnedState
        End Sub

        Public Overridable Property IsPreview() As Boolean
        <BindableProperty(OnPropertyChangedMethodName := "OnPinnedChanged")>
        Public Overridable Property Pinned() As Boolean
        Public Overridable Property ShowPinButton() As Boolean
        Protected MustOverride ReadOnly Property WorkspaceName() As String
        Private Property IMVVMDockingProperties_TargetName() As String Implements IMVVMDockingProperties.TargetName
        Public Overridable Function Open() As Boolean
            Return False
        End Function
        Protected Sub OnPinnedChanged()
            If IsPreview Then
                IsPreview = False
            End If
        End Sub
    End Class
    Public Class ToolboxViewModel
        Inherits PanelWorkspaceViewModel

        Public Sub New()
            DisplayName = "Toolbox"
            Glyph = New BitmapImage(New Uri("/DockingDemo;component/Images/VS2010Docking/Toolbox_16x16.png", UriKind.Relative))
        End Sub

        Protected Overrides ReadOnly Property WorkspaceName() As String
            Get
                Return "Toolbox"
            End Get
        End Property
    End Class
    Public Class SolutionExplorerViewModel
        Inherits PanelWorkspaceViewModel

        Public Sub New()
            DisplayName = "Solution Explorer"
            Glyph = New BitmapImage(New Uri("/DockingDemo;component/Images/VS2010Docking/Solution Explorer.png", UriKind.Relative))
        End Sub

        Public Property Solution() As Solution
        Protected Overrides ReadOnly Property WorkspaceName() As String
            Get
                Return "RightHost"
            End Get
        End Property
    End Class
    Public Class PropertiesViewModel
        Inherits PanelWorkspaceViewModel

        Public Sub New()
            DisplayName = "Properties"
            Glyph = New BitmapImage(New Uri("/DockingDemo;component/Images/VS2010Docking/PropertiesWindow_16x16.png", UriKind.Relative))
        End Sub

        Protected Overrides ReadOnly Property WorkspaceName() As String
            Get
                Return "RightHost"
            End Get
        End Property
    End Class
    Public Class ErrorListViewModel
        Inherits PanelWorkspaceViewModel

        Public Sub New()
            DisplayName = "Error List"
            Glyph = New BitmapImage(New Uri("/DockingDemo;component/Images/VS2010Docking/TaskList_16x16.png", UriKind.Relative))
        End Sub

        Protected Overrides ReadOnly Property WorkspaceName() As String
            Get
                Return "BottomHost"
            End Get
        End Property
    End Class
    Public Class SearchResultsViewModel
        Inherits PanelWorkspaceViewModel

        Public Sub New()
            DisplayName = "Search Results"
            Glyph = New BitmapImage(New Uri("/DockingDemo;component/Images/VS2010Docking/FindInFiles_16x16.png", UriKind.Relative))
        End Sub

        Protected Overrides ReadOnly Property WorkspaceName() As String
            Get
                Return "BottomHost"
            End Get
        End Property
    End Class
    Public Class OutputViewModel
        Inherits PanelWorkspaceViewModel

        Public Sub New()
            DisplayName = "Output"
            Glyph = New BitmapImage(New Uri("/DockingDemo;component/Images/VS2010Docking/Output_16x16.png", UriKind.Relative))
        End Sub

        Protected Overrides ReadOnly Property WorkspaceName() As String
            Get
                Return "BottomHost"
            End Get
        End Property
    End Class
    Public Class DocumentViewModel
        Inherits PanelWorkspaceViewModel

        Public Sub New()
            IsClosed = False
        End Sub
        Public Sub New(ByVal displayName As String, ByVal text As String)
            Me.New()
            DisplayName = displayName
            Me.Text = text
        End Sub

        Private privateDescription As String
        Public Property Description() As String
            Get
                Return privateDescription
            End Get
            Protected Set(ByVal value As String)
                privateDescription = value
            End Set
        End Property
        Private privateFooter As String
        Public Property Footer() As String
            Get
                Return privateFooter
            End Get
            Protected Set(ByVal value As String)
                privateFooter = value
            End Set
        End Property
        Private privateText As String
        Public Property Text() As String
            Get
                Return privateText
            End Get
            Protected Set(ByVal value As String)
                privateText = value
            End Set
        End Property
        Protected Overrides ReadOnly Property WorkspaceName() As String
            Get
                Return "DocumentHost"
            End Get
        End Property

        Public Overrides Function Open() As Boolean
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*"
            openFileDialog1.FilterIndex = 1
            Dim dialogResult? As Boolean = openFileDialog1.ShowDialog()
            Dim dialogResultOK As Boolean = dialogResult.HasValue AndAlso dialogResult.Value
            If dialogResultOK Then
                DisplayName = openFileDialog1.SafeFileName
                Dim fileStream As System.IO.Stream = File.OpenRead(openFileDialog1.FileName)
                Using reader As New System.IO.StreamReader(fileStream)
                    Text = reader.ReadToEnd()
                End Using
                fileStream.Close()
            End If
            Return dialogResultOK
        End Function
    End Class
    Public Class BarModel
        Inherits ViewModel

        Private _Commands As IList(Of Object)

        Public Sub New()
            _Commands = New ObservableCollection(Of Object)()
        End Sub
        Public Sub New(ByVal displayName As String)
            Me.New()
            Me.DisplayName = displayName
        End Sub

        Public ReadOnly Property Commands() As IList(Of Object)
            Get
                Return _Commands
            End Get
        End Property
        Public Property IsMainMenu() As Boolean
    End Class
    Public Class MainWindowViewModel
        Private _commands As ReadOnlyCollection(Of CommandViewModel)
        Private _workspaces As ObservableCollection(Of WorkspaceViewModel)
        Private Const DefaultText As String = "This example demonstrates how to use the ItemsSource collection for the DockLayoutManager object in order to apply an MVVM pattern for your application. All BarManager and DockLayoutManager items are defined in the data source. They are bound via the ItemsSource property and visualized via templates. Elements are added and organized in containers according to the attached TargetName property."
        Public Sub New()
            InitDefaultLayout()
        End Sub
        Protected Overridable Sub InitDefaultLayout()
            Dim panels = New List(Of PanelWorkspaceViewModel) From {_ToolboxViewModel, _SolutionExplorerViewModel, _PropertiesViewModel, _ErrorListViewModel}
            For Each panel In panels
                OpenOrCloseWorkspace(panel)
            Next panel
            Dim doc = CreatePanelWorkspaceViewModel(Function() New DocumentViewModel("Start Page", DefaultText))
            OpenOrCloseWorkspace(doc, True)
        End Sub
        Public ReadOnly Property Commands() As ReadOnlyCollection(Of CommandViewModel)
            Get
                If _commands Is Nothing Then
                    Dim cmds As List(Of CommandViewModel) = CreateCommands()
                    _commands = New ReadOnlyCollection(Of CommandViewModel)(cmds)
                End If
                Return _commands
            End Get
        End Property
        Protected Overridable Function CreateViewCommands() As List(Of CommandViewModel)
            Dim showToolboxPanelRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnShowToolboxPanel)
            Dim showSolutionExplorerPanelRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnShowSolutionExplorerPanel)
            Dim showPropertiesPanelRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnShowPropertiesPanel)
            Dim showErrorListPanelRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnShowErrorListPanel)
            Dim showOutputPanelRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnShowOutputPanel)
            Dim showSearchResultsPanelRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnShowSearchResultsPanel)
            Dim toolbox As New CommandViewModel(_ToolboxViewModel, showToolboxPanelRelayCommand)
            Dim solutionExplorer As New CommandViewModel(_SolutionExplorerViewModel, showSolutionExplorerPanelRelayCommand)
            Dim properties As New CommandViewModel(_PropertiesViewModel, showPropertiesPanelRelayCommand)
            Dim errorList As New CommandViewModel(_ErrorListViewModel, showErrorListPanelRelayCommand)
            Dim output As New CommandViewModel(_OutputViewModel, showOutputPanelRelayCommand)
            Dim searchResults As New CommandViewModel(_SearchResultsViewModel, showSearchResultsPanelRelayCommand)
            Return New List(Of CommandViewModel)() From {toolbox, solutionExplorer, properties, errorList, output, searchResults}
        End Function
        Protected Overridable Function CreateFileCommands() As List(Of CommandViewModel)
            Dim openDocumentRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnOpenDocument)
            Dim openDocument As New CommandViewModel("Open...", openDocumentRelayCommand) With {.Glyph = GlyphHelper.GetGlyph("/Images/Open_16x16.png"), .IsEnabled = True}
            Return New List(Of CommandViewModel)() From {openDocument}
        End Function
        Private Function CreateCommands() As List(Of CommandViewModel)
            Dim fileCommands As List(Of CommandViewModel) = CreateFileCommands()
            Dim viewCommands As List(Of CommandViewModel) = CreateViewCommands()
            Dim file = New CommandViewModel("File", fileCommands)
            Dim view = New CommandViewModel("View", viewCommands)
            Return New List(Of CommandViewModel) From {file, view}
        End Function
        Private _bars As ReadOnlyCollection(Of BarModel)
        Public ReadOnly Property Bars() As ReadOnlyCollection(Of BarModel)
            Get
                If _bars Is Nothing Then
                    Dim cmds As List(Of BarModel) = CreateBars()
                    _bars = New ReadOnlyCollection(Of BarModel)(cmds)
                End If
                Return _bars
            End Get
        End Property
        Protected Overridable Function CreateBars() As List(Of BarModel)
            Dim model As New BarModel("Main") With {.IsMainMenu = True}

            Dim commands_Renamed = CreateCommands()
            For Each cmd In commands_Renamed
                model.Commands.Add(cmd)
            Next cmd
            Return New List(Of BarModel)() From {model}
        End Function

        Public ReadOnly Property Workspaces() As ObservableCollection(Of WorkspaceViewModel)
            Get
                If _workspaces Is Nothing Then
                    _workspaces = New ObservableCollection(Of WorkspaceViewModel)()
                    AddHandler _workspaces.CollectionChanged, AddressOf OnWorkspacesChanged
                End If
                Return _workspaces
            End Get
        End Property

        Private Sub OnWorkspacesChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
            If e.NewItems IsNot Nothing AndAlso e.NewItems.Count <> 0 Then
                For Each workspace As WorkspaceViewModel In e.NewItems
                    AddHandler workspace.RequestClose, AddressOf OnWorkspaceRequestClose
                Next workspace
            End If

            If e.OldItems IsNot Nothing AndAlso e.OldItems.Count <> 0 Then
                For Each workspace As WorkspaceViewModel In e.OldItems
                    RemoveHandler workspace.RequestClose, AddressOf OnWorkspaceRequestClose
                Next workspace
            End If
        End Sub

        Private Sub OnWorkspaceRequestClose(ByVal sender As Object, ByVal e As EventArgs)
            Dim workspace As WorkspaceViewModel = TryCast(sender, WorkspaceViewModel)
            If TypeOf workspace Is PanelWorkspaceViewModel Then
                CType(workspace, PanelWorkspaceViewModel).IsClosed = True
                If TypeOf workspace Is DocumentViewModel Then
                    workspace.Dispose()
                    Workspaces.Remove(workspace)
                End If
            End If
        End Sub
        Protected Overridable Sub InitPanelWorkspaceViewModel(ByVal viewModel As PanelWorkspaceViewModel)
        End Sub
        Protected Function CreatePanelWorkspaceViewModel(Of T As PanelWorkspaceViewModel)() As T
            Dim viewModel As T = ViewModelSource(Of T).Create()
            InitPanelWorkspaceViewModel(viewModel)
            Return viewModel
        End Function
        Protected Function CreatePanelWorkspaceViewModel(Of T As PanelWorkspaceViewModel)(ByVal constructorExpression As System.Linq.Expressions.Expression(Of Func(Of T))) As T
            Return ViewModelSource.Create(constructorExpression)
        End Function
        Private toolBoxViewModel As ToolboxViewModel
        Public ReadOnly Property _ToolboxViewModel() As ToolboxViewModel
            Get
                If toolBoxViewModel Is Nothing Then
                    toolBoxViewModel = CreatePanelWorkspaceViewModel(Of ToolboxViewModel)()
                End If
                Return toolBoxViewModel
            End Get
        End Property
        Private solutionExplorerViewModel As SolutionExplorerViewModel
        Public ReadOnly Property _SolutionExplorerViewModel() As SolutionExplorerViewModel
            Get
                If solutionExplorerViewModel Is Nothing Then
                    solutionExplorerViewModel = CreatePanelWorkspaceViewModel(Of SolutionExplorerViewModel)()
                    solutionExplorerViewModel.Solution = Solution
                End If
                Return solutionExplorerViewModel
            End Get
        End Property

        Private solution_Renamed As Solution
        Private ReadOnly Property Solution() As Solution
            Get
                If solution_Renamed Is Nothing Then
                    solution_Renamed = DockingDemo.ViewModels.Solution.Create()
                    AddHandler solution_Renamed.PropertyChanged, AddressOf OnSolutionPropertyChanged
                End If
                Return solution_Renamed
            End Get
        End Property
        Private Sub OnSolutionPropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
            If e.PropertyName = "PreviewItem" Then
                OnPreviewItemChanged()
            End If
        End Sub
        Protected Overridable Sub OnPreviewItemChanged()
        End Sub
        Private propertiesViewModel As PropertiesViewModel
        Public ReadOnly Property _PropertiesViewModel() As PropertiesViewModel
            Get
                If propertiesViewModel Is Nothing Then
                    propertiesViewModel = CreatePanelWorkspaceViewModel(Of PropertiesViewModel)()
                End If
                Return propertiesViewModel
            End Get
        End Property
        Private errorListViewModel As ErrorListViewModel
        Public ReadOnly Property _ErrorListViewModel() As ErrorListViewModel
            Get
                If errorListViewModel Is Nothing Then
                    errorListViewModel = CreatePanelWorkspaceViewModel(Of ErrorListViewModel)()
                End If
                Return errorListViewModel
            End Get
        End Property
        Private outputViewModel As OutputViewModel
        Public ReadOnly Property _OutputViewModel() As OutputViewModel
            Get
                If outputViewModel Is Nothing Then
                    outputViewModel = CreatePanelWorkspaceViewModel(Of OutputViewModel)()
                End If
                Return outputViewModel
            End Get
        End Property
        Private searchResultsViewModel As SearchResultsViewModel
        Public ReadOnly Property _SearchResultsViewModel() As SearchResultsViewModel
            Get
                If searchResultsViewModel Is Nothing Then
                    searchResultsViewModel = CreatePanelWorkspaceViewModel(Of SearchResultsViewModel)()
                End If
                Return searchResultsViewModel
            End Get
        End Property
        Protected Sub OpenOrCloseWorkspace(ByVal workspace As PanelWorkspaceViewModel, ByVal activateOnOpen As Boolean)
            If Workspaces.Contains(workspace) Then
                workspace.IsClosed = Not workspace.IsClosed
            Else
                Workspaces.Add(workspace)
                workspace.IsClosed = False
                If activateOnOpen Then
                    SetActiveWorkspace(workspace)
                End If
            End If
        End Sub
        Protected Sub OpenOrCloseWorkspace(ByVal workspace As PanelWorkspaceViewModel)
            OpenOrCloseWorkspace(workspace, False)
        End Sub
        Private Sub OnShowToolboxPanel(ByVal param As Object)
            OpenOrCloseWorkspace(_ToolboxViewModel)
        End Sub
        Private Sub OnShowSolutionExplorerPanel(ByVal param As Object)
            OpenOrCloseWorkspace(_SolutionExplorerViewModel)
        End Sub
        Private Sub OnShowPropertiesPanel(ByVal param As Object)
            OpenOrCloseWorkspace(_PropertiesViewModel)
        End Sub
        Private Sub OnShowErrorListPanel(ByVal param As Object)
            OpenOrCloseWorkspace(_ErrorListViewModel)
        End Sub
        Private Sub OnShowOutputPanel(ByVal param As Object)
            OpenOrCloseWorkspace(_OutputViewModel)
        End Sub
        Private Sub OnShowSearchResultsPanel(ByVal param As Object)
            OpenOrCloseWorkspace(_SearchResultsViewModel)
        End Sub
        Protected Overridable Function CreateDocumentViewModel() As PanelWorkspaceViewModel
            Return CreatePanelWorkspaceViewModel(Of DocumentViewModel)()
        End Function
        Private Sub OnOpenDocument(ByVal param As Object)
            Dim workspace = CreateDocumentViewModel()
            If Not workspace.Open() Then
                Return
            End If
            OpenOrCloseWorkspace(workspace, True)
        End Sub

        Private Sub SetActiveWorkspace(ByVal workspace As WorkspaceViewModel)
            Debug.Assert(Workspaces.Contains(workspace))
            workspace.IsActive = True
        End Sub
        Protected NotInheritable Class GlyphHelper

            Private Sub New()
            End Sub

            Public Shared Function GetGlyph(ByVal path As String) As BitmapImage
                Return New BitmapImage(DevExpress.Utils.AssemblyHelper.GetResourceUri(GetType(GlyphHelper).Assembly, path))
            End Function
        End Class
    End Class
    Public Class SolutionItem
        Private ReadOnly solution As Solution


        Protected Sub New(ByVal solution_Renamed As Solution)
            Me.solution = solution_Renamed
        End Sub

        Private privateDisplayName As String
        Public Property DisplayName() As String
            Get
                Return privateDisplayName
            End Get
            Private Set(ByVal value As String)
                privateDisplayName = value
            End Set
        End Property
        Private privateGlyphPath As String
        Public Property GlyphPath() As String
            Get
                Return privateGlyphPath
            End Get
            Private Set(ByVal value As String)
                privateGlyphPath = value
            End Set
        End Property
        <BindableProperty(OnPropertyChangedMethodName := "OnIsSelectedChanged")>
        Public Overridable Property IsSelected() As Boolean
        Public ReadOnly Property Items() As List(Of SolutionItem)
            Get
                Return items_Renamed
            End Get
        End Property


        Public Shared Function Create(ByVal solution_Renamed As Solution, ByVal displayName As String, ByVal glyph As String) As SolutionItem

            Dim solutionItem_Renamed = ViewModelSource.Create(Function() New SolutionItem(solution_Renamed))
            solutionItem_Renamed.Do(Sub(x)
                x.DisplayName = displayName
                x.GlyphPath = glyph
            End Sub)
            Return solutionItem_Renamed
        End Function
        Protected Sub OnIsSelectedChanged()
            If IsSelected Then
                solution.PreviewItem = Me
            End If
        End Sub

        Private items_Renamed As New List(Of SolutionItem)()
    End Class
    Public Class Solution
        Inherits DevExpress.Mvvm.BindableBase

        Protected Sub New()
            Dim root As SolutionItem = SolutionItem.Create(Me, "WPFApplication", "/DockingDemo;component/Images/VS2010Docking/Solution Explorer.png")
            Dim properties As SolutionItem = SolutionItem.Create(Me, "Properties", "/DockingDemo;component/Images/VS2010Docking/ReferencesClosed_16x16.png")
            Dim references As SolutionItem = SolutionItem.Create(Me, "References", "/DockingDemo;component/Images/VS2010Docking/ReferencesOpened_16x16.png")
            Dim file1 As SolutionItem = SolutionItem.Create(Me, "File1.cs", "/DockingDemo;component/Images/VS2010Docking/FileCS_16x16.png")
            Dim file2 As SolutionItem = SolutionItem.Create(Me, "File2.cs", "/DockingDemo;component/Images/VS2010Docking/FileCS_16x16.png")
            Dim file3 As SolutionItem = SolutionItem.Create(Me, "Program.cs", "/DockingDemo;component/Images/VS2010Docking/FileCS_16x16.png")

            root.Items.AddRange(New SolutionItem() { properties, references, file1, file2, file3 })
            Items.Add(root)
        End Sub

        Public ReadOnly Property Items() As List(Of SolutionItem)
            Get
                Return items_Renamed
            End Get
        End Property
        Public Overridable Property PreviewItem() As SolutionItem

        Public Shared Function Create() As Solution
            Return ViewModelSource.Create(Function() New Solution())
        End Function

        Private items_Renamed As New List(Of SolutionItem)()
    End Class
End Namespace
