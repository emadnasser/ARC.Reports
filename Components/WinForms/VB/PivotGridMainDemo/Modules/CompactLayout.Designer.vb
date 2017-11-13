Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class CompactLayout
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
			Me.components = New System.ComponentModel.Container()
			Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.groupLayout = New DevExpress.XtraEditors.RadioGroup()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.separator2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mainPanel.SuspendLayout()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.groupLayout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.separator2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' mainPanel
			' 
			Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.mainPanel.Controls.Add(Me.splitContainerControl1)
			Me.mainPanel.Controls.Add(Me.separator2)
			Me.mainPanel.Controls.Add(Me.panelControl1)
			Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mainPanel.Location = New System.Drawing.Point(0, 0)
			Me.mainPanel.Name = "mainPanel"
			Me.mainPanel.Size = New System.Drawing.Size(702, 408)
			Me.mainPanel.TabIndex = 11
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 48)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.pivotGridControl1)
			Me.splitContainerControl1.Panel2.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(702, 360)
			Me.splitContainerControl1.SplitterPosition = 240
			Me.splitContainerControl1.TabIndex = 4
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.salesPersonBindingSource
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldSalesPerson, Me.fieldCategoryName, Me.fieldQuantity, Me.fieldOrderYear, Me.fieldOrderQuarter})
			Me.pivotGridControl1.Location = New System.Drawing.Point(4, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsCustomization.CustomizationFormLayout = DevExpress.XtraPivotGrid.Customization.CustomizationFormLayout.BottomPanelOnly2by2
			Me.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
			Me.pivotGridControl1.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree
			Me.pivotGridControl1.OptionsView.ShowColumnHeaders = False
			Me.pivotGridControl1.OptionsView.ShowDataHeaders = False
			Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
			Me.pivotGridControl1.OptionsView.ShowRowHeaders = False
			Me.pivotGridControl1.OptionsView.ShowTotalsForSingleValues = True
			Me.pivotGridControl1.Size = New System.Drawing.Size(452, 360)
			Me.pivotGridControl1.TabIndex = 5
'			Me.pivotGridControl1.FieldValueImageIndex += New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(Me.pivotGridControl1_FieldValueImageIndex);
			' 
			' salesPersonBindingSource
			' 
			Me.salesPersonBindingSource.DataMember = "SalesPerson"
			Me.salesPersonBindingSource.DataSource = Me.dsSalesPerson1
			' 
			' dsSalesPerson1
			' 
			Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
			Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson.AreaIndex = 0
			Me.fieldSalesPerson.Caption = "Customer"
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			Me.fieldSalesPerson.Width = 150
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 1
			Me.fieldCategoryName.Caption = "Product Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			Me.fieldCategoryName.Width = 186
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 0
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			Me.fieldQuantity.Width = 130
			' 
			' fieldOrderYear
			' 
			Me.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldOrderYear.AreaIndex = 2
			Me.fieldOrderYear.Caption = "Order Year"
			Me.fieldOrderYear.FieldName = "OrderDate"
			Me.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderYear.Name = "fieldOrderYear"
			Me.fieldOrderYear.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
			Me.fieldOrderYear.UnboundFieldName = "fieldOrderYear"
			' 
			' fieldOrderQuarter
			' 
			Me.fieldOrderQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldOrderQuarter.AreaIndex = 3
			Me.fieldOrderQuarter.Caption = "Order Quarter"
			Me.fieldOrderQuarter.FieldName = "OrderDate"
			Me.fieldOrderQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldOrderQuarter.Name = "fieldOrderQuarter"
			Me.fieldOrderQuarter.UnboundFieldName = "fieldOrderQuarter"
			Me.fieldOrderQuarter.ValueFormat.FormatString = "Qtr {0}"
			Me.fieldOrderQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.groupLayout)
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(702, 40)
			Me.panelControl1.TabIndex = 5
			' 
			' groupLayout
			' 
			Me.groupLayout.EditValue = True
			Me.groupLayout.Location = New System.Drawing.Point(80, 6)
			Me.groupLayout.Name = "groupLayout"
			Me.groupLayout.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupLayout.Properties.Appearance.Options.UseBackColor = True
			Me.groupLayout.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.groupLayout.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Compact Layout"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Full Layout")})
			Me.groupLayout.Size = New System.Drawing.Size(222, 29)
			Me.groupLayout.TabIndex = 1
'			Me.groupLayout.SelectedIndexChanged += New System.EventHandler(Me.radioGroup1_SelectedIndexChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(10, 14)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(64, 13)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "Pivot Layout:"
			' 
			' separator2
			' 
			Me.separator2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.separator2.Dock = System.Windows.Forms.DockStyle.Top
			Me.separator2.Location = New System.Drawing.Point(0, 40)
			Me.separator2.Name = "separator2"
			Me.separator2.Size = New System.Drawing.Size(702, 8)
			Me.separator2.TabIndex = 14
			' 
			' CompactLayout
			' 
			Me.Controls.Add(Me.mainPanel)
			Me.Name = "CompactLayout"
			Me.Size = New System.Drawing.Size(702, 408)
'			Me.Load += New System.EventHandler(Me.CompactLayout_Load);
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mainPanel.ResumeLayout(False)
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.groupLayout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.separator2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private components As System.ComponentModel.IContainer = Nothing
		Private mainPanel As DevExpress.XtraEditors.PanelControl
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents pivotGridControl1 As PivotGridControl
		Private fieldSalesPerson As PivotGridField
		Private fieldCategoryName As PivotGridField
		Private fieldQuantity As PivotGridField
		Private fieldOrderYear As PivotGridField
		Private fieldOrderQuarter As PivotGridField
		Private salesPersonBindingSource As System.Windows.Forms.BindingSource
		Private dsSalesPerson1 As dsSalesPerson
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents groupLayout As DevExpress.XtraEditors.RadioGroup
		Private separator2 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
