Namespace DevExpress.XtraGrid.Demos
	Partial Public Class GridInstantFeedbackUI
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(GridInstantFeedbackUI))
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.xpAsyncServerModeSource1 = New DevExpress.Xpo.XPInstantFeedbackSource(Me.components)
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFrom = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSent = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSize = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colHasAttachment = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.colExpression = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.ilColumns = New System.Windows.Forms.ImageList(Me.components)
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.icbAnimation = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.sbShowSQLConnection = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciWaitAnimationOptions = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.icbAnimation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciWaitAnimationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.xpAsyncServerModeSource1
			resources.ApplyResources(Me.gridControl1, "gridControl1")
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox1, Me.repositoryItemCheckEdit1})
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' xpAsyncServerModeSource1
			' 
			Me.xpAsyncServerModeSource1.ObjectType = GetType(DevExpress.XtraGrid.Demos.ServerSideGridTest)
'			Me.xpAsyncServerModeSource1.ResolveSession += New System.EventHandler(Of DevExpress.Xpo.ResolveSessionEventArgs)(Me.xpAsyncServerModeSource1_ResolveSession)
'			Me.xpAsyncServerModeSource1.DismissSession += New System.EventHandler(Of DevExpress.Xpo.ResolveSessionEventArgs)(Me.xpAsyncServerModeSource1_DismissSession)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOid, Me.colSubject, Me.colFrom, Me.colSent, Me.colSize, Me.colHasAttachment, Me.colPriority, Me.colExpression})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem((CType(resources.GetObject("gridView1.GroupSummary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView1.GroupSummary1"), (CType(resources.GetObject("gridView1.GroupSummary2"), DevExpress.XtraGrid.Columns.GridColumn)), resources.GetString("gridView1.GroupSummary3")), New DevExpress.XtraGrid.GridGroupSummaryItem((CType(resources.GetObject("gridView1.GroupSummary4"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView1.GroupSummary5"), (CType(resources.GetObject("gridView1.GroupSummary6"), DevExpress.XtraGrid.Columns.GridColumn)), resources.GetString("gridView1.GroupSummary7"))})
			Me.gridView1.Images = Me.ilColumns
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ShowFooter = True
'			Me.gridView1.CustomColumnDisplayText += New DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(Me.gridView1_CustomColumnDisplayText)
			' 
			' colOid
			' 
			resources.ApplyResources(Me.colOid, "colOid")
			Me.colOid.FieldName = "Oid"
			Me.colOid.Name = "colOid"
			Me.colOid.OptionsColumn.ReadOnly = True
			Me.colOid.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((CType(resources.GetObject("colOid.Summary"), DevExpress.Data.SummaryItemType)))})
			' 
			' colSubject
			' 
			resources.ApplyResources(Me.colSubject, "colSubject")
			Me.colSubject.FieldName = "Subject"
			Me.colSubject.Name = "colSubject"
			' 
			' colFrom
			' 
			resources.ApplyResources(Me.colFrom, "colFrom")
			Me.colFrom.FieldName = "From"
			Me.colFrom.Name = "colFrom"
			' 
			' colSent
			' 
			resources.ApplyResources(Me.colSent, "colSent")
			Me.colSent.FieldName = "Sent"
			Me.colSent.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth
			Me.colSent.Name = "colSent"
			' 
			' colSize
			' 
			resources.ApplyResources(Me.colSize, "colSize")
			Me.colSize.DisplayFormat.FormatString = "{0:n0} KB"
			Me.colSize.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colSize.FieldName = "Size"
			Me.colSize.Name = "colSize"
			Me.colSize.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((CType(resources.GetObject("colSize.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("colSize.Summary1"), resources.GetString("colSize.Summary2"))})
			' 
			' colHasAttachment
			' 
			resources.ApplyResources(Me.colHasAttachment, "colHasAttachment")
			Me.colHasAttachment.ColumnEdit = Me.repositoryItemCheckEdit1
			Me.colHasAttachment.FieldName = "HasAttachment"
			Me.colHasAttachment.Name = "colHasAttachment"
			Me.colHasAttachment.OptionsColumn.AllowSize = False
			Me.colHasAttachment.OptionsColumn.ShowCaption = False
			' 
			' repositoryItemCheckEdit1
			' 
			resources.ApplyResources(Me.repositoryItemCheckEdit1, "repositoryItemCheckEdit1")
			Me.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
			Me.repositoryItemCheckEdit1.ImageIndexChecked = 4
			Me.repositoryItemCheckEdit1.Images = Me.imageList1
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			Me.repositoryItemCheckEdit1.ReadOnly = True
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			' 
			' colPriority
			' 
			resources.ApplyResources(Me.colPriority, "colPriority")
			Me.colPriority.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.colPriority.FieldName = "Priority"
			Me.colPriority.Name = "colPriority"
			Me.colPriority.OptionsColumn.AllowSize = False
			Me.colPriority.OptionsColumn.ShowCaption = False
			Me.colPriority.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			' 
			' repositoryItemImageComboBox1
			' 
			resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items1"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items4"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items7"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items8")))))})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			Me.repositoryItemImageComboBox1.SmallImages = Me.imageList1
			' 
			' colExpression
			' 
			resources.ApplyResources(Me.colExpression, "colExpression")
			Me.colExpression.FieldName = "Expression"
			Me.colExpression.Name = "colExpression"
			Me.colExpression.ShowUnboundExpressionMenu = True
			Me.colExpression.UnboundExpression = "DateDiffMinute([Sent], Now())"
			Me.colExpression.UnboundType = DevExpress.Data.UnboundColumnType.Integer
			' 
			' ilColumns
			' 
			Me.ilColumns.ImageStream = (CType(resources.GetObject("ilColumns.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.ilColumns.TransparentColor = System.Drawing.Color.Transparent
			Me.ilColumns.Images.SetKeyName(0, "Importance.png")
			Me.ilColumns.Images.SetKeyName(1, "Attach.png")
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.panelControl1)
			Me.layoutControl1.Controls.Add(Me.sbShowSQLConnection)
			Me.layoutControl1.Controls.Add(Me.gridControl1)
			resources.ApplyResources(Me.layoutControl1, "layoutControl1")
			Me.layoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem5})
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Controls.Add(Me.icbAnimation)
			resources.ApplyResources(Me.panelControl1, "panelControl1")
			Me.panelControl1.Name = "panelControl1"
			' 
			' labelControl1
			' 
			resources.ApplyResources(Me.labelControl1, "labelControl1")
			Me.labelControl1.Name = "labelControl1"
			' 
			' icbAnimation
			' 
			resources.ApplyResources(Me.icbAnimation, "icbAnimation")
			Me.icbAnimation.Name = "icbAnimation"
			Me.icbAnimation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("icbAnimation.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
'			Me.icbAnimation.SelectedIndexChanged += New System.EventHandler(Me.icbAnimation_SelectedIndexChanged)
			' 
			' sbShowSQLConnection
			' 
			resources.ApplyResources(Me.sbShowSQLConnection, "sbShowSQLConnection")
			Me.sbShowSQLConnection.Name = "sbShowSQLConnection"
			Me.sbShowSQLConnection.StyleController = Me.layoutControl1
'			Me.sbShowSQLConnection.Click += New System.EventHandler(Me.sbShowSQLConnection_Click)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.sbShowSQLConnection
			resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 436)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem5.Size = New System.Drawing.Size(119, 33)
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlGroup1
			' 
			resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.lciWaitAnimationOptions, Me.emptySpaceItem1})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(792, 577)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.gridControl1
			resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 46)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem1.Size = New System.Drawing.Size(792, 531)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' lciWaitAnimationOptions
			' 
			Me.lciWaitAnimationOptions.Control = Me.panelControl1
			resources.ApplyResources(Me.lciWaitAnimationOptions, "lciWaitAnimationOptions")
			Me.lciWaitAnimationOptions.Location = New System.Drawing.Point(0, 0)
			Me.lciWaitAnimationOptions.MaxSize = New System.Drawing.Size(0, 38)
			Me.lciWaitAnimationOptions.MinSize = New System.Drawing.Size(100, 38)
			Me.lciWaitAnimationOptions.Name = "lciWaitAnimationOptions"
			Me.lciWaitAnimationOptions.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lciWaitAnimationOptions.Size = New System.Drawing.Size(792, 38)
			Me.lciWaitAnimationOptions.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciWaitAnimationOptions.TextSize = New System.Drawing.Size(0, 0)
			Me.lciWaitAnimationOptions.TextToControlDistance = 0
			Me.lciWaitAnimationOptions.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 38)
			Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 8)
			Me.emptySpaceItem1.MinSize = New System.Drawing.Size(104, 8)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(792, 8)
			Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' GridInstantFeedbackUI
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "GridInstantFeedbackUI"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.icbAnimation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciWaitAnimationOptions, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colOid As DevExpress.XtraGrid.Columns.GridColumn
		Private colSubject As DevExpress.XtraGrid.Columns.GridColumn
		Private colFrom As DevExpress.XtraGrid.Columns.GridColumn
		Private colSent As DevExpress.XtraGrid.Columns.GridColumn
		Private colSize As DevExpress.XtraGrid.Columns.GridColumn
		Private colHasAttachment As DevExpress.XtraGrid.Columns.GridColumn
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents sbShowSQLConnection As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents xpAsyncServerModeSource1 As DevExpress.Xpo.XPInstantFeedbackSource
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private lciWaitAnimationOptions As DevExpress.XtraLayout.LayoutControlItem
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbAnimation As DevExpress.XtraEditors.ImageComboBoxEdit
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private colPriority As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageList1 As System.Windows.Forms.ImageList
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private colExpression As DevExpress.XtraGrid.Columns.GridColumn
		Private ilColumns As System.Windows.Forms.ImageList
	End Class
End Namespace

