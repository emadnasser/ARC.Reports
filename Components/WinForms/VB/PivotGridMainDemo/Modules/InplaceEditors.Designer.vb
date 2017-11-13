Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class InplaceEditors
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
			Me.controlPanel = New DevExpress.XtraEditors.PanelControl()
			Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
			Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
			Me.fieldPercents = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mainPanel.SuspendLayout()
			CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' controlPanel
			' 
			Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.controlPanel.Location = New System.Drawing.Point(0, 0)
			Me.controlPanel.Name = "controlPanel"
			Me.controlPanel.Size = New System.Drawing.Size(700, 21)
			Me.controlPanel.TabIndex = 0
			Me.controlPanel.Visible = False
			' 
			' paddingPanel
			' 
			Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.paddingPanel.Location = New System.Drawing.Point(0, 21)
			Me.paddingPanel.Name = "paddingPanel"
			Me.paddingPanel.Size = New System.Drawing.Size(700, 8)
			Me.paddingPanel.TabIndex = 1
			Me.paddingPanel.Visible = False
			' 
			' mainPanel
			' 
			Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.mainPanel.Controls.Add(Me.pivotGridControl)
			Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mainPanel.Location = New System.Drawing.Point(0, 29)
			Me.mainPanel.Name = "mainPanel"
			Me.mainPanel.Size = New System.Drawing.Size(700, 371)
			Me.mainPanel.TabIndex = 2
			' 
			' pivotGridControl
			' 
			Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName, Me.fieldSalesPerson, Me.fieldExtendedPrice, Me.fieldPercents})
			Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl.Name = "pivotGridControl"
			Me.pivotGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemProgressBar1, Me.repositoryItemCalcEdit1})
			Me.pivotGridControl.Size = New System.Drawing.Size(700, 371)
			Me.pivotGridControl.TabIndex = 0
'			Me.pivotGridControl.FieldValueImageIndex += New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(Me.pivotGridControl_FieldValueImageIndex);
'			Me.pivotGridControl.CustomAppearance += New DevExpress.XtraPivotGrid.PivotCustomAppearanceEventHandler(Me.pivotGridControl_CustomAppearance);
'			Me.pivotGridControl.EditValueChanged += New DevExpress.XtraPivotGrid.EditValueChangedEventHandler(Me.pivotGridControl_EditorValueChanged);
'			Me.pivotGridControl.GridLayout += New System.EventHandler(Me.pivotGridControl_GridLayout);
'			Me.pivotGridControl.CustomEditValue += New DevExpress.XtraPivotGrid.CustomEditValueEventHandler(Me.pivotGridControl_CustomEditValue);
'			Me.pivotGridControl.ShowingEditor += New System.EventHandler(Of CancelPivotCellEditEventArgs)(Me.pivotGridControl_ShowingEditor);
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldCategoryName.AreaIndex = 0
			Me.fieldCategoryName.Caption = "CategoryName"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson.AreaIndex = 0
			Me.fieldSalesPerson.Caption = "Sales Person"
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 0
			Me.fieldExtendedPrice.Caption = "Extended Price"
			Me.fieldExtendedPrice.FieldEdit = Me.repositoryItemCalcEdit1
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			' 
			' repositoryItemCalcEdit1
			' 
			Me.repositoryItemCalcEdit1.AutoHeight = False
			Me.repositoryItemCalcEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCalcEdit1.DisplayFormat.FormatString = "c"
			Me.repositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
			' 
			' fieldPercents
			' 
			Me.fieldPercents.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldPercents.AreaIndex = 1
			Me.fieldPercents.Caption = "Percent Of Column"
			Me.fieldPercents.CellFormat.FormatString = "{0}%"
			Me.fieldPercents.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
			Me.fieldPercents.FieldEdit = Me.repositoryItemProgressBar1
			Me.fieldPercents.FieldName = "Extended Price"
			Me.fieldPercents.Name = "fieldPercents"
			Me.fieldPercents.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn
			' 
			' repositoryItemProgressBar1
			' 
			Me.repositoryItemProgressBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemProgressBar1.DisplayFormat.FormatString = "{0}%"
			Me.repositoryItemProgressBar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
			Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
			Me.repositoryItemProgressBar1.ShowTitle = True
'			Me.repositoryItemProgressBar1.KeyPress += New System.Windows.Forms.KeyPressEventHandler(Me.progressBar_KeyPress);
			' 
			' InplaceEditors
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.mainPanel)
			Me.Controls.Add(Me.paddingPanel)
			Me.Controls.Add(Me.controlPanel)
			Me.Name = "InplaceEditors"
			Me.Size = New System.Drawing.Size(700, 400)
			CType(Me.controlPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mainPanel.ResumeLayout(False)
			CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub


		Private controlPanel As DevExpress.XtraEditors.PanelControl
		Private paddingPanel As DevExpress.XtraEditors.PanelControl
		Private mainPanel As DevExpress.XtraEditors.PanelControl
		#End Region
		Private WithEvents pivotGridControl As PivotGridControl
		Private fieldCategoryName As PivotGridField
		Private fieldSalesPerson As PivotGridField
		Private fieldExtendedPrice As PivotGridField
		Private fieldPercents As PivotGridField
		Private WithEvents repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit

	End Class
End Namespace
