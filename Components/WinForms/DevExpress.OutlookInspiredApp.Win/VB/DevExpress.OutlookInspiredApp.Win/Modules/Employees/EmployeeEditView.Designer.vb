Namespace DevExpress.DevAV.Modules
    Partial Public Class EmployeeEditView
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
            Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()
            Me.moduleDataLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.FullNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biSave = New DevExpress.XtraBars.BarButtonItem()
            Me.biClose = New DevExpress.XtraBars.BarButtonItem()
            Me.biSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biMailMerge = New DevExpress.XtraBars.BarButtonItem()
            Me.biMeeting = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrintSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiPrintProfile = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintSummary = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintDirectory = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintTaskList = New DevExpress.XtraBars.BarButtonItem()
            Me.biTask = New DevExpress.XtraBars.BarButtonItem()
            Me.galleryQuickLetters = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.biShowMap = New DevExpress.XtraBars.BarButtonItem()
            Me.biRefresh = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ZipCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.StateImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.CityTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.AddressTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.gridControlTasks = New DevExpress.XtraGrid.GridControl()
            Me.bindingSourceTasks = New System.Windows.Forms.BindingSource(Me.components)
            Me.gvTasks = New DevExpress.DevAV.TaskPreviewGridView()
            Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubject1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCompletion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.gridControlEvaluations = New DevExpress.XtraGrid.GridControl()
            Me.bindingSourceEvaluations = New System.Windows.Forms.BindingSource(Me.components)
            Me.gvEvaluations = New DevExpress.DevAV.TaskPreviewGridView()
            Me.colCreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.DepartmentImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.TitleTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.StatusImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.HireDateDateEdit = New DevExpress.XtraEditors.DateEdit()
            Me.FirstNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.LastNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.PrefixImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.BirthDateDateEdit = New DevExpress.XtraEditors.DateEdit()
            Me.PhotoPictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.HomePhoneTextEdit = New DevExpress.XtraEditors.ButtonEdit()
            Me.MobilePhoneTextEdit = New DevExpress.XtraEditors.ButtonEdit()
            Me.EmailTextEdit = New DevExpress.XtraEditors.ButtonEdit()
            Me.SkypeTextEdit = New DevExpress.XtraEditors.ButtonEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForFirstName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForLastName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForPrefix = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForDepartment = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForStatus = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForEvaluations = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForHomePhone = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForMobilePhone = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForEmail = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForSkype = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForPhoto = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForAddress = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForCity = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForState = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForZipCode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForFullName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForHireDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForBirthDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForTitle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForTasks = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.moduleDataLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleDataLayout.SuspendLayout()
            CType(Me.FullNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ZipCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StateImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControlTasks, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSourceTasks, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControlEvaluations, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSourceEvaluations, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gvEvaluations, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DepartmentImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TitleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StatusImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.HireDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.HireDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PrefixImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BirthDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BirthDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PhotoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.HomePhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MobilePhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SkypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForLastName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForPrefix, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForEvaluations, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForHomePhone, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForMobilePhone, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForSkype, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForCity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForState, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForZipCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForFullName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForHireDate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForBirthDate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForTasks, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.moduleDataLayout.AllowCustomization = False
            Me.moduleDataLayout.Controls.Add(Me.FullNameTextEdit)
            Me.moduleDataLayout.Controls.Add(Me.ZipCodeTextEdit)
            Me.moduleDataLayout.Controls.Add(Me.StateImageComboBoxEdit)
            Me.moduleDataLayout.Controls.Add(Me.CityTextEdit)
            Me.moduleDataLayout.Controls.Add(Me.AddressTextEdit)
            Me.moduleDataLayout.Controls.Add(Me.gridControlTasks)
            Me.moduleDataLayout.Controls.Add(Me.gridControlEvaluations)
            Me.moduleDataLayout.Controls.Add(Me.DepartmentImageComboBoxEdit)
            Me.moduleDataLayout.Controls.Add(Me.TitleTextEdit)
            Me.moduleDataLayout.Controls.Add(Me.StatusImageComboBoxEdit)
            Me.moduleDataLayout.Controls.Add(Me.HireDateDateEdit)
            Me.moduleDataLayout.Controls.Add(Me.FirstNameTextEdit)
            Me.moduleDataLayout.Controls.Add(Me.LastNameTextEdit)
            Me.moduleDataLayout.Controls.Add(Me.PrefixImageComboBoxEdit)
            Me.moduleDataLayout.Controls.Add(Me.BirthDateDateEdit)
            Me.moduleDataLayout.Controls.Add(Me.PhotoPictureEdit)
            Me.moduleDataLayout.Controls.Add(Me.HomePhoneTextEdit)
            Me.moduleDataLayout.Controls.Add(Me.MobilePhoneTextEdit)
            Me.moduleDataLayout.Controls.Add(Me.EmailTextEdit)
            Me.moduleDataLayout.Controls.Add(Me.SkypeTextEdit)
            Me.moduleDataLayout.DataSource = Me.bindingSource
            Me.moduleDataLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleDataLayout.Location = New System.Drawing.Point(0, 141)
            Me.moduleDataLayout.MenuManager = Me.ribbonControl
            Me.moduleDataLayout.Name = "moduleDataLayout"
            Me.moduleDataLayout.Root = Me.layoutControlGroup1
            Me.moduleDataLayout.Size = New System.Drawing.Size(1209, 644)
            Me.moduleDataLayout.TabIndex = 1
            Me.moduleDataLayout.Text = "moduleDataLayout"
            Me.FullNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "FullNameBindable", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.FullNameTextEdit.Location = New System.Drawing.Point(100, 60)
            Me.FullNameTextEdit.MenuManager = Me.ribbonControl
            Me.FullNameTextEdit.Name = "FullNameTextEdit"
            Me.FullNameTextEdit.Size = New System.Drawing.Size(313, 20)
            Me.FullNameTextEdit.StyleController = Me.moduleDataLayout
            Me.FullNameTextEdit.TabIndex = 23
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Employee)
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.biSave, Me.biClose, Me.biSaveAndClose, Me.biDelete, Me.biMailMerge, Me.biMeeting, Me.biPrintSubItem, Me.bmiPrintProfile, Me.bmiPrintSummary, Me.biTask, Me.bmiPrintDirectory, Me.bmiPrintTaskList, Me.galleryQuickLetters, Me.biShowMap, Me.biRefresh})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 18
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl.Size = New System.Drawing.Size(1209, 141)
            Me.biSave.Caption = "Save"
            Me.biSave.Id = 1
            Me.biSave.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biSave.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biSave.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Save.svg"
            Me.biSave.Name = "biSave"
            Me.biClose.Caption = "Close"
            Me.biClose.Id = 2
            Me.biClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biClose.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biClose.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg"
            Me.biClose.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
            Me.biClose.Name = "biClose"
            Me.biSaveAndClose.Caption = "Save && Close"
            Me.biSaveAndClose.Id = 3
            Me.biSaveAndClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biSaveAndClose.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biSaveAndClose.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SaveAndClose.svg"
            Me.biSaveAndClose.Name = "biSaveAndClose"
            Me.biDelete.Caption = "Delete"
            Me.biDelete.Id = 4
            Me.biDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biDelete.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDelete.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg"
            Me.biDelete.Name = "biDelete"
            Me.biMailMerge.Caption = "Mail Merge"
            Me.biMailMerge.Id = 5
            Me.biMailMerge.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biMailMerge.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMailMerge.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.MailMerge.svg"
            Me.biMailMerge.Name = "biMailMerge"
            Me.biMeeting.Caption = "Meeting"
            Me.biMeeting.Id = 6
            Me.biMeeting.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biMeeting.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMeeting.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Meeting.svg"
            Me.biMeeting.Name = "biMeeting"
            Me.biPrintSubItem.Caption = "Print"
            Me.biPrintSubItem.Id = 8
            Me.biPrintSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biPrintSubItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPrintSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg"
            Me.biPrintSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintProfile),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintSummary),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintDirectory),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintTaskList)
            })
            Me.biPrintSubItem.Name = "biPrintSubItem"
            Me.biPrintSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiPrintProfile.Caption = "Employee Profile"
            Me.bmiPrintProfile.Id = 9
            Me.bmiPrintProfile.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiPrintProfile.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintProfile.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.EmployeeCard.svg?Size=16x16"
            Me.bmiPrintProfile.Name = "bmiPrintProfile"
            Me.bmiPrintSummary.Caption = "Summary Report"
            Me.bmiPrintSummary.Id = 10
            Me.bmiPrintSummary.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiPrintSummary.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintSummary.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Summary.svg?Size=16x16"
            Me.bmiPrintSummary.Name = "bmiPrintSummary"
            Me.bmiPrintDirectory.Caption = "Directory"
            Me.bmiPrintDirectory.Id = 12
            Me.bmiPrintDirectory.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiPrintDirectory.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintDirectory.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.EmployeeDirectory.svg?Size=16x16"
            Me.bmiPrintDirectory.Name = "bmiPrintDirectory"
            Me.bmiPrintTaskList.Caption = "Task List"
            Me.bmiPrintTaskList.Id = 13
            Me.bmiPrintTaskList.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bmiPrintTaskList.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintTaskList.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.TaskList.svg?Size=16x16"
            Me.bmiPrintTaskList.Name = "bmiPrintTaskList"
            Me.biTask.Caption = "Task"
            Me.biTask.Id = 11
            Me.biTask.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biTask.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Task.svg"
            Me.biTask.Name = "biTask"
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
            Me.galleryQuickLetters.Id = 14
            Me.galleryQuickLetters.Name = "galleryQuickLetters"
            Me.biShowMap.Caption = "Map It"
            Me.biShowMap.Id = 15
            Me.biShowMap.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biShowMap.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biShowMap.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Mapit.svg"
            Me.biShowMap.Name = "biShowMap"
            Me.biRefresh.Caption = "Reset Changes"
            Me.biRefresh.Id = 17
            Me.biRefresh.ImageOptions.Image = My.Resources.icon_reset_changes_16
            Me.biRefresh.ImageOptions.LargeImage = My.Resources.icon_reset_changes_32
            Me.biRefresh.Name = "biRefresh"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup7, Me.ribbonPageGroup2, Me.ribbonPageGroup4, Me.ribbonPageGroup5, Me.ribbonPageGroup6, Me.ribbonPageGroup3})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "CONTACT"
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biSave)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biSaveAndClose)
            Me.ribbonPageGroup1.MergeOrder = 0
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup1.Text = "Save"
            Me.ribbonPageGroup7.AllowTextClipping = False
            Me.ribbonPageGroup7.ItemLinks.Add(Me.biRefresh)
            Me.ribbonPageGroup7.MergeOrder = 0
            Me.ribbonPageGroup7.Name = "ribbonPageGroup7"
            Me.ribbonPageGroup7.ShowCaptionButton = False
            Me.ribbonPageGroup7.Text = "Edit"
            Me.ribbonPageGroup2.AllowTextClipping = False
            Me.ribbonPageGroup2.ItemLinks.Add(Me.biDelete)
            Me.ribbonPageGroup2.MergeOrder = 0
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.ShowCaptionButton = False
            Me.ribbonPageGroup2.Text = "Delete"
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biPrintSubItem)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biMeeting)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biTask)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biMailMerge)
            Me.ribbonPageGroup4.MergeOrder = 0
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.ShowCaptionButton = False
            Me.ribbonPageGroup4.Text = "Actions"
            Me.ribbonPageGroup5.ItemLinks.Add(Me.galleryQuickLetters)
            Me.ribbonPageGroup5.MergeOrder = 0
            Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
            Me.ribbonPageGroup5.ShowCaptionButton = False
            Me.ribbonPageGroup5.Text = "Quick Letters"
            Me.ribbonPageGroup6.AllowTextClipping = False
            Me.ribbonPageGroup6.ItemLinks.Add(Me.biShowMap)
            Me.ribbonPageGroup6.MergeOrder = 0
            Me.ribbonPageGroup6.Name = "ribbonPageGroup6"
            Me.ribbonPageGroup6.ShowCaptionButton = False
            Me.ribbonPageGroup6.Text = "View"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biClose)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.ShowCaptionButton = False
            Me.ribbonPageGroup3.Text = "Close"
            Me.ZipCodeTextEdit.EnterMoveNextControl = True
            Me.ZipCodeTextEdit.Location = New System.Drawing.Point(245, 200)
            Me.ZipCodeTextEdit.MenuManager = Me.ribbonControl
            Me.ZipCodeTextEdit.Name = "ZipCodeTextEdit"
            Me.ZipCodeTextEdit.Size = New System.Drawing.Size(294, 20)
            Me.ZipCodeTextEdit.StyleController = Me.moduleDataLayout
            Me.ZipCodeTextEdit.TabIndex = 22
            Me.StateImageComboBoxEdit.EnterMoveNextControl = True
            Me.StateImageComboBoxEdit.Location = New System.Drawing.Point(100, 200)
            Me.StateImageComboBoxEdit.MenuManager = Me.ribbonControl
            Me.StateImageComboBoxEdit.Name = "StateImageComboBoxEdit"
            Me.StateImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.StateImageComboBoxEdit.Properties.DropDownRows = 14
            Me.StateImageComboBoxEdit.Properties.Sorted = True
            Me.StateImageComboBoxEdit.Size = New System.Drawing.Size(94, 20)
            Me.StateImageComboBoxEdit.StyleController = Me.moduleDataLayout
            Me.StateImageComboBoxEdit.TabIndex = 21
            Me.CityTextEdit.EnterMoveNextControl = True
            Me.CityTextEdit.Location = New System.Drawing.Point(100, 176)
            Me.CityTextEdit.MenuManager = Me.ribbonControl
            Me.CityTextEdit.Name = "CityTextEdit"
            Me.CityTextEdit.Size = New System.Drawing.Size(439, 20)
            Me.CityTextEdit.StyleController = Me.moduleDataLayout
            Me.CityTextEdit.TabIndex = 20
            Me.AddressTextEdit.EnterMoveNextControl = True
            Me.AddressTextEdit.Location = New System.Drawing.Point(100, 152)
            Me.AddressTextEdit.MenuManager = Me.ribbonControl
            Me.AddressTextEdit.Name = "AddressTextEdit"
            Me.AddressTextEdit.Size = New System.Drawing.Size(439, 20)
            Me.AddressTextEdit.StyleController = Me.moduleDataLayout
            Me.AddressTextEdit.TabIndex = 19
            Me.gridControlTasks.DataBindings.Add(New System.Windows.Forms.Binding("DataSource", Me.bindingSource, "AssignedTasks", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.gridControlTasks.DataSource = Me.bindingSourceTasks
            Me.gridControlTasks.Location = New System.Drawing.Point(100, 368)
            Me.gridControlTasks.MainView = Me.gvTasks
            Me.gridControlTasks.Name = "gridControlTasks"
            Me.gridControlTasks.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemProgressBar1})
            Me.gridControlTasks.ShowOnlyPredefinedDetails = True
            Me.gridControlTasks.Size = New System.Drawing.Size(1097, 264)
            Me.gridControlTasks.TabIndex = 18
            Me.gridControlTasks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvTasks})
            Me.bindingSourceTasks.DataSource = GetType(DevExpress.DevAV.EmployeeTask)
            Me.gvTasks.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
            Me.gvTasks.Appearance.HideSelectionRow.Options.UseBackColor = True
            Me.gvTasks.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colPriority, Me.colDueDate, Me.colSubject1, Me.colDescription, Me.colCompletion})
            Me.gvTasks.GridControl = Me.gridControlTasks
            Me.gvTasks.Name = "gvTasks"
            Me.gvTasks.OptionsBehavior.FocusLeaveOnTab = True
            Me.gvTasks.PreviewFieldName = "Description"
            Me.gvTasks.PreviewIndent = 0
            Me.colPriority.Caption = "PRIORITY"
            Me.colPriority.FieldName = "Priority"
            Me.colPriority.Name = "colPriority"
            Me.colPriority.OptionsColumn.AllowEdit = False
            Me.colPriority.OptionsColumn.AllowFocus = False
            Me.colPriority.Visible = True
            Me.colPriority.VisibleIndex = 0
            Me.colPriority.Width = 65
            Me.colDueDate.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.colDueDate.AppearanceCell.Options.UseFont = True
            Me.colDueDate.Caption = "DUE DATE"
            Me.colDueDate.FieldName = "DueDate"
            Me.colDueDate.Name = "colDueDate"
            Me.colDueDate.OptionsColumn.AllowEdit = False
            Me.colDueDate.OptionsColumn.AllowFocus = False
            Me.colDueDate.Visible = True
            Me.colDueDate.VisibleIndex = 1
            Me.colDueDate.Width = 80
            Me.colSubject1.Caption = "SUBJECT"
            Me.colSubject1.FieldName = "Subject"
            Me.colSubject1.Name = "colSubject1"
            Me.colSubject1.OptionsColumn.AllowEdit = False
            Me.colSubject1.OptionsColumn.AllowFocus = False
            Me.colSubject1.Visible = True
            Me.colSubject1.VisibleIndex = 2
            Me.colSubject1.Width = 288
            Me.colDescription.Caption = "DESCRIPTION"
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.OptionsColumn.AllowEdit = False
            Me.colDescription.OptionsColumn.AllowFocus = False
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 3
            Me.colDescription.Width = 524
            Me.colCompletion.Caption = "COMPLETION"
            Me.colCompletion.ColumnEdit = Me.repositoryItemProgressBar1
            Me.colCompletion.FieldName = "Completion"
            Me.colCompletion.Name = "colCompletion"
            Me.colCompletion.OptionsColumn.AllowEdit = False
            Me.colCompletion.OptionsColumn.AllowFocus = False
            Me.colCompletion.Visible = True
            Me.colCompletion.VisibleIndex = 4
            Me.colCompletion.Width = 122
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            Me.repositoryItemProgressBar1.ShowTitle = True
            Me.gridControlEvaluations.DataBindings.Add(New System.Windows.Forms.Binding("DataSource", Me.bindingSource, "Evaluations", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.gridControlEvaluations.DataSource = Me.bindingSourceEvaluations
            Me.gridControlEvaluations.Location = New System.Drawing.Point(563, 122)
            Me.gridControlEvaluations.MainView = Me.gvEvaluations
            Me.gridControlEvaluations.Name = "gridControlEvaluations"
            Me.gridControlEvaluations.Size = New System.Drawing.Size(634, 222)
            Me.gridControlEvaluations.TabIndex = 6
            Me.gridControlEvaluations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvEvaluations})
            Me.bindingSourceEvaluations.DataSource = GetType(DevExpress.DevAV.Evaluation)
            Me.gvEvaluations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCreatedOn, Me.colSubject, Me.colCreatedBy})
            Me.gvEvaluations.GridControl = Me.gridControlEvaluations
            Me.gvEvaluations.Name = "gvEvaluations"
            Me.gvEvaluations.OptionsBehavior.FocusLeaveOnTab = True
            Me.gvEvaluations.OptionsSelection.EnableAppearanceHideSelection = False
            Me.gvEvaluations.PreviewFieldName = "Details"
            Me.gvEvaluations.PreviewIndent = 0
            Me.colCreatedOn.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.colCreatedOn.AppearanceCell.Options.UseFont = True
            Me.colCreatedOn.Caption = "CREATED ON"
            Me.colCreatedOn.FieldName = "CreatedOn"
            Me.colCreatedOn.Name = "colCreatedOn"
            Me.colCreatedOn.OptionsColumn.AllowEdit = False
            Me.colCreatedOn.OptionsColumn.AllowFocus = False
            Me.colCreatedOn.Visible = True
            Me.colCreatedOn.VisibleIndex = 0
            Me.colCreatedOn.Width = 88
            Me.colSubject.Caption = "SUBJECT"
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.OptionsColumn.AllowEdit = False
            Me.colSubject.OptionsColumn.AllowFocus = False
            Me.colSubject.Visible = True
            Me.colSubject.VisibleIndex = 1
            Me.colSubject.Width = 351
            Me.colCreatedBy.Caption = "MANAGER"
            Me.colCreatedBy.FieldName = "CreatedBy"
            Me.colCreatedBy.Name = "colCreatedBy"
            Me.colCreatedBy.OptionsColumn.AllowEdit = False
            Me.colCreatedBy.OptionsColumn.AllowFocus = False
            Me.colCreatedBy.Visible = True
            Me.colCreatedBy.VisibleIndex = 2
            Me.colCreatedBy.Width = 189
            Me.DepartmentImageComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Department", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.DepartmentImageComboBoxEdit.EnterMoveNextControl = True
            Me.DepartmentImageComboBoxEdit.Location = New System.Drawing.Point(651, 12)
            Me.DepartmentImageComboBoxEdit.MenuManager = Me.ribbonControl
            Me.DepartmentImageComboBoxEdit.Name = "DepartmentImageComboBoxEdit"
            Me.DepartmentImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DepartmentImageComboBoxEdit.Size = New System.Drawing.Size(546, 20)
            Me.DepartmentImageComboBoxEdit.StyleController = Me.moduleDataLayout
            Me.DepartmentImageComboBoxEdit.TabIndex = 4
            Me.TitleTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Title", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.TitleTextEdit.EnterMoveNextControl = True
            Me.TitleTextEdit.Location = New System.Drawing.Point(100, 108)
            Me.TitleTextEdit.MenuManager = Me.ribbonControl
            Me.TitleTextEdit.Name = "TitleTextEdit"
            Me.TitleTextEdit.Properties.ValidateOnEnterKey = True
            Me.TitleTextEdit.Size = New System.Drawing.Size(200, 20)
            Me.TitleTextEdit.StyleController = Me.moduleDataLayout
            Me.TitleTextEdit.TabIndex = 5
            Me.StatusImageComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Status", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.StatusImageComboBoxEdit.EnterMoveNextControl = True
            Me.StatusImageComboBoxEdit.Location = New System.Drawing.Point(651, 36)
            Me.StatusImageComboBoxEdit.MenuManager = Me.ribbonControl
            Me.StatusImageComboBoxEdit.Name = "StatusImageComboBoxEdit"
            Me.StatusImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.StatusImageComboBoxEdit.Size = New System.Drawing.Size(546, 20)
            Me.StatusImageComboBoxEdit.StyleController = Me.moduleDataLayout
            Me.StatusImageComboBoxEdit.TabIndex = 6
            Me.HireDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "HireDate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.HireDateDateEdit.EditValue = Nothing
            Me.HireDateDateEdit.EnterMoveNextControl = True
            Me.HireDateDateEdit.Location = New System.Drawing.Point(651, 60)
            Me.HireDateDateEdit.MenuManager = Me.ribbonControl
            Me.HireDateDateEdit.Name = "HireDateDateEdit"
            Me.HireDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.HireDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.HireDateDateEdit.Size = New System.Drawing.Size(546, 20)
            Me.HireDateDateEdit.StyleController = Me.moduleDataLayout
            Me.HireDateDateEdit.TabIndex = 7
            Me.FirstNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "FirstName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.FirstNameTextEdit.EnterMoveNextControl = True
            Me.FirstNameTextEdit.Location = New System.Drawing.Point(100, 12)
            Me.FirstNameTextEdit.MenuManager = Me.ribbonControl
            Me.FirstNameTextEdit.Name = "FirstNameTextEdit"
            Me.FirstNameTextEdit.Properties.ValidateOnEnterKey = True
            Me.FirstNameTextEdit.Size = New System.Drawing.Size(313, 20)
            Me.FirstNameTextEdit.StyleController = Me.moduleDataLayout
            Me.FirstNameTextEdit.TabIndex = 8
            Me.LastNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "LastName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.LastNameTextEdit.EnterMoveNextControl = True
            Me.LastNameTextEdit.Location = New System.Drawing.Point(100, 36)
            Me.LastNameTextEdit.MenuManager = Me.ribbonControl
            Me.LastNameTextEdit.Name = "LastNameTextEdit"
            Me.LastNameTextEdit.Properties.ValidateOnEnterKey = True
            Me.LastNameTextEdit.Size = New System.Drawing.Size(313, 20)
            Me.LastNameTextEdit.StyleController = Me.moduleDataLayout
            Me.LastNameTextEdit.TabIndex = 9
            Me.PrefixImageComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Prefix", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.PrefixImageComboBoxEdit.EnterMoveNextControl = True
            Me.PrefixImageComboBoxEdit.Location = New System.Drawing.Point(337, 108)
            Me.PrefixImageComboBoxEdit.MenuManager = Me.ribbonControl
            Me.PrefixImageComboBoxEdit.Name = "PrefixImageComboBoxEdit"
            Me.PrefixImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.PrefixImageComboBoxEdit.Size = New System.Drawing.Size(76, 20)
            Me.PrefixImageComboBoxEdit.StyleController = Me.moduleDataLayout
            Me.PrefixImageComboBoxEdit.TabIndex = 11
            Me.BirthDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "BirthDate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.BirthDateDateEdit.EditValue = Nothing
            Me.BirthDateDateEdit.EnterMoveNextControl = True
            Me.BirthDateDateEdit.Location = New System.Drawing.Point(100, 84)
            Me.BirthDateDateEdit.MenuManager = Me.ribbonControl
            Me.BirthDateDateEdit.Name = "BirthDateDateEdit"
            Me.BirthDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.BirthDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.BirthDateDateEdit.Size = New System.Drawing.Size(313, 20)
            Me.BirthDateDateEdit.StyleController = Me.moduleDataLayout
            Me.BirthDateDateEdit.TabIndex = 16
            Me.PhotoPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
            Me.PhotoPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Photo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.PhotoPictureEdit.Location = New System.Drawing.Point(435, 12)
            Me.PhotoPictureEdit.MenuManager = Me.ribbonControl
            Me.PhotoPictureEdit.Name = "PhotoPictureEdit"
            Me.PhotoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
            Me.PhotoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.PhotoPictureEdit.Properties.ZoomAccelerationFactor = 1R
            Me.PhotoPictureEdit.Size = New System.Drawing.Size(104, 116)
            Me.PhotoPictureEdit.StyleController = Me.moduleDataLayout
            Me.PhotoPictureEdit.TabIndex = 17
            Me.HomePhoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "HomePhone", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.HomePhoneTextEdit.EnterMoveNextControl = True
            Me.HomePhoneTextEdit.Location = New System.Drawing.Point(100, 244)
            Me.HomePhoneTextEdit.MenuManager = Me.ribbonControl
            Me.HomePhoneTextEdit.Name = "HomePhoneTextEdit"
            Me.HomePhoneTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, My.Resources.icon_home_phone_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
            Me.HomePhoneTextEdit.Properties.ValidateOnEnterKey = True
            Me.HomePhoneTextEdit.Size = New System.Drawing.Size(439, 22)
            Me.HomePhoneTextEdit.StyleController = Me.moduleDataLayout
            Me.HomePhoneTextEdit.TabIndex = 12
            Me.MobilePhoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "MobilePhone", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.MobilePhoneTextEdit.EnterMoveNextControl = True
            Me.MobilePhoneTextEdit.Location = New System.Drawing.Point(100, 270)
            Me.MobilePhoneTextEdit.MenuManager = Me.ribbonControl
            Me.MobilePhoneTextEdit.Name = "MobilePhoneTextEdit"
            Me.MobilePhoneTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, My.Resources.icon_mobile_phone_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True)})
            Me.MobilePhoneTextEdit.Properties.ValidateOnEnterKey = True
            Me.MobilePhoneTextEdit.Size = New System.Drawing.Size(439, 22)
            Me.MobilePhoneTextEdit.StyleController = Me.moduleDataLayout
            Me.MobilePhoneTextEdit.TabIndex = 13
            Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Email", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.EmailTextEdit.EnterMoveNextControl = True
            Me.EmailTextEdit.Location = New System.Drawing.Point(100, 296)
            Me.EmailTextEdit.MenuManager = Me.ribbonControl
            Me.EmailTextEdit.Name = "EmailTextEdit"
            Me.EmailTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, My.Resources.icon_email_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", Nothing, Nothing, True)})
            Me.EmailTextEdit.Properties.ValidateOnEnterKey = True
            Me.EmailTextEdit.Size = New System.Drawing.Size(439, 22)
            Me.EmailTextEdit.StyleController = Me.moduleDataLayout
            Me.EmailTextEdit.TabIndex = 14
            Me.SkypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Skype", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.SkypeTextEdit.EnterMoveNextControl = True
            Me.SkypeTextEdit.Location = New System.Drawing.Point(100, 322)
            Me.SkypeTextEdit.MenuManager = Me.ribbonControl
            Me.SkypeTextEdit.Name = "SkypeTextEdit"
            Me.SkypeTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, My.Resources.icon_skype_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", Nothing, Nothing, True)})
            Me.SkypeTextEdit.Properties.ValidateOnEnterKey = True
            Me.SkypeTextEdit.Size = New System.Drawing.Size(439, 22)
            Me.SkypeTextEdit.StyleController = Me.moduleDataLayout
            Me.SkypeTextEdit.TabIndex = 15
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2, Me.ItemForTasks})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 25
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1209, 644)
            Me.layoutControlGroup1.TextVisible = False
            Me.layoutControlGroup2.AllowDrawBackground = False
            Me.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForFirstName, Me.ItemForLastName, Me.ItemForPrefix, Me.ItemForDepartment, Me.ItemForStatus, Me.ItemForEvaluations, Me.ItemForHomePhone, Me.ItemForMobilePhone, Me.ItemForEmail, Me.ItemForSkype, Me.ItemForPhoto, Me.emptySpaceItem1, Me.ItemForAddress, Me.ItemForCity, Me.ItemForState, Me.ItemForZipCode, Me.emptySpaceItem2, Me.ItemForFullName, Me.ItemForHireDate, Me.ItemForBirthDate, Me.emptySpaceItem3, Me.emptySpaceItem4, Me.emptySpaceItem5, Me.ItemForTitle})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(1189, 356)
            Me.ItemForFirstName.Control = Me.FirstNameTextEdit
            Me.ItemForFirstName.CustomizationFormText = "First Name"
            Me.ItemForFirstName.Location = New System.Drawing.Point(0, 0)
            Me.ItemForFirstName.Name = "ItemForFirstName"
            Me.ItemForFirstName.Size = New System.Drawing.Size(405, 24)
            Me.ItemForFirstName.Text = "First Name"
            Me.ItemForFirstName.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForLastName.Control = Me.LastNameTextEdit
            Me.ItemForLastName.CustomizationFormText = "Last Name"
            Me.ItemForLastName.Location = New System.Drawing.Point(0, 24)
            Me.ItemForLastName.Name = "ItemForLastName"
            Me.ItemForLastName.Size = New System.Drawing.Size(405, 24)
            Me.ItemForLastName.Text = "Last Name"
            Me.ItemForLastName.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForPrefix.Control = Me.PrefixImageComboBoxEdit
            Me.ItemForPrefix.CustomizationFormText = "Prefix"
            Me.ItemForPrefix.Location = New System.Drawing.Point(292, 96)
            Me.ItemForPrefix.Name = "ItemForPrefix"
            Me.ItemForPrefix.Size = New System.Drawing.Size(113, 24)
            Me.ItemForPrefix.Text = "Prefix"
            Me.ItemForPrefix.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.ItemForPrefix.TextSize = New System.Drawing.Size(28, 13)
            Me.ItemForPrefix.TextToControlDistance = 5
            Me.ItemForDepartment.Control = Me.DepartmentImageComboBoxEdit
            Me.ItemForDepartment.CustomizationFormText = "Department"
            Me.ItemForDepartment.Location = New System.Drawing.Point(551, 0)
            Me.ItemForDepartment.Name = "ItemForDepartment"
            Me.ItemForDepartment.Size = New System.Drawing.Size(638, 24)
            Me.ItemForDepartment.Text = "Department"
            Me.ItemForDepartment.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForStatus.Control = Me.StatusImageComboBoxEdit
            Me.ItemForStatus.CustomizationFormText = "Status"
            Me.ItemForStatus.Location = New System.Drawing.Point(551, 24)
            Me.ItemForStatus.Name = "ItemForStatus"
            Me.ItemForStatus.Size = New System.Drawing.Size(638, 24)
            Me.ItemForStatus.Text = "Status"
            Me.ItemForStatus.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForEvaluations.Control = Me.gridControlEvaluations
            Me.ItemForEvaluations.CustomizationFormText = "Evaluations"
            Me.ItemForEvaluations.Location = New System.Drawing.Point(551, 92)
            Me.ItemForEvaluations.Name = "ItemForEvaluations"
            Me.ItemForEvaluations.Size = New System.Drawing.Size(638, 244)
            Me.ItemForEvaluations.Text = "Evaluations"
            Me.ItemForEvaluations.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.ItemForEvaluations.TextLocation = DevExpress.Utils.Locations.Top
            Me.ItemForEvaluations.TextSize = New System.Drawing.Size(55, 13)
            Me.ItemForEvaluations.TextToControlDistance = 5
            Me.ItemForHomePhone.Control = Me.HomePhoneTextEdit
            Me.ItemForHomePhone.CustomizationFormText = "Home Phone"
            Me.ItemForHomePhone.Location = New System.Drawing.Point(0, 232)
            Me.ItemForHomePhone.Name = "ItemForHomePhone"
            Me.ItemForHomePhone.Size = New System.Drawing.Size(531, 26)
            Me.ItemForHomePhone.Text = "Home Phone"
            Me.ItemForHomePhone.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForMobilePhone.Control = Me.MobilePhoneTextEdit
            Me.ItemForMobilePhone.CustomizationFormText = "Mobile Phone"
            Me.ItemForMobilePhone.Location = New System.Drawing.Point(0, 258)
            Me.ItemForMobilePhone.Name = "ItemForMobilePhone"
            Me.ItemForMobilePhone.Size = New System.Drawing.Size(531, 26)
            Me.ItemForMobilePhone.Text = "Mobile Phone"
            Me.ItemForMobilePhone.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForEmail.Control = Me.EmailTextEdit
            Me.ItemForEmail.CustomizationFormText = "Email"
            Me.ItemForEmail.Location = New System.Drawing.Point(0, 284)
            Me.ItemForEmail.Name = "ItemForEmail"
            Me.ItemForEmail.Size = New System.Drawing.Size(531, 26)
            Me.ItemForEmail.Text = "Email"
            Me.ItemForEmail.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForSkype.Control = Me.SkypeTextEdit
            Me.ItemForSkype.CustomizationFormText = "Skype"
            Me.ItemForSkype.Location = New System.Drawing.Point(0, 310)
            Me.ItemForSkype.Name = "ItemForSkype"
            Me.ItemForSkype.Size = New System.Drawing.Size(531, 26)
            Me.ItemForSkype.Text = "Skype"
            Me.ItemForSkype.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForPhoto.Control = Me.PhotoPictureEdit
            Me.ItemForPhoto.CustomizationFormText = "Photo"
            Me.ItemForPhoto.Location = New System.Drawing.Point(405, 0)
            Me.ItemForPhoto.Name = "ItemForPhoto"
            Me.ItemForPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2)
            Me.ItemForPhoto.Size = New System.Drawing.Size(126, 120)
            Me.ItemForPhoto.Text = "Photo:"
            Me.ItemForPhoto.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForPhoto.TextVisible = False
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 120)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 20)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 20)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(531, 20)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForAddress.Control = Me.AddressTextEdit
            Me.ItemForAddress.CustomizationFormText = "Address"
            Me.ItemForAddress.Location = New System.Drawing.Point(0, 140)
            Me.ItemForAddress.Name = "ItemForAddress"
            Me.ItemForAddress.Size = New System.Drawing.Size(531, 24)
            Me.ItemForAddress.Text = "Address"
            Me.ItemForAddress.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForCity.Control = Me.CityTextEdit
            Me.ItemForCity.CustomizationFormText = "City"
            Me.ItemForCity.Location = New System.Drawing.Point(0, 164)
            Me.ItemForCity.Name = "ItemForCity"
            Me.ItemForCity.Size = New System.Drawing.Size(531, 24)
            Me.ItemForCity.Text = "City"
            Me.ItemForCity.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForState.Control = Me.StateImageComboBoxEdit
            Me.ItemForState.CustomizationFormText = "State"
            Me.ItemForState.Location = New System.Drawing.Point(0, 188)
            Me.ItemForState.Name = "ItemForState"
            Me.ItemForState.Size = New System.Drawing.Size(186, 24)
            Me.ItemForState.Text = "State"
            Me.ItemForState.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForZipCode.Control = Me.ZipCodeTextEdit
            Me.ItemForZipCode.CustomizationFormText = "ZipCode"
            Me.ItemForZipCode.Location = New System.Drawing.Point(186, 188)
            Me.ItemForZipCode.Name = "ItemForZipCode"
            Me.ItemForZipCode.Size = New System.Drawing.Size(345, 24)
            Me.ItemForZipCode.Text = "ZIP code"
            Me.ItemForZipCode.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.ItemForZipCode.TextSize = New System.Drawing.Size(42, 13)
            Me.ItemForZipCode.TextToControlDistance = 5
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 212)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 20)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(10, 20)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(531, 20)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForFullName.Control = Me.FullNameTextEdit
            Me.ItemForFullName.CustomizationFormText = "Full Name"
            Me.ItemForFullName.Location = New System.Drawing.Point(0, 48)
            Me.ItemForFullName.Name = "ItemForFullName"
            Me.ItemForFullName.Size = New System.Drawing.Size(405, 24)
            Me.ItemForFullName.Text = "Full Name"
            Me.ItemForFullName.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForHireDate.Control = Me.HireDateDateEdit
            Me.ItemForHireDate.CustomizationFormText = "Hire Date"
            Me.ItemForHireDate.Location = New System.Drawing.Point(551, 48)
            Me.ItemForHireDate.Name = "ItemForHireDate"
            Me.ItemForHireDate.Size = New System.Drawing.Size(638, 24)
            Me.ItemForHireDate.Text = "Hire Date"
            Me.ItemForHireDate.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForBirthDate.Control = Me.BirthDateDateEdit
            Me.ItemForBirthDate.CustomizationFormText = "Birth Date"
            Me.ItemForBirthDate.Location = New System.Drawing.Point(0, 72)
            Me.ItemForBirthDate.Name = "ItemForBirthDate"
            Me.ItemForBirthDate.Size = New System.Drawing.Size(405, 24)
            Me.ItemForBirthDate.Text = "Birth Date"
            Me.ItemForBirthDate.TextSize = New System.Drawing.Size(63, 13)
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 336)
            Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 20)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 20)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(1189, 20)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.emptySpaceItem4.AllowHotTrack = False
            Me.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4"
            Me.emptySpaceItem4.Location = New System.Drawing.Point(531, 0)
            Me.emptySpaceItem4.MaxSize = New System.Drawing.Size(20, 0)
            Me.emptySpaceItem4.MinSize = New System.Drawing.Size(20, 10)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(20, 336)
            Me.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.emptySpaceItem5.AllowHotTrack = False
            Me.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5"
            Me.emptySpaceItem5.Location = New System.Drawing.Point(551, 72)
            Me.emptySpaceItem5.MaxSize = New System.Drawing.Size(0, 20)
            Me.emptySpaceItem5.MinSize = New System.Drawing.Size(10, 20)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(638, 20)
            Me.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForTitle.Control = Me.TitleTextEdit
            Me.ItemForTitle.CustomizationFormText = "Title"
            Me.ItemForTitle.Location = New System.Drawing.Point(0, 96)
            Me.ItemForTitle.Name = "ItemForTitle"
            Me.ItemForTitle.Size = New System.Drawing.Size(292, 24)
            Me.ItemForTitle.Text = "Title"
            Me.ItemForTitle.TextSize = New System.Drawing.Size(63, 13)
            Me.ItemForTasks.AppearanceItemCaption.Options.UseTextOptions = True
            Me.ItemForTasks.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.ItemForTasks.Control = Me.gridControlTasks
            Me.ItemForTasks.CustomizationFormText = "TASKS"
            Me.ItemForTasks.Location = New System.Drawing.Point(0, 356)
            Me.ItemForTasks.Name = "ItemForTasks"
            Me.ItemForTasks.Size = New System.Drawing.Size(1189, 268)
            Me.ItemForTasks.Text = "Tasks"
            Me.ItemForTasks.TextSize = New System.Drawing.Size(63, 13)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleDataLayout)
            Me.Controls.Add(Me.ribbonControl)
            Me.Name = "EmployeeEditView"
            Me.Size = New System.Drawing.Size(1209, 785)
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.moduleDataLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleDataLayout.ResumeLayout(False)
            CType(Me.FullNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ZipCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StateImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControlTasks, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSourceTasks, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gvTasks, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControlEvaluations, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSourceEvaluations, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gvEvaluations, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DepartmentImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TitleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StatusImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.HireDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.HireDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PrefixImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BirthDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BirthDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PhotoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.HomePhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MobilePhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SkypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForFirstName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForLastName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForPrefix, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForDepartment, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForStatus, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForEvaluations, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForHomePhone, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForMobilePhone, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForSkype, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForPhoto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForCity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForState, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForZipCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForFullName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForHireDate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForBirthDate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForTasks, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbonControl As XtraBars.Ribbon.RibbonControl
        Private biSave As XtraBars.BarButtonItem
        Private biClose As XtraBars.BarButtonItem
        Private biSaveAndClose As XtraBars.BarButtonItem
        Private biDelete As XtraBars.BarButtonItem
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
        Private moduleDataLayout As XtraDataLayout.DataLayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private bindingSource As System.Windows.Forms.BindingSource
        Private DepartmentImageComboBoxEdit As XtraEditors.ImageComboBoxEdit
        Private TitleTextEdit As XtraEditors.TextEdit
        Private StatusImageComboBoxEdit As XtraEditors.ImageComboBoxEdit
        Private HireDateDateEdit As XtraEditors.DateEdit
        Private FirstNameTextEdit As XtraEditors.TextEdit
        Private LastNameTextEdit As XtraEditors.TextEdit
        Private PrefixImageComboBoxEdit As XtraEditors.ImageComboBoxEdit
        Private BirthDateDateEdit As XtraEditors.DateEdit
        Private PhotoPictureEdit As XtraEditors.PictureEdit
        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
        Private ItemForHomePhone As XtraLayout.LayoutControlItem
        Private ItemForMobilePhone As XtraLayout.LayoutControlItem
        Private ItemForEmail As XtraLayout.LayoutControlItem
        Private ItemForSkype As XtraLayout.LayoutControlItem
        Private ItemForFirstName As XtraLayout.LayoutControlItem
        Private ItemForPhoto As XtraLayout.LayoutControlItem
        Private ItemForLastName As XtraLayout.LayoutControlItem
        Private ItemForPrefix As XtraLayout.LayoutControlItem
        Private ItemForTitle As XtraLayout.LayoutControlItem
        Private ItemForDepartment As XtraLayout.LayoutControlItem
        Private ItemForStatus As XtraLayout.LayoutControlItem
        Private ItemForHireDate As XtraLayout.LayoutControlItem
        Private ItemForBirthDate As XtraLayout.LayoutControlItem
        Private gridControlEvaluations As XtraGrid.GridControl
        Private ItemForEvaluations As XtraLayout.LayoutControlItem
        Private bindingSourceEvaluations As System.Windows.Forms.BindingSource
        Private gridControlTasks As XtraGrid.GridControl
        Private ItemForTasks As XtraLayout.LayoutControlItem
        Private bindingSourceTasks As System.Windows.Forms.BindingSource
        Private FullNameTextEdit As XtraEditors.TextEdit
        Private ZipCodeTextEdit As XtraEditors.TextEdit
        Private StateImageComboBoxEdit As XtraEditors.ImageComboBoxEdit
        Private CityTextEdit As XtraEditors.TextEdit
        Private AddressTextEdit As XtraEditors.TextEdit
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private ItemForAddress As XtraLayout.LayoutControlItem
        Private ItemForCity As XtraLayout.LayoutControlItem
        Private ItemForState As XtraLayout.LayoutControlItem
        Private ItemForZipCode As XtraLayout.LayoutControlItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private ItemForFullName As XtraLayout.LayoutControlItem
        Private HomePhoneTextEdit As XtraEditors.ButtonEdit
        Private MobilePhoneTextEdit As XtraEditors.ButtonEdit
        Private EmailTextEdit As XtraEditors.ButtonEdit
        Private SkypeTextEdit As XtraEditors.ButtonEdit
        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem4 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem5 As XtraLayout.EmptySpaceItem
        Private colCreatedOn As XtraGrid.Columns.GridColumn
        Private colSubject As XtraGrid.Columns.GridColumn
        Private colCreatedBy As XtraGrid.Columns.GridColumn
        Private WithEvents gvEvaluations As TaskPreviewGridView
        Private colDueDate As XtraGrid.Columns.GridColumn
        Private colSubject1 As XtraGrid.Columns.GridColumn
        Private gvTasks As TaskPreviewGridView
        Private ribbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
        Private biMailMerge As XtraBars.BarButtonItem
        Private biMeeting As XtraBars.BarButtonItem
        Private biPrintSubItem As XtraBars.BarSubItem
        Private bmiPrintProfile As XtraBars.BarButtonItem
        Private bmiPrintSummary As XtraBars.BarButtonItem
        Private biTask As XtraBars.BarButtonItem
        Private bmiPrintDirectory As XtraBars.BarButtonItem
        Private bmiPrintTaskList As XtraBars.BarButtonItem
        Private galleryQuickLetters As XtraBars.RibbonGalleryBarItem
        Private ribbonPageGroup5 As XtraBars.Ribbon.RibbonPageGroup
        Private biShowMap As XtraBars.BarButtonItem
        Private ribbonPageGroup6 As XtraBars.Ribbon.RibbonPageGroup
        Private biRefresh As XtraBars.BarButtonItem
        Private ribbonPageGroup7 As XtraBars.Ribbon.RibbonPageGroup
        Private colDescription As XtraGrid.Columns.GridColumn
        Private colPriority As XtraGrid.Columns.GridColumn
        Private colCompletion As XtraGrid.Columns.GridColumn
        Private repositoryItemProgressBar1 As XtraEditors.Repository.RepositoryItemProgressBar
    End Class
End Namespace
