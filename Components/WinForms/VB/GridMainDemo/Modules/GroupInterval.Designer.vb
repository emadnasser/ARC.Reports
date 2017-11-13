Namespace DevExpress.XtraGrid.Demos
	Partial Public Class GroupInterval
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(GroupInterval))
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.label3 = New System.Windows.Forms.Label()
			Me.icbeDrawMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label2 = New System.Windows.Forms.Label()
			Me.cbeInterval = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label1 = New System.Windows.Forms.Label()
			Me.icbeAllowFixedGroups = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.icbeDrawMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeInterval.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbeAllowFixedGroups.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.label3)
			Me.panelControl1.Controls.Add(Me.icbeDrawMode)
			Me.panelControl1.Controls.Add(Me.label2)
			Me.panelControl1.Controls.Add(Me.cbeInterval)
			Me.panelControl1.Controls.Add(Me.label1)
			Me.panelControl1.Controls.Add(Me.icbeAllowFixedGroups)
			resources.ApplyResources(Me.panelControl1, "panelControl1")
			Me.panelControl1.Name = "panelControl1"
			' 
			' label3
			' 
			resources.ApplyResources(Me.label3, "label3")
			Me.label3.Name = "label3"
			' 
			' icbeDrawMode
			' 
			resources.ApplyResources(Me.icbeDrawMode, "icbeDrawMode")
			Me.icbeDrawMode.Name = "icbeDrawMode"
			Me.icbeDrawMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("icbeDrawMode.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
'			Me.icbeDrawMode.SelectedIndexChanged += New System.EventHandler(Me.icbeDrawMode_SelectedIndexChanged)
			' 
			' label2
			' 
			resources.ApplyResources(Me.label2, "label2")
			Me.label2.Name = "label2"
			' 
			' cbeInterval
			' 
			resources.ApplyResources(Me.cbeInterval, "cbeInterval")
			Me.cbeInterval.Name = "cbeInterval"
			Me.cbeInterval.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("cbeInterval.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.cbeInterval.Properties.DropDownRows = 20
			Me.cbeInterval.Properties.Items.AddRange(New Object() { resources.GetString("cbeInterval.Properties.Items"), resources.GetString("cbeInterval.Properties.Items1"), resources.GetString("cbeInterval.Properties.Items2"), resources.GetString("cbeInterval.Properties.Items3"), resources.GetString("cbeInterval.Properties.Items4"), resources.GetString("cbeInterval.Properties.Items5"), resources.GetString("cbeInterval.Properties.Items6")})
			Me.cbeInterval.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
'			Me.cbeInterval.SelectedIndexChanged += New System.EventHandler(Me.cbeInterval_SelectedIndexChanged)
			' 
			' label1
			' 
			resources.ApplyResources(Me.label1, "label1")
			Me.label1.Name = "label1"
			' 
			' icbeAllowFixedGroups
			' 
			resources.ApplyResources(Me.icbeAllowFixedGroups, "icbeAllowFixedGroups")
			Me.icbeAllowFixedGroups.Name = "icbeAllowFixedGroups"
			Me.icbeAllowFixedGroups.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("icbeAllowFixedGroups.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.icbeAllowFixedGroups.Properties.DropDownRows = 20
'			Me.icbeAllowFixedGroups.SelectedIndexChanged += New System.EventHandler(Me.icbeAllowFixedGroups_SelectedIndexChanged)
			' 
			' gridControl1
			' 
			resources.ApplyResources(Me.gridControl1, "gridControl1")
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox1, Me.repositoryItemSpinEdit1, Me.repositoryItemSpinEdit2})
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem((CType(resources.GetObject("gridView1.GroupSummary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView1.GroupSummary1"), Nothing, resources.GetString("gridView1.GroupSummary2"))})
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True
			Me.gridView1.OptionsView.AllowCellMerge = True
			Me.gridView1.OptionsView.ShowGroupedColumns = True
'			Me.gridView1.GridMenuItemClick += New DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventHandler(Me.gridView1_GridMenuItemClick)
'			Me.gridView1.CustomDrawGroupRow += New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(Me.gridView1_CustomDrawGroupRow)
'			Me.gridView1.CellMerge += New DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(Me.gridView1_CellMerge)
'			Me.gridView1.CustomColumnGroup += New DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(Me.gridView1_CustomColumnGroup)
'			Me.gridView1.PopupMenuShowing += New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(Me.gridView1_PopupMenuShowing)
			' 
			' gridColumn1
			' 
			resources.ApplyResources(Me.gridColumn1, "gridColumn1")
			Me.gridColumn1.FieldName = "Product Name"
			Me.gridColumn1.Name = "gridColumn1"
			' 
			' gridColumn2
			' 
			resources.ApplyResources(Me.gridColumn2, "gridColumn2")
			Me.gridColumn2.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.gridColumn2.FieldName = "Category"
			Me.gridColumn2.Name = "gridColumn2"
			' 
			' repositoryItemImageComboBox1
			' 
			resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemImageComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items1"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items4"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items7"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items8"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items10"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items11"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items12"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items13"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items14"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items15"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items16"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items17"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items18"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items19"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items20"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items21"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items22"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items23")))))})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			Me.repositoryItemImageComboBox1.SmallImages = Me.imageList1
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
			Me.imageList1.Images.SetKeyName(6, "")
			Me.imageList1.Images.SetKeyName(7, "")
			' 
			' gridColumn3
			' 
			resources.ApplyResources(Me.gridColumn3, "gridColumn3")
			Me.gridColumn3.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.gridColumn3.DisplayFormat.FormatString = "c"
			Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn3.FieldName = "Unit Price"
			Me.gridColumn3.Name = "gridColumn3"
			' 
			' repositoryItemSpinEdit1
			' 
			resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask")
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' gridColumn4
			' 
			Me.gridColumn4.AppearanceCell.BackColor = (CType(resources.GetObject("gridColumn4.AppearanceCell.BackColor"), System.Drawing.Color))
			Me.gridColumn4.AppearanceCell.BackColor2 = (CType(resources.GetObject("gridColumn4.AppearanceCell.BackColor2"), System.Drawing.Color))
			Me.gridColumn4.AppearanceCell.ForeColor = (CType(resources.GetObject("gridColumn4.AppearanceCell.ForeColor"), System.Drawing.Color))
			Me.gridColumn4.AppearanceCell.GradientMode = (CType(resources.GetObject("gridColumn4.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
			Me.gridColumn4.AppearanceCell.Options.UseBackColor = True
			Me.gridColumn4.AppearanceCell.Options.UseForeColor = True
			resources.ApplyResources(Me.gridColumn4, "gridColumn4")
			Me.gridColumn4.DisplayFormat.FormatString = "c"
			Me.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn4.FieldName = "Order Sum"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.OptionsColumn.AllowEdit = False
			' 
			' gridColumn5
			' 
			resources.ApplyResources(Me.gridColumn5, "gridColumn5")
			Me.gridColumn5.FieldName = "Order Date"
			Me.gridColumn5.Name = "gridColumn5"
			' 
			' gridColumn6
			' 
			resources.ApplyResources(Me.gridColumn6, "gridColumn6")
			Me.gridColumn6.ColumnEdit = Me.repositoryItemSpinEdit2
			Me.gridColumn6.FieldName = "Count"
			Me.gridColumn6.Name = "gridColumn6"
			' 
			' repositoryItemSpinEdit2
			' 
			resources.ApplyResources(Me.repositoryItemSpinEdit2, "repositoryItemSpinEdit2")
			Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit2.IsFloatValue = False
			Me.repositoryItemSpinEdit2.Mask.EditMask = resources.GetString("repositoryItemSpinEdit2.Mask.EditMask")
			Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			resources.ApplyResources(Me.panelControl2, "panelControl2")
			Me.panelControl2.Name = "panelControl2"
			' 
			' GroupInterval
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "GroupInterval"
'			Me.Load += New System.EventHandler(Me.GroupInterval_Load)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.icbeDrawMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeInterval.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbeAllowFixedGroups.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private label1 As System.Windows.Forms.Label
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageList1 As System.Windows.Forms.ImageList
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private label2 As System.Windows.Forms.Label
		Private WithEvents cbeInterval As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents icbeDrawMode As DevExpress.XtraEditors.ImageComboBoxEdit
		Private components As System.ComponentModel.IContainer
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private label3 As System.Windows.Forms.Label
		Private WithEvents icbeAllowFixedGroups As DevExpress.XtraEditors.ImageComboBoxEdit

	End Class
End Namespace
