Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class RunningTotal
		Private components As System.ComponentModel.IContainer = Nothing
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		Private Sub InitializeComponent()
			Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldProductAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.controlPanel = New DevExpress.XtraEditors.PanelControl()
			Me.ceAllowCrossGroupRunningTotals = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowRunningTotals = New DevExpress.XtraEditors.CheckEdit()
			Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.controlPanel.SuspendLayout()
			CType(Me.ceAllowCrossGroupRunningTotals.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowRunningTotals.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mainPanel.SuspendLayout()
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
			Me.fieldOrderYear.UnboundFieldName = "pivotGridField1"
			' 
			' fieldOrderQuarter
			' 
			Me.fieldOrderQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderQuarter.AreaIndex = 1
			Me.fieldOrderQuarter.Caption = "Order Quarter"
			Me.fieldOrderQuarter.FieldName = "OrderDate"
			Me.fieldOrderQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldOrderQuarter.Name = "fieldOrderQuarter"
			Me.fieldOrderQuarter.UnboundFieldName = "pivotGridField2"
			' 
			' paddingPanel
			' 
			Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.paddingPanel.Location = New System.Drawing.Point(0, 39)
			Me.paddingPanel.Name = "paddingPanel"
			Me.paddingPanel.Size = New System.Drawing.Size(700, 8)
			Me.paddingPanel.TabIndex = 7
			' 
			' pivotGridControl
			' 
			Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldProductAmount, Me.fieldProductName, Me.fieldOrderYear, Me.fieldOrderQuarter})
			pivotGridGroup1.Fields.Add(Me.fieldOrderYear)
			pivotGridGroup1.Fields.Add(Me.fieldOrderQuarter)
			pivotGridGroup1.Hierarchy = Nothing
			Me.pivotGridControl.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
			Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl.Name = "pivotGridControl"
			Me.pivotGridControl.OptionsView.ShowColumnTotals = False
			Me.pivotGridControl.Size = New System.Drawing.Size(700, 353)
			Me.pivotGridControl.TabIndex = 0
			' 
			' fieldProductAmount
			' 
			Me.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldProductAmount.AreaIndex = 0
			Me.fieldProductAmount.Caption = "Product Sales"
			Me.fieldProductAmount.CellFormat.FormatString = "c"
			Me.fieldProductAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldProductAmount.FieldName = "ProductAmount"
			Me.fieldProductAmount.Name = "fieldProductAmount"
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 0
			Me.fieldProductName.Caption = "Product"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' controlPanel
			' 
			Me.controlPanel.Controls.Add(Me.ceAllowCrossGroupRunningTotals)
			Me.controlPanel.Controls.Add(Me.ceShowRunningTotals)
			Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.controlPanel.Location = New System.Drawing.Point(0, 0)
			Me.controlPanel.Name = "controlPanel"
			Me.controlPanel.Size = New System.Drawing.Size(700, 39)
			Me.controlPanel.TabIndex = 6
			' 
			' ceAllowCrossGroupRunningTotals
			' 
			Me.ceAllowCrossGroupRunningTotals.Location = New System.Drawing.Point(362, 10)
			Me.ceAllowCrossGroupRunningTotals.Name = "ceAllowCrossGroupRunningTotals"
			Me.ceAllowCrossGroupRunningTotals.Properties.Caption = "Allow Cross-Group Running Totals Accumulation"
			Me.ceAllowCrossGroupRunningTotals.Size = New System.Drawing.Size(254, 19)
			Me.ceAllowCrossGroupRunningTotals.TabIndex = 4
'			Me.ceAllowCrossGroupRunningTotals.CheckedChanged += New System.EventHandler(Me.ceAllowCrossGroupRunningTotals_CheckedChanged);
			' 
			' ceShowRunningTotals
			' 
			Me.ceShowRunningTotals.Location = New System.Drawing.Point(12, 10)
			Me.ceShowRunningTotals.Name = "ceShowRunningTotals"
			Me.ceShowRunningTotals.Properties.AutoWidth = True
			Me.ceShowRunningTotals.Properties.Caption = "Include Previous Quarter Sales into the Values of the Next Quarter"
			Me.ceShowRunningTotals.Size = New System.Drawing.Size(344, 19)
			Me.ceShowRunningTotals.TabIndex = 3
'			Me.ceShowRunningTotals.CheckedChanged += New System.EventHandler(Me.ceShowRunningTotals_CheckedChanged);
			' 
			' mainPanel
			' 
			Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.mainPanel.Controls.Add(Me.pivotGridControl)
			Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mainPanel.Location = New System.Drawing.Point(0, 47)
			Me.mainPanel.Name = "mainPanel"
			Me.mainPanel.Size = New System.Drawing.Size(700, 353)
			Me.mainPanel.TabIndex = 8
			' 
			' RunningTotal
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.mainPanel)
			Me.Controls.Add(Me.paddingPanel)
			Me.Controls.Add(Me.controlPanel)
			Me.Name = "RunningTotal"
			Me.Size = New System.Drawing.Size(700, 400)
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.controlPanel.ResumeLayout(False)
			CType(Me.ceAllowCrossGroupRunningTotals.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowRunningTotals.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mainPanel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private paddingPanel As DevExpress.XtraEditors.PanelControl
		Private pivotGridControl As PivotGridControl
		Private fieldProductAmount As PivotGridField
		Private fieldProductName As PivotGridField
		Private controlPanel As DevExpress.XtraEditors.PanelControl
		Private mainPanel As DevExpress.XtraEditors.PanelControl
		Private WithEvents ceShowRunningTotals As DevExpress.XtraEditors.CheckEdit
		Private fieldOrderYear As PivotGridField
		Private fieldOrderQuarter As PivotGridField
		Private WithEvents ceAllowCrossGroupRunningTotals As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace
