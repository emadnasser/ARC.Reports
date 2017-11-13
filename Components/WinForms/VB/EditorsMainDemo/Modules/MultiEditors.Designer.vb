Namespace DevExpress.XtraEditors.Demos
	Partial Public Class MultiEditors
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MultiEditors))
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
			Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4})
			Me.gridView1.FixedLineWidth = 1
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ShowGroupPanel = False
'			Me.gridView1.CustomRowCellEdit += New DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(Me.gridView1_CustomRowCellEdit)
'			Me.gridView1.CalcRowHeight += New DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(Me.gridView1_CalcRowHeight)
'			Me.gridView1.RowCellDefaultAlignment += New DevExpress.XtraGrid.Views.Base.RowCellAlignmentEventHandler(Me.gridView1_RowCellDefaultAlignment)
			' 
			' gridColumn1
			' 
			Me.gridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(212)))), (CInt((CByte(250)))))
			Me.gridColumn1.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb((CInt((CByte(194)))), (CInt((CByte(222)))), (CInt((CByte(255)))))
			Me.gridColumn1.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(64)))))
			Me.gridColumn1.AppearanceCell.Options.UseBackColor = True
			Me.gridColumn1.AppearanceCell.Options.UseForeColor = True
			Me.gridColumn1.Caption = "Category"
			Me.gridColumn1.FieldName = "Category"
			Me.gridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.OptionsColumn.AllowEdit = False
			Me.gridColumn1.OptionsColumn.AllowFocus = False
			Me.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumn1.OptionsColumn.AllowMove = False
			Me.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumn1.OptionsFilter.AllowFilter = False
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			Me.gridColumn1.Width = 120
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Product #1"
			Me.gridColumn2.FieldName = "Product1"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumn2.OptionsFilter.AllowFilter = False
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			Me.gridColumn2.Width = 140
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Product #2"
			Me.gridColumn3.FieldName = "Product2"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumn3.OptionsFilter.AllowFilter = False
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 2
			Me.gridColumn3.Width = 140
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Product #3"
			Me.gridColumn4.FieldName = "Product3"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumn4.OptionsFilter.AllowFilter = False
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 3
			Me.gridColumn4.Width = 145
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(5, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1, Me.repositoryItemCheckEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemDateEdit1, Me.repositoryItemComboBox1, Me.repositoryItemImageComboBox1, Me.repositoryItemProgressBar1, Me.repositoryItemTextEdit1, Me.repositoryItemPictureEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(575, 356)
			Me.gridControl1.TabIndex = 6
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AllowFocused = False
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.IsFloatValue = False
			Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AllowFocused = False
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Caption = "Check"
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' repositoryItemCalcEdit1
			' 
			Me.repositoryItemCalcEdit1.AllowFocused = False
			Me.repositoryItemCalcEdit1.AutoHeight = False
			Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCalcEdit1.DisplayFormat.FormatString = "c"
			Me.repositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
			' 
			' repositoryItemDateEdit1
			' 
			Me.repositoryItemDateEdit1.AllowFocused = False
			Me.repositoryItemDateEdit1.AutoHeight = False
			Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.AllowFocused = False
			Me.repositoryItemComboBox1.AutoHeight = False
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.Items.AddRange(New Object() { "Exotic Liquids", "Specialty Biscuits, Ltd.", "Leka Trading", "Tokyo Traders"})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AllowFocused = False
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Beverages", 1, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Condiments", 2, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Confections", 3, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Dairy Products", 4, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Grains/Cereals", 5, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Meat/Poultry", 6, 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Produce", 7, 6), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Seafood", 8, 7)})
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
			' repositoryItemProgressBar1
			' 
			Me.repositoryItemProgressBar1.EndColor = System.Drawing.Color.Khaki
			Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
			Me.repositoryItemProgressBar1.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
			Me.repositoryItemProgressBar1.ShowTitle = True
			Me.repositoryItemProgressBar1.StartColor = System.Drawing.Color.Chocolate
'			Me.repositoryItemProgressBar1.KeyPress += New System.Windows.Forms.KeyPressEventHandler(Me.repositoryItemProgressBar1_KeyPress)
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AllowFocused = False
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' MultiEditors
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "MultiEditors"
			Me.Size = New System.Drawing.Size(580, 361)
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private WithEvents repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
