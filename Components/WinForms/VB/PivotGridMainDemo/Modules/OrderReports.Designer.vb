Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class OrderReports
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
			Me.fieldOrderID = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProduct = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldUnitPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDiscount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSum = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.rgReport = New DevExpress.XtraEditors.RadioGroup()
			Me.pcOrder = New DevExpress.XtraEditors.PanelControl()
			Me.cbeOrder = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.dsReports1 = New DevExpress.XtraPivotGrid.Demos.dsReports()
			Me.controlPanel = New DevExpress.XtraEditors.PanelControl()
			Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
			Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.rgReport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcOrder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcOrder.SuspendLayout()
			CType(Me.cbeOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsReports1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.controlPanel.SuspendLayout()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mainPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' fieldOrderID
			' 
			Me.fieldOrderID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldOrderID.AreaIndex = 0
			Me.fieldOrderID.Caption = "Order"
			Me.fieldOrderID.FieldName = "OrderID"
			Me.fieldOrderID.Name = "fieldOrderID"
			Me.fieldOrderID.Width = 105
			' 
			' fieldProduct
			' 
			Me.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProduct.AreaIndex = 1
			Me.fieldProduct.Caption = "Product Name"
			Me.fieldProduct.FieldName = "ProductName"
			Me.fieldProduct.Name = "fieldProduct"
			Me.fieldProduct.Width = 185
			' 
			' fieldUnitPrice
			' 
			Me.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldUnitPrice.AreaIndex = 0
			Me.fieldUnitPrice.Caption = "Unit Price"
			Me.fieldUnitPrice.CellFormat.FormatString = "c"
			Me.fieldUnitPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldUnitPrice.FieldName = "UnitPrice"
			Me.fieldUnitPrice.Name = "fieldUnitPrice"
			Me.fieldUnitPrice.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False
			Me.fieldUnitPrice.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 1
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			Me.fieldQuantity.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False
			' 
			' fieldDiscount
			' 
			Me.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldDiscount.AreaIndex = 2
			Me.fieldDiscount.FieldName = "Discount"
			Me.fieldDiscount.Name = "fieldDiscount"
			Me.fieldDiscount.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False
			Me.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
			Me.fieldDiscount.TotalCellFormat.FormatString = "P"
			Me.fieldDiscount.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldDiscount.Width = 99
			' 
			' fieldSum
			' 
			Me.fieldSum.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldSum.AreaIndex = 3
			Me.fieldSum.CellFormat.FormatString = "c"
			Me.fieldSum.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldSum.FieldName = "Extended Price"
			Me.fieldSum.Name = "fieldSum"
			Me.fieldSum.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False
			Me.fieldSum.Width = 120
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.rgReport)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(2, 2)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Padding = New System.Windows.Forms.Padding(4)
			Me.panelControl1.Size = New System.Drawing.Size(700, 61)
			Me.panelControl1.TabIndex = 2
			' 
			' rgReport
			' 
			Me.rgReport.Location = New System.Drawing.Point(11, 7)
			Me.rgReport.Name = "rgReport"
			Me.rgReport.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.rgReport.Properties.Appearance.Options.UseBackColor = True
			Me.rgReport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.rgReport.Properties.Columns = 2
			Me.rgReport.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Orders"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Orders (filtering)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Quantity"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Average Unit Price")})
			Me.rgReport.Size = New System.Drawing.Size(241, 53)
			Me.rgReport.TabIndex = 0
'			Me.rgReport.SelectedIndexChanged += New System.EventHandler(Me.rgReport_SelectedIndexChanged);
			' 
			' pcOrder
			' 
			Me.pcOrder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcOrder.Controls.Add(Me.cbeOrder)
			Me.pcOrder.Controls.Add(Me.label1)
			Me.pcOrder.Dock = System.Windows.Forms.DockStyle.Top
			Me.pcOrder.Location = New System.Drawing.Point(2, 63)
			Me.pcOrder.Name = "pcOrder"
			Me.pcOrder.Padding = New System.Windows.Forms.Padding(4)
			Me.pcOrder.Size = New System.Drawing.Size(700, 30)
			Me.pcOrder.TabIndex = 3
			' 
			' cbeOrder
			' 
			Me.cbeOrder.EditValue = ""
			Me.cbeOrder.Location = New System.Drawing.Point(63, 4)
			Me.cbeOrder.Name = "cbeOrder"
			Me.cbeOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeOrder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeOrder.Size = New System.Drawing.Size(144, 20)
			Me.cbeOrder.TabIndex = 1
'			Me.cbeOrder.SelectedIndexChanged += New System.EventHandler(Me.cbeOrder_SelectedIndexChanged);
			' 
			' label1
			' 
			Me.label1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label1.Appearance.Options.UseBackColor = True
			Me.label1.Location = New System.Drawing.Point(14, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(46, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "OrderID: "
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.pivotGridControl1.DataSource = Me.dsReports1.OrderReports
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldOrderID, Me.fieldProduct, Me.fieldUnitPrice, Me.fieldQuantity, Me.fieldDiscount, Me.fieldSum})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsView.ShowColumnHeaders = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(704, 305)
			Me.pivotGridControl1.TabIndex = 4
			' 
			' dsReports1
			' 
			Me.dsReports1.DataSetName = "dsReports"
			Me.dsReports1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dsReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' controlPanel
			' 
			Me.controlPanel.AutoSize = True
			Me.controlPanel.Controls.Add(Me.pcOrder)
			Me.controlPanel.Controls.Add(Me.panelControl1)
			Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.controlPanel.Location = New System.Drawing.Point(0, 0)
			Me.controlPanel.Name = "controlPanel"
			Me.controlPanel.Size = New System.Drawing.Size(704, 95)
			Me.controlPanel.TabIndex = 11
			' 
			' paddingPanel
			' 
			Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.paddingPanel.Location = New System.Drawing.Point(0, 95)
			Me.paddingPanel.Name = "paddingPanel"
			Me.paddingPanel.Size = New System.Drawing.Size(704, 8)
			Me.paddingPanel.TabIndex = 12
			' 
			' mainPanel
			' 
			Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.mainPanel.Controls.Add(Me.pivotGridControl1)
			Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mainPanel.Location = New System.Drawing.Point(0, 103)
			Me.mainPanel.Name = "mainPanel"
			Me.mainPanel.Size = New System.Drawing.Size(704, 305)
			Me.mainPanel.TabIndex = 13
			' 
			' OrderReports
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.mainPanel)
			Me.Controls.Add(Me.paddingPanel)
			Me.Controls.Add(Me.controlPanel)
			Me.Name = "OrderReports"
			Me.Size = New System.Drawing.Size(704, 408)
'			Me.Load += New System.EventHandler(Me.OrderReports_Load);
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.rgReport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcOrder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcOrder.ResumeLayout(False)
			Me.pcOrder.PerformLayout()
			CType(Me.cbeOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsReports1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.controlPanel.ResumeLayout(False)
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mainPanel.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private fieldOrderID As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProduct As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldUnitPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDiscount As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSum As DevExpress.XtraPivotGrid.PivotGridField
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private dsReports1 As DevExpress.XtraPivotGrid.Demos.dsReports
		Private WithEvents rgReport As DevExpress.XtraEditors.RadioGroup
		Private pcOrder As DevExpress.XtraEditors.PanelControl
		Private WithEvents cbeOrder As DevExpress.XtraEditors.ComboBoxEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private controlPanel As DevExpress.XtraEditors.PanelControl
		Private paddingPanel As DevExpress.XtraEditors.PanelControl
		Private mainPanel As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
