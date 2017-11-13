Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Namespace Examples
    <CodeExampleClass("TabbedView via code", "TabbedView.vb"), CodeExampleHighlightTokens("TabbedView", "UserControl", "DocumentGroupCollection", "BaseDocument", "DocumentGroup", "Document", "Orientation", "RibbonMdiMergeStyle", "RibbonAndBarsMergeStyle", "Color", "RibbonControl", "RibbonPage", "RibbonPageGroup", "BarButtonItem", "BarItem", "Panel")>
    Public NotInheritable Class TabbedLayout

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
                documentManager = Nothing
            End If
        End Sub
        <CodeExampleCase("Create simple TabbedView")>
        Public Shared Sub SimpleTabbedView(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New TabbedView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.AddDocument(New UserControl() With {.Text = "Document1"})
        End Sub
        <CodeExampleCase("Create TabbedView with free layout")>
        Public Shared Sub TabbedViewFreeLayout(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New TabbedView()
            view.EnableFreeLayoutMode = DevExpress.Utils.DefaultBoolean.True
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim groups1 As DocumentGroupCollection = view.DocumentGroups
            For i As Integer = 1 To 3
                Dim document As BaseDocument = view.AddDocument(New Control())
                document.Caption = "Document" & i
                Dim documentGroup As New DocumentGroup()
                view.DocumentGroups.Add(documentGroup)
                view.Controller.Dock(TryCast(document, Document), documentGroup)
            Next i
            groups1(2).DockTo(groups1(1), Orientation.Vertical)
            view.LayoutChanged()
        End Sub
        <CodeExampleCase("Ribbon merging", New Type() {GetType(RibbonInitializer)})>
        Public Shared Sub DocumentRibbonMerging(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New TabbedView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            documentManager.RibbonAndBarsMergeStyle = RibbonAndBarsMergeStyle.Always
            Dim control = New UserControl() With {.Text = "Document1"}
            Dim mainRibbon = RibbonInitializer.Init(ownerControl, True)
            Dim childRibbon = RibbonInitializer.Init(control, False)

            mainRibbon.MdiMergeStyle = RibbonMdiMergeStyle.Always

            view.AddDocument(control)
            mainRibbon.SelectedPage = mainRibbon.MergedPages(0)
        End Sub
        <CodeExampleCase("Create several vertical DocumentGroup")>
        Public Shared Sub CreateSeveralDocumentVerticalGroup(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New TabbedView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document1 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document1"}), Document)
            Dim document2 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document2"}), Document)
            Dim newDocumentGroup As New DocumentGroup()
            view.DocumentGroups.Add(newDocumentGroup)
            Dim Controller = TryCast(view.Controller, ITabbedViewController)
            Controller.Dock(document2, newDocumentGroup)
        End Sub
        <CodeExampleCase("Create several horizontal DocumentGroup")>
        Public Shared Sub CreateSeveralDocumentHorizontalGroup(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New TabbedView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document1 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document1"}), Document)
            Dim document2 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document2"}), Document)
            Dim newDocumentGroup As New DocumentGroup()
            view.DocumentGroups.Add(newDocumentGroup)
            view.Orientation = Orientation.Vertical
            Dim Controller = TryCast(view.Controller, ITabbedViewController)
            Controller.Dock(document2, newDocumentGroup)
        End Sub
        <CodeExampleCase("Colored Tabs")>
        Public Shared Sub ColoredTab(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New TabbedView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document1 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document1"}), Document)
            Dim document2 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document2"}), Document)
            Dim newDocumentGroup As New DocumentGroup()
            view.DocumentGroups.Add(newDocumentGroup)
            Dim Controller = TryCast(view.Controller, ITabbedViewController)
            Controller.Dock(document2, newDocumentGroup)
            view.AppearancePage.Header.BackColor = Color.Red
            document1.Appearance.HeaderActive.BackColor = Color.Green
            document2.Appearance.HeaderActive.BackColor = Color.Green
            view.Controller.Activate(document1)

        End Sub
        <CodeExampleNestedClass>
        Public NotInheritable Class RibbonInitializer

            Private Sub New()
            End Sub

            Public Shared Function Init(ByVal control As Control, ByVal parentRibbon As Boolean) As RibbonControl
                Dim ribbonControl As New RibbonControl()
                Dim ribbonPage As New RibbonPage()
                Dim ribbonPageGroup As New RibbonPageGroup()
                Dim barButtonItem As New BarButtonItem()
                ribbonControl.Items.AddRange(New BarItem() {barButtonItem})
                ribbonControl.Pages.AddRange(New RibbonPage() {ribbonPage})
                ribbonPage.Groups.AddRange(New RibbonPageGroup() {ribbonPageGroup})
                ribbonPage.Text = If(parentRibbon, "MainPage", "DocumentPage")
                ribbonPageGroup.ItemLinks.Add(barButtonItem)
                ribbonPageGroup.Text = "Actions"
                If parentRibbon Then
                    barButtonItem.Caption = "Add"
                    barButtonItem.ImageUri.Uri = "Add"
                Else
                    barButtonItem.Caption = "Save"
                    barButtonItem.ImageUri.Uri = "Save"
                End If
                control.Controls.Add(ribbonControl)
                Return ribbonControl
            End Function
        End Class
    End Class
End Namespace
