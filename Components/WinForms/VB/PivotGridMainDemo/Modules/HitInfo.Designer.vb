Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class HitInfo
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
			Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.headersAreaInfo1 = New DevExpress.XtraPivotGrid.Demos.Modules.HeadersAreaInfo()
			Me.valueInfo1 = New DevExpress.XtraPivotGrid.Demos.Modules.ValueInfo()
			Me.cellInfo1 = New DevExpress.XtraPivotGrid.Demos.Modules.CellInfo()
			Me.lbHitTest = New DevExpress.XtraEditors.LabelControl()
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' dsSalesPerson1
			' 
			Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
			Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' paddingPanel
			' 
			Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.paddingPanel.Location = New System.Drawing.Point(0, 86)
			Me.paddingPanel.Name = "paddingPanel"
			Me.paddingPanel.Size = New System.Drawing.Size(706, 8)
			Me.paddingPanel.TabIndex = 10
'			Me.paddingPanel.Paint += New System.Windows.Forms.PaintEventHandler(Me.paddingPanel_Paint);
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName, Me.fieldProductName, Me.fieldSalesPerson, Me.fieldCountry, Me.fieldQuantity, Me.fieldExtendedPrice})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 94)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(706, 322)
			Me.pivotGridControl1.TabIndex = 11
'			Me.pivotGridControl1.FieldValueImageIndex += New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(Me.pivotGridControl1_FieldValueImageIndex);
'			Me.pivotGridControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.pivotGridControl1_MouseMove);
'			Me.pivotGridControl1.MouseLeave += New System.EventHandler(Me.pivotGridControl1_MouseLeave);
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 0
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			Me.fieldCategoryName.Width = 160
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			Me.fieldProductName.Width = 180
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldSalesPerson.AreaIndex = 1
			Me.fieldSalesPerson.Caption = "Sales Person"
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			Me.fieldSalesPerson.Width = 140
			' 
			' fieldCountry
			' 
			Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldCountry.AreaIndex = 0
			Me.fieldCountry.FieldName = "Country"
			Me.fieldCountry.Name = "fieldCountry"
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 0
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 1
			Me.fieldExtendedPrice.Caption = "Order Amount"
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.headersAreaInfo1)
			Me.panelControl1.Controls.Add(Me.valueInfo1)
			Me.panelControl1.Controls.Add(Me.cellInfo1)
			Me.panelControl1.Controls.Add(Me.lbHitTest)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Padding = New System.Windows.Forms.Padding(4)
			Me.panelControl1.Size = New System.Drawing.Size(706, 86)
			Me.panelControl1.TabIndex = 12
			' 
			' headersAreaInfo1
			' 
			Me.headersAreaInfo1.Location = New System.Drawing.Point(272, 2)
			Me.headersAreaInfo1.Name = "headersAreaInfo1"
			Me.headersAreaInfo1.Size = New System.Drawing.Size(134, 75)
			Me.headersAreaInfo1.TabIndex = 9
			' 
			' valueInfo1
			' 
			Me.valueInfo1.Location = New System.Drawing.Point(412, 3)
			Me.valueInfo1.Name = "valueInfo1"
			Me.valueInfo1.Size = New System.Drawing.Size(154, 74)
			Me.valueInfo1.TabIndex = 8
			' 
			' cellInfo1
			' 
			Me.cellInfo1.Location = New System.Drawing.Point(572, 2)
			Me.cellInfo1.Name = "cellInfo1"
			Me.cellInfo1.Size = New System.Drawing.Size(129, 72)
			Me.cellInfo1.TabIndex = 7
			' 
			' lbHitTest
			' 
			Me.lbHitTest.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.lbHitTest.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.lbHitTest.Appearance.Options.UseBackColor = True
			Me.lbHitTest.Appearance.Options.UseFont = True
			Me.lbHitTest.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbHitTest.Dock = System.Windows.Forms.DockStyle.Left
			Me.lbHitTest.Location = New System.Drawing.Point(6, 6)
			Me.lbHitTest.Name = "lbHitTest"
			Me.lbHitTest.Size = New System.Drawing.Size(133, 74)
			Me.lbHitTest.TabIndex = 6
			Me.lbHitTest.Text = "None"
			' 
			' HitInfo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.paddingPanel)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "HitInfo"
			Me.Size = New System.Drawing.Size(706, 416)
'			Me.Load += New System.EventHandler(Me.HitInfo_Load);
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents paddingPanel As DevExpress.XtraEditors.PanelControl
		Private WithEvents pivotGridControl1 As PivotGridControl
		Private fieldCategoryName As PivotGridField
		Private fieldProductName As PivotGridField
		Private fieldSalesPerson As PivotGridField
		Private fieldCountry As PivotGridField
		Private fieldQuantity As PivotGridField
		Private fieldExtendedPrice As PivotGridField
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private headersAreaInfo1 As DevExpress.XtraPivotGrid.Demos.Modules.HeadersAreaInfo
		Private valueInfo1 As DevExpress.XtraPivotGrid.Demos.Modules.ValueInfo
		Private cellInfo1 As DevExpress.XtraPivotGrid.Demos.Modules.CellInfo
		Private lbHitTest As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
