namespace DevExpress.XtraTreeList.Demos.Tutorials {
    partial class DataStore {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataStore));
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImageComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(4, 4);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "Project A",
            new System.DateTime(2003, 5, 28, 0, 0, 0),
            2}, -1);
            this.treeList1.AppendNode(new object[] {
            "Deliverable 1",
            new System.DateTime(2003, 5, 30, 0, 0, 0),
            0}, 0, 1, 1, -1);
            this.treeList1.AppendNode(new object[] {
            "This task is mine A",
            new System.DateTime(2003, 6, 12, 0, 0, 0),
            2}, 1, 2, 2, -1);
            this.treeList1.AppendNode(new object[] {
            "This task is not mine A",
            new System.DateTime(2003, 6, 19, 0, 0, 0),
            1}, 1, 2, 2, -1);
            this.treeList1.AppendNode(new object[] {
            "Project B",
            new System.DateTime(2003, 6, 20, 0, 0, 0),
            0}, -1);
            this.treeList1.AppendNode(new object[] {
            "This task is mine B",
            new System.DateTime(2003, 7, 24, 0, 0, 0),
            2}, 4, 2, 2, -1);
            this.treeList1.AppendNode(new object[] {
            "This task is not mine B",
            new System.DateTime(2003, 6, 29, 0, 0, 0),
            1}, 4, 2, 2, -1);
            this.treeList1.AppendNode(new object[] {
            "Project C",
            new System.DateTime(2003, 6, 12, 0, 0, 0),
            1}, -1);
            this.treeList1.AppendNode(new object[] {
            "Deliverable 2",
            new System.DateTime(2003, 6, 26, 0, 0, 0),
            0}, 7, 1, 1, -1);
            this.treeList1.AppendNode(new object[] {
            "Deliverable 3",
            new System.DateTime(2003, 6, 19, 0, 0, 0),
            2}, 7, 1, 1, -1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryImageComboBox1});
            this.treeList1.SelectImageList = this.imageList1;
            this.treeList1.Size = new System.Drawing.Size(555, 292);
            this.treeList1.TabIndex = 6;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.MinWidth = 81;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 240;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Start Date";
            this.treeListColumn2.ColumnEdit = this.repositoryItemDateEdit1;
            this.treeListColumn2.FieldName = "StartDate";
            this.treeListColumn2.Format.FormatString = "d";
            this.treeListColumn2.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.DateTime;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 140;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AllowFocused = false;
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Priority";
            this.treeListColumn3.ColumnEdit = this.repositoryImageComboBox1;
            this.treeListColumn3.FieldName = "Priority";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Integer;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 140;
            // 
            // repositoryImageComboBox1
            // 
            this.repositoryImageComboBox1.AllowFocused = false;
            this.repositoryImageComboBox1.AutoHeight = false;
            this.repositoryImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 1, 1)});
            this.repositoryImageComboBox1.Name = "repositoryImageComboBox1";
            this.repositoryImageComboBox1.SmallImages = this.imageList2;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // DataStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Name = "DataStore";
            this.Size = new System.Drawing.Size(563, 300);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImageComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryImageComboBox1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private System.ComponentModel.IContainer components;

    }
}
