Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridIncrementalSearch
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
		'<gridControl1>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.panel1 = New DevExpress.XtraEditors.PanelControl
            Me.lbEvent = New DevExpress.XtraEditors.LabelControl
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemSpinEdit2})
            Me.gridControl1.Size = New System.Drawing.Size(592, 336)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.UseEmbeddedNavigator = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", Nothing, "")})
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowIncrementalSearch = True
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
            Me.gridColumn4.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.gridColumn4.FieldName = "Quantity"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 3
            Me.gridColumn4.Width = 104
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
            Me.gridColumn5.Caption = "Discount"
            Me.gridColumn5.DisplayFormat.FormatString = "p"
            Me.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn5.FieldName = "Discount"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 4
            Me.gridColumn5.Width = 121
            '
            'repositoryItemSpinEdit1
            '
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'panel1
            '
            Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panel1.Controls.Add(Me.lbEvent)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 336)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(592, 54)
            Me.panel1.TabIndex = 5
            '
            'lbEvent
            '
            Me.lbEvent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbEvent.Appearance.Options.UseTextOptions = True
            Me.lbEvent.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.lbEvent.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.lbEvent.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbEvent.Location = New System.Drawing.Point(16, 8)
            Me.lbEvent.Name = "lbEvent"
            Me.lbEvent.Size = New System.Drawing.Size(573, 43)
            Me.lbEvent.TabIndex = 0
            '
            'timer1
            '
            Me.timer1.Interval = 500
            '
            'GridIncrementalSearch
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridIncrementalSearch"
            Me.Size = New System.Drawing.Size(592, 390)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
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
        Private lbEvent As DevExpress.XtraEditors.LabelControl
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private components As System.ComponentModel.IContainer
	End Class
End Namespace