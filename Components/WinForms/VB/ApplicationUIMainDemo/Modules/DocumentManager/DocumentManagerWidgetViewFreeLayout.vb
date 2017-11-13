Imports DevExpress.DXperience.Demos

Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class DocumentManagerWidgetViewFreeLayout
        Inherits TutorialControlBase

        Private widgetView1 As XtraBars.Docking2010.Views.Widget.WidgetView
        Private documentManager1 As XtraBars.Docking2010.DocumentManager
        Private document1 As XtraBars.Docking2010.Views.Widget.Document
        Private document3 As XtraBars.Docking2010.Views.Widget.Document
        Private document2 As XtraBars.Docking2010.Views.Widget.Document
        Private document4 As XtraBars.Docking2010.Views.Widget.Document
        Private document5 As XtraBars.Docking2010.Views.Widget.Document
        Private document6 As XtraBars.Docking2010.Views.Widget.Document
        Private document7 As XtraBars.Docking2010.Views.Widget.Document
        Private document8 As XtraBars.Docking2010.Views.Widget.Document
        Private document9 As XtraBars.Docking2010.Views.Widget.Document
        Private components As System.ComponentModel.IContainer
        Public Sub New()
            InitializeComponent()
            AddHandler documentManager1.View.QueryControl, AddressOf OnViewQueryControl
        End Sub
        Private r As New Random()
        Private Sub OnViewQueryControl(ByVal sender As Object, ByVal e As XtraBars.Docking2010.Views.QueryControlEventArgs)
            If e.Document.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget" Then
                Dim smallWidget = New ucCardWidget()
                smallWidget.Price = r.Next(100, 1000)
                smallWidget.PPrice = r.NextDouble() - r.NextDouble()
                smallWidget.Delta = r.Next(-50, 100) + r.NextDouble()
                e.Control = smallWidget
                Return
            End If
            If Not String.IsNullOrEmpty(e.Document.ControlTypeName) Then
                e.Control = TryCast(Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)), Control)
            Else
                e.Control = New System.Windows.Forms.Control()
            End If
        End Sub
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim WidgetDockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim WidgetDockingContainer2 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim WidgetDockingContainer3 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim WidgetDockingContainer4 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim WidgetDockingContainer5 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim WidgetDockingContainer6 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim WidgetDockingContainer7 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim WidgetDockingContainer8 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim WidgetDockingContainer9 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim WidgetDockingContainer10 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim WidgetDockingContainer11 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim WidgetDockingContainer12 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Me.document9 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document2 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document1 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document3 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document4 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document5 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document6 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document7 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.document8 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.widgetView1 = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(Me.components)
            CType(Me.document9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.widgetView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'document9
            '
            Me.document9.Caption = "Clock"
            Me.document9.ControlName = "Clock"
            Me.document9.ControlTypeName = "DevExpress.ApplicationUI.Demos.Clock"
            Me.document9.FreeLayoutHeight.UnitValue = 0.45R
            Me.document9.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            Me.document9.FreeLayoutWidth.UnitValue = 220.0R
            '
            'document2
            '
            Me.document2.Caption = "Calendar"
            Me.document2.ControlName = "Calendar"
            Me.document2.ControlTypeName = "DevExpress.ApplicationUI.Demos.Calendar"
            Me.document2.FreeLayoutHeight.UnitValue = 1.55R
            Me.document2.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            Me.document2.FreeLayoutWidth.UnitValue = 220.0R
            '
            'document1
            '
            Me.document1.Caption = "Products"
            Me.document1.ControlName = "ProductsGridEx"
            Me.document1.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucProductsBorderlessGrid"
            Me.document1.Properties.ShowBorders = DevExpress.Utils.DefaultBoolean.[False]
            '
            'document3
            '
            Me.document3.Caption = "Locations"
            Me.document3.ControlName = "ChoroplethMapItem"
            Me.document3.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucChoroplethMapItem"
            Me.document3.FreeLayoutHeight.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            Me.document3.FreeLayoutHeight.UnitValue = 230.0R
            '
            'document4
            '
            Me.document4.Caption = "Exprense YTD"
            Me.document4.ControlName = "CardWidget1"
            Me.document4.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            Me.document4.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            Me.document4.FreeLayoutWidth.UnitValue = 220.0R
            Me.document4.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.[False]
            '
            'document5
            '
            Me.document5.Caption = "Profit YTD"
            Me.document5.ControlName = "CardWidget2"
            Me.document5.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            Me.document5.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            Me.document5.FreeLayoutWidth.UnitValue = 220.0R
            Me.document5.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.[False]
            '
            'document6
            '
            Me.document6.Caption = "New Customers"
            Me.document6.ControlName = "CardWidget3"
            Me.document6.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            Me.document6.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            Me.document6.FreeLayoutWidth.UnitValue = 220.0R
            Me.document6.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.[False]
            '
            'document7
            '
            Me.document7.Caption = "Market Share"
            Me.document7.ControlName = "CardWidget4"
            Me.document7.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            Me.document7.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            Me.document7.FreeLayoutWidth.UnitValue = 220.0R
            Me.document7.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.[False]
            '
            'document8
            '
            Me.document8.Caption = "Avg Order Size"
            Me.document8.ControlName = "CardWidget5"
            Me.document8.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget"
            Me.document8.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            Me.document8.FreeLayoutWidth.UnitValue = 220.0R
            Me.document8.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.[False]
            '
            'documentManager1
            '
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentManager1.View = Me.widgetView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.widgetView1})
            '
            'widgetView1
            '
            Me.widgetView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.document1, Me.document2, Me.document3, Me.document4, Me.document5, Me.document6, Me.document7, Me.document8, Me.document9})
            Me.widgetView1.FreeLayoutProperties.FreeLayoutItems.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.document1, Me.document2, Me.document3, Me.document4, Me.document5, Me.document6, Me.document7, Me.document8, Me.document9})
            Me.widgetView1.FreeLayoutProperties.ItemDragStyle = DevExpress.XtraBars.Docking2010.Views.Widget.ItemDragStyle.DockingHints
            Me.widgetView1.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FreeLayout
            Me.widgetView1.Orientation = System.Windows.Forms.Orientation.Horizontal
            Me.widgetView1.RootContainer.Element = Nothing
            WidgetDockingContainer1.Element = Nothing
            WidgetDockingContainer2.Element = Me.document9
            WidgetDockingContainer3.Element = Me.document2
            WidgetDockingContainer1.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {WidgetDockingContainer2, WidgetDockingContainer3})
            WidgetDockingContainer1.Orientation = System.Windows.Forms.Orientation.Vertical
            WidgetDockingContainer1.Size.Width.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            WidgetDockingContainer1.Size.Width.UnitValue = 220.0R
            WidgetDockingContainer4.Element = Nothing
            WidgetDockingContainer5.Element = Me.document1
            WidgetDockingContainer6.Element = Me.document3
            WidgetDockingContainer4.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {WidgetDockingContainer5, WidgetDockingContainer6})
            WidgetDockingContainer4.Orientation = System.Windows.Forms.Orientation.Vertical
            WidgetDockingContainer7.Element = Nothing
            WidgetDockingContainer8.Element = Me.document4
            WidgetDockingContainer9.Element = Me.document5
            WidgetDockingContainer10.Element = Me.document6
            WidgetDockingContainer11.Element = Me.document7
            WidgetDockingContainer12.Element = Me.document8
            WidgetDockingContainer7.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {WidgetDockingContainer8, WidgetDockingContainer9, WidgetDockingContainer10, WidgetDockingContainer11, WidgetDockingContainer12})
            WidgetDockingContainer7.Orientation = System.Windows.Forms.Orientation.Vertical
            WidgetDockingContainer7.Size.Width.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel
            WidgetDockingContainer7.Size.Width.UnitValue = 220.0R
            Me.widgetView1.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {WidgetDockingContainer1, WidgetDockingContainer4, WidgetDockingContainer7})
            '
            'DocumentManagerWidgetViewFreeLayout
            '
            Me.Name = "DocumentManagerWidgetViewFreeLayout"
            Me.Size = New System.Drawing.Size(760, 401)
            CType(Me.document9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.widgetView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace
