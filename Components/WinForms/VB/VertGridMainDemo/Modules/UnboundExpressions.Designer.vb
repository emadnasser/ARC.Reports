Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class UnboundExpressions
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
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.orderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.dsNWindProducts = New DevExpress.XtraVerticalGrid.Demos.dsNWindProducts()
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.categoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowOrderID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowProductID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowUnitPrice = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowQuantity = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowDiscount = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow2 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowTotal = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowTotalAmount = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.addNewRow = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsNWindProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' vGridControl1
			' 
			Me.vGridControl1.DataSource = Me.orderDetailsBindingSource
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(0, 50)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.OptionsMenu.EnableContextMenu = True
			Me.vGridControl1.OptionsView.MinRowAutoHeight = 20
			Me.vGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1})
			Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.categoryRow1, Me.categoryRow2})
			Me.vGridControl1.Size = New System.Drawing.Size(650, 430)
			Me.vGridControl1.TabIndex = 10
'			Me.vGridControl1.RowChanged += New DevExpress.XtraVerticalGrid.Events.RowChangedEventHandler(Me.vGridControl1_RowChanged)
			' 
			' orderDetailsBindingSource
			' 
			Me.orderDetailsBindingSource.DataMember = "Order Details"
			Me.orderDetailsBindingSource.DataSource = Me.dsNWindProducts
			' 
			' dsNWindProducts
			' 
			Me.dsNWindProducts.DataSetName = "dsNWindProducts"
			Me.dsNWindProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' repositoryItemLookUpEdit1
			' 
			Me.repositoryItemLookUpEdit1.AutoHeight = False
			Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")})
			Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
			Me.repositoryItemLookUpEdit1.DropDownRows = 10
			Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
			Me.repositoryItemLookUpEdit1.PopupWidth = 220
			Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
			' 
			' categoryRow1
			' 
			Me.categoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowOrderID, Me.rowProductID, Me.rowUnitPrice, Me.rowQuantity, Me.rowDiscount})
			Me.categoryRow1.Name = "categoryRow1"
			Me.categoryRow1.Properties.Caption = "Bound Rows"
			' 
			' rowOrderID
			' 
			Me.rowOrderID.Name = "rowOrderID"
			Me.rowOrderID.Properties.Caption = "Order ID"
			Me.rowOrderID.Properties.FieldName = "OrderID"
			' 
			' rowProductID
			' 
			Me.rowProductID.Name = "rowProductID"
			Me.rowProductID.Properties.Caption = "Product"
			Me.rowProductID.Properties.FieldName = "ProductID"
			Me.rowProductID.Properties.RowEdit = Me.repositoryItemLookUpEdit1
			' 
			' rowUnitPrice
			' 
			Me.rowUnitPrice.Name = "rowUnitPrice"
			Me.rowUnitPrice.Properties.Caption = "Unit Price"
			Me.rowUnitPrice.Properties.FieldName = "UnitPrice"
			Me.rowUnitPrice.Properties.Format.FormatString = "c2"
			Me.rowUnitPrice.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' rowQuantity
			' 
			Me.rowQuantity.Name = "rowQuantity"
			Me.rowQuantity.Properties.Caption = "Quantity"
			Me.rowQuantity.Properties.FieldName = "Quantity"
			' 
			' rowDiscount
			' 
			Me.rowDiscount.Name = "rowDiscount"
			Me.rowDiscount.Properties.Caption = "Discount"
			Me.rowDiscount.Properties.FieldName = "Discount"
			Me.rowDiscount.Properties.Format.FormatString = "p0"
			Me.rowDiscount.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' categoryRow2
			' 
			Me.categoryRow2.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowTotal, Me.rowTotalAmount})
			Me.categoryRow2.Name = "categoryRow2"
			Me.categoryRow2.Properties.Caption = "Unbound Rows"
			' 
			' rowTotal
			' 
			Me.rowTotal.Name = "rowTotal"
			Me.rowTotal.Properties.Caption = "Total"
			Me.rowTotal.Properties.FieldName = "rowTotal0"
			Me.rowTotal.Properties.Format.FormatString = "c2"
			Me.rowTotal.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.rowTotal.Properties.ShowUnboundExpressionMenu = True
			Me.rowTotal.Properties.UnboundExpression = "(1 - [Discount]) * [Quantity] * [UnitPrice]"
			Me.rowTotal.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			' 
			' rowTotalAmount
			' 
			Me.rowTotalAmount.Name = "rowTotalAmount"
			Me.rowTotalAmount.Properties.Caption = "Total Amount"
			Me.rowTotalAmount.Properties.FieldName = "TotalAmount"
			Me.rowTotalAmount.Properties.Format.FormatString = "c2"
			Me.rowTotalAmount.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.rowTotalAmount.Properties.ShowUnboundExpressionMenu = True
			Me.rowTotalAmount.Properties.UnboundExpression = "[Quantity] * [UnitPrice] - [rowTotal0]"
			Me.rowTotalAmount.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 42)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(650, 8)
			Me.panelControl2.TabIndex = 9
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.addNewRow)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(650, 42)
			Me.panelControl1.TabIndex = 8
			' 
			' addNewRow
			' 
			Me.addNewRow.Location = New System.Drawing.Point(17, 9)
			Me.addNewRow.Name = "addNewRow"
			Me.addNewRow.Size = New System.Drawing.Size(121, 23)
			Me.addNewRow.TabIndex = 0
			Me.addNewRow.Text = "Add New Row"
'			Me.addNewRow.Click += New System.EventHandler(Me.addNewRow_Click)
			' 
			' UnboundExpressions
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "UnboundExpressions"
			Me.Size = New System.Drawing.Size(650, 480)
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsNWindProducts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents vGridControl1 As VGridControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private orderDetailsBindingSource As System.Windows.Forms.BindingSource
		Private dsNWindProducts As dsNWindProducts
		Private rowOrderID As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowProductID As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowUnitPrice As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowQuantity As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowDiscount As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private rowTotal As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTotalAmount As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private WithEvents addNewRow As DevExpress.XtraEditors.SimpleButton
		Private categoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private categoryRow2 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
	End Class
End Namespace
