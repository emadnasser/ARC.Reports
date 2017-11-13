Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class Editors
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editors))
			Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
			Me.tabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.rowPrice = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.categoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowHP = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.rowLiter = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowCyl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.rowTransmiss_Speed_Count = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.rowTransmiss_Automatic = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.rowDescription = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
			Me.rowIs_In_Stock = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.rowHyperlink = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.repositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
			Me.rowID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow3 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowDelivery_Date = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.categoryRow4 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowTrademark = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowModel = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowCategory = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
			Me.rowPicture = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowIcon = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow2 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			CType(Me.tabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitter1
			' 
			Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
			Me.splitter1.Location = New System.Drawing.Point(294, 4)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(8, 514)
			Me.splitter1.TabIndex = 11
			Me.splitter1.TabStop = False
			' 
			' tabControl1
			' 
			Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.tabControl1.Location = New System.Drawing.Point(302, 4)
			Me.tabControl1.Name = "tabControl1"
			Me.tabControl1.Size = New System.Drawing.Size(308, 514)
			Me.tabControl1.TabIndex = 10
'			Me.tabControl1.SelectedPageChanged += New DevExpress.XtraTab.TabPageChangedEventHandler(Me.tabControl1_SelectedPageChanged);
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
			' repositoryItemCalcEdit1
			' 
			Me.repositoryItemCalcEdit1.AllowFocused = False
			Me.repositoryItemCalcEdit1.AutoHeight = False
			Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' categoryRow1
			' 
			Me.categoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowHP, Me.rowLiter, Me.rowCyl, Me.rowTransmiss_Speed_Count, Me.rowTransmiss_Automatic})
			Me.categoryRow1.Name = "categoryRow1"
			Me.categoryRow1.Properties.Caption = "Performance Attributes"
			' 
			' rowHP
			' 
			Me.rowHP.Name = "rowHP"
			Me.rowHP.Properties.Caption = "HP"
			Me.rowHP.Properties.FieldName = "HP"
			Me.rowHP.Properties.RowEdit = Me.repositoryItemTextEdit1
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AllowFocused = False
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' rowLiter
			' 
			Me.rowLiter.Name = "rowLiter"
			Me.rowLiter.Properties.Caption = "Capacity"
			Me.rowLiter.Properties.FieldName = "Liter"
			Me.rowLiter.Properties.Format.FormatString = "#.### Liters"
			Me.rowLiter.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.rowLiter.Properties.RowEdit = Me.repositoryItemTextEdit1
			' 
			' rowCyl
			' 
			Me.rowCyl.Name = "rowCyl"
			Me.rowCyl.Properties.Caption = "Cyl"
			Me.rowCyl.Properties.FieldName = "Cyl"
			Me.rowCyl.Properties.RowEdit = Me.repositoryItemSpinEdit1
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
			' rowTransmiss_Speed_Count
			' 
			Me.rowTransmiss_Speed_Count.Name = "rowTransmiss_Speed_Count"
			Me.rowTransmiss_Speed_Count.Properties.Caption = "# of Gears"
			Me.rowTransmiss_Speed_Count.Properties.FieldName = "Transmiss Speed Count"
			Me.rowTransmiss_Speed_Count.Properties.RowEdit = Me.repositoryItemSpinEdit2
			' 
			' repositoryItemSpinEdit2
			' 
			Me.repositoryItemSpinEdit2.AllowFocused = False
			Me.repositoryItemSpinEdit2.AutoHeight = False
			Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit2.IsFloatValue = False
			Me.repositoryItemSpinEdit2.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
			' 
			' rowTransmiss_Automatic
			' 
			Me.rowTransmiss_Automatic.Name = "rowTransmiss_Automatic"
			Me.rowTransmiss_Automatic.Properties.Caption = "Automatic Transmission"
			Me.rowTransmiss_Automatic.Properties.FieldName = "Transmiss Automatic"
			Me.rowTransmiss_Automatic.Properties.ImageIndex = 2
			Me.rowTransmiss_Automatic.Properties.RowEdit = Me.repositoryItemImageComboBox1
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AllowFocused = False
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yes", "Yes", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("No", "No", 1)})
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
			' rowDescription
			' 
			Me.rowDescription.Name = "rowDescription"
			Me.rowDescription.Properties.Caption = "Description"
			Me.rowDescription.Properties.FieldName = "Description"
			Me.rowDescription.Properties.RowEdit = Me.repositoryItemMemoExEdit1
			' 
			' repositoryItemMemoExEdit1
			' 
			Me.repositoryItemMemoExEdit1.AllowFocused = False
			Me.repositoryItemMemoExEdit1.AutoHeight = False
			Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
			' 
			' rowIs_In_Stock
			' 
			Me.rowIs_In_Stock.Name = "rowIs_In_Stock"
			Me.rowIs_In_Stock.Properties.Caption = "In Stock?"
			Me.rowIs_In_Stock.Properties.FieldName = "Is In Stock"
			Me.rowIs_In_Stock.Properties.RowEdit = Me.repositoryItemCheckEdit1
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AllowFocused = False
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' rowHyperlink
			' 
			Me.rowHyperlink.Name = "rowHyperlink"
			Me.rowHyperlink.Properties.Caption = "Hyperlink"
			Me.rowHyperlink.Properties.FieldName = "Hyperlink"
			Me.rowHyperlink.Properties.ImageIndex = 1
			Me.rowHyperlink.Properties.RowEdit = Me.repositoryItemHyperLinkEdit1
			' 
			' repositoryItemHyperLinkEdit1
			' 
			Me.repositoryItemHyperLinkEdit1.AutoHeight = False
			Me.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1"
			' 
			' rowID
			' 
			Me.rowID.Name = "rowID"
			Me.rowID.Properties.Caption = "Record ID"
			Me.rowID.Properties.FieldName = "ID"
			Me.rowID.Properties.ImageIndex = 0
			Me.rowID.Properties.RowEdit = Me.repositoryItemTextEdit1
			' 
			' categoryRow3
			' 
			Me.categoryRow3.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowPrice, Me.rowDelivery_Date, Me.rowIs_In_Stock})
			Me.categoryRow3.Name = "categoryRow3"
			Me.categoryRow3.Properties.Caption = "Others"
			' 
			' rowDelivery_Date
			' 
			Me.rowDelivery_Date.Name = "rowDelivery_Date"
			Me.rowDelivery_Date.Properties.Caption = "Delivery Date"
			Me.rowDelivery_Date.Properties.FieldName = "Delivery Date"
			Me.rowDelivery_Date.Properties.RowEdit = Me.repositoryItemDateEdit1
			' 
			' repositoryItemDateEdit1
			' 
			Me.repositoryItemDateEdit1.AllowFocused = False
			Me.repositoryItemDateEdit1.AutoHeight = False
			Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
			' 
			' categoryRow4
			' 
			Me.categoryRow4.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowID, Me.rowTrademark, Me.rowModel, Me.rowCategory})
			Me.categoryRow4.Name = "categoryRow4"
			Me.categoryRow4.Properties.Caption = "Main Info"
			' 
			' rowTrademark
			' 
			Me.rowTrademark.Name = "rowTrademark"
			Me.rowTrademark.Properties.Caption = "Trademark"
			Me.rowTrademark.Properties.FieldName = "Trademark"
			Me.rowTrademark.Properties.RowEdit = Me.repositoryItemTextEdit1
			' 
			' rowModel
			' 
			Me.rowModel.Name = "rowModel"
			Me.rowModel.Properties.Caption = "Model"
			Me.rowModel.Properties.FieldName = "Model"
			Me.rowModel.Properties.RowEdit = Me.repositoryItemTextEdit1
			' 
			' rowCategory
			' 
			Me.rowCategory.Name = "rowCategory"
			Me.rowCategory.Properties.Caption = "Category"
			Me.rowCategory.Properties.FieldName = "Category"
			Me.rowCategory.Properties.RowEdit = Me.repositoryItemComboBox1
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.AllowFocused = False
			Me.repositoryItemComboBox1.AutoHeight = False
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.Items.AddRange(New Object() { "SALOON", "SPORTS", "TRUCK"})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			' 
			' repositoryItemImageEdit1
			' 
			Me.repositoryItemImageEdit1.AllowFocused = False
			Me.repositoryItemImageEdit1.AutoHeight = False
			Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
			' 
			' rowPicture
			' 
			Me.rowPicture.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowIcon})
			Me.rowPicture.Name = "rowPicture"
			Me.rowPicture.Properties.Caption = "Picture"
			Me.rowPicture.Properties.FieldName = "Picture"
			Me.rowPicture.Properties.RowEdit = Me.repositoryItemImageEdit1
			' 
			' rowIcon
			' 
			Me.rowIcon.Height = 52
			Me.rowIcon.Name = "rowIcon"
			Me.rowIcon.Properties.Caption = "Icon"
			Me.rowIcon.Properties.FieldName = "Icon"
			Me.rowIcon.Properties.ImageIndex = 4
			Me.rowIcon.Properties.RowEdit = Me.repositoryItemPictureEdit1
			' 
			' categoryRow2
			' 
			Me.categoryRow2.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowPicture, Me.rowDescription, Me.rowHyperlink})
			Me.categoryRow2.Name = "categoryRow2"
			Me.categoryRow2.Properties.Caption = "Notes"
			Me.categoryRow2.Properties.ImageIndex = 3
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(4, 4)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEdit1, Me.repositoryItemImageEdit1, Me.repositoryItemPictureEdit1, Me.repositoryItemMemoExEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemDateEdit1, Me.repositoryItemCheckEdit1, Me.repositoryItemComboBox1, Me.repositoryItemImageComboBox1, Me.repositoryItemSpinEdit2, Me.repositoryItemHyperLinkEdit1})
			Me.vGridControl1.RowHeaderWidth = 188
			Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.categoryRow4, Me.categoryRow1, Me.categoryRow2, Me.categoryRow3})
			Me.vGridControl1.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowForFocusedRecord
			Me.vGridControl1.Size = New System.Drawing.Size(290, 514)
			Me.vGridControl1.TabIndex = 13
			' 
			' Editors
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.tabControl1)
			Me.Name = "Editors"
			Me.Size = New System.Drawing.Size(614, 522)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.Editors_Load);
			CType(Me.tabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private WithEvents tabControl1 As DevExpress.XtraTab.XtraTabControl
		Private rowPrice As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private categoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowHP As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowLiter As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCyl As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTransmiss_Speed_Count As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTransmiss_Automatic As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowDescription As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowIs_In_Stock As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowHyperlink As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowID As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow3 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowDelivery_Date As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow4 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowTrademark As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowModel As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCategory As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
		Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private rowPicture As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowIcon As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow2 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageList1 As System.Windows.Forms.ImageList
		Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
