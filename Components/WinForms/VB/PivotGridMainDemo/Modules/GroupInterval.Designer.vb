Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class GroupInterval
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
			Me.ceProductInterval = New DevExpress.XtraEditors.CheckEdit()
			Me.icbGroupInterval = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.pcSplitter = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldProductAlphabetical = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.ceProductInterval.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbGroupInterval.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
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
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.ceProductInterval)
			Me.panelControl1.Controls.Add(Me.icbGroupInterval)
			Me.panelControl1.Controls.Add(Me.label1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(703, 63)
			Me.panelControl1.TabIndex = 1
			' 
			' ceProductInterval
			' 
			Me.ceProductInterval.Location = New System.Drawing.Point(19, 37)
			Me.ceProductInterval.Name = "ceProductInterval"
			Me.ceProductInterval.Properties.Caption = "Show Product Alphabetically"
			Me.ceProductInterval.Size = New System.Drawing.Size(224, 18)
			Me.ceProductInterval.TabIndex = 3
'			Me.ceProductInterval.CheckedChanged += New System.EventHandler(Me.ceProductInterval_CheckedChanged);
			' 
			' icbGroupInterval
			' 
			Me.icbGroupInterval.EditValue = "imageComboBoxEdit1"
			Me.icbGroupInterval.Location = New System.Drawing.Point(221, 11)
			Me.icbGroupInterval.Name = "icbGroupInterval"
			Me.icbGroupInterval.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbGroupInterval.Size = New System.Drawing.Size(160, 20)
			Me.icbGroupInterval.TabIndex = 2
'			Me.icbGroupInterval.SelectedIndexChanged += New System.EventHandler(Me.icbGroupInterval_SelectedIndexChanged);
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(18, 14)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(197, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Group Interval for the OrderDate field: "
			Me.label1.BackColor = System.Drawing.Color.Transparent
			' 
			' pcSplitter
			' 
			Me.pcSplitter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcSplitter.Dock = System.Windows.Forms.DockStyle.Top
			Me.pcSplitter.Location = New System.Drawing.Point(0, 63)
			Me.pcSplitter.Name = "pcSplitter"
			Me.pcSplitter.Size = New System.Drawing.Size(703, 2)
			Me.pcSplitter.TabIndex = 9
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 65)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(703, 8)
			Me.panelControl2.TabIndex = 14
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldProductAlphabetical, Me.fieldProductName, Me.fieldExtendedPrice, Me.fieldOrderDate})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 73)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(703, 343)
			Me.pivotGridControl1.TabIndex = 15
'			Me.pivotGridControl1.FieldValueDisplayText += New DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(Me.pivotGridControl1_FieldValueDisplayText);
			' 
			' fieldProductAlphabetical
			' 
			Me.fieldProductAlphabetical.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.fieldProductAlphabetical.Appearance.Header.Options.UseFont = True
			Me.fieldProductAlphabetical.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductAlphabetical.AreaIndex = 0
			Me.fieldProductAlphabetical.Caption = "Product Alphabetical"
			Me.fieldProductAlphabetical.FieldName = "ProductName"
			Me.fieldProductAlphabetical.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Alphabetical
			Me.fieldProductAlphabetical.Name = "fieldProductAlphabetical"
			Me.fieldProductAlphabetical.UnboundFieldName = "fieldProductAlphabetical"
			Me.fieldProductAlphabetical.Width = 170
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			Me.fieldProductName.Width = 155
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 0
			Me.fieldExtendedPrice.CellFormat.FormatString = "c"
			Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			' 
			' fieldOrderDate
			' 
			Me.fieldOrderDate.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.fieldOrderDate.Appearance.Header.Options.UseFont = True
			Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDate.AreaIndex = 0
			Me.fieldOrderDate.Caption = "Order Date"
			Me.fieldOrderDate.FieldName = "OrderDate"
			Me.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.fieldOrderDate.Name = "fieldOrderDate"
			Me.fieldOrderDate.UnboundFieldName = "fieldOrderDate"
			' 
			' GroupInterval
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.pcSplitter)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "GroupInterval"
			Me.Size = New System.Drawing.Size(703, 416)
'			Me.Load += New System.EventHandler(Me.GroupInterval_Load);
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.ceProductInterval.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbGroupInterval.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcSplitter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbGroupInterval As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents ceProductInterval As DevExpress.XtraEditors.CheckEdit
		Private pcSplitter As DevExpress.XtraEditors.PanelControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private WithEvents pivotGridControl1 As PivotGridControl
		Private fieldProductAlphabetical As PivotGridField
		Private fieldProductName As PivotGridField
		Private fieldExtendedPrice As PivotGridField
		Private fieldOrderDate As PivotGridField

	End Class
End Namespace
