Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class SortBySummary
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
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDiscount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.icbField = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.icbField.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
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
			Me.fieldQuantity.AreaIndex = 1
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			' 
			' fieldDiscount
			' 
			Me.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldDiscount.AreaIndex = 2
			Me.fieldDiscount.Caption = "Discount (Avg)"
			Me.fieldDiscount.CellFormat.FormatString = "p"
			Me.fieldDiscount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldDiscount.FieldName = "Discount"
			Me.fieldDiscount.Name = "fieldDiscount"
			Me.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
			' 
			' dsSalesPerson1
			' 
			Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
			Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.icbField)
			Me.panelControl1.Controls.Add(Me.label2)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 8)
			Me.panelControl1.Size = New System.Drawing.Size(707, 43)
			Me.panelControl1.TabIndex = 1
			' 
			' icbField
			' 
			Me.icbField.EditValue = "imageComboBoxEdit1"
			Me.icbField.Location = New System.Drawing.Point(174, 13)
			Me.icbField.Name = "icbField"
			Me.icbField.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbField.Size = New System.Drawing.Size(164, 20)
			Me.icbField.TabIndex = 5
'			Me.icbField.SelectedIndexChanged += New System.EventHandler(Me.icbField_SelectedIndexChanged);
			' 
			' label2
			' 
			Me.label2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label2.Location = New System.Drawing.Point(14, 16)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(158, 13)
			Me.label2.TabIndex = 6
			Me.label2.Text = "Sort the ""Sales Person"" Field by: "
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 43)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(707, 8)
			Me.panelControl2.TabIndex = 12
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldQuarter, Me.fieldSalesPerson, Me.fieldExtendedPrice, Me.fieldYear, Me.fieldQuantity, Me.fieldDiscount})
			pivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
			pivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = True
			pivotGridStyleFormatCondition1.ApplyToCustomTotalCell = False
			pivotGridStyleFormatCondition1.ApplyToGrandTotalCell = False
			pivotGridStyleFormatCondition1.ApplyToTotalCell = False
			pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
			pivotGridStyleFormatCondition1.Field = Me.fieldExtendedPrice
			pivotGridStyleFormatCondition1.FieldName = "fieldExtendedPrice"
			pivotGridStyleFormatCondition1.Value1 = 10000
			pivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue
			pivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = True
			pivotGridStyleFormatCondition2.ApplyToCustomTotalCell = False
			pivotGridStyleFormatCondition2.ApplyToGrandTotalCell = False
			pivotGridStyleFormatCondition2.ApplyToTotalCell = False
			pivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
			pivotGridStyleFormatCondition2.Field = Me.fieldQuantity
			pivotGridStyleFormatCondition2.FieldName = "fieldQuantity"
			pivotGridStyleFormatCondition2.Value1 = 350
			pivotGridStyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Green
			pivotGridStyleFormatCondition3.Appearance.Options.UseForeColor = True
			pivotGridStyleFormatCondition3.ApplyToCustomTotalCell = False
			pivotGridStyleFormatCondition3.ApplyToGrandTotalCell = False
			pivotGridStyleFormatCondition3.ApplyToTotalCell = False
			pivotGridStyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
			pivotGridStyleFormatCondition3.Field = Me.fieldDiscount
			pivotGridStyleFormatCondition3.FieldName = "fieldDiscount"
			pivotGridStyleFormatCondition3.Value1 = 0.1F
			Me.pivotGridControl1.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() { pivotGridStyleFormatCondition1, pivotGridStyleFormatCondition2, pivotGridStyleFormatCondition3})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 51)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsView.ShowColumnHeaders = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(707, 365)
			Me.pivotGridControl1.TabIndex = 13
'			Me.pivotGridControl1.CustomDrawCell += New DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(Me.pivotGridControl1_CustomDrawCell);
			' 
			' fieldQuarter
			' 
			Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldQuarter.AreaIndex = 0
			Me.fieldQuarter.Caption = "Order Month"
			Me.fieldQuarter.FieldName = "OrderDate"
			Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.fieldQuarter.Name = "fieldQuarter"
			Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
			Me.fieldQuarter.Width = 120
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.fieldSalesPerson.Appearance.Header.Options.UseFont = True
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson.AreaIndex = 1
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			Me.fieldSalesPerson.SortBySummaryInfo.Field = Me.fieldExtendedPrice
			Me.fieldSalesPerson.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
			Me.fieldSalesPerson.Width = 150
			' 
			' fieldYear
			' 
			Me.fieldYear.AreaIndex = 0
			Me.fieldYear.Caption = "Order Year"
			Me.fieldYear.FieldName = "OrderDate"
			Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldYear.Name = "fieldYear"
			Me.fieldYear.UnboundFieldName = "fieldYear"
			' 
			' SortBySummary
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "SortBySummary"
			Me.Size = New System.Drawing.Size(707, 416)
'			Me.Load += New System.EventHandler(Me.SortBySummary_Load);
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.icbField.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbField As DevExpress.XtraEditors.ImageComboBoxEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private WithEvents pivotGridControl1 As PivotGridControl
		Private fieldQuarter As PivotGridField
		Private fieldSalesPerson As PivotGridField
		Private fieldExtendedPrice As PivotGridField
		Private fieldYear As PivotGridField
		Private fieldQuantity As PivotGridField
		Private fieldDiscount As PivotGridField

	End Class
End Namespace
