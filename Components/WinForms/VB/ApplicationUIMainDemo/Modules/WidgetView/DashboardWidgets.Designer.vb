Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views.Widget
Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class DashboardWidgets
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardWidgets))
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.widgetView1 = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(Me.components)
            Me.calendarDocument = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.dateTimeDocument = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.mailDocument = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.weatherDocument = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.newsDocument = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.tradingDocument = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biFlowMode = New DevExpress.XtraBars.BarButtonItem()
            Me.biStackedMode = New DevExpress.XtraBars.BarButtonItem()
            Me.biTableMode = New DevExpress.XtraBars.BarButtonItem()
            Me.biLeftToRight = New DevExpress.XtraBars.BarButtonItem()
            Me.biRightToLeft = New DevExpress.XtraBars.BarButtonItem()
            Me.biBottomUp = New DevExpress.XtraBars.BarButtonItem()
            Me.biTopDown = New DevExpress.XtraBars.BarButtonItem()
            Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.biFreeMode = New DevExpress.XtraBars.BarButtonItem()
            Me.biDragMode = New DevExpress.XtraBars.BarButtonItem()
            Me.rpSettings = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.pgLayoutMode = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.pgFlowDirection = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.pgMixAction = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.biItemMixer = New DevExpress.XtraBars.BarButtonItem()
            Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.RowDefinition1 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
            Me.RowDefinition2 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
            Me.RowDefinition3 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
            Me.ColumnDefinition1 = New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition()
            Me.ColumnDefinition2 = New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition()
            Me.ColumnDefinition3 = New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition()
            Me.StackGroup1 = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(Me.components)
            Me.StackGroup2 = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(Me.components)
            Me.StackGroup3 = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(Me.components)
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.widgetView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.calendarDocument, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateTimeDocument, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mailDocument, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.weatherDocument, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.newsDocument, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tradingDocument, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RowDefinition1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RowDefinition2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RowDefinition3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ColumnDefinition1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ColumnDefinition2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ColumnDefinition3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StackGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StackGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StackGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me.widgetView1.Columns.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition() {Me.ColumnDefinition1, Me.ColumnDefinition2, Me.ColumnDefinition3})
            Me.widgetView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.calendarDocument, Me.dateTimeDocument, Me.mailDocument, Me.weatherDocument, Me.newsDocument, Me.tradingDocument})
            Me.widgetView1.DocumentSpacing = 3
            Me.widgetView1.FreeLayoutProperties.FreeLayoutItems.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.calendarDocument, Me.dateTimeDocument, Me.mailDocument, Me.weatherDocument, Me.newsDocument, Me.tradingDocument})
            Me.widgetView1.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FreeLayout
            Me.widgetView1.RootContainer.Element = Nothing
            WidgetDockingContainer1.Element = Nothing
            WidgetDockingContainer2.Element = Nothing
            WidgetDockingContainer3.Element = Me.newsDocument
            WidgetDockingContainer4.Element = Me.calendarDocument
            WidgetDockingContainer2.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {WidgetDockingContainer3, WidgetDockingContainer4})
            WidgetDockingContainer2.Orientation = System.Windows.Forms.Orientation.Vertical
            WidgetDockingContainer5.Element = Nothing
            WidgetDockingContainer6.Element = Nothing
            WidgetDockingContainer7.Element = Me.dateTimeDocument
            WidgetDockingContainer8.Element = Me.mailDocument
            WidgetDockingContainer6.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {WidgetDockingContainer7, WidgetDockingContainer8})
            WidgetDockingContainer9.Element = Me.weatherDocument
            WidgetDockingContainer10.Element = Me.tradingDocument
            WidgetDockingContainer5.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {WidgetDockingContainer6, WidgetDockingContainer9, WidgetDockingContainer10})
            WidgetDockingContainer5.Orientation = System.Windows.Forms.Orientation.Vertical
            WidgetDockingContainer1.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {WidgetDockingContainer2, WidgetDockingContainer5})
            Me.widgetView1.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {WidgetDockingContainer1})
            Me.widgetView1.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.widgetView1.Rows.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition() {Me.RowDefinition1, Me.RowDefinition2, Me.RowDefinition3})
            Me.widgetView1.StackGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup() {Me.StackGroup1, Me.StackGroup2, Me.StackGroup3})
            '
            'calendarDocument
            '
            Me.calendarDocument.Caption = "Calendar"
            Me.calendarDocument.ColumnIndex = 1
            Me.calendarDocument.ControlName = "Calendar"
            Me.calendarDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.Calendar"
            Me.calendarDocument.Height = 295
            Me.calendarDocument.Width = 260
            '
            'dateTimeDocument
            '
            Me.dateTimeDocument.Caption = "Date & Time"
            Me.dateTimeDocument.ColumnIndex = 1
            Me.dateTimeDocument.ControlName = "Clock"
            Me.dateTimeDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.Clock"
            Me.dateTimeDocument.Height = 125
            Me.dateTimeDocument.RowIndex = 1
            Me.dateTimeDocument.Width = 276
            '
            'mailDocument
            '
            Me.mailDocument.Caption = "Mail"
            Me.mailDocument.ControlName = "Mail"
            Me.mailDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.Mail"
            Me.mailDocument.Height = 176
            Me.mailDocument.RowIndex = 1
            Me.mailDocument.Width = 276
            '
            'weatherDocument
            '
            Me.weatherDocument.Caption = "Weather"
            Me.weatherDocument.ColumnIndex = 2
            Me.weatherDocument.ControlName = "Weather"
            Me.weatherDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.Weather"
            Me.weatherDocument.FreeLayoutHeight.UnitValue = 1.1R
            Me.weatherDocument.Height = 227
            Me.weatherDocument.Width = 414
            '
            'newsDocument
            '
            Me.newsDocument.Caption = "News"
            Me.newsDocument.ColumnIndex = 2
            Me.newsDocument.ControlName = "News"
            Me.newsDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.News"
            Me.newsDocument.Height = 290
            Me.newsDocument.RowIndex = 1
            Me.newsDocument.Width = 496
            '
            'tradingDocument
            '
            Me.tradingDocument.Caption = "TO-DO"
            Me.tradingDocument.ControlName = "TO-DO"
            Me.tradingDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.ToDoList"
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.biFlowMode, Me.biStackedMode, Me.biTableMode, Me.biLeftToRight, Me.biRightToLeft, Me.biBottomUp, Me.biTopDown, Me.BarCheckItem1, Me.biFreeMode, Me.biDragMode})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 11
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpSettings})
            Me.ribbonControl1.Size = New System.Drawing.Size(924, 141)
            '
            'biFlowMode
            '
            Me.biFlowMode.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biFlowMode.Caption = "Flow Layout"
            Me.biFlowMode.Glyph = CType(resources.GetObject("biFlowMode.Glyph"), System.Drawing.Image)
            Me.biFlowMode.GroupIndex = 1
            Me.biFlowMode.Id = 1
            Me.biFlowMode.LargeGlyph = CType(resources.GetObject("biFlowMode.LargeGlyph"), System.Drawing.Image)
            Me.biFlowMode.Name = "biFlowMode"
            Me.biFlowMode.Tag = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FlowLayout
            '
            'biStackedMode
            '
            Me.biStackedMode.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biStackedMode.Caption = "Stacked Layout"
            Me.biStackedMode.Glyph = CType(resources.GetObject("biStackedMode.Glyph"), System.Drawing.Image)
            Me.biStackedMode.GroupIndex = 1
            Me.biStackedMode.Id = 2
            Me.biStackedMode.LargeGlyph = CType(resources.GetObject("biStackedMode.LargeGlyph"), System.Drawing.Image)
            Me.biStackedMode.Name = "biStackedMode"
            Me.biStackedMode.Tag = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.StackLayout
            '
            'biTableMode
            '
            Me.biTableMode.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biTableMode.Caption = "Table Layout"
            Me.biTableMode.Glyph = CType(resources.GetObject("biTableMode.Glyph"), System.Drawing.Image)
            Me.biTableMode.GroupIndex = 1
            Me.biTableMode.Id = 3
            Me.biTableMode.LargeGlyph = CType(resources.GetObject("biTableMode.LargeGlyph"), System.Drawing.Image)
            Me.biTableMode.Name = "biTableMode"
            Me.biTableMode.Tag = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.TableLayout
            '
            'biLeftToRight
            '
            Me.biLeftToRight.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biLeftToRight.Caption = "Left to Right"
            Me.biLeftToRight.Down = True
            Me.biLeftToRight.Glyph = CType(resources.GetObject("biLeftToRight.Glyph"), System.Drawing.Image)
            Me.biLeftToRight.GroupIndex = 2
            Me.biLeftToRight.Id = 4
            Me.biLeftToRight.LargeGlyph = CType(resources.GetObject("biLeftToRight.LargeGlyph"), System.Drawing.Image)
            Me.biLeftToRight.Name = "biLeftToRight"
            Me.biLeftToRight.Tag = System.Windows.Forms.FlowDirection.LeftToRight
            '
            'biRightToLeft
            '
            Me.biRightToLeft.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biRightToLeft.Caption = "Right to Left"
            Me.biRightToLeft.Glyph = CType(resources.GetObject("biRightToLeft.Glyph"), System.Drawing.Image)
            Me.biRightToLeft.GroupIndex = 2
            Me.biRightToLeft.Id = 5
            Me.biRightToLeft.LargeGlyph = CType(resources.GetObject("biRightToLeft.LargeGlyph"), System.Drawing.Image)
            Me.biRightToLeft.Name = "biRightToLeft"
            Me.biRightToLeft.Tag = System.Windows.Forms.FlowDirection.RightToLeft
            '
            'biBottomUp
            '
            Me.biBottomUp.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biBottomUp.Caption = "Bottom Up"
            Me.biBottomUp.Glyph = CType(resources.GetObject("biBottomUp.Glyph"), System.Drawing.Image)
            Me.biBottomUp.GroupIndex = 2
            Me.biBottomUp.Id = 6
            Me.biBottomUp.LargeGlyph = CType(resources.GetObject("biBottomUp.LargeGlyph"), System.Drawing.Image)
            Me.biBottomUp.Name = "biBottomUp"
            Me.biBottomUp.Tag = System.Windows.Forms.FlowDirection.BottomUp
            '
            'biTopDown
            '
            Me.biTopDown.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biTopDown.Caption = "Top Down"
            Me.biTopDown.Glyph = CType(resources.GetObject("biTopDown.Glyph"), System.Drawing.Image)
            Me.biTopDown.GroupIndex = 2
            Me.biTopDown.Id = 7
            Me.biTopDown.LargeGlyph = CType(resources.GetObject("biTopDown.LargeGlyph"), System.Drawing.Image)
            Me.biTopDown.Name = "biTopDown"
            Me.biTopDown.Tag = System.Windows.Forms.FlowDirection.TopDown
            '
            'BarCheckItem1
            '
            Me.BarCheckItem1.BindableChecked = True
            Me.BarCheckItem1.Caption = "Colored Widgets"
            Me.BarCheckItem1.Checked = True
            Me.BarCheckItem1.Glyph = CType(resources.GetObject("BarCheckItem1.Glyph"), System.Drawing.Image)
            Me.BarCheckItem1.Id = 8
            Me.BarCheckItem1.LargeGlyph = CType(resources.GetObject("BarCheckItem1.LargeGlyph"), System.Drawing.Image)
            Me.BarCheckItem1.Name = "BarCheckItem1"
            '
            'biFreeMode
            '
            Me.biFreeMode.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biFreeMode.Caption = "Free Layout"
            Me.biFreeMode.Down = True
            Me.biFreeMode.Glyph = CType(resources.GetObject("biFreeMode.Glyph"), System.Drawing.Image)
            Me.biFreeMode.GroupIndex = 1
            Me.biFreeMode.Id = 9
            Me.biFreeMode.LargeGlyph = CType(resources.GetObject("biFreeMode.LargeGlyph"), System.Drawing.Image)
            Me.biFreeMode.Name = "biFreeMode"
            Me.biFreeMode.Tag = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FreeLayout
            '
            'biDragMode
            '
            Me.biDragMode.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biDragMode.Caption = "Outer Dragging"
            Me.biDragMode.Id = 10
            Me.biDragMode.Name = "biDragMode"
            '
            'rpSettings
            '
            Me.rpSettings.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.pgLayoutMode, Me.pgFlowDirection, Me.pgMixAction, Me.RibbonPageGroup1})
            Me.rpSettings.Name = "rpSettings"
            Me.rpSettings.Text = "Widget view settings"
            '
            'pgLayoutMode
            '
            Me.pgLayoutMode.ItemLinks.Add(Me.biFlowMode)
            Me.pgLayoutMode.ItemLinks.Add(Me.biStackedMode)
            Me.pgLayoutMode.ItemLinks.Add(Me.biTableMode)
            Me.pgLayoutMode.ItemLinks.Add(Me.biFreeMode)
            Me.pgLayoutMode.Name = "pgLayoutMode"
            Me.pgLayoutMode.Text = "Layout Mode"
            '
            'pgFlowDirection
            '
            Me.pgFlowDirection.ItemLinks.Add(Me.biLeftToRight)
            Me.pgFlowDirection.ItemLinks.Add(Me.biRightToLeft)
            Me.pgFlowDirection.ItemLinks.Add(Me.biBottomUp)
            Me.pgFlowDirection.ItemLinks.Add(Me.biTopDown)
            Me.pgFlowDirection.Name = "pgFlowDirection"
            Me.pgFlowDirection.Text = "Flow Direction"
            '
            'pgMixAction
            '
            Me.pgMixAction.AllowTextClipping = False
            Me.pgMixAction.ItemLinks.Add(Me.biItemMixer)
            Me.pgMixAction.ItemLinks.Add(Me.biDragMode)
            Me.pgMixAction.Name = "pgMixAction"
            Me.pgMixAction.Text = "View Actions"
            '
            'biItemMixer
            '
            Me.biItemMixer.Caption = "Mix"
            Me.biItemMixer.Glyph = CType(resources.GetObject("biItemMixer.Glyph"), System.Drawing.Image)
            Me.biItemMixer.Id = 18
            Me.biItemMixer.LargeGlyph = CType(resources.GetObject("biItemMixer.LargeGlyph"), System.Drawing.Image)
            Me.biItemMixer.Name = "biItemMixer"
            '
            'RibbonPageGroup1
            '
            Me.RibbonPageGroup1.AllowTextClipping = False
            Me.RibbonPageGroup1.ItemLinks.Add(Me.BarCheckItem1)
            Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
            Me.RibbonPageGroup1.Text = "Appearance"
            '
            'StackGroup1
            '
            Me.StackGroup1.Caption = "Daily Events"
            Me.StackGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.weatherDocument, Me.newsDocument})
            Me.StackGroup1.Length.UnitValue = 1.5R
            '
            'StackGroup2
            '
            Me.StackGroup2.Caption = "Work"
            Me.StackGroup2.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.calendarDocument, Me.mailDocument})
            '
            'StackGroup3
            '
            Me.StackGroup3.Caption = "Organizer"
            Me.StackGroup3.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.dateTimeDocument, Me.tradingDocument})
            '
            'DashboardWidgets
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "DashboardWidgets"
            Me.Size = New System.Drawing.Size(924, 576)
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.widgetView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.calendarDocument, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateTimeDocument, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mailDocument, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.weatherDocument, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.newsDocument, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tradingDocument, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RowDefinition1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RowDefinition2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RowDefinition3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ColumnDefinition1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ColumnDefinition2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ColumnDefinition3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StackGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StackGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StackGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
        Private WithEvents widgetView1 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView
        Private calendarDocument As DevExpress.XtraBars.Docking2010.Views.Widget.Document
        Private dateTimeDocument As DevExpress.XtraBars.Docking2010.Views.Widget.Document
        Private mailDocument As DevExpress.XtraBars.Docking2010.Views.Widget.Document
        Private weatherDocument As DevExpress.XtraBars.Docking2010.Views.Widget.Document
        Private newsDocument As DevExpress.XtraBars.Docking2010.Views.Widget.Document
        Private tradingDocument As DevExpress.XtraBars.Docking2010.Views.Widget.Document
        Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
        Private rpSettings As XtraBars.Ribbon.RibbonPage
        Private pgLayoutMode As XtraBars.Ribbon.RibbonPageGroup
        Private pgFlowDirection As XtraBars.Ribbon.RibbonPageGroup
        Private WithEvents biItemMixer As XtraBars.BarButtonItem
        Private pgMixAction As XtraBars.Ribbon.RibbonPageGroup
        Friend WithEvents biFlowMode As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents biStackedMode As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents biTableMode As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents biLeftToRight As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents biRightToLeft As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents biBottomUp As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents biTopDown As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
        Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Friend WithEvents biFreeMode As XtraBars.BarButtonItem
        Friend WithEvents biDragMode As XtraBars.BarButtonItem
        Friend WithEvents ColumnDefinition1 As ColumnDefinition
        Friend WithEvents ColumnDefinition2 As ColumnDefinition
        Friend WithEvents ColumnDefinition3 As ColumnDefinition
        Friend WithEvents RowDefinition1 As RowDefinition
        Friend WithEvents RowDefinition2 As RowDefinition
        Friend WithEvents RowDefinition3 As RowDefinition
        Friend WithEvents StackGroup1 As StackGroup
        Friend WithEvents StackGroup2 As StackGroup
        Friend WithEvents StackGroup3 As StackGroup
    End Class
End Namespace
