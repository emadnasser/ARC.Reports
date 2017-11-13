Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class FieldsCustomization
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
			Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.icbCustomizationStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.icbHideFields = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.sbCustomizationForm = New DevExpress.XtraEditors.SimpleButton()
			Me.pcSplitter = New DevExpress.XtraEditors.PanelControl()
			Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderID = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.icbCustomizationStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbHideFields.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.panelControl1.Controls.Add(Me.icbCustomizationStyle)
			Me.panelControl1.Controls.Add(Me.label1)
			Me.panelControl1.Controls.Add(Me.icbHideFields)
			Me.panelControl1.Controls.Add(Me.label2)
			Me.panelControl1.Controls.Add(Me.sbCustomizationForm)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(707, 72)
			Me.panelControl1.TabIndex = 1
			' 
			' icbCustomizationStyle
			' 
			Me.icbCustomizationStyle.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.icbCustomizationStyle.EditValue = "imageComboBoxEdit1"
			Me.icbCustomizationStyle.Location = New System.Drawing.Point(510, 41)
			Me.icbCustomizationStyle.Name = "icbCustomizationStyle"
			Me.icbCustomizationStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbCustomizationStyle.Properties.DropDownRows = 10
			Me.icbCustomizationStyle.Size = New System.Drawing.Size(184, 20)
			Me.icbCustomizationStyle.TabIndex = 8
'			Me.icbCustomizationStyle.SelectedIndexChanged += New System.EventHandler(Me.icbCustomizationStyle_SelectedIndexChanged);
			' 
			' label1
			' 
			Me.label1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.label1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label1.Location = New System.Drawing.Point(400, 44)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(98, 13)
			Me.label1.TabIndex = 7
			Me.label1.Text = "Customization Style:"
			' 
			' icbHideFields
			' 
			Me.icbHideFields.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.icbHideFields.EditValue = "imageComboBoxEdit1"
			Me.icbHideFields.Location = New System.Drawing.Point(510, 15)
			Me.icbHideFields.Name = "icbHideFields"
			Me.icbHideFields.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbHideFields.Properties.DropDownRows = 10
			Me.icbHideFields.Size = New System.Drawing.Size(184, 20)
			Me.icbHideFields.TabIndex = 6
'			Me.icbHideFields.SelectedIndexChanged += New System.EventHandler(Me.icbHideFields_SelectedIndexChanged);
			' 
			' label2
			' 
			Me.label2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.label2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label2.Location = New System.Drawing.Point(409, 18)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(91, 13)
			Me.label2.TabIndex = 5
			Me.label2.Text = "Allow Hiding Fields:"
			' 
			' sbCustomizationForm
			' 
			Me.sbCustomizationForm.Location = New System.Drawing.Point(12, 25)
			Me.sbCustomizationForm.Name = "sbCustomizationForm"
			Me.sbCustomizationForm.Size = New System.Drawing.Size(212, 24)
			Me.sbCustomizationForm.TabIndex = 0
'			Me.sbCustomizationForm.Click += New System.EventHandler(Me.sbCustomizationForm_Click);
			' 
			' pcSplitter
			' 
			Me.pcSplitter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcSplitter.Dock = System.Windows.Forms.DockStyle.Top
			Me.pcSplitter.Location = New System.Drawing.Point(0, 72)
			Me.pcSplitter.Name = "pcSplitter"
			Me.pcSplitter.Size = New System.Drawing.Size(707, 2)
			Me.pcSplitter.TabIndex = 9
			' 
			' paddingPanel
			' 
			Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.paddingPanel.Location = New System.Drawing.Point(0, 74)
			Me.paddingPanel.Name = "paddingPanel"
			Me.paddingPanel.Size = New System.Drawing.Size(707, 8)
			Me.paddingPanel.TabIndex = 11
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCountry, Me.fieldSalesPerson, Me.fieldYear, Me.fieldQuarter, Me.fieldExtendedPrice, Me.fieldQuantity, Me.fieldProductName, Me.fieldCategoryName, Me.fieldOrderID})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 82)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(707, 334)
			Me.pivotGridControl1.TabIndex = 12
'			Me.pivotGridControl1.FieldValueImageIndex += New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(Me.pivotGridControl1_FieldValueImageIndex);
'			Me.pivotGridControl1.HideCustomizationForm += New System.EventHandler(Me.pivotGridControl1_HideCustomizationForm);
'			Me.pivotGridControl1.ShowCustomizationForm += New System.EventHandler(Me.pivotGridControl1_ShowCustomizationForm);
			' 
			' fieldCountry
			' 
			Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldCountry.AreaIndex = 0
			Me.fieldCountry.FieldName = "Country"
			Me.fieldCountry.Name = "fieldCountry"
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldSalesPerson.AreaIndex = 1
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			Me.fieldSalesPerson.Width = 130
			' 
			' fieldYear
			' 
			Me.fieldYear.AreaIndex = 0
			Me.fieldYear.Caption = "Order Year"
			Me.fieldYear.FieldName = "OrderDate"
			Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldYear.Name = "fieldYear"
			Me.fieldYear.UnboundFieldName = "fieldYear"
			Me.fieldYear.Width = 120
			' 
			' fieldQuarter
			' 
			Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldQuarter.AreaIndex = 0
			Me.fieldQuarter.Caption = "Order Quarter"
			Me.fieldQuarter.FieldName = "OrderDate"
			Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldQuarter.Name = "fieldQuarter"
			Me.fieldQuarter.TotalValueFormat.FormatString = "Quarter {0} Total"
			Me.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
			Me.fieldQuarter.ValueFormat.FormatString = "Quarter {0}"
			Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldQuarter.Width = 140
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
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			Me.fieldQuantity.Visible = False
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			Me.fieldProductName.Visible = False
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 1
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			Me.fieldCategoryName.Width = 139
			' 
			' fieldOrderID
			' 
			Me.fieldOrderID.FieldName = "OrderID"
			Me.fieldOrderID.Name = "fieldOrderID"
			Me.fieldOrderID.Visible = False
			' 
			' FieldsCustomization
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.paddingPanel)
			Me.Controls.Add(Me.pcSplitter)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "FieldsCustomization"
			Me.Size = New System.Drawing.Size(707, 416)
'			Me.Load += New System.EventHandler(Me.FieldsCustomization_Load);
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.icbCustomizationStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbHideFields.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcSplitter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private pcSplitter As DevExpress.XtraEditors.PanelControl
		Private WithEvents sbCustomizationForm As DevExpress.XtraEditors.SimpleButton
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbHideFields As DevExpress.XtraEditors.ImageComboBoxEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private paddingPanel As DevExpress.XtraEditors.PanelControl
		Private WithEvents pivotGridControl1 As PivotGridControl
		Private fieldCountry As PivotGridField
		Private fieldSalesPerson As PivotGridField
		Private fieldYear As PivotGridField
		Private fieldQuarter As PivotGridField
		Private fieldExtendedPrice As PivotGridField
		Private fieldQuantity As PivotGridField
		Private fieldProductName As PivotGridField
		Private fieldCategoryName As PivotGridField
		Private fieldOrderID As PivotGridField
		Private WithEvents icbCustomizationStyle As DevExpress.XtraEditors.ImageComboBoxEdit
		Private label1 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
