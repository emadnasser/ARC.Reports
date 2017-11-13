Namespace DevExpress.XtraGrid.Demos
	Partial Public Class UnboundExpression
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(UnboundExpression))
			Dim styleFormatCondition1 As New DevExpress.XtraGrid.StyleFormatCondition()
			Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridColumn7
			' 
			resources.ApplyResources(Me.gridColumn7, "gridColumn7")
			Me.gridColumn7.DisplayFormat.FormatString = "c"
			Me.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn7.FieldName = "DiscountAmount"
			Me.gridColumn7.Name = "gridColumn7"
			Me.gridColumn7.OptionsColumn.AllowEdit = False
			Me.gridColumn7.ShowUnboundExpressionMenu = True
			Me.gridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((CType(resources.GetObject("gridColumn7.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridColumn7.Summary1"), resources.GetString("gridColumn7.Summary2"))})
			Me.gridColumn7.UnboundExpression = "[UnitPrice] * [Quantity] - [Total]"
			Me.gridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			' 
			' gridControl1
			' 
			resources.ApplyResources(Me.gridControl1, "gridControl1")
			Me.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
			Me.gridControl1.EmbeddedNavigator.Buttons.Edit.ImageIndex = 0
			Me.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemTextEdit1})
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7})
			styleFormatCondition1.Appearance.BackColor = (CType(resources.GetObject("resource.BackColor"), System.Drawing.Color))
			styleFormatCondition1.Appearance.Font = (CType(resources.GetObject("resource.Font"), System.Drawing.Font))
			styleFormatCondition1.Appearance.ForeColor = (CType(resources.GetObject("resource.ForeColor"), System.Drawing.Color))
			styleFormatCondition1.Appearance.Options.UseBackColor = True
			styleFormatCondition1.Appearance.Options.UseFont = True
			styleFormatCondition1.Appearance.Options.UseForeColor = True
			styleFormatCondition1.Column = Me.gridColumn7
			styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
			styleFormatCondition1.Value1 = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() { styleFormatCondition1})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupCount = 1
			Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem((CType(resources.GetObject("gridView1.GroupSummary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView1.GroupSummary1"), Nothing, resources.GetString("gridView1.GroupSummary2")), New DevExpress.XtraGrid.GridGroupSummaryItem((CType(resources.GetObject("gridView1.GroupSummary3"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView1.GroupSummary4"), Nothing, resources.GetString("gridView1.GroupSummary5"))})
			Me.gridView1.Images = Me.imageCollection1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
			Me.gridView1.OptionsView.AllowHtmlDrawHeaders = True
			Me.gridView1.OptionsView.ShowFooter = True
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
			' 
			' gridColumn1
			' 
			resources.ApplyResources(Me.gridColumn1, "gridColumn1")
			Me.gridColumn1.FieldName = "OrderID"
			Me.gridColumn1.Name = "gridColumn1"
			' 
			' gridColumn2
			' 
			resources.ApplyResources(Me.gridColumn2, "gridColumn2")
			Me.gridColumn2.ColumnEdit = Me.repositoryItemLookUpEdit1
			Me.gridColumn2.FieldName = "ProductID"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((CType(resources.GetObject("gridColumn2.Summary"), DevExpress.Data.SummaryItemType)))})
			' 
			' repositoryItemLookUpEdit1
			' 
			resources.ApplyResources(Me.repositoryItemLookUpEdit1, "repositoryItemLookUpEdit1")
			Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemLookUpEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns"), resources.GetString("repositoryItemLookUpEdit1.Columns1"))})
			Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
			Me.repositoryItemLookUpEdit1.DropDownRows = 10
			Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
			Me.repositoryItemLookUpEdit1.PopupWidth = 220
			Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
			' 
			' gridColumn3
			' 
			resources.ApplyResources(Me.gridColumn3, "gridColumn3")
			Me.gridColumn3.ColumnEdit = Me.repositoryItemCalcEdit1
			Me.gridColumn3.DisplayFormat.FormatString = "c"
			Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn3.FieldName = "UnitPrice"
			Me.gridColumn3.Name = "gridColumn3"
			' 
			' repositoryItemCalcEdit1
			' 
			resources.ApplyResources(Me.repositoryItemCalcEdit1, "repositoryItemCalcEdit1")
			Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemCalcEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemCalcEdit1.Mask.EditMask = resources.GetString("repositoryItemCalcEdit1.Mask.EditMask")
			Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
			' 
			' gridColumn4
			' 
			resources.ApplyResources(Me.gridColumn4, "gridColumn4")
			Me.gridColumn4.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.gridColumn4.FieldName = "Quantity"
			Me.gridColumn4.Name = "gridColumn4"
			' 
			' repositoryItemSpinEdit1
			' 
			resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.IsFloatValue = False
			Me.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask")
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' gridColumn5
			' 
			resources.ApplyResources(Me.gridColumn5, "gridColumn5")
			Me.gridColumn5.ColumnEdit = Me.repositoryItemTextEdit1
			Me.gridColumn5.DisplayFormat.FormatString = "p"
			Me.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn5.FieldName = "Discount"
			Me.gridColumn5.Name = "gridColumn5"
			' 
			' repositoryItemTextEdit1
			' 
			resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
			Me.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask")
			Me.repositoryItemTextEdit1.Mask.MaskType = (CType(resources.GetObject("repositoryItemTextEdit1.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' gridColumn6
			' 
			resources.ApplyResources(Me.gridColumn6, "gridColumn6")
			Me.gridColumn6.DisplayFormat.FormatString = "c"
			Me.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn6.FieldName = "Total"
			Me.gridColumn6.Name = "gridColumn6"
			Me.gridColumn6.OptionsColumn.AllowEdit = False
			Me.gridColumn6.ShowUnboundExpressionMenu = True
			Me.gridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((CType(resources.GetObject("gridColumn6.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridColumn6.Summary1"), resources.GetString("gridColumn6.Summary2"))})
			Me.gridColumn6.UnboundExpression = "[UnitPrice] * [Quantity] * (1 - [Discount])"
			Me.gridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "order-16x16.png")
			Me.imageCollection1.Images.SetKeyName(1, "sale-item-16x16.png")
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = (CType(resources.GetObject("panelControl1.Appearance.BackColor"), System.Drawing.Color))
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.simpleButton1)
			Me.panelControl1.Controls.Add(Me.imageComboBoxEdit1)
			Me.panelControl1.Controls.Add(Me.labelControl1)
			resources.ApplyResources(Me.panelControl1, "panelControl1")
			Me.panelControl1.Name = "panelControl1"
			' 
			' simpleButton1
			' 
			resources.ApplyResources(Me.simpleButton1, "simpleButton1")
			Me.simpleButton1.Name = "simpleButton1"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click)
			' 
			' imageComboBoxEdit1
			' 
			resources.ApplyResources(Me.imageComboBoxEdit1, "imageComboBoxEdit1")
			Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
			Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("imageComboBoxEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.imageComboBoxEdit1.Properties.SmallImages = Me.imageCollection1
			' 
			' labelControl1
			' 
			resources.ApplyResources(Me.labelControl1, "labelControl1")
			Me.labelControl1.Name = "labelControl1"
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			resources.ApplyResources(Me.panelControl2, "panelControl2")
			Me.panelControl2.Name = "panelControl2"
			' 
			' UnboundExpression
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "UnboundExpression"
'			Me.Load += New System.EventHandler(Me.UnboundExpression_Load)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
