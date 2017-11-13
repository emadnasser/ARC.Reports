Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class Groups
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
			Dim pivotGridGroup2 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Dim pivotGridGroup3 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate2 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDiscount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.sbExpandCollapse = New DevExpress.XtraEditors.SimpleButton()
			Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 0
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			Me.fieldCategoryName.Width = 150
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
			' fieldOrderDate
			' 
			Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDate.AreaIndex = 0
			Me.fieldOrderDate.Caption = "Year"
			Me.fieldOrderDate.FieldName = "OrderDate"
			Me.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderDate.Name = "fieldOrderDate"
			Me.fieldOrderDate.UnboundFieldName = "fieldOrderDate"
			' 
			' fieldOrderDate1
			' 
			Me.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDate1.AreaIndex = 1
			Me.fieldOrderDate1.Caption = "Quarter"
			Me.fieldOrderDate1.FieldName = "OrderDate"
			Me.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldOrderDate1.Name = "fieldOrderDate1"
			Me.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1"
			Me.fieldOrderDate1.ValueFormat.FormatString = "Quarter {0}"
			Me.fieldOrderDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' fieldOrderDate2
			' 
			Me.fieldOrderDate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDate2.AreaIndex = 2
			Me.fieldOrderDate2.Caption = "Month"
			Me.fieldOrderDate2.FieldName = "OrderDate"
			Me.fieldOrderDate2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.fieldOrderDate2.Name = "fieldOrderDate2"
			Me.fieldOrderDate2.UnboundFieldName = "fieldOrderDate2"
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 0
			Me.fieldExtendedPrice.Caption = "Order Amount"
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 1
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			' 
			' fieldDiscount
			' 
			Me.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldDiscount.AreaIndex = 2
			Me.fieldDiscount.Caption = "Discount (Avr)"
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
			Me.panelControl1.Controls.Add(Me.sbExpandCollapse)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Padding = New System.Windows.Forms.Padding(2)
			Me.panelControl1.Size = New System.Drawing.Size(704, 44)
			Me.panelControl1.TabIndex = 1
			' 
			' sbExpandCollapse
			' 
			Me.sbExpandCollapse.Location = New System.Drawing.Point(12, 10)
			Me.sbExpandCollapse.Name = "sbExpandCollapse"
			Me.sbExpandCollapse.Size = New System.Drawing.Size(120, 24)
			Me.sbExpandCollapse.TabIndex = 0
			Me.sbExpandCollapse.Text = "Expand All Groups"
'			Me.sbExpandCollapse.Click += New System.EventHandler(Me.sbExpand_Click);
			' 
			' paddingPanel
			' 
			Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.paddingPanel.Location = New System.Drawing.Point(0, 44)
			Me.paddingPanel.Name = "paddingPanel"
			Me.paddingPanel.Size = New System.Drawing.Size(704, 8)
			Me.paddingPanel.TabIndex = 11
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName, Me.fieldProductName, Me.fieldQuantity, Me.fieldExtendedPrice, Me.fieldDiscount, Me.fieldOrderDate, Me.fieldOrderDate1, Me.fieldOrderDate2})
			pivotGridGroup1.Fields.Add(Me.fieldCategoryName)
			pivotGridGroup1.Fields.Add(Me.fieldProductName)
			pivotGridGroup1.Hierarchy = Nothing
			pivotGridGroup2.Fields.Add(Me.fieldOrderDate)
			pivotGridGroup2.Fields.Add(Me.fieldOrderDate1)
			pivotGridGroup2.Fields.Add(Me.fieldOrderDate2)
			pivotGridGroup2.Hierarchy = Nothing
			pivotGridGroup3.Fields.Add(Me.fieldExtendedPrice)
			pivotGridGroup3.Fields.Add(Me.fieldQuantity)
			pivotGridGroup3.Fields.Add(Me.fieldDiscount)
			pivotGridGroup3.Hierarchy = Nothing
			Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1, pivotGridGroup2, pivotGridGroup3})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 52)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(704, 364)
			Me.pivotGridControl1.TabIndex = 12
'			Me.pivotGridControl1.FieldValueImageIndex += New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(Me.pivotGridControl1_FieldValueImageIndex);
'			Me.pivotGridControl1.CustomDrawFieldHeader += New DevExpress.XtraPivotGrid.PivotCustomDrawFieldHeaderEventHandler(Me.pivotGridControl1_CustomDrawFieldHeader);
			' 
			' Groups
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.paddingPanel)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Groups"
			Me.Size = New System.Drawing.Size(704, 416)
'			Me.Load += New System.EventHandler(Me.Groups_Load);
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents sbExpandCollapse As DevExpress.XtraEditors.SimpleButton
		Private components As System.ComponentModel.IContainer = Nothing
		Private paddingPanel As DevExpress.XtraEditors.PanelControl
		Private WithEvents pivotGridControl1 As PivotGridControl
		Private fieldCategoryName As PivotGridField
		Private fieldProductName As PivotGridField
		Private fieldQuantity As PivotGridField
		Private fieldExtendedPrice As PivotGridField
		Private fieldDiscount As PivotGridField
		Private fieldOrderDate As PivotGridField
		Private fieldOrderDate1 As PivotGridField
		Private fieldOrderDate2 As PivotGridField

	End Class
End Namespace
