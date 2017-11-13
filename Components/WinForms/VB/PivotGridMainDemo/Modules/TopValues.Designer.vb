Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class TopValues
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
			Dim pivotGridStyleFormatCondition1 As New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
			Dim pivotGridStyleFormatCondition2 As New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
			Dim pivotGridStyleFormatCondition3 As New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
			Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.ceTopValuesShowOthers = New DevExpress.XtraEditors.CheckEdit()
			Me.icbField = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.seTop = New DevExpress.XtraEditors.SpinEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.pcSplitter = New DevExpress.XtraEditors.PanelControl()
			Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldOrderID = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.ceTopValuesShowOthers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbField.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seTop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dsSalesPerson1
			' 
			Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
			Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.ceTopValuesShowOthers)
			Me.panelControl1.Controls.Add(Me.icbField)
			Me.panelControl1.Controls.Add(Me.label1)
			Me.panelControl1.Controls.Add(Me.seTop)
			Me.panelControl1.Controls.Add(Me.label2)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(706, 74)
			Me.panelControl1.TabIndex = 1
			' 
			' ceTopValuesShowOthers
			' 
			Me.ceTopValuesShowOthers.Location = New System.Drawing.Point(16, 45)
			Me.ceTopValuesShowOthers.Name = "ceTopValuesShowOthers"
			Me.ceTopValuesShowOthers.Properties.Caption = "TopValuesShowOthers"
			Me.ceTopValuesShowOthers.Size = New System.Drawing.Size(224, 19)
			Me.ceTopValuesShowOthers.TabIndex = 2
'			Me.ceTopValuesShowOthers.CheckedChanged += New System.EventHandler(Me.ceTopValuesShowOthers_CheckedChanged);
			' 
			' icbField
			' 
			Me.icbField.EditValue = "imageComboBoxEdit1"
			Me.icbField.Location = New System.Drawing.Point(264, 16)
			Me.icbField.Name = "icbField"
			Me.icbField.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbField.Size = New System.Drawing.Size(168, 20)
			Me.icbField.TabIndex = 1
'			Me.icbField.SelectedIndexChanged += New System.EventHandler(Me.icbField_SelectedIndexChanged);
			' 
			' label1
			' 
			Me.label1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label1.Location = New System.Drawing.Point(154, 19)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(99, 13)
			Me.label1.TabIndex = 8
			Me.label1.Text = "Values for the Field: "
			' 
			' seTop
			' 
			Me.seTop.EditValue = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.seTop.Location = New System.Drawing.Point(76, 16)
			Me.seTop.Name = "seTop"
			Me.seTop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seTop.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.seTop.Properties.IsFloatValue = False
			Me.seTop.Properties.Mask.EditMask = "N00"
			Me.seTop.Properties.MaxValue = New Decimal(New Integer() { 30, 0, 0, 0})
			Me.seTop.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.seTop.Size = New System.Drawing.Size(72, 20)
			Me.seTop.TabIndex = 0
'			Me.seTop.EditValueChanged += New System.EventHandler(Me.seTop_EditValueChanged);
			' 
			' label2
			' 
			Me.label2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label2.Location = New System.Drawing.Point(16, 19)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(51, 13)
			Me.label2.TabIndex = 6
			Me.label2.Text = "Show Top:"
			' 
			' pcSplitter
			' 
			Me.pcSplitter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcSplitter.Dock = System.Windows.Forms.DockStyle.Top
			Me.pcSplitter.Location = New System.Drawing.Point(0, 74)
			Me.pcSplitter.Name = "pcSplitter"
			Me.pcSplitter.Size = New System.Drawing.Size(706, 2)
			Me.pcSplitter.TabIndex = 9
			' 
			' paddingPanel
			' 
			Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.paddingPanel.Location = New System.Drawing.Point(0, 76)
			Me.paddingPanel.Name = "paddingPanel"
			Me.paddingPanel.Size = New System.Drawing.Size(706, 8)
			Me.paddingPanel.TabIndex = 11
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldOrderID, Me.fieldCategoryName, Me.fieldProductName, Me.fieldSalesPerson, Me.fieldExtendedPrice})
			pivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
			pivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = True
			pivotGridStyleFormatCondition1.ApplyToCustomTotalCell = False
			pivotGridStyleFormatCondition1.ApplyToGrandTotalCell = False
			pivotGridStyleFormatCondition1.ApplyToTotalCell = False
			pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
			pivotGridStyleFormatCondition1.FieldName = ""
			pivotGridStyleFormatCondition1.Value1 = 10000
			pivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue
			pivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = True
			pivotGridStyleFormatCondition2.ApplyToCustomTotalCell = False
			pivotGridStyleFormatCondition2.ApplyToGrandTotalCell = False
			pivotGridStyleFormatCondition2.ApplyToTotalCell = False
			pivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
			pivotGridStyleFormatCondition2.FieldName = ""
			pivotGridStyleFormatCondition2.Value1 = 350
			pivotGridStyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Green
			pivotGridStyleFormatCondition3.Appearance.Options.UseForeColor = True
			pivotGridStyleFormatCondition3.ApplyToCustomTotalCell = False
			pivotGridStyleFormatCondition3.ApplyToGrandTotalCell = False
			pivotGridStyleFormatCondition3.ApplyToTotalCell = False
			pivotGridStyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
			pivotGridStyleFormatCondition3.FieldName = ""
			pivotGridStyleFormatCondition3.Value1 = 0.1F
			Me.pivotGridControl1.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() { pivotGridStyleFormatCondition1, pivotGridStyleFormatCondition2, pivotGridStyleFormatCondition3})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 84)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsView.ShowColumnHeaders = False
			Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(706, 332)
			Me.pivotGridControl1.TabIndex = 12
'			Me.pivotGridControl1.FieldValueImageIndex += New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(Me.pivotGridControl1_FieldValueImageIndex);
'			Me.pivotGridControl1.CustomDrawFieldValue += New DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventHandler(Me.pivotGridControl1_CustomDrawFieldValue);
			' 
			' fieldOrderID
			' 
			Me.fieldOrderID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldOrderID.AreaIndex = 0
			Me.fieldOrderID.Caption = "Order ID"
			Me.fieldOrderID.FieldName = "OrderID"
			Me.fieldOrderID.Name = "fieldOrderID"
			Me.fieldOrderID.SortBySummaryInfo.Field = Me.fieldExtendedPrice
			Me.fieldOrderID.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 0
			Me.fieldExtendedPrice.Caption = "Order Amount"
			Me.fieldExtendedPrice.CellFormat.FormatString = "c"
			Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			Me.fieldExtendedPrice.Width = 120
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 1
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			Me.fieldCategoryName.SortBySummaryInfo.Field = Me.fieldExtendedPrice
			Me.fieldCategoryName.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
			Me.fieldCategoryName.Width = 160
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 3
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			Me.fieldProductName.SortBySummaryInfo.Field = Me.fieldExtendedPrice
			Me.fieldProductName.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
			Me.fieldProductName.Width = 180
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson.AreaIndex = 2
			Me.fieldSalesPerson.Caption = "Sales Person"
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			Me.fieldSalesPerson.SortBySummaryInfo.Field = Me.fieldExtendedPrice
			Me.fieldSalesPerson.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
			Me.fieldSalesPerson.Width = 140
			' 
			' TopValues
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.paddingPanel)
			Me.Controls.Add(Me.pcSplitter)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "TopValues"
			Me.Size = New System.Drawing.Size(706, 416)
'			Me.Load += New System.EventHandler(Me.TopValues_Load);
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.ceTopValuesShowOthers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbField.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seTop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcSplitter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private pcSplitter As DevExpress.XtraEditors.PanelControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbField As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents seTop As DevExpress.XtraEditors.SpinEdit
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents ceTopValuesShowOthers As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private paddingPanel As DevExpress.XtraEditors.PanelControl
		Private WithEvents pivotGridControl1 As PivotGridControl
		Private fieldOrderID As PivotGridField
		Private fieldExtendedPrice As PivotGridField
		Private fieldCategoryName As PivotGridField
		Private fieldProductName As PivotGridField
		Private fieldSalesPerson As PivotGridField

	End Class
End Namespace
