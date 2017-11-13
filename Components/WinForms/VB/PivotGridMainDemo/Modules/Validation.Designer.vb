Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class Validation
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
			Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
			Me.controlPanel = New DevExpress.XtraEditors.PanelControl()
			Me.totalValidation = New DevExpress.XtraPivotGrid.Demos.Modules.ValidationControl()
			Me.commonValidation = New DevExpress.XtraPivotGrid.Demos.Modules.ValidationControl()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mainPanel.SuspendLayout()
			CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.controlPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' mainPanel
			' 
			Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.mainPanel.Controls.Add(Me.pivotGridControl)
			Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mainPanel.Location = New System.Drawing.Point(0, 82)
			Me.mainPanel.Name = "mainPanel"
			Me.mainPanel.Size = New System.Drawing.Size(700, 318)
			Me.mainPanel.TabIndex = 5
			' 
			' pivotGridControl
			' 
			Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldQuantity, Me.fieldCategoryName, Me.fieldProductName, Me.fieldSalesPerson})
			Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl.Name = "pivotGridControl"
			Me.pivotGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCalcEdit1})
			Me.pivotGridControl.Size = New System.Drawing.Size(700, 318)
			Me.pivotGridControl.TabIndex = 0
'			Me.pivotGridControl.FieldValueImageIndex += New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(Me.pivotGridControl_FieldValueImageIndex);
'			Me.pivotGridControl.CustomAppearance += New DevExpress.XtraPivotGrid.PivotCustomAppearanceEventHandler(Me.pivotGridControl_CustomAppearance);
'			Me.pivotGridControl.EditValueChanged += New DevExpress.XtraPivotGrid.EditValueChangedEventHandler(Me.pivotGridControl_EditorValueChanged);
'			Me.pivotGridControl.ValidatingEditor += New DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(Me.pivotGridControl_ValidatingEditor);
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 0
			Me.fieldQuantity.FieldEdit = Me.repositoryItemCalcEdit1
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			' 
			' repositoryItemCalcEdit1
			' 
			Me.repositoryItemCalcEdit1.AutoHeight = False
			Me.repositoryItemCalcEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 0
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldSalesPerson.AreaIndex = 0
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			' 
			' paddingPanel
			' 
			Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.paddingPanel.Location = New System.Drawing.Point(0, 74)
			Me.paddingPanel.Name = "paddingPanel"
			Me.paddingPanel.Size = New System.Drawing.Size(700, 8)
			Me.paddingPanel.TabIndex = 4
			' 
			' controlPanel
			' 
			Me.controlPanel.Controls.Add(Me.totalValidation)
			Me.controlPanel.Controls.Add(Me.commonValidation)
			Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.controlPanel.Location = New System.Drawing.Point(0, 0)
			Me.controlPanel.Name = "controlPanel"
			Me.controlPanel.Size = New System.Drawing.Size(700, 74)
			Me.controlPanel.TabIndex = 3
			' 
			' totalValidation
			' 
			Me.totalValidation.Caption = "Quantitiy (Total or GrandTotal):"
			Me.totalValidation.Dock = System.Windows.Forms.DockStyle.Top
			Me.totalValidation.Location = New System.Drawing.Point(2, 32)
			Me.totalValidation.Name = "totalValidation"
			Me.totalValidation.Size = New System.Drawing.Size(696, 30)
			Me.totalValidation.TabIndex = 1
'			Me.totalValidation.ValidateCondition += New System.EventHandler(Me.validationControl_ValidateCondition);
			' 
			' commonValidation
			' 
			Me.commonValidation.Caption = "Quantity (Common Cells):"
			Me.commonValidation.Dock = System.Windows.Forms.DockStyle.Top
			Me.commonValidation.Location = New System.Drawing.Point(2, 2)
			Me.commonValidation.Name = "commonValidation"
			Me.commonValidation.Size = New System.Drawing.Size(696, 30)
			Me.commonValidation.TabIndex = 0
'			Me.commonValidation.ValidateCondition += New System.EventHandler(Me.validationControl_ValidateCondition);
			' 
			' Validation
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.mainPanel)
			Me.Controls.Add(Me.paddingPanel)
			Me.Controls.Add(Me.controlPanel)
			Me.Name = "Validation"
			Me.Size = New System.Drawing.Size(700, 400)
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mainPanel.ResumeLayout(False)
			CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.controlPanel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		Private mainPanel As DevExpress.XtraEditors.PanelControl
		Private paddingPanel As DevExpress.XtraEditors.PanelControl
		Private controlPanel As DevExpress.XtraEditors.PanelControl

		#End Region
		Private WithEvents pivotGridControl As PivotGridControl
		Private fieldQuantity As PivotGridField
		Private fieldCategoryName As PivotGridField
		Private fieldProductName As PivotGridField
		Private fieldSalesPerson As PivotGridField
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private WithEvents totalValidation As ValidationControl
		Private WithEvents commonValidation As ValidationControl
	End Class
End Namespace
