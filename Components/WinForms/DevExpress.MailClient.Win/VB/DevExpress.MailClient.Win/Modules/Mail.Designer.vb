Namespace DevExpress.MailClient.Win
	Partial Public Class Mail
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Mail))
			Dim styleFormatCondition1 As New DevExpress.XtraGrid.StyleFormatCondition()
			Me.gcIcon = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.icEditors = New DevExpress.Utils.ImageCollection(Me.components)
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.ucMailViewer1 = New DevExpress.MailClient.Win.ucMailViewer()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.MailClient.Win.MyGridView()
			Me.gcPriority = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.gcAttachment = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.gcSubject = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gcFrom = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gcDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gcRead = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.ilColumns = New System.Windows.Forms.ImageList(Me.components)
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lcList = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lcMailView = New DevExpress.XtraLayout.LayoutControlItem()
			Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icEditors, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcMailView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gcIcon
            ' 
            resources.ApplyResources(Me.gcIcon, "gcIcon")
            Me.gcIcon.ColumnEdit = Me.repositoryItemImageComboBox2
            Me.gcIcon.FieldName = "Read"
            Me.gcIcon.Name = "gcIcon"
            Me.gcIcon.OptionsColumn.AllowEdit = False
            Me.gcIcon.OptionsColumn.AllowFocus = False
            Me.gcIcon.OptionsColumn.AllowSize = False
            Me.gcIcon.OptionsColumn.FixedWidth = True
            Me.gcIcon.OptionsColumn.ShowCaption = False
            ' 
            ' repositoryItemImageComboBox2
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox2, "repositoryItemImageComboBox2")
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items"), (CType(resources.GetObject("repositoryItemImageComboBox2.Items1"), Object)), (CType(resources.GetObject("repositoryItemImageComboBox2.Items2"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items3"), (CType(resources.GetObject("repositoryItemImageComboBox2.Items4"), Object)), (CType(resources.GetObject("repositoryItemImageComboBox2.Items5"), Integer)))
            })
            Me.repositoryItemImageComboBox2.SmallImages = Me.icEditors
            ' 
            ' icEditors
            ' 
            resources.ApplyResources(Me.icEditors, "icEditors")
            Me.icEditors.ImageStream = (CType(resources.GetObject("icEditors.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.icEditors.Images.SetKeyName(0, "Low.png")
            Me.icEditors.Images.SetKeyName(1, "High.png")
            Me.icEditors.Images.SetKeyName(2, "ReadMessage_13x13.png")
            Me.icEditors.Images.SetKeyName(3, "UnreadMessage_13x13.png")
            Me.icEditors.Images.SetKeyName(4, "Attachment.png")
            Me.icEditors.Images.SetKeyName(5, "Unread.png")
            Me.icEditors.Images.SetKeyName(6, "Read.png")
            ' 
            ' layoutControl1
            ' 
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.FontSizeDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.FontSizeDelta"), Integer))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.FontStyleDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.GradientMode = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.Image = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.Image"), System.Drawing.Image))
            Me.layoutControl1.Appearance.DisabledLayoutItem.FontSizeDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.FontSizeDelta"), Integer))
            Me.layoutControl1.Appearance.DisabledLayoutItem.FontStyleDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.Appearance.DisabledLayoutItem.GradientMode = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.Appearance.DisabledLayoutItem.Image = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.Image"), System.Drawing.Image))
            Me.layoutControl1.Controls.Add(Me.ucMailViewer1)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(694, 412, 450, 350)
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.FontSizeDelta = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.FontSizeDelta"), Integer))
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.FontStyleDelta = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.GradientMode = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Image = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.Image"), System.Drawing.Image))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.FontSizeDelta = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.FontStyleDelta = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.GradientMode = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.Image = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.Image"), System.Drawing.Image))
            'this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' ucMailViewer1
            ' 
            resources.ApplyResources(Me.ucMailViewer1, "ucMailViewer1")
            Me.ucMailViewer1.Name = "ucMailViewer1"
            Me.ucMailViewer1.ZoomFactor = 1.0F
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.EmbeddedNavigator.AccessibleDescription = resources.GetString("gridControl1.EmbeddedNavigator.AccessibleDescription")
            Me.gridControl1.EmbeddedNavigator.AccessibleName = resources.GetString("gridControl1.EmbeddedNavigator.AccessibleName")
            Me.gridControl1.EmbeddedNavigator.AllowHtmlTextInToolTip = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean))
            Me.gridControl1.EmbeddedNavigator.Anchor = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles))
            Me.gridControl1.EmbeddedNavigator.BackgroundImage = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image))
            Me.gridControl1.EmbeddedNavigator.BackgroundImageLayout = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout))
            Me.gridControl1.EmbeddedNavigator.ImeMode = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode))
            Me.gridControl1.EmbeddedNavigator.MaximumSize = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.MaximumSize"), System.Drawing.Size))
            Me.gridControl1.EmbeddedNavigator.TextLocation = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation))
            Me.gridControl1.EmbeddedNavigator.ToolTip = resources.GetString("gridControl1.EmbeddedNavigator.ToolTip")
            Me.gridControl1.EmbeddedNavigator.ToolTipIconType = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
            Me.gridControl1.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridControl1.EmbeddedNavigator.ToolTipTitle")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3, Me.repositoryItemImageComboBox4})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            resources.ApplyResources(Me.gridView1, "gridView1")
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcPriority, Me.gcIcon, Me.gcAttachment, Me.gcSubject, Me.gcFrom, Me.gcDate, Me.gcRead})
            Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
            styleFormatCondition1.Appearance.Font = (CType(resources.GetObject("resource.Font"), System.Drawing.Font))
            styleFormatCondition1.Appearance.FontSizeDelta = (CType(resources.GetObject("resource.FontSizeDelta"), Integer))
            styleFormatCondition1.Appearance.FontStyleDelta = (CType(resources.GetObject("resource.FontStyleDelta"), System.Drawing.FontStyle))
            styleFormatCondition1.Appearance.GradientMode = (CType(resources.GetObject("resource.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            styleFormatCondition1.Appearance.Image = (CType(resources.GetObject("resource.Image"), System.Drawing.Image))
            styleFormatCondition1.Appearance.Options.UseFont = True
            styleFormatCondition1.ApplyToRow = True
            styleFormatCondition1.Column = Me.gcIcon
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            styleFormatCondition1.Value1 = 0
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {styleFormatCondition1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem((CType(resources.GetObject("gridView1.GroupSummary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView1.GroupSummary1"), (CType(resources.GetObject("gridView1.GroupSummary2"), DevExpress.XtraGrid.Columns.GridColumn)), resources.GetString("gridView1.GroupSummary3"))})
            Me.gridView1.Images = Me.ilColumns
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True
            Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
            Me.gridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView1.OptionsFind.AlwaysVisible = True
            Me.gridView1.OptionsPrint.PrintHorzLines = False
            Me.gridView1.OptionsPrint.PrintVertLines = False
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office
            Me.gridView1.OptionsView.ShowGroupedColumns = True
            Me.gridView1.OptionsView.ShowIndicator = False
            Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            Me.gridView1.PreviewFieldName = "PlainText"
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcDate, DevExpress.Data.ColumnSortOrder.Descending)})
            '			Me.gridView1.RowClick += New DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(Me.gridView1_RowClick)
            '			Me.gridView1.RowCellClick += New DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(Me.gridView1_RowCellClick)
            '			Me.gridView1.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.gridView1_CustomDrawCell)
            '			Me.gridView1.CustomDrawGroupRow += New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(Me.gridView1_CustomDrawGroupRow)
            '			Me.gridView1.SelectionChanged += New DevExpress.Data.SelectionChangedEventHandler(Me.gridView1_SelectionChanged)
            '			Me.gridView1.ColumnPositionChanged += New System.EventHandler(Me.gridView1_ColumnPositionChanged)
            '			Me.gridView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.gridView1_FocusedRowChanged)
            '			Me.gridView1.ColumnFilterChanged += New System.EventHandler(Me.gridView1_ColumnFilterChanged)
            '			Me.gridView1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.gridView1_KeyDown)
            '			Me.gridView1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.gridView1_MouseDown)
            '			Me.gridView1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.gridView1_MouseMove)
            ' 
            ' gcPriority
            ' 
            resources.ApplyResources(Me.gcPriority, "gcPriority")
            Me.gcPriority.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.gcPriority.FieldName = "Priority"
            Me.gcPriority.Name = "gcPriority"
            Me.gcPriority.OptionsColumn.AllowFocus = False
            Me.gcPriority.OptionsColumn.AllowSize = False
            Me.gcPriority.OptionsColumn.FixedWidth = True
            Me.gcPriority.OptionsColumn.ShowCaption = False
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (CType(resources.GetObject("repositoryItemImageComboBox1.Items1"), Object)), (CType(resources.GetObject("repositoryItemImageComboBox1.Items2"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (CType(resources.GetObject("repositoryItemImageComboBox1.Items4"), Object)), (CType(resources.GetObject("repositoryItemImageComboBox1.Items5"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), (CType(resources.GetObject("repositoryItemImageComboBox1.Items7"), Object)), (CType(resources.GetObject("repositoryItemImageComboBox1.Items8"), Integer)))
            })
            Me.repositoryItemImageComboBox1.SmallImages = Me.icEditors
            ' 
            ' gcAttachment
            ' 
            resources.ApplyResources(Me.gcAttachment, "gcAttachment")
            Me.gcAttachment.ColumnEdit = Me.repositoryItemImageComboBox3
            Me.gcAttachment.FieldName = "Attachment"
            Me.gcAttachment.Name = "gcAttachment"
            Me.gcAttachment.OptionsColumn.AllowEdit = False
            Me.gcAttachment.OptionsColumn.AllowFocus = False
            Me.gcAttachment.OptionsColumn.AllowSize = False
            Me.gcAttachment.OptionsColumn.FixedWidth = True
            Me.gcAttachment.OptionsColumn.ShowCaption = False
            ' 
            ' repositoryItemImageComboBox3
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox3, "repositoryItemImageComboBox3")
            Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
            Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items"), (CType(resources.GetObject("repositoryItemImageComboBox3.Items1"), Object)), (CType(resources.GetObject("repositoryItemImageComboBox3.Items2"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items3"), (CType(resources.GetObject("repositoryItemImageComboBox3.Items4"), Object)), (CType(resources.GetObject("repositoryItemImageComboBox3.Items5"), Integer)))
            })
            Me.repositoryItemImageComboBox3.SmallImages = Me.icEditors
            ' 
            ' gcSubject
            ' 
            resources.ApplyResources(Me.gcSubject, "gcSubject")
            Me.gcSubject.FieldName = "Subject"
            Me.gcSubject.Name = "gcSubject"
            Me.gcSubject.OptionsColumn.AllowFocus = False
            ' 
            ' gcFrom
            ' 
            resources.ApplyResources(Me.gcFrom, "gcFrom")
            Me.gcFrom.FieldName = "From"
            Me.gcFrom.Name = "gcFrom"
            Me.gcFrom.OptionsColumn.AllowFocus = False
            ' 
            ' gcDate
            ' 
            resources.ApplyResources(Me.gcDate, "gcDate")
            Me.gcDate.FieldName = "Date"
            Me.gcDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.gcDate.Name = "gcDate"
            Me.gcDate.OptionsColumn.AllowFocus = False
            Me.gcDate.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt
            ' 
            ' gcRead
            ' 
            resources.ApplyResources(Me.gcRead, "gcRead")
            Me.gcRead.ColumnEdit = Me.repositoryItemImageComboBox4
            Me.gcRead.FieldName = "Read"
            Me.gcRead.Name = "gcRead"
            Me.gcRead.OptionsColumn.AllowEdit = False
            Me.gcRead.OptionsColumn.AllowFocus = False
            Me.gcRead.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            Me.gcRead.OptionsColumn.AllowShowHide = False
            Me.gcRead.OptionsColumn.AllowSize = False
            Me.gcRead.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.gcRead.OptionsColumn.FixedWidth = True
            Me.gcRead.OptionsColumn.ShowCaption = False
            Me.gcRead.OptionsFilter.AllowAutoFilter = False
            Me.gcRead.OptionsFilter.AllowFilter = False
            ' 
            ' repositoryItemImageComboBox4
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox4, "repositoryItemImageComboBox4")
            Me.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4"
            Me.repositoryItemImageComboBox4.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox4.Items"), (CType(resources.GetObject("repositoryItemImageComboBox4.Items1"), Object)), (CType(resources.GetObject("repositoryItemImageComboBox4.Items2"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox4.Items3"), (CType(resources.GetObject("repositoryItemImageComboBox4.Items4"), Object)), (CType(resources.GetObject("repositoryItemImageComboBox4.Items5"), Integer)))
            })
            Me.repositoryItemImageComboBox4.SmallImages = Me.icEditors
            ' 
            ' ilColumns
            ' 
            Me.ilColumns.ImageStream = (CType(resources.GetObject("ilColumns.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.ilColumns.TransparentColor = System.Drawing.Color.Transparent
            Me.ilColumns.Images.SetKeyName(0, "Importance.png")
            Me.ilColumns.Images.SetKeyName(1, "Icon.png")
            Me.ilColumns.Images.SetKeyName(2, "Attach.png")
            Me.ilColumns.Images.SetKeyName(3, "Whatched.png")
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcList, Me.lcMailView, Me.splitterItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1226, 621)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' lcList
            ' 
            resources.ApplyResources(Me.lcList, "lcList")
            Me.lcList.Control = Me.gridControl1
            Me.lcList.Location = New System.Drawing.Point(581, 0)
            Me.lcList.Name = "lcList"
            Me.lcList.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcList.Size = New System.Drawing.Size(633, 609)
            Me.lcList.TextSize = New System.Drawing.Size(0, 0)
            Me.lcList.TextVisible = False
            ' 
            ' lcMailView
            ' 
            resources.ApplyResources(Me.lcMailView, "lcMailView")
            Me.lcMailView.Control = Me.ucMailViewer1
            Me.lcMailView.Location = New System.Drawing.Point(0, 0)
            Me.lcMailView.Name = "lcMailView"
            Me.lcMailView.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcMailView.Size = New System.Drawing.Size(576, 609)
            Me.lcMailView.TextSize = New System.Drawing.Size(0, 0)
            Me.lcMailView.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.AllowHotTrack = True
            resources.ApplyResources(Me.splitterItem1, "splitterItem1")
            Me.splitterItem1.Location = New System.Drawing.Point(576, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(5, 609)
            ' 
            ' Mail
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Mail"
            '			Me.Load += New System.EventHandler(Me.Mail_Load)
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icEditors, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcMailView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private lcList As DevExpress.XtraLayout.LayoutControlItem
		Private ucMailViewer1 As ucMailViewer
		Private lcMailView As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private gcPriority As DevExpress.XtraGrid.Columns.GridColumn
		Private gcIcon As DevExpress.XtraGrid.Columns.GridColumn
		Private gcAttachment As DevExpress.XtraGrid.Columns.GridColumn
		Private gcSubject As DevExpress.XtraGrid.Columns.GridColumn
		Private gcFrom As DevExpress.XtraGrid.Columns.GridColumn
		Private gcDate As DevExpress.XtraGrid.Columns.GridColumn
		Private gcRead As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private icEditors As DevExpress.Utils.ImageCollection
		Private ilColumns As System.Windows.Forms.ImageList
		Protected Friend WithEvents gridView1 As MyGridView
	End Class
End Namespace
