Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Base
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraEditors

Namespace TabbedBrowser
    Partial Public Class RootMainForm
        Inherits XtraForm
        Implements DevExpress.XtraBars.Docking2010.IDocumentsHostWindow
        Private popupMenu As BrowserMenu
        Private allHistory As Dictionary(Of String, Date)
        Private IsHistory, CloseForm, CanCreateAddTab As Boolean
        Protected IsInitialized As Boolean = True
        Protected InitialFormSize As Size
        Private homeUrl As String = "http://devexpress.com/"
        Public Sub New()
            Initialize(New Dictionary(Of String, Date)(), FormWindowState.Maximized)
        End Sub
        Public Sub New(ByVal allHistory As Dictionary(Of String, Date), ByVal state As FormWindowState)
            Initialize(allHistory, state)
        End Sub
        Private Sub Initialize(ByVal allHistory As Dictionary(Of String, Date), ByVal state As FormWindowState)
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, Me) 'DEMO_REMOVE
            InitializeComponent()
            AddHandler tabbedView1.CustomDocumentsHostWindow, AddressOf CustomDocumentsHostWindow
            tabbedView1.FloatingDocumentContainer = FloatingDocumentContainer.DocumentsHost
            AddHandler tabbedView1.QueryControl, AddressOf QueryControl
            AddHandler tabbedView1.Documents.CollectionChanged, AddressOf DocumentsCollectionChanged
            AddHandler tabbedView1.TabMouseActivating, AddressOf TabMouseActivating
            AddHandler tabbedView1.ControlReleasing, AddressOf ControlReleasing
            CreateAddTab(Nothing)
            AddHandler tabbedView1.DocumentGroups.CollectionChanged, AddressOf DocumentGroupsCollectionChanged
            AddHandler tabbedView1.PopupMenuShowing, AddressOf PopupMenuShowing
            AddHandler tabbedView1.BeginDocumentsHostDocking, AddressOf BeginDocumentsHostDocking
            Me.allHistory = allHistory
            CanCreateAddTab = True
            WindowState = state
        End Sub
        Private Sub CreateMenu()
            popupMenu = New BrowserMenu(barManager1)
        End Sub
        Private Delegate Sub DelegateReleaseDeferredLoadControl(ByVal document As Document)
        Private Delegate Sub DelegateCreateAddTab(ByVal group As DocumentGroup)
        Private Sub CreateAddTab(ByVal group As DocumentGroup)
            Dim newDocument As Document = CreateTab("+", group)
            newDocument.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False
            newDocument.Properties.AllowPin = newDocument.Properties.AllowClose
            newDocument.Properties.AllowFloat = newDocument.Properties.AllowPin
            newDocument.Properties.ShowInDocumentSelector = DevExpress.Utils.DefaultBoolean.False
        End Sub
        Private Function CreateTab(ByVal caption As String, ByVal group As DocumentGroup) As Document
            Dim document As Document = CType(tabbedView1.AddDocument(caption, caption), Document)
            If group IsNot Nothing Then
                tabbedView1.Controller.Dock(document, group)
            End If
            Return document
        End Function
        Public Sub CreateNewTab()
            ActivateTab(GetAddTab(GetActiveDocument().Parent))
        End Sub
        Public Sub CreateNewWindow(ByVal control As Control)
            tabbedView1.AddFloatingDocumentsHost(control)
            Dim manager = (CType(control.FindForm(), IDocumentsHostWindow)).DocumentManager
            Dim doc As Document = CType(manager.GetDocument(control), Document)
            AddHandler doc.ParentChanged, AddressOf DocumentParentChanged
        End Sub
        Public Sub Navigate(ByVal url As String)
            Navigate(GetActiveDocument().Control, url)
        End Sub
        Private Sub SetSelectedPrevTab(ByVal group As DocumentGroup)
            Dim index As Integer = group.SelectedItemIndex
            If index > 0 Then
                group.SetSelected(group.Items(index - 1))
            End If
        End Sub
        Private Sub ActivateTab(ByVal document As Document)
            If IsAddTab(document) Then
                CanCreateAddTab = True
            End If
            tabbedView1.Controller.Activate(document)
        End Sub
        Private Sub RestoreAddTabButtonPosition(ByVal group As DocumentGroup, ByVal document As Document)
            Dim addTab As Document = GetAddTab(group)
            Using BatchUpdate.Enter(group)
                If CanRestoreAddTabButtonPosition(group.Items, addTab) Then
                    group.Items.Move(group.Items.Count, addTab)
                    If document IsNot Nothing Then
                        group.SetSelected(document)
                    End If
                End If
            End Using
        End Sub
        Private Sub RestoreAddTabButtonPositions()
            Dim groups() As DocumentGroup = tabbedView1.DocumentGroups.ToArray()
            For Each group As DocumentGroup In groups
                RestoreAddTabButtonPosition(group, Nothing)
            Next group
        End Sub
        Private Function CloseChildWindow(ByVal group As DocumentGroup) As Boolean
            If group.Items.Count <= 2 Then
                Dim document As Document = GetAddTab(group)
                If document IsNot Nothing Then document.Dispose()
                If tabbedView1.DocumentGroups.Count <= 1 Then
                    Return True
                End If
            End If
            ActivateTab(group.SelectedDocument)
            Return False
        End Function
        Private Function GetAddTab(ByVal group As DocumentGroup) As Document
            Return group.Items.FindFirst(Function(x) x.Caption = "+")
        End Function
        Private Function GetActiveDocument() As Document
            Return CType(tabbedView1.ActiveDocument, Document)
        End Function
        Private Sub SetTabCaption(ByVal Caption As String)
            If Caption <> "" Then
                GetActiveDocument().Caption = Caption
            Else
                GetActiveDocument().Caption = "New Tab"
            End If
        End Sub
        Private Sub AddHistory(ByVal url As String)
            If url IsNot Nothing AndAlso (Not allHistory.ContainsKey(url)) Then
                allHistory.Add(url, Date.Now)
            End If
        End Sub
        Private Function QueryControlAddTab(ByVal e As QueryControlEventArgs) As Boolean
            e.Control = If((Not IsInitialized), New BrowserControl(), New BrowserControl(homeUrl))
            AddHandler e.Control.TextChanged, AddressOf TabTextChanged
            AddHandler (CType(e.Control, BrowserControl)).ChangeHistory, AddressOf ChangeHistory
            Dim thisDoc As Document = CType(e.Document, Document)
            Return IsAddTab(thisDoc)
        End Function
        Private Function QueryControlHistory(ByVal e As QueryControlEventArgs) As Boolean
            e.Control = New HistoryControl()
            AddHandler (CType(e.Control, HistoryControl)).ItemClick, AddressOf History_ItemClick
            Dim thisDoc As Document = CType(e.Document, Document)
            Return IsAddTab(thisDoc)
        End Function
        Private Function IsAddTab(ByVal document As Document) As Boolean
            If document.Caption = "+" Then
                Return True
            End If
            Return False
        End Function
        Private Function CanRestoreAddTabButtonPosition(ByVal collection As DocumentCollection, ByVal addTab As Document) As Boolean
            Return collection.IndexOf(addTab) <> collection.Count - 1
        End Function
        Private Sub SetPropertyNewTab(ByVal document As Document, ByVal caption As String)
            document.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.True
            document.Properties.AllowPin = document.Properties.AllowClose
            document.Properties.AllowFloat = document.Properties.AllowPin
            document.Properties.ShowInDocumentSelector = DevExpress.Utils.DefaultBoolean.True
            document.Caption = caption
        End Sub
        Private Sub Navigate(ByVal browser As Control, ByVal url As String)
            Dim control As BrowserControl = TryCast(browser, BrowserControl)
            If control IsNot Nothing Then
                control.Navigate(url)
            End If
        End Sub
        Private Sub BeginFloating(ByVal sender As Object, ByVal e As DocumentCancelEventArgs) Handles tabbedView1.BeginFloating
            Dim ea As BeginFloatingEventArgs = TryCast(e, BeginFloatingEventArgs)
            Dim document As Document = CType(e.Document, Document)
            If ea.FloatingReason <> FloatingReason.DoubleClick Then
                SetSelectedPrevTab(document.Parent)
                CloseChildWindow(document.Parent)
            Else
                e.Cancel = document.Parent.Items.Count = 2
            End If
        End Sub
        Private Sub EndDocking(ByVal sender As Object, ByVal e As DocumentEventArgs) Handles tabbedView1.EndDocking
            RestoreAddTabButtonPosition((CType(e.Document, Document)).Parent, CType(e.Document, Document))
        End Sub
        Private Sub CustomHeaderButtonClick(ByVal sender As Object, ByVal e As CustomHeaderButtonEventArgs) Handles tabbedView1.CustomHeaderButtonClick
            If e.Document IsNot Nothing Then
                ActivateTab(e.Document)
                If e.Button.Index = 0 Then
                    Navigate(e.Document.Control, homeUrl)
                End If
                If e.Button.Index = 1 Then
                    IsHistory = True
                    ActivateTab(GetAddTab(e.Document.Parent))
                End If
                If e.Button.Index = 2 Then
                    If popupMenu Is Nothing Then
                        CreateMenu()
                    End If
                    popupMenu.ShowPopup(barManager1, documentManager1.ClientToScreen(New Point(e.Document.Control.Parent.Right - 133, e.Document.Control.Parent.Top - 1)))
                End If
            End If
        End Sub
        Private Sub History_ItemClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim tag As String
            Dim itemArgs As DevExpress.XtraBars.ItemClickEventArgs = TryCast(e, DevExpress.XtraBars.ItemClickEventArgs)
            If itemArgs IsNot Nothing Then
                tag = itemArgs.Item.Tag.ToString()
            Else
                tag = "DoubleClick"
            End If
            If tag = "DoubleClick" Or tag = "Open in new Tab" Then
                Dim document As Document = GetAddTab(GetActiveDocument().Parent)
                ActivateTab(document)
                CType(document.Control, BrowserControl).Navigate((CType(sender, HistoryItem)).Url)
            End If
            If tag = "Open in new Window" Then
                CreateNewWindow(New BrowserControl((CType(sender, HistoryItem)).Url))
            End If
        End Sub
        Private Sub TabTextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim browserControl As BrowserControl = (CType(sender, BrowserControl))
            If tabbedView1.ActiveDocument Is Nothing Then
                ActivateTab(CType(tabbedView1.Documents(0), Document))
            End If
            SetTabCaption(browserControl.GetCaption)
        End Sub
        Private Sub ChangeHistory(ByVal sender As Object, ByVal e As EventArgs)
            Dim url As String = If(sender.ToString() = "", "New Tab", sender.ToString())
            AddHistory(url)
        End Sub
        Private Sub ClearHistory(ByVal sender As Object, ByVal e As EventArgs)
            allHistory.Clear()
        End Sub
        Private Sub CustomDocumentsHostWindow(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.CustomDocumentsHostWindowEventArgs)
            e.Constructor = Function() New HostWindow(allHistory, Me)
        End Sub
        Private Sub DocumentGroupsCollectionChanged(ByVal ea As DevExpress.XtraBars.Docking2010.Base.CollectionChangedEventArgs(Of DocumentGroup))
            If ea.ChangedType = DevExpress.XtraBars.Docking2010.Base.CollectionChangedType.ElementAdded Then
                CreateAddTab(ea.Element)
            End If
        End Sub
        Private Sub QueryControl(ByVal sender As Object, ByVal e As QueryControlEventArgs)
            If If(IsHistory, QueryControlHistory(e), QueryControlAddTab(e)) Then
                If Not CanCreateAddTab Then
                    BeginInvoke(New DelegateReleaseDeferredLoadControl(AddressOf tabbedView1.ReleaseDeferredLoadControl), e.Document)
                    SetSelectedPrevTab(CType(e.Document, Document).Parent)
                    ActivateTab(CType(e.Document, Document).Parent.SelectedDocument)
                Else
                    SetPropertyNewTab(CType(e.Document, Document), If(IsHistory, "History", "New Tab"))
                    AddHandler (CType(e.Document, Document)).ParentChanged, AddressOf DocumentParentChanged
                    BeginInvoke(New DelegateCreateAddTab(AddressOf CreateAddTab), (CType(e.Document, Document)).Parent)
                End If
                IsHistory = False
            End If
            IsInitialized = False
            CanCreateAddTab = False
        End Sub
        Private Sub ControlReleasing(ByVal sender As Object, ByVal e As ControlReleasingEventArgs)
            If IsAddTab(CType(e.Document, Document)) Then
                e.Cancel = False
                e.DisposeControl = True
            End If
        End Sub
        Private Sub TabMouseActivating(ByVal sender As Object, ByVal e As DocumentCancelEventArgs)
            If (CType(e.Document, Document)).Caption = "+" Then
                CanCreateAddTab = True
            End If
        End Sub
        Private Sub PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            Dim document As Document = TryCast(e.GetDocument(), Document)
            If document IsNot Nothing AndAlso document.Parent.Items.Count = 2 Then
                e.Menu.Remove(BaseViewControllerCommand.Float)
                e.Menu.Remove(TabbedViewControllerCommand.NewVerticalDocumentGroup)
                e.Menu.Remove(TabbedViewControllerCommand.NewHorizontalDocumentGroup)
                e.Menu.Remove(TabbedViewControllerCommand.MoveToPrevDocumentGroup)
                e.Menu.Remove(TabbedViewControllerCommand.MoveToNextDocumentGroup)
            End If
        End Sub
        Private Sub DocumentParentChanged(ByVal sender As Object, ByVal e As DocumentEventArgs)
            Dim document As Document = CType(sender, Document)
            If document.Parent IsNot Nothing Then
                RestoreAddTabButtonPosition(document.Parent, document)
            End If
        End Sub
        Private Sub DocumentsCollectionChanged(ByVal ea As DevExpress.XtraBars.Docking2010.Base.CollectionChangedEventArgs(Of BaseDocument))
            Dim control As XtraUserControl = TryCast(ea.Element.Control, XtraUserControl)
            If control IsNot Nothing Then
                If ea.ChangedType = DevExpress.XtraBars.Docking2010.Base.CollectionChangedType.ElementAdded Then
                    If TypeOf control Is BrowserControl Then
                        AddHandler control.TextChanged, AddressOf TabTextChanged
                    End If
                    If TypeOf control Is HistoryControl Then
                        AddHandler (CType(control, HistoryControl)).ItemClick, AddressOf History_ItemClick
                    End If
                End If
                If ea.ChangedType = DevExpress.XtraBars.Docking2010.Base.CollectionChangedType.ElementRemoved Then
                    If TypeOf control Is BrowserControl Then
                        RemoveHandler control.TextChanged, AddressOf TabTextChanged
                    End If
                    If TypeOf control Is HistoryControl Then
                        RemoveHandler (CType(control, HistoryControl)).ItemClick, AddressOf History_ItemClick
                    End If
                End If
            End If
        End Sub
        Private Sub DocumentActivated(ByVal sender As Object, ByVal e As DocumentEventArgs) Handles tabbedView1.DocumentActivated
            If e.Document.Caption = "History" Then
                CType(e.Document.Control, HistoryControl).Update(allHistory)
            End If
        End Sub
        Private Sub BeginDocumentsHostDocking(ByVal sender As Object, ByVal e As DocumentCancelEventArgs) Handles tabbedView1.BeginDocumentsHostDocking
            Dim view As TabbedView = CType(e.Document.Manager.View, TabbedView)
            If view IsNot Nothing Then
                For Each group As DocumentGroup In view.DocumentGroups
                    Dim document As Document = GetAddTab(group)
                    If document IsNot Nothing Then
                        document.Dispose()
                    End If
                Next group
            End If
        End Sub
        Private Sub DocumentClosing(ByVal sender As Object, ByVal e As DocumentCancelEventArgs) Handles tabbedView1.DocumentClosing
            Dim group As DocumentGroup = (CType(e.Document, Document)).Parent
            If group IsNot Nothing Then
                SetSelectedPrevTab(group)
                CloseForm = CloseChildWindow(group)
            End If
        End Sub
        Private Sub DocumentClosed(ByVal sender As Object, ByVal e As DocumentEventArgs) Handles tabbedView1.DocumentClosed
            If CloseForm Then
                BeginInvoke(New Action(AddressOf Me.Close))
            End If
        End Sub
#Region "IDocumentHostWindow Members"
        Private ReadOnly Property DestroyOnRemovingChildren() As Boolean Implements IDocumentsHostWindow.DestroyOnRemovingChildren
            Get
                Return True
            End Get
        End Property

        Private ReadOnly Property IDocumentsHostWindow_DocumentManager() As DocumentManager Implements IDocumentsHostWindow.DocumentManager
            Get
                Return documentManager1
            End Get
        End Property
        Private Sub IDocumentsHostWindow_Close() Implements IDocumentsHostWindow.Close
            MyBase.Close()
        End Sub
        Private Sub IDocumentsHostWindow_Show() Implements IDocumentsHostWindow.Show
            RestoreAddTabButtonPositions()
            RemoveHandler Me.Shown, AddressOf TabbedBrowserApplicationContext.rootForm_Shown
            RemoveHandler Me.Disposed, AddressOf TabbedBrowserApplicationContext.rootForm_Disposed
            AddHandler Me.Shown, AddressOf TabbedBrowserApplicationContext.rootForm_Shown
            AddHandler Me.Disposed, AddressOf TabbedBrowserApplicationContext.rootForm_Disposed
            MyBase.Show()
        End Sub
        Private Custom Event IDocumentsHostWindow_Closed As EventHandler Implements IDocumentsHostWindow.Closed
            AddHandler(ByVal value As EventHandler)
                Throw New NotImplementedException()
            End AddHandler
            RemoveHandler(ByVal value As EventHandler)
                Throw New NotImplementedException()
            End RemoveHandler
            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            End RaiseEvent
        End Event
        Private Custom Event IDocumentsHostWindow_Closing As System.ComponentModel.CancelEventHandler Implements IDocumentsHostWindow.Closing
            AddHandler(ByVal value As System.ComponentModel.CancelEventHandler)
                Throw New NotImplementedException()
            End AddHandler
            RemoveHandler(ByVal value As System.ComponentModel.CancelEventHandler)
                Throw New NotImplementedException()
            End RemoveHandler
            RaiseEvent(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            End RaiseEvent
        End Event
        Private Sub IDocumentsHostWindow_Hide() Implements IDocumentsHostWindow.Hide
            MyBase.Hide()
        End Sub
#End Region
    End Class

    Friend Class BrowserMenu
        Inherits PopupMenu
        Public Sub New(ByVal barManeger As BarManager)
            MyBase.New(barManeger)
            Me.Add("New Tab")
            Me.Add("New Window")
            Me.AddGallerySkin("Skin")
            Me.Add("Help")
            Me.Add("Support")
            Me.Add("About")
            Manager = barManeger
        End Sub
        Public Function Add(ByVal menuCaption As String) As BarItemLink
            Return Me.AddItem(AddToCollection(menuCaption))
        End Function
        Private Function AddToCollection(ByVal menuCaption As String) As BarButtonItem
            Dim newMenu As New BarButtonItem(Manager, menuCaption)
            newMenu.Tag = menuCaption
            AddHandler newMenu.ItemClick, AddressOf browserMenu_Click
            Return newMenu
        End Function
        Private Sub AddRange(ByVal subMenu As BarItemLinkCollection, ByVal menuCaption As List(Of String))
            If menuCaption IsNot Nothing Then
                For Each caption As String In menuCaption
                    subMenu.Add(AddToCollection(caption))
                Next caption
            End If
        End Sub
        Public Function Add(ByVal subMenuCaption As String, ByVal menuCaption As List(Of String)) As BarSubItem
            Dim newSubMenu As New BarSubItem(Manager, subMenuCaption)
            newSubMenu.Tag = subMenuCaption
            AddRange(newSubMenu.ItemLinks, menuCaption)
            Me.AddItem(newSubMenu)
            Return newSubMenu
        End Function
        Public Function AddGallerySkin(ByVal caption As String) As BarButtonItem
            Dim gallery As New PopupMenu()
            gallery.Manager = Manager
            SkinHelper.InitSkinPopupMenu(gallery)
            Dim galleryMenu As New BarButtonItem(Manager, caption)
            galleryMenu.ButtonStyle = BarButtonStyle.DropDown
            galleryMenu.DropDownControl = gallery
            galleryMenu.ActAsDropDown = True
            Me.AddItem(galleryMenu)
            Return galleryMenu
        End Function

        Private Sub browserMenu_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim mainForm As RootMainForm = (CType(Me.Manager.Form, RootMainForm))
            Select Case e.Item.Tag.ToString()
                Case "New Tab"
                    mainForm.CreateNewTab()
                Case "New Window"
                    mainForm.CreateNewWindow(New BrowserControl())
                Case "Help"
                    mainForm.Navigate("http://www.devexpress.com/Products/NET/Controls/WinForms/Bars")
                Case "Support"
                    mainForm.Navigate("http://www.devexpress.com/Support")
                Case "About"
                    BarManager.About()
            End Select
        End Sub
    End Class
End Namespace
