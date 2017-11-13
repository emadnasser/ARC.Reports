﻿Namespace DevExpress.XtraEditors.Demos.Modules.Overview
	Partial Public Class EmployeeView
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
			Dim stubGlyphOptions1 As New DevExpress.Utils.Drawing.StubGlyphOptions()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(EmployeeView))
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
			Me.FirstNameTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
			Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
			Me.barButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
			Me.ribbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.barButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.LastNameTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.PrefixImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.DepartmentImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.StatusImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.gridControlEvaluations = New DevExpress.XtraGrid.GridControl()
			Me.evaluationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.gvEvaluations = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.HomePhoneTextEdit = New DevExpress.XtraEditors.ButtonEdit()
			Me.MobilePhoneTextEdit = New DevExpress.XtraEditors.ButtonEdit()
			Me.EmailTextEdit = New DevExpress.XtraEditors.ButtonEdit()
			Me.SkypeTextEdit = New DevExpress.XtraEditors.ButtonEdit()
			Me.PhotoPictureEdit = New DevExpress.XtraEditors.PictureEdit()
			Me.AddressTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.CityTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.StateImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.ZipCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.FullNameTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.HireDateDateEdit = New DevExpress.XtraEditors.DateEdit()
			Me.BirthDateDateEdit = New DevExpress.XtraEditors.DateEdit()
			Me.TitleTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.gridControlTasks = New DevExpress.XtraGrid.GridControl()
			Me.assignedTasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.gvTasks = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSubject1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCompletion = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.autoGeneratedGroup0 = New DevExpress.XtraLayout.LayoutControlGroup()
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
			Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
			DirectCast(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dataLayoutControl1.SuspendLayout()
			DirectCast(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.PrefixImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.DepartmentImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.StatusImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridControlEvaluations, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.evaluationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gvEvaluations, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.HomePhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.MobilePhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.SkypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.PhotoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.CityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.StateImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ZipCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.FullNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.HireDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.HireDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.BirthDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.BirthDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.TitleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridControlTasks, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.assignedTasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.autoGeneratedGroup0, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForLastName, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForPrefix, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForStatus, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForEvaluations, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForHomePhone, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForMobilePhone, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForSkype, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForCity, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForState, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForZipCode, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForFullName, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForHireDate, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForBirthDate, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForTitle, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ItemForTasks, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.behaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataLayoutControl1
			' 
			Me.dataLayoutControl1.AllowCustomization = False
			Me.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True
			Me.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True
			Me.dataLayoutControl1.Controls.Add(Me.FirstNameTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.LastNameTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.PrefixImageComboBoxEdit)
			Me.dataLayoutControl1.Controls.Add(Me.DepartmentImageComboBoxEdit)
			Me.dataLayoutControl1.Controls.Add(Me.StatusImageComboBoxEdit)
			Me.dataLayoutControl1.Controls.Add(Me.gridControlEvaluations)
			Me.dataLayoutControl1.Controls.Add(Me.HomePhoneTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.MobilePhoneTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.EmailTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.SkypeTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.PhotoPictureEdit)
			Me.dataLayoutControl1.Controls.Add(Me.AddressTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.CityTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.StateImageComboBoxEdit)
			Me.dataLayoutControl1.Controls.Add(Me.ZipCodeTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.FullNameTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.HireDateDateEdit)
			Me.dataLayoutControl1.Controls.Add(Me.BirthDateDateEdit)
			Me.dataLayoutControl1.Controls.Add(Me.TitleTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.gridControlTasks)
			Me.dataLayoutControl1.DataSource = Me.bindingSource
			Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataLayoutControl1.Location = New System.Drawing.Point(5, 0)
			Me.dataLayoutControl1.Name = "dataLayoutControl1"
			Me.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(421, 117, 1099, 808)
			Me.dataLayoutControl1.Root = Me.layoutControlGroup1
			Me.dataLayoutControl1.Size = New System.Drawing.Size(1010, 571)
			Me.dataLayoutControl1.TabIndex = 0
			Me.dataLayoutControl1.Text = "dataLayoutControl1"
			' 
			' FirstNameTextEdit
			' 
			Me.FirstNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "FirstName", True))
			Me.FirstNameTextEdit.EnterMoveNextControl = True
			Me.FirstNameTextEdit.Location = New System.Drawing.Point(78, 12)
			Me.FirstNameTextEdit.MenuManager = Me.ribbonControl1
			Me.FirstNameTextEdit.Name = "FirstNameTextEdit"
			Me.FirstNameTextEdit.Properties.ValidateOnEnterKey = True
			Me.FirstNameTextEdit.Size = New System.Drawing.Size(287, 20)
			Me.FirstNameTextEdit.StyleController = Me.dataLayoutControl1
			Me.FirstNameTextEdit.TabIndex = 8
			' 
			' bindingSource
			' 
			Me.bindingSource.DataSource = GetType(DevExpress.XtraEditors.Demos.Modules.Overview.Employee)
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5, Me.barButtonItem6, Me.barSubItem1, Me.barButtonItem7, Me.barButtonItem8, Me.barButtonItem11, Me.barButtonItem9, Me.barButtonItem10, Me.ribbonGalleryBarItem1, Me.barButtonItem12, Me.barButtonItem13})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 18
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.Size = New System.Drawing.Size(1209, 141)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
			Me.barButtonItem1.Caption = "Save"
			Me.barButtonItem1.Id = 1
			Me.barButtonItem1.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Save.svg"
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
			Me.barButtonItem2.Caption = "Close"
			Me.barButtonItem2.Id = 2
			Me.barButtonItem2.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg"
			Me.barButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
			Me.barButtonItem3.Caption = "Save && Close"
			Me.barButtonItem3.Id = 3
			Me.barButtonItem3.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SaveAndClose.svg"
			Me.barButtonItem3.Name = "barButtonItem3"
			' 
			' barButtonItem4
			' 
			Me.barButtonItem4.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
			Me.barButtonItem4.Caption = "Delete"
			Me.barButtonItem4.Id = 4
			Me.barButtonItem4.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg"
			Me.barButtonItem4.Name = "barButtonItem4"
			' 
			' barButtonItem5
			' 
			Me.barButtonItem5.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
			Me.barButtonItem5.Caption = "Mail Merge"
			Me.barButtonItem5.Id = 5
			Me.barButtonItem5.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.MailMerge.svg"
			Me.barButtonItem5.Name = "barButtonItem5"
			' 
			' barButtonItem6
			' 
			Me.barButtonItem6.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
			Me.barButtonItem6.Caption = "Meeting"
			Me.barButtonItem6.Id = 6
			Me.barButtonItem6.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Meeting.svg"
			Me.barButtonItem6.Name = "barButtonItem6"
			' 
			' barSubItem1
			' 
			Me.barSubItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
			Me.barSubItem1.Caption = "Print"
			Me.barSubItem1.Id = 8
            Me.barSubItem1.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg"
            Me.barSubItem1.Name = "barSubItem1"
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem7),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem8),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem9),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem10)
            })
            Me.barSubItem1.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
			' 
			' barButtonItem7
			' 
			Me.barButtonItem7.Caption = "Employee Profile"
			Me.barButtonItem7.Id = 9
			Me.barButtonItem7.Name = "barButtonItem7"
			' 
			' barButtonItem8
			' 
			Me.barButtonItem8.Caption = "Summary Report"
			Me.barButtonItem8.Id = 10
			Me.barButtonItem8.Name = "barButtonItem8"
			' 
			' barButtonItem9
			' 
			Me.barButtonItem9.Caption = "Directory"
			Me.barButtonItem9.Id = 12
			Me.barButtonItem9.Name = "barButtonItem9"
			' 
			' barButtonItem10
			' 
			Me.barButtonItem10.Caption = "Task List"
			Me.barButtonItem10.Id = 13
			Me.barButtonItem10.Name = "barButtonItem10"
			' 
			' barButtonItem11
			' 
			Me.barButtonItem11.Caption = "Task"
			Me.barButtonItem11.Id = 11
			Me.barButtonItem11.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Task.svg"
			Me.barButtonItem11.Name = "barButtonItem11"
			' 
			' ribbonGalleryBarItem1
			' 
			Me.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1"
			' 
			' 
			' 
			Me.ribbonGalleryBarItem1.Gallery.ColumnCount = 2
			Me.ribbonGalleryBarItem1.Gallery.DrawImageBackground = False
			galleryItemGroup1.Caption = "Group1"
			galleryItem1.Caption = "Thank You Note"
			galleryItem2.Caption = "Employee Award"
			galleryItem3.Caption = "Service Excellence"
			galleryItem4.Caption = "Probation Notice"
			galleryItem5.Caption = "Welcome To DevAV"
			galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2, galleryItem3, galleryItem4, galleryItem5})
			Me.ribbonGalleryBarItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.ribbonGalleryBarItem1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			skinPaddingEdges1.Bottom = -3
			skinPaddingEdges1.Top = -3
			Me.ribbonGalleryBarItem1.Gallery.ItemImagePadding = skinPaddingEdges1
			skinPaddingEdges2.Bottom = -1
			skinPaddingEdges2.Top = -1
			Me.ribbonGalleryBarItem1.Gallery.ItemTextPadding = skinPaddingEdges2
			Me.ribbonGalleryBarItem1.Gallery.ShowItemText = True
			Me.ribbonGalleryBarItem1.Id = 14
			Me.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1"
			' 
			' barButtonItem12
			' 
			Me.barButtonItem12.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
			Me.barButtonItem12.Caption = "Map It"
			Me.barButtonItem12.Id = 15
			Me.barButtonItem12.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Mapit.svg"
			Me.barButtonItem12.Name = "barButtonItem12"
			' 
			' barButtonItem13
			' 
			Me.barButtonItem13.Caption = "Reset Changes"
			Me.barButtonItem13.Id = 17
			Me.barButtonItem13.Name = "barButtonItem13"
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3, Me.ribbonPageGroup4, Me.ribbonPageGroup5, Me.ribbonPageGroup6, Me.ribbonPageGroup7})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "CONTACT"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem3)
			Me.ribbonPageGroup1.MergeOrder = 0
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.ShowCaptionButton = False
			Me.ribbonPageGroup1.Text = "Save"
			' 
			' ribbonPageGroup2
			' 
			Me.ribbonPageGroup2.AllowTextClipping = False
			Me.ribbonPageGroup2.ItemLinks.Add(Me.barButtonItem13)
			Me.ribbonPageGroup2.MergeOrder = 0
			Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
			Me.ribbonPageGroup2.ShowCaptionButton = False
			Me.ribbonPageGroup2.Text = "Edit"
			' 
			' ribbonPageGroup3
			' 
			Me.ribbonPageGroup3.AllowTextClipping = False
			Me.ribbonPageGroup3.ItemLinks.Add(Me.barButtonItem4)
			Me.ribbonPageGroup3.MergeOrder = 0
			Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
			Me.ribbonPageGroup3.ShowCaptionButton = False
			Me.ribbonPageGroup3.Text = "Delete"
			' 
			' ribbonPageGroup4
			' 
			Me.ribbonPageGroup4.ItemLinks.Add(Me.barSubItem1)
			Me.ribbonPageGroup4.ItemLinks.Add(Me.barButtonItem6)
			Me.ribbonPageGroup4.ItemLinks.Add(Me.barButtonItem11)
			Me.ribbonPageGroup4.ItemLinks.Add(Me.barButtonItem5)
			Me.ribbonPageGroup4.MergeOrder = 0
			Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
			Me.ribbonPageGroup4.ShowCaptionButton = False
			Me.ribbonPageGroup4.Text = "Actions"
			' 
			' ribbonPageGroup5
			' 
			Me.ribbonPageGroup5.ItemLinks.Add(Me.ribbonGalleryBarItem1)
			Me.ribbonPageGroup5.MergeOrder = 0
			Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
			Me.ribbonPageGroup5.ShowCaptionButton = False
			Me.ribbonPageGroup5.Text = "Quick Letters"
			' 
			' ribbonPageGroup6
			' 
			Me.ribbonPageGroup6.AllowTextClipping = False
			Me.ribbonPageGroup6.ItemLinks.Add(Me.barButtonItem12)
			Me.ribbonPageGroup6.MergeOrder = 0
			Me.ribbonPageGroup6.Name = "ribbonPageGroup6"
			Me.ribbonPageGroup6.ShowCaptionButton = False
			Me.ribbonPageGroup6.Text = "View"
			' 
			' ribbonPageGroup7
			' 
			Me.ribbonPageGroup7.AllowTextClipping = False
			Me.ribbonPageGroup7.ItemLinks.Add(Me.barButtonItem2)
			Me.ribbonPageGroup7.MergeOrder = 0
			Me.ribbonPageGroup7.Name = "ribbonPageGroup7"
			Me.ribbonPageGroup7.ShowCaptionButton = False
			Me.ribbonPageGroup7.Text = "Close"
			' 
			' LastNameTextEdit
			' 
			Me.LastNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "LastName", True))
			Me.LastNameTextEdit.EnterMoveNextControl = True
			Me.LastNameTextEdit.Location = New System.Drawing.Point(78, 36)
			Me.LastNameTextEdit.MenuManager = Me.ribbonControl1
			Me.LastNameTextEdit.Name = "LastNameTextEdit"
			Me.LastNameTextEdit.Properties.ValidateOnEnterKey = True
			Me.LastNameTextEdit.Size = New System.Drawing.Size(287, 20)
			Me.LastNameTextEdit.StyleController = Me.dataLayoutControl1
			Me.LastNameTextEdit.TabIndex = 9
			' 
			' PrefixImageComboBoxEdit
			' 
			Me.PrefixImageComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Prefix", True))
			Me.PrefixImageComboBoxEdit.EnterMoveNextControl = True
			Me.PrefixImageComboBoxEdit.Location = New System.Drawing.Point(287, 108)
			Me.PrefixImageComboBoxEdit.MenuManager = Me.ribbonControl1
			Me.PrefixImageComboBoxEdit.Name = "PrefixImageComboBoxEdit"
			Me.PrefixImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.PrefixImageComboBoxEdit.Size = New System.Drawing.Size(78, 20)
			Me.PrefixImageComboBoxEdit.StyleController = Me.dataLayoutControl1
			Me.PrefixImageComboBoxEdit.TabIndex = 11
			' 
			' DepartmentImageComboBoxEdit
			' 
			Me.DepartmentImageComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Department", True))
			Me.DepartmentImageComboBoxEdit.EnterMoveNextControl = True
			Me.DepartmentImageComboBoxEdit.Location = New System.Drawing.Point(595, 12)
			Me.DepartmentImageComboBoxEdit.MenuManager = Me.ribbonControl1
			Me.DepartmentImageComboBoxEdit.Name = "DepartmentImageComboBoxEdit"
			Me.DepartmentImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.DepartmentImageComboBoxEdit.Size = New System.Drawing.Size(403, 20)
			Me.DepartmentImageComboBoxEdit.StyleController = Me.dataLayoutControl1
			Me.DepartmentImageComboBoxEdit.TabIndex = 4
			' 
			' StatusImageComboBoxEdit
			' 
			Me.behaviorManager1.SetBehaviors(Me.StatusImageComboBoxEdit, New DevExpress.Utils.Behaviors.Behavior() { (CType(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(GetType(DevExpress.XtraEditors.Behaviors.StubGlyphBehaviorSourceForImageComboBox), stubGlyphOptions1, New System.Drawing.Size(16, 16)), DevExpress.Utils.Behaviors.Behavior))})
			Me.StatusImageComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Status", True))
			Me.StatusImageComboBoxEdit.EnterMoveNextControl = True
			Me.StatusImageComboBoxEdit.Location = New System.Drawing.Point(595, 36)
			Me.StatusImageComboBoxEdit.MenuManager = Me.ribbonControl1
			Me.StatusImageComboBoxEdit.Name = "StatusImageComboBoxEdit"
			Me.StatusImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.StatusImageComboBoxEdit.Size = New System.Drawing.Size(403, 20)
			Me.StatusImageComboBoxEdit.StyleController = Me.dataLayoutControl1
			Me.StatusImageComboBoxEdit.TabIndex = 6
			' 
			' gridControlEvaluations
			' 
			Me.gridControlEvaluations.DataSource = Me.evaluationsBindingSource
			Me.gridControlEvaluations.Location = New System.Drawing.Point(529, 122)
			Me.gridControlEvaluations.MainView = Me.gvEvaluations
			Me.gridControlEvaluations.Name = "gridControlEvaluations"
			Me.gridControlEvaluations.Size = New System.Drawing.Size(469, 222)
			Me.gridControlEvaluations.TabIndex = 6
			Me.gridControlEvaluations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvEvaluations})
			' 
			' evaluationsBindingSource
			' 
			Me.evaluationsBindingSource.DataMember = "Evaluations"
			Me.evaluationsBindingSource.DataSource = Me.bindingSource
			' 
			' gvEvaluations
			' 
			Me.gvEvaluations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCreatedOn, Me.colSubject, Me.colCreatedBy})
			Me.gvEvaluations.GridControl = Me.gridControlEvaluations
			Me.gvEvaluations.Name = "gvEvaluations"
			Me.gvEvaluations.OptionsBehavior.FocusLeaveOnTab = True
			Me.gvEvaluations.OptionsSelection.EnableAppearanceHideSelection = False
			Me.gvEvaluations.OptionsView.AutoCalcPreviewLineCount = True
			Me.gvEvaluations.OptionsView.EnableAppearanceEvenRow = True
			Me.gvEvaluations.OptionsView.ShowGroupPanel = False
			Me.gvEvaluations.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False
			Me.gvEvaluations.OptionsView.ShowIndicator = False
			Me.gvEvaluations.OptionsView.ShowPreview = True
			Me.gvEvaluations.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
			Me.gvEvaluations.PreviewFieldName = "Details"
			Me.gvEvaluations.PreviewIndent = 0
			' 
			' colCreatedOn
			' 
			Me.colCreatedOn.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
			Me.colCreatedOn.AppearanceCell.Options.UseFont = True
			Me.colCreatedOn.Caption = "CREATED ON"
			Me.colCreatedOn.FieldName = "CreatedOn"
			Me.colCreatedOn.Name = "colCreatedOn"
			Me.colCreatedOn.OptionsColumn.AllowEdit = False
			Me.colCreatedOn.OptionsColumn.AllowFocus = False
			Me.colCreatedOn.Visible = True
			Me.colCreatedOn.VisibleIndex = 0
			Me.colCreatedOn.Width = 82
			' 
			' colSubject
			' 
			Me.colSubject.Caption = "SUBJECT"
			Me.colSubject.FieldName = "Subject"
			Me.colSubject.Name = "colSubject"
			Me.colSubject.OptionsColumn.AllowEdit = False
			Me.colSubject.OptionsColumn.AllowFocus = False
			Me.colSubject.Visible = True
			Me.colSubject.VisibleIndex = 1
			Me.colSubject.Width = 249
			' 
			' colCreatedBy
			' 
			Me.colCreatedBy.Caption = "MANAGER"
			Me.colCreatedBy.FieldName = "Manager"
			Me.colCreatedBy.Name = "colCreatedBy"
			Me.colCreatedBy.OptionsColumn.AllowEdit = False
			Me.colCreatedBy.OptionsColumn.AllowFocus = False
			Me.colCreatedBy.Visible = True
			Me.colCreatedBy.VisibleIndex = 2
			Me.colCreatedBy.Width = 136
			' 
			' HomePhoneTextEdit
			' 
			Me.HomePhoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "HomePhone", True))
			Me.HomePhoneTextEdit.EnterMoveNextControl = True
			Me.HomePhoneTextEdit.Location = New System.Drawing.Point(78, 244)
			Me.HomePhoneTextEdit.MenuManager = Me.ribbonControl1
			Me.HomePhoneTextEdit.Name = "HomePhoneTextEdit"
			Me.HomePhoneTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (DirectCast(resources.GetObject("HomePhoneTextEdit.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
			Me.HomePhoneTextEdit.Properties.ValidateOnEnterKey = True
			Me.HomePhoneTextEdit.Size = New System.Drawing.Size(427, 22)
			Me.HomePhoneTextEdit.StyleController = Me.dataLayoutControl1
			Me.HomePhoneTextEdit.TabIndex = 12
			' 
			' MobilePhoneTextEdit
			' 
			Me.MobilePhoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "MobilePhone", True))
			Me.MobilePhoneTextEdit.EnterMoveNextControl = True
			Me.MobilePhoneTextEdit.Location = New System.Drawing.Point(78, 270)
			Me.MobilePhoneTextEdit.MenuManager = Me.ribbonControl1
			Me.MobilePhoneTextEdit.Name = "MobilePhoneTextEdit"
			Me.MobilePhoneTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (DirectCast(resources.GetObject("MobilePhoneTextEdit.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True)})
			Me.MobilePhoneTextEdit.Properties.ValidateOnEnterKey = True
			Me.MobilePhoneTextEdit.Size = New System.Drawing.Size(427, 22)
			Me.MobilePhoneTextEdit.StyleController = Me.dataLayoutControl1
			Me.MobilePhoneTextEdit.TabIndex = 13
			' 
			' EmailTextEdit
			' 
			Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Email", True))
			Me.EmailTextEdit.EnterMoveNextControl = True
			Me.EmailTextEdit.Location = New System.Drawing.Point(78, 296)
			Me.EmailTextEdit.MenuManager = Me.ribbonControl1
			Me.EmailTextEdit.Name = "EmailTextEdit"
			Me.EmailTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (DirectCast(resources.GetObject("EmailTextEdit.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", Nothing, Nothing, True)})
			Me.EmailTextEdit.Properties.ValidateOnEnterKey = True
			Me.EmailTextEdit.Size = New System.Drawing.Size(427, 22)
			Me.EmailTextEdit.StyleController = Me.dataLayoutControl1
			Me.EmailTextEdit.TabIndex = 14
			' 
			' SkypeTextEdit
			' 
			Me.SkypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Skype", True))
			Me.SkypeTextEdit.EnterMoveNextControl = True
			Me.SkypeTextEdit.Location = New System.Drawing.Point(78, 322)
			Me.SkypeTextEdit.MenuManager = Me.ribbonControl1
			Me.SkypeTextEdit.Name = "SkypeTextEdit"
			Me.SkypeTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (DirectCast(resources.GetObject("SkypeTextEdit.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", Nothing, Nothing, True)})
			Me.SkypeTextEdit.Properties.ValidateOnEnterKey = True
			Me.SkypeTextEdit.Size = New System.Drawing.Size(427, 22)
			Me.SkypeTextEdit.StyleController = Me.dataLayoutControl1
			Me.SkypeTextEdit.TabIndex = 15
			' 
			' PhotoPictureEdit
			' 
			Me.PhotoPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
			Me.PhotoPictureEdit.EditValue = (DirectCast(resources.GetObject("PhotoPictureEdit.EditValue"), Object))
			Me.PhotoPictureEdit.Location = New System.Drawing.Point(387, 12)
			Me.PhotoPictureEdit.MenuManager = Me.ribbonControl1
			Me.PhotoPictureEdit.Name = "PhotoPictureEdit"
			Me.PhotoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
			Me.PhotoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
			Me.PhotoPictureEdit.Properties.ZoomAccelerationFactor = 1R
			Me.PhotoPictureEdit.Size = New System.Drawing.Size(118, 116)
			Me.PhotoPictureEdit.StyleController = Me.dataLayoutControl1
			Me.PhotoPictureEdit.TabIndex = 17
			' 
			' AddressTextEdit
			' 
			Me.AddressTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Address.Line", True))
			Me.AddressTextEdit.EnterMoveNextControl = True
			Me.AddressTextEdit.Location = New System.Drawing.Point(78, 152)
			Me.AddressTextEdit.MenuManager = Me.ribbonControl1
			Me.AddressTextEdit.Name = "AddressTextEdit"
			Me.AddressTextEdit.Size = New System.Drawing.Size(427, 20)
			Me.AddressTextEdit.StyleController = Me.dataLayoutControl1
			Me.AddressTextEdit.TabIndex = 19
			' 
			' CityTextEdit
			' 
			Me.CityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Address.City", True))
			Me.CityTextEdit.EnterMoveNextControl = True
			Me.CityTextEdit.Location = New System.Drawing.Point(78, 176)
			Me.CityTextEdit.MenuManager = Me.ribbonControl1
			Me.CityTextEdit.Name = "CityTextEdit"
			Me.CityTextEdit.Size = New System.Drawing.Size(427, 20)
			Me.CityTextEdit.StyleController = Me.dataLayoutControl1
			Me.CityTextEdit.TabIndex = 20
			' 
			' StateImageComboBoxEdit
			' 
			Me.StateImageComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Address.State", True))
			Me.StateImageComboBoxEdit.EnterMoveNextControl = True
			Me.StateImageComboBoxEdit.Location = New System.Drawing.Point(78, 200)
			Me.StateImageComboBoxEdit.MenuManager = Me.ribbonControl1
			Me.StateImageComboBoxEdit.Name = "StateImageComboBoxEdit"
			Me.StateImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.StateImageComboBoxEdit.Properties.DropDownRows = 14
			Me.StateImageComboBoxEdit.Properties.Sorted = True
			Me.StateImageComboBoxEdit.Size = New System.Drawing.Size(227, 20)
			Me.StateImageComboBoxEdit.StyleController = Me.dataLayoutControl1
			Me.StateImageComboBoxEdit.TabIndex = 21
			' 
			' ZipCodeTextEdit
			' 
			Me.ZipCodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Address.ZipCode", True))
			Me.ZipCodeTextEdit.EnterMoveNextControl = True
			Me.ZipCodeTextEdit.Location = New System.Drawing.Point(356, 200)
			Me.ZipCodeTextEdit.MenuManager = Me.ribbonControl1
			Me.ZipCodeTextEdit.Name = "ZipCodeTextEdit"
			Me.ZipCodeTextEdit.Size = New System.Drawing.Size(149, 20)
			Me.ZipCodeTextEdit.StyleController = Me.dataLayoutControl1
			Me.ZipCodeTextEdit.TabIndex = 22
			' 
			' FullNameTextEdit
			' 
			Me.FullNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "FullNameBindable", True))
			Me.FullNameTextEdit.Location = New System.Drawing.Point(78, 60)
			Me.FullNameTextEdit.MenuManager = Me.ribbonControl1
			Me.FullNameTextEdit.Name = "FullNameTextEdit"
			Me.FullNameTextEdit.Size = New System.Drawing.Size(287, 20)
			Me.FullNameTextEdit.StyleController = Me.dataLayoutControl1
			Me.FullNameTextEdit.TabIndex = 23
			' 
			' HireDateDateEdit
			' 
			Me.HireDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "HireDate", True))
			Me.HireDateDateEdit.EditValue = Nothing
			Me.HireDateDateEdit.EnterMoveNextControl = True
			Me.HireDateDateEdit.Location = New System.Drawing.Point(595, 60)
			Me.HireDateDateEdit.MenuManager = Me.ribbonControl1
			Me.HireDateDateEdit.Name = "HireDateDateEdit"
			Me.HireDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.HireDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.HireDateDateEdit.Size = New System.Drawing.Size(403, 20)
			Me.HireDateDateEdit.StyleController = Me.dataLayoutControl1
			Me.HireDateDateEdit.TabIndex = 7
			' 
			' BirthDateDateEdit
			' 
			Me.BirthDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "BirthDate", True))
			Me.BirthDateDateEdit.EditValue = Nothing
			Me.BirthDateDateEdit.EnterMoveNextControl = True
			Me.BirthDateDateEdit.Location = New System.Drawing.Point(78, 84)
			Me.BirthDateDateEdit.MenuManager = Me.ribbonControl1
			Me.BirthDateDateEdit.Name = "BirthDateDateEdit"
			Me.BirthDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.BirthDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.BirthDateDateEdit.Size = New System.Drawing.Size(287, 20)
			Me.BirthDateDateEdit.StyleController = Me.dataLayoutControl1
			Me.BirthDateDateEdit.TabIndex = 16
			' 
			' TitleTextEdit
			' 
			Me.TitleTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Title", True))
			Me.TitleTextEdit.EnterMoveNextControl = True
			Me.TitleTextEdit.Location = New System.Drawing.Point(78, 108)
			Me.TitleTextEdit.MenuManager = Me.ribbonControl1
			Me.TitleTextEdit.Name = "TitleTextEdit"
			Me.TitleTextEdit.Properties.ValidateOnEnterKey = True
			Me.TitleTextEdit.Size = New System.Drawing.Size(172, 20)
			Me.TitleTextEdit.StyleController = Me.dataLayoutControl1
			Me.TitleTextEdit.TabIndex = 5
			' 
			' gridControlTasks
			' 
			Me.gridControlTasks.DataSource = Me.assignedTasksBindingSource
			Me.gridControlTasks.Location = New System.Drawing.Point(12, 384)
			Me.gridControlTasks.MainView = Me.gvTasks
			Me.gridControlTasks.Name = "gridControlTasks"
			Me.gridControlTasks.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemProgressBar1})
			Me.gridControlTasks.Size = New System.Drawing.Size(986, 175)
			Me.gridControlTasks.TabIndex = 18
			Me.gridControlTasks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvTasks})
			' 
			' assignedTasksBindingSource
			' 
			Me.assignedTasksBindingSource.DataMember = "AssignedTasks"
			Me.assignedTasksBindingSource.DataSource = Me.bindingSource
			' 
			' gvTasks
			' 
			Me.gvTasks.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
			Me.gvTasks.Appearance.HideSelectionRow.Options.UseBackColor = True
			Me.gvTasks.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colPriority, Me.colDueDate, Me.colSubject1, Me.colDescription, Me.colCompletion})
			Me.gvTasks.GridControl = Me.gridControlTasks
			Me.gvTasks.Name = "gvTasks"
			Me.gvTasks.OptionsBehavior.FocusLeaveOnTab = True
			Me.gvTasks.OptionsSelection.EnableAppearanceHideSelection = False
			Me.gvTasks.OptionsView.AutoCalcPreviewLineCount = True
			Me.gvTasks.OptionsView.EnableAppearanceEvenRow = True
			Me.gvTasks.OptionsView.ShowGroupPanel = False
			Me.gvTasks.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False
			Me.gvTasks.OptionsView.ShowIndicator = False
			Me.gvTasks.OptionsView.ShowPreview = True
			Me.gvTasks.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
			Me.gvTasks.PreviewFieldName = "Description"
			Me.gvTasks.PreviewIndent = 0
			Me.gvTasks.PreviewLineCount = 3
			' 
			' colPriority
			' 
			Me.colPriority.Caption = "PRIORITY"
			Me.colPriority.FieldName = "Priority"
			Me.colPriority.Name = "colPriority"
			Me.colPriority.OptionsColumn.AllowEdit = False
			Me.colPriority.OptionsColumn.AllowFocus = False
			Me.colPriority.Visible = True
			Me.colPriority.VisibleIndex = 0
			Me.colPriority.Width = 133
			' 
			' colDueDate
			' 
			Me.colDueDate.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
			Me.colDueDate.AppearanceCell.Options.UseFont = True
			Me.colDueDate.Caption = "DUE DATE"
			Me.colDueDate.FieldName = "DueDate"
			Me.colDueDate.Name = "colDueDate"
			Me.colDueDate.OptionsColumn.AllowEdit = False
			Me.colDueDate.OptionsColumn.AllowFocus = False
			Me.colDueDate.Visible = True
			Me.colDueDate.VisibleIndex = 1
			Me.colDueDate.Width = 133
			' 
			' colSubject1
			' 
			Me.colSubject1.Caption = "SUBJECT"
			Me.colSubject1.FieldName = "Subject"
			Me.colSubject1.Name = "colSubject1"
			Me.colSubject1.OptionsColumn.AllowEdit = False
			Me.colSubject1.OptionsColumn.AllowFocus = False
			Me.colSubject1.Visible = True
			Me.colSubject1.VisibleIndex = 2
			Me.colSubject1.Width = 316
			' 
			' colDescription
			' 
			Me.colDescription.Caption = "DESCRIPTION"
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.OptionsColumn.AllowEdit = False
			Me.colDescription.OptionsColumn.AllowFocus = False
			Me.colDescription.Width = 439
			' 
			' colCompletion
			' 
			Me.colCompletion.Caption = "COMPLETION"
			Me.colCompletion.ColumnEdit = Me.repositoryItemProgressBar1
			Me.colCompletion.FieldName = "Completion"
			Me.colCompletion.Name = "colCompletion"
			Me.colCompletion.OptionsColumn.AllowEdit = False
			Me.colCompletion.OptionsColumn.AllowFocus = False
			Me.colCompletion.Visible = True
			Me.colCompletion.VisibleIndex = 3
			Me.colCompletion.Width = 402
			' 
			' repositoryItemProgressBar1
			' 
			Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
			Me.repositoryItemProgressBar1.ShowTitle = True
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.autoGeneratedGroup0, Me.ItemForTasks})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(1010, 571)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' autoGeneratedGroup0
			' 
			Me.autoGeneratedGroup0.AllowDrawBackground = False
			Me.autoGeneratedGroup0.CustomizationFormText = "autoGeneratedGroup0"
			Me.autoGeneratedGroup0.GroupBordersVisible = False
			Me.autoGeneratedGroup0.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForFirstName, Me.ItemForLastName, Me.ItemForPrefix, Me.ItemForDepartment, Me.ItemForStatus, Me.ItemForEvaluations, Me.ItemForHomePhone, Me.ItemForMobilePhone, Me.ItemForEmail, Me.ItemForSkype, Me.ItemForPhoto, Me.emptySpaceItem1, Me.ItemForAddress, Me.ItemForCity, Me.ItemForState, Me.ItemForZipCode, Me.emptySpaceItem2, Me.ItemForFullName, Me.ItemForHireDate, Me.ItemForBirthDate, Me.emptySpaceItem3, Me.emptySpaceItem4, Me.emptySpaceItem5, Me.ItemForTitle})
			Me.autoGeneratedGroup0.Location = New System.Drawing.Point(0, 0)
			Me.autoGeneratedGroup0.Name = "autoGeneratedGroup0"
			Me.autoGeneratedGroup0.Size = New System.Drawing.Size(990, 356)
			' 
			' ItemForFirstName
			' 
			Me.ItemForFirstName.Control = Me.FirstNameTextEdit
			Me.ItemForFirstName.CustomizationFormText = "First Name"
			Me.ItemForFirstName.Location = New System.Drawing.Point(0, 0)
			Me.ItemForFirstName.Name = "ItemForFirstName"
			Me.ItemForFirstName.Size = New System.Drawing.Size(357, 24)
			Me.ItemForFirstName.Text = "First Name"
			Me.ItemForFirstName.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForLastName
			' 
			Me.ItemForLastName.Control = Me.LastNameTextEdit
			Me.ItemForLastName.CustomizationFormText = "Last Name"
			Me.ItemForLastName.Location = New System.Drawing.Point(0, 24)
			Me.ItemForLastName.Name = "ItemForLastName"
			Me.ItemForLastName.Size = New System.Drawing.Size(357, 24)
			Me.ItemForLastName.Text = "Last Name"
			Me.ItemForLastName.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForPrefix
			' 
			Me.ItemForPrefix.Control = Me.PrefixImageComboBoxEdit
			Me.ItemForPrefix.CustomizationFormText = "Prefix"
			Me.ItemForPrefix.Location = New System.Drawing.Point(242, 96)
			Me.ItemForPrefix.MaxSize = New System.Drawing.Size(115, 24)
			Me.ItemForPrefix.MinSize = New System.Drawing.Size(115, 24)
			Me.ItemForPrefix.Name = "ItemForPrefix"
			Me.ItemForPrefix.Size = New System.Drawing.Size(115, 24)
			Me.ItemForPrefix.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.ItemForPrefix.Text = "Prefix"
            Me.ItemForPrefix.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.ItemForPrefix.TextSize = New System.Drawing.Size(28, 13)
            Me.ItemForPrefix.TextToControlDistance = 5
			' 
			' ItemForDepartment
			' 
			Me.ItemForDepartment.Control = Me.DepartmentImageComboBoxEdit
			Me.ItemForDepartment.CustomizationFormText = "Department"
			Me.ItemForDepartment.Location = New System.Drawing.Point(517, 0)
			Me.ItemForDepartment.Name = "ItemForDepartment"
			Me.ItemForDepartment.Size = New System.Drawing.Size(473, 24)
			Me.ItemForDepartment.Text = "Department"
			Me.ItemForDepartment.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForStatus
			' 
			Me.ItemForStatus.Control = Me.StatusImageComboBoxEdit
			Me.ItemForStatus.CustomizationFormText = "Status"
			Me.ItemForStatus.Location = New System.Drawing.Point(517, 24)
			Me.ItemForStatus.Name = "ItemForStatus"
			Me.ItemForStatus.Size = New System.Drawing.Size(473, 24)
			Me.ItemForStatus.Text = "Status"
			Me.ItemForStatus.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForEvaluations
			' 
			Me.ItemForEvaluations.Control = Me.gridControlEvaluations
			Me.ItemForEvaluations.CustomizationFormText = "Evaluations"
			Me.ItemForEvaluations.Location = New System.Drawing.Point(517, 92)
			Me.ItemForEvaluations.Name = "ItemForEvaluations"
			Me.ItemForEvaluations.Size = New System.Drawing.Size(473, 244)
			Me.ItemForEvaluations.Text = "Evaluations"
			Me.ItemForEvaluations.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
			Me.ItemForEvaluations.TextLocation = DevExpress.Utils.Locations.Top
			Me.ItemForEvaluations.TextSize = New System.Drawing.Size(55, 13)
			Me.ItemForEvaluations.TextToControlDistance = 5
			' 
			' ItemForHomePhone
			' 
			Me.ItemForHomePhone.Control = Me.HomePhoneTextEdit
			Me.ItemForHomePhone.CustomizationFormText = "Home Phone"
			Me.ItemForHomePhone.Location = New System.Drawing.Point(0, 232)
			Me.ItemForHomePhone.Name = "ItemForHomePhone"
			Me.ItemForHomePhone.Size = New System.Drawing.Size(497, 26)
			Me.ItemForHomePhone.Text = "Home Phone"
			Me.ItemForHomePhone.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForMobilePhone
			' 
			Me.ItemForMobilePhone.Control = Me.MobilePhoneTextEdit
			Me.ItemForMobilePhone.CustomizationFormText = "Mobile Phone"
			Me.ItemForMobilePhone.Location = New System.Drawing.Point(0, 258)
			Me.ItemForMobilePhone.Name = "ItemForMobilePhone"
			Me.ItemForMobilePhone.Size = New System.Drawing.Size(497, 26)
			Me.ItemForMobilePhone.Text = "Mobile Phone"
			Me.ItemForMobilePhone.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForEmail
			' 
			Me.ItemForEmail.Control = Me.EmailTextEdit
			Me.ItemForEmail.CustomizationFormText = "Email"
			Me.ItemForEmail.Location = New System.Drawing.Point(0, 284)
			Me.ItemForEmail.Name = "ItemForEmail"
			Me.ItemForEmail.Size = New System.Drawing.Size(497, 26)
			Me.ItemForEmail.Text = "Email"
			Me.ItemForEmail.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForSkype
			' 
			Me.ItemForSkype.Control = Me.SkypeTextEdit
			Me.ItemForSkype.CustomizationFormText = "Skype"
			Me.ItemForSkype.Location = New System.Drawing.Point(0, 310)
			Me.ItemForSkype.Name = "ItemForSkype"
			Me.ItemForSkype.Size = New System.Drawing.Size(497, 26)
			Me.ItemForSkype.Text = "Skype"
			Me.ItemForSkype.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForPhoto
			' 
			Me.ItemForPhoto.Control = Me.PhotoPictureEdit
			Me.ItemForPhoto.CustomizationFormText = "Photo"
			Me.ItemForPhoto.Location = New System.Drawing.Point(357, 0)
			Me.ItemForPhoto.Name = "ItemForPhoto"
			Me.ItemForPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2)
			Me.ItemForPhoto.Size = New System.Drawing.Size(140, 120)
			Me.ItemForPhoto.Text = "Photo:"
			Me.ItemForPhoto.TextSize = New System.Drawing.Size(0, 0)
			Me.ItemForPhoto.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 120)
			Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 20)
			Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 20)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(497, 20)
			Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' ItemForAddress
			' 
			Me.ItemForAddress.Control = Me.AddressTextEdit
			Me.ItemForAddress.CustomizationFormText = "Address"
			Me.ItemForAddress.Location = New System.Drawing.Point(0, 140)
			Me.ItemForAddress.Name = "ItemForAddress"
			Me.ItemForAddress.Size = New System.Drawing.Size(497, 24)
			Me.ItemForAddress.Text = "Address"
			Me.ItemForAddress.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForCity
			' 
			Me.ItemForCity.Control = Me.CityTextEdit
			Me.ItemForCity.CustomizationFormText = "City"
			Me.ItemForCity.Location = New System.Drawing.Point(0, 164)
			Me.ItemForCity.Name = "ItemForCity"
			Me.ItemForCity.Size = New System.Drawing.Size(497, 24)
			Me.ItemForCity.Text = "City"
			Me.ItemForCity.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForState
			' 
			Me.ItemForState.Control = Me.StateImageComboBoxEdit
			Me.ItemForState.CustomizationFormText = "State"
			Me.ItemForState.Location = New System.Drawing.Point(0, 188)
			Me.ItemForState.Name = "ItemForState"
			Me.ItemForState.Size = New System.Drawing.Size(297, 24)
			Me.ItemForState.Text = "State"
			Me.ItemForState.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForZipCode
			' 
			Me.ItemForZipCode.Control = Me.ZipCodeTextEdit
			Me.ItemForZipCode.CustomizationFormText = "ZipCode"
			Me.ItemForZipCode.Location = New System.Drawing.Point(297, 188)
			Me.ItemForZipCode.Name = "ItemForZipCode"
			Me.ItemForZipCode.Size = New System.Drawing.Size(200, 24)
			Me.ItemForZipCode.Text = "ZIP code"
			Me.ItemForZipCode.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
			Me.ItemForZipCode.TextSize = New System.Drawing.Size(42, 13)
			Me.ItemForZipCode.TextToControlDistance = 5
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 212)
			Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 20)
			Me.emptySpaceItem2.MinSize = New System.Drawing.Size(10, 20)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(497, 20)
			Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' ItemForFullName
			' 
			Me.ItemForFullName.Control = Me.FullNameTextEdit
			Me.ItemForFullName.CustomizationFormText = "Full Name"
			Me.ItemForFullName.Location = New System.Drawing.Point(0, 48)
			Me.ItemForFullName.Name = "ItemForFullName"
			Me.ItemForFullName.Size = New System.Drawing.Size(357, 24)
			Me.ItemForFullName.Text = "Full Name"
			Me.ItemForFullName.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForHireDate
			' 
			Me.ItemForHireDate.Control = Me.HireDateDateEdit
			Me.ItemForHireDate.CustomizationFormText = "Hire Date"
			Me.ItemForHireDate.Location = New System.Drawing.Point(517, 48)
			Me.ItemForHireDate.Name = "ItemForHireDate"
			Me.ItemForHireDate.Size = New System.Drawing.Size(473, 24)
			Me.ItemForHireDate.Text = "Hire Date"
			Me.ItemForHireDate.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForBirthDate
			' 
			Me.ItemForBirthDate.Control = Me.BirthDateDateEdit
			Me.ItemForBirthDate.CustomizationFormText = "Birth Date"
			Me.ItemForBirthDate.Location = New System.Drawing.Point(0, 72)
			Me.ItemForBirthDate.Name = "ItemForBirthDate"
			Me.ItemForBirthDate.Size = New System.Drawing.Size(357, 24)
			Me.ItemForBirthDate.Text = "Birth Date"
			Me.ItemForBirthDate.TextSize = New System.Drawing.Size(63, 13)
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.AllowHotTrack = False
			Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
			Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 336)
			Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 20)
			Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 20)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(990, 20)
			Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem4
			' 
			Me.emptySpaceItem4.AllowHotTrack = False
			Me.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4"
			Me.emptySpaceItem4.Location = New System.Drawing.Point(497, 0)
			Me.emptySpaceItem4.MaxSize = New System.Drawing.Size(20, 0)
			Me.emptySpaceItem4.MinSize = New System.Drawing.Size(20, 10)
			Me.emptySpaceItem4.Name = "emptySpaceItem4"
			Me.emptySpaceItem4.Size = New System.Drawing.Size(20, 336)
			Me.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem5
			' 
			Me.emptySpaceItem5.AllowHotTrack = False
			Me.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5"
			Me.emptySpaceItem5.Location = New System.Drawing.Point(517, 72)
			Me.emptySpaceItem5.MaxSize = New System.Drawing.Size(0, 20)
			Me.emptySpaceItem5.MinSize = New System.Drawing.Size(10, 20)
			Me.emptySpaceItem5.Name = "emptySpaceItem5"
			Me.emptySpaceItem5.Size = New System.Drawing.Size(473, 20)
			Me.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
			' 
			' ItemForTitle
			' 
			Me.ItemForTitle.Control = Me.TitleTextEdit
			Me.ItemForTitle.CustomizationFormText = "Title"
			Me.ItemForTitle.Location = New System.Drawing.Point(0, 96)
			Me.ItemForTitle.Name = "ItemForTitle"
			Me.ItemForTitle.Size = New System.Drawing.Size(242, 24)
			Me.ItemForTitle.Text = "Title"
			Me.ItemForTitle.TextSize = New System.Drawing.Size(63, 13)
			' 
			' ItemForTasks
			' 
			Me.ItemForTasks.Control = Me.gridControlTasks
			Me.ItemForTasks.CustomizationFormText = "TASKS"
			Me.ItemForTasks.Location = New System.Drawing.Point(0, 356)
			Me.ItemForTasks.Name = "ItemForTasks"
			Me.ItemForTasks.Size = New System.Drawing.Size(990, 195)
			Me.ItemForTasks.Text = "Tasks"
			Me.ItemForTasks.TextLocation = DevExpress.Utils.Locations.Top
			Me.ItemForTasks.TextSize = New System.Drawing.Size(63, 13)
			' 
			' EmployeeView
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.dataLayoutControl1)
			Me.Name = "EmployeeView"
			Me.Size = New System.Drawing.Size(1015, 576)
			DirectCast(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dataLayoutControl1.ResumeLayout(False)
			DirectCast(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.PrefixImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.DepartmentImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.StatusImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridControlEvaluations, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.evaluationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gvEvaluations, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.HomePhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.MobilePhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.SkypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.PhotoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.CityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.StateImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ZipCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.FullNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.HireDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.HireDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.BirthDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.BirthDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.TitleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridControlTasks, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.assignedTasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gvTasks, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.autoGeneratedGroup0, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForFirstName, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForLastName, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForPrefix, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForDepartment, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForStatus, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForEvaluations, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForHomePhone, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForMobilePhone, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForSkype, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForPhoto, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForCity, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForState, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForZipCode, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForFullName, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForHireDate, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForBirthDate, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForTitle, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ItemForTasks, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.behaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataLayoutControl1 As XtraDataLayout.DataLayoutControl
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private FirstNameTextEdit As TextEdit
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private barButtonItem1 As XtraBars.BarButtonItem
		Private barButtonItem2 As XtraBars.BarButtonItem
		Private barButtonItem3 As XtraBars.BarButtonItem
		Private barButtonItem4 As XtraBars.BarButtonItem
		Private barButtonItem5 As XtraBars.BarButtonItem
		Private barButtonItem6 As XtraBars.BarButtonItem
		Private barSubItem1 As XtraBars.BarSubItem
		Private barButtonItem7 As XtraBars.BarButtonItem
		Private barButtonItem8 As XtraBars.BarButtonItem
		Private barButtonItem9 As XtraBars.BarButtonItem
		Private barButtonItem10 As XtraBars.BarButtonItem
		Private barButtonItem11 As XtraBars.BarButtonItem
		Private ribbonGalleryBarItem1 As XtraBars.RibbonGalleryBarItem
		Private barButtonItem12 As XtraBars.BarButtonItem
		Private barButtonItem13 As XtraBars.BarButtonItem
		Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup5 As XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup6 As XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup7 As XtraBars.Ribbon.RibbonPageGroup
		Private LastNameTextEdit As TextEdit
		Private PrefixImageComboBoxEdit As ImageComboBoxEdit
		Private DepartmentImageComboBoxEdit As ImageComboBoxEdit
		Private StatusImageComboBoxEdit As ImageComboBoxEdit
		Private gridControlEvaluations As XtraGrid.GridControl
		Private gvEvaluations As XtraGrid.Views.Grid.GridView
		Private colCreatedOn As XtraGrid.Columns.GridColumn
		Private colSubject As XtraGrid.Columns.GridColumn
		Private colCreatedBy As XtraGrid.Columns.GridColumn
		Private HomePhoneTextEdit As ButtonEdit
		Private MobilePhoneTextEdit As ButtonEdit
		Private EmailTextEdit As ButtonEdit
		Private SkypeTextEdit As ButtonEdit
		Private PhotoPictureEdit As PictureEdit
		Private AddressTextEdit As TextEdit
		Private CityTextEdit As TextEdit
		Private StateImageComboBoxEdit As ImageComboBoxEdit
		Private ZipCodeTextEdit As TextEdit
		Private FullNameTextEdit As TextEdit
		Private HireDateDateEdit As DateEdit
		Private BirthDateDateEdit As DateEdit
		Private TitleTextEdit As TextEdit
		Private gridControlTasks As XtraGrid.GridControl
		Private gvTasks As XtraGrid.Views.Grid.GridView
		Private colPriority As XtraGrid.Columns.GridColumn
		Private colDueDate As XtraGrid.Columns.GridColumn
		Private colSubject1 As XtraGrid.Columns.GridColumn
		Private colDescription As XtraGrid.Columns.GridColumn
		Private colCompletion As XtraGrid.Columns.GridColumn
		Private repositoryItemProgressBar1 As Repository.RepositoryItemProgressBar
		Private autoGeneratedGroup0 As XtraLayout.LayoutControlGroup
		Private ItemForFirstName As XtraLayout.LayoutControlItem
		Private ItemForLastName As XtraLayout.LayoutControlItem
		Private ItemForPrefix As XtraLayout.LayoutControlItem
		Private ItemForDepartment As XtraLayout.LayoutControlItem
		Private ItemForStatus As XtraLayout.LayoutControlItem
		Private ItemForEvaluations As XtraLayout.LayoutControlItem
		Private ItemForHomePhone As XtraLayout.LayoutControlItem
		Private ItemForMobilePhone As XtraLayout.LayoutControlItem
		Private ItemForEmail As XtraLayout.LayoutControlItem
		Private ItemForSkype As XtraLayout.LayoutControlItem
		Private ItemForPhoto As XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
		Private ItemForAddress As XtraLayout.LayoutControlItem
		Private ItemForCity As XtraLayout.LayoutControlItem
		Private ItemForState As XtraLayout.LayoutControlItem
		Private ItemForZipCode As XtraLayout.LayoutControlItem
		Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
		Private ItemForFullName As XtraLayout.LayoutControlItem
		Private ItemForHireDate As XtraLayout.LayoutControlItem
		Private ItemForBirthDate As XtraLayout.LayoutControlItem
		Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
		Private emptySpaceItem4 As XtraLayout.EmptySpaceItem
		Private emptySpaceItem5 As XtraLayout.EmptySpaceItem
		Private ItemForTitle As XtraLayout.LayoutControlItem
		Private ItemForTasks As XtraLayout.LayoutControlItem
		Private bindingSource As System.Windows.Forms.BindingSource
		Private evaluationsBindingSource As System.Windows.Forms.BindingSource
		Private assignedTasksBindingSource As System.Windows.Forms.BindingSource
		Private behaviorManager1 As Utils.Behaviors.BehaviorManager
	End Class
End Namespace
