Namespace DevExpress.XtraGrid.Demos
	Partial Public Class OutlookStyle
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OutlookStyle))
            Dim AlertButton1 As DevExpress.XtraBars.Alerter.AlertButton = New DevExpress.XtraBars.Alerter.AlertButton()
            Dim AlertButton2 As DevExpress.XtraBars.Alerter.AlertButton = New DevExpress.XtraBars.Alerter.AlertButton()
            Dim AlertButton3 As DevExpress.XtraBars.Alerter.AlertButton = New DevExpress.XtraBars.Alerter.AlertButton()
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection()
            Me.alertControl1 = New DevExpress.XtraBars.Alerter.AlertControl()
            Me.imageList3 = New System.Windows.Forms.ImageList()
            Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu()
            Me.biOpen = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biRead = New DevExpress.XtraBars.BarButtonItem()
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.bcLow = New DevExpress.XtraBars.BarCheckItem()
            Me.bcMedium = New DevExpress.XtraBars.BarCheckItem()
            Me.bcHigh = New DevExpress.XtraBars.BarCheckItem()
            Me.barManager1 = New DevExpress.XtraBars.BarManager()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.repositoryItemImageComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.ucMailViewer1 = New DevExpress.XtraGrid.Demos.ucMailViewer()
            Me.lcMailView = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcList = New DevExpress.XtraLayout.LayoutControlItem()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Demos.PreviewGridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ilColumns = New System.Windows.Forms.ImageList()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcMailView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridColumn2
            '
            resources.ApplyResources(Me.gridColumn2, "gridColumn2")
            Me.gridColumn2.ColumnEdit = Me.repositoryItemImageComboBox2
            Me.gridColumn2.FieldName = "Read"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.OptionsColumn.AllowEdit = False
            Me.gridColumn2.OptionsColumn.AllowFocus = False
            Me.gridColumn2.OptionsColumn.AllowSize = False
            Me.gridColumn2.OptionsColumn.FixedWidth = True
            Me.gridColumn2.OptionsColumn.ShowCaption = False
            '
            'repositoryItemImageComboBox2
            '
            resources.ApplyResources(Me.repositoryItemImageComboBox2, "repositoryItemImageComboBox2")
            Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items"), CType(resources.GetObject("repositoryItemImageComboBox2.Items1"), Object), CType(resources.GetObject("repositoryItemImageComboBox2.Items2"), Integer)), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items3"), CType(resources.GetObject("repositoryItemImageComboBox2.Items4"), Object), CType(resources.GetObject("repositoryItemImageComboBox2.Items5"), Integer))})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.SmallImages = Me.imageCollection1
            '
            'imageCollection1
            '
            resources.ApplyResources(Me.imageCollection1, "imageCollection1")
            Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            '
            'alertControl1
            '
            AlertButton1.Hint = "Mark as Read"
            AlertButton1.ImageDownIndex = 1
            AlertButton1.ImageIndex = 2
            AlertButton1.Name = "Read"
            AlertButton1.Style = DevExpress.XtraBars.Alerter.AlertButtonStyle.CheckButton
            AlertButton2.Hint = "Open Attachment"
            AlertButton2.Image = Global.My.Resources.Resources.attach_16x16
            AlertButton2.Name = "Attachment"
            AlertButton3.Hint = "Delete Item"
            AlertButton3.Image = Global.My.Resources.Resources.delete_16x16
            AlertButton3.Name = "Delete"
            Me.alertControl1.Buttons.Add(AlertButton1)
            Me.alertControl1.Buttons.Add(AlertButton2)
            Me.alertControl1.Buttons.Add(AlertButton3)
            Me.alertControl1.Images = Me.imageList3
            Me.alertControl1.PopupMenu = Me.popupMenu1
            '
            'imageList3
            '
            Me.imageList3.ImageStream = CType(resources.GetObject("imageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList3.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList3.Images.SetKeyName(0, "")
            Me.imageList3.Images.SetKeyName(1, "")
            Me.imageList3.Images.SetKeyName(2, "")
            Me.imageList3.Images.SetKeyName(3, "attach.png")
            '
            'popupMenu1
            '
            Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.biOpen), New DevExpress.XtraBars.LinkPersistInfo(Me.biDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.biRead), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1, True)})
            Me.popupMenu1.Manager = Me.barManager1
            Me.popupMenu1.Name = "popupMenu1"
            '
            'biOpen
            '
            resources.ApplyResources(Me.biOpen, "biOpen")
            Me.biOpen.Id = 4
            Me.biOpen.Name = "biOpen"
            '
            'biDelete
            '
            resources.ApplyResources(Me.biDelete, "biDelete")
            Me.biDelete.Glyph = Global.My.Resources.Resources.delete_16x16
            Me.biDelete.Id = 1
            Me.biDelete.Name = "biDelete"
            '
            'biRead
            '
            resources.ApplyResources(Me.biRead, "biRead")
            Me.biRead.Id = 2
            Me.biRead.ImageIndex = 1
            Me.biRead.Name = "biRead"
            '
            'barSubItem1
            '
            resources.ApplyResources(Me.barSubItem1, "barSubItem1")
            Me.barSubItem1.Id = 3
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bcLow), New DevExpress.XtraBars.LinkPersistInfo(Me.bcMedium), New DevExpress.XtraBars.LinkPersistInfo(Me.bcHigh)})
            Me.barSubItem1.Name = "barSubItem1"
            '
            'bcLow
            '
            resources.ApplyResources(Me.bcLow, "bcLow")
            Me.bcLow.GroupIndex = 1
            Me.bcLow.Id = 5
            Me.bcLow.Name = "bcLow"
            '
            'bcMedium
            '
            resources.ApplyResources(Me.bcMedium, "bcMedium")
            Me.bcMedium.GroupIndex = 1
            Me.bcMedium.Id = 8
            Me.bcMedium.Name = "bcMedium"
            '
            'bcHigh
            '
            resources.ApplyResources(Me.bcHigh, "bcHigh")
            Me.bcHigh.GroupIndex = 1
            Me.bcHigh.Id = 9
            Me.bcHigh.Name = "bcHigh"
            '
            'barManager1
            '
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Images = Me.imageList3
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.biDelete, Me.biRead, Me.barSubItem1, Me.biOpen, Me.bcLow, Me.bcMedium, Me.bcHigh})
            Me.barManager1.MaxItemId = 10
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            resources.ApplyResources(Me.barDockControlTop, "barDockControlTop")
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            resources.ApplyResources(Me.barDockControlBottom, "barDockControlBottom")
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            resources.ApplyResources(Me.barDockControlLeft, "barDockControlLeft")
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            resources.ApplyResources(Me.barDockControlRight, "barDockControlRight")
            '
            'repositoryItemImageComboBox4
            '
            resources.ApplyResources(Me.repositoryItemImageComboBox4, "repositoryItemImageComboBox4")
            Me.repositoryItemImageComboBox4.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox4.Items"), CType(resources.GetObject("repositoryItemImageComboBox4.Items1"), Object), CType(resources.GetObject("repositoryItemImageComboBox4.Items2"), Integer)), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox4.Items3"), CType(resources.GetObject("repositoryItemImageComboBox4.Items4"), Object), CType(resources.GetObject("repositoryItemImageComboBox4.Items5"), Integer))})
            Me.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4"
            Me.repositoryItemImageComboBox4.SmallImages = Me.imageCollection1
            '
            'ucMailViewer1
            '
            resources.ApplyResources(Me.ucMailViewer1, "ucMailViewer1")
            Me.ucMailViewer1.Name = "ucMailViewer1"
            Me.ucMailViewer1.ZoomFactor = 1.0!
            '
            'lcMailView
            '
            Me.lcMailView.Control = Me.ucMailViewer1
            resources.ApplyResources(Me.lcMailView, "lcMailView")
            Me.lcMailView.Location = New System.Drawing.Point(660, 0)
            Me.lcMailView.Name = "lcMailView"
            Me.lcMailView.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcMailView.Size = New System.Drawing.Size(441, 583)
            Me.lcMailView.TextSize = New System.Drawing.Size(0, 0)
            Me.lcMailView.TextToControlDistance = 0
            Me.lcMailView.TextVisible = False
            '
            'lcList
            '
            Me.lcList.Control = Me.gridControl1
            resources.ApplyResources(Me.lcList, "lcList")
            Me.lcList.Location = New System.Drawing.Point(0, 0)
            Me.lcList.Name = "lcList"
            Me.lcList.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcList.Size = New System.Drawing.Size(655, 583)
            Me.lcList.TextSize = New System.Drawing.Size(0, 0)
            Me.lcList.TextToControlDistance = 0
            Me.lcList.TextVisible = False
            '
            'gridControl1
            '
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3, Me.repositoryItemImageComboBox4})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7})
            Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
            StyleFormatCondition1.Appearance.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
            StyleFormatCondition1.Appearance.Options.UseFont = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.gridColumn2
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = 0
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            resources.ApplyResources(Me.gridView1, "gridView1")
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType(resources.GetObject("gridView1.GroupSummary"), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary1"), CType(resources.GetObject("gridView1.GroupSummary2"), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary3"))})
            Me.gridView1.Images = Me.ilColumns
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView1.OptionsFind.AlwaysVisible = True
            Me.gridView1.OptionsPrint.PrintHorzLines = False
            Me.gridView1.OptionsPrint.PrintPreview = True
            Me.gridView1.OptionsPrint.PrintVertLines = False
            Me.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office
            Me.gridView1.OptionsView.ShowGroupedColumns = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.PreviewFieldName = "PlainText"
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn6, DevExpress.Data.ColumnSortOrder.Descending)})
            '
            'gridColumn1
            '
            resources.ApplyResources(Me.gridColumn1, "gridColumn1")
            Me.gridColumn1.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.gridColumn1.FieldName = "Priority"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.OptionsColumn.AllowFocus = False
            Me.gridColumn1.OptionsColumn.AllowSize = False
            Me.gridColumn1.OptionsColumn.FixedWidth = True
            Me.gridColumn1.OptionsColumn.ShowCaption = False
            '
            'repositoryItemImageComboBox1
            '
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), CType(resources.GetObject("repositoryItemImageComboBox1.Items1"), Object), CType(resources.GetObject("repositoryItemImageComboBox1.Items2"), Integer)), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), CType(resources.GetObject("repositoryItemImageComboBox1.Items4"), Object), CType(resources.GetObject("repositoryItemImageComboBox1.Items5"), Integer)), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), CType(resources.GetObject("repositoryItemImageComboBox1.Items7"), Object), CType(resources.GetObject("repositoryItemImageComboBox1.Items8"), Integer))})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.imageCollection1
            '
            'gridColumn3
            '
            resources.ApplyResources(Me.gridColumn3, "gridColumn3")
            Me.gridColumn3.ColumnEdit = Me.repositoryItemImageComboBox3
            Me.gridColumn3.FieldName = "Attachment"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.OptionsColumn.AllowEdit = False
            Me.gridColumn3.OptionsColumn.AllowFocus = False
            Me.gridColumn3.OptionsColumn.AllowSize = False
            Me.gridColumn3.OptionsColumn.FixedWidth = True
            Me.gridColumn3.OptionsColumn.ShowCaption = False
            '
            'repositoryItemImageComboBox3
            '
            resources.ApplyResources(Me.repositoryItemImageComboBox3, "repositoryItemImageComboBox3")
            Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items"), CType(resources.GetObject("repositoryItemImageComboBox3.Items1"), Object), CType(resources.GetObject("repositoryItemImageComboBox3.Items2"), Integer)), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items3"), CType(resources.GetObject("repositoryItemImageComboBox3.Items4"), Object), CType(resources.GetObject("repositoryItemImageComboBox3.Items5"), Integer))})
            Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
            Me.repositoryItemImageComboBox3.SmallImages = Me.imageCollection1
            '
            'gridColumn4
            '
            resources.ApplyResources(Me.gridColumn4, "gridColumn4")
            Me.gridColumn4.FieldName = "Subject"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.OptionsColumn.AllowFocus = False
            '
            'gridColumn5
            '
            resources.ApplyResources(Me.gridColumn5, "gridColumn5")
            Me.gridColumn5.FieldName = "From"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.OptionsColumn.AllowFocus = False
            '
            'gridColumn6
            '
            resources.ApplyResources(Me.gridColumn6, "gridColumn6")
            Me.gridColumn6.FieldName = "Date"
            Me.gridColumn6.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.OptionsColumn.AllowFocus = False
            Me.gridColumn6.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt
            '
            'gridColumn7
            '
            Me.gridColumn7.ColumnEdit = Me.repositoryItemImageComboBox4
            Me.gridColumn7.FieldName = "Read"
            resources.ApplyResources(Me.gridColumn7, "gridColumn7")
            Me.gridColumn7.Name = "gridColumn7"
            Me.gridColumn7.OptionsColumn.AllowEdit = False
            Me.gridColumn7.OptionsColumn.AllowFocus = False
            Me.gridColumn7.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridColumn7.OptionsColumn.AllowShowHide = False
            Me.gridColumn7.OptionsColumn.AllowSize = False
            Me.gridColumn7.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridColumn7.OptionsColumn.FixedWidth = True
            Me.gridColumn7.OptionsColumn.ShowCaption = False
            Me.gridColumn7.OptionsFilter.AllowAutoFilter = False
            Me.gridColumn7.OptionsFilter.AllowFilter = False
            '
            'ilColumns
            '
            Me.ilColumns.ImageStream = CType(resources.GetObject("ilColumns.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ilColumns.TransparentColor = System.Drawing.Color.Transparent
            Me.ilColumns.Images.SetKeyName(0, "Importance.png")
            Me.ilColumns.Images.SetKeyName(1, "Icon.png")
            Me.ilColumns.Images.SetKeyName(2, "Attach.png")
            Me.ilColumns.Images.SetKeyName(3, "Whatched.png")
            '
            'layoutControlGroup1
            '
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcList, Me.lcMailView, Me.splitterItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1113, 595)
            Me.layoutControlGroup1.TextVisible = False
            '
            'splitterItem1
            '
            Me.splitterItem1.AllowHotTrack = True
            resources.ApplyResources(Me.splitterItem1, "splitterItem1")
            Me.splitterItem1.Location = New System.Drawing.Point(655, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(5, 583)
            '
            'layoutControl1
            '
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ucMailViewer1)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(694, 412, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            '
            'OutlookStyle
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "OutlookStyle"
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcMailView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private components As System.ComponentModel.IContainer
		Private WithEvents alertControl1 As DevExpress.XtraBars.Alerter.AlertControl
		Private imageList3 As System.Windows.Forms.ImageList
		Private WithEvents barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private WithEvents biDelete As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biRead As DevExpress.XtraBars.BarButtonItem
		Private barSubItem1 As DevExpress.XtraBars.BarSubItem
		Private WithEvents biOpen As DevExpress.XtraBars.BarButtonItem
		Private WithEvents bcLow As DevExpress.XtraBars.BarCheckItem
		Private WithEvents bcMedium As DevExpress.XtraBars.BarCheckItem
		Private WithEvents bcHigh As DevExpress.XtraBars.BarCheckItem
		Private layoutControl1 As XtraLayout.LayoutControl
        Private ucMailViewer1 As ucMailViewer
		Private WithEvents gridControl1 As GridControl
		Private repositoryItemImageComboBox1 As XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageCollection1 As Utils.ImageCollection
		Private repositoryItemImageComboBox2 As XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox3 As XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox4 As XtraEditors.Repository.RepositoryItemImageComboBox
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private lcList As XtraLayout.LayoutControlItem
		Private lcMailView As XtraLayout.LayoutControlItem
		Private splitterItem1 As XtraLayout.SplitterItem
		Private ilColumns As System.Windows.Forms.ImageList
		Private gridColumn1 As Columns.GridColumn
		Private gridColumn2 As Columns.GridColumn
		Private gridColumn3 As Columns.GridColumn
		Private gridColumn4 As Columns.GridColumn
		Private gridColumn5 As Columns.GridColumn
		Private gridColumn6 As Columns.GridColumn
		Private gridColumn7 As Columns.GridColumn
		Private WithEvents gridView1 As PreviewGridView

	End Class
End Namespace
