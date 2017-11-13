Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridGroupLevelStyle
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
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.panel1 = New DevExpress.XtraEditors.PanelControl
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit
            Me.label1 = New DevExpress.XtraEditors.LabelControl
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 44)
            Me.gridControl1.LookAndFeel.UseDefaultLookAndFeel = False
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemSpinEdit2})
            Me.gridControl1.Size = New System.Drawing.Size(593, 322)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Appearance.Row.Options.UseTextOptions = True
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 4
            Me.gridView1.Name = "gridView1"
            Me.gridView1.PaintStyleName = "WindowsXP"
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn4, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn5, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn6, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn7, DevExpress.Data.ColumnSortOrder.Ascending)})
            '
            'gridColumn1
            '
            Me.gridColumn1.Caption = "Product Name"
            Me.gridColumn1.FieldName = "ProductName"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.OptionsFilter.AllowFilter = False
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            Me.gridColumn1.Width = 92
            '
            'gridColumn2
            '
            Me.gridColumn2.Caption = "Quantity Per Unit"
            Me.gridColumn2.FieldName = "QuantityPerUnit"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            Me.gridColumn2.Width = 73
            '
            'gridColumn3
            '
            Me.gridColumn3.Caption = "Unit Price"
            Me.gridColumn3.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.gridColumn3.DisplayFormat.FormatString = "c"
            Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn3.FieldName = "UnitPrice"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            Me.gridColumn3.Width = 62
            '
            'repositoryItemSpinEdit1
            '
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'gridColumn4
            '
            Me.gridColumn4.Caption = "Units In Stock"
            Me.gridColumn4.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.gridColumn4.FieldName = "UnitsInStock"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Width = 87
            '
            'repositoryItemSpinEdit2
            '
            Me.repositoryItemSpinEdit2.AutoHeight = False
            Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repositoryItemSpinEdit2.IsFloatValue = False
            Me.repositoryItemSpinEdit2.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
            '
            'gridColumn5
            '
            Me.gridColumn5.Caption = "Units On Order"
            Me.gridColumn5.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.gridColumn5.FieldName = "UnitsOnOrder"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Width = 80
            '
            'gridColumn6
            '
            Me.gridColumn6.Caption = "Reorder Level"
            Me.gridColumn6.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.gridColumn6.FieldName = "ReorderLevel"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.Width = 68
            '
            'gridColumn7
            '
            Me.gridColumn7.Caption = "Discontinued"
            Me.gridColumn7.FieldName = "Discontinued"
            Me.gridColumn7.Name = "gridColumn7"
            Me.gridColumn7.Width = 82
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.spinEdit1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(593, 36)
            Me.panel1.TabIndex = 6
            '
            'spinEdit1
            '
            Me.spinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit1.Location = New System.Drawing.Point(100, 8)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinEdit1.Properties.IsFloatValue = False
            Me.spinEdit1.Properties.Mask.EditMask = "N00"
            Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinEdit1.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.spinEdit1.Size = New System.Drawing.Size(88, 20)
            Me.spinEdit1.TabIndex = 8
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(16, 11)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(64, 13)
            Me.label1.TabIndex = 7
            Me.label1.Text = "Level Indent:"
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 36)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(593, 8)
            Me.panelControl1.TabIndex = 9
            '
            'GridGroupLevelStyle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridGroupLevelStyle"
            Me.Size = New System.Drawing.Size(593, 366)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
        Private label1 As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
