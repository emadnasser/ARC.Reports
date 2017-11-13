Imports System
Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Reflection
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Threading
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Docking
Imports DevExpress.Xpf.Docking.Base
Imports DevExpress.Xpf.Editors.Settings
Imports DevExpress.Xpf.NavBar

Namespace DockingDemo
    Partial Public Class MDIQuickNotes
        Inherits DockingDemoModule

        Private ReadOnly UnavailableEdit As RichTextBox
        Public Sub New()
            DockLayoutManagerParameters.LayoutControlItemCaptionFormat = "{0}"
            InitializeComponent()
            UnavailableEdit = New RichTextBox With {.IsEnabled = False, .Visibility = Visibility.Collapsed}
            AllNotes = DefaultBook.GetNotes()
            DataContext = AllNotes
            AddHandler Loaded, AddressOf MDIQuickNotes_Loaded
            AddHandler Unloaded, AddressOf MDIQuickNotes_UnLoaded
            AddHandler dockManager.LayoutItemActivating, AddressOf dockManager_LayoutItemActivating
            AddHandler dockManager.DockItemActivating, AddressOf dockManager_DockItemActivating
            AddHandler dockManager.DockItemClosed, AddressOf dockManager_DockItemClosed
        End Sub
        Private Sub bHome_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            NavigateHomePage()
        End Sub
        Private Sub MDIQuickNotes_UnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RemoveHandler Unloaded, AddressOf MDIQuickNotes_UnLoaded
            CType(eFontSize.EditSettings, ComboBoxEditSettings).ItemsSource = Nothing
            CType(eFontFamily.EditSettings, ComboBoxEditSettings).ItemsSource = Nothing
        End Sub

        Private modified_Renamed As Boolean
        Protected Property Modified() As Boolean
            Get
                Return modified_Renamed
            End Get
            Set(ByVal value As Boolean)
                If Modified = value Then
                    Return
                End If
                modified_Renamed = value
                OnModifiedChanged()
            End Set
        End Property
        Private Sub OnModifiedChanged()
            If Modified Then
                bModified.Content = "Modified"
            Else
                bModified.Content = ""
            End If
        End Sub
        Private Sub bAbout_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ShowAbout()
        End Sub
        Private Sub bExit_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub
        Private Sub bUndo_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            GetEdit().Undo()
        End Sub
        Private Sub bRedo_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            GetEdit().Redo()
        End Sub
        Private Sub bCut_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            GetEdit().Cut()
        End Sub
        Private Sub bCopy_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            GetEdit().Copy()
        End Sub
        Private Sub bPaste_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            GetEdit().Paste()
        End Sub
        Private Sub bClear_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            GetEdit().Document.Blocks.Clear()
        End Sub
        Private Sub bSelectAll_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            GetEdit().SelectAll()
        End Sub
        Private Sub bFind_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub
        Private Sub bReplace_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub
        Private Sub bNew_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub
        Private Sub bOpen_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub
        Private Sub bClose_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub
        Private Sub bSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub
        Private Sub bSaveAs_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub
        Private Sub bPrint_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub
        Private isInvokePending As Boolean
        Private Sub InvokeUpdateFormat()
            If Not isInvokePending Then
                Dispatcher.BeginInvoke(DispatcherPriority.Background, New Action(AddressOf UpdateFormat))
                isInvokePending = True
            End If
            UpdateFormat()
        End Sub
        Protected Sub UpdateFormat()
            Dim value As Object
            Dim edit As RichTextBox = GetEdit()
            value = edit.Selection.GetPropertyValue(TextElement.FontFamilyProperty)
            eFontFamily.EditValue = If(value Is DependencyProperty.UnsetValue, Nothing, value)

            value = edit.Selection.GetPropertyValue(TextElement.FontSizeProperty)
            eFontSize.EditValue = If(value Is DependencyProperty.UnsetValue, Nothing, value)

            value = edit.Selection.GetPropertyValue(TextElement.ForegroundProperty)
            fontColorChooser.Color = If(value Is DependencyProperty.UnsetValue, Colors.Black, DirectCast(value, SolidColorBrush).Color)

            value = edit.Selection.GetPropertyValue(TextElement.FontWeightProperty)
            bBold.IsChecked = (value IsNot DependencyProperty.UnsetValue) AndAlso (DirectCast(value, FontWeight) = FontWeights.Bold)

            value = edit.Selection.GetPropertyValue(TextElement.FontStyleProperty)
            bItalic.IsChecked = (value IsNot DependencyProperty.UnsetValue) AndAlso (DirectCast(value, FontStyle) = FontStyles.Italic)

            value = edit.Selection.GetPropertyValue(Inline.TextDecorationsProperty)
            bUnderline.IsChecked = (value IsNot DependencyProperty.UnsetValue) AndAlso (value IsNot Nothing AndAlso System.Windows.TextDecorations.Underline.Equals(value))

            value = edit.Selection.GetPropertyValue(Paragraph.TextAlignmentProperty)
            bLeft.IsChecked = (value Is DependencyProperty.UnsetValue) OrElse DirectCast(value, TextAlignment) = TextAlignment.Left
            bCenter.IsChecked = (value IsNot DependencyProperty.UnsetValue) AndAlso DirectCast(value, TextAlignment) = TextAlignment.Center
            bRight.IsChecked = (value IsNot DependencyProperty.UnsetValue) AndAlso DirectCast(value, TextAlignment) = TextAlignment.Right

            Dim startParagraph As Paragraph = edit.Selection.Start.Paragraph
            Dim endParagraph As Paragraph = edit.Selection.End.Paragraph
            If startParagraph IsNot Nothing AndAlso endParagraph IsNot Nothing AndAlso (TypeOf startParagraph.Parent Is ListItem) AndAlso (TypeOf endParagraph.Parent Is ListItem) AndAlso Object.ReferenceEquals(CType(startParagraph.Parent, ListItem).List, CType(endParagraph.Parent, ListItem).List) Then
                Dim markerStyle As TextMarkerStyle = CType(startParagraph.Parent, ListItem).List.MarkerStyle
                bBullets.IsChecked = (markerStyle = TextMarkerStyle.Disc OrElse markerStyle = TextMarkerStyle.Circle OrElse markerStyle = TextMarkerStyle.Square OrElse markerStyle = TextMarkerStyle.Box)
            Else
                bBullets.IsChecked = False
            End If
            isInvokePending = False
        End Sub
        Private Sub fontColorChooser_ColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            If isInvokePending Then
                Return
            End If
            GetEdit().Selection.ApplyPropertyValue(TextElement.ForegroundProperty, New SolidColorBrush(fontColorChooser.Color))
            InvokeUpdateFormat()
            InvokeFocusEdit()
        End Sub
        Private Sub eFontSize_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If eFontSize.EditValue Is Nothing OrElse isInvokePending Then
                Return
            End If
            GetEdit().Selection.ApplyPropertyValue(TextElement.FontSizeProperty, eFontSize.EditValue)
            InvokeUpdateFormat()
            InvokeFocusEdit()
        End Sub
        Private Sub eFontFamily_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If eFontFamily.EditValue Is Nothing OrElse isInvokePending Then
                Return
            End If
            GetEdit().Selection.ApplyPropertyValue(TextElement.FontFamilyProperty, eFontFamily.EditValue.ToString())
            InvokeUpdateFormat()
            InvokeFocusEdit()
        End Sub
        Private Sub InvokeFocusEdit()
            Dim edit As RichTextBox = GetEdit()
            Dispatcher.BeginInvoke(DispatcherPriority.Background, New Action(Sub() edit.Focus()))
        End Sub
        Private Function GetEdit() As RichTextBox
            Dim panel As DocumentPanel = TryCast(notesContainer.SelectedItem, DocumentPanel)
            If panel IsNot Nothing AndAlso panel.Layout IsNot Nothing Then
                Dim group As LayoutGroup = TryCast(panel.Layout(0), LayoutGroup)
                If group IsNot Nothing Then
                    Dim item As LayoutControlItem = TryCast(group.SelectedItem, LayoutControlItem)
                    If item Is Nothing Then
                        item = TryCast(group(0), LayoutControlItem)
                    End If
                    If item IsNot Nothing Then
                        Return If((TryCast(item.Control, RichTextBox)), UnavailableEdit)
                    End If
                End If
            End If
            Return UnavailableEdit
        End Function
        Private Sub dockManager_DockItemClosed(ByVal sender As Object, ByVal e As DockItemClosedEventArgs)
            Dim document As DocumentPanel = TryCast(e.Item, DocumentPanel)
            If document IsNot Nothing Then

                Dim note_Renamed As Note = DockingDemo.Note.GetNote(document)
                If note_Renamed IsNot Nothing AndAlso AllNotes.Remove(note_Renamed) Then
                    dockManager.DockController.RemovePanel(document)
                    DockingDemo.Note.SetNote(document, Nothing)
                End If
            End If
        End Sub
        Private Sub dockManager_LayoutItemActivating(ByVal sender As Object, ByVal e As ItemCancelEventArgs)
            If e.Item.Name = "newNotePage" Then
                Dim item As LayoutControlItem = CreateNewNotePage(e.Item.Parent)
                e.Cancel = item IsNot Nothing
                If item IsNot Nothing Then
                    Dim activate As New ActivateDelegate(AddressOf ActivateLayoutItem)
                    Dispatcher.BeginInvoke(activate, New Object() { item })
                End If
            End If
        End Sub
        Private Sub dockManager_DockItemActivating(ByVal sender As Object, ByVal e As ItemCancelEventArgs)
            If e.Item.Name = "newNote" Then
                Dim panel As DocumentPanel = CreateNewNote()
                e.Cancel = panel IsNot Nothing
                If panel IsNot Nothing Then
                    Dim activate As New ActivateDelegate(AddressOf ActivateDockItem)
                    Dispatcher.BeginInvoke(activate, New Object() { panel })
                End If
            End If
        End Sub
        Private Delegate Sub ActivateDelegate(ByVal item As BaseLayoutItem)
        Private Sub ActivateDockItem(ByVal panel As BaseLayoutItem)
            dockManager.DockController.Activate(panel)
        End Sub
        Private Sub ActivateLayoutItem(ByVal item As BaseLayoutItem)
            dockManager.LayoutController.Activate(item)
        End Sub
        Private Function CreateNewNote() As DocumentPanel

            Dim note_Renamed As New Note() With {.Caption = "Untitled", .Book = ActiveBook}
            Dim page As New NotePage() With {.Caption = "Untitled"}
            note_Renamed.Pages.Add(page)
            Dim notePanel As DocumentPanel = CreateNoteDocument(note_Renamed)
            Dim result As Boolean = dockManager.DockController.Insert(notesContainer, notePanel, notesContainer.Items.Count - 1)
            If result Then
                AllNotes.Add(note_Renamed)
            End If
            Return If(result, notePanel, Nothing)
        End Function
        Private Function CreateNewNotePage(ByVal group As LayoutGroup) As LayoutControlItem
            Dim page As New NotePage() With {.Caption = "Untitled"}
            ActiveNote.Pages.Add(page)
            Dim notePage As LayoutControlItem = CreateNotePage(page)
            Dim result As Boolean = dockManager.DockController.Insert(group, notePage, group.Items.Count - 1)
            Return If(result, notePage, Nothing)
        End Function
        Private Sub MDIQuickNotes_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RemoveHandler Loaded, AddressOf MDIQuickNotes_Loaded
            noteBooksNavBar.ItemsSource = AllNotes
            AddHandler noteBooksNavBar.Loaded, AddressOf noteBooksNavBar_Loaded
        End Sub
        Private Sub noteBooksNavBar_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RemoveHandler noteBooksNavBar.Loaded, AddressOf noteBooksNavBar_Loaded
            noteBooksNavBar.View.SelectItem(CType(noteBooksNavBar.Groups(0).Items(0), NavBarItem))
            CType(eFontSize.EditSettings, ComboBoxEditSettings).ItemsSource = FontSizes.Items
            CType(eFontFamily.EditSettings, ComboBoxEditSettings).ItemsSource = FontFamilies.FontNames
            UpdateFormat()
        End Sub
        Protected Overridable Sub OnEditTextChanged(ByVal sender As Object, ByVal e As TextChangedEventArgs)
            Modified = True
        End Sub
        Protected Overridable Sub OnEditSelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateStatus()
        End Sub
        Protected Overridable Sub OnEditLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateStatus()
        End Sub
        Private Sub UpdateStatus()
            Dim line As Integer = Nothing
            Dim edit As RichTextBox = GetEdit()
            edit.CaretPosition.GetLineStartPosition(-100000, line)
            Dim col As Integer = edit.CaretPosition.GetOffsetToPosition(edit.CaretPosition.GetLineStartPosition(0))
            bPosInfo.Content = "Line: " & -line & "  Position: " & -col
            InvokeUpdateFormat()
        End Sub
        Public Property AllNotes() As ObservableCollection(Of Note)
        Private activeBookCore As String
        Protected Property ActiveBook() As String
            Get
                Return activeBookCore
            End Get
            Set(ByVal value As String)
                If activeBookCore = value Then
                    Return
                End If
                activeBookCore = value
                OnActiveBookChanged(value)
            End Set
        End Property
        Private activeNoteCore As Note
        Protected Property ActiveNote() As Note
            Get
                Return activeNoteCore
            End Get
            Set(ByVal value As Note)
                If activeNoteCore Is value Then
                    Return
                End If
                activeNoteCore = value
                OnActiveNoteChanged(value)
            End Set
        End Property
        Private Sub OnActiveBookChanged(ByVal book As String)
            ClearNotes()

            For Each note_Renamed As Note In AllNotes
                If note_Renamed.Book <> book Then
                    Continue For
                End If
                dockManager.DockController.Insert(notesContainer, CreateNoteDocument(note_Renamed), notesContainer.Items.Count - 1)
            Next note_Renamed
        End Sub
        Private Sub ClearNotes()
            Dim notes() As BaseLayoutItem = notesContainer.GetItems()
            For Each panel As DocumentPanel In notes
                If panel.Name = "newNote" Then
                    Continue For
                End If
                notesContainer.Remove(panel)
            Next panel
        End Sub

        Private Function CreateNoteDocument(ByVal note_Renamed As Note) As DocumentPanel
            Dim tabs As LayoutGroup = New LayoutGroup With {.Caption = "Pages", .ShowCaption = True, .GroupBorderStyle = GroupBorderStyle.Tabbed, .CaptionLocation = CaptionLocation.Bottom}
            tabs.AddRange(CreateNotePages(note_Renamed))
            tabs.Add(CreateNewItemPage())
            Dim group As New LayoutGroup()
            group.Add(tabs)

            Dim document As DocumentPanel = New DocumentPanel With {.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled, .VerticalScrollBarVisibility = ScrollBarVisibility.Disabled, .AllowFloat = False, .AllowMove = False, .Name = note_Renamed.Caption, .Caption = note_Renamed.Caption, .Content = group, .TabBackgroundColor = Helpers.ColorPalette.GetColor((New Random(Date.Now.Millisecond)).Next())}
            DockingDemo.Note.SetNote(document, note_Renamed)

            Return document
        End Function
        Private Function CreateNewItemPage() As LayoutControlItem
            Dim item As LayoutControlItem = New LayoutControlItem With {.Name = "newNotePage", .CaptionImage = DefaultBook.NewNoteImage, .ShowCaption = False, .ShowControl = False, .Margin = New Thickness(0, -1, 0, 1), .ToolTip = "Create a new page"}
            Return item
        End Function

        Private Function CreateNotePages(ByVal note_Renamed As Note) As BaseLayoutItem()
            Dim items(note_Renamed.Pages.Count - 1) As BaseLayoutItem
            For i As Integer = 0 To items.Length - 1
                items(i) = CreateNotePage(note_Renamed.Pages(i))
            Next i
            Return items
        End Function
        Private Function CreateNotePage(ByVal page As NotePage) As LayoutControlItem
            Dim rtb As New NoteRichTextBox()
            LoadRtf(page, New TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd))
            AddHandler rtb.Loaded, AddressOf OnEditLoaded
            AddHandler rtb.TextChanged, AddressOf OnEditTextChanged
            AddHandler rtb.SelectionChanged, AddressOf OnEditSelectionChanged

            Dim pageRenameButton As Button = New Button With {.Template = TryCast(FindResource("renameButton"), ControlTemplate), .ToolTip = "Rename page"}
            AddHandler pageRenameButton.Click, AddressOf RenamePageClick

            Dim pageCloseButton As Button = New Button With {.Template = TryCast(FindResource("deleteButton"), ControlTemplate), .ToolTip = "Delete page"}
            AddHandler pageCloseButton.Click, AddressOf ClosePageClick

            Dim panel As StackPanel = New StackPanel With {.Orientation = Orientation.Horizontal, .Margin = New Thickness(0, -1, 0, 1), .VerticalAlignment = VerticalAlignment.Bottom}
            panel.Children.Add(pageRenameButton)
            panel.Children.Add(pageCloseButton)

            Dim result As LayoutControlItem = New LayoutControlItem With {.Caption = page.Caption, .CaptionImage = page.CaptionImage, .CaptionImageLocation = ImageLocation.AfterText, .ShowCaption = False, .ControlBoxContent = panel, .Content = rtb}
            Return result
        End Function
        Private Sub RenamePageClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim item As LayoutControlItem = TryCast(DockLayoutManager.GetLayoutItem(DirectCast(sender, DependencyObject)), LayoutControlItem)
            If item IsNot Nothing Then
                dockManager.LayoutController.Rename(item)
            End If
        End Sub
        Private Sub ClosePageClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim item As LayoutControlItem = TryCast(DockLayoutManager.GetLayoutItem(DirectCast(sender, DependencyObject)), LayoutControlItem)
            If item IsNot Nothing Then
                item.Parent.Remove(item)
            End If
        End Sub
        Private Sub LoadRtf(ByVal page As NotePage, ByVal range As TextRange)
            If String.IsNullOrEmpty(page.Path) Then
                Return
            End If
            Dim assembly As System.Reflection.Assembly = System.Reflection.Assembly.GetAssembly(Me.GetType())
            Using stream As Stream = assembly.GetManifestResourceStream(page.Path)
                If stream IsNot Nothing Then
                    range.Load(stream, DataFormats.Rtf)
                End If
            End Using
        End Sub

        Private Sub OnActiveNoteChanged(ByVal note_Renamed As Note)
            If note_Renamed IsNot Nothing Then
                dockManager.DockController.Activate(notesContainer(note_Renamed.Caption))
            End If
        End Sub
        Private Sub NotebooksItemSelected(ByVal sender As Object, ByVal e As NavBarItemSelectedEventArgs)
            ActiveBook = CStr(e.Group.Header)
            If e.Item IsNot Nothing Then
                ActiveNote = TryCast(e.Item.GetValue(FrameworkElement.DataContextProperty), Note)
            End If
        End Sub
    End Class
    Public Class Note
        #Region "Static"
        Public Shared ReadOnly NoteProperty As DependencyProperty = DependencyProperty.RegisterAttached("Note", GetType(Note), GetType(Note), New PropertyMetadata(Nothing))
        Public Shared Function GetNote(ByVal obj As DependencyObject) As Note
            Return DirectCast(obj.GetValue(NoteProperty), Note)
        End Function
        Public Shared Sub SetNote(ByVal obj As DependencyObject, ByVal value As Note)
            obj.SetValue(NoteProperty, value)
        End Sub
        #End Region ' Static
        Public Sub New()
            Pages = New ObservableCollection(Of NotePage)()
        End Sub
        Public Property Book() As String
        Public Property Caption() As String
        Private privatePages As ObservableCollection(Of NotePage)
        Public Property Pages() As ObservableCollection(Of NotePage)
            Get
                Return privatePages
            End Get
            Private Set(ByVal value As ObservableCollection(Of NotePage))
                privatePages = value
            End Set
        End Property
    End Class
    Public Class NotePage
        Public Property Caption() As String
        Public Property CaptionImage() As ImageSource
        Public Property Path() As String
    End Class
    Friend NotInheritable Class DefaultBook

        Private Sub New()
        End Sub

        Private Shared newNoteImageCore As ImageSource
        Public Shared ReadOnly Property NewNoteImage() As ImageSource
            Get
                If newNoteImageCore Is Nothing Then
                    newNoteImageCore = New BitmapImage(New Uri("/Images/Icons/create.png", UriKind.Relative))
                End If
                Return newNoteImageCore
            End Get
        End Property
        Public Shared Function GetNotes() As ObservableCollection(Of Note)
            Dim gNote0 As New Note() With {.Book = "General", .Caption = "Features"}
            Dim gNote1 As New Note() With {.Book = "General", .Caption = "Tips"}
            gNote0.Pages.Add(New NotePage() With {.Caption = "General", .Path = "DockingDemo.Data.QuickNotes_General.rtf"})
            gNote0.Pages.Add(New NotePage() With {.Caption = "Basics", .Path = "DockingDemo.Data.QuickNotes_Basics.rtf"})
            gNote1.Pages.Add(New NotePage() With {.Caption = "Tips", .Path = "DockingDemo.Data.QuickNotes_Tips.rtf"})

            Dim wNote0 As New Note() With {.Book = "Work", .Caption = "Meetings"}
            Dim wNote1 As New Note() With {.Book = "Work", .Caption = "Projects"}
            Dim wNote2 As New Note() With {.Book = "Work", .Caption = "Requests"}
            Dim hNote0 As New Note() With {.Book = "Home", .Caption = "Shopping"}
            hNote0.Pages.Add(New NotePage() With {.Caption = "Everyday Shopping"})
            hNote0.Pages.Add(New NotePage() With {.Caption = "Sunday Shopping"})
            Dim hNote1 As New Note() With {.Book = "Home", .Caption = "Garden"}
            Dim hNote2 As New Note() With {.Book = "Home", .Caption = "Kids"}
            Dim hNote3 As New Note() With {.Book = "Home", .Caption = "Party"}
            Return New ObservableCollection(Of Note)(New Note() { gNote0, gNote1, wNote0, wNote1, wNote2, hNote0, hNote1, hNote2, hNote3 })
        End Function
    End Class
    Public Class NoteRichTextBox
        Inherits RichTextBox

        Public Sub New()
            BorderThickness = New Thickness(0)
            VerticalScrollBarVisibility = ScrollBarVisibility.Auto
            Margin = New Thickness(-7)
        End Sub
        Protected Overrides Sub OnLostFocus(ByVal e As RoutedEventArgs)
            e.Handled = True
            MyBase.OnLostFocus(e)
        End Sub
        Protected Overrides Sub OnLostKeyboardFocus(ByVal e As KeyboardFocusChangedEventArgs)
            e.Handled = True
            MyBase.OnLostKeyboardFocus(e)
        End Sub
    End Class
End Namespace
