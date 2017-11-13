Namespace DevExpress.DevAV.Modules
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(EmployeeView))
            Me.images = New DevExpress.Utils.ImageCollection(Me.components)
            Me.pictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.modueLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.gcEvaluations = New DevExpress.XtraGrid.GridControl()
            Me.gvEvaluations = New DevExpress.DevAV.TaskPreviewGridView()
            Me.colCreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubject1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.lbTasks = New DevExpress.XtraEditors.LabelControl()
            Me.lbSeparator = New DevExpress.XtraEditors.LabelControl()
            Me.lbEvaluations = New DevExpress.XtraEditors.LabelControl()
            Me.gcTasks = New DevExpress.XtraGrid.GridControl()
            Me.gvTasks = New DevExpress.DevAV.TaskPreviewGridView()
            Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.buttonPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.buttonImages = New System.Windows.Forms.ImageList(Me.components)
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForPhoto = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciTasks = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.sliName = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.sliTitle = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciEvaluations = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.images, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.modueLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.modueLayout.SuspendLayout()
            CType(Me.gcEvaluations, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gvEvaluations, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcTasks, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciTasks, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sliName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sliTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciEvaluations, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.images.ImageStream = (CType(resources.GetObject("images.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.images.TransparentColor = System.Drawing.Color.Transparent
            Me.images.InsertImage(My.Resources.glyph_message_16, "glyph_message_16", GetType(My.Resources.Resources), 0)
            Me.images.Images.SetKeyName(0, "glyph_message_16")
            Me.images.InsertImage(My.Resources.glyph_phone_16, "glyph_phone_16", GetType(My.Resources.Resources), 1)
            Me.images.Images.SetKeyName(1, "glyph_phone_16")
            Me.images.InsertImage(My.Resources.glyph_video_16, "glyph_video_16", GetType(My.Resources.Resources), 2)
            Me.images.Images.SetKeyName(2, "glyph_video_16")
            Me.images.InsertImage(My.Resources.glyph_mail_16, "glyph_mail_16", GetType(My.Resources.Resources), 3)
            Me.images.Images.SetKeyName(3, "glyph_mail_16")
            Me.pictureEdit.Cursor = System.Windows.Forms.Cursors.Default
            Me.pictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Photo", True))
            Me.pictureEdit.Location = New System.Drawing.Point(0, 0)
            Me.pictureEdit.Name = "pictureEdit"
            Me.pictureEdit.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.True
            Me.pictureEdit.Properties.AllowFocused = False
            Me.pictureEdit.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.pictureEdit.Properties.ReadOnly = True
            Me.pictureEdit.Properties.ShowMenu = False
            Me.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.pictureEdit.Properties.ZoomAccelerationFactor = 1R
            Me.pictureEdit.Size = New System.Drawing.Size(130, 130)
            Me.pictureEdit.StyleController = Me.modueLayout
            Me.pictureEdit.TabIndex = 0
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Employee)
            Me.modueLayout.AllowCustomization = False
            Me.modueLayout.Controls.Add(Me.gcEvaluations)
            Me.modueLayout.Controls.Add(Me.lbTasks)
            Me.modueLayout.Controls.Add(Me.lbSeparator)
            Me.modueLayout.Controls.Add(Me.lbEvaluations)
            Me.modueLayout.Controls.Add(Me.gcTasks)
            Me.modueLayout.Controls.Add(Me.buttonPanel)
            Me.modueLayout.Controls.Add(Me.pictureEdit)
            Me.modueLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.modueLayout.Location = New System.Drawing.Point(0, 0)
            Me.modueLayout.Name = "modueLayout"
            Me.modueLayout.Root = Me.layoutControlGroup1
            Me.modueLayout.Size = New System.Drawing.Size(578, 593)
            Me.modueLayout.TabIndex = 1
            Me.modueLayout.Text = "modueLayout"
            Me.gcEvaluations.Location = New System.Drawing.Point(289, 177)
            Me.gcEvaluations.MainView = Me.gvEvaluations
            Me.gcEvaluations.Name = "gcEvaluations"
            Me.gcEvaluations.Size = New System.Drawing.Size(289, 416)
            Me.gcEvaluations.TabIndex = 9
            Me.gcEvaluations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvEvaluations})
            Me.gvEvaluations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCreatedOn, Me.colSubject1, Me.colCreatedBy})
            Me.gvEvaluations.GridControl = Me.gcEvaluations
            Me.gvEvaluations.Name = "gvEvaluations"
            Me.gvEvaluations.PreviewFieldName = "Details"
            Me.gvEvaluations.PreviewIndent = 0
            Me.colCreatedOn.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
            Me.colCreatedOn.AppearanceCell.Options.UseFont = True
            Me.colCreatedOn.Caption = "CREATED ON"
            Me.colCreatedOn.FieldName = "CreatedOn"
            Me.colCreatedOn.Name = "colCreatedOn"
            Me.colCreatedOn.OptionsColumn.AllowEdit = False
            Me.colCreatedOn.OptionsColumn.AllowFocus = False
            Me.colCreatedOn.Visible = True
            Me.colCreatedOn.VisibleIndex = 0
            Me.colCreatedOn.Width = 90
            Me.colSubject1.Caption = "SUBJECT"
            Me.colSubject1.FieldName = "Subject"
            Me.colSubject1.Name = "colSubject1"
            Me.colSubject1.OptionsColumn.AllowEdit = False
            Me.colSubject1.OptionsColumn.AllowFocus = False
            Me.colSubject1.Visible = True
            Me.colSubject1.VisibleIndex = 1
            Me.colSubject1.Width = 238
            Me.colCreatedBy.Caption = "MANAGER"
            Me.colCreatedBy.FieldName = "CreatedBy"
            Me.colCreatedBy.Name = "colCreatedBy"
            Me.colCreatedBy.OptionsColumn.AllowEdit = False
            Me.colCreatedBy.OptionsColumn.AllowFocus = False
            Me.colCreatedBy.Visible = True
            Me.colCreatedBy.VisibleIndex = 2
            Me.colCreatedBy.Width = 228
            Me.lbTasks.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.lbTasks.Appearance.Options.UseFont = True
            Me.lbTasks.Location = New System.Drawing.Point(539, 158)
            Me.lbTasks.Name = "lbTasks"
            Me.lbTasks.Size = New System.Drawing.Size(37, 17)
            Me.lbTasks.StyleController = Me.modueLayout
            Me.lbTasks.TabIndex = 8
            Me.lbTasks.Text = "TASKS"
            Me.lbSeparator.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.lbSeparator.Appearance.Options.UseFont = True
            Me.lbSeparator.Location = New System.Drawing.Point(528, 158)
            Me.lbSeparator.Name = "lbSeparator"
            Me.lbSeparator.Size = New System.Drawing.Size(3, 17)
            Me.lbSeparator.StyleController = Me.modueLayout
            Me.lbSeparator.TabIndex = 7
            Me.lbSeparator.Text = "|"
            Me.lbEvaluations.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.lbEvaluations.Appearance.Options.UseFont = True
            Me.lbEvaluations.Location = New System.Drawing.Point(437, 158)
            Me.lbEvaluations.Name = "lbEvaluations"
            Me.lbEvaluations.Size = New System.Drawing.Size(83, 17)
            Me.lbEvaluations.StyleController = Me.modueLayout
            Me.lbEvaluations.TabIndex = 6
            Me.lbEvaluations.Text = "EVALUATIONS"
            Me.gcTasks.Location = New System.Drawing.Point(0, 177)
            Me.gcTasks.MainView = Me.gvTasks
            Me.gcTasks.Name = "gcTasks"
            Me.gcTasks.ShowOnlyPredefinedDetails = True
            Me.gcTasks.Size = New System.Drawing.Size(289, 416)
            Me.gcTasks.TabIndex = 5
            Me.gcTasks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvTasks})
            Me.gvTasks.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colDueDate, Me.colSubject, Me.colDescription})
            Me.gvTasks.GridControl = Me.gcTasks
            Me.gvTasks.Name = "gvTasks"
            Me.gvTasks.PreviewFieldName = "Description"
            Me.gvTasks.PreviewIndent = 0
            Me.colDueDate.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
            Me.colDueDate.AppearanceCell.Options.UseFont = True
            Me.colDueDate.Caption = "DUE DATE"
            Me.colDueDate.FieldName = "DueDate"
            Me.colDueDate.Name = "colDueDate"
            Me.colDueDate.OptionsColumn.AllowEdit = False
            Me.colDueDate.OptionsColumn.AllowFocus = False
            Me.colDueDate.Visible = True
            Me.colDueDate.VisibleIndex = 0
            Me.colDueDate.Width = 116
            Me.colSubject.Caption = "SUBJECT"
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.OptionsColumn.AllowEdit = False
            Me.colSubject.OptionsColumn.AllowFocus = False
            Me.colSubject.Visible = True
            Me.colSubject.VisibleIndex = 1
            Me.colSubject.Width = 221
            Me.colDescription.Caption = "DESCRIPTION"
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.OptionsColumn.AllowEdit = False
            Me.colDescription.OptionsColumn.AllowFocus = False
            Me.colDescription.OptionsColumn.ShowInCustomizationForm = False
            Me.colDescription.OptionsFilter.AllowFilter = False
            Me.colDescription.Width = 504
            Me.buttonPanel.ButtonBackgroundImages = Me.buttonImages
            Me.buttonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("", Nothing, 0, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1),
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("", Nothing, 1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1),
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("", Nothing, 2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1),
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("", Nothing, 3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1)
            })
            Me.buttonPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.buttonPanel.Images = Me.images
            Me.buttonPanel.Location = New System.Drawing.Point(144, 84)
            Me.buttonPanel.Name = "buttonPanel"
            Me.buttonPanel.Size = New System.Drawing.Size(420, 28)
            Me.buttonPanel.TabIndex = 4
            Me.buttonPanel.Text = "windowsUIButtonPanel1"
            Me.buttonImages.ImageStream = (CType(resources.GetObject("buttonImages.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.buttonImages.TransparentColor = System.Drawing.Color.Transparent
            Me.buttonImages.Images.SetKeyName(0, "glyph-backg-normal.png")
            Me.buttonImages.Images.SetKeyName(1, "glyph-backg-hover.png")
            Me.buttonImages.Images.SetKeyName(2, "glyph-backg-pressed.png")
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForPhoto, Me.simpleSeparator1, Me.emptySpaceItem2, Me.lciTasks, Me.emptySpaceItem1, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlGroup2, Me.lciEvaluations})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(578, 593)
            Me.layoutControlGroup1.TextVisible = False
            Me.ItemForPhoto.Control = Me.pictureEdit
            Me.ItemForPhoto.CustomizationFormText = "ItemForPhoto"
            Me.ItemForPhoto.Location = New System.Drawing.Point(0, 0)
            Me.ItemForPhoto.MaxSize = New System.Drawing.Size(130, 130)
            Me.ItemForPhoto.MinSize = New System.Drawing.Size(130, 130)
            Me.ItemForPhoto.Name = "ItemForPhoto"
            Me.ItemForPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForPhoto.Size = New System.Drawing.Size(130, 136)
            Me.ItemForPhoto.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForPhoto.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForPhoto.TextVisible = False
            Me.simpleSeparator1.AllowHotTrack = False
            Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
            Me.simpleSeparator1.Location = New System.Drawing.Point(0, 146)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10)
            Me.simpleSeparator1.Size = New System.Drawing.Size(578, 2)
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 136)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(578, 10)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.lciTasks.Control = Me.gcTasks
            Me.lciTasks.CustomizationFormText = "lciTasks"
            Me.lciTasks.Location = New System.Drawing.Point(0, 177)
            Me.lciTasks.Name = "lciTasks"
            Me.lciTasks.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lciTasks.Size = New System.Drawing.Size(289, 416)
            Me.lciTasks.TextSize = New System.Drawing.Size(0, 0)
            Me.lciTasks.TextVisible = False
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 148)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(435, 29)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.Control = Me.lbEvaluations
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(435, 148)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
            Me.layoutControlItem4.Size = New System.Drawing.Size(87, 29)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            Me.layoutControlItem5.Control = Me.lbSeparator
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(522, 148)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 10, 2)
            Me.layoutControlItem5.Size = New System.Drawing.Size(15, 29)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            Me.layoutControlItem6.Control = Me.lbTasks
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(537, 148)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
            Me.layoutControlItem6.Size = New System.Drawing.Size(41, 29)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.sliName, Me.sliTitle, Me.layoutControlItem2, Me.emptySpaceItem3})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(130, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(448, 136)
            Me.sliName.AllowHotTrack = False
            Me.sliName.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.sliName.AppearanceItemCaption.Options.UseFont = True
            Me.sliName.CustomizationFormText = "Name"
            Me.sliName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "FullNameBindable", True))
            Me.sliName.Location = New System.Drawing.Point(0, 0)
            Me.sliName.Name = "sliName"
            Me.sliName.Size = New System.Drawing.Size(424, 41)
            Me.sliName.Text = "Name"
            Me.sliName.TextSize = New System.Drawing.Size(71, 37)
            Me.sliTitle.AllowHotTrack = False
            Me.sliTitle.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.sliTitle.AppearanceItemCaption.Options.UseFont = True
            Me.sliTitle.CustomizationFormText = "Title"
            Me.sliTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "Title", True))
            Me.sliTitle.Location = New System.Drawing.Point(0, 41)
            Me.sliTitle.Name = "sliTitle"
            Me.sliTitle.Size = New System.Drawing.Size(424, 29)
            Me.sliTitle.Text = "Title"
            Me.sliTitle.TextSize = New System.Drawing.Size(71, 25)
            Me.layoutControlItem2.Control = Me.buttonPanel
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 70)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(1, 32)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(424, 32)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 102)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(424, 10)
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.lciEvaluations.Control = Me.gcEvaluations
            Me.lciEvaluations.CustomizationFormText = "lciEvaluations"
            Me.lciEvaluations.Location = New System.Drawing.Point(289, 177)
            Me.lciEvaluations.Name = "lciEvaluations"
            Me.lciEvaluations.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lciEvaluations.Size = New System.Drawing.Size(289, 416)
            Me.lciEvaluations.TextSize = New System.Drawing.Size(0, 0)
            Me.lciEvaluations.TextVisible = False
            Me.lciEvaluations.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.modueLayout)
            Me.Name = "EmployeeView"
            Me.Size = New System.Drawing.Size(578, 593)
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.images, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.modueLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.modueLayout.ResumeLayout(False)
            CType(Me.gcEvaluations, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gvEvaluations, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcTasks, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gvTasks, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForPhoto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciTasks, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sliName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sliTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciEvaluations, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private pictureEdit As DevExpress.XtraEditors.PictureEdit
        Private bindingSource As System.Windows.Forms.BindingSource
        Private modueLayout As XtraLayout.LayoutControl
        Private buttonPanel As XtraBars.Docking2010.WindowsUIButtonPanel
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private ItemForPhoto As XtraLayout.LayoutControlItem
        Private sliName As XtraLayout.SimpleLabelItem
        Private sliTitle As XtraLayout.SimpleLabelItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private simpleSeparator1 As XtraLayout.SimpleSeparator
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private gcTasks As XtraGrid.GridControl
        Private colDueDate As XtraGrid.Columns.GridColumn
        Private colSubject As XtraGrid.Columns.GridColumn
        Private lciTasks As XtraLayout.LayoutControlItem
        Private gvTasks As TaskPreviewGridView
        Private lbTasks As XtraEditors.LabelControl
        Private lbSeparator As XtraEditors.LabelControl
        Private lbEvaluations As XtraEditors.LabelControl
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private layoutControlItem6 As XtraLayout.LayoutControlItem
        Private gcEvaluations As XtraGrid.GridControl
        Private lciEvaluations As XtraLayout.LayoutControlItem
        Private colCreatedOn As XtraGrid.Columns.GridColumn
        Private colSubject1 As XtraGrid.Columns.GridColumn
        Private colCreatedBy As XtraGrid.Columns.GridColumn
        Private gvEvaluations As TaskPreviewGridView
        Private images As DevExpress.Utils.ImageCollection
        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
        Private buttonImages As System.Windows.Forms.ImageList
        Private colDescription As XtraGrid.Columns.GridColumn
    End Class
End Namespace
