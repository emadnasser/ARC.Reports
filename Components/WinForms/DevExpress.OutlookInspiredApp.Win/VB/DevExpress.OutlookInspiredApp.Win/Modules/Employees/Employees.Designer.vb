Namespace DevExpress.DevAV.Modules
    Partial Public Class Employees
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
            Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItem1 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem3 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem4 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem5 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim skinPaddingEdges1 As New DevExpress.Skins.SkinPaddingEdges()
            Dim skinPaddingEdges2 As New DevExpress.Skins.SkinPaddingEdges()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biNewEmployee = New DevExpress.XtraBars.BarButtonItem()
            Me.biNewGroup = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biShowList = New DevExpress.XtraBars.BarCheckItem()
            Me.biShowCard = New DevExpress.XtraBars.BarCheckItem()
            Me.biMap = New DevExpress.XtraBars.BarButtonItem()
            Me.biNewSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiNewEmployee = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiNewGroup = New DevExpress.XtraBars.BarButtonItem()
            Me.biChangeViewSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiShowList = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiShowCard = New DevExpress.XtraBars.BarCheckItem()
            Me.biDataPaneSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiHorizontalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiVerticalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiHideDetail = New DevExpress.XtraBars.BarCheckItem()
            Me.biResetView = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrintSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiPrintProfile = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintSummary = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintDirectory = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintTaskList = New DevExpress.XtraBars.BarButtonItem()
            Me.biMailMerge = New DevExpress.XtraBars.BarButtonItem()
            Me.biEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.galleryQuickLetters = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.biMeeting = New DevExpress.XtraBars.BarButtonItem()
            Me.biTask = New DevExpress.XtraBars.BarButtonItem()
            Me.biViewSettings = New DevExpress.XtraBars.BarButtonItem()
            Me.biReverseSort = New DevExpress.XtraBars.BarButtonItem()
            Me.biAddColumns = New DevExpress.XtraBars.BarCheckItem()
            Me.biExpandCollapse = New DevExpress.XtraBars.BarButtonItem()
            Me.hiItemsCount = New DevExpress.XtraBars.BarHeaderItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.biNewCustomFilter = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colPrefix = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colZipCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBirthDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHireDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHomePhone = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMobilePhone1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.layoutView = New DevExpress.XtraGrid.Views.Layout.LayoutView()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colPhoto = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colFullName1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colFullName1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colAddress1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colAddress1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colEmail1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colEmail1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colMobilePhone = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colMobilePhone = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
            Me.Item1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.modueLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.pnlView = New DevExpress.XtraEditors.PanelControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.masterItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.detailItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colFullName1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colAddress1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colEmail1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colMobilePhone, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Item1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.modueLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.modueLayout.SuspendLayout()
            CType(Me.pnlView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.masterItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.detailItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.biNewEmployee, Me.biNewGroup, Me.biDelete, Me.biShowList, Me.biShowCard, Me.biMap, Me.biNewSubItem, Me.biChangeViewSubItem, Me.biDataPaneSubItem, Me.bmiHideDetail, Me.bmiHorizontalLayout, Me.bmiVerticalLayout, Me.biResetView, Me.bmiShowList, Me.bmiShowCard, Me.bmiNewEmployee, Me.bmiNewGroup, Me.biPrintSubItem, Me.biMailMerge, Me.bmiPrintProfile, Me.bmiPrintSummary, Me.bmiPrintDirectory, Me.bmiPrintTaskList, Me.biEdit, Me.galleryQuickLetters, Me.biMeeting, Me.biTask, Me.biViewSettings, Me.biReverseSort, Me.biAddColumns, Me.biExpandCollapse, Me.hiItemsCount})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 8
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1, Me.ribbonPage2})
            Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl.Size = New System.Drawing.Size(1280, 141)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar
            Me.biNewEmployee.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biNewEmployee.Caption = "New Employee"
            Me.biNewEmployee.Id = 1
            Me.biNewEmployee.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewEmployee.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewEmploye.svg"
            Me.biNewEmployee.Name = "biNewEmployee"
            Me.biNewGroup.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biNewGroup.Caption = "New Group"
            Me.biNewGroup.Id = 2
            Me.biNewGroup.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewGroup.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewGroup.svg"
            Me.biNewGroup.Name = "biNewGroup"
            Me.biDelete.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biDelete.Caption = "Delete"
            Me.biDelete.Id = 3
            Me.biDelete.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDelete.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg"
            Me.biDelete.Name = "biDelete"
            Me.biShowList.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biShowList.Caption = "List"
            Me.biShowList.GroupIndex = 1
            Me.biShowList.Id = 4
            Me.biShowList.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biShowList.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.List.svg"
            Me.biShowList.LargeImageIndex = 37
            Me.biShowList.Name = "biShowList"
            Me.biShowCard.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biShowCard.Caption = "Card"
            Me.biShowCard.GroupIndex = 1
            Me.biShowCard.Id = 5
            Me.biShowCard.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biShowCard.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Card.svg"
            Me.biShowCard.Name = "biShowCard"
            Me.biMap.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biMap.Caption = "Map It"
            Me.biMap.Id = 8
            Me.biMap.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMap.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Mapit.svg"
            Me.biMap.Name = "biMap"
            Me.biNewSubItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biNewSubItem.Caption = "New Items"
            Me.biNewSubItem.Id = 10
            Me.biNewSubItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewSubItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewItem.svg"
            Me.biNewSubItem.LargeImageIndex = 29
            Me.biNewSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiNewEmployee),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiNewGroup)
            })
            Me.biNewSubItem.Name = "biNewSubItem"
            Me.biNewSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiNewEmployee.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiNewEmployee.Caption = "New Employee"
            Me.bmiNewEmployee.Id = 11
            Me.bmiNewEmployee.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiNewEmployee.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewEmploye.svg?Size=16x16"
            Me.bmiNewEmployee.Name = "bmiNewEmployee"
            Me.bmiNewGroup.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiNewGroup.Caption = "New Group"
            Me.bmiNewGroup.Id = 12
            Me.bmiNewGroup.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiNewGroup.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewGroup.svg?Size=16x16"
            Me.bmiNewGroup.Name = "bmiNewGroup"
            Me.biChangeViewSubItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biChangeViewSubItem.Caption = "Change View"
            Me.biChangeViewSubItem.Id = 10
            Me.biChangeViewSubItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biChangeViewSubItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ChangeView.svg"
            Me.biChangeViewSubItem.LargeImageIndex = 40
            Me.biChangeViewSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiShowList),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiShowCard)
            })
            Me.biChangeViewSubItem.Name = "biChangeViewSubItem"
            Me.biChangeViewSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiShowList.Caption = "List"
            Me.bmiShowList.GroupIndex = 3
            Me.bmiShowList.Id = 4
            Me.bmiShowList.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiShowList.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.List.svg"
            Me.bmiShowList.Name = "bmiShowList"
            Me.bmiShowCard.Caption = "Card"
            Me.bmiShowCard.GroupIndex = 3
            Me.bmiShowCard.Id = 5
            Me.bmiShowCard.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiShowCard.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Card.svg?Size=32x32"
            Me.bmiShowCard.LargeImageIndex = 34
            Me.bmiShowCard.Name = "bmiShowCard"
            Me.biDataPaneSubItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biDataPaneSubItem.Caption = "Data Pane"
            Me.biDataPaneSubItem.Id = 10
            Me.biDataPaneSubItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDataPaneSubItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.DataPanel.svg"
            Me.biDataPaneSubItem.LargeImageIndex = 41
            Me.biDataPaneSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiHorizontalLayout),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiVerticalLayout),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiHideDetail)
            })
            Me.biDataPaneSubItem.Name = "biDataPaneSubItem"
            Me.biDataPaneSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiHorizontalLayout.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiHorizontalLayout.Caption = "Right"
            Me.bmiHorizontalLayout.GroupIndex = 2
            Me.bmiHorizontalLayout.Id = 6
            Me.bmiHorizontalLayout.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiHorizontalLayout.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelRight.svg?Size=16x16"
            Me.bmiHorizontalLayout.Name = "bmiHorizontalLayout"
            Me.bmiVerticalLayout.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiVerticalLayout.Caption = "Bottom"
            Me.bmiVerticalLayout.GroupIndex = 2
            Me.bmiVerticalLayout.Id = 7
            Me.bmiVerticalLayout.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiVerticalLayout.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelBottom.svg?Size=16x16"
            Me.bmiVerticalLayout.Name = "bmiVerticalLayout"
            Me.bmiHideDetail.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiHideDetail.Caption = "Off"
            Me.bmiHideDetail.GroupIndex = 2
            Me.bmiHideDetail.Id = 7
            Me.bmiHideDetail.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiHideDetail.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelOff.svg?Size=16x16"
            Me.bmiHideDetail.Name = "bmiHideDetail"
            Me.biResetView.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biResetView.Caption = "Reset View"
            Me.biResetView.Id = 9
            Me.biResetView.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biResetView.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ResetView.svg"
            Me.biResetView.Name = "biResetView"
            Me.biPrintSubItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biPrintSubItem.Caption = "Print"
            Me.biPrintSubItem.Id = 10
            Me.biPrintSubItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPrintSubItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg"
            Me.biPrintSubItem.LargeImageIndex = 30
            Me.biPrintSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintProfile),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintSummary),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintDirectory),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintTaskList)
            })
            Me.biPrintSubItem.Name = "biPrintSubItem"
            Me.biPrintSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiPrintProfile.Caption = "Employee Profile"
            Me.bmiPrintProfile.Glyph = My.Resources.icon_employee_profile_16
            Me.bmiPrintProfile.GroupIndex = 5
            Me.bmiPrintProfile.Id = 6
            Me.bmiPrintProfile.Name = "bmiPrintProfile"
            Me.bmiPrintSummary.Caption = "Summary Report"
            Me.bmiPrintSummary.Glyph = My.Resources.icon_employee_summary_16
            Me.bmiPrintSummary.GroupIndex = 5
            Me.bmiPrintSummary.Id = 6
            Me.bmiPrintSummary.Name = "bmiPrintSummary"
            Me.bmiPrintDirectory.Caption = "Directory"
            Me.bmiPrintDirectory.Glyph = My.Resources.icon_employee_directory_16
            Me.bmiPrintDirectory.GroupIndex = 5
            Me.bmiPrintDirectory.Id = 6
            Me.bmiPrintDirectory.Name = "bmiPrintDirectory"
            Me.bmiPrintTaskList.Caption = "Task List"
            Me.bmiPrintTaskList.Glyph = My.Resources.icon_employee_task_list_16
            Me.bmiPrintTaskList.GroupIndex = 5
            Me.bmiPrintTaskList.Id = 6
            Me.bmiPrintTaskList.Name = "bmiPrintTaskList"
            Me.biMailMerge.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biMailMerge.Caption = "Mail Merge"
            Me.biMailMerge.Id = 10
            Me.biMailMerge.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMailMerge.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.MailMerge.svg"
            Me.biMailMerge.Name = "biMailMerge"
            Me.biEdit.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biEdit.Caption = "Edit"
            Me.biEdit.Id = 13
            Me.biEdit.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biEdit.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Edit.svg"
            Me.biEdit.Name = "biEdit"
            Me.galleryQuickLetters.Caption = "ribbonGalleryBarItem1"
            Me.galleryQuickLetters.Gallery.ColumnCount = 2
            Me.galleryQuickLetters.Gallery.DrawImageBackground = False
            galleryItemGroup1.Caption = "Group1"
            galleryItem1.Caption = "Thank You Note"
            galleryItem1.Image = My.Resources.icon_employee_quick_thank_16
            galleryItem2.Caption = "Employee Award"
            galleryItem2.Image = My.Resources.icon_employee_quick_award_16
            galleryItem3.Caption = "Service Excellence"
            galleryItem3.Image = My.Resources.icon_employee_quick_excellence_16
            galleryItem4.Caption = "Probation Notice"
            galleryItem4.Image = My.Resources.icon_employee_quick_probation_notice_16
            galleryItem5.Caption = "Welcome To DevAV"
            galleryItem5.Image = My.Resources.icon_employee_quick_welcome_16
            galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2, galleryItem3, galleryItem4, galleryItem5})
            Me.galleryQuickLetters.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
            Me.galleryQuickLetters.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            skinPaddingEdges1.Bottom = -3
            skinPaddingEdges1.Top = -3
            Me.galleryQuickLetters.Gallery.ItemImagePadding = skinPaddingEdges1
            skinPaddingEdges2.Bottom = -1
            skinPaddingEdges2.Top = -1
            Me.galleryQuickLetters.Gallery.ItemTextPadding = skinPaddingEdges2
            Me.galleryQuickLetters.Gallery.ShowItemText = True
            Me.galleryQuickLetters.Id = 15
            Me.galleryQuickLetters.Name = "galleryQuickLetters"
            Me.biMeeting.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biMeeting.Caption = "Meeting"
            Me.biMeeting.Id = 1
            Me.biMeeting.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMeeting.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Meeting.svg"
            Me.biMeeting.Name = "biMeeting"
            Me.biTask.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biTask.Caption = "Task"
            Me.biTask.Id = 2
            Me.biTask.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biTask.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Task.svg"
            Me.biTask.Name = "biTask"
            Me.biViewSettings.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biViewSettings.Caption = "View Settings"
            Me.biViewSettings.Id = 3
            Me.biViewSettings.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biViewSettings.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ViewSetting.svg"
            Me.biViewSettings.Name = "biViewSettings"
            Me.biReverseSort.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biReverseSort.Caption = "Reverse Sort"
            Me.biReverseSort.Id = 4
            Me.biReverseSort.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biReverseSort.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ReversSort.svg?Size=16x16"
            Me.biReverseSort.Name = "biReverseSort"
            Me.biAddColumns.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biAddColumns.Caption = "Add Columns"
            Me.biAddColumns.Id = 5
            Me.biAddColumns.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biAddColumns.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.AddColumn.svg?Size=16x16"
            Me.biAddColumns.Name = "biAddColumns"
            Me.biExpandCollapse.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biExpandCollapse.Caption = "Expand/Collapse"
            Me.biExpandCollapse.Id = 6
            Me.biExpandCollapse.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biExpandCollapse.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ExpandCollapse.svg?Size=16x16"
            Me.biExpandCollapse.Name = "biExpandCollapse"
            Me.hiItemsCount.Caption = "RECORDS: 0"
            Me.hiItemsCount.Id = 7
            Me.hiItemsCount.Name = "hiItemsCount"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3, Me.ribbonPageGroup8, Me.ribbonPageGroup4, Me.ribbonPageGroup6})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "HOME"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewEmployee)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewGroup)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewSubItem)
            Me.ribbonPageGroup1.MergeOrder = 0
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup1.Text = "New"
            Me.ribbonPageGroup2.AllowTextClipping = False
            Me.ribbonPageGroup2.ItemLinks.Add(Me.biDelete)
            Me.ribbonPageGroup2.MergeOrder = 0
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.ShowCaptionButton = False
            Me.ribbonPageGroup2.Text = "Delete"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biEdit)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biPrintSubItem)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biMeeting)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biTask)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biMailMerge)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.ShowCaptionButton = False
            Me.ribbonPageGroup3.Text = "Actions"
            Me.ribbonPageGroup8.AllowTextClipping = False
            Me.ribbonPageGroup8.ItemLinks.Add(Me.galleryQuickLetters)
            Me.ribbonPageGroup8.MergeOrder = 0
            Me.ribbonPageGroup8.Name = "ribbonPageGroup8"
            Me.ribbonPageGroup8.ShowCaptionButton = False
            Me.ribbonPageGroup8.Text = "Quick Letter"
            Me.ribbonPageGroup4.AllowTextClipping = False
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biShowList)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biShowCard)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biMap)
            Me.ribbonPageGroup4.MergeOrder = 0
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.ShowCaptionButton = False
            Me.ribbonPageGroup4.Text = "View"
            Me.ribbonPageGroup6.AllowMinimize = False
            Me.ribbonPageGroup6.AllowTextClipping = False
            Me.ribbonPageGroup6.ItemLinks.Add(Me.biNewCustomFilter)
            Me.ribbonPageGroup6.MergeOrder = 0
            Me.ribbonPageGroup6.Name = "ribbonPageGroup6"
            Me.ribbonPageGroup6.ShowCaptionButton = False
            Me.ribbonPageGroup6.Text = "Find"
            Me.biNewCustomFilter.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biNewCustomFilter.Caption = "Custom Filter"
            Me.biNewCustomFilter.Id = 9
            Me.biNewCustomFilter.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewCustomFilter.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Filter.svg"
            Me.biNewCustomFilter.Name = "biNewCustomFilter"
            Me.ribbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup5, Me.ribbonPageGroup7, Me.ribbonPageGroup9})
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "VIEW"
            Me.ribbonPageGroup5.AllowTextClipping = False
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biChangeViewSubItem)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biViewSettings)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biResetView)
            Me.ribbonPageGroup5.MergeOrder = 0
            Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
            Me.ribbonPageGroup5.ShowCaptionButton = False
            Me.ribbonPageGroup5.Text = "Current View"
            Me.ribbonPageGroup7.AllowTextClipping = False
            Me.ribbonPageGroup7.ItemLinks.Add(Me.biDataPaneSubItem)
            Me.ribbonPageGroup7.MergeOrder = 1
            Me.ribbonPageGroup7.Name = "ribbonPageGroup7"
            Me.ribbonPageGroup7.ShowCaptionButton = False
            Me.ribbonPageGroup7.Text = "Layout"
            Me.ribbonPageGroup9.AllowTextClipping = False
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biReverseSort)
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biAddColumns)
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biExpandCollapse)
            Me.ribbonPageGroup9.MergeOrder = 1
            Me.ribbonPageGroup9.Name = "ribbonPageGroup9"
            Me.ribbonPageGroup9.ShowCaptionButton = False
            Me.ribbonStatusBar.ItemLinks.Add(Me.hiItemsCount)
            Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 773)
            Me.ribbonStatusBar.Name = "ribbonStatusBar"
            Me.ribbonStatusBar.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar.Size = New System.Drawing.Size(1280, 27)
            Me.gridControl.DataSource = Me.bindingSource
            Me.gridControl.Location = New System.Drawing.Point(6, 14)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Margin = New System.Windows.Forms.Padding(12)
            Me.gridControl.MenuManager = Me.ribbonControl
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemMemoEdit1})
            Me.gridControl.ShowOnlyPredefinedDetails = True
            Me.gridControl.Size = New System.Drawing.Size(754, 604)
            Me.gridControl.TabIndex = 1
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView, Me.layoutView})
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Employee)
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colPrefix, Me.colDepartment, Me.colFullName, Me.colAddress, Me.colCity, Me.colState, Me.colZipCode, Me.colEmail, Me.colBirthDate, Me.colHireDate, Me.colHomePhone, Me.colMobilePhone1, Me.colTitle})
            Me.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.GroupCount = 1
            Me.gridView.GroupFormat = "[#image]{1} {2}"
            Me.gridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", Nothing, "")})
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView.OptionsBehavior.Editable = False
            Me.gridView.OptionsFind.AlwaysVisible = True
            Me.gridView.OptionsFind.FindNullPrompt = "Search Employees (Ctrl + F)"
            Me.gridView.OptionsFind.ShowClearButton = False
            Me.gridView.OptionsFind.ShowFindButton = False
            Me.gridView.OptionsSelection.MultiSelect = True
            Me.gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True
            Me.gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False
            Me.gridView.OptionsView.ShowIndicator = False
            Me.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDepartment, DevExpress.Data.ColumnSortOrder.Ascending)})
            Me.colPrefix.Caption = "PREFIX"
            Me.colPrefix.FieldName = "Prefix"
            Me.colPrefix.Image = My.Resources.icon_prefix_16
            Me.colPrefix.ImageAlignment = System.Drawing.StringAlignment.Center
            Me.colPrefix.Name = "colPrefix"
            Me.colPrefix.OptionsColumn.AllowFocus = False
            Me.colPrefix.OptionsColumn.AllowMove = False
            Me.colPrefix.OptionsColumn.AllowSize = False
            Me.colPrefix.OptionsColumn.FixedWidth = True
            Me.colPrefix.OptionsColumn.ShowCaption = False
            Me.colPrefix.Visible = True
            Me.colPrefix.VisibleIndex = 0
            Me.colPrefix.Width = 47
            Me.colDepartment.Caption = "DEPARTMENT"
            Me.colDepartment.FieldName = "Department"
            Me.colDepartment.Name = "colDepartment"
            Me.colDepartment.OptionsColumn.AllowFocus = False
            Me.colDepartment.Visible = True
            Me.colDepartment.VisibleIndex = 0
            Me.colFullName.Caption = "FULL NAME"
            Me.colFullName.FieldName = "FullNameBindable"
            Me.colFullName.Name = "colFullName"
            Me.colFullName.OptionsColumn.AllowFocus = False
            Me.colFullName.Visible = True
            Me.colFullName.VisibleIndex = 1
            Me.colFullName.Width = 133
            Me.colAddress.Caption = "ADDRESS"
            Me.colAddress.FieldName = "Address.Line"
            Me.colAddress.Name = "colAddress"
            Me.colAddress.OptionsColumn.AllowFocus = False
            Me.colAddress.Visible = True
            Me.colAddress.VisibleIndex = 2
            Me.colAddress.Width = 142
            Me.colCity.Caption = "CITY"
            Me.colCity.FieldName = "Address.City"
            Me.colCity.Name = "colCity"
            Me.colCity.OptionsColumn.AllowFocus = False
            Me.colCity.Visible = True
            Me.colCity.VisibleIndex = 3
            Me.colCity.Width = 113
            Me.colState.Caption = "STATE"
            Me.colState.FieldName = "Address.State"
            Me.colState.Name = "colState"
            Me.colState.OptionsColumn.AllowFocus = False
            Me.colState.Visible = True
            Me.colState.VisibleIndex = 4
            Me.colState.Width = 73
            Me.colZipCode.Caption = "ZIP CODE"
            Me.colZipCode.FieldName = "Address.ZipCode"
            Me.colZipCode.Name = "colZipCode"
            Me.colZipCode.OptionsColumn.AllowFocus = False
            Me.colZipCode.Visible = True
            Me.colZipCode.VisibleIndex = 5
            Me.colZipCode.Width = 73
            Me.colEmail.Caption = "EMAIL"
            Me.colEmail.FieldName = "Email"
            Me.colEmail.Name = "colEmail"
            Me.colEmail.OptionsColumn.AllowFocus = False
            Me.colEmail.Visible = True
            Me.colEmail.VisibleIndex = 6
            Me.colEmail.Width = 166
            Me.colBirthDate.Caption = "BIRTH DATE"
            Me.colBirthDate.FieldName = "BirthDate"
            Me.colBirthDate.Name = "colBirthDate"
            Me.colBirthDate.OptionsColumn.AllowFocus = False
            Me.colHireDate.Caption = "HIRE DATE"
            Me.colHireDate.FieldName = "HireDate"
            Me.colHireDate.Name = "colHireDate"
            Me.colHireDate.OptionsColumn.AllowFocus = False
            Me.colHomePhone.Caption = "HOME PHONE"
            Me.colHomePhone.FieldName = "HomePhone"
            Me.colHomePhone.Name = "colHomePhone"
            Me.colHomePhone.OptionsColumn.AllowFocus = False
            Me.colMobilePhone1.Caption = "MOBILE PHONE"
            Me.colMobilePhone1.FieldName = "MobilePhone"
            Me.colMobilePhone1.Name = "colMobilePhone1"
            Me.colMobilePhone1.OptionsColumn.AllowFocus = False
            Me.colTitle.Caption = "TITLE"
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            Me.colTitle.OptionsColumn.AllowFocus = False
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox2.AutoHeight = False
            Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            Me.layoutView.CardCaptionFormat = "{3}"
            Me.layoutView.CardMinSize = New System.Drawing.Size(292, 183)
            Me.layoutView.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colPhoto, Me.colFullName1, Me.colAddress1, Me.colEmail1, Me.colMobilePhone})
            Me.layoutView.FieldCaptionFormat = "{0}"
            Me.layoutView.GridControl = Me.gridControl
            Me.layoutView.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colFullName1})
            Me.layoutView.Name = "layoutView"
            Me.layoutView.OptionsBehavior.AllowExpandCollapse = False
            Me.layoutView.OptionsBehavior.AllowRuntimeCustomization = False
            Me.layoutView.OptionsBehavior.Editable = False
            Me.layoutView.OptionsBehavior.ReadOnly = True
            Me.layoutView.OptionsFind.AlwaysVisible = True
            Me.layoutView.OptionsFind.FindNullPrompt = "Search Employees (Ctrl + F)"
            Me.layoutView.OptionsFind.ShowClearButton = False
            Me.layoutView.OptionsFind.ShowCloseButton = False
            Me.layoutView.OptionsFind.ShowFindButton = False
            Me.layoutView.OptionsItemText.TextToControlDistance = 2
            Me.layoutView.OptionsMultiRecordMode.MultiRowScrollBarOrientation = DevExpress.XtraGrid.Views.Layout.ScrollBarOrientation.Vertical
            Me.layoutView.OptionsSelection.MultiSelect = True
            Me.layoutView.OptionsView.AllowHotTrackFields = False
            Me.layoutView.OptionsView.FocusRectStyle = DevExpress.XtraGrid.Views.Layout.FocusRectStyle.None
            Me.layoutView.OptionsView.ShowHeaderPanel = False
            Me.layoutView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
            Me.layoutView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFullName1, DevExpress.Data.ColumnSortOrder.Ascending)})
            Me.layoutView.TemplateCard = Me.layoutViewCard1
            Me.colPhoto.AppearanceCell.Options.UseTextOptions = True
            Me.colPhoto.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.LayoutViewField = Me.layoutViewField_colPhoto
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.OptionsColumn.AllowEdit = False
            Me.colPhoto.OptionsColumn.AllowFocus = False
            Me.colPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colPhoto.OptionsFilter.AllowFilter = False
            Me.layoutViewField_colPhoto.EditorPreferredWidth = 106
            Me.layoutViewField_colPhoto.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colPhoto.MaxSize = New System.Drawing.Size(120, 136)
            Me.layoutViewField_colPhoto.MinSize = New System.Drawing.Size(120, 136)
            Me.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto"
            Me.layoutViewField_colPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 12, 2, 2)
            Me.layoutViewField_colPhoto.Size = New System.Drawing.Size(120, 136)
            Me.layoutViewField_colPhoto.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutViewField_colPhoto.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutViewField_colPhoto.TextVisible = False
            Me.colFullName1.FieldName = "FullNameBindable"
            Me.colFullName1.LayoutViewField = Me.layoutViewField_colFullName1
            Me.colFullName1.Name = "colFullName1"
            Me.colFullName1.OptionsColumn.AllowFocus = False
            Me.layoutViewField_colFullName1.EditorPreferredWidth = 20
            Me.layoutViewField_colFullName1.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colFullName1.Name = "layoutViewField_colFullName1"
            Me.layoutViewField_colFullName1.Size = New System.Drawing.Size(272, 136)
            Me.layoutViewField_colFullName1.TextSize = New System.Drawing.Size(67, 13)
            Me.colAddress1.Caption = "ADDRESS"
            Me.colAddress1.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colAddress1.FieldName = "Address"
            Me.colAddress1.LayoutViewField = Me.layoutViewField_colAddress1
            Me.colAddress1.Name = "colAddress1"
            Me.colAddress1.OptionsColumn.AllowFocus = False
            Me.colAddress1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colAddress1.OptionsFilter.AllowFilter = False
            Me.layoutViewField_colAddress1.EditorPreferredWidth = 148
            Me.layoutViewField_colAddress1.Location = New System.Drawing.Point(120, 0)
            Me.layoutViewField_colAddress1.Name = "layoutViewField_colAddress1"
            Me.layoutViewField_colAddress1.Size = New System.Drawing.Size(152, 36)
            Me.layoutViewField_colAddress1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutViewField_colAddress1.TextSize = New System.Drawing.Size(46, 13)
            Me.colEmail1.Caption = "EMAIL"
            Me.colEmail1.FieldName = "Email"
            Me.colEmail1.LayoutViewField = Me.layoutViewField_colEmail1
            Me.colEmail1.Name = "colEmail1"
            Me.colEmail1.OptionsColumn.AllowFocus = False
            Me.colEmail1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colEmail1.OptionsFilter.AllowFilter = False
            Me.layoutViewField_colEmail1.EditorPreferredWidth = 148
            Me.layoutViewField_colEmail1.Location = New System.Drawing.Point(120, 36)
            Me.layoutViewField_colEmail1.Name = "layoutViewField_colEmail1"
            Me.layoutViewField_colEmail1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2)
            Me.layoutViewField_colEmail1.Size = New System.Drawing.Size(152, 41)
            Me.layoutViewField_colEmail1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutViewField_colEmail1.TextSize = New System.Drawing.Size(46, 13)
            Me.colMobilePhone.Caption = "PHONE"
            Me.colMobilePhone.FieldName = "MobilePhone"
            Me.colMobilePhone.LayoutViewField = Me.layoutViewField_colMobilePhone
            Me.colMobilePhone.Name = "colMobilePhone"
            Me.colMobilePhone.OptionsColumn.AllowFocus = False
            Me.colMobilePhone.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.colMobilePhone.OptionsFilter.AllowFilter = False
            Me.layoutViewField_colMobilePhone.EditorPreferredWidth = 148
            Me.layoutViewField_colMobilePhone.Location = New System.Drawing.Point(120, 77)
            Me.layoutViewField_colMobilePhone.Name = "layoutViewField_colMobilePhone"
            Me.layoutViewField_colMobilePhone.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2)
            Me.layoutViewField_colMobilePhone.Size = New System.Drawing.Size(152, 45)
            Me.layoutViewField_colMobilePhone.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutViewField_colMobilePhone.TextSize = New System.Drawing.Size(46, 13)
            Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
            Me.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colAddress1, Me.layoutViewField_colEmail1, Me.layoutViewField_colPhoto, Me.layoutViewField_colMobilePhone, Me.Item1})
            Me.layoutViewCard1.Name = "layoutViewCard1"
            Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 2
            Me.layoutViewCard1.Text = "TemplateCard"
            Me.Item1.AllowHotTrack = False
            Me.Item1.CustomizationFormText = "Item1"
            Me.Item1.Location = New System.Drawing.Point(120, 122)
            Me.Item1.Name = "Item1"
            Me.Item1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Item1.Size = New System.Drawing.Size(152, 14)
            Me.Item1.TextSize = New System.Drawing.Size(0, 0)
            Me.modueLayout.AllowCustomization = False
            Me.modueLayout.Controls.Add(Me.pnlView)
            Me.modueLayout.Controls.Add(Me.gridControl)
            Me.modueLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.modueLayout.Location = New System.Drawing.Point(0, 141)
            Me.modueLayout.Name = "modueLayout"
            Me.modueLayout.Root = Me.layoutControlGroup1
            Me.modueLayout.Size = New System.Drawing.Size(1280, 632)
            Me.modueLayout.TabIndex = 5
            Me.modueLayout.Text = "modueLayout"
            Me.pnlView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlView.Location = New System.Drawing.Point(769, 14)
            Me.pnlView.Name = "pnlView"
            Me.pnlView.Size = New System.Drawing.Size(497, 604)
            Me.pnlView.TabIndex = 4
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.masterItem, Me.detailItem, Me.splitterItem})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 12, 12, 12)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1280, 632)
            Me.layoutControlGroup1.TextVisible = False
            Me.masterItem.Control = Me.gridControl
            Me.masterItem.CustomizationFormText = "layoutControlItem1"
            Me.masterItem.Location = New System.Drawing.Point(0, 0)
            Me.masterItem.Name = "layoutControlItem1"
            Me.masterItem.Size = New System.Drawing.Size(758, 608)
            Me.masterItem.TextSize = New System.Drawing.Size(0, 0)
            Me.masterItem.TextVisible = False
            Me.detailItem.Control = Me.pnlView
            Me.detailItem.CustomizationFormText = "layoutControlItem2"
            Me.detailItem.Location = New System.Drawing.Point(763, 0)
            Me.detailItem.Name = "layoutControlItem2"
            Me.detailItem.Size = New System.Drawing.Size(501, 608)
            Me.detailItem.TextSize = New System.Drawing.Size(0, 0)
            Me.detailItem.TextVisible = False
            Me.splitterItem.AllowHotTrack = True
            Me.splitterItem.CustomizationFormText = "splitterItem1"
            Me.splitterItem.Location = New System.Drawing.Point(758, 0)
            Me.splitterItem.Name = "splitterItem1"
            Me.splitterItem.Size = New System.Drawing.Size(5, 608)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.modueLayout)
            Me.Controls.Add(Me.ribbonControl)
            Me.Controls.Add(Me.ribbonStatusBar)
            Me.Name = "Employees"
            Me.Size = New System.Drawing.Size(1280, 800)
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colPhoto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colFullName1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colAddress1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colEmail1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colMobilePhone, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Item1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.modueLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.modueLayout.ResumeLayout(False)
            CType(Me.pnlView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.masterItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.detailItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        #End Region

        Private ribbonControl As XtraBars.Ribbon.RibbonControl
        Private ribbonStatusBar As XtraBars.Ribbon.RibbonStatusBar
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPage2 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private biNewEmployee As XtraBars.BarButtonItem
        Private biNewGroup As XtraBars.BarButtonItem
        Private biNewCustomFilter As XtraBars.BarButtonItem
        Private biDelete As XtraBars.BarButtonItem
        Private ribbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup5 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup6 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup7 As XtraBars.Ribbon.RibbonPageGroup
        Private gridControl As XtraGrid.GridControl
        Private gridView As XtraGrid.Views.Grid.GridView
        Private bindingSource As System.Windows.Forms.BindingSource
        Private colDepartment As XtraGrid.Columns.GridColumn
        Private colFullName As XtraGrid.Columns.GridColumn
        Private colEmail As XtraGrid.Columns.GridColumn
        Private colCity As XtraGrid.Columns.GridColumn
        Private colAddress As XtraGrid.Columns.GridColumn
        Private biShowList As XtraBars.BarCheckItem
        Private biShowCard As XtraBars.BarCheckItem
        Private bmiShowList As XtraBars.BarCheckItem
        Private bmiShowCard As XtraBars.BarCheckItem
        Private biMap As XtraBars.BarButtonItem
        Private bmiHorizontalLayout As XtraBars.BarCheckItem
        Private bmiVerticalLayout As XtraBars.BarCheckItem
        Private bmiHideDetail As XtraBars.BarCheckItem
        Private biNewSubItem As XtraBars.BarSubItem
        Private biChangeViewSubItem As XtraBars.BarSubItem
        Private biDataPaneSubItem As XtraBars.BarSubItem
        Private biPrintSubItem As XtraBars.BarSubItem
        Private bmiPrintProfile As XtraBars.BarButtonItem
        Private bmiPrintSummary As XtraBars.BarButtonItem
        Private bmiPrintDirectory As XtraBars.BarButtonItem
        Private bmiPrintTaskList As XtraBars.BarButtonItem
        Private biMailMerge As XtraBars.BarButtonItem

        Private bmiNewEmployee As XtraBars.BarButtonItem
        Private bmiNewGroup As XtraBars.BarButtonItem
        Private biEdit As XtraBars.BarButtonItem
        Private biResetView As XtraBars.BarButtonItem
        Private WithEvents layoutView As XtraGrid.Views.Layout.LayoutView
        Private modueLayout As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private masterItem As XtraLayout.LayoutControlItem
        Private pnlView As XtraEditors.PanelControl
        Private detailItem As XtraLayout.LayoutControlItem
        Private splitterItem As XtraLayout.SplitterItem
        Private colState As XtraGrid.Columns.GridColumn
        Private colZipCode As XtraGrid.Columns.GridColumn
        Private repositoryItemImageComboBox1 As XtraEditors.Repository.RepositoryItemImageComboBox
        Private repositoryItemImageComboBox2 As XtraEditors.Repository.RepositoryItemImageComboBox
        Private colPhoto As XtraGrid.Columns.LayoutViewColumn
        Private colFullName1 As XtraGrid.Columns.LayoutViewColumn
        Private colAddress1 As XtraGrid.Columns.LayoutViewColumn
        Private colEmail1 As XtraGrid.Columns.LayoutViewColumn
        Private colMobilePhone As XtraGrid.Columns.LayoutViewColumn
        Private repositoryItemMemoEdit1 As XtraEditors.Repository.RepositoryItemMemoEdit
        Private galleryQuickLetters As XtraBars.RibbonGalleryBarItem
        Private ribbonPageGroup8 As XtraBars.Ribbon.RibbonPageGroup
        Private biMeeting As XtraBars.BarButtonItem
        Private biTask As XtraBars.BarButtonItem
        Private biViewSettings As XtraBars.BarButtonItem
        Private WithEvents biReverseSort As XtraBars.BarButtonItem
        Private WithEvents biAddColumns As XtraBars.BarCheckItem
        Private WithEvents biExpandCollapse As XtraBars.BarButtonItem
        Private ribbonPageGroup9 As XtraBars.Ribbon.RibbonPageGroup
        Private layoutViewField_colPhoto As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colFullName1 As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colAddress1 As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colEmail1 As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewField_colMobilePhone As XtraGrid.Views.Layout.LayoutViewField
        Private layoutViewCard1 As XtraGrid.Views.Layout.LayoutViewCard
        Private Item1 As XtraLayout.EmptySpaceItem
        Private hiItemsCount As XtraBars.BarHeaderItem
        Private colBirthDate As XtraGrid.Columns.GridColumn
        Private colHireDate As XtraGrid.Columns.GridColumn
        Private colHomePhone As XtraGrid.Columns.GridColumn
        Private colMobilePhone1 As XtraGrid.Columns.GridColumn
        Private colTitle As XtraGrid.Columns.GridColumn
        Private colPrefix As XtraGrid.Columns.GridColumn
    End Class
End Namespace
