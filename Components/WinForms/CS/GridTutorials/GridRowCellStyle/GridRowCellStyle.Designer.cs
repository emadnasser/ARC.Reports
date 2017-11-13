namespace DevExpress.XtraGrid.Demos.Tutorials {
    partial class GridRowCellStyle {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrademark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLiter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCyl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTransmissSpeedCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMPGCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMPGHighway = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colDeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(4, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemCalcEdit1});
            this.gridControl1.Size = new System.Drawing.Size(584, 358);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrademark,
            this.colModel,
            this.colHP,
            this.colLiter,
            this.colCyl,
            this.colTransmissSpeedCount,
            this.colMPGCity,
            this.colMPGHighway,
            this.colPrice,
            this.colDeliveryDate,
            this.colIsInStock});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colTrademark
            // 
            this.colTrademark.Caption = "Trademark";
            this.colTrademark.FieldName = "Trademark";
            this.colTrademark.Name = "colTrademark";
            this.colTrademark.Visible = true;
            this.colTrademark.VisibleIndex = 0;
            this.colTrademark.Width = 88;
            // 
            // colModel
            // 
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.OptionsFilter.AllowFilter = false;
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 1;
            this.colModel.Width = 163;
            // 
            // colHP
            // 
            this.colHP.Caption = "HP";
            this.colHP.FieldName = "HP";
            this.colHP.Name = "colHP";
            this.colHP.Visible = true;
            this.colHP.VisibleIndex = 2;
            this.colHP.Width = 44;
            // 
            // colLiter
            // 
            this.colLiter.Caption = "Capacity";
            this.colLiter.FieldName = "Liter";
            this.colLiter.Name = "colLiter";
            this.colLiter.Visible = true;
            this.colLiter.VisibleIndex = 3;
            this.colLiter.Width = 72;
            // 
            // colCyl
            // 
            this.colCyl.Caption = "Cyl";
            this.colCyl.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colCyl.FieldName = "Cyl";
            this.colCyl.Name = "colCyl";
            this.colCyl.Visible = true;
            this.colCyl.VisibleIndex = 4;
            this.colCyl.Width = 45;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.IsFloatValue = false;
            this.repositoryItemSpinEdit1.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colTransmissSpeedCount
            // 
            this.colTransmissSpeedCount.Caption = "# of Gears";
            this.colTransmissSpeedCount.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colTransmissSpeedCount.FieldName = "Transmiss Speed Count";
            this.colTransmissSpeedCount.Name = "colTransmissSpeedCount";
            this.colTransmissSpeedCount.Visible = true;
            this.colTransmissSpeedCount.VisibleIndex = 5;
            this.colTransmissSpeedCount.Width = 80;
            // 
            // colMPGCity
            // 
            this.colMPGCity.Caption = "MPG City";
            this.colMPGCity.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colMPGCity.FieldName = "MPG City";
            this.colMPGCity.Name = "colMPGCity";
            this.colMPGCity.Visible = true;
            this.colMPGCity.VisibleIndex = 6;
            this.colMPGCity.Width = 76;
            // 
            // colMPGHighway
            // 
            this.colMPGHighway.Caption = "MPG Highway";
            this.colMPGHighway.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colMPGHighway.FieldName = "MPG Highway";
            this.colMPGHighway.Name = "colMPGHighway";
            this.colMPGHighway.Visible = true;
            this.colMPGHighway.VisibleIndex = 7;
            this.colMPGHighway.Width = 99;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colPrice.DisplayFormat.FormatString = "c";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 8;
            this.colPrice.Width = 83;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.Caption = "Delivery Date";
            this.colDeliveryDate.FieldName = "Delivery Date";
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.Visible = true;
            this.colDeliveryDate.VisibleIndex = 9;
            this.colDeliveryDate.Width = 95;
            // 
            // colIsInStock
            // 
            this.colIsInStock.Caption = "In Stock?";
            this.colIsInStock.FieldName = "Is In Stock";
            this.colIsInStock.Name = "colIsInStock";
            this.colIsInStock.Visible = true;
            this.colIsInStock.VisibleIndex = 10;
            // 
            // GridRowCellStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "GridRowCellStyle";
            this.Size = new System.Drawing.Size(592, 366);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.GridRowCellStyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTrademark;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colHP;
        private DevExpress.XtraGrid.Columns.GridColumn colLiter;
        private DevExpress.XtraGrid.Columns.GridColumn colCyl;
        private DevExpress.XtraGrid.Columns.GridColumn colTransmissSpeedCount;
        private DevExpress.XtraGrid.Columns.GridColumn colMPGCity;
        private DevExpress.XtraGrid.Columns.GridColumn colMPGHighway;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsInStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private System.ComponentModel.Container components = null;

    }
}
