Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class CustomDraw
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomDraw))
			Dim multiEditorRowProperties1 As New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Dim multiEditorRowProperties2 As New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.repositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
			Me.categoryRow4 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowTrademark = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowModel = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowCategory = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowHP = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowLiter = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowCyl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowTransmiss_Speed_Count = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowTransmiss_Automatic = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowMPG = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
			Me.categoryRow2 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowIcon = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowPicture = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowDescription = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowHyperlink = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow3 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowPrice = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowDelivery_Date = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowIs_In_Stock = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.imageList3 = New System.Windows.Forms.ImageList(Me.components)
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
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
			' repositoryItemImageEdit1
			' 
			Me.repositoryItemImageEdit1.AllowFocused = False
			Me.repositoryItemImageEdit1.AutoHeight = False
			Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
			' 
			' repositoryItemCalcEdit1
			' 
			Me.repositoryItemCalcEdit1.AllowFocused = False
			Me.repositoryItemCalcEdit1.AutoHeight = False
			Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AllowFocused = False
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sports", "SPORTS", 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Saloon", "SALOON", 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Truck", "TRUCK", 4)})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			Me.repositoryItemImageComboBox1.SmallImages = Me.imageList2
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			Me.imageList2.Images.SetKeyName(3, "")
			Me.imageList2.Images.SetKeyName(4, "")
			' 
			' repositoryItemImageComboBox2
			' 
			Me.repositoryItemImageComboBox2.AllowFocused = False
			Me.repositoryItemImageComboBox2.AutoHeight = False
			Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yes", "Yes", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("No", "No", 1)})
			Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
			Me.repositoryItemImageComboBox2.SmallImages = Me.imageList2
			' 
			' repositoryItemMemoEdit1
			' 
			Me.repositoryItemMemoEdit1.AllowFocused = False
			Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
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
			' vGridControl1
			' 
			Me.vGridControl1.Appearance.BandBorder.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(169)))), (CInt((CByte(169)))), (CInt((CByte(169)))))
			Me.vGridControl1.Appearance.BandBorder.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.vGridControl1.Appearance.BandBorder.Options.UseBackColor = True
			Me.vGridControl1.Appearance.BandBorder.Options.UseForeColor = True
			Me.vGridControl1.Appearance.Category.BackColor = System.Drawing.Color.SlateGray
			Me.vGridControl1.Appearance.Category.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.vGridControl1.Appearance.Category.ForeColor = System.Drawing.Color.White
			Me.vGridControl1.Appearance.Category.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
			Me.vGridControl1.Appearance.Category.Options.UseBackColor = True
			Me.vGridControl1.Appearance.Category.Options.UseFont = True
			Me.vGridControl1.Appearance.Category.Options.UseForeColor = True
			Me.vGridControl1.Appearance.CategoryExpandButton.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(253)))), (CInt((CByte(244)))), (CInt((CByte(227)))))
			Me.vGridControl1.Appearance.CategoryExpandButton.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.vGridControl1.Appearance.CategoryExpandButton.Options.UseBackColor = True
			Me.vGridControl1.Appearance.CategoryExpandButton.Options.UseForeColor = True
			Me.vGridControl1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(224)))), (CInt((CByte(224)))), (CInt((CByte(224)))))
			Me.vGridControl1.Appearance.Empty.BackColor2 = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(224)))), (CInt((CByte(192)))))
			Me.vGridControl1.Appearance.Empty.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.vGridControl1.Appearance.Empty.Options.UseBackColor = True
			Me.vGridControl1.Appearance.Empty.Options.UseForeColor = True
			Me.vGridControl1.Appearance.ExpandButton.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.vGridControl1.Appearance.ExpandButton.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.vGridControl1.Appearance.ExpandButton.Options.UseBackColor = True
			Me.vGridControl1.Appearance.ExpandButton.Options.UseForeColor = True
			Me.vGridControl1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Linen
			Me.vGridControl1.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Bisque
			Me.vGridControl1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.vGridControl1.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
			Me.vGridControl1.Appearance.FocusedCell.Options.UseBackColor = True
			Me.vGridControl1.Appearance.FocusedCell.Options.UseForeColor = True
			Me.vGridControl1.Appearance.FocusedRecord.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(229)))), (CInt((CByte(225)))), (CInt((CByte(216)))))
			Me.vGridControl1.Appearance.FocusedRecord.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.vGridControl1.Appearance.FocusedRecord.Options.UseBackColor = True
			Me.vGridControl1.Appearance.FocusedRecord.Options.UseForeColor = True
			Me.vGridControl1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(64)))), (CInt((CByte(64)))))
			Me.vGridControl1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.vGridControl1.Appearance.FocusedRow.Options.UseBackColor = True
			Me.vGridControl1.Appearance.FocusedRow.Options.UseForeColor = True
			Me.vGridControl1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
			Me.vGridControl1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(208)))), (CInt((CByte(200)))))
			Me.vGridControl1.Appearance.HideSelectionRow.Options.UseBackColor = True
			Me.vGridControl1.Appearance.HideSelectionRow.Options.UseForeColor = True
			Me.vGridControl1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(213)))), (CInt((CByte(204)))), (CInt((CByte(187)))))
			Me.vGridControl1.Appearance.HorzLine.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(162)))), (CInt((CByte(141)))), (CInt((CByte(104)))))
			Me.vGridControl1.Appearance.HorzLine.Options.UseBackColor = True
			Me.vGridControl1.Appearance.HorzLine.Options.UseForeColor = True
			Me.vGridControl1.Appearance.PressedRow.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
			Me.vGridControl1.Appearance.PressedRow.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.vGridControl1.Appearance.PressedRow.Options.UseBackColor = True
			Me.vGridControl1.Appearance.PressedRow.Options.UseForeColor = True
			Me.vGridControl1.Appearance.RecordValue.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(234)))), (CInt((CByte(230)))), (CInt((CByte(221)))))
			Me.vGridControl1.Appearance.RecordValue.BackColor2 = System.Drawing.Color.FromArgb((CInt((CByte(247)))), (CInt((CByte(245)))), (CInt((CByte(242)))))
			Me.vGridControl1.Appearance.RecordValue.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.vGridControl1.Appearance.RecordValue.Options.UseBackColor = True
			Me.vGridControl1.Appearance.RecordValue.Options.UseForeColor = True
			Me.vGridControl1.Appearance.RowHeaderPanel.BackColor = System.Drawing.Color.Linen
			Me.vGridControl1.Appearance.RowHeaderPanel.BackColor2 = System.Drawing.Color.Bisque
			Me.vGridControl1.Appearance.RowHeaderPanel.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.vGridControl1.Appearance.RowHeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
			Me.vGridControl1.Appearance.RowHeaderPanel.Options.UseBackColor = True
			Me.vGridControl1.Appearance.RowHeaderPanel.Options.UseForeColor = True
			Me.vGridControl1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(213)))), (CInt((CByte(204)))), (CInt((CByte(187)))))
			Me.vGridControl1.Appearance.VertLine.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(162)))), (CInt((CByte(141)))), (CInt((CByte(104)))))
			Me.vGridControl1.Appearance.VertLine.Options.UseBackColor = True
			Me.vGridControl1.Appearance.VertLine.Options.UseForeColor = True
			Me.vGridControl1.BackgroundImage = (CType(resources.GetObject("vGridControl1.BackgroundImage"), System.Drawing.Image))
			Me.vGridControl1.BandsInterval = 5
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.ImageList = Me.imageList1
			Me.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
			Me.vGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.RecordWidth = 120
			Me.vGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageEdit1, Me.repositoryItemPictureEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemMemoEdit1, Me.repositoryItemHyperLinkEdit1})
			Me.vGridControl1.RowHeaderWidth = 185
			Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.categoryRow4, Me.categoryRow1, Me.categoryRow2, Me.categoryRow3})
			Me.vGridControl1.Size = New System.Drawing.Size(597, 369)
			Me.vGridControl1.TabIndex = 4
'			Me.vGridControl1.FocusedRowChanged += New DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventHandler(Me.vGridControl1_FocusedRowChanged)
'			Me.vGridControl1.CustomDrawTreeButton += New DevExpress.XtraVerticalGrid.Events.CustomDrawTreeButtonEventHandler(Me.vGridControl1_CustomDrawTreeButton)
'			Me.vGridControl1.CustomDrawSeparator += New DevExpress.XtraVerticalGrid.Events.CustomDrawSeparatorEventHandler(Me.vGridControl1_CustomDrawSeparator)
'			Me.vGridControl1.CustomDrawRowHeaderIndent += New DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderIndentEventHandler(Me.vGridControl1_CustomDrawRowHeaderIndent)
'			Me.vGridControl1.CustomDrawRowValueCell += New DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventHandler(Me.vGridControl1_CustomDrawRowValueCell)
'			Me.vGridControl1.CustomDrawRowHeaderCell += New DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventHandler(Me.vGridControl1_CustomDrawRowHeaderCell)
			' 
			' repositoryItemHyperLinkEdit1
			' 
			Me.repositoryItemHyperLinkEdit1.AutoHeight = False
			Me.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1"
			' 
			' categoryRow4
			' 
			Me.categoryRow4.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowID, Me.rowTrademark, Me.rowModel, Me.rowCategory})
			Me.categoryRow4.Name = "categoryRow4"
			Me.categoryRow4.Properties.Caption = "Main Info"
			' 
			' rowID
			' 
			Me.rowID.Name = "rowID"
			Me.rowID.Properties.Caption = "Record ID"
			Me.rowID.Properties.FieldName = "ID"
			Me.rowID.Properties.ImageIndex = 0
			' 
			' rowTrademark
			' 
			Me.rowTrademark.Name = "rowTrademark"
			Me.rowTrademark.Properties.Caption = "Trademark"
			Me.rowTrademark.Properties.FieldName = "Trademark"
			' 
			' rowModel
			' 
			Me.rowModel.Name = "rowModel"
			Me.rowModel.Properties.Caption = "Model"
			Me.rowModel.Properties.FieldName = "Model"
			' 
			' rowCategory
			' 
			Me.rowCategory.Name = "rowCategory"
			Me.rowCategory.Properties.Caption = "Category"
			Me.rowCategory.Properties.FieldName = "Category"
			Me.rowCategory.Properties.RowEdit = Me.repositoryItemImageComboBox1
			' 
			' categoryRow1
			' 
			Me.categoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowHP, Me.rowLiter, Me.rowCyl, Me.rowTransmiss_Speed_Count, Me.rowTransmiss_Automatic, Me.rowMPG})
			Me.categoryRow1.Name = "categoryRow1"
			Me.categoryRow1.Properties.Caption = "Performance Attributes"
			' 
			' rowHP
			' 
			Me.rowHP.Name = "rowHP"
			Me.rowHP.Properties.Caption = "HP"
			Me.rowHP.Properties.FieldName = "HP"
			' 
			' rowLiter
			' 
			Me.rowLiter.Name = "rowLiter"
			Me.rowLiter.Properties.Caption = "Capacity"
			Me.rowLiter.Properties.FieldName = "Liter"
			Me.rowLiter.Properties.Format.FormatString = "#.### Liters"
			Me.rowLiter.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' rowCyl
			' 
			Me.rowCyl.Name = "rowCyl"
			Me.rowCyl.Properties.Caption = "Cyl"
			Me.rowCyl.Properties.FieldName = "Cyl"
			Me.rowCyl.Properties.RowEdit = Me.repositoryItemSpinEdit1
			' 
			' rowTransmiss_Speed_Count
			' 
			Me.rowTransmiss_Speed_Count.Name = "rowTransmiss_Speed_Count"
			Me.rowTransmiss_Speed_Count.Properties.Caption = "# of Gears"
			Me.rowTransmiss_Speed_Count.Properties.FieldName = "Transmiss Speed Count"
			Me.rowTransmiss_Speed_Count.Properties.RowEdit = Me.repositoryItemSpinEdit1
			' 
			' rowTransmiss_Automatic
			' 
			Me.rowTransmiss_Automatic.Name = "rowTransmiss_Automatic"
			Me.rowTransmiss_Automatic.Properties.Caption = "Automatic Transmission"
			Me.rowTransmiss_Automatic.Properties.FieldName = "Transmiss Automatic"
			Me.rowTransmiss_Automatic.Properties.ImageIndex = 2
			Me.rowTransmiss_Automatic.Properties.RowEdit = Me.repositoryItemImageComboBox2
			' 
			' rowMPG
			' 
			Me.rowMPG.Name = "rowMPG"
			multiEditorRowProperties1.Caption = "MPG City"
			multiEditorRowProperties1.FieldName = "MPG City"
			multiEditorRowProperties1.RowEdit = Me.repositoryItemSpinEdit1
			multiEditorRowProperties1.Width = 17
			multiEditorRowProperties2.Caption = "MPG Highway"
			multiEditorRowProperties2.FieldName = "MPG Highway"
			multiEditorRowProperties2.RowEdit = Me.repositoryItemSpinEdit1
			multiEditorRowProperties2.Width = 23
			Me.rowMPG.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() { multiEditorRowProperties1, multiEditorRowProperties2})
			Me.rowMPG.SeparatorKind = DevExpress.XtraVerticalGrid.Rows.SeparatorKind.String
			Me.rowMPG.SeparatorString = "/"
			' 
			' categoryRow2
			' 
			Me.categoryRow2.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowIcon, Me.rowPicture, Me.rowDescription, Me.rowHyperlink})
			Me.categoryRow2.Name = "categoryRow2"
			Me.categoryRow2.Properties.Caption = "Notes"
			Me.categoryRow2.Properties.ImageIndex = 3
			' 
			' rowIcon
			' 
			Me.rowIcon.Height = 60
			Me.rowIcon.Name = "rowIcon"
			Me.rowIcon.Properties.Caption = "Icon"
			Me.rowIcon.Properties.FieldName = "Icon"
			Me.rowIcon.Properties.ImageIndex = 4
			Me.rowIcon.Properties.RowEdit = Me.repositoryItemPictureEdit1
			' 
			' rowPicture
			' 
			Me.rowPicture.Name = "rowPicture"
			Me.rowPicture.Properties.Caption = "Picture"
			Me.rowPicture.Properties.FieldName = "Picture"
			Me.rowPicture.Properties.RowEdit = Me.repositoryItemImageEdit1
			' 
			' rowDescription
			' 
			Me.rowDescription.Height = 317
			Me.rowDescription.Name = "rowDescription"
			Me.rowDescription.Properties.Caption = "Description"
			Me.rowDescription.Properties.FieldName = "Description"
			Me.rowDescription.Properties.RowEdit = Me.repositoryItemMemoEdit1
			' 
			' rowHyperlink
			' 
			Me.rowHyperlink.Name = "rowHyperlink"
			Me.rowHyperlink.Properties.Caption = "Hyperlink"
			Me.rowHyperlink.Properties.FieldName = "Hyperlink"
			Me.rowHyperlink.Properties.ImageIndex = 1
			Me.rowHyperlink.Properties.RowEdit = Me.repositoryItemHyperLinkEdit1
			' 
			' categoryRow3
			' 
			Me.categoryRow3.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowPrice, Me.rowDelivery_Date, Me.rowIs_In_Stock})
			Me.categoryRow3.Name = "categoryRow3"
			Me.categoryRow3.Properties.Caption = "Others"
			' 
			' rowPrice
			' 
			Me.rowPrice.Name = "rowPrice"
			Me.rowPrice.Properties.Caption = "Price"
			Me.rowPrice.Properties.FieldName = "Price"
			Me.rowPrice.Properties.Format.FormatString = "c"
			Me.rowPrice.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.rowPrice.Properties.RowEdit = Me.repositoryItemCalcEdit1
			' 
			' rowDelivery_Date
			' 
			Me.rowDelivery_Date.Name = "rowDelivery_Date"
			Me.rowDelivery_Date.Properties.Caption = "Delivery Date"
			Me.rowDelivery_Date.Properties.FieldName = "Delivery Date"
			' 
			' rowIs_In_Stock
			' 
			Me.rowIs_In_Stock.Name = "rowIs_In_Stock"
			Me.rowIs_In_Stock.Properties.Caption = "In Stock?"
			Me.rowIs_In_Stock.Properties.FieldName = "Is In Stock"
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AllowFocused = False
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' imageList3
			' 
			Me.imageList3.ImageStream = (CType(resources.GetObject("imageList3.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList3.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList3.Images.SetKeyName(0, "")
			Me.imageList3.Images.SetKeyName(1, "")
			Me.imageList3.Images.SetKeyName(2, "")
			Me.imageList3.Images.SetKeyName(3, "")
			Me.imageList3.Images.SetKeyName(4, "")
			Me.imageList3.Images.SetKeyName(5, "")
			Me.imageList3.Images.SetKeyName(6, "")
			Me.imageList3.Images.SetKeyName(7, "")
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.MaxItemId = 0
			' 
			' CustomDraw
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "CustomDraw"
			Me.Size = New System.Drawing.Size(597, 369)
'			Me.Load += New System.EventHandler(Me.CustomDraw_Load)
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageList2 As System.Windows.Forms.ImageList
		Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private categoryRow4 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowID As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTrademark As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowModel As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCategory As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowHP As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowLiter As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCyl As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTransmiss_Speed_Count As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTransmiss_Automatic As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowMPG As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
		Private categoryRow2 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowPicture As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowIcon As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowDescription As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowHyperlink As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow3 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowPrice As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowDelivery_Date As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowIs_In_Stock As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private imageList3 As System.Windows.Forms.ImageList
		Private repositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
