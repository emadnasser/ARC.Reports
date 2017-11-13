Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridOptions
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
            Me.panel1 = New DevExpress.XtraEditors.PanelControl
            Me.checkedListBoxControl2 = New DevExpress.XtraEditors.CheckedListBoxControl
            Me.label2 = New DevExpress.XtraEditors.LabelControl
            Me.checkedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl
            Me.label1 = New DevExpress.XtraEditors.LabelControl
            Me.splitter1 = New DevExpress.XtraEditors.SplitterControl
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
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.checkedListBoxControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panel1.Controls.Add(Me.checkedListBoxControl2)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.checkedListBoxControl1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(200, 476)
            Me.panel1.TabIndex = 3
            '
            'checkedListBoxControl2
            '
            Me.checkedListBoxControl2.CheckOnClick = True
            Me.checkedListBoxControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.checkedListBoxControl2.ItemHeight = 16
            Me.checkedListBoxControl2.Location = New System.Drawing.Point(0, 286)
            Me.checkedListBoxControl2.Name = "checkedListBoxControl2"
            Me.checkedListBoxControl2.Size = New System.Drawing.Size(200, 190)
            Me.checkedListBoxControl2.TabIndex = 4
            '
            'label2
            '
            Me.label2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.label2.Appearance.Options.UseFont = True
            Me.label2.Dock = System.Windows.Forms.DockStyle.Top
            Me.label2.Location = New System.Drawing.Point(0, 269)
            Me.label2.Name = "label2"
            Me.label2.Padding = New System.Windows.Forms.Padding(2)
            Me.label2.Size = New System.Drawing.Size(110, 17)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Options Behaviour:"
            '
            'checkedListBoxControl1
            '
            Me.checkedListBoxControl1.CheckOnClick = True
            Me.checkedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.checkedListBoxControl1.ItemHeight = 16
            Me.checkedListBoxControl1.Location = New System.Drawing.Point(0, 17)
            Me.checkedListBoxControl1.Name = "checkedListBoxControl1"
            Me.checkedListBoxControl1.Size = New System.Drawing.Size(200, 252)
            Me.checkedListBoxControl1.TabIndex = 3
            '
            'label1
            '
            Me.label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.label1.Appearance.Options.UseFont = True
            Me.label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.label1.Location = New System.Drawing.Point(0, 0)
            Me.label1.Name = "label1"
            Me.label1.Padding = New System.Windows.Forms.Padding(2)
            Me.label1.Size = New System.Drawing.Size(79, 17)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Options View:"
            '
            'splitter1
            '
            Me.splitter1.Location = New System.Drawing.Point(200, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(6, 476)
            Me.splitter1.TabIndex = 5
            Me.splitter1.TabStop = False
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(206, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(637, 476)
            Me.gridControl1.TabIndex = 6
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", Nothing, "")})
            Me.gridView1.Name = "gridView1"
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
            'GridOptions
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridOptions"
            Me.Size = New System.Drawing.Size(843, 476)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.checkedListBoxControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private label1 As DevExpress.XtraEditors.LabelControl
        Private label2 As DevExpress.XtraEditors.LabelControl
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private WithEvents checkedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
		Private WithEvents checkedListBoxControl2 As DevExpress.XtraEditors.CheckedListBoxControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
