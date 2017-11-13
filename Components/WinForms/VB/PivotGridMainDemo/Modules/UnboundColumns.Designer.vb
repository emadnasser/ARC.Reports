Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class UnboundColumns
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
			Me.icbOrderAmount = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.icbSalesPerson = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldPercent = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldBonusAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.icbOrderAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbSalesPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.panelControl1.Controls.Add(Me.icbOrderAmount)
			Me.panelControl1.Controls.Add(Me.label2)
			Me.panelControl1.Controls.Add(Me.icbSalesPerson)
			Me.panelControl1.Controls.Add(Me.label1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(706, 64)
			Me.panelControl1.TabIndex = 1
			' 
			' icbOrderAmount
			' 
			Me.icbOrderAmount.EditValue = 0
			Me.icbOrderAmount.Location = New System.Drawing.Point(126, 37)
			Me.icbOrderAmount.Name = "icbOrderAmount"
			Me.icbOrderAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbOrderAmount.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("with Discount", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("without Discount", 1, -1)})
			Me.icbOrderAmount.Size = New System.Drawing.Size(172, 20)
			Me.icbOrderAmount.TabIndex = 4
'			Me.icbOrderAmount.SelectedIndexChanged += New System.EventHandler(Me.icb_SelectedIndexChanged);
			' 
			' label2
			' 
			Me.label2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label2.Appearance.Options.UseBackColor = True
			Me.label2.Location = New System.Drawing.Point(18, 40)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(99, 13)
			Me.label2.TabIndex = 3
			Me.label2.Text = "Order Amount Rule: "
			' 
			' icbSalesPerson
			' 
			Me.icbSalesPerson.EditValue = "{0} {1}"
			Me.icbSalesPerson.Location = New System.Drawing.Point(126, 11)
			Me.icbSalesPerson.Name = "icbSalesPerson"
			Me.icbSalesPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbSalesPerson.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("First Name + Last Name", "{0} {1}", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Last Name + First Name", "{1} {0}", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Last Name only", "{1}", -1)})
			Me.icbSalesPerson.Size = New System.Drawing.Size(172, 20)
			Me.icbSalesPerson.TabIndex = 2
'			Me.icbSalesPerson.SelectedIndexChanged += New System.EventHandler(Me.icb_SelectedIndexChanged);
			' 
			' label1
			' 
			Me.label1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label1.Appearance.Options.UseBackColor = True
			Me.label1.Location = New System.Drawing.Point(18, 14)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(105, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Sales Person Format: "
			' 
			' paddingPanel
			' 
			Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.paddingPanel.Location = New System.Drawing.Point(0, 64)
			Me.paddingPanel.Name = "paddingPanel"
			Me.paddingPanel.Size = New System.Drawing.Size(706, 8)
			Me.paddingPanel.TabIndex = 10
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldQuarter, Me.fieldSalesPerson, Me.fieldExtendedPrice, Me.fieldOrderAmount, Me.fieldPercent, Me.fieldBonusAmount})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 72)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsView.ShowColumnHeaders = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(706, 344)
			Me.pivotGridControl1.TabIndex = 11
'			Me.pivotGridControl1.FieldAreaChanged += New DevExpress.XtraPivotGrid.PivotFieldEventHandler(Me.pivotGridControl1_FieldAreaChanged);
'			Me.pivotGridControl1.CustomUnboundFieldData += New DevExpress.XtraPivotGrid.CustomFieldDataEventHandler(Me.pivotGridControl1_CustomUnboundFieldData);
'			Me.pivotGridControl1.CustomCellDisplayText += New DevExpress.XtraPivotGrid.PivotCellDisplayTextEventHandler(Me.pivotGridControl1_CustomCellDisplayText);
			' 
			' fieldQuarter
			' 
			Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldQuarter.AreaIndex = 1
			Me.fieldQuarter.Caption = "Quarter"
			Me.fieldQuarter.FieldName = "OrderDate"
			Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldQuarter.Name = "fieldQuarter"
			Me.fieldQuarter.TotalValueFormat.FormatString = "Qtr {0} Total"
			Me.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
			Me.fieldQuarter.ValueFormat.FormatString = "Qtr {0}"
			Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldQuarter.Width = 140
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.fieldSalesPerson.Appearance.Header.Options.UseFont = True
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson.AreaIndex = 0
			Me.fieldSalesPerson.Caption = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			Me.fieldSalesPerson.UnboundFieldName = "fieldSalesPerson"
			Me.fieldSalesPerson.UnboundType = DevExpress.Data.UnboundColumnType.String
			Me.fieldSalesPerson.Width = 219
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.AreaIndex = 0
			Me.fieldExtendedPrice.CellFormat.FormatString = "c"
			Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			Me.fieldExtendedPrice.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False
			' 
			' fieldOrderAmount
			' 
			Me.fieldOrderAmount.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.fieldOrderAmount.Appearance.Header.Options.UseFont = True
			Me.fieldOrderAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldOrderAmount.AreaIndex = 0
			Me.fieldOrderAmount.Caption = "Order Amount"
			Me.fieldOrderAmount.CellFormat.FormatString = "c"
			Me.fieldOrderAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldOrderAmount.Name = "fieldOrderAmount"
			Me.fieldOrderAmount.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False
			Me.fieldOrderAmount.UnboundFieldName = "fieldOrderAmount"
			Me.fieldOrderAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			' 
			' fieldPercent
			' 
			Me.fieldPercent.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic)
			Me.fieldPercent.Appearance.Header.Options.UseFont = True
			Me.fieldPercent.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldPercent.AreaIndex = 1
			Me.fieldPercent.Caption = "Percent of OrderTotal"
			Me.fieldPercent.Name = "fieldPercent"
			Me.fieldPercent.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False
			Me.fieldPercent.Options.AllowFilterBySummary = DevExpress.Utils.DefaultBoolean.False
			Me.fieldPercent.Width = 131
			' 
			' fieldBonusAmount
			' 
			Me.fieldBonusAmount.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic)
			Me.fieldBonusAmount.Appearance.Header.Options.UseFont = True
			Me.fieldBonusAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldBonusAmount.AreaIndex = 2
			Me.fieldBonusAmount.Caption = "Bonus Amount"
			Me.fieldBonusAmount.Name = "fieldBonusAmount"
			Me.fieldBonusAmount.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False
			Me.fieldBonusAmount.Options.AllowFilterBySummary = DevExpress.Utils.DefaultBoolean.False
			' 
			' UnboundColumns
			' 
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.paddingPanel)
			Me.Controls.Add(Me.panelControl1)
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "UnboundColumns"
			Me.Size = New System.Drawing.Size(706, 416)
'			Me.Load += New System.EventHandler(Me.UnboundColumns_Load);
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.icbOrderAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbSalesPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbSalesPerson As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents icbOrderAmount As DevExpress.XtraEditors.ImageComboBoxEdit
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private paddingPanel As DevExpress.XtraEditors.PanelControl
		Private WithEvents pivotGridControl1 As PivotGridControl
		Private fieldQuarter As PivotGridField
		Private fieldSalesPerson As PivotGridField
		Private fieldExtendedPrice As PivotGridField
		Private fieldOrderAmount As PivotGridField
		Private fieldPercent As PivotGridField
		Private fieldBonusAmount As PivotGridField

	End Class
End Namespace
