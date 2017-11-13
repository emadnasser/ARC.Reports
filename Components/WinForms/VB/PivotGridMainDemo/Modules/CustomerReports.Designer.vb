Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class CustomerReports
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
			Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.rgReport = New DevExpress.XtraEditors.RadioGroup()
			Me.dsReports1 = New DevExpress.XtraPivotGrid.Demos.dsReports()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldCompanyName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pcYear = New DevExpress.XtraEditors.PanelControl()
			Me.cbeQuarter = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.cbeYear = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.pcSplitter = New DevExpress.XtraEditors.PanelControl()
			Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
			Me.controlPanel = New DevExpress.XtraEditors.PanelControl()
			Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.rgReport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsReports1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcYear, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcYear.SuspendLayout()
			CType(Me.cbeQuarter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mainPanel.SuspendLayout()
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.controlPanel.SuspendLayout()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' fieldOrderYear
			' 
			Me.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderYear.AreaIndex = 0
			Me.fieldOrderYear.Caption = "Order Year"
			Me.fieldOrderYear.FieldName = "OrderDate"
			Me.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderYear.Name = "fieldOrderYear"
			Me.fieldOrderYear.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
			Me.fieldOrderYear.UnboundFieldName = "fieldOrderYear"
			' 
			' fieldOrderQuarter
			' 
			Me.fieldOrderQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderQuarter.AreaIndex = 1
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
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.rgReport)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(2, 2)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Padding = New System.Windows.Forms.Padding(4)
			Me.panelControl1.Size = New System.Drawing.Size(698, 63)
			Me.panelControl1.TabIndex = 2
			' 
			' rgReport
			' 
			Me.rgReport.Location = New System.Drawing.Point(12, 7)
			Me.rgReport.Name = "rgReport"
			Me.rgReport.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.rgReport.Properties.Appearance.Options.UseBackColor = True
			Me.rgReport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.rgReport.Properties.Columns = 2
			Me.rgReport.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Customers"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Products(filtering)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Top 2 Products"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Top 10 Customers")})
			Me.rgReport.Size = New System.Drawing.Size(280, 54)
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
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.dsReports1.CustomerReports
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCompanyName, Me.fieldProductName, Me.fieldProductAmount, Me.fieldOrderYear, Me.fieldOrderQuarter})
			pivotGridGroup1.Fields.Add(Me.fieldOrderYear)
			pivotGridGroup1.Fields.Add(Me.fieldOrderQuarter)
			pivotGridGroup1.Hierarchy = Nothing
			Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(702, 306)
			Me.pivotGridControl1.TabIndex = 3
			' 
			' fieldCompanyName
			' 
			Me.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCompanyName.AreaIndex = 0
			Me.fieldCompanyName.Caption = "Customer"
			Me.fieldCompanyName.FieldName = "CompanyName"
			Me.fieldCompanyName.Name = "fieldCompanyName"
			Me.fieldCompanyName.Width = 150
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			Me.fieldProductName.Width = 186
			' 
			' fieldProductAmount
			' 
			Me.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldProductAmount.AreaIndex = 0
			Me.fieldProductAmount.Caption = "Product Amount"
			Me.fieldProductAmount.CellFormat.FormatString = "c"
			Me.fieldProductAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldProductAmount.FieldName = "ProductAmount"
			Me.fieldProductAmount.Name = "fieldProductAmount"
			Me.fieldProductAmount.Width = 130
			' 
			' pcYear
			' 
			Me.pcYear.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcYear.Controls.Add(Me.cbeQuarter)
			Me.pcYear.Controls.Add(Me.label2)
			Me.pcYear.Controls.Add(Me.cbeYear)
			Me.pcYear.Controls.Add(Me.label1)
			Me.pcYear.Dock = System.Windows.Forms.DockStyle.Top
			Me.pcYear.Location = New System.Drawing.Point(2, 65)
			Me.pcYear.Name = "pcYear"
			Me.pcYear.Padding = New System.Windows.Forms.Padding(4)
			Me.pcYear.Size = New System.Drawing.Size(698, 25)
			Me.pcYear.TabIndex = 4
			' 
			' cbeQuarter
			' 
			Me.cbeQuarter.EditValue = ""
			Me.cbeQuarter.Location = New System.Drawing.Point(274, 0)
			Me.cbeQuarter.Name = "cbeQuarter"
			Me.cbeQuarter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeQuarter.Properties.Items.AddRange(New Object() { "(All)"})
			Me.cbeQuarter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeQuarter.Size = New System.Drawing.Size(144, 20)
			Me.cbeQuarter.TabIndex = 3
'			Me.cbeQuarter.SelectedIndexChanged += New System.EventHandler(Me.cbeQuarter_SelectedIndexChanged);
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(216, 3)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(52, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Quarter: "
			Me.label2.BackColor = System.Drawing.Color.Transparent
			' 
			' cbeYear
			' 
			Me.cbeYear.EditValue = ""
			Me.cbeYear.Location = New System.Drawing.Point(56, 0)
			Me.cbeYear.Name = "cbeYear"
			Me.cbeYear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeYear.Size = New System.Drawing.Size(144, 20)
			Me.cbeYear.TabIndex = 1
'			Me.cbeYear.SelectedIndexChanged += New System.EventHandler(Me.cbeYear_SelectedIndexChanged);
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(14, 3)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(36, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Year: "
			Me.label1.BackColor = System.Drawing.Color.Transparent
			' 
			' pcSplitter
			' 
			Me.pcSplitter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcSplitter.Dock = System.Windows.Forms.DockStyle.Top
			Me.pcSplitter.Location = New System.Drawing.Point(2, 90)
			Me.pcSplitter.Name = "pcSplitter"
			Me.pcSplitter.Size = New System.Drawing.Size(698, 2)
			Me.pcSplitter.TabIndex = 10
			' 
			' mainPanel
			' 
			Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.mainPanel.Controls.Add(Me.pivotGridControl1)
			Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mainPanel.Location = New System.Drawing.Point(0, 102)
			Me.mainPanel.Name = "mainPanel"
			Me.mainPanel.Size = New System.Drawing.Size(702, 306)
			Me.mainPanel.TabIndex = 11
			' 
			' controlPanel
			' 
			Me.controlPanel.AutoSize = True
			Me.controlPanel.Controls.Add(Me.pcSplitter)
			Me.controlPanel.Controls.Add(Me.pcYear)
			Me.controlPanel.Controls.Add(Me.panelControl1)
			Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.controlPanel.Location = New System.Drawing.Point(0, 0)
			Me.controlPanel.Name = "controlPanel"
			Me.controlPanel.Size = New System.Drawing.Size(702, 94)
			Me.controlPanel.TabIndex = 12
			' 
			' paddingPanel
			' 
			Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.paddingPanel.Location = New System.Drawing.Point(0, 94)
			Me.paddingPanel.Name = "paddingPanel"
			Me.paddingPanel.Size = New System.Drawing.Size(702, 8)
			Me.paddingPanel.TabIndex = 16
			' 
			' CustomerReports
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.mainPanel)
			Me.Controls.Add(Me.paddingPanel)
			Me.Controls.Add(Me.controlPanel)
			Me.Name = "CustomerReports"
			Me.Size = New System.Drawing.Size(702, 408)
'			Me.Load += New System.EventHandler(Me.CustomerReports_Load);
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.rgReport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsReports1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcYear, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcYear.ResumeLayout(False)
			Me.pcYear.PerformLayout()
			CType(Me.cbeQuarter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcSplitter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mainPanel.ResumeLayout(False)
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.controlPanel.ResumeLayout(False)
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private dsReports1 As DevExpress.XtraPivotGrid.Demos.dsReports
		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCompanyName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductAmount As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderQuarter As DevExpress.XtraPivotGrid.PivotGridField
		Private pcYear As DevExpress.XtraEditors.PanelControl
		Private WithEvents cbeYear As DevExpress.XtraEditors.ComboBoxEdit
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbeQuarter As DevExpress.XtraEditors.ComboBoxEdit
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private pcSplitter As DevExpress.XtraEditors.PanelControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private mainPanel As DevExpress.XtraEditors.PanelControl
		Private controlPanel As DevExpress.XtraEditors.PanelControl
		Private WithEvents rgReport As DevExpress.XtraEditors.RadioGroup
		Private paddingPanel As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
