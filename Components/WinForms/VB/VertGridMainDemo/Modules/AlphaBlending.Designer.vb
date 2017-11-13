Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class AlphaBlending
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlphaBlending))
            Me.multiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.multiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.button1 = New DevExpress.XtraEditors.SimpleButton()
            Me.chAlphaBlending = New DevExpress.XtraEditors.CheckEdit()
            Me.lsStyles = New DevExpress.XtraEditors.ListBoxControl()
            Me.label2 = New System.Windows.Forms.Label()
            Me.lsImages = New DevExpress.XtraEditors.ListBoxControl()
            Me.label1 = New System.Windows.Forms.Label()
            Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
            Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
            Me.repositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
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
            Me.rowPicture = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowIcon = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowDescription = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowHyperlink = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.categoryRow3 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
            Me.rowPrice = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowDelivery_Date = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowIs_In_Stock = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.xtraVertGridBlending1 = New DevExpress.XtraVerticalGrid.Blending.XtraVertGridBlending()
            Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.chAlphaBlending.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lsStyles, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lsImages, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'multiEditorRowProperties1
            '
            Me.multiEditorRowProperties1.Caption = "MPG City"
            Me.multiEditorRowProperties1.FieldName = "MPG City"
            Me.multiEditorRowProperties1.RowEdit = Me.repositoryItemSpinEdit1
            Me.multiEditorRowProperties1.Width = 17
            '
            'repositoryItemSpinEdit1
            '
            Me.repositoryItemSpinEdit1.AllowFocused = False
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'multiEditorRowProperties2
            '
            Me.multiEditorRowProperties2.Caption = "MPG Highway"
            Me.multiEditorRowProperties2.FieldName = "MPG Highway"
            Me.multiEditorRowProperties2.RowEdit = Me.repositoryItemSpinEdit1
            Me.multiEditorRowProperties2.Width = 23
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.button1)
            Me.panel1.Controls.Add(Me.chAlphaBlending)
            Me.panel1.Controls.Add(Me.lsStyles)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.lsImages)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Padding = New System.Windows.Forms.Padding(4)
            Me.panel1.Size = New System.Drawing.Size(148, 498)
            Me.panel1.TabIndex = 0
            '
            'button1
            '
            Me.button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
            Me.button1.Location = New System.Drawing.Point(12, 368)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(120, 28)
            Me.button1.TabIndex = 17
            Me.button1.Text = "Adjustment..."
            '
            'chAlphaBlending
            '
            Me.chAlphaBlending.EditValue = True
            Me.chAlphaBlending.Location = New System.Drawing.Point(10, 344)
            Me.chAlphaBlending.Name = "chAlphaBlending"
            Me.chAlphaBlending.Properties.Caption = "Alpha Blending"
            Me.chAlphaBlending.Size = New System.Drawing.Size(124, 19)
            Me.chAlphaBlending.TabIndex = 16
            '
            'lsStyles
            '
            Me.lsStyles.Dock = System.Windows.Forms.DockStyle.Top
            Me.lsStyles.ItemHeight = 15
            Me.lsStyles.Location = New System.Drawing.Point(4, 140)
            Me.lsStyles.Name = "lsStyles"
            Me.lsStyles.Size = New System.Drawing.Size(140, 184)
            Me.lsStyles.TabIndex = 14
            '
            'label2
            '
            Me.label2.Dock = System.Windows.Forms.DockStyle.Top
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
            Me.label2.Location = New System.Drawing.Point(4, 120)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(140, 20)
            Me.label2.TabIndex = 15
            Me.label2.Text = "Style Formats:"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lsImages
            '
            Me.lsImages.Dock = System.Windows.Forms.DockStyle.Top
            Me.lsImages.ItemHeight = 15
            Me.lsImages.Items.AddRange(New Object() {"(None)", "Blue", "Green", "Pink", "Yellow", "World"})
            Me.lsImages.Location = New System.Drawing.Point(4, 24)
            Me.lsImages.Name = "lsImages"
            Me.lsImages.Size = New System.Drawing.Size(140, 96)
            Me.lsImages.TabIndex = 12
            '
            'label1
            '
            Me.label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
            Me.label1.Location = New System.Drawing.Point(4, 4)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(140, 20)
            Me.label1.TabIndex = 13
            Me.label1.Text = "Background Images:"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'vGridControl1
            '
            Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.vGridControl1.ImageList = Me.imageCollection1
            Me.vGridControl1.Location = New System.Drawing.Point(153, 0)
            Me.vGridControl1.Name = "vGridControl1"
            Me.vGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageEdit1, Me.repositoryItemMemoExEdit1, Me.repositoryItemPictureEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemHyperLinkEdit1, Me.repositoryItemRadioGroup1})
            Me.vGridControl1.RowHeaderWidth = 188
            Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.categoryRow4, Me.categoryRow1, Me.categoryRow2, Me.categoryRow3})
            Me.vGridControl1.Size = New System.Drawing.Size(492, 498)
            Me.vGridControl1.TabIndex = 1
            Me.vGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
            '
            'repositoryItemImageEdit1
            '
            Me.repositoryItemImageEdit1.AllowFocused = False
            Me.repositoryItemImageEdit1.AutoHeight = False
            Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
            '
            'repositoryItemMemoExEdit1
            '
            Me.repositoryItemMemoExEdit1.AllowFocused = False
            Me.repositoryItemMemoExEdit1.AutoHeight = False
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            '
            'repositoryItemPictureEdit1
            '
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            '
            'repositoryItemCalcEdit1
            '
            Me.repositoryItemCalcEdit1.AllowFocused = False
            Me.repositoryItemCalcEdit1.AutoHeight = False
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            '
            'repositoryItemImageComboBox1
            '
            Me.repositoryItemImageComboBox1.AllowFocused = False
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sports", "SPORTS", 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Saloon", "SALOON", 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Truck", "TRUCK", 4)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.imageList2
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList2.Images.SetKeyName(0, "")
            Me.imageList2.Images.SetKeyName(1, "")
            Me.imageList2.Images.SetKeyName(2, "")
            Me.imageList2.Images.SetKeyName(3, "")
            Me.imageList2.Images.SetKeyName(4, "")
            '
            'repositoryItemImageComboBox2
            '
            Me.repositoryItemImageComboBox2.AllowFocused = False
            Me.repositoryItemImageComboBox2.AutoHeight = False
            Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yes", "Yes", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("No", "No", 1)})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.SmallImages = Me.imageList2
            '
            'repositoryItemHyperLinkEdit1
            '
            Me.repositoryItemHyperLinkEdit1.AutoHeight = False
            Me.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1"
            '
            'repositoryItemRadioGroup1
            '
            Me.repositoryItemRadioGroup1.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Yes", "Yes"), New DevExpress.XtraEditors.Controls.RadioGroupItem("No", "No")})
            Me.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1"
            '
            'categoryRow4
            '
            Me.categoryRow4.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowID, Me.rowTrademark, Me.rowModel, Me.rowCategory})
            Me.categoryRow4.Name = "categoryRow4"
            Me.categoryRow4.Properties.Caption = "Main Info"
            '
            'rowID
            '
            Me.rowID.Name = "rowID"
            Me.rowID.Properties.Caption = "Record ID"
            Me.rowID.Properties.FieldName = "ID"
            '
            'rowTrademark
            '
            Me.rowTrademark.Name = "rowTrademark"
            Me.rowTrademark.Properties.Caption = "Trademark"
            Me.rowTrademark.Properties.FieldName = "Trademark"
            Me.rowTrademark.Properties.ImageIndex = 2
            '
            'rowModel
            '
            Me.rowModel.Name = "rowModel"
            Me.rowModel.Properties.Caption = "Model"
            Me.rowModel.Properties.FieldName = "Model"
            '
            'rowCategory
            '
            Me.rowCategory.Name = "rowCategory"
            Me.rowCategory.Properties.Caption = "Category"
            Me.rowCategory.Properties.FieldName = "Category"
            Me.rowCategory.Properties.RowEdit = Me.repositoryItemImageComboBox1
            '
            'categoryRow1
            '
            Me.categoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowHP, Me.rowLiter, Me.rowCyl, Me.rowTransmiss_Speed_Count, Me.rowTransmiss_Automatic, Me.rowMPG})
            Me.categoryRow1.Name = "categoryRow1"
            Me.categoryRow1.Properties.Caption = "Performance Attributes"
            '
            'rowHP
            '
            Me.rowHP.Name = "rowHP"
            Me.rowHP.Properties.Caption = "HP"
            Me.rowHP.Properties.FieldName = "HP"
            '
            'rowLiter
            '
            Me.rowLiter.Name = "rowLiter"
            Me.rowLiter.Properties.Caption = "Capacity"
            Me.rowLiter.Properties.FieldName = "Liter"
            Me.rowLiter.Properties.Format.FormatString = "#.### Liters"
            Me.rowLiter.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            '
            'rowCyl
            '
            Me.rowCyl.Name = "rowCyl"
            Me.rowCyl.Properties.Caption = "Cyl"
            Me.rowCyl.Properties.FieldName = "Cyl"
            Me.rowCyl.Properties.RowEdit = Me.repositoryItemSpinEdit1
            '
            'rowTransmiss_Speed_Count
            '
            Me.rowTransmiss_Speed_Count.Name = "rowTransmiss_Speed_Count"
            Me.rowTransmiss_Speed_Count.Properties.Caption = "# of Gears"
            Me.rowTransmiss_Speed_Count.Properties.FieldName = "Transmiss Speed Count"
            Me.rowTransmiss_Speed_Count.Properties.RowEdit = Me.repositoryItemSpinEdit1
            '
            'rowTransmiss_Automatic
            '
            Me.rowTransmiss_Automatic.Height = 19
            Me.rowTransmiss_Automatic.Name = "rowTransmiss_Automatic"
            Me.rowTransmiss_Automatic.Properties.Caption = "Automatic Transmission"
            Me.rowTransmiss_Automatic.Properties.FieldName = "Transmiss Automatic"
            Me.rowTransmiss_Automatic.Properties.RowEdit = Me.repositoryItemRadioGroup1
            '
            'rowMPG
            '
            Me.rowMPG.Name = "rowMPG"
            Me.rowMPG.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.multiEditorRowProperties1, Me.multiEditorRowProperties2})
            '
            'categoryRow2
            '
            Me.categoryRow2.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowPicture, Me.rowDescription, Me.rowHyperlink})
            Me.categoryRow2.Name = "categoryRow2"
            Me.categoryRow2.Properties.Caption = "Notes"
            Me.categoryRow2.Properties.ImageIndex = 0
            '
            'rowPicture
            '
            Me.rowPicture.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIcon})
            Me.rowPicture.Name = "rowPicture"
            Me.rowPicture.Properties.Caption = "Picture"
            Me.rowPicture.Properties.FieldName = "Picture"
            Me.rowPicture.Properties.RowEdit = Me.repositoryItemImageEdit1
            '
            'rowIcon
            '
            Me.rowIcon.Height = 52
            Me.rowIcon.Name = "rowIcon"
            Me.rowIcon.Properties.Caption = "Icon"
            Me.rowIcon.Properties.FieldName = "Icon"
            Me.rowIcon.Properties.ImageIndex = 1
            Me.rowIcon.Properties.RowEdit = Me.repositoryItemPictureEdit1
            '
            'rowDescription
            '
            Me.rowDescription.Name = "rowDescription"
            Me.rowDescription.Properties.Caption = "Description"
            Me.rowDescription.Properties.FieldName = "Description"
            Me.rowDescription.Properties.RowEdit = Me.repositoryItemMemoExEdit1
            '
            'rowHyperlink
            '
            Me.rowHyperlink.Name = "rowHyperlink"
            Me.rowHyperlink.Properties.Caption = "Hyperlink"
            Me.rowHyperlink.Properties.FieldName = "Hyperlink"
            Me.rowHyperlink.Properties.RowEdit = Me.repositoryItemHyperLinkEdit1
            '
            'categoryRow3
            '
            Me.categoryRow3.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowPrice, Me.rowDelivery_Date, Me.rowIs_In_Stock})
            Me.categoryRow3.Name = "categoryRow3"
            Me.categoryRow3.Properties.Caption = "Others"
            '
            'rowPrice
            '
            Me.rowPrice.Name = "rowPrice"
            Me.rowPrice.Properties.Caption = "Price"
            Me.rowPrice.Properties.FieldName = "Price"
            Me.rowPrice.Properties.Format.FormatString = "c"
            Me.rowPrice.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.rowPrice.Properties.RowEdit = Me.repositoryItemCalcEdit1
            '
            'rowDelivery_Date
            '
            Me.rowDelivery_Date.Name = "rowDelivery_Date"
            Me.rowDelivery_Date.Properties.Caption = "Delivery Date"
            Me.rowDelivery_Date.Properties.FieldName = "Delivery Date"
            '
            'rowIs_In_Stock
            '
            Me.rowIs_In_Stock.Name = "rowIs_In_Stock"
            Me.rowIs_In_Stock.Properties.Caption = "In Stock?"
            Me.rowIs_In_Stock.Properties.FieldName = "Is In Stock"
            '
            'xtraVertGridBlending1
            '
            Me.xtraVertGridBlending1.VertGridControl = Me.vGridControl1
            '
            'splitter1
            '
            Me.splitter1.Location = New System.Drawing.Point(148, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(5, 498)
            Me.splitter1.TabIndex = 2
            Me.splitter1.TabStop = False
            '
            'imageCollection1
            '
            Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "Notes_16x16.png")
            Me.imageCollection1.Images.SetKeyName(1, "Image_16x16.png")
            Me.imageCollection1.Images.SetKeyName(2, "Feature_16x16.png")
            '
            'AlphaBlending
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.vGridControl1)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "AlphaBlending"
            Me.Size = New System.Drawing.Size(645, 498)
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.chAlphaBlending.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lsStyles, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lsImages, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private panel1 As System.Windows.Forms.Panel
        Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private xtraVertGridBlending1 As DevExpress.XtraVerticalGrid.Blending.XtraVertGridBlending
		Private WithEvents lsImages As DevExpress.XtraEditors.ListBoxControl
		Private label1 As System.Windows.Forms.Label
		Private WithEvents lsStyles As DevExpress.XtraEditors.ListBoxControl
		Private label2 As System.Windows.Forms.Label
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private WithEvents chAlphaBlending As DevExpress.XtraEditors.CheckEdit
		Private WithEvents button1 As DevExpress.XtraEditors.SimpleButton
		Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
		Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private imageList2 As System.Windows.Forms.ImageList
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
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
		Private repositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
		Private repositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
        Private components As System.ComponentModel.IContainer
        Friend WithEvents multiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Private WithEvents imageCollection1 As DevExpress.Utils.ImageCollection

	End Class
End Namespace
