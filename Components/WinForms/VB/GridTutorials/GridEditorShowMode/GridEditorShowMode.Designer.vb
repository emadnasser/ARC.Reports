Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridEditorShowMode
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
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
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.panel1 = New DevExpress.XtraEditors.PanelControl
            Me.imageComboBoxEdit2 = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.label1 = New DevExpress.XtraEditors.LabelControl
            Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.label3 = New DevExpress.XtraEditors.LabelControl
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.imageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 73)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(597, 293)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", Nothing, "")})
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor
            '
            'gridColumn1
            '
            Me.gridColumn1.Caption = "Order ID"
            Me.gridColumn1.FieldName = "OrderID"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            Me.gridColumn1.Width = 86
            '
            'gridColumn2
            '
            Me.gridColumn2.Caption = "Product"
            Me.gridColumn2.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.gridColumn2.FieldName = "ProductID"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            Me.gridColumn2.Width = 225
            '
            'repositoryItemLookUpEdit1
            '
            Me.repositoryItemLookUpEdit1.AutoHeight = False
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")})
            Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
            Me.repositoryItemLookUpEdit1.DropDownRows = 10
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 220
            Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
            '
            'gridColumn3
            '
            Me.gridColumn3.Caption = "Unit Price"
            Me.gridColumn3.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.gridColumn3.DisplayFormat.FormatString = "c"
            Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn3.FieldName = "UnitPrice"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            Me.gridColumn3.Width = 104
            '
            'repositoryItemCalcEdit1
            '
            Me.repositoryItemCalcEdit1.AutoHeight = False
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            '
            'gridColumn4
            '
            Me.gridColumn4.Caption = "Quantity"
            Me.gridColumn4.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.gridColumn4.FieldName = "Quantity"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 3
            Me.gridColumn4.Width = 104
            '
            'repositoryItemSpinEdit1
            '
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'gridColumn5
            '
            Me.gridColumn5.Caption = "Discount"
            Me.gridColumn5.DisplayFormat.FormatString = "p"
            Me.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn5.FieldName = "Discount"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 4
            Me.gridColumn5.Width = 121
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.imageComboBoxEdit2)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.imageComboBoxEdit1)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.checkEdit1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(597, 65)
            Me.panel1.TabIndex = 6
            '
            'imageComboBoxEdit2
            '
            Me.imageComboBoxEdit2.Location = New System.Drawing.Point(390, 34)
            Me.imageComboBoxEdit2.Name = "imageComboBoxEdit2"
            Me.imageComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit2.Size = New System.Drawing.Size(168, 20)
            Me.imageComboBoxEdit2.TabIndex = 7
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(290, 37)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(94, 13)
            Me.label1.TabIndex = 6
            Me.label1.Text = "Show Button Mode:"
            '
            'imageComboBoxEdit1
            '
            Me.imageComboBoxEdit1.Location = New System.Drawing.Point(110, 34)
            Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
            Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit1.Size = New System.Drawing.Size(148, 20)
            Me.imageComboBoxEdit1.TabIndex = 5
            '
            'label3
            '
            Me.label3.Location = New System.Drawing.Point(14, 37)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(90, 13)
            Me.label3.TabIndex = 4
            Me.label3.Text = "Editor Show Mode:"
            '
            'checkEdit1
            '
            Me.checkEdit1.Location = New System.Drawing.Point(12, 12)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Editable"
            Me.checkEdit1.Size = New System.Drawing.Size(184, 18)
            Me.checkEdit1.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 65)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(597, 8)
            Me.panelControl1.TabIndex = 9
            '
            'GridEditorShowMode
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridEditorShowMode"
            Me.Size = New System.Drawing.Size(597, 366)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.imageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private label3 As DevExpress.XtraEditors.LabelControl
        Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit
        Private WithEvents imageComboBoxEdit2 As DevExpress.XtraEditors.ImageComboBoxEdit
        Private label1 As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
