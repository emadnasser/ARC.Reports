Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class SingleTotal
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
			Dim pivotGridCustomTotal1 As New DevExpress.XtraPivotGrid.PivotGridCustomTotal()
			Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
			Me.pcSummary = New DevExpress.XtraEditors.PanelControl()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.clbOptions = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.pcSplitter = New DevExpress.XtraEditors.PanelControl()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.icbSummaryType = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.icbField = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldUnitPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDiscount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcSummary, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcSummary.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.clbOptions, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.icbSummaryType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbField.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dsSalesPerson1
			' 
			Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
			Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' pcSummary
			' 
			Me.pcSummary.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcSummary.Controls.Add(Me.groupControl2)
			Me.pcSummary.Controls.Add(Me.pcSplitter)
			Me.pcSummary.Controls.Add(Me.groupControl1)
			Me.pcSummary.Dock = System.Windows.Forms.DockStyle.Top
			Me.pcSummary.Location = New System.Drawing.Point(0, 0)
			Me.pcSummary.Name = "pcSummary"
			Me.pcSummary.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
			Me.pcSummary.Size = New System.Drawing.Size(706, 88)
			Me.pcSummary.TabIndex = 1
			' 
			' groupControl2
			' 
			Me.groupControl2.Controls.Add(Me.clbOptions)
			Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl2.Location = New System.Drawing.Point(215, 0)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Padding = New System.Windows.Forms.Padding(4)
			Me.groupControl2.Size = New System.Drawing.Size(491, 86)
			Me.groupControl2.TabIndex = 7
			Me.groupControl2.Text = "View Options"
			' 
			' clbOptions
			' 
			Me.clbOptions.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.clbOptions.CheckOnClick = True
			Me.clbOptions.Dock = System.Windows.Forms.DockStyle.Fill
			Me.clbOptions.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
			Me.clbOptions.ItemHeight = 17
			Me.clbOptions.Location = New System.Drawing.Point(6, 26)
			Me.clbOptions.MultiColumn = True
			Me.clbOptions.Name = "clbOptions"
			Me.clbOptions.Size = New System.Drawing.Size(479, 54)
			Me.clbOptions.TabIndex = 0
'			Me.clbOptions.ItemCheck += New DevExpress.XtraEditors.Controls.ItemCheckEventHandler(Me.clbOptions_ItemCheck);
			' 
			' pcSplitter
			' 
			Me.pcSplitter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcSplitter.Dock = System.Windows.Forms.DockStyle.Left
			Me.pcSplitter.Location = New System.Drawing.Point(213, 0)
			Me.pcSplitter.Name = "pcSplitter"
			Me.pcSplitter.Size = New System.Drawing.Size(2, 86)
			Me.pcSplitter.TabIndex = 8
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.icbSummaryType)
			Me.groupControl1.Controls.Add(Me.label3)
			Me.groupControl1.Controls.Add(Me.icbField)
			Me.groupControl1.Controls.Add(Me.label2)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.groupControl1.Location = New System.Drawing.Point(0, 0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(213, 86)
			Me.groupControl1.TabIndex = 6
			Me.groupControl1.Text = "DataField Summary Settings"
			' 
			' icbSummaryType
			' 
			Me.icbSummaryType.EditValue = "imageComboBoxEdit1"
			Me.icbSummaryType.Location = New System.Drawing.Point(93, 53)
			Me.icbSummaryType.Name = "icbSummaryType"
			Me.icbSummaryType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbSummaryType.Properties.DropDownRows = 10
			Me.icbSummaryType.Size = New System.Drawing.Size(104, 20)
			Me.icbSummaryType.TabIndex = 6
'			Me.icbSummaryType.SelectedIndexChanged += New System.EventHandler(Me.icbSummaryType_SelectedIndexChanged);
			' 
			' label3
			' 
			Me.label3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label3.Location = New System.Drawing.Point(12, 57)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(75, 13)
			Me.label3.TabIndex = 5
			Me.label3.Text = "Summary Type:"
			' 
			' icbField
			' 
			Me.icbField.EditValue = "imageComboBoxEdit1"
			Me.icbField.Location = New System.Drawing.Point(93, 29)
			Me.icbField.Name = "icbField"
			Me.icbField.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbField.Size = New System.Drawing.Size(104, 20)
			Me.icbField.TabIndex = 0
'			Me.icbField.SelectedIndexChanged += New System.EventHandler(Me.icbField_SelectedIndexChanged);
			' 
			' label2
			' 
			Me.label2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label2.Location = New System.Drawing.Point(12, 33)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(26, 13)
			Me.label2.TabIndex = 4
			Me.label2.Text = "Field:"
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 88)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(706, 8)
			Me.panelControl2.TabIndex = 13
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldYear, Me.fieldCategoryName, Me.fieldProductName, Me.fieldQuarter, Me.fieldUnitPrice, Me.fieldQuantity, Me.fieldDiscount, Me.fieldExtendedPrice})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 96)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
			Me.pivotGridControl1.OptionsDataField.AreaIndex = 2
			Me.pivotGridControl1.OptionsView.ShowColumnGrandTotals = False
			Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(706, 320)
			Me.pivotGridControl1.TabIndex = 14
'			Me.pivotGridControl1.FieldValueImageIndex += New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(Me.pivotGridControl1_FieldValueImageIndex);
'			Me.pivotGridControl1.CustomDrawFieldHeader += New DevExpress.XtraPivotGrid.PivotCustomDrawFieldHeaderEventHandler(Me.pivotGridControl1_CustomDrawFieldHeader);
'			Me.pivotGridControl1.CustomSummary += New DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(Me.pivotGridControl1_CustomSummary);
			' 
			' fieldYear
			' 
			Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldYear.AreaIndex = 0
			Me.fieldYear.Caption = "Year"
			Me.fieldYear.FieldName = "OrderDate"
			Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldYear.Name = "fieldYear"
			Me.fieldYear.UnboundFieldName = "fieldYear"
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 0
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			Me.fieldCategoryName.Width = 135
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			Me.fieldProductName.Width = 170
			' 
			' fieldQuarter
			' 
			Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldQuarter.AreaIndex = 1
			Me.fieldQuarter.Caption = "Quarter"
			Me.fieldQuarter.FieldName = "OrderDate"
			Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldQuarter.Name = "fieldQuarter"
			Me.fieldQuarter.TotalValueFormat.FormatString = "Quarter {0} Total"
			Me.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
			Me.fieldQuarter.ValueFormat.FormatString = "Quarter {0}"
			Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' fieldUnitPrice
			' 
			Me.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldUnitPrice.AreaIndex = 0
			Me.fieldUnitPrice.Caption = "Unit Price"
			Me.fieldUnitPrice.CellFormat.FormatString = "c"
			Me.fieldUnitPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			pivotGridCustomTotal1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			pivotGridCustomTotal1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.StdDev
			Me.fieldUnitPrice.CustomTotals.AddRange(New DevExpress.XtraPivotGrid.PivotGridCustomTotal() { pivotGridCustomTotal1})
			Me.fieldUnitPrice.FieldName = "UnitPrice"
			Me.fieldUnitPrice.Name = "fieldUnitPrice"
			Me.fieldUnitPrice.Options.ShowSummaryTypeName = True
			Me.fieldUnitPrice.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
			Me.fieldUnitPrice.ValueFormat.FormatString = "c"
			Me.fieldUnitPrice.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 1
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.CellFormat.FormatString = "#.##"
			Me.fieldQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			Me.fieldQuantity.Options.ShowSummaryTypeName = True
			Me.fieldQuantity.ValueFormat.FormatString = "#.##"
			Me.fieldQuantity.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' fieldDiscount
			' 
			Me.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldDiscount.AreaIndex = 2
			Me.fieldDiscount.Caption = "Discount"
			Me.fieldDiscount.CellFormat.FormatString = "p"
			Me.fieldDiscount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldDiscount.FieldName = "Discount"
			Me.fieldDiscount.Name = "fieldDiscount"
			Me.fieldDiscount.Options.ShowSummaryTypeName = True
			Me.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
			Me.fieldDiscount.ValueFormat.FormatString = "p"
			Me.fieldDiscount.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 3
			Me.fieldExtendedPrice.Caption = "Extended Price"
			Me.fieldExtendedPrice.CellFormat.FormatString = "c"
			Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			Me.fieldExtendedPrice.Options.ShowInCustomizationForm = False
			Me.fieldExtendedPrice.ValueFormat.FormatString = "c"
			Me.fieldExtendedPrice.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldExtendedPrice.Visible = False
			' 
			' SingleTotal
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.pcSummary)
			Me.Name = "SingleTotal"
			Me.Size = New System.Drawing.Size(706, 416)
'			Me.Load += New System.EventHandler(Me.SingleTotal_Load);
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcSummary, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcSummary.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.clbOptions, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcSplitter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.icbSummaryType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbField.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson
		Private WithEvents icbField As DevExpress.XtraEditors.ImageComboBoxEdit
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private pcSplitter As DevExpress.XtraEditors.PanelControl
		Private pcSummary As DevExpress.XtraEditors.PanelControl
		Private WithEvents clbOptions As DevExpress.XtraEditors.CheckedListBoxControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents icbSummaryType As DevExpress.XtraEditors.ImageComboBoxEdit
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private WithEvents pivotGridControl1 As PivotGridControl
		Private fieldYear As PivotGridField
		Private fieldCategoryName As PivotGridField
		Private fieldProductName As PivotGridField
		Private fieldQuarter As PivotGridField
		Private fieldUnitPrice As PivotGridField
		Private fieldQuantity As PivotGridField
		Private fieldDiscount As PivotGridField
		Private fieldExtendedPrice As PivotGridField

	End Class
End Namespace
