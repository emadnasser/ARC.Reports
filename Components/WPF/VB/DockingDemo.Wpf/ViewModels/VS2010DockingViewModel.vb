Imports DevExpress.DemoData.Utils
Imports DevExpress.Mvvm.Native
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Xpf.DemoBase.Helpers.TextColorizer
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Input
Imports System.Windows.Media.Imaging

Namespace DockingDemo.ViewModels
    Public Class VS2010DocumentViewModel
        Inherits DocumentViewModel

        Private privateCodeLanguageText As CodeLanguageText
        Public Property CodeLanguageText() As CodeLanguageText
            Get
                Return privateCodeLanguageText
            End Get
            Private Set(ByVal value As CodeLanguageText)
                privateCodeLanguageText = value
            End Set
        End Property
        Private privateCodeLanguage As CodeLanguage
        Public Property CodeLanguage() As CodeLanguage
            Get
                Return privateCodeLanguage
            End Get
            Private Set(ByVal value As CodeLanguage)
                privateCodeLanguage = value
            End Set
        End Property
        Protected Overrides ReadOnly Property WorkspaceName() As String
            Get
                Return "DocumentHost"
            End Get
        End Property
        Private Shared count As Integer = 0
        Public Overrides Function Open() As Boolean
            CodeLanguage = If(count Mod 2 = 0, CodeLanguage.XAML, CodeLanguage.CS)
            count += 1
            DisplayName = String.Format("File{0}.{1}", count, CodeLanguage.ToString().ToLower())
            Glyph = New BitmapImage(New Uri("/DockingDemo;component/Images/VS2010Docking/FileCS_16x16.png", UriKind.Relative))
            Description = If(Object.Equals(CodeLanguage, CodeLanguage.XAML), "Windows Markup File", "Visual C# Source file")
            Footer = String.Format("c:\...\DockingDemo\{0}", DisplayName)
            Dim filename As String = "VS2010Docking." & CodeLanguage.ToString().ToLower()
            CodeLanguageText = New CodeLanguageText(CodeLanguage, Function() GetCodeText(filename))
            Return True
        End Function
        Private Function GetCodeText(ByVal name As String) As String
            Dim assembly As System.Reflection.Assembly = GetType(VS2010DocumentViewModel).Assembly
            Using stream As Stream = AssemblyHelper.GetEmbeddedResourceStream(assembly, DemoHelper.GetPath("Data/", assembly) & name, True)
                If stream Is Nothing Then
                    Return String.Empty
                End If
                Using reader As New StreamReader(stream)
                    Return reader.ReadToEnd()
                End Using
            End Using
        End Function
    End Class
    Public Class VS2010MainWindowViewModel
        Inherits MainWindowViewModel

        Protected Overrides Sub InitDefaultLayout()
            Dim panels = New List(Of PanelWorkspaceViewModel) From {_ToolboxViewModel, _SolutionExplorerViewModel, _PropertiesViewModel, _ErrorListViewModel}
            For Each panel In panels
                OpenOrCloseWorkspace(panel)
            Next panel
            Dim document As PanelWorkspaceViewModel = CreateDocumentViewModel()
            document.Open()
            OpenOrCloseWorkspace(document, True)
        End Sub
        Protected Overrides Function CreateDocumentViewModel() As PanelWorkspaceViewModel
            Return CreatePanelWorkspaceViewModel(Of VS2010DocumentViewModel)()
        End Function
        Protected Overrides Sub InitPanelWorkspaceViewModel(ByVal viewModel As PanelWorkspaceViewModel)
            MyBase.InitPanelWorkspaceViewModel(viewModel)
            viewModel.ShowPinButton = True
        End Sub
        Private previewItem As PanelWorkspaceViewModel
        Protected Overrides Sub OnPreviewItemChanged()
            If previewItem IsNot Nothing Then
                If previewItem.IsPreview Then
                    previewItem.IsPreview = False
                    previewItem.IsClosed = True
                End If
            End If
            previewItem = CreateDocumentViewModel()
            previewItem.Open()
            previewItem.ShowPinButton = True
            previewItem.Pinned = True
            OpenOrCloseWorkspace(previewItem, True)
            previewItem.IsPreview = True
        End Sub
        Protected Overrides Function CreateFileCommands() As List(Of CommandViewModel)
            Dim projectRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnNewFileExecuted)
            Dim fileRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnNewFileExecuted)
            Dim fileOpenRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnNewFileExecuted)
            Dim closeFileRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnCloseFileExecuted)

            Dim newCommand As New CommandViewModel("New") With {.IsSubItem = True}
            Dim newProject As New CommandViewModel("Project...", projectRelayCommand) With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/NewProject_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.N, ModifierKeys.Control Or ModifierKeys.Shift)}
            Dim newFile As New CommandViewModel("File...", fileRelayCommand) With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/File_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.N, ModifierKeys.Control)}
            newCommand.Commands = New List(Of CommandViewModel)() From {newProject, newFile}

            Dim openCommand As New CommandViewModel("Open") With {.IsSubItem = True}
            Dim openProject As New CommandViewModel("Project/Solution...") With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/OpenSolution_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.O, ModifierKeys.Control Or ModifierKeys.Shift), .IsEnabled = False}
            Dim openFile As New CommandViewModel("File...", fileOpenRelayCommand) With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/OpenFile_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.O, ModifierKeys.Control)}
            openCommand.Commands = New List(Of CommandViewModel)() From {openProject, openFile}

            Dim closeFile As New CommandViewModel("Close", closeFileRelayCommand)
            Dim closeSolution As New CommandViewModel("Close Solution") With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/CloseSolution_16x16.png")}
            Dim save As New CommandViewModel("Save") With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/Save_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.S, ModifierKeys.Control)}
            Dim saveAll As New CommandViewModel("Save All") With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/SaveAll_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.S, ModifierKeys.Control Or ModifierKeys.Shift)}

            Dim recentFilesCommand As New CommandViewModel("Recent files") With {.IsSubItem = True}
            Dim recentProjectsCommand As New CommandViewModel("Recent projects and solutions") With {.IsSubItem = True}

            Return New List(Of CommandViewModel)() From {newCommand, openCommand, GetSeparator(), closeFile, closeSolution, GetSeparator(), save, saveAll, GetSeparator(), recentFilesCommand, recentProjectsCommand}
        End Function
        Private Function GetSeparator() As CommandViewModel
            Return New CommandViewModel() With {.IsSeparator = True}
        End Function
        Protected Overrides Function CreateBars() As List(Of BarModel)

            Dim bars_Renamed As List(Of BarModel) = MyBase.CreateBars()
            Dim model As New BarModel("Standard")

            Dim commands_Renamed = CreateToolbarCommands()
            For Each cmd In commands_Renamed
                model.Commands.Add(cmd)
            Next cmd
            bars_Renamed.Add(model)
            Return bars_Renamed
        End Function
        Private Function CreateToolbarCommands() As List(Of CommandViewModel)
            Dim newProjectRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnNewFileExecuted)
            Dim addNewItemRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnNewFileExecuted)
            Dim openRelayCommand = DelegateCommandFactory.Create(Of Object)(AddressOf OnNewFileExecuted)

            Dim newProject As New CommandViewModel("New Project", newProjectRelayCommand) With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/NewProject_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.N, ModifierKeys.Control Or ModifierKeys.Shift)}
            Dim newFile As New CommandViewModel("Add New Item", addNewItemRelayCommand) With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/File_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.N, ModifierKeys.Control)}
            Dim openFile As New CommandViewModel("Open File", openRelayCommand) With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/OpenFile_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.O, ModifierKeys.Control)}

            Dim save As New CommandViewModel("Save") With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/Save_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.S, ModifierKeys.Control)}
            Dim saveAll As New CommandViewModel("Save All") With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/SaveAll_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.S, ModifierKeys.Control Or ModifierKeys.Shift)}

            Dim cut As New CommandViewModel("Cut") With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/Cut_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.S, ModifierKeys.Control Or ModifierKeys.Shift)}
            Dim copy As New CommandViewModel("Copy") With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/Copy_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.S, ModifierKeys.Control Or ModifierKeys.Shift)}
            Dim paste As New CommandViewModel("Paste") With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/Paste_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.S, ModifierKeys.Control Or ModifierKeys.Shift)}

            Dim undo As New CommandViewModel("Undo") With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/Undo_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.S, ModifierKeys.Control Or ModifierKeys.Shift)}
            Dim redo As New CommandViewModel("Redo") With {.Glyph = GlyphHelper.GetGlyph("/Images/VS2010Docking/Redo_16x16.png"), .KeyGesture = KeyGestureHelper.GetKeyGesture(Key.S, ModifierKeys.Control Or ModifierKeys.Shift)}

            Return New List(Of CommandViewModel)() From {newProject, newFile, openFile, save, saveAll, GetSeparator(), cut, copy, paste, GetSeparator(), undo, redo}
        End Function
        Private Sub OnNewFileExecuted(ByVal param As Object)
            Dim document = CreateDocumentViewModel()
            document.Open()
            OpenOrCloseWorkspace(document, True)
        End Sub
        Private Sub OnCloseFileExecuted(ByVal param As Object)
        End Sub
        Private NotInheritable Class KeyGestureHelper

            Private Sub New()
            End Sub

            Public Shared Function GetKeyGesture(ByVal key As Key, ByVal modifiers As ModifierKeys) As KeyGesture
                Dim k As New KeyGesture(key, modifiers)
                Dim s As String = k.GetDisplayStringForCulture(System.Globalization.CultureInfo.InvariantCulture)
                Return New KeyGesture(key, modifiers)
            End Function
        End Class
    End Class
End Namespace
