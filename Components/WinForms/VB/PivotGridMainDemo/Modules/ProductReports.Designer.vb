Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class ProductReports
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
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.rgReport = New DevExpress.XtraEditors.RadioGroup()
			Me.dsReports1 = New DevExpress.XtraPivotGrid.Demos.dsReports()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldShippedYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductSales = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldShippedQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldShippedMonth = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldAverageSale = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldMinimumSale = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pcCategories = New DevExpress.XtraEditors.PanelControl()
			Me.ceCategories = New DevExpress.XtraEditors.CheckEdit()
			Me.pcDate = New DevExpress.XtraEditors.PanelControl()
			Me.cbeDate = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.pcDrillDown = New DevExpress.XtraEditors.PanelControl()
			Me.ceDrillDown = New DevExpress.XtraEditors.CheckEdit()
			Me.controlPanel = New DevExpress.XtraEditors.PanelControl()
			Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
			Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.rgReport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsReports1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcCategories, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcCategories.SuspendLayout()
			CType(Me.ceCategories.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcDate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcDate.SuspendLayout()
			CType(Me.cbeDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcDrillDown, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcDrillDown.SuspendLayout()
			CType(Me.ceDrillDown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.controlPanel.SuspendLayout()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mainPanel.SuspendLayout()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.rgReport)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(2, 2)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Padding = New System.Windows.Forms.Padding(4)
			Me.panelControl1.Size = New System.Drawing.Size(699, 61)
			Me.panelControl1.TabIndex = 2
			' 
			' rgReport
			' 
			Me.rgReport.Location = New System.Drawing.Point(11, 7)
			Me.rgReport.Name = "rgReport"
			Me.rgReport.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.rgReport.Properties.Appearance.Options.UseBackColor = True
			Me.rgReport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.rgReport.Properties.Columns = 3
			Me.rgReport.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Category Sales"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Product Sales"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Interval Grouping"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Multiple Subtotals"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Average Sales"), New DevExpress.XtraEditors.Controls.RadioGroupItem(5, "Top 3 Products")})
			Me.rgReport.Size = New System.Drawing.Size(400, 52)
			Me.rgReport.TabIndex = 0
'			Me.rgReport.SelectedIndexChanged += New System.EventHandler(Me.rgReport_SelectedIndexChanged);
			' 
			' dsReports1
			' 
			Me.dsReports1.DataSetName = "dsReports"
			Me.dsReports1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dsReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.pivotGridControl1.DataSource = Me.dsReports1.ProductReports
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName, Me.fieldProductName, Me.fieldShippedYear, Me.fieldProductSales, Me.fieldShippedQuarter, Me.fieldShippedMonth, Me.fieldAverageSale, Me.fieldMinimumSale})
			pivotGridGroup1.Hierarchy = Nothing
			Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(703, 251)
			Me.pivotGridControl1.TabIndex = 3
'			Me.pivotGridControl1.FieldValueImageIndex += New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(Me.pivotGridControl1_FieldValueImageIndex);
'			Me.pivotGridControl1.CellDoubleClick += New DevExpress.XtraPivotGrid.PivotCellEventHandler(Me.pivotGridControl1_CellDoubleClick);
'			Me.pivotGridControl1.FieldValueDisplayText += New DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(Me.pivotGridControl1_FieldValueDisplayText);
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 0
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			Me.fieldCategoryName.Width = 125
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			Me.fieldProductName.Width = 171
			' 
			' fieldShippedYear
			' 
			Me.fieldShippedYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldShippedYear.AreaIndex = 0
			Me.fieldShippedYear.Caption = "Shipped Year"
			Me.fieldShippedYear.FieldName = "ShippedDate"
			Me.fieldShippedYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldShippedYear.Name = "fieldShippedYear"
			Me.fieldShippedYear.UnboundFieldName = "fieldShippedYear"
			' 
			' fieldProductSales
			' 
			Me.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldProductSales.AreaIndex = 0
			Me.fieldProductSales.Caption = "Product Sales"
			Me.fieldProductSales.CellFormat.FormatString = "c"
			Me.fieldProductSales.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldProductSales.FieldName = "ProductSales"
			Me.fieldProductSales.Name = "fieldProductSales"
			Me.fieldProductSales.Width = 130
			' 
			' fieldShippedQuarter
			' 
			Me.fieldShippedQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldShippedQuarter.AreaIndex = 1
			Me.fieldShippedQuarter.Caption = "Shipped Quarter"
			Me.fieldShippedQuarter.FieldName = "ShippedDate"
			Me.fieldShippedQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldShippedQuarter.Name = "fieldShippedQuarter"
			Me.fieldShippedQuarter.UnboundFieldName = "fieldShippedQuarter"
			Me.fieldShippedQuarter.ValueFormat.FormatString = "Qtr {0}"
			Me.fieldShippedQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldShippedQuarter.Width = 130
			' 
			' fieldShippedMonth
			' 
			Me.fieldShippedMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldShippedMonth.Caption = "Shipped Month"
			Me.fieldShippedMonth.FieldName = "ShippedDate"
			Me.fieldShippedMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.fieldShippedMonth.Name = "fieldShippedMonth"
			Me.fieldShippedMonth.UnboundFieldName = "fieldShippedMonth"
			Me.fieldShippedMonth.Visible = False
			Me.fieldShippedMonth.Width = 120
			' 
			' fieldAverageSale
			' 
			Me.fieldAverageSale.Caption = "Average Sale"
			Me.fieldAverageSale.CellFormat.FormatString = "c"
			Me.fieldAverageSale.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldAverageSale.FieldName = "ProductSales"
			Me.fieldAverageSale.Name = "fieldAverageSale"
			Me.fieldAverageSale.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
			Me.fieldAverageSale.Visible = False
			' 
			' fieldMinimumSale
			' 
			Me.fieldMinimumSale.Caption = "Minimum Sale"
			Me.fieldMinimumSale.CellFormat.FormatString = "c"
			Me.fieldMinimumSale.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldMinimumSale.FieldName = "ProductSales"
			Me.fieldMinimumSale.Name = "fieldMinimumSale"
			Me.fieldMinimumSale.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min
			Me.fieldMinimumSale.Visible = False
			' 
			' pcCategories
			' 
			Me.pcCategories.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcCategories.Controls.Add(Me.ceCategories)
			Me.pcCategories.Dock = System.Windows.Forms.DockStyle.Top
			Me.pcCategories.Location = New System.Drawing.Point(2, 91)
			Me.pcCategories.Name = "pcCategories"
			Me.pcCategories.Padding = New System.Windows.Forms.Padding(4)
			Me.pcCategories.Size = New System.Drawing.Size(699, 28)
			Me.pcCategories.TabIndex = 4
			' 
			' ceCategories
			' 
			Me.ceCategories.Location = New System.Drawing.Point(13, 4)
			Me.ceCategories.Name = "ceCategories"
			Me.ceCategories.Properties.Caption = "Show Categories"
			Me.ceCategories.Size = New System.Drawing.Size(132, 19)
			Me.ceCategories.TabIndex = 0
'			Me.ceCategories.CheckedChanged += New System.EventHandler(Me.ceCategories_CheckedChanged);
			' 
			' pcDate
			' 
			Me.pcDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcDate.Controls.Add(Me.cbeDate)
			Me.pcDate.Controls.Add(Me.label1)
			Me.pcDate.Dock = System.Windows.Forms.DockStyle.Top
			Me.pcDate.Location = New System.Drawing.Point(2, 119)
			Me.pcDate.Name = "pcDate"
			Me.pcDate.Padding = New System.Windows.Forms.Padding(4)
			Me.pcDate.Size = New System.Drawing.Size(699, 28)
			Me.pcDate.TabIndex = 5
			' 
			' cbeDate
			' 
			Me.cbeDate.EditValue = ""
			Me.cbeDate.Location = New System.Drawing.Point(101, 4)
			Me.cbeDate.Name = "cbeDate"
			Me.cbeDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeDate.Properties.Items.AddRange(New Object() { "by Years", "by Quarters", "by Months", "by Years, Quarters, Months"})
			Me.cbeDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeDate.Size = New System.Drawing.Size(196, 20)
			Me.cbeDate.TabIndex = 3
'			Me.cbeDate.SelectedIndexChanged += New System.EventHandler(Me.cbeDate_SelectedIndexChanged);
			' 
			' label1
			' 
			Me.label1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label1.Appearance.Options.UseBackColor = True
			Me.label1.Location = New System.Drawing.Point(14, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(86, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Grouping Layout: "
			' 
			' pcDrillDown
			' 
			Me.pcDrillDown.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcDrillDown.Controls.Add(Me.ceDrillDown)
			Me.pcDrillDown.Dock = System.Windows.Forms.DockStyle.Top
			Me.pcDrillDown.Location = New System.Drawing.Point(2, 63)
			Me.pcDrillDown.Name = "pcDrillDown"
			Me.pcDrillDown.Padding = New System.Windows.Forms.Padding(4)
			Me.pcDrillDown.Size = New System.Drawing.Size(699, 28)
			Me.pcDrillDown.TabIndex = 11
			' 
			' ceDrillDown
			' 
			Me.ceDrillDown.EditValue = True
			Me.ceDrillDown.Location = New System.Drawing.Point(13, 4)
			Me.ceDrillDown.Name = "ceDrillDown"
			Me.ceDrillDown.Properties.Caption = "Show Drill Down Form on Cell Double Click"
			Me.ceDrillDown.Size = New System.Drawing.Size(308, 19)
			Me.ceDrillDown.TabIndex = 0
			' 
			' controlPanel
			' 
			Me.controlPanel.AutoSize = True
			Me.controlPanel.Controls.Add(Me.pcDate)
			Me.controlPanel.Controls.Add(Me.pcCategories)
			Me.controlPanel.Controls.Add(Me.pcDrillDown)
			Me.controlPanel.Controls.Add(Me.panelControl1)
			Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.controlPanel.Location = New System.Drawing.Point(0, 0)
			Me.controlPanel.Name = "controlPanel"
			Me.controlPanel.Size = New System.Drawing.Size(703, 149)
			Me.controlPanel.TabIndex = 12
			' 
			' mainPanel
			' 
			Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.mainPanel.Controls.Add(Me.pivotGridControl1)
			Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mainPanel.Location = New System.Drawing.Point(0, 157)
			Me.mainPanel.Name = "mainPanel"
			Me.mainPanel.Size = New System.Drawing.Size(703, 251)
			Me.mainPanel.TabIndex = 13
			' 
			' paddingPanel
			' 
			Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.paddingPanel.Location = New System.Drawing.Point(0, 149)
			Me.paddingPanel.Name = "paddingPanel"
			Me.paddingPanel.Size = New System.Drawing.Size(703, 8)
			Me.paddingPanel.TabIndex = 14
			' 
			' ProductReports
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.mainPanel)
			Me.Controls.Add(Me.paddingPanel)
			Me.Controls.Add(Me.controlPanel)
			Me.Name = "ProductReports"
			Me.Size = New System.Drawing.Size(703, 408)
'			Me.Load += New System.EventHandler(Me.ProductReports_Load);
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.rgReport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsReports1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcCategories, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcCategories.ResumeLayout(False)
			CType(Me.ceCategories.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcDate, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcDate.ResumeLayout(False)
			Me.pcDate.PerformLayout()
			CType(Me.cbeDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcDrillDown, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcDrillDown.ResumeLayout(False)
			CType(Me.ceDrillDown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.controlPanel.ResumeLayout(False)
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mainPanel.ResumeLayout(False)
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private dsReports1 As DevExpress.XtraPivotGrid.Demos.dsReports
		Private WithEvents rgReport As DevExpress.XtraEditors.RadioGroup
		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldShippedQuarter As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldShippedYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductSales As DevExpress.XtraPivotGrid.PivotGridField
		Private pcCategories As DevExpress.XtraEditors.PanelControl
		Private WithEvents ceCategories As DevExpress.XtraEditors.CheckEdit
		Private pcDate As DevExpress.XtraEditors.PanelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbeDate As DevExpress.XtraEditors.ComboBoxEdit
		Private fieldShippedMonth As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldAverageSale As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldMinimumSale As DevExpress.XtraPivotGrid.PivotGridField
		Private pcDrillDown As DevExpress.XtraEditors.PanelControl
		Private ceDrillDown As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private controlPanel As DevExpress.XtraEditors.PanelControl
		Private mainPanel As DevExpress.XtraEditors.PanelControl
		Private paddingPanel As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
