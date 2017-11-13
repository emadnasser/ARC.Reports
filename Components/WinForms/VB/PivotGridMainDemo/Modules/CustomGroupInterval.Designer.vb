Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class CustomGroupInterval
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.cbGroup = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.cbGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Controls.Add(Me.cbGroup)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(710, 45)
			Me.panelControl1.TabIndex = 1
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(15, 15)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(106, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Select Group Interval:"
			' 
			' cbGroup
			' 
			Me.cbGroup.Location = New System.Drawing.Point(131, 12)
			Me.cbGroup.Name = "cbGroup"
			Me.cbGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbGroup.Size = New System.Drawing.Size(207, 20)
			Me.cbGroup.TabIndex = 0
'			Me.cbGroup.SelectedIndexChanged += New System.EventHandler(Me.cbGroup_SelectedIndexChanged);
			' 
			' pivotGridControl
			' 
			Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.pivotGridField1, Me.pivotGridField2, Me.pivotGridField3, Me.pivotGridField4, Me.pivotGridField5})
			Me.pivotGridControl.Location = New System.Drawing.Point(0, 53)
			Me.pivotGridControl.Name = "pivotGridControl"
			Me.pivotGridControl.Size = New System.Drawing.Size(710, 357)
			Me.pivotGridControl.TabIndex = 13
'			Me.pivotGridControl.CustomGroupInterval += New DevExpress.XtraPivotGrid.PivotCustomGroupIntervalEventHandler(Me.PivotGridControl_CustomGroupInterval);
			' 
			' pivotGridField1
			' 
			Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.pivotGridField1.AreaIndex = 0
			Me.pivotGridField1.Caption = "Product Group"
			Me.pivotGridField1.FieldName = "ProductName"
			Me.pivotGridField1.Name = "pivotGridField1"
			Me.pivotGridField1.UnboundFieldName = "pivotGridField1"
			' 
			' pivotGridField2
			' 
			Me.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.pivotGridField2.AreaIndex = 1
			Me.pivotGridField2.Caption = "Product"
			Me.pivotGridField2.FieldName = "ProductName"
			Me.pivotGridField2.Name = "pivotGridField2"
			' 
			' pivotGridField3
			' 
			Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.pivotGridField3.AreaIndex = 0
			Me.pivotGridField3.Caption = "Sales"
			Me.pivotGridField3.FieldName = "ProductSales"
			Me.pivotGridField3.Name = "pivotGridField3"
			' 
			' pivotGridField4
			' 
			Me.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.pivotGridField4.AreaIndex = 0
			Me.pivotGridField4.Caption = "Year - Quarter"
			Me.pivotGridField4.FieldName = "ShippedDate"
			Me.pivotGridField4.Name = "pivotGridField4"
			Me.pivotGridField4.Visible = False
			' 
			' pivotGridField5
			' 
			Me.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.pivotGridField5.AreaIndex = 0
			Me.pivotGridField5.Caption = "Shipped Date"
			Me.pivotGridField5.FieldName = "ShippedDate"
			Me.pivotGridField5.Name = "pivotGridField5"
			Me.pivotGridField5.UnboundFieldName = "pivotGridField5"
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 45)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(710, 8)
			Me.panelControl2.TabIndex = 14
			' 
			' CustomGroupInterval
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pivotGridControl)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "CustomGroupInterval"
			Me.Size = New System.Drawing.Size(710, 410)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.cbGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents cbGroup As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents pivotGridControl As PivotGridControl
		Private pivotGridField1 As PivotGridField
		Private pivotGridField2 As PivotGridField
		Private pivotGridField3 As PivotGridField
		Private pivotGridField4 As PivotGridField
		Private pivotGridField5 As PivotGridField
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
