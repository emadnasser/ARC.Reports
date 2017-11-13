namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    partial class SimpleMode {
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
            DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties multiEditorRowProperties1 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties multiEditorRowProperties2 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties multiEditorRowProperties3 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties multiEditorRowProperties4 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties multiEditorRowProperties5 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties multiEditorRowProperties6 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties multiEditorRowProperties7 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.categoryRow4 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.editorRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.multiEditorRow1 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.editorRow2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.multiEditorRow2 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.editorRow7 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow8 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow5 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.editorRow4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.multiEditorRow3 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.editorRow6 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow6 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.editorRow9 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow10 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow11 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // vGridControl1
            // 
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.Location = new System.Drawing.Point(4, 4);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 194;
            this.vGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.vGridControl1.RowHeaderWidth = 194;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.categoryRow4,
            this.categoryRow5,
            this.categoryRow6});
            this.vGridControl1.Size = new System.Drawing.Size(383, 445);
            this.vGridControl1.TabIndex = 8;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.AllowFocused = false;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // categoryRow4
            // 
            this.categoryRow4.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow1,
            this.multiEditorRow1,
            this.editorRow2,
            this.editorRow3,
            this.editorRow5,
            this.multiEditorRow2,
            this.editorRow7,
            this.editorRow8});
            this.categoryRow4.Name = "categoryRow4";
            this.categoryRow4.Properties.Caption = "Client";
            // 
            // editorRow1
            // 
            this.editorRow1.Name = "editorRow1";
            this.editorRow1.Properties.Caption = "Client ID";
            this.editorRow1.Properties.FieldName = "ClientID";
            this.editorRow1.Properties.ImageIndex = 0;
            this.editorRow1.Visible = false;
            // 
            // multiEditorRow1
            // 
            this.multiEditorRow1.Name = "multiEditorRow1";
            multiEditorRowProperties1.Caption = "First Name";
            multiEditorRowProperties1.FieldName = "FirstName";
            multiEditorRowProperties1.ImageIndex = 5;
            multiEditorRowProperties1.Width = 22;
            multiEditorRowProperties2.Caption = "Last Name";
            multiEditorRowProperties2.FieldName = "LastName";
            multiEditorRowProperties2.Width = 18;
            this.multiEditorRow1.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            multiEditorRowProperties1,
            multiEditorRowProperties2});
            // 
            // editorRow2
            // 
            this.editorRow2.Name = "editorRow2";
            this.editorRow2.Properties.Caption = "Company Name";
            this.editorRow2.Properties.FieldName = "CompanyName";
            // 
            // editorRow3
            // 
            this.editorRow3.Name = "editorRow3";
            this.editorRow3.Properties.Caption = "Customer";
            this.editorRow3.Properties.FieldName = "Customer";
            // 
            // editorRow5
            // 
            this.editorRow5.Name = "editorRow5";
            this.editorRow5.Properties.Caption = "Gender";
            this.editorRow5.Properties.FieldName = "Gender";
            // 
            // multiEditorRow2
            // 
            this.multiEditorRow2.Name = "multiEditorRow2";
            multiEditorRowProperties3.Caption = "Occupation";
            multiEditorRowProperties3.FieldName = "Occupation";
            multiEditorRowProperties4.Caption = "Risk Level";
            multiEditorRowProperties4.FieldName = "RiskLevel";
            this.multiEditorRow2.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            multiEditorRowProperties3,
            multiEditorRowProperties4});
            // 
            // editorRow7
            // 
            this.editorRow7.Height = 45;
            this.editorRow7.Name = "editorRow7";
            this.editorRow7.Properties.Caption = "Interest (Ctrl+Enter - close editor)";
            this.editorRow7.Properties.FieldName = "Interest";
            this.editorRow7.Properties.RowEdit = this.repositoryItemMemoEdit1;
            // 
            // editorRow8
            // 
            this.editorRow8.Name = "editorRow8";
            this.editorRow8.Properties.Caption = "Date Open";
            this.editorRow8.Properties.FieldName = "DateOpen";
            // 
            // categoryRow5
            // 
            this.categoryRow5.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow4,
            this.multiEditorRow3,
            this.editorRow6});
            this.categoryRow5.Name = "categoryRow5";
            this.categoryRow5.Properties.Caption = "Address";
            this.categoryRow5.Properties.ImageIndex = 6;
            // 
            // editorRow4
            // 
            this.editorRow4.Name = "editorRow4";
            this.editorRow4.Properties.Caption = "Address";
            this.editorRow4.Properties.FieldName = "Address";
            // 
            // multiEditorRow3
            // 
            this.multiEditorRow3.Name = "multiEditorRow3";
            multiEditorRowProperties5.Caption = "City";
            multiEditorRowProperties5.FieldName = "City";
            multiEditorRowProperties5.Width = 18;
            multiEditorRowProperties6.Caption = "State";
            multiEditorRowProperties6.FieldName = "State";
            multiEditorRowProperties6.Width = 18;
            multiEditorRowProperties7.Caption = "Zip Code";
            multiEditorRowProperties7.FieldName = "ZipCode";
            multiEditorRowProperties7.Width = 24;
            this.multiEditorRow3.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            multiEditorRowProperties5,
            multiEditorRowProperties6,
            multiEditorRowProperties7});
            // 
            // editorRow6
            // 
            this.editorRow6.Name = "editorRow6";
            this.editorRow6.Properties.Caption = "Phone";
            this.editorRow6.Properties.FieldName = "Phone";
            // 
            // categoryRow6
            // 
            this.categoryRow6.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow9,
            this.editorRow10,
            this.editorRow11});
            this.categoryRow6.Name = "categoryRow6";
            this.categoryRow6.Properties.Caption = "Payment Information";
            // 
            // editorRow9
            // 
            this.editorRow9.Name = "editorRow9";
            this.editorRow9.Properties.Caption = "Payment Type";
            this.editorRow9.Properties.FieldName = "PaymentType";
            // 
            // editorRow10
            // 
            this.editorRow10.Name = "editorRow10";
            this.editorRow10.Properties.Caption = "Payment Amount";
            this.editorRow10.Properties.FieldName = "PaymentAmount";
            this.editorRow10.Properties.Format.FormatString = "c";
            this.editorRow10.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // editorRow11
            // 
            this.editorRow11.Name = "editorRow11";
            this.editorRow11.Properties.Caption = "Payment Date";
            this.editorRow11.Properties.FieldName = "PaymentDate";
            // 
            // SimpleMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vGridControl1);
            this.Name = "SimpleMode";
            this.Size = new System.Drawing.Size(391, 453);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.SimpleMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow1;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow multiEditorRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow5;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow multiEditorRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow7;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow8;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow5;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow4;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow multiEditorRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow6;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow6;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow9;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow10;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow11;
        private System.ComponentModel.IContainer components = null;

    }
}
