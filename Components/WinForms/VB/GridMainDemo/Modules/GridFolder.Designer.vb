Namespace DevExpress.XtraGrid.Demos
	Partial Public Class GridFolder
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(GridFolder))
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumnImage = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.gridColumnName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumnSize = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumnModified = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumnType = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.panelDrives = New DevExpress.XtraEditors.PanelControl()
			Me.comboBoxDrives = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelSelectDrive = New System.Windows.Forms.Label()
			Me.labelCurrentPath = New System.Windows.Forms.Label()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelDrives, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelDrives.SuspendLayout()
			CType(Me.comboBoxDrives.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl2
			' 
			resources.ApplyResources(Me.gridControl2, "gridControl2")
			Me.gridControl2.MainView = Me.gridView1
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox1})
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Appearance.EvenRow.BackColor = (CType(resources.GetObject("gridView1.Appearance.EvenRow.BackColor"), System.Drawing.Color))
			Me.gridView1.Appearance.EvenRow.Options.UseBackColor = True
			Me.gridView1.Appearance.FooterPanel.Font = (CType(resources.GetObject("gridView1.Appearance.FooterPanel.Font"), System.Drawing.Font))
			Me.gridView1.Appearance.FooterPanel.Options.UseFont = True
			Me.gridView1.Appearance.HeaderPanel.Font = (CType(resources.GetObject("gridView1.Appearance.HeaderPanel.Font"), System.Drawing.Font))
			Me.gridView1.Appearance.HeaderPanel.Options.UseFont = True
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumnImage, Me.gridColumnName, Me.gridColumnSize, Me.gridColumnModified, Me.gridColumnType})
			Me.gridView1.GridControl = Me.gridControl2
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.AllowIncrementalSearch = True
			Me.gridView1.OptionsBehavior.Editable = False
			Me.gridView1.OptionsMenu.EnableFooterMenu = False
			Me.gridView1.OptionsMenu.EnableGroupPanelMenu = False
			Me.gridView1.OptionsView.AutoCalcPreviewLineCount = True
			Me.gridView1.OptionsView.ShowFooter = True
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.OptionsView.ShowIndicator = False
			Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumnName, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.gridView1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.gridView1_KeyDown)
'			Me.gridView1.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.gridView1_CustomDrawCell)
'			Me.gridView1.CustomColumnSort += New DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(Me.gridView1_CustomColumnSort)
'			Me.gridView1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.gridView1_MouseDown)
'			Me.gridView1.CalcPreviewText += New DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventHandler(Me.gridView1_CalcPreviewText)
			' 
			' gridColumnImage
			' 
			Me.gridColumnImage.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.gridColumnImage.FieldName = "ImageIndex"
			Me.gridColumnImage.Name = "gridColumnImage"
			Me.gridColumnImage.OptionsColumn.AllowFocus = False
			Me.gridColumnImage.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumnImage.OptionsColumn.AllowMove = False
			Me.gridColumnImage.OptionsColumn.AllowSize = False
			Me.gridColumnImage.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumnImage.OptionsColumn.FixedWidth = True
			Me.gridColumnImage.OptionsColumn.ShowInCustomizationForm = False
			Me.gridColumnImage.OptionsFilter.AllowFilter = False
			resources.ApplyResources(Me.gridColumnImage, "gridColumnImage")
			' 
			' repositoryItemImageComboBox1
			' 
			resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
			Me.repositoryItemImageComboBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemImageComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemImageComboBox1.CaseSensitiveSearch = True
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items1"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items4"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items5")))))})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			Me.repositoryItemImageComboBox1.SmallImages = Me.imageList1
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			' 
			' gridColumnName
			' 
			resources.ApplyResources(Me.gridColumnName, "gridColumnName")
			Me.gridColumnName.FieldName = "Name"
			Me.gridColumnName.Name = "gridColumnName"
			Me.gridColumnName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumnName.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
			Me.gridColumnName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((CType(resources.GetObject("gridColumnName.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridColumnName.Summary1"), resources.GetString("gridColumnName.Summary2"))})
			' 
			' gridColumnSize
			' 
			resources.ApplyResources(Me.gridColumnSize, "gridColumnSize")
			Me.gridColumnSize.FieldName = "Size"
			Me.gridColumnSize.Name = "gridColumnSize"
			Me.gridColumnSize.OptionsColumn.AllowFocus = False
			Me.gridColumnSize.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumnSize.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
			' 
			' gridColumnModified
			' 
			resources.ApplyResources(Me.gridColumnModified, "gridColumnModified")
			Me.gridColumnModified.FieldName = "Modified"
			Me.gridColumnModified.Name = "gridColumnModified"
			Me.gridColumnModified.OptionsColumn.AllowFocus = False
			Me.gridColumnModified.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumnModified.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
			' 
			' gridColumnType
			' 
			resources.ApplyResources(Me.gridColumnType, "gridColumnType")
			Me.gridColumnType.FieldName = "ItemType"
			Me.gridColumnType.Name = "gridColumnType"
			Me.gridColumnType.OptionsColumn.ShowInCustomizationForm = False
			' 
			' panelDrives
			' 
			Me.panelDrives.Controls.Add(Me.comboBoxDrives)
			Me.panelDrives.Controls.Add(Me.labelSelectDrive)
			Me.panelDrives.Controls.Add(Me.labelCurrentPath)
			resources.ApplyResources(Me.panelDrives, "panelDrives")
			Me.panelDrives.Name = "panelDrives"
			' 
			' comboBoxDrives
			' 
			resources.ApplyResources(Me.comboBoxDrives, "comboBoxDrives")
			Me.comboBoxDrives.Name = "comboBoxDrives"
			Me.comboBoxDrives.Properties.Appearance.Font = (CType(resources.GetObject("comboBoxDrives.Properties.Appearance.Font"), System.Drawing.Font))
			Me.comboBoxDrives.Properties.Appearance.Options.UseFont = True
			Me.comboBoxDrives.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("comboBoxDrives.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.comboBoxDrives.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			' 
			' labelSelectDrive
			' 
			resources.ApplyResources(Me.labelSelectDrive, "labelSelectDrive")
			Me.labelSelectDrive.Name = "labelSelectDrive"
			' 
			' labelCurrentPath
			' 
			resources.ApplyResources(Me.labelCurrentPath, "labelCurrentPath")
			Me.labelCurrentPath.Name = "labelCurrentPath"
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			resources.ApplyResources(Me.panelControl1, "panelControl1")
			Me.panelControl1.Name = "panelControl1"
			' 
			' GridFolder
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panelDrives)
			Me.Name = "GridFolder"
'			Me.Load += New System.EventHandler(Me.GridFolder_Load)
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelDrives, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelDrives.ResumeLayout(False)
			Me.panelDrives.PerformLayout()
			CType(Me.comboBoxDrives.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumnImage As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnName As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private gridColumnSize As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnModified As DevExpress.XtraGrid.Columns.GridColumn
		Private comboBoxDrives As DevExpress.XtraEditors.ComboBoxEdit
		Private labelSelectDrive As System.Windows.Forms.Label
		Private panelDrives As DevExpress.XtraEditors.PanelControl
		Private labelCurrentPath As System.Windows.Forms.Label
		Private gridColumnType As DevExpress.XtraGrid.Columns.GridColumn
		Private imageList1 As System.Windows.Forms.ImageList
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
