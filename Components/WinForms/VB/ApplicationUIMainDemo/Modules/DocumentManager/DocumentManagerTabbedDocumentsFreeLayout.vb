Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars.Docking2010.Views

Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class DocumentManagerTabbedDocumentsFreeLayout
        Inherits TutorialControlBase

#Region "Windows Form Designer generated code"
        Private documentManager1 As XtraBars.Docking2010.DocumentManager
        Private tabbedView1 As XtraBars.Docking2010.Views.Tabbed.TabbedView
        Private components As System.ComponentModel.IContainer
        Private documentGroup1 As XtraBars.Docking2010.Views.Tabbed.DocumentGroup
        Private document1 As XtraBars.Docking2010.Views.Tabbed.Document
        Private document2 As XtraBars.Docking2010.Views.Tabbed.Document
        Private document3 As XtraBars.Docking2010.Views.Tabbed.Document
        Private documentGroup2 As XtraBars.Docking2010.Views.Tabbed.DocumentGroup
        Private document4 As XtraBars.Docking2010.Views.Tabbed.Document
        Private document5 As XtraBars.Docking2010.Views.Tabbed.Document
        Private documentGroup4 As XtraBars.Docking2010.Views.Tabbed.DocumentGroup
        Private documentGroup5 As XtraBars.Docking2010.Views.Tabbed.DocumentGroup
        Private documentGroup7 As XtraBars.Docking2010.Views.Tabbed.DocumentGroup
        Private barAndDockingController1 As XtraBars.BarAndDockingController

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim dockingContainer8 As New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Dim dockingContainer9 As New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Dim dockingContainer10 As New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Dim dockingContainer11 As New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Dim dockingContainer12 As New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Dim dockingContainer13 As New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Dim dockingContainer14 As New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup4 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.document4 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentGroup5 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.document5 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentGroup7 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.document3 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.documentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentGroup2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.document2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            DirectCast(Me.documentGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.documentGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.documentGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.documentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.documentGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentGroup4
            ' 
            Me.documentGroup4.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.document4})
            ' 
            ' document4
            ' 
            Me.document4.Caption = "Clock"
            Me.document4.ControlName = "Clock"
            Me.document4.ControlTypeName = "DevExpress.ApplicationUI.Demos.Clock"
            Me.document4.ImageUri.Uri = ""
            ' 
            ' documentGroup5
            ' 
            Me.documentGroup5.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.document5})
            ' 
            ' document5
            ' 
            Me.document5.Caption = "Calendar"
            Me.document5.ControlName = "Calendar"
            Me.document5.ControlTypeName = "DevExpress.ApplicationUI.Demos.Calendar"
            Me.document5.ImageUri.Uri = ""
            ' 
            ' documentGroup7
            ' 
            Me.documentGroup7.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.document3})
            ' 
            ' document3
            ' 
            Me.document3.Caption = "Sales"
            Me.document3.ControlName = "Sales"
            Me.document3.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCategorySales"
            Me.document3.ImageUri.Uri = ""
            ' 
            ' tabbedView1
            ' 
            Me.tabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.documentGroup1, Me.documentGroup2, Me.documentGroup4, Me.documentGroup5, Me.documentGroup7})
            Me.tabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.document1, Me.document2, Me.document3, Me.document4, Me.document5})
            Me.tabbedView1.EnableFreeLayoutMode = DevExpress.Utils.DefaultBoolean.True
            dockingContainer8.Length.UnitValue = 1.7054427658400548R
            dockingContainer9.Element = Me.documentGroup1
            dockingContainer9.Length.UnitValue = 1.2481231810106879R
            dockingContainer9.Parent = dockingContainer8
            dockingContainer10.Element = Me.documentGroup2
            dockingContainer10.Length.UnitValue = 0.7518768189893118R
            dockingContainer10.Parent = dockingContainer8
            dockingContainer8.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {dockingContainer9, dockingContainer10})
            dockingContainer8.Orientation = System.Windows.Forms.Orientation.Vertical
            dockingContainer8.Parent = Me.tabbedView1.RootContainer
            dockingContainer11.Length.UnitValue = 0.62267099719482488R
            dockingContainer12.Element = Me.documentGroup4
            dockingContainer12.Length.UnitValue = 0.4821805394648605R
            dockingContainer12.Parent = dockingContainer11
            dockingContainer13.Element = Me.documentGroup5
            dockingContainer13.Length.UnitValue = 1.3723427353315503R
            dockingContainer13.Parent = dockingContainer11
            dockingContainer14.Element = Me.documentGroup7
            dockingContainer14.Length.UnitValue = 1.1454767252035896R
            dockingContainer14.Parent = dockingContainer11
            dockingContainer11.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {dockingContainer12, dockingContainer13, dockingContainer14})
            dockingContainer11.Orientation = System.Windows.Forms.Orientation.Vertical
            dockingContainer11.Parent = Me.tabbedView1.RootContainer
            Me.tabbedView1.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {dockingContainer8, dockingContainer11})
            Me.tabbedView1.RootContainer.Parent = Nothing
            ' 
            ' documentGroup1
            ' 
            Me.documentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.document1})
            ' 
            ' document1
            ' 
            Me.document1.Caption = "Products"
            Me.document1.ControlName = "document1"
            Me.document1.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucProductsGrid"
            Me.document1.ImageUri.Uri = ""
            ' 
            ' documentGroup2
            ' 
            Me.documentGroup2.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.document2})
            ' 
            ' document2
            ' 
            Me.document2.Caption = "Locations"
            Me.document2.ControlName = "ChoropletMapItem"
            Me.document2.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucChoroplethMapItem"
            Me.document2.ImageUri.Uri = ""
            ' 
            ' barAndDockingController1
            ' 
            Me.barAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
            Me.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
            ' 
            ' documentManager1
            ' 
            Me.documentManager1.BarAndDockingController = Me.barAndDockingController1
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.View = Me.tabbedView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tabbedView1})
            ' 
            ' DocumentManagerTabbedDocumentsFreeLayout
            ' 
            Me.Name = "DocumentManagerTabbedDocumentsFreeLayout"
            Me.Size = New System.Drawing.Size(869, 624)
            DirectCast(Me.documentGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.documentGroup5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.documentGroup7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.documentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.documentGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region
        Public Sub New()
            InitializeComponent()
            AddHandler documentManager1.View.QueryControl, AddressOf OnQueryControl
        End Sub
        Private Sub OnQueryControl(ByVal sender As Object, ByVal e As QueryControlEventArgs)
            If Not String.IsNullOrEmpty(e.Document.ControlTypeName) Then
                e.Control = TryCast(Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)), Control)
            Else
                e.Control = New Control()
            End If
        End Sub
    End Class
End Namespace
