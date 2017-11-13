Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.Utils.Base
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors

Namespace Examples
    <CodeExampleClass("WindowsUIView", "WindowsUIView.vb"), CodeExampleHighlightTokens("WindowsUIView", "TileItemElement", "Tile", "TileContainer", "TileItemContentAlignment", "ISupportInitialize", "Flyout", "FlyoutAction", "MessageBoxButtons", "DocumentContent", "Document", "PageGroup", "TabbedGroup", "HeaderStyle", "Page", "AttachedAction", "NavigationCommand", "ActionType", "ActionEdge", "Color", "SolidBrush", "Pen", "StringFormat", "Font", "StringAlignment", "ControlStyles", "PaintEventArgs", "StringTrimming", "StringFormatFlags", "Panel", "INavigationArgs", "IDictionaryEnumerator", "AnchorStyles", "IDocumentActionsArgs", "DocumentAction", "ISupportNavigation", "IPropertiesProvider", "DocumentManager", "XtraUserControl", "DockStyle", "ISupportDocumentActions")>
    Public NotInheritable Class WindowsUIViewInterface

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim documentManager As New DocumentManager()
            Dim documentManagerHost As New XtraUserControl()
            documentManagerHost.Parent = sampleHost
            documentManagerHost.Dock = DockStyle.Fill
            Return New Object() {documentManager, documentManagerHost}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim documentManager As DocumentManager = documentManager.FromControl(sampleHost.Controls(0))
            If documentManager IsNot Nothing Then
                documentManager.Dispose()
            End If
        End Sub
        <CodeExampleCase("Create WindowsUIView")>
        Public Shared Sub CreateWindowsUIView(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WindowsUIView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim tile As New Tile()
            Dim element As New TileItemElement() With {.Text = "Tile", .TextAlignment = TileItemContentAlignment.MiddleCenter}
            tile.Elements.Add(element)
            view.Tiles.Add(tile)
            Dim container As New TileContainer()
            container.Items.Add(tile)
            view.ContentContainers.Add(container)
            view.ActivateContainer(container)
        End Sub
		<CodeExampleCase("Using QueryStartupContentContainer event", New Type() { GetType(DocumentContent) }), CodeExampleUnderlineTokens("BeginInit", "EndInit", "ForceInitialize")>
        Public Shared Sub UseQueryStartupContentContainer(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WindowsUIView()
            TryCast(view, ISupportInitialize).BeginInit()

            Dim flyout As New Flyout()
            flyout.Action = New FlyoutAction() With {.Caption = "Login form"}
            flyout.FlyoutButtons = MessageBoxButtons.OK
            documentManager.View = view
            documentManager.ContainerControl = ownerControl
            flyout.Document = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Login User Control", .Size = New Size(300, 130)}), Document)
            Dim tile As New Tile()
            Dim element As New TileItemElement() With {.Text = "Tile", .TextAlignment = TileItemContentAlignment.MiddleCenter}
            tile.Elements.Add(element)
            view.Tiles.Add(tile)
            Dim tileContainer As New TileContainer()
            tileContainer.Items.Add(tile)
            tileContainer.Parent = flyout
            view.ContentContainers.Add(tileContainer)
            AddHandler view.QueryStartupContentContainer, Sub(sender, e) e.ContentContainer = flyout
            AddHandler view.FlyoutHidden, Sub(sender, e) view.ActivateContainer(tileContainer)
            TryCast(view, ISupportInitialize).EndInit()
            documentManager.ForceInitialize()

        End Sub
        <CodeExampleCase("Create Tile automatically", New Type() {GetType(DocumentContent)})>
        Public Shared Sub CreateSimpleTileWithDocument(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WindowsUIView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim tileContainer As New TileContainer()
            view.ContentContainers.Add(tileContainer)
            Dim document = view.AddDocument(New DocumentContent() With {.Text = "Document1"})
            'Tile created after adding document
            Dim tile = view.Tiles(document)
            Dim element As New TileItemElement() With {.Text = "Document1", .TextAlignment = TileItemContentAlignment.MiddleCenter}
            tile.Elements.Add(element)
            view.ActivateContainer(tileContainer)
        End Sub
        <CodeExampleCase("Create PageGroup", New Type() {GetType(DocumentContent)})>
        Public Shared Sub CreatePageGroup(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WindowsUIView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim container As New PageGroup()
            view.ContentContainers.Add(container)
            Dim document1 = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Document1"}), Document)
            Dim document2 = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Document2"}), Document)
            container.Items.Add(document1)
            container.Items.Add(document2)
            view.ActivateContainer(container)
        End Sub
        <CodeExampleCase("Create TabbedGroup(Tabs)", New Type() {GetType(DocumentContent)})>
        Public Shared Sub CreateTabbedGroupTabHeaderStyle(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WindowsUIView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim container As New TabbedGroup()
            view.ContentContainers.Add(container)
            Dim document1 = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Document1"}), Document)
            Dim document2 = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Document2"}), Document)
            Dim document3 = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Document3"}), Document)
            Dim document4 = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Document4"}), Document)
            Dim document5 = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Document5"}), Document)
            container.Items.Add(document1)
            container.Items.Add(document2)
            container.Items.Add(document3)
            container.Items.Add(document4)
            container.Items.Add(document5)
            view.ActivateContainer(container)
        End Sub
        <CodeExampleCase("Create TabbedGroup(Tiles)", New Type() {GetType(DocumentContent)})>
        Public Shared Sub CreateTabbedGroupTileHeaderStyle(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WindowsUIView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim container As New TabbedGroup()
            container.Properties.HeaderStyle = HeaderStyle.Tile
            container.Properties.TileSize = 80
            container.Properties.TileColumnCount = 1
            view.ContentContainers.Add(container)
            Dim item1 = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Item1"}), Document)
            Dim item2 = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Item2"}), Document)
            Dim item3 = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Item3"}), Document)
            container.Items.Add(item1)
            container.Items.Add(item2)
            container.Items.Add(item3)
            view.ActivateContainer(container)
        End Sub
        <CodeExampleCase("Simple Navigation", New Type() {GetType(DocumentContent), GetType(WindowsUIViewInitializer)})>
        Public Shared Sub SimpleNavigation(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view = WindowsUIViewInitializer.Init(documentManager, ownerControl)
            Dim document = TryCast(view.Documents(0), Document)
            Dim tile As New Tile()
            Dim element As New TileItemElement() With {.Text = "Click here", .TextAlignment = TileItemContentAlignment.MiddleCenter}
            tile.Elements.Add(element)
            view.Tiles.Add(tile)
            Dim container As New TileContainer()
            Dim page As New Page() With {.Caption = "Custom page"}
            page.Parent = container
            page.Document = document
            container.Items.Add(tile)
            tile.ActivationTarget = page
            view.ContentContainers.Add(container)
            view.ContentContainers.Add(page)
            view.ActivateContainer(container)
        End Sub
        <CodeExampleCase("Using ISupportNavigation interface", New Type() {GetType(UserControl1), GetType(DocumentContent), GetType(WindowsUIViewInitializer)})>
        Public Shared Sub UsingNavigation(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view = WindowsUIViewInitializer.Init(documentManager, ownerControl)
            Dim document = TryCast(view.AddDocument(New UserControl1()), Document)
            Dim tile As New Tile()
            tile.Tag = "Custom Filter"
            Dim element As New TileItemElement() With {.Text = "Click here", .TextAlignment = TileItemContentAlignment.MiddleCenter}
            tile.Elements.Add(element)
            view.Tiles.Add(tile)
            Dim container As New TileContainer() With {.Name = "Main container"}
            Dim page As New Page() With {.Caption = "Custom page"}
            page.Parent = container
            page.Document = document
            container.Items.Add(tile)
            tile.ActivationTarget = page
            view.ContentContainers.Add(container)
            view.ContentContainers.Add(page)
            view.ActivateContainer(container)
        End Sub
        <CodeExampleCase("Using attached action", New Type() {GetType(WindowsUIViewInitializer), GetType(DocumentContent), GetType(NavigationCommand), GetType(UserControl2)})>
        Public Shared Sub AttachedActions(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view = WindowsUIViewInitializer.Init(documentManager, ownerControl)
            Dim mainPage As New Page() With {.Caption = "Main Page"}
            Dim targetPage As New Page() With {.Caption = "Target Page"}
            Dim control As New UserControl2()
            AddHandler control.NavigateButton.Click, Sub(sender, e) AttachedAction.Execute(control.NavigateButton)
            Dim navigateAction As New AttachedAction() With {.Target = targetPage, .Command = New NavigationCommand(view)}
            AttachedAction.Attach(control.NavigateButton, navigateAction)
            Dim navigateDocument = TryCast(view.AddDocument(control), Document)
            mainPage.Document = navigateDocument
            Dim targetDocument = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Target document"}), Document)
            targetPage.Document = targetDocument
            view.ContentContainers.Add(mainPage)
            view.ContentContainers.Add(targetPage)
            targetPage.Parent = mainPage
            view.ActivateContainer(mainPage)
        End Sub
        <CodeExampleCase("Custom document action", New Type() {GetType(ActionUserControl), GetType(DocumentContent)})>
        Public Shared Sub CustomDocumentAction(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WindowsUIView()
            view.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.False
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            AddHandler view.QueryDocumentActions, Sub(sender, e) e.DocumentActions.Add(New DocumentAction(Nothing) With {.Caption = "Document Action 1"})
            Dim document = TryCast(view.AddDocument(New ActionUserControl() With {.Text = "Document1"}), Document)
            Dim page As New Page() With {.Caption = "Page"}
            page.Document = document
            page.Properties.ShowContextActionBarOnActivating = DevExpress.Utils.DefaultBoolean.True
            view.ContentContainers.Add(page)
            view.ActivateContainer(page)
        End Sub
        <CodeExampleCase("Custom container action", New Type() {GetType(DocumentContent)})>
        Public Shared Sub CustomContainerAction(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WindowsUIView()
            view.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.False
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Document1"}), Document)
            Dim page As New Page() With {.Caption = "Page"}
            page.Actions.Add(New DelegateAction(Function() (True), Sub()
                                                                   End Sub) With {.Caption = "Container action", .Type = ActionType.Context, .Edge = ActionEdge.Left})
            page.Document = document
            page.Properties.ShowContextActionBarOnActivating = DevExpress.Utils.DefaultBoolean.True
            view.ContentContainers.Add(page)
            view.ActivateContainer(page)
        End Sub
        <CodeExampleCase("Flyout with action", New Type() {GetType(WindowsUIViewInitializer), GetType(DocumentContent)})>
        Public Shared Sub Flyout(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view = WindowsUIViewInitializer.Init(documentManager, ownerControl)
            Dim document = TryCast(view.Documents(0), Document)

            Dim flyout As New Flyout() With {.Caption = "Custom page"}
            flyout.Action = New FlyoutAction() With {.Caption = "Flyout Action Caption", .Description = "Flyout Action Description"}
            flyout.FlyoutButtons = MessageBoxButtons.OK
            view.ContentContainers.Add(flyout)
            view.ActivateContainer(flyout)
        End Sub
        <CodeExampleCase("Flyout with UserControl", New Type() {GetType(WindowsUIViewInitializer), GetType(DocumentContent)})>
        Public Shared Sub FlyoutWithControl(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view = WindowsUIViewInitializer.Init(documentManager, ownerControl)
            Dim document = TryCast(view.Documents(0), Document)

            Dim flyout As New Flyout()
            flyout.Action = New FlyoutAction() With {.Caption = "Flyout Action Caption"}
            flyout.FlyoutButtons = MessageBoxButtons.OK
            'add document with user control to flyout
            flyout.Document = document
            view.ContentContainers.Add(flyout)
            view.ActivateContainer(flyout)
        End Sub
        <CodeExampleNestedClass>
        Public Class DocumentContent
            Inherits Panel

            Private Shared currentColor As Integer
            Private Shared forecolors() As Color = {Color.Red, Color.Blue, Color.Green}
            Private sb As SolidBrush
            Private pen As Pen
            Private sf As StringFormat
            Private Shared newFont As New Font("Segoe UI", 24.0F)
            Private Property TextColor() As Color
            Public Sub New()
                sf = New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter, .FormatFlags = StringFormatFlags.NoWrap}
                DoubleBuffered = True
                TextColor = forecolors((currentColor) Mod forecolors.Length)
                currentColor += 1
                SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint, True)
                SetStyle(ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
            End Sub
            Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
                If sb Is Nothing Then
                    sb = New SolidBrush(Color.FromArgb(100, TextColor))
                End If
                If pen Is Nothing Then
                    pen = New Pen(Color.FromArgb(200, 221, 223, 223))
                End If
                e.Graphics.FillRectangle(sb, ClientRectangle)
                e.Graphics.DrawString(Text, newFont, sb, ClientRectangle, sf)
            End Sub
        End Class
        <CodeExampleNestedClass>
        Public Class UserControl1
            Inherits DocumentContent
            Implements ISupportNavigation, IPropertiesProvider

            Public Sub OnNavigatedFrom(ByVal args As INavigationArgs) Implements ISupportNavigation.OnNavigatedFrom
            End Sub
            Public Sub OnNavigatedTo(ByVal args As INavigationArgs) Implements ISupportNavigation.OnNavigatedTo
                MessageBox.Show("Navigated from " & args.Source.Name.ToString & ". Tile tag = " & args.Tag.ToString)
            End Sub
            Public Function GetProperties() As System.Collections.IDictionaryEnumerator Implements IPropertiesProvider.GetProperties
                Return Nothing
            End Function
        End Class
        <CodeExampleNestedClass>
        Public Class NavigationCommand
            Implements ICommand(Of IContentContainer)

            Private viewCore As WindowsUIView
            Public Sub New(ByVal view As WindowsUIView)
                viewCore = view
            End Sub
            Public Function CanExecute(ByVal parameter As IContentContainer) As Boolean Implements ICommand(Of DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer).CanExecute
                Return True
            End Function
            Public Sub Execute(ByVal parameter As IContentContainer) Implements ICommand(Of DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer).Execute
                viewCore.ActivateContainer(parameter)
            End Sub
            Public Custom Event CanExecuteChanged As EventHandler Implements ICommand(Of DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer).CanExecuteChanged
                AddHandler(ByVal value As EventHandler)
                End AddHandler
                RemoveHandler(ByVal value As EventHandler)
                End RemoveHandler
                RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
                End RaiseEvent
            End Event
        End Class
        <CodeExampleNestedClass>
        Public Class UserControl2
            Inherits DocumentContent

            Public Sub New()
                Size = New Size(300, 130)
                NavigateButton = New SimpleButton() With {.Text = "Navigate to container",
                                                          .Size = New Size(175, 30),
                                                          .Location = New Point(10, 10),
                                                          .Parent = Me,
                                                          .Anchor = AnchorStyles.Bottom Or AnchorStyles.Right Or AnchorStyles.Left Or AnchorStyles.Top}
                NavigateButton.Dock = DockStyle.Top
                AddHandler NavigateButton.Click, Sub(sender, e) AttachedAction.Execute(NavigateButton)
            End Sub
            Public Property NavigateButton() As SimpleButton
        End Class
        <CodeExampleNestedClass>
        Public Class ActionUserControl
            Inherits DocumentContent
            Implements ISupportDocumentActions

            Public Sub OnQueryDocumentActions(ByVal args As IDocumentActionsArgs) Implements ISupportDocumentActions.OnQueryDocumentActions
                args.DocumentActions.Add(New DocumentAction(AddressOf CanExecuteDocumentAction, AddressOf ExecuteDocumentAction) With {.Caption = "Document Action 2"})
            End Sub
            Public Shared Function CanExecuteDocumentAction(ByVal document As Document) As Boolean
                Return True
            End Function
            Public Shared Sub ExecuteDocumentAction(ByVal document As Document)
                MessageBox.Show("Custom action executed")
            End Sub
        End Class

        <CodeExampleNestedClass>
        Public NotInheritable Class WindowsUIViewInitializer

            Private Sub New()
            End Sub

            Public Shared Function Init(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl) As WindowsUIView
                Dim view As New WindowsUIView()
                view.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.False
                documentManager.View = view
                documentManager.ViewCollection.Add(view)
                documentManager.ContainerControl = ownerControl
                view.AddDocument(New DocumentContent() With {.Text = "Document1", .Size = New Size(300, 150)})
                view.AddDocument(New DocumentContent() With {.Text = "Document2"})
                Return view
            End Function
        End Class
    End Class
End Namespace
