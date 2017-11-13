Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class DataMode
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
			Dim multiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Dim multiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
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
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(4, 4)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageEdit1, Me.repositoryItemPictureEdit1, Me.repositoryItemMemoExEdit1, Me.repositoryItemHyperLinkEdit1, Me.repositoryItemRadioGroup1})
			Me.vGridControl1.RowHeaderWidth = 188
			Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.categoryRow4, Me.categoryRow1, Me.categoryRow2, Me.categoryRow3})
			Me.vGridControl1.Size = New System.Drawing.Size(386, 458)
			Me.vGridControl1.TabIndex = 7
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
			' 
			' repositoryItemMemoExEdit1
			' 
			Me.repositoryItemMemoExEdit1.AllowFocused = False
			Me.repositoryItemMemoExEdit1.AutoHeight = False
			Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
			' 
			' repositoryItemHyperLinkEdit1
			' 
			Me.repositoryItemHyperLinkEdit1.AutoHeight = False
			Me.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1"
			' 
			' repositoryItemRadioGroup1
			' 
			Me.repositoryItemRadioGroup1.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem("Yes", "Yes"), New DevExpress.XtraEditors.Controls.RadioGroupItem("No", "No")})
			Me.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1"
			' 
			' categoryRow4
			' 
			Me.categoryRow4.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowID, Me.rowTrademark, Me.rowModel, Me.rowCategory})
			Me.categoryRow4.Expanded = False
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
			' 
			' rowTransmiss_Speed_Count
			' 
			Me.rowTransmiss_Speed_Count.Name = "rowTransmiss_Speed_Count"
			Me.rowTransmiss_Speed_Count.Properties.Caption = "# of Gears"
			Me.rowTransmiss_Speed_Count.Properties.FieldName = "Transmiss Speed Count"
			' 
			' rowTransmiss_Automatic
			' 
			Me.rowTransmiss_Automatic.Name = "rowTransmiss_Automatic"
			Me.rowTransmiss_Automatic.Properties.Caption = "Automatic Transmission"
			Me.rowTransmiss_Automatic.Properties.FieldName = "Transmiss Automatic"
			Me.rowTransmiss_Automatic.Properties.ImageIndex = 2
			Me.rowTransmiss_Automatic.Properties.RowEdit = Me.repositoryItemRadioGroup1
			' 
			' rowMPG
			' 
			Me.rowMPG.Name = "rowMPG"
			multiEditorRowProperties1.Caption = "MPG City"
			multiEditorRowProperties1.FieldName = "MPG City"
			multiEditorRowProperties1.Width = 17
			multiEditorRowProperties2.Caption = "MPG Highway"
			multiEditorRowProperties2.FieldName = "MPG Highway"
			multiEditorRowProperties2.Width = 23
			Me.rowMPG.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() { multiEditorRowProperties1, multiEditorRowProperties2})
			' 
			' categoryRow2
			' 
			Me.categoryRow2.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowPicture, Me.rowDescription, Me.rowHyperlink})
			Me.categoryRow2.Name = "categoryRow2"
			Me.categoryRow2.Properties.Caption = "Notes"
			Me.categoryRow2.Properties.ImageIndex = 3
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
			' rowDescription
			' 
			Me.rowDescription.Name = "rowDescription"
			Me.rowDescription.Properties.Caption = "Description"
			Me.rowDescription.Properties.FieldName = "Description"
			Me.rowDescription.Properties.RowEdit = Me.repositoryItemMemoExEdit1
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
			' DataMode
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Name = "DataMode"
			Me.Size = New System.Drawing.Size(394, 466)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.DataMode_Load);
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
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
		Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private repositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
		Private repositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
