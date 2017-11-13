using DevExpress.XtraEditors;
namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    partial class RowAlignment {
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
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.comboBox2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.categoryRow4 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTrademark = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowModel = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowHP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowLiter = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCyl = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTransmiss_Speed_Count = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTransmiss_Automatic = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow3 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowPrice = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDelivery_Date = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowIs_In_Stock = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 38);
            this.panel2.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.Location = new System.Drawing.Point(256, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBox2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBox2.Size = new System.Drawing.Size(128, 20);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alignment:";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(50, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBox1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBox1.Size = new System.Drawing.Size(128, 20);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Row:";
            // 
            // vGridControl1
            // 
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.Location = new System.Drawing.Point(0, 46);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.OptionsBehavior.ResizeHeaderPanel = false;
            this.vGridControl1.OptionsBehavior.UseTabKey = false;
            this.vGridControl1.RecordWidth = 197;
            this.vGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.vGridControl1.RowHeaderWidth = 188;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.categoryRow4,
            this.categoryRow1,
            this.categoryRow3});
            this.vGridControl1.Size = new System.Drawing.Size(400, 368);
            this.vGridControl1.TabIndex = 11;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // categoryRow4
            // 
            this.categoryRow4.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowID,
            this.rowTrademark,
            this.rowModel});
            this.categoryRow4.Name = "categoryRow4";
            this.categoryRow4.Properties.Caption = "Main Info";
            // 
            // rowID
            // 
            this.rowID.Name = "rowID";
            this.rowID.Properties.Caption = "Record ID";
            this.rowID.Properties.FieldName = "ID";
            this.rowID.Properties.ImageIndex = 0;
            // 
            // rowTrademark
            // 
            this.rowTrademark.Name = "rowTrademark";
            this.rowTrademark.Properties.Caption = "Trademark";
            this.rowTrademark.Properties.FieldName = "Trademark";
            // 
            // rowModel
            // 
            this.rowModel.Name = "rowModel";
            this.rowModel.Properties.Caption = "Model";
            this.rowModel.Properties.FieldName = "Model";
            // 
            // categoryRow1
            // 
            this.categoryRow1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowHP,
            this.rowLiter,
            this.rowCyl,
            this.rowTransmiss_Speed_Count,
            this.rowTransmiss_Automatic});
            this.categoryRow1.Name = "categoryRow1";
            this.categoryRow1.Properties.Caption = "Performance Attributes";
            // 
            // rowHP
            // 
            this.rowHP.Name = "rowHP";
            this.rowHP.Properties.Caption = "HP";
            this.rowHP.Properties.FieldName = "HP";
            // 
            // rowLiter
            // 
            this.rowLiter.Name = "rowLiter";
            this.rowLiter.Properties.Caption = "Capacity";
            this.rowLiter.Properties.FieldName = "Liter";
            this.rowLiter.Properties.Format.FormatString = "#.### Liters";
            this.rowLiter.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // rowCyl
            // 
            this.rowCyl.Name = "rowCyl";
            this.rowCyl.Properties.Caption = "Cyl";
            this.rowCyl.Properties.FieldName = "Cyl";
            // 
            // rowTransmiss_Speed_Count
            // 
            this.rowTransmiss_Speed_Count.Name = "rowTransmiss_Speed_Count";
            this.rowTransmiss_Speed_Count.Properties.Caption = "# of Gears";
            this.rowTransmiss_Speed_Count.Properties.FieldName = "Transmiss Speed Count";
            // 
            // rowTransmiss_Automatic
            // 
            this.rowTransmiss_Automatic.Name = "rowTransmiss_Automatic";
            this.rowTransmiss_Automatic.Properties.Caption = "Automatic Transmission";
            this.rowTransmiss_Automatic.Properties.FieldName = "Transmiss Automatic";
            this.rowTransmiss_Automatic.Properties.ImageIndex = 2;
            // 
            // categoryRow3
            // 
            this.categoryRow3.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowPrice,
            this.rowDelivery_Date,
            this.rowIs_In_Stock});
            this.categoryRow3.Name = "categoryRow3";
            this.categoryRow3.Properties.Caption = "Others";
            // 
            // rowPrice
            // 
            this.rowPrice.Name = "rowPrice";
            this.rowPrice.Properties.Caption = "Price";
            this.rowPrice.Properties.FieldName = "Price";
            this.rowPrice.Properties.Format.FormatString = "c";
            this.rowPrice.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // rowDelivery_Date
            // 
            this.rowDelivery_Date.Name = "rowDelivery_Date";
            this.rowDelivery_Date.Properties.Caption = "Delivery Date";
            this.rowDelivery_Date.Properties.FieldName = "Delivery Date";
            // 
            // rowIs_In_Stock
            // 
            this.rowIs_In_Stock.Name = "rowIs_In_Stock";
            this.rowIs_In_Stock.Properties.Caption = "In Stock?";
            this.rowIs_In_Stock.Properties.FieldName = "Is In Stock";
            this.rowIs_In_Stock.Properties.RowEdit = this.repositoryItemTextEdit1;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 38);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(400, 8);
            this.panelControl1.TabIndex = 14;
            // 
            // RowAlignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel2);
            this.Name = "RowAlignment";
            this.Size = new System.Drawing.Size(400, 414);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.RowAlignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PanelControl panel2;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBox2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBox1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTrademark;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowModel;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowHP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowLiter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCyl;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTransmiss_Speed_Count;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTransmiss_Automatic;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPrice;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDelivery_Date;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowIs_In_Stock;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.ComponentModel.IContainer components = null;
        private PanelControl panelControl1;

    }
}
