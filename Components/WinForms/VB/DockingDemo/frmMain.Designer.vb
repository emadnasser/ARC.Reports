Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraBars.Demos.DockingDemo
	Partial Public Class frmMain
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.siFile = New DevExpress.XtraBars.BarSubItem()
            Me.siNew = New DevExpress.XtraBars.BarSubItem()
            Me.iFile = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.iProject = New DevExpress.XtraBars.BarButtonItem()
            Me.iBlankSolution = New DevExpress.XtraBars.BarButtonItem()
            Me.iOpen = New DevExpress.XtraBars.BarButtonItem()
            Me.iClose = New DevExpress.XtraBars.BarButtonItem()
            Me.iAddNewItem = New DevExpress.XtraBars.BarButtonItem()
            Me.iAddExistingItem = New DevExpress.XtraBars.BarButtonItem()
            Me.siAddProject = New DevExpress.XtraBars.BarSubItem()
            Me.iNewProject = New DevExpress.XtraBars.BarButtonItem()
            Me.iExistingProject = New DevExpress.XtraBars.BarButtonItem()
            Me.iOpenSolution = New DevExpress.XtraBars.BarButtonItem()
            Me.iCloseSolution = New DevExpress.XtraBars.BarButtonItem()
            Me.iSaveAll = New DevExpress.XtraBars.BarButtonItem()
            Me.iPageSetup = New DevExpress.XtraBars.BarButtonItem()
            Me.iPrint = New DevExpress.XtraBars.BarButtonItem()
            Me.iExit = New DevExpress.XtraBars.BarButtonItem()
            Me.siEdit = New DevExpress.XtraBars.BarSubItem()
            Me.siFind = New DevExpress.XtraBars.BarSubItem()
            Me.iFind = New DevExpress.XtraBars.BarButtonItem()
            Me.iReplace = New DevExpress.XtraBars.BarButtonItem()
            Me.iFindinFiles = New DevExpress.XtraBars.BarButtonItem()
            Me.siLayouts = New DevExpress.XtraBars.BarSubItem()
            Me.iLoadLayout = New DevExpress.XtraBars.BarButtonItem()
            Me.iSaveLayout = New DevExpress.XtraBars.BarButtonItem()
            Me.siWindow = New DevExpress.XtraBars.BarSubItem()
            Me.iPaintStyle = New DevExpress.XtraBars.BarSubItem()
            Me.barDockingMenuItem1 = New DevExpress.XtraBars.BarDockingMenuItem()
            Me.bsiHelp = New DevExpress.XtraBars.BarSubItem()
            Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.iNew = New DevExpress.XtraBars.BarButtonItem()
            Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.iOpenFile = New DevExpress.XtraBars.BarButtonItem()
            Me.iSave = New DevExpress.XtraBars.BarButtonItem()
            Me.iStart = New DevExpress.XtraBars.BarButtonItem()
            Me.eConfiguration = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.eFind = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.iSolutionExplorer = New DevExpress.XtraBars.BarButtonItem()
            Me.iProperties = New DevExpress.XtraBars.BarButtonItem()
            Me.iToolbox = New DevExpress.XtraBars.BarButtonItem()
            Me.iClassView = New DevExpress.XtraBars.BarButtonItem()
            Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
            Me.treeView1 = New DevExpress.XtraTreeList.TreeList()
            Me.classViewImages = New System.Windows.Forms.ImageList(Me.components)
            Me.iTaskList = New DevExpress.XtraBars.BarButtonItem()
            Me.iFindResults = New DevExpress.XtraBars.BarButtonItem()
            Me.iOutput = New DevExpress.XtraBars.BarButtonItem()
            Me.bar4 = New DevExpress.XtraBars.Bar()
            Me.iStatus1 = New DevExpress.XtraBars.BarStaticItem()
            Me.bar5 = New DevExpress.XtraBars.Bar()
            Me.bar6 = New DevExpress.XtraBars.Bar()
            Me.barAndDockingController = New DevExpress.XtraBars.BarAndDockingController(Me.components)
            Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
            Me.dockPanel6 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel6_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.ucToolbox1 = New DevExpress.XtraBars.Demos.DockingDemo.ucToolbox()
            Me.mainMenuImages = New System.Windows.Forms.ImageList(Me.components)
            Me.panelContainer2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel5 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel5_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.ucOutput1 = New DevExpress.XtraBars.Demos.DockingDemo.ucOutput()
            Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.ucTaskList1 = New DevExpress.XtraBars.Demos.DockingDemo.ucTaskList()
            Me.dockPanel4 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel4_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.textBox1 = New DevExpress.XtraEditors.MemoEdit()
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.solutionExplorer = New DevExpress.XtraBars.Demos.DockingDemo.ucSolutionExplorer()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.ucProperties1 = New DevExpress.XtraBars.Demos.DockingDemo.ucProperties()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.fileTypeImages = New System.Windows.Forms.ImageList(Me.components)
            Me.AdornerUIManager1 = New DevExpress.Utils.VisualEffects.AdornerUIManager(Me.components)
            Me.Badge1 = New DevExpress.Utils.VisualEffects.Badge()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer1.SuspendLayout()
            CType(Me.treeView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barAndDockingController, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hideContainerLeft.SuspendLayout()
            Me.dockPanel6.SuspendLayout()
            Me.dockPanel6_Container.SuspendLayout()
            Me.panelContainer2.SuspendLayout()
            Me.dockPanel5.SuspendLayout()
            Me.dockPanel5_Container.SuspendLayout()
            Me.dockPanel3.SuspendLayout()
            Me.dockPanel3_Container.SuspendLayout()
            Me.dockPanel4.SuspendLayout()
            Me.dockPanel4_Container.SuspendLayout()
            CType(Me.textBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelContainer1.SuspendLayout()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.documentManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AdornerUIManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3, Me.bar4, Me.bar5, Me.bar6})
            Me.barManager.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("Built-in Menus", New System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2")), New DevExpress.XtraBars.BarManagerCategory("File", New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")), New DevExpress.XtraBars.BarManagerCategory("Edit", New System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe")), New DevExpress.XtraBars.BarManagerCategory("Standard", New System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b")), New DevExpress.XtraBars.BarManagerCategory("View", New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")), New DevExpress.XtraBars.BarManagerCategory("Window", New System.Guid("faa74de1-bd23-44b9-955d-6ba635fa0f01")), New DevExpress.XtraBars.BarManagerCategory("Status", New System.Guid("d3532f9f-c716-4c40-8731-d110e1a41e64")), New DevExpress.XtraBars.BarManagerCategory("Layouts", New System.Guid("f2b2eae8-5b98-43eb-81aa-d999b20fd3d3")), New DevExpress.XtraBars.BarManagerCategory("PaintStyles", New System.Guid("d0a113b2-425b-47f5-a6b5-0aefb1859507"))})
            Me.barManager.Controller = Me.barAndDockingController
            Me.barManager.DockControls.Add(Me.barDockControl1)
            Me.barManager.DockControls.Add(Me.barDockControl2)
            Me.barManager.DockControls.Add(Me.barDockControl3)
            Me.barManager.DockControls.Add(Me.barDockControl4)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Images = Me.mainMenuImages
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.siFile, Me.siEdit, Me.siNew, Me.iOpen, Me.iClose, Me.iProject, Me.iFile, Me.iBlankSolution, Me.iAddNewItem, Me.iAddExistingItem, Me.siAddProject, Me.iNewProject, Me.iExistingProject, Me.iSaveAll, Me.iOpenSolution, Me.iCloseSolution, Me.iPageSetup, Me.iPrint, Me.iExit, Me.siFind, Me.iFind, Me.iReplace, Me.iFindinFiles, Me.iNew, Me.iOpenFile, Me.iSave, Me.iStart, Me.eConfiguration, Me.eFind, Me.iSolutionExplorer, Me.iProperties, Me.iToolbox, Me.iClassView, Me.iTaskList, Me.iFindResults, Me.iOutput, Me.siWindow, Me.iStatus1, Me.iLoadLayout, Me.iSaveLayout, Me.siLayouts, Me.iPaintStyle, Me.barDockingMenuItem1, Me.bsiHelp, Me.iAbout, Me.barButtonItem1})
            Me.barManager.MainMenu = Me.bar1
            Me.barManager.MaxItemId = 76
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryImageComboBox1, Me.repositoryItemComboBox1, Me.repositoryItemImageComboBox1})
            Me.barManager.StatusBar = Me.bar4
            '
            'bar1
            '
            Me.bar1.BarName = "MainMenu"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(92, 126)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.siFile), New DevExpress.XtraBars.LinkPersistInfo(Me.siEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.siLayouts), New DevExpress.XtraBars.LinkPersistInfo(Me.siWindow), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiHelp)})
            Me.bar1.OptionsBar.AllowQuickCustomization = False
            Me.bar1.OptionsBar.DrawDragBorder = False
            Me.bar1.OptionsBar.MultiLine = True
            Me.bar1.OptionsBar.UseWholeRow = True
            Me.bar1.Text = "MainMenu"
            '
            'siFile
            '
            Me.siFile.Caption = "&File"
            Me.siFile.CategoryGuid = New System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2")
            Me.siFile.Id = 0
            Me.siFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.siNew), New DevExpress.XtraBars.LinkPersistInfo(Me.iOpen), New DevExpress.XtraBars.LinkPersistInfo(Me.iClose), New DevExpress.XtraBars.LinkPersistInfo(Me.iAddNewItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iAddExistingItem), New DevExpress.XtraBars.LinkPersistInfo(Me.siAddProject), New DevExpress.XtraBars.LinkPersistInfo(Me.iOpenSolution, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iCloseSolution), New DevExpress.XtraBars.LinkPersistInfo(Me.iSaveAll, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, Me.iPageSetup, "", True, False, True, 0), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, Me.iPrint, "", False, False, True, 0), New DevExpress.XtraBars.LinkPersistInfo(Me.iExit, True)})
            Me.siFile.Name = "siFile"
            '
            'siNew
            '
            Me.siNew.Caption = "&New"
            Me.siNew.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.siNew.Id = 2
            Me.siNew.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iFile), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.iProject), New DevExpress.XtraBars.LinkPersistInfo(Me.iBlankSolution)})
            Me.siNew.Name = "siNew"
            '
            'iFile
            '
            Me.iFile.Caption = "&File..."
            Me.iFile.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iFile.Hint = "New File"
            Me.iFile.Id = 6
            Me.iFile.ImageIndex = 1
            Me.iFile.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
            Me.iFile.Name = "iFile"
            '
            'barButtonItem1
            '
            Me.barButtonItem1.Caption = "Web Site..."
            Me.barButtonItem1.Id = 75
            Me.barButtonItem1.ImageIndex = 37
            Me.barButtonItem1.Name = "barButtonItem1"
            '
            'iProject
            '
            Me.iProject.Caption = "Team &Project..."
            Me.iProject.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iProject.Hint = "New Project"
            Me.iProject.Id = 5
            Me.iProject.ImageIndex = 0
            Me.iProject.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.N))
            Me.iProject.Name = "iProject"
            '
            'iBlankSolution
            '
            Me.iBlankSolution.Caption = "&Blank Solution..."
            Me.iBlankSolution.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iBlankSolution.Hint = "Blank Solution"
            Me.iBlankSolution.Id = 7
            Me.iBlankSolution.ImageIndex = 2
            Me.iBlankSolution.Name = "iBlankSolution"
            '
            'iOpen
            '
            Me.iOpen.Caption = "&Open"
            Me.iOpen.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iOpen.Id = 3
            Me.iOpen.Name = "iOpen"
            '
            'iClose
            '
            Me.iClose.Caption = "&Close"
            Me.iClose.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iClose.Id = 4
            Me.iClose.Name = "iClose"
            '
            'iAddNewItem
            '
            Me.iAddNewItem.Caption = "Add Ne&w Item..."
            Me.iAddNewItem.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iAddNewItem.Hint = "Add New Item"
            Me.iAddNewItem.Id = 8
            Me.iAddNewItem.ImageIndex = 3
            Me.iAddNewItem.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.A))
            Me.iAddNewItem.Name = "iAddNewItem"
            '
            'iAddExistingItem
            '
            Me.iAddExistingItem.Caption = "Add Existin&g Item..."
            Me.iAddExistingItem.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iAddExistingItem.Id = 9
            Me.iAddExistingItem.ImageIndex = 4
            Me.iAddExistingItem.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.B))
            Me.iAddExistingItem.Name = "iAddExistingItem"
            '
            'siAddProject
            '
            Me.siAddProject.Caption = "A&dd Project"
            Me.siAddProject.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.siAddProject.Id = 10
            Me.siAddProject.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iNewProject), New DevExpress.XtraBars.LinkPersistInfo(Me.iExistingProject)})
            Me.siAddProject.Name = "siAddProject"
            '
            'iNewProject
            '
            Me.iNewProject.Caption = "&New Project..."
            Me.iNewProject.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iNewProject.Hint = "New Project"
            Me.iNewProject.Id = 11
            Me.iNewProject.Name = "iNewProject"
            '
            'iExistingProject
            '
            Me.iExistingProject.Caption = "&Existing Project..."
            Me.iExistingProject.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iExistingProject.Id = 12
            Me.iExistingProject.Name = "iExistingProject"
            '
            'iOpenSolution
            '
            Me.iOpenSolution.Caption = "Op&en Solution..."
            Me.iOpenSolution.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iOpenSolution.Id = 14
            Me.iOpenSolution.ImageIndex = 5
            Me.iOpenSolution.Name = "iOpenSolution"
            '
            'iCloseSolution
            '
            Me.iCloseSolution.Caption = "Close Solu&tion"
            Me.iCloseSolution.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iCloseSolution.Id = 15
            Me.iCloseSolution.ImageIndex = 6
            Me.iCloseSolution.Name = "iCloseSolution"
            '
            'iSaveAll
            '
            Me.iSaveAll.Caption = "Save A&ll"
            Me.iSaveAll.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iSaveAll.Enabled = False
            Me.iSaveAll.Hint = "Save All"
            Me.iSaveAll.Id = 13
            Me.iSaveAll.ImageIndex = 7
            Me.iSaveAll.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.S))
            Me.iSaveAll.Name = "iSaveAll"
            '
            'iPageSetup
            '
            Me.iPageSetup.Caption = "Page Set&up..."
            Me.iPageSetup.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iPageSetup.Id = 16
            Me.iPageSetup.ImageIndex = 8
            Me.iPageSetup.Name = "iPageSetup"
            '
            'iPrint
            '
            Me.iPrint.Caption = "&Print..."
            Me.iPrint.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iPrint.Id = 17
            Me.iPrint.ImageIndex = 9
            Me.iPrint.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
            Me.iPrint.Name = "iPrint"
            '
            'iExit
            '
            Me.iExit.Caption = "E&xit"
            Me.iExit.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iExit.Id = 18
            Me.iExit.Name = "iExit"
            '
            'siEdit
            '
            Me.siEdit.Caption = "&Edit"
            Me.siEdit.CategoryGuid = New System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2")
            Me.siEdit.Id = 1
            Me.siEdit.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.siFind, True)})
            Me.siEdit.Name = "siEdit"
            '
            'siFind
            '
            Me.siFind.Caption = "&Find and Replace"
            Me.siFind.CategoryGuid = New System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe")
            Me.siFind.Id = 27
            Me.siFind.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iFind), New DevExpress.XtraBars.LinkPersistInfo(Me.iReplace), New DevExpress.XtraBars.LinkPersistInfo(Me.iFindinFiles)})
            Me.siFind.Name = "siFind"
            '
            'iFind
            '
            Me.iFind.Caption = "&Find"
            Me.iFind.CategoryGuid = New System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe")
            Me.iFind.Id = 28
            Me.iFind.ImageIndex = 16
            Me.iFind.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
            Me.iFind.Name = "iFind"
            '
            'iReplace
            '
            Me.iReplace.Caption = "R&eplace"
            Me.iReplace.CategoryGuid = New System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe")
            Me.iReplace.Id = 29
            Me.iReplace.ImageIndex = 17
            Me.iReplace.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H))
            Me.iReplace.Name = "iReplace"
            '
            'iFindinFiles
            '
            Me.iFindinFiles.Caption = "F&ind in Files"
            Me.iFindinFiles.CategoryGuid = New System.Guid("ac82dbe7-c530-4aa2-b6de-94a7777426fe")
            Me.iFindinFiles.Hint = "Find in Files"
            Me.iFindinFiles.Id = 30
            Me.iFindinFiles.ImageIndex = 18
            Me.iFindinFiles.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.F))
            Me.iFindinFiles.Name = "iFindinFiles"
            '
            'siLayouts
            '
            Me.siLayouts.Caption = "&Layouts"
            Me.siLayouts.CategoryGuid = New System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2")
            Me.siLayouts.Id = 49
            Me.siLayouts.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iLoadLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.iSaveLayout)})
            Me.siLayouts.Name = "siLayouts"
            '
            'iLoadLayout
            '
            Me.iLoadLayout.Caption = "&Load Layout..."
            Me.iLoadLayout.CategoryGuid = New System.Guid("f2b2eae8-5b98-43eb-81aa-d999b20fd3d3")
            Me.iLoadLayout.Hint = "Load Layout"
            Me.iLoadLayout.Id = 47
            Me.iLoadLayout.ImageIndex = 35
            Me.iLoadLayout.Name = "iLoadLayout"
            '
            'iSaveLayout
            '
            Me.iSaveLayout.Caption = "&Save Layout..."
            Me.iSaveLayout.CategoryGuid = New System.Guid("f2b2eae8-5b98-43eb-81aa-d999b20fd3d3")
            Me.iSaveLayout.Hint = "Save Layout"
            Me.iSaveLayout.Id = 48
            Me.iSaveLayout.ImageIndex = 34
            Me.iSaveLayout.Name = "iSaveLayout"
            '
            'siWindow
            '
            Me.siWindow.Caption = "&Window"
            Me.siWindow.CategoryGuid = New System.Guid("a984a9d9-f96f-425a-8857-fe4de6df48c2")
            Me.siWindow.Id = 45
            Me.siWindow.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iPaintStyle), New DevExpress.XtraBars.LinkPersistInfo(Me.barDockingMenuItem1)})
            Me.siWindow.Name = "siWindow"
            '
            'iPaintStyle
            '
            Me.iPaintStyle.Caption = "Paint Style"
            Me.iPaintStyle.CategoryGuid = New System.Guid("d0a113b2-425b-47f5-a6b5-0aefb1859507")
            Me.iPaintStyle.Id = 60
            Me.iPaintStyle.ItemAppearance.Normal.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
            Me.iPaintStyle.ItemAppearance.Normal.Options.UseFont = True
            Me.iPaintStyle.Name = "iPaintStyle"
            Me.iPaintStyle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'barDockingMenuItem1
            '
            Me.barDockingMenuItem1.Caption = "Window"
            Me.barDockingMenuItem1.Id = 72
            Me.barDockingMenuItem1.Name = "barDockingMenuItem1"
            '
            'bsiHelp
            '
            Me.bsiHelp.Caption = "&Help"
            Me.bsiHelp.Id = 73
            Me.bsiHelp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iAbout)})
            Me.bsiHelp.Name = "bsiHelp"
            '
            'iAbout
            '
            Me.iAbout.Caption = "&About"
            Me.iAbout.Id = 74
            Me.iAbout.ImageIndex = 36
            Me.iAbout.Name = "iAbout"
            '
            'bar2
            '
            Me.bar2.BarName = "Standard"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 1
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.FloatLocation = New System.Drawing.Point(38, 139)
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iNew), New DevExpress.XtraBars.LinkPersistInfo(Me.iAddNewItem), New DevExpress.XtraBars.LinkPersistInfo(Me.iOpenFile), New DevExpress.XtraBars.LinkPersistInfo(Me.iSave), New DevExpress.XtraBars.LinkPersistInfo(Me.iSaveAll), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.iStart, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.eConfiguration, "", False, True, True, 88), New DevExpress.XtraBars.LinkPersistInfo(Me.iFindinFiles, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.eFind, "", False, True, True, 97)})
            Me.bar2.Text = "Standard"
            '
            'iNew
            '
            Me.iNew.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.iNew.Caption = "New Project"
            Me.iNew.CategoryGuid = New System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b")
            Me.iNew.DropDownControl = Me.popupMenu1
            Me.iNew.Hint = "New Project"
            Me.iNew.Id = 31
            Me.iNew.ImageIndex = 10
            Me.iNew.Name = "iNew"
            '
            'popupMenu1
            '
            Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iProject), New DevExpress.XtraBars.LinkPersistInfo(Me.iFile), New DevExpress.XtraBars.LinkPersistInfo(Me.iBlankSolution)})
            Me.popupMenu1.Manager = Me.barManager
            Me.popupMenu1.Name = "popupMenu1"
            '
            'iOpenFile
            '
            Me.iOpenFile.Caption = "Open File"
            Me.iOpenFile.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iOpenFile.Hint = "Open File"
            Me.iOpenFile.Id = 32
            Me.iOpenFile.ImageIndex = 5
            Me.iOpenFile.Name = "iOpenFile"
            '
            'iSave
            '
            Me.iSave.Caption = "Save"
            Me.iSave.CategoryGuid = New System.Guid("ec880574-4d2a-4f26-8779-903acfad8a52")
            Me.iSave.Enabled = False
            Me.iSave.Hint = "Save"
            Me.iSave.Id = 33
            Me.iSave.ImageIndex = 21
            Me.iSave.Name = "iSave"
            '
            'iStart
            '
            Me.iStart.Caption = "Start"
            Me.iStart.CategoryGuid = New System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b")
            Me.iStart.Hint = "Start"
            Me.iStart.Id = 34
            Me.iStart.ImageIndex = 22
            Me.iStart.Name = "iStart"
            '
            'eConfiguration
            '
            Me.eConfiguration.Caption = "Solution Configuration"
            Me.eConfiguration.CategoryGuid = New System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b")
            Me.eConfiguration.Edit = Me.repositoryImageComboBox1
            Me.eConfiguration.EditValue = "Debug"
            Me.eConfiguration.Hint = "Solution Configuration"
            Me.eConfiguration.Id = 35
            Me.eConfiguration.Name = "eConfiguration"
            Me.eConfiguration.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            '
            'repositoryImageComboBox1
            '
            Me.repositoryImageComboBox1.AllowFocused = False
            Me.repositoryImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryImageComboBox1.Name = "repositoryImageComboBox1"
            '
            'eFind
            '
            Me.eFind.Caption = "Find"
            Me.eFind.CategoryGuid = New System.Guid("fbaaf85d-943d-4ccd-8517-fc398efe9c7b")
            Me.eFind.Edit = Me.repositoryItemComboBox1
            Me.eFind.Hint = "Find"
            Me.eFind.Id = 36
            Me.eFind.Name = "eFind"
            Me.eFind.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            '
            'repositoryItemComboBox1
            '
            Me.repositoryItemComboBox1.AllowFocused = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Items.AddRange(New Object() {"barManager1"})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            '
            'bar3
            '
            Me.bar3.BarName = "View"
            Me.bar3.DockCol = 2
            Me.bar3.DockRow = 1
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar3.FloatLocation = New System.Drawing.Point(36, 181)
            Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iSolutionExplorer), New DevExpress.XtraBars.LinkPersistInfo(Me.iProperties), New DevExpress.XtraBars.LinkPersistInfo(Me.iToolbox), New DevExpress.XtraBars.LinkPersistInfo(Me.iClassView), New DevExpress.XtraBars.LinkPersistInfo(Me.iTaskList, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iFindResults), New DevExpress.XtraBars.LinkPersistInfo(Me.iOutput)})
            Me.bar3.Offset = 400
            Me.bar3.Text = "View"
            '
            'iSolutionExplorer
            '
            Me.iSolutionExplorer.Caption = "Solution Ex&plorer"
            Me.iSolutionExplorer.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iSolutionExplorer.Hint = "Solution Explorer"
            Me.iSolutionExplorer.Id = 37
            Me.iSolutionExplorer.ImageIndex = 23
            Me.iSolutionExplorer.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.L))
            Me.iSolutionExplorer.Name = "iSolutionExplorer"
            '
            'iProperties
            '
            Me.iProperties.Caption = "Properties &Window"
            Me.iProperties.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iProperties.Hint = "Properties Window"
            Me.iProperties.Id = 38
            Me.iProperties.ImageIndex = 24
            Me.iProperties.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
            Me.iProperties.Name = "iProperties"
            '
            'iToolbox
            '
            Me.iToolbox.Caption = "Toolbo&x"
            Me.iToolbox.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iToolbox.Hint = "Toolbox"
            Me.iToolbox.Id = 39
            Me.iToolbox.ImageIndex = 25
            Me.iToolbox.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.X))
            Me.iToolbox.Name = "iToolbox"
            '
            'iClassView
            '
            Me.iClassView.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.iClassView.Caption = "Cl&ass View"
            Me.iClassView.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iClassView.DropDownControl = Me.popupControlContainer1
            Me.iClassView.Hint = "Class View"
            Me.iClassView.Id = 40
            Me.iClassView.ImageIndex = 26
            Me.iClassView.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.C))
            Me.iClassView.Name = "iClassView"
            '
            'popupControlContainer1
            '
            Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.popupControlContainer1.Controls.Add(Me.treeView1)
            Me.popupControlContainer1.Location = New System.Drawing.Point(52, 111)
            Me.popupControlContainer1.Manager = Me.barManager
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.ShowSizeGrip = True
            Me.popupControlContainer1.Size = New System.Drawing.Size(408, 231)
            Me.popupControlContainer1.TabIndex = 5
            Me.popupControlContainer1.Visible = False
            '
            'treeView1
            '
            Me.treeView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeView1.Location = New System.Drawing.Point(0, 0)
            Me.treeView1.Name = "treeView1"
            Me.treeView1.Size = New System.Drawing.Size(408, 231)
            Me.treeView1.StateImageList = Me.classViewImages
            Me.treeView1.TabIndex = 0
            '
            'classViewImages
            '
            Me.classViewImages.ImageStream = CType(resources.GetObject("classViewImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.classViewImages.TransparentColor = System.Drawing.Color.Magenta
            Me.classViewImages.Images.SetKeyName(0, "Solution_8308.png")
            Me.classViewImages.Images.SetKeyName(1, "ClassIcon.png")
            Me.classViewImages.Images.SetKeyName(2, "field_16xMD.png")
            Me.classViewImages.Images.SetKeyName(3, "Event_594.png")
            Me.classViewImages.Images.SetKeyName(4, "method_16xMD.png")
            Me.classViewImages.Images.SetKeyName(5, "Field-Private_545.png")
            Me.classViewImages.Images.SetKeyName(6, "Event-Private_598.png")
            Me.classViewImages.Images.SetKeyName(7, "Method-Private_640.png")
            Me.classViewImages.Images.SetKeyName(8, "Field-Protected_544.png")
            Me.classViewImages.Images.SetKeyName(9, "Event-Protected_597.png")
            Me.classViewImages.Images.SetKeyName(10, "Method-Protected_639.png")
            '
            'iTaskList
            '
            Me.iTaskList.Caption = "Task List"
            Me.iTaskList.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iTaskList.Hint = "Task List"
            Me.iTaskList.Id = 68
            Me.iTaskList.ImageIndex = 27
            Me.iTaskList.Name = "iTaskList"
            '
            'iFindResults
            '
            Me.iFindResults.Caption = "Find Results"
            Me.iFindResults.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iFindResults.Hint = "Find Results"
            Me.iFindResults.Id = 69
            Me.iFindResults.ImageIndex = 28
            Me.iFindResults.Name = "iFindResults"
            '
            'iOutput
            '
            Me.iOutput.Caption = "Output"
            Me.iOutput.CategoryGuid = New System.Guid("0cb4cc3e-4798-4d61-9457-672bdc2a90d4")
            Me.iOutput.Hint = "Output"
            Me.iOutput.Id = 70
            Me.iOutput.ImageIndex = 29
            Me.iOutput.Name = "iOutput"
            '
            'bar4
            '
            Me.bar4.BarName = "StatusBar"
            Me.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar4.DockCol = 0
            Me.bar4.DockRow = 0
            Me.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar4.FloatLocation = New System.Drawing.Point(25, 282)
            Me.bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iStatus1)})
            Me.bar4.OptionsBar.AllowQuickCustomization = False
            Me.bar4.OptionsBar.DrawDragBorder = False
            Me.bar4.OptionsBar.DrawSizeGrip = True
            Me.bar4.OptionsBar.RotateWhenVertical = False
            Me.bar4.OptionsBar.UseWholeRow = True
            Me.bar4.Text = "StatusBar"
            '
            'iStatus1
            '
            Me.iStatus1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.iStatus1.Caption = "Ready"
            Me.iStatus1.CategoryGuid = New System.Guid("d3532f9f-c716-4c40-8731-d110e1a41e64")
            Me.iStatus1.Id = 50
            Me.iStatus1.Name = "iStatus1"
            Me.iStatus1.TextAlignment = System.Drawing.StringAlignment.Near
            '
            'bar5
            '
            Me.bar5.BarName = "Layouts"
            Me.bar5.DockCol = 3
            Me.bar5.DockRow = 1
            Me.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar5.FloatLocation = New System.Drawing.Point(159, 118)
            Me.bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iLoadLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.iSaveLayout)})
            Me.bar5.Offset = 665
            Me.bar5.Text = "Layouts"
            '
            'bar6
            '
            Me.bar6.BarName = "Edit"
            Me.bar6.DockCol = 1
            Me.bar6.DockRow = 1
            Me.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar6.Offset = 391
            Me.bar6.OptionsBar.AllowRename = True
            Me.bar6.Text = "Common"
            '
            'barAndDockingController
            '
            Me.barAndDockingController.PaintStyleName = "Skin"
            Me.barAndDockingController.PropertiesBar.AllowLinkLighting = False
            Me.barAndDockingController.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
            Me.barAndDockingController.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
            '
            'barDockControl1
            '
            Me.barDockControl1.CausesValidation = False
            Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControl1.Location = New System.Drawing.Point(0, 0)
            Me.barDockControl1.Size = New System.Drawing.Size(1133, 53)
            '
            'barDockControl2
            '
            Me.barDockControl2.CausesValidation = False
            Me.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControl2.Location = New System.Drawing.Point(0, 637)
            Me.barDockControl2.Size = New System.Drawing.Size(1133, 25)
            '
            'barDockControl3
            '
            Me.barDockControl3.CausesValidation = False
            Me.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControl3.Location = New System.Drawing.Point(0, 53)
            Me.barDockControl3.Size = New System.Drawing.Size(0, 584)
            '
            'barDockControl4
            '
            Me.barDockControl4.CausesValidation = False
            Me.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControl4.Location = New System.Drawing.Point(1133, 53)
            Me.barDockControl4.Size = New System.Drawing.Size(0, 584)
            '
            'dockManager
            '
            Me.dockManager.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft})
            Me.dockManager.Controller = Me.barAndDockingController
            Me.dockManager.Form = Me
            Me.dockManager.Images = Me.mainMenuImages
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.panelContainer2, Me.panelContainer1})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar"})
            '
            'hideContainerLeft
            '
            Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
            Me.hideContainerLeft.Controls.Add(Me.dockPanel6)
            Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.hideContainerLeft.Location = New System.Drawing.Point(0, 53)
            Me.hideContainerLeft.Name = "hideContainerLeft"
            Me.hideContainerLeft.Size = New System.Drawing.Size(22, 584)
            '
            'dockPanel6
            '
            Me.dockPanel6.Controls.Add(Me.dockPanel6_Container)
            Me.dockPanel6.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel6.FloatSize = New System.Drawing.Size(146, 428)
            Me.dockPanel6.ID = New System.Guid("24977e30-0ea6-44aa-8fa4-9abaeb178b5e")
            Me.dockPanel6.ImageIndex = 25
            Me.dockPanel6.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel6.Name = "dockPanel6"
            Me.dockPanel6.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel6.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel6.SavedIndex = 2
            Me.dockPanel6.Size = New System.Drawing.Size(200, 584)
            Me.dockPanel6.Text = "Toolbox"
            Me.dockPanel6.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
            '
            'dockPanel6_Container
            '
            Me.dockPanel6_Container.Controls.Add(Me.ucToolbox1)
            Me.dockPanel6_Container.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel6_Container.Name = "dockPanel6_Container"
            Me.dockPanel6_Container.Size = New System.Drawing.Size(192, 557)
            Me.dockPanel6_Container.TabIndex = 0
            '
            'ucToolbox1
            '
            Me.ucToolbox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucToolbox1.Location = New System.Drawing.Point(0, 0)
            Me.ucToolbox1.Margin = New System.Windows.Forms.Padding(2)
            Me.ucToolbox1.Name = "ucToolbox1"
            Me.ucToolbox1.Size = New System.Drawing.Size(192, 557)
            Me.ucToolbox1.TabIndex = 0
            '
            'mainMenuImages
            '
            Me.mainMenuImages.ImageStream = CType(resources.GetObject("mainMenuImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.mainMenuImages.TransparentColor = System.Drawing.Color.Magenta
            Me.mainMenuImages.Images.SetKeyName(0, "NewTeamProject_7437_32.bmp")
            Me.mainMenuImages.Images.SetKeyName(1, "NewFile_6276.png")
            Me.mainMenuImages.Images.SetKeyName(2, "BlankApp_CPP_16x.png")
            Me.mainMenuImages.Images.SetKeyName(3, "AddNewItem_6273.png")
            Me.mainMenuImages.Images.SetKeyName(4, "AddExistingItem_6269.png")
            Me.mainMenuImages.Images.SetKeyName(5, "OpenFile.png")
            Me.mainMenuImages.Images.SetKeyName(6, "Close_6519.png")
            Me.mainMenuImages.Images.SetKeyName(7, "Saveall_6518.png")
            Me.mainMenuImages.Images.SetKeyName(8, "PrintSetup_11011.png")
            Me.mainMenuImages.Images.SetKeyName(9, "Print_11009.png")
            Me.mainMenuImages.Images.SetKeyName(10, "NewTeamProject_7437.png")
            Me.mainMenuImages.Images.SetKeyName(11, "Undo_16x16.png")
            Me.mainMenuImages.Images.SetKeyName(12, "Redo_16x16.png")
            Me.mainMenuImages.Images.SetKeyName(13, "Cut_16x16.png")
            Me.mainMenuImages.Images.SetKeyName(14, "Copy_16x16.png")
            Me.mainMenuImages.Images.SetKeyName(15, "Paste_16x16.png")
            Me.mainMenuImages.Images.SetKeyName(16, "Find_5650.png")
            Me.mainMenuImages.Images.SetKeyName(17, "")
            Me.mainMenuImages.Images.SetKeyName(18, "FindinFiles_6299.png")
            Me.mainMenuImages.Images.SetKeyName(19, "")
            Me.mainMenuImages.Images.SetKeyName(20, "Open_6529.png")
            Me.mainMenuImages.Images.SetKeyName(21, "Save_6530.png")
            Me.mainMenuImages.Images.SetKeyName(22, "StartDebugging_16x16.png")
            Me.mainMenuImages.Images.SetKeyName(23, "Solution_8308.png")
            Me.mainMenuImages.Images.SetKeyName(24, "properties_16xLG.png")
            Me.mainMenuImages.Images.SetKeyName(25, "toolbox_16xLG.png")
            Me.mainMenuImages.Images.SetKeyName(26, "class_16xLG.png")
            Me.mainMenuImages.Images.SetKeyName(27, "Task_16xLG.png")
            Me.mainMenuImages.Images.SetKeyName(28, "FindInFiles.png")
            Me.mainMenuImages.Images.SetKeyName(29, "Output.png")
            Me.mainMenuImages.Images.SetKeyName(30, "")
            Me.mainMenuImages.Images.SetKeyName(31, "")
            Me.mainMenuImages.Images.SetKeyName(32, "")
            Me.mainMenuImages.Images.SetKeyName(33, "")
            Me.mainMenuImages.Images.SetKeyName(34, "SaveFileDialogControl_703.png")
            Me.mainMenuImages.Images.SetKeyName(35, "OpenFileDialog_692.png")
            Me.mainMenuImages.Images.SetKeyName(36, "Information_blue_6227_16x16.png")
            Me.mainMenuImages.Images.SetKeyName(37, "NewWebSite_6288.png")
            '
            'panelContainer2
            '
            Me.panelContainer2.ActiveChild = Me.dockPanel5
            Me.panelContainer2.Controls.Add(Me.dockPanel3)
            Me.panelContainer2.Controls.Add(Me.dockPanel4)
            Me.panelContainer2.Controls.Add(Me.dockPanel5)
            Me.panelContainer2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.panelContainer2.FloatSize = New System.Drawing.Size(304, 139)
            Me.panelContainer2.ID = New System.Guid("ec7b92c0-cfe1-43c3-9ff0-c24e6320f016")
            Me.panelContainer2.Location = New System.Drawing.Point(22, 437)
            Me.panelContainer2.Name = "panelContainer2"
            Me.panelContainer2.OriginalSize = New System.Drawing.Size(200, 200)
            Me.panelContainer2.Size = New System.Drawing.Size(1111, 200)
            Me.panelContainer2.Tabbed = True
            Me.panelContainer2.Text = "panelContainer2"
            '
            'dockPanel5
            '
            Me.dockPanel5.Controls.Add(Me.dockPanel5_Container)
            Me.dockPanel5.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel5.FloatSize = New System.Drawing.Size(304, 139)
            Me.dockPanel5.ID = New System.Guid("dbdb0ba9-5443-476b-93ad-ec35678d61ef")
            Me.dockPanel5.ImageIndex = 29
            Me.dockPanel5.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel5.Name = "dockPanel5"
            Me.dockPanel5.OriginalSize = New System.Drawing.Size(1084, 145)
            Me.dockPanel5.Size = New System.Drawing.Size(1103, 145)
            Me.dockPanel5.Text = "Output"
            '
            'dockPanel5_Container
            '
            Me.dockPanel5_Container.Controls.Add(Me.ucOutput1)
            Me.dockPanel5_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel5_Container.Name = "dockPanel5_Container"
            Me.dockPanel5_Container.Size = New System.Drawing.Size(1103, 145)
            Me.dockPanel5_Container.TabIndex = 0
            '
            'ucOutput1
            '
            Me.ucOutput1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucOutput1.Location = New System.Drawing.Point(0, 0)
            Me.ucOutput1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.ucOutput1.Name = "ucOutput1"
            Me.ucOutput1.Size = New System.Drawing.Size(1103, 145)
            Me.ucOutput1.TabIndex = 0
            '
            'dockPanel3
            '
            Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
            Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel3.FloatSize = New System.Drawing.Size(304, 139)
            Me.dockPanel3.ID = New System.Guid("7351d5e2-6da1-45c0-a5b6-13e4e7d7a56e")
            Me.dockPanel3.ImageIndex = 27
            Me.dockPanel3.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel3.Name = "dockPanel3"
            Me.dockPanel3.OriginalSize = New System.Drawing.Size(1084, 145)
            Me.dockPanel3.Size = New System.Drawing.Size(1103, 145)
            Me.dockPanel3.TabText = "Task List"
            Me.dockPanel3.Text = "Task List - 0 Build Errors"
            '
            'dockPanel3_Container
            '
            Me.dockPanel3_Container.Controls.Add(Me.ucTaskList1)
            Me.dockPanel3_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel3_Container.Name = "dockPanel3_Container"
            Me.dockPanel3_Container.Size = New System.Drawing.Size(1103, 145)
            Me.dockPanel3_Container.TabIndex = 0
            '
            'ucTaskList1
            '
            Me.ucTaskList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucTaskList1.Location = New System.Drawing.Point(0, 0)
            Me.ucTaskList1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.ucTaskList1.Name = "ucTaskList1"
            Me.ucTaskList1.Size = New System.Drawing.Size(1103, 145)
            Me.ucTaskList1.TabIndex = 0
            '
            'dockPanel4
            '
            Me.dockPanel4.Controls.Add(Me.dockPanel4_Container)
            Me.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel4.FloatSize = New System.Drawing.Size(304, 139)
            Me.dockPanel4.ID = New System.Guid("47b3ea95-3900-46d6-b24c-5f3a779b1ae7")
            Me.dockPanel4.ImageIndex = 28
            Me.dockPanel4.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel4.Name = "dockPanel4"
            Me.dockPanel4.OriginalSize = New System.Drawing.Size(1084, 145)
            Me.dockPanel4.Size = New System.Drawing.Size(1103, 145)
            Me.dockPanel4.Text = "Find Results"
            '
            'dockPanel4_Container
            '
            Me.dockPanel4_Container.Controls.Add(Me.textBox1)
            Me.dockPanel4_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel4_Container.Name = "dockPanel4_Container"
            Me.dockPanel4_Container.Size = New System.Drawing.Size(1103, 145)
            Me.dockPanel4_Container.TabIndex = 0
            '
            'textBox1
            '
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox1.EditValue = ""
            Me.textBox1.Location = New System.Drawing.Point(0, 0)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 8.25!)
            Me.textBox1.Properties.Appearance.Options.UseFont = True
            Me.textBox1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.textBox1.Size = New System.Drawing.Size(1103, 145)
            Me.textBox1.TabIndex = 0
            Me.textBox1.UseOptimizedRendering = True
            '
            'panelContainer1
            '
            Me.panelContainer1.ActiveChild = Me.dockPanel1
            Me.panelContainer1.Controls.Add(Me.dockPanel1)
            Me.panelContainer1.Controls.Add(Me.dockPanel2)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.FloatSize = New System.Drawing.Size(253, 266)
            Me.panelContainer1.ID = New System.Guid("6c74c2c4-9754-4cea-b108-63e9e7e6c9a0")
            Me.panelContainer1.Location = New System.Drawing.Point(933, 53)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(200, 384)
            Me.panelContainer1.Tabbed = True
            Me.panelContainer1.Text = "panelContainer1"
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel1.FloatSize = New System.Drawing.Size(253, 266)
            Me.dockPanel1.ID = New System.Guid("70a62a0b-1c55-4e72-bef0-661a97c3e934")
            Me.dockPanel1.ImageIndex = 23
            Me.dockPanel1.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(192, 322)
            Me.dockPanel1.Size = New System.Drawing.Size(192, 329)
            Me.dockPanel1.TabText = "Solution Explorer"
            Me.dockPanel1.Text = "Solution Explorer - Visual Studio Inspired UI Demo"
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Controls.Add(Me.solutionExplorer)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(192, 329)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'solutionExplorer
            '
            Me.solutionExplorer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.solutionExplorer.Location = New System.Drawing.Point(0, 0)
            Me.solutionExplorer.Name = "solutionExplorer"
            Me.solutionExplorer.Size = New System.Drawing.Size(192, 329)
            Me.solutionExplorer.TabIndex = 0
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel2.ID = New System.Guid("96144626-be47-440b-ae5f-2c5507db5076")
            Me.dockPanel2.ImageIndex = 24
            Me.dockPanel2.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(192, 322)
            Me.dockPanel2.Size = New System.Drawing.Size(192, 329)
            Me.dockPanel2.Text = "Properties"
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.ucProperties1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(192, 329)
            Me.dockPanel2_Container.TabIndex = 0
            '
            'ucProperties1
            '
            Me.ucProperties1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucProperties1.Location = New System.Drawing.Point(0, 0)
            Me.ucProperties1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.ucProperties1.Name = "ucProperties1"
            Me.ucProperties1.Size = New System.Drawing.Size(192, 329)
            Me.ucProperties1.TabIndex = 0
            '
            'repositoryItemImageComboBox1
            '
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            '
            'documentManager
            '
            Me.documentManager.BarAndDockingController = Me.barAndDockingController
            Me.documentManager.ContainerControl = Me
            Me.documentManager.MenuManager = Me.barManager
            Me.documentManager.ShowToolTips = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentManager.View = Me.tabbedView
            Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tabbedView})
            '
            'tabbedView
            '
            Me.tabbedView.DocumentProperties.AllowPin = True
            Me.tabbedView.DocumentSelectorProperties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
            Me.tabbedView.DocumentSelectorProperties.DocumentFooterFormat = "{0}\{1}"
            Me.tabbedView.DocumentSelectorProperties.DocumentHeaderFormat = "{0}<br>Source file"
            Me.tabbedView.DocumentSelectorProperties.PanelFooterFormat = ""
            Me.tabbedView.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost
            '
            'fileTypeImages
            '
            Me.fileTypeImages.ImageStream = CType(resources.GetObject("fileTypeImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.fileTypeImages.TransparentColor = System.Drawing.Color.Magenta
            Me.fileTypeImages.Images.SetKeyName(0, "refresh_16xLG.png")
            Me.fileTypeImages.Images.SetKeyName(1, "")
            Me.fileTypeImages.Images.SetKeyName(2, "Property_501.png")
            Me.fileTypeImages.Images.SetKeyName(3, "Solution_8308.png")
            Me.fileTypeImages.Images.SetKeyName(4, "CSharpProject_SolutionExplorerNode.png")
            Me.fileTypeImages.Images.SetKeyName(5, "reference_16xLG.png")
            Me.fileTypeImages.Images.SetKeyName(6, "FolderOpen.png")
            Me.fileTypeImages.Images.SetKeyName(7, "Folder.png")
            Me.fileTypeImages.Images.SetKeyName(8, "HiddenFolder_428.png")
            Me.fileTypeImages.Images.SetKeyName(9, "HiddenFolder_427.png")
            Me.fileTypeImages.Images.SetKeyName(10, "CSharpFile_SolutionExplorerNode.png")
            Me.fileTypeImages.Images.SetKeyName(11, "dialog_16xLG.png")
            Me.fileTypeImages.Images.SetKeyName(12, "Component_16xLG.png")
            Me.fileTypeImages.Images.SetKeyName(13, "VSProject_generatedfile.bmp")
            '
            'AdornerUIManager1
            '
            Me.AdornerUIManager1.Elements.Add(Me.Badge1)
            Me.AdornerUIManager1.Owner = Me
            '
            'Badge1
            '
            Me.Badge1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.Badge1.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
            Me.Badge1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Badge1.Appearance.Options.UseBackColor = True
            Me.Badge1.Appearance.Options.UseFont = True
            Me.Badge1.Appearance.Options.UseForeColor = True
            Me.Badge1.Properties.Location = System.Drawing.ContentAlignment.MiddleCenter
            Me.Badge1.Properties.Text = "VS-inspired UI demo by DevExpress"
            Me.Badge1.TargetElement = Me
            '
            'frmMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1133, 662)
            Me.Controls.Add(Me.popupControlContainer1)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.panelContainer2)
            Me.Controls.Add(Me.hideContainerLeft)
            Me.Controls.Add(Me.barDockControl3)
            Me.Controls.Add(Me.barDockControl4)
            Me.Controls.Add(Me.barDockControl2)
            Me.Controls.Add(Me.barDockControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Visual Studio Inspired UI (VB Demo)"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer1.ResumeLayout(False)
            CType(Me.treeView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barAndDockingController, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.hideContainerLeft.ResumeLayout(False)
            Me.dockPanel6.ResumeLayout(False)
            Me.dockPanel6_Container.ResumeLayout(False)
            Me.panelContainer2.ResumeLayout(False)
            Me.dockPanel5.ResumeLayout(False)
            Me.dockPanel5_Container.ResumeLayout(False)
            Me.dockPanel3.ResumeLayout(False)
            Me.dockPanel3_Container.ResumeLayout(False)
            Me.dockPanel4.ResumeLayout(False)
            Me.dockPanel4_Container.ResumeLayout(False)
            CType(Me.textBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelContainer1.ResumeLayout(False)
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.documentManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AdornerUIManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub


#End Region
        Private WithEvents barManager As DevExpress.XtraBars.BarManager
		Private barDockControl1 As DevExpress.XtraBars.BarDockControl
		Private barDockControl2 As DevExpress.XtraBars.BarDockControl
		Private barDockControl3 As DevExpress.XtraBars.BarDockControl
		Private barDockControl4 As DevExpress.XtraBars.BarDockControl
		Private siFile As DevExpress.XtraBars.BarSubItem
		Private siEdit As DevExpress.XtraBars.BarSubItem
		Private siNew As DevExpress.XtraBars.BarSubItem
		Private iOpen As DevExpress.XtraBars.BarButtonItem
		Private iClose As DevExpress.XtraBars.BarButtonItem
		Private mainMenuImages As System.Windows.Forms.ImageList
		Private WithEvents iProject As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iFile As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iBlankSolution As DevExpress.XtraBars.BarButtonItem
		Private iAddNewItem As DevExpress.XtraBars.BarButtonItem
		Private iAddExistingItem As DevExpress.XtraBars.BarButtonItem
		Private siAddProject As DevExpress.XtraBars.BarSubItem
		Private WithEvents iNewProject As DevExpress.XtraBars.BarButtonItem
		Private iExistingProject As DevExpress.XtraBars.BarButtonItem
		Private iSaveAll As DevExpress.XtraBars.BarButtonItem
		Private iOpenSolution As DevExpress.XtraBars.BarButtonItem
		Private iCloseSolution As DevExpress.XtraBars.BarButtonItem
		Private iPageSetup As DevExpress.XtraBars.BarButtonItem
		Private iPrint As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
		Private siFind As DevExpress.XtraBars.BarSubItem
		Private iFind As DevExpress.XtraBars.BarButtonItem
		Private iReplace As DevExpress.XtraBars.BarButtonItem
		Private iFindinFiles As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iNew As DevExpress.XtraBars.BarButtonItem
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private iOpenFile As DevExpress.XtraBars.BarButtonItem
		Private iSave As DevExpress.XtraBars.BarButtonItem
		Private iStart As DevExpress.XtraBars.BarButtonItem
		Private eConfiguration As DevExpress.XtraBars.BarEditItem
		Private repositoryImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private eFind As DevExpress.XtraBars.BarEditItem
		Private WithEvents repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private WithEvents iSolutionExplorer As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iProperties As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iToolbox As DevExpress.XtraBars.BarButtonItem
		Private iClassView As DevExpress.XtraBars.BarButtonItem
		Private textBox1 As DevExpress.XtraEditors.MemoEdit
		Private WithEvents solutionExplorer As DevExpress.XtraBars.Demos.DockingDemo.ucSolutionExplorer
		Private WithEvents iTaskList As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iFindResults As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iOutput As DevExpress.XtraBars.BarButtonItem
		Private siWindow As DevExpress.XtraBars.BarSubItem
		Private iStatus1 As DevExpress.XtraBars.BarStaticItem
        Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
		Private treeView1 As DevExpress.XtraTreeList.TreeList
		Private classViewImages As System.Windows.Forms.ImageList
		Private WithEvents iLoadLayout As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iSaveLayout As DevExpress.XtraBars.BarButtonItem
		Private siLayouts As DevExpress.XtraBars.BarSubItem
		Private bar1 As DevExpress.XtraBars.Bar
		Private bar2 As DevExpress.XtraBars.Bar
		Private bar3 As DevExpress.XtraBars.Bar
		Private bar4 As DevExpress.XtraBars.Bar
		Private bar5 As DevExpress.XtraBars.Bar
		Private iPaintStyle As DevExpress.XtraBars.BarSubItem
		Private dockManager As DevExpress.XtraBars.Docking.DockManager
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel3 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel4 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel4_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel5 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel5_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private panelContainer2 As DevExpress.XtraBars.Docking.DockPanel
		Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
		Private barAndDockingController As DevExpress.XtraBars.BarAndDockingController
		Private dockPanel6 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel6_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private components As System.ComponentModel.IContainer
		Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager
		Private tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
		Private fileTypeImages As System.Windows.Forms.ImageList
		Private barDockingMenuItem1 As BarDockingMenuItem
		Private bsiHelp As BarSubItem
		Private WithEvents iAbout As BarButtonItem
		Private bar6 As Bar
		Private ucProperties1 As DevExpress.XtraBars.Demos.DockingDemo.ucProperties
		Private ucTaskList1 As ucTaskList
		Private ucOutput1 As ucOutput
		Private ucToolbox1 As ucToolbox
		Private barButtonItem1 As BarButtonItem
        Friend WithEvents AdornerUIManager1 As DevExpress.Utils.VisualEffects.AdornerUIManager
        Friend WithEvents Badge1 As DevExpress.Utils.VisualEffects.Badge
    End Class
End Namespace
