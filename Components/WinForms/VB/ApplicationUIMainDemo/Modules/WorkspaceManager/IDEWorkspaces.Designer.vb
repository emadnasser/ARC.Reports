Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class IDEWorkspaces
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(IDEWorkspaces))
            Dim combTransition1 As New DevExpress.Utils.Animation.CombTransition()
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
            Me.barWorkspaceMenuItem1 = New DevExpress.XtraBars.BarWorkspaceMenuItem()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
            Me.toolboxImages = New System.Windows.Forms.ImageList(Me.components)
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.ucSolutionExplorer1 = New DevExpress.ApplicationUI.Demos.ucSolutionExplorer()
            Me.dockPanel4 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel4_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.ucOutput1 = New DevExpress.ApplicationUI.Demos.ucOutput()
            Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.documentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.document2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.document3 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.workspaceManager1 = New DevExpress.Utils.WorkspaceManager()
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelContainer1.SuspendLayout()
            Me.dockPanel3.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            Me.dockPanel4.SuspendLayout()
            Me.dockPanel4_Container.SuspendLayout()
            CType(Me.tabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.documentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.document3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentManager1
            ' 
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.MenuManager = Me.barManager1
            Me.documentManager1.View = Me.tabbedView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tabbedView1})
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.DockManager = Me.dockManager1
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5, Me.barButtonItem6, Me.barButtonItem7, Me.barButtonItem8, Me.barButtonItem9, Me.barButtonItem10, Me.barButtonItem11, Me.barButtonItem12, Me.barButtonItem13, Me.barWorkspaceMenuItem1})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 15
            Me.barManager1.StatusBar = Me.bar3
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 1
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem5),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem6),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem7),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem8, True),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem9, True),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem10),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem11),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem12, True),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem13)
            })
            Me.bar1.Text = "Tools"
            ' 
            ' barButtonItem5
            ' 
            Me.barButtonItem5.Caption = "New File"
            Me.barButtonItem5.Glyph = (CType(resources.GetObject("barButtonItem5.Glyph"), System.Drawing.Image))
            Me.barButtonItem5.Id = 4
            Me.barButtonItem5.LargeGlyph = (CType(resources.GetObject("barButtonItem5.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem5.Name = "barButtonItem5"
            ' 
            ' barButtonItem6
            ' 
            Me.barButtonItem6.Caption = "Open"
            Me.barButtonItem6.Glyph = (CType(resources.GetObject("barButtonItem6.Glyph"), System.Drawing.Image))
            Me.barButtonItem6.Id = 5
            Me.barButtonItem6.LargeGlyph = (CType(resources.GetObject("barButtonItem6.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem6.Name = "barButtonItem6"
            ' 
            ' barButtonItem7
            ' 
            Me.barButtonItem7.Caption = "Save"
            Me.barButtonItem7.Glyph = (CType(resources.GetObject("barButtonItem7.Glyph"), System.Drawing.Image))
            Me.barButtonItem7.Id = 6
            Me.barButtonItem7.LargeGlyph = (CType(resources.GetObject("barButtonItem7.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem7.Name = "barButtonItem7"
            ' 
            ' barButtonItem8
            ' 
            Me.barButtonItem8.Caption = "Print"
            Me.barButtonItem8.Glyph = (CType(resources.GetObject("barButtonItem8.Glyph"), System.Drawing.Image))
            Me.barButtonItem8.Id = 7
            Me.barButtonItem8.LargeGlyph = (CType(resources.GetObject("barButtonItem8.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem8.Name = "barButtonItem8"
            ' 
            ' barButtonItem9
            ' 
            Me.barButtonItem9.Caption = "Cut"
            Me.barButtonItem9.Glyph = (CType(resources.GetObject("barButtonItem9.Glyph"), System.Drawing.Image))
            Me.barButtonItem9.Id = 8
            Me.barButtonItem9.LargeGlyph = (CType(resources.GetObject("barButtonItem9.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem9.Name = "barButtonItem9"
            ' 
            ' barButtonItem10
            ' 
            Me.barButtonItem10.Caption = "Copy"
            Me.barButtonItem10.Glyph = (CType(resources.GetObject("barButtonItem10.Glyph"), System.Drawing.Image))
            Me.barButtonItem10.Id = 9
            Me.barButtonItem10.LargeGlyph = (CType(resources.GetObject("barButtonItem10.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem10.Name = "barButtonItem10"
            ' 
            ' barButtonItem11
            ' 
            Me.barButtonItem11.Caption = "Paste"
            Me.barButtonItem11.Glyph = (CType(resources.GetObject("barButtonItem11.Glyph"), System.Drawing.Image))
            Me.barButtonItem11.Id = 10
            Me.barButtonItem11.LargeGlyph = (CType(resources.GetObject("barButtonItem11.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem11.Name = "barButtonItem11"
            ' 
            ' barButtonItem12
            ' 
            Me.barButtonItem12.Caption = "Undo"
            Me.barButtonItem12.Glyph = (CType(resources.GetObject("barButtonItem12.Glyph"), System.Drawing.Image))
            Me.barButtonItem12.Id = 11
            Me.barButtonItem12.LargeGlyph = (CType(resources.GetObject("barButtonItem12.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem12.Name = "barButtonItem12"
            ' 
            ' barButtonItem13
            ' 
            Me.barButtonItem13.Caption = "Redo"
            Me.barButtonItem13.Glyph = (CType(resources.GetObject("barButtonItem13.Glyph"), System.Drawing.Image))
            Me.barButtonItem13.Id = 12
            Me.barButtonItem13.LargeGlyph = (CType(resources.GetObject("barButtonItem13.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem13.Name = "barButtonItem13"
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem4),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barWorkspaceMenuItem1)
            })
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "File"
            Me.barButtonItem1.Id = 0
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "Edit"
            Me.barButtonItem2.Id = 1
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "Toolbars"
            Me.barButtonItem3.Id = 2
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' barButtonItem4
            ' 
            Me.barButtonItem4.Caption = "Help"
            Me.barButtonItem4.Id = 3
            Me.barButtonItem4.Name = "barButtonItem4"
            ' 
            ' barWorkspaceMenuItem1
            ' 
            Me.barWorkspaceMenuItem1.Caption = "Workspaces"
            Me.barWorkspaceMenuItem1.Id = 14
            Me.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1"
            Me.barWorkspaceMenuItem1.ShowSaveLoadCommands = True
            ' 
            ' bar3
            ' 
            Me.bar3.BarName = "Status bar"
            Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar3.DockCol = 0
            Me.bar3.DockRow = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar3.OptionsBar.AllowQuickCustomization = False
            Me.bar3.OptionsBar.DrawDragBorder = False
            Me.bar3.OptionsBar.UseWholeRow = True
            Me.bar3.Text = "Status bar"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(914, 53)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 505)
            Me.barDockControlBottom.Size = New System.Drawing.Size(914, 23)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 53)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 452)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(914, 53)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 452)
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.Form = Me
            Me.dockManager1.MenuManager = Me.barManager1
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1, Me.panelContainer1, Me.dockPanel4})
            Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.ID = New System.Guid("1c0462cd-5b46-461e-80af-99fd4075d170")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 53)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel1.Size = New System.Drawing.Size(200, 452)
            Me.dockPanel1.Text = "Toolbox"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Controls.Add(Me.navBarControl1)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(192, 425)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' navBarControl1
            ' 
            Me.navBarControl1.ActiveGroup = Nothing
            Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navBarControl1.Location = New System.Drawing.Point(0, 0)
            Me.navBarControl1.Name = "navBarControl1"
            Me.navBarControl1.OptionsNavPane.ExpandedWidth = 192
            Me.navBarControl1.Size = New System.Drawing.Size(192, 425)
            Me.navBarControl1.SmallImages = Me.toolboxImages
            Me.navBarControl1.TabIndex = 0
            Me.navBarControl1.Text = "navBarControl1"
            ' 
            ' toolboxImages
            ' 
            Me.toolboxImages.ImageStream = (CType(resources.GetObject("toolboxImages.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.toolboxImages.TransparentColor = System.Drawing.Color.Magenta
            Me.toolboxImages.Images.SetKeyName(0, "Label_684.png")
            Me.toolboxImages.Images.SetKeyName(1, "Button_668.png")
            Me.toolboxImages.Images.SetKeyName(2, "CheckBox_669.png")
            Me.toolboxImages.Images.SetKeyName(3, "RadioButton_701.png")
            Me.toolboxImages.Images.SetKeyName(4, "ComboBox_672.png")
            Me.toolboxImages.Images.SetKeyName(5, "ListBox_686.png")
            Me.toolboxImages.Images.SetKeyName(6, "CheckBoxList_727.png")
            Me.toolboxImages.Images.SetKeyName(7, "DataGrid_674.png")
            Me.toolboxImages.Images.SetKeyName(8, "ListView_687.png")
            Me.toolboxImages.Images.SetKeyName(9, "SplitterControl_705.png")
            Me.toolboxImages.Images.SetKeyName(10, "SplitContainerControl_704.png")
            Me.toolboxImages.Images.SetKeyName(11, "Panel_694.png")
            Me.toolboxImages.Images.SetKeyName(12, "TableLayoutPanel_6241.png")
            Me.toolboxImages.Images.SetKeyName(13, "GroupBox_680.png")
            Me.toolboxImages.Images.SetKeyName(14, "TabControl_707.png")
            Me.toolboxImages.Images.SetKeyName(15, "LabelControl_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(16, "SimpleButton_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(17, "CheckButton_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(18, "ToggleSwitch_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(19, "CheckEdit_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(20, "RadioGroup_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(21, "TextEdit_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(22, "MemoEdit_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(23, "ButtonEdit_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(24, "SpinEdit_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(25, "CalcEdit_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(26, "ColorEdit_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(27, "DateControl_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(28, "DateEdit_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(29, "TimeEdit_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(30, "LookUpEdit_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(31, "ListBoxControl_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(32, "PictureEdit_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(33, "RangeControl_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(34, "XtraTabControl_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(35, "BarManager_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(36, "DocumentManager_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(37, "PopupMenu_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(38, "RadialMenu_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(39, "TileControl_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(40, "GridControl_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(41, "GridLookUpEdit_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(42, "PdfViewer_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(43, "ChartControl_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(44, "SpreadsheetControl_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(45, "SchedulerControl_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(46, "PivotGridControl_DX.bmp")
            Me.toolboxImages.Images.SetKeyName(47, "MapControl_DX.bmp")
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.ActiveChild = Me.dockPanel3
            Me.panelContainer1.Controls.Add(Me.dockPanel2)
            Me.panelContainer1.Controls.Add(Me.dockPanel3)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.FloatVertical = True
            Me.panelContainer1.ID = New System.Guid("8ab18f1a-d5df-4d58-9923-6f9814a9b400")
            Me.panelContainer1.Location = New System.Drawing.Point(714, 53)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(200, 452)
            Me.panelContainer1.Tabbed = True
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' dockPanel3
            ' 
            Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
            Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel3.FloatVertical = True
            Me.dockPanel3.ID = New System.Guid("04633bdd-57dd-45b5-9dc8-8bf3ff5d3b72")
            Me.dockPanel3.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel3.Name = "dockPanel3"
            Me.dockPanel3.OriginalSize = New System.Drawing.Size(192, 385)
            Me.dockPanel3.Size = New System.Drawing.Size(192, 398)
            Me.dockPanel3.Text = "Properties"
            ' 
            ' dockPanel3_Container
            ' 
            Me.dockPanel3_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel3_Container.Name = "dockPanel3_Container"
            Me.dockPanel3_Container.Size = New System.Drawing.Size(192, 398)
            Me.dockPanel3_Container.TabIndex = 0
            ' 
            ' dockPanel2
            ' 
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel2.ID = New System.Guid("3eee2e6e-9350-48cb-83a6-d2e00e875502")
            Me.dockPanel2.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(192, 385)
            Me.dockPanel2.Size = New System.Drawing.Size(192, 398)
            Me.dockPanel2.Text = "Solution Explorer"
            ' 
            ' dockPanel2_Container
            ' 
            Me.dockPanel2_Container.Controls.Add(Me.ucSolutionExplorer1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(192, 398)
            Me.dockPanel2_Container.TabIndex = 0
            ' 
            ' ucSolutionExplorer1
            ' 
            Me.ucSolutionExplorer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucSolutionExplorer1.Location = New System.Drawing.Point(0, 0)
            Me.ucSolutionExplorer1.Name = "ucSolutionExplorer1"
            Me.ucSolutionExplorer1.Size = New System.Drawing.Size(192, 398)
            Me.ucSolutionExplorer1.TabIndex = 0
            ' 
            ' dockPanel4
            ' 
            Me.dockPanel4.Controls.Add(Me.dockPanel4_Container)
            Me.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.dockPanel4.ID = New System.Guid("9feb35bb-87cd-424f-81bc-9a242d36eb90")
            Me.dockPanel4.Location = New System.Drawing.Point(200, 305)
            Me.dockPanel4.Name = "dockPanel4"
            Me.dockPanel4.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel4.Size = New System.Drawing.Size(514, 200)
            Me.dockPanel4.Text = "Output"
            ' 
            ' dockPanel4_Container
            ' 
            Me.dockPanel4_Container.Controls.Add(Me.ucOutput1)
            Me.dockPanel4_Container.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel4_Container.Name = "dockPanel4_Container"
            Me.dockPanel4_Container.Size = New System.Drawing.Size(506, 173)
            Me.dockPanel4_Container.TabIndex = 0
            ' 
            ' ucOutput1
            ' 
            Me.ucOutput1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucOutput1.Location = New System.Drawing.Point(0, 0)
            Me.ucOutput1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.ucOutput1.Name = "ucOutput1"
            Me.ucOutput1.Size = New System.Drawing.Size(506, 173)
            Me.ucOutput1.TabIndex = 0
            ' 
            ' tabbedView1
            ' 
            Me.tabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.documentGroup1})
            Me.tabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.document1, Me.document2, Me.document3})
            ' 
            ' documentGroup1
            ' 
            Me.documentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.document1, Me.document2, Me.document3})
            ' 
            ' document1
            ' 
            Me.document1.Caption = "File.cs"
            Me.document1.ControlName = "document1"
            ' 
            ' document2
            ' 
            Me.document2.Caption = "ucToolBox.cs"
            Me.document2.ControlName = "document2"
            ' 
            ' document3
            ' 
            Me.document3.Caption = "ucMain.cs"
            Me.document3.ControlName = "document3"
            ' 
            ' workspaceManager1
            ' 
            Me.workspaceManager1.TargetControl = Me
            Me.workspaceManager1.TransitionType = combTransition1
            ' 
            ' IDEWorkspaces
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dockPanel4)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.dockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "IDEWorkspaces"
            Me.Size = New System.Drawing.Size(914, 528)
            CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelContainer1.ResumeLayout(False)
            Me.dockPanel3.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            Me.dockPanel4.ResumeLayout(False)
            Me.dockPanel4_Container.ResumeLayout(False)
            CType(Me.tabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.documentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.document3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private documentManager1 As XtraBars.Docking2010.DocumentManager
        Private panelContainer1 As XtraBars.Docking.DockPanel
        Private dockPanel2 As XtraBars.Docking.DockPanel
        Private dockPanel2_Container As XtraBars.Docking.ControlContainer
        Private dockPanel3 As XtraBars.Docking.DockPanel
        Private dockPanel3_Container As XtraBars.Docking.ControlContainer
        Private dockPanel1 As XtraBars.Docking.DockPanel
        Private dockPanel1_Container As XtraBars.Docking.ControlContainer
        Private barDockControlLeft As XtraBars.BarDockControl
        Private barDockControlRight As XtraBars.BarDockControl
        Private barDockControlBottom As XtraBars.BarDockControl
        Private barDockControlTop As XtraBars.BarDockControl
        Private barManager1 As XtraBars.BarManager
        Private bar1 As XtraBars.Bar
        Private barButtonItem5 As XtraBars.BarButtonItem
        Private barButtonItem6 As XtraBars.BarButtonItem
        Private barButtonItem7 As XtraBars.BarButtonItem
        Private barButtonItem8 As XtraBars.BarButtonItem
        Private barButtonItem9 As XtraBars.BarButtonItem
        Private barButtonItem10 As XtraBars.BarButtonItem
        Private barButtonItem11 As XtraBars.BarButtonItem
        Private barButtonItem12 As XtraBars.BarButtonItem
        Private barButtonItem13 As XtraBars.BarButtonItem
        Private bar2 As XtraBars.Bar
        Private barButtonItem1 As XtraBars.BarButtonItem
        Private barButtonItem2 As XtraBars.BarButtonItem
        Private barButtonItem3 As XtraBars.BarButtonItem
        Private barButtonItem4 As XtraBars.BarButtonItem
        Private bar3 As XtraBars.Bar
        Private dockManager1 As XtraBars.Docking.DockManager
        Private tabbedView1 As XtraBars.Docking2010.Views.Tabbed.TabbedView
        Private workspaceManager1 As Utils.WorkspaceManager
        Private toolboxImages As System.Windows.Forms.ImageList
        Private navBarControl1 As XtraNavBar.NavBarControl
        Private ucSolutionExplorer1 As ucSolutionExplorer
        Private documentGroup1 As XtraBars.Docking2010.Views.Tabbed.DocumentGroup
        Private document1 As XtraBars.Docking2010.Views.Tabbed.Document
        Private document2 As XtraBars.Docking2010.Views.Tabbed.Document
        Private document3 As XtraBars.Docking2010.Views.Tabbed.Document
        Private barWorkspaceMenuItem1 As XtraBars.BarWorkspaceMenuItem
        Private dockPanel4 As XtraBars.Docking.DockPanel
        Private dockPanel4_Container As XtraBars.Docking.ControlContainer
        Private ucOutput1 As ucOutput
    End Class
End Namespace
