Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class TotalsLocation
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
			Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.rowTotalsLocations = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.columnTotalsLocations = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.rowTotalsLocations.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.columnTotalsLocations.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
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
			' fieldQuarter
			' 
			Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldQuarter.AreaIndex = 1
			Me.fieldQuarter.Caption = "Quarter"
			Me.fieldQuarter.FieldName = "OrderDate"
			Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldQuarter.Name = "fieldQuarter"
			Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
			Me.fieldQuarter.ValueFormat.FormatString = "Qtr {0}"
			Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' dsSalesPerson1
			' 
			Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
			Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.rowTotalsLocations)
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Controls.Add(Me.columnTotalsLocations)
			Me.panelControl1.Controls.Add(Me.label2)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(708, 43)
			Me.panelControl1.TabIndex = 2
			' 
			' rowTotalsLocations
			' 
			Me.rowTotalsLocations.EditValue = "imageComboBoxEdit1"
			Me.rowTotalsLocations.Location = New System.Drawing.Point(379, 12)
			Me.rowTotalsLocations.Name = "rowTotalsLocations"
			Me.rowTotalsLocations.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.rowTotalsLocations.Size = New System.Drawing.Size(116, 20)
			Me.rowTotalsLocations.TabIndex = 7
'			Me.rowTotalsLocations.SelectedIndexChanged += New System.EventHandler(Me.rowTotalsLocation_SelectedIndexChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.labelControl1.Appearance.Options.UseBackColor = True
			Me.labelControl1.Location = New System.Drawing.Point(270, 15)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(103, 13)
			Me.labelControl1.TabIndex = 8
			Me.labelControl1.Text = "Row Totals Location: "
			' 
			' columnTotalsLocations
			' 
			Me.columnTotalsLocations.EditValue = "imageComboBoxEdit1"
			Me.columnTotalsLocations.Location = New System.Drawing.Point(137, 12)
			Me.columnTotalsLocations.Name = "columnTotalsLocations"
			Me.columnTotalsLocations.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.columnTotalsLocations.Size = New System.Drawing.Size(116, 20)
			Me.columnTotalsLocations.TabIndex = 5
'			Me.columnTotalsLocations.SelectedIndexChanged += New System.EventHandler(Me.icbTotalsLocations_SelectedIndexChanged);
			' 
			' label2
			' 
			Me.label2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label2.Appearance.Options.UseBackColor = True
			Me.label2.Location = New System.Drawing.Point(14, 15)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(117, 13)
			Me.label2.TabIndex = 6
			Me.label2.Text = "Column Totals Location: "
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName, Me.fieldQuantity, Me.fieldSalesPerson, Me.fieldYear, Me.fieldQuarter})
			pivotGridGroup1.Fields.Add(Me.fieldYear)
			pivotGridGroup1.Fields.Add(Me.fieldQuarter)
			pivotGridGroup1.Hierarchy = Nothing
			Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 51)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsView.ShowColumnGrandTotals = False
			Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
			Me.pivotGridControl1.OptionsView.ShowTotalsForSingleValues = True
			Me.pivotGridControl1.Size = New System.Drawing.Size(708, 365)
			Me.pivotGridControl1.TabIndex = 10
'			Me.pivotGridControl1.FieldValueImageIndex += New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(Me.pivotGridControl1_FieldValueImageIndex);
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 1
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			Me.fieldCategoryName.Width = 140
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 0
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.CellFormat.FormatString = "#.##"
			Me.fieldQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			Me.fieldQuantity.ValueFormat.FormatString = "#.##"
			Me.fieldQuantity.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson.AreaIndex = 0
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			Me.fieldSalesPerson.Width = 140
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 43)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(708, 8)
			Me.panelControl2.TabIndex = 13
			' 
			' TotalsLocation
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "TotalsLocation"
			Me.Size = New System.Drawing.Size(708, 416)
'			Me.Load += New System.EventHandler(Me.TotalsLocation_Load);
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.rowTotalsLocations.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.columnTotalsLocations.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents columnTotalsLocations As DevExpress.XtraEditors.ImageComboBoxEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents pivotGridControl1 As PivotGridControl
		Private fieldCategoryName As PivotGridField
		Private fieldQuantity As PivotGridField
		Private fieldSalesPerson As PivotGridField
		Private fieldYear As PivotGridField
		Private fieldQuarter As PivotGridField
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private WithEvents rowTotalsLocations As DevExpress.XtraEditors.ImageComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
