namespace DevExpress.XtraVerticalGrid.Demos {
    partial class UnboundExpressions {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNWindProducts = new DevExpress.XtraVerticalGrid.Demos.dsNWindProducts();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.categoryRow1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowOrderID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowProductID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowUnitPrice = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowQuantity = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDiscount = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow2 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowTotal = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTotalAmount = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.addNewRow = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNWindProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vGridControl1
            // 
            this.vGridControl1.DataSource = this.orderDetailsBindingSource;
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.Location = new System.Drawing.Point(0, 50);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.OptionsMenu.EnableContextMenu = true;
            this.vGridControl1.OptionsView.MinRowAutoHeight = 20;
            this.vGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.categoryRow1,
            this.categoryRow2});
            this.vGridControl1.Size = new System.Drawing.Size(650, 430);
            this.vGridControl1.TabIndex = 10;
            this.vGridControl1.RowChanged += new DevExpress.XtraVerticalGrid.Events.RowChangedEventHandler(this.vGridControl1_RowChanged);
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "Order Details";
            this.orderDetailsBindingSource.DataSource = this.dsNWindProducts;
            // 
            // dsNWindProducts
            // 
            this.dsNWindProducts.DataSetName = "dsNWindProducts";
            this.dsNWindProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")});
            this.repositoryItemLookUpEdit1.DisplayMember = "ProductName";
            this.repositoryItemLookUpEdit1.DropDownRows = 10;
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.PopupWidth = 220;
            this.repositoryItemLookUpEdit1.ValueMember = "ProductID";
            // 
            // categoryRow1
            // 
            this.categoryRow1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowOrderID,
            this.rowProductID,
            this.rowUnitPrice,
            this.rowQuantity,
            this.rowDiscount});
            this.categoryRow1.Name = "categoryRow1";
            this.categoryRow1.Properties.Caption = "Bound Rows";
            // 
            // rowOrderID
            // 
            this.rowOrderID.Name = "rowOrderID";
            this.rowOrderID.Properties.Caption = "Order ID";
            this.rowOrderID.Properties.FieldName = "OrderID";
            // 
            // rowProductID
            // 
            this.rowProductID.Name = "rowProductID";
            this.rowProductID.Properties.Caption = "Product";
            this.rowProductID.Properties.FieldName = "ProductID";
            this.rowProductID.Properties.RowEdit = this.repositoryItemLookUpEdit1;
            // 
            // rowUnitPrice
            // 
            this.rowUnitPrice.Name = "rowUnitPrice";
            this.rowUnitPrice.Properties.Caption = "Unit Price";
            this.rowUnitPrice.Properties.FieldName = "UnitPrice";
            this.rowUnitPrice.Properties.Format.FormatString = "c2";
            this.rowUnitPrice.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // rowQuantity
            // 
            this.rowQuantity.Name = "rowQuantity";
            this.rowQuantity.Properties.Caption = "Quantity";
            this.rowQuantity.Properties.FieldName = "Quantity";
            // 
            // rowDiscount
            // 
            this.rowDiscount.Name = "rowDiscount";
            this.rowDiscount.Properties.Caption = "Discount";
            this.rowDiscount.Properties.FieldName = "Discount";
            this.rowDiscount.Properties.Format.FormatString = "p0";
            this.rowDiscount.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // categoryRow2
            // 
            this.categoryRow2.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowTotal,
            this.rowTotalAmount});
            this.categoryRow2.Name = "categoryRow2";
            this.categoryRow2.Properties.Caption = "Unbound Rows";
            // 
            // rowTotal
            // 
            this.rowTotal.Name = "rowTotal";
            this.rowTotal.Properties.Caption = "Total";
            this.rowTotal.Properties.FieldName = "rowTotal0";
            this.rowTotal.Properties.Format.FormatString = "c2";
            this.rowTotal.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rowTotal.Properties.ShowUnboundExpressionMenu = true;
            this.rowTotal.Properties.UnboundExpression = "(1 - [Discount]) * [Quantity] * [UnitPrice]";
            this.rowTotal.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // rowTotalAmount
            // 
            this.rowTotalAmount.Name = "rowTotalAmount";
            this.rowTotalAmount.Properties.Caption = "Total Amount";
            this.rowTotalAmount.Properties.FieldName = "TotalAmount";
            this.rowTotalAmount.Properties.Format.FormatString = "c2";
            this.rowTotalAmount.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rowTotalAmount.Properties.ShowUnboundExpressionMenu = true;
            this.rowTotalAmount.Properties.UnboundExpression = "[Quantity] * [UnitPrice] - [rowTotal0]";
            this.rowTotalAmount.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 42);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(650, 8);
            this.panelControl2.TabIndex = 9;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.addNewRow);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(650, 42);
            this.panelControl1.TabIndex = 8;
            // 
            // addNewRow
            // 
            this.addNewRow.Location = new System.Drawing.Point(17, 9);
            this.addNewRow.Name = "addNewRow";
            this.addNewRow.Size = new System.Drawing.Size(121, 23);
            this.addNewRow.TabIndex = 0;
            this.addNewRow.Text = "Add New Row";
            this.addNewRow.Click += new System.EventHandler(this.addNewRow_Click);
            // 
            // UnboundExpressions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "UnboundExpressions";
            this.Size = new System.Drawing.Size(650, 480);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNWindProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VGridControl vGridControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private dsNWindProducts dsNWindProducts;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowOrderID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowProductID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowUnitPrice;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowQuantity;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDiscount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTotal;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTotalAmount;
        private DevExpress.XtraEditors.SimpleButton addNewRow;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow1;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow2;
    }
}
