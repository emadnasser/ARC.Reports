Namespace DevExpress.XtraLayout.Demos
	Partial Public Class MultilanguageForm
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MultilanguageForm))
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.xpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
			Me.labelControl8 = New DevExpress.XtraEditors.LabelControl()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutModeGroup = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutModeGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.FontSizeDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.FontSizeDelta"), Integer))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.FontStyleDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.GradientMode = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.Image = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.Image"), System.Drawing.Image))
            Me.layoutControl1.Appearance.DisabledLayoutItem.FontSizeDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.FontSizeDelta"), Integer))
            Me.layoutControl1.Appearance.DisabledLayoutItem.FontStyleDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.Appearance.DisabledLayoutItem.GradientMode = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.Appearance.DisabledLayoutItem.Image = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.Image"), System.Drawing.Image))
            Me.layoutControl1.Controls.Add(Me.dataNavigator1)
            Me.layoutControl1.Controls.Add(Me.labelControl8)
            Me.layoutControl1.Controls.Add(Me.memoEdit1)
            Me.layoutControl1.Controls.Add(Me.labelControl7)
            Me.layoutControl1.Controls.Add(Me.labelControl6)
            Me.layoutControl1.Controls.Add(Me.labelControl5)
            Me.layoutControl1.Controls.Add(Me.labelControl4)
            Me.layoutControl1.Controls.Add(Me.labelControl3)
            Me.layoutControl1.Controls.Add(Me.labelControl2)
            Me.layoutControl1.Controls.Add(Me.labelControl1)
            Me.layoutControl1.Controls.Add(Me.pictureEdit1)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(524, 175, 852, 623)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' dataNavigator1
            ' 
            resources.ApplyResources(Me.dataNavigator1, "dataNavigator1")
            Me.dataNavigator1.DataSource = Me.xpCollection1
            Me.dataNavigator1.Name = "dataNavigator1"
            Me.dataNavigator1.StyleController = Me.layoutControl1
            ' 
            ' xpCollection1
            ' 
            Me.xpCollection1.ObjectType = GetType(DevExpress.XtraLayout.Demos.VideoCatalogItem)
            ' 
            ' labelControl8
            ' 
            resources.ApplyResources(Me.labelControl8, "labelControl8")
            Me.labelControl8.AppearanceDisabled.Image = (CType(resources.GetObject("labelControl8.Appearance.DisabledImage"), System.Drawing.Image))
            Me.labelControl8.Appearance.Font = (CType(resources.GetObject("labelControl8.Appearance.Font"), System.Drawing.Font))
            Me.labelControl8.Appearance.FontSizeDelta = (CType(resources.GetObject("labelControl8.Appearance.FontSizeDelta"), Integer))
            Me.labelControl8.Appearance.FontStyleDelta = (CType(resources.GetObject("labelControl8.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.labelControl8.Appearance.GradientMode = (CType(resources.GetObject("labelControl8.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.labelControl8.AppearanceHovered.Image = (CType(resources.GetObject("labelControl8.Appearance.HoverImage"), System.Drawing.Image))
            Me.labelControl8.Appearance.Image = (CType(resources.GetObject("labelControl8.Appearance.Image"), System.Drawing.Image))
            Me.labelControl8.AppearancePressed.Image = (CType(resources.GetObject("labelControl8.Appearance.PressedImage"), System.Drawing.Image))
            Me.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl8.Name = "labelControl8"
            Me.labelControl8.StyleController = Me.layoutControl1
            ' 
            ' memoEdit1
            ' 
            resources.ApplyResources(Me.memoEdit1, "memoEdit1")
            Me.memoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.xpCollection1, "Description", True))
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Properties.AccessibleDescription = resources.GetString("memoEdit1.Properties.AccessibleDescription")
            Me.memoEdit1.Properties.AccessibleName = resources.GetString("memoEdit1.Properties.AccessibleName")
            Me.memoEdit1.Properties.NullValuePrompt = resources.GetString("memoEdit1.Properties.NullValuePrompt")
            Me.memoEdit1.Properties.NullValuePromptShowForEmptyValue = (CType(resources.GetObject("memoEdit1.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.memoEdit1.StyleController = Me.layoutControl1
            Me.memoEdit1.TabStop = False
            ' 
            ' labelControl7
            ' 
            resources.ApplyResources(Me.labelControl7, "labelControl7")
            Me.labelControl7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.xpCollection1, "RunTime", True))
            Me.labelControl7.Name = "labelControl7"
            Me.labelControl7.StyleController = Me.layoutControl1
            ' 
            ' labelControl6
            ' 
            resources.ApplyResources(Me.labelControl6, "labelControl6")
            Me.labelControl6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.xpCollection1, "Country", True))
            Me.labelControl6.Name = "labelControl6"
            Me.labelControl6.StyleController = Me.layoutControl1
            ' 
            ' labelControl5
            ' 
            resources.ApplyResources(Me.labelControl5, "labelControl5")
            Me.labelControl5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.xpCollection1, "Cast", True))
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.StyleController = Me.layoutControl1
            ' 
            ' labelControl4
            ' 
            resources.ApplyResources(Me.labelControl4, "labelControl4")
            Me.labelControl4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.xpCollection1, "Genre", True))
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.StyleController = Me.layoutControl1
            ' 
            ' labelControl3
            ' 
            resources.ApplyResources(Me.labelControl3, "labelControl3")
            Me.labelControl3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.xpCollection1, "Year", True))
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.StyleController = Me.layoutControl1
            ' 
            ' labelControl2
            ' 
            resources.ApplyResources(Me.labelControl2, "labelControl2")
            Me.labelControl2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.xpCollection1, "Director", True))
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.StyleController = Me.layoutControl1
            ' 
            ' labelControl1
            ' 
            resources.ApplyResources(Me.labelControl1, "labelControl1")
            Me.labelControl1.AppearanceDisabled.Image = (CType(resources.GetObject("labelControl1.Appearance.DisabledImage"), System.Drawing.Image))
            Me.labelControl1.Appearance.Font = (CType(resources.GetObject("labelControl1.Appearance.Font"), System.Drawing.Font))
            Me.labelControl1.Appearance.FontSizeDelta = (CType(resources.GetObject("labelControl1.Appearance.FontSizeDelta"), Integer))
            Me.labelControl1.Appearance.FontStyleDelta = (CType(resources.GetObject("labelControl1.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.labelControl1.Appearance.ForeColor = (CType(resources.GetObject("labelControl1.Appearance.ForeColor"), System.Drawing.Color))
            Me.labelControl1.Appearance.GradientMode = (CType(resources.GetObject("labelControl1.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.labelControl1.AppearanceHovered.Image = (CType(resources.GetObject("labelControl1.Appearance.HoverImage"), System.Drawing.Image))
            Me.labelControl1.Appearance.Image = (CType(resources.GetObject("labelControl1.Appearance.Image"), System.Drawing.Image))
            Me.labelControl1.AppearancePressed.Image = (CType(resources.GetObject("labelControl1.Appearance.PressedImage"), System.Drawing.Image))
            Me.labelControl1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.xpCollection1, "Caption", True))
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.StyleController = Me.layoutControl1
            ' 
            ' pictureEdit1
            ' 
            resources.ApplyResources(Me.pictureEdit1, "pictureEdit1")
            Me.pictureEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Photo", True))
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.AccessibleDescription = resources.GetString("pictureEdit1.Properties.AccessibleDescription")
            Me.pictureEdit1.Properties.AccessibleName = resources.GetString("pictureEdit1.Properties.AccessibleName")
            Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.pictureEdit1.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AppearanceItemCaption.Font = (CType(resources.GetObject("layoutControlGroup1.AppearanceItemCaption.Font"), System.Drawing.Font))
            Me.layoutControlGroup1.AppearanceItemCaption.FontSizeDelta = (CType(resources.GetObject("layoutControlGroup1.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.layoutControlGroup1.AppearanceItemCaption.FontStyleDelta = (CType(resources.GetObject("layoutControlGroup1.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControlGroup1.AppearanceItemCaption.GradientMode = (CType(resources.GetObject("layoutControlGroup1.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControlGroup1.AppearanceItemCaption.Image = (CType(resources.GetObject("layoutControlGroup1.AppearanceItemCaption.Image"), System.Drawing.Image))
            Me.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = True
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem9, Me.layoutControlItem10, Me.layoutControlItem11, Me.emptySpaceItem2, Me.layoutModeGroup, Me.emptySpaceItem3, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(488, 361)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.pictureEdit1
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 35)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(230, 195)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(230, 195)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem1.Size = New System.Drawing.Size(230, 195)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.memoEdit1
            resources.ApplyResources(Me.layoutControlItem9, "layoutControlItem9")
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 240)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem9.Size = New System.Drawing.Size(486, 90)
            Me.layoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(77, 13)
            Me.layoutControlItem9.TextToControlDistance = 0
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.labelControl8
            resources.ApplyResources(Me.layoutControlItem10, "layoutControlItem10")
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem10.Size = New System.Drawing.Size(486, 35)
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.dataNavigator1
            resources.ApplyResources(Me.layoutControlItem11, "layoutControlItem11")
            Me.layoutControlItem11.Location = New System.Drawing.Point(291, 330)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem11.Size = New System.Drawing.Size(195, 29)
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem2, "emptySpaceItem2")
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 330)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.emptySpaceItem2.Size = New System.Drawing.Size(291, 29)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutModeGroup
            ' 
            Me.layoutModeGroup.AllowDrawBackground = False
            resources.ApplyResources(Me.layoutModeGroup, "layoutModeGroup")
            Me.layoutModeGroup.GroupBordersVisible = False
            Me.layoutModeGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8})
            Me.layoutModeGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Flow
            Me.layoutModeGroup.Location = New System.Drawing.Point(240, 35)
            Me.layoutModeGroup.Name = "layoutModeGroup"
            Me.layoutModeGroup.Size = New System.Drawing.Size(246, 205)
            Me.layoutModeGroup.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.AppearanceItemCaption.FontSizeDelta = (CType(resources.GetObject("layoutControlItem2.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.layoutControlItem2.AppearanceItemCaption.FontStyleDelta = (CType(resources.GetObject("layoutControlItem2.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControlItem2.AppearanceItemCaption.GradientMode = (CType(resources.GetObject("layoutControlItem2.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControlItem2.AppearanceItemCaption.Image = (CType(resources.GetObject("layoutControlItem2.AppearanceItemCaption.Image"), System.Drawing.Image))
            Me.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.layoutControlItem2.Control = Me.labelControl1
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem2.Size = New System.Drawing.Size(192, 36)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.AppearanceItemCaption.FontSizeDelta = (CType(resources.GetObject("layoutControlItem3.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.layoutControlItem3.AppearanceItemCaption.FontStyleDelta = (CType(resources.GetObject("layoutControlItem3.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControlItem3.AppearanceItemCaption.GradientMode = (CType(resources.GetObject("layoutControlItem3.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControlItem3.AppearanceItemCaption.Image = (CType(resources.GetObject("layoutControlItem3.AppearanceItemCaption.Image"), System.Drawing.Image))
            Me.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.layoutControlItem3.Control = Me.labelControl2
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 36)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem3.Size = New System.Drawing.Size(192, 24)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.AppearanceItemCaption.FontSizeDelta = (CType(resources.GetObject("layoutControlItem4.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.layoutControlItem4.AppearanceItemCaption.FontStyleDelta = (CType(resources.GetObject("layoutControlItem4.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControlItem4.AppearanceItemCaption.GradientMode = (CType(resources.GetObject("layoutControlItem4.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControlItem4.AppearanceItemCaption.Image = (CType(resources.GetObject("layoutControlItem4.AppearanceItemCaption.Image"), System.Drawing.Image))
            Me.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.layoutControlItem4.Control = Me.labelControl3
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 60)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem4.Size = New System.Drawing.Size(192, 24)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.AppearanceItemCaption.FontSizeDelta = (CType(resources.GetObject("layoutControlItem5.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.layoutControlItem5.AppearanceItemCaption.FontStyleDelta = (CType(resources.GetObject("layoutControlItem5.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControlItem5.AppearanceItemCaption.GradientMode = (CType(resources.GetObject("layoutControlItem5.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControlItem5.AppearanceItemCaption.Image = (CType(resources.GetObject("layoutControlItem5.AppearanceItemCaption.Image"), System.Drawing.Image))
            Me.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.layoutControlItem5.Control = Me.labelControl4
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 84)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem5.Size = New System.Drawing.Size(192, 24)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.AppearanceItemCaption.FontSizeDelta = (CType(resources.GetObject("layoutControlItem6.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.layoutControlItem6.AppearanceItemCaption.FontStyleDelta = (CType(resources.GetObject("layoutControlItem6.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControlItem6.AppearanceItemCaption.GradientMode = (CType(resources.GetObject("layoutControlItem6.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControlItem6.AppearanceItemCaption.Image = (CType(resources.GetObject("layoutControlItem6.AppearanceItemCaption.Image"), System.Drawing.Image))
            Me.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.layoutControlItem6.Control = Me.labelControl5
            resources.ApplyResources(Me.layoutControlItem6, "layoutControlItem6")
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 108)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem6.Size = New System.Drawing.Size(192, 24)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.AppearanceItemCaption.FontSizeDelta = (CType(resources.GetObject("layoutControlItem7.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.layoutControlItem7.AppearanceItemCaption.FontStyleDelta = (CType(resources.GetObject("layoutControlItem7.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControlItem7.AppearanceItemCaption.GradientMode = (CType(resources.GetObject("layoutControlItem7.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControlItem7.AppearanceItemCaption.Image = (CType(resources.GetObject("layoutControlItem7.AppearanceItemCaption.Image"), System.Drawing.Image))
            Me.layoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.layoutControlItem7.Control = Me.labelControl6
            resources.ApplyResources(Me.layoutControlItem7, "layoutControlItem7")
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 132)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem7.Size = New System.Drawing.Size(192, 24)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.AppearanceItemCaption.FontSizeDelta = (CType(resources.GetObject("layoutControlItem8.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.layoutControlItem8.AppearanceItemCaption.FontStyleDelta = (CType(resources.GetObject("layoutControlItem8.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControlItem8.AppearanceItemCaption.GradientMode = (CType(resources.GetObject("layoutControlItem8.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControlItem8.AppearanceItemCaption.Image = (CType(resources.GetObject("layoutControlItem8.AppearanceItemCaption.Image"), System.Drawing.Image))
            Me.layoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.layoutControlItem8.Control = Me.labelControl7
            resources.ApplyResources(Me.layoutControlItem8, "layoutControlItem8")
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 156)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem8.Size = New System.Drawing.Size(192, 24)
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem3, "emptySpaceItem3")
            Me.emptySpaceItem3.Location = New System.Drawing.Point(230, 35)
            Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(10, 0)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(10, 205)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 230)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(230, 10)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' MultilanguageForm
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "MultilanguageForm"
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutModeGroup, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private xpCollection1 As DevExpress.Xpo.XPCollection
		Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
		Private labelControl6 As DevExpress.XtraEditors.LabelControl
		Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
		Private labelControl7 As DevExpress.XtraEditors.LabelControl
		Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
		Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
		Private labelControl8 As DevExpress.XtraEditors.LabelControl
		Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private layoutModeGroup As LayoutControlGroup
		Private components As System.ComponentModel.IContainer
		Public layoutControl1 As LayoutControl
		Private emptySpaceItem3 As EmptySpaceItem
		Private layoutControlItem2 As LayoutControlItem
		Private emptySpaceItem1 As EmptySpaceItem
	End Class
End Namespace
