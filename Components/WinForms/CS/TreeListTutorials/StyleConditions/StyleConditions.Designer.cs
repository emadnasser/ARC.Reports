namespace DevExpress.XtraTreeList.Demos.Tutorials {
    partial class StyleConditions {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StyleConditions));
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            this.tlcDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.tlcPriority = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tlcRejected = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new DevExpress.XtraEditors.CheckEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.tlcName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            this.panel3.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlcDate
            // 
            this.tlcDate.Caption = "Start Date";
            this.tlcDate.ColumnEdit = this.repositoryItemDateEdit2;
            this.tlcDate.FieldName = "StartDate";
            this.tlcDate.Format.FormatString = "d";
            this.tlcDate.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tlcDate.Name = "tlcDate";
            this.tlcDate.Visible = true;
            this.tlcDate.VisibleIndex = 1;
            this.tlcDate.Width = 121;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AllowFocused = false;
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            this.repositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // tlcPriority
            // 
            this.tlcPriority.Caption = "Priority";
            this.tlcPriority.ColumnEdit = this.repositoryItemImageComboBox1;
            this.tlcPriority.FieldName = "Priority";
            this.tlcPriority.Name = "tlcPriority";
            this.tlcPriority.Visible = true;
            this.tlcPriority.VisibleIndex = 2;
            this.tlcPriority.Width = 118;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AllowFocused = false;
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 1, 1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageList2;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            // 
            // tlcRejected
            // 
            this.tlcRejected.Caption = "Rejected";
            this.tlcRejected.ColumnEdit = this.repositoryItemCheckEdit2;
            this.tlcRejected.FieldName = "Rejected";
            this.tlcRejected.Name = "tlcRejected";
            this.tlcRejected.Visible = true;
            this.tlcRejected.VisibleIndex = 3;
            this.tlcRejected.Width = 60;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AllowFocused = false;
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
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
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AllowFocused = false;
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowFocused = false;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(2, 39);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "Project A",
            new System.DateTime(2003, 5, 28, 0, 0, 0),
            2,
            true}, -1);
            this.treeList1.AppendNode(new object[] {
            "Deliverable 1",
            new System.DateTime(2003, 5, 30, 0, 0, 0),
            0,
            true}, 0, 1, 1, -1);
            this.treeList1.AppendNode(new object[] {
            "This task is mine A",
            new System.DateTime(2003, 6, 12, 0, 0, 0),
            0,
            false}, 1, 2, 2, -1);
            this.treeList1.AppendNode(new object[] {
            "This task is not mine A",
            new System.DateTime(2003, 6, 19, 0, 0, 0),
            1,
            true}, 1, 2, 2, -1);
            this.treeList1.AppendNode(new object[] {
            "Project B",
            new System.DateTime(2003, 6, 20, 0, 0, 0),
            0,
            false}, -1);
            this.treeList1.AppendNode(new object[] {
            "This task is mine B",
            new System.DateTime(2003, 7, 24, 0, 0, 0),
            2,
            false}, 4, 2, 2, -1);
            this.treeList1.AppendNode(new object[] {
            "This task is not mine B",
            new System.DateTime(2003, 6, 29, 0, 0, 0),
            1,
            false}, 4, 2, 2, -1);
            this.treeList1.AppendNode(new object[] {
            "Project C",
            new System.DateTime(2003, 6, 12, 0, 0, 0),
            2,
            true}, -1);
            this.treeList1.AppendNode(new object[] {
            "Deliverable 2",
            new System.DateTime(2003, 6, 26, 0, 0, 0),
            0,
            true}, 7, 1, 1, -1);
            this.treeList1.AppendNode(new object[] {
            "Deliverable 3",
            new System.DateTime(2003, 6, 19, 0, 0, 0),
            1,
            false}, 7, 1, 1, -1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryImageComboBox1,
            this.repositoryItemCheckEdit1});
            this.treeList1.SelectImageList = this.imageList1;
            this.treeList1.Size = new System.Drawing.Size(562, 267);
            this.treeList1.TabIndex = 8;
            this.treeList1.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.treeList1_NodeCellStyle);
            this.treeList1.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeList1_CustomDrawNodeCell);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.MinWidth = 81;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 221;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Start Date";
            this.treeListColumn2.ColumnEdit = this.repositoryItemDateEdit1;
            this.treeListColumn2.FieldName = "StartDate";
            this.treeListColumn2.Format.FormatString = "d";
            this.treeListColumn2.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 121;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Priority";
            this.treeListColumn3.ColumnEdit = this.repositoryImageComboBox1;
            this.treeListColumn3.FieldName = "Priority";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 118;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Rejected";
            this.treeListColumn4.ColumnEdit = this.repositoryItemCheckEdit1;
            this.treeListColumn4.FieldName = "Rejected";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            this.treeListColumn4.Width = 60;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 37);
            this.panel2.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(9, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Properties.Caption = "Use custom style for the \"Name\" column only";
            this.checkBox1.Size = new System.Drawing.Size(284, 18);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(575, 338);
            this.xtraTabControl1.TabIndex = 10;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.treeList2);
            this.xtraTabPage1.Controls.Add(this.panel3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.xtraTabPage1.Size = new System.Drawing.Size(566, 308);
            this.xtraTabPage1.Text = "Style Conditions";
            // 
            // treeList2
            // 
            this.treeList2.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcName,
            this.tlcDate,
            this.tlcPriority,
            this.tlcRejected});
            this.treeList2.Dock = System.Windows.Forms.DockStyle.Fill;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Column = this.tlcDate;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between;
            styleFormatCondition1.Value1 = new System.DateTime(2003, 6, 10, 10, 2, 10, 0);
            styleFormatCondition1.Value2 = new System.DateTime(2003, 6, 19, 10, 2, 35, 0);
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Column = this.tlcPriority;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = 2;
            styleFormatCondition3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Gray;
            styleFormatCondition3.Appearance.Options.UseFont = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.tlcRejected;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = true;
            this.treeList2.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.treeList2.Location = new System.Drawing.Point(2, 39);
            this.treeList2.Name = "treeList2";
            this.treeList2.BeginUnboundLoad();
            this.treeList2.AppendNode(new object[] {
            "Project A",
            new System.DateTime(2003, 5, 28, 0, 0, 0),
            2,
            true}, -1);
            this.treeList2.AppendNode(new object[] {
            "Deliverable 1",
            new System.DateTime(2003, 5, 30, 0, 0, 0),
            0,
            true}, 0, 1, 1, -1);
            this.treeList2.AppendNode(new object[] {
            "This task is mine A",
            new System.DateTime(2003, 6, 12, 0, 0, 0),
            0,
            false}, 1, 2, 2, -1);
            this.treeList2.AppendNode(new object[] {
            "This task is not mine A",
            new System.DateTime(2003, 6, 19, 0, 0, 0),
            1,
            true}, 1, 2, 2, -1);
            this.treeList2.AppendNode(new object[] {
            "Project B",
            new System.DateTime(2003, 6, 20, 0, 0, 0),
            0,
            false}, -1);
            this.treeList2.AppendNode(new object[] {
            "This task is mine B",
            new System.DateTime(2003, 7, 24, 0, 0, 0),
            2,
            false}, 4, 2, 2, -1);
            this.treeList2.AppendNode(new object[] {
            "This task is not mine B",
            new System.DateTime(2003, 6, 29, 0, 0, 0),
            1,
            false}, 4, 2, 2, -1);
            this.treeList2.AppendNode(new object[] {
            "Project C",
            new System.DateTime(2003, 6, 12, 0, 0, 0),
            2,
            false}, -1);
            this.treeList2.AppendNode(new object[] {
            "Deliverable 2",
            new System.DateTime(2003, 6, 26, 0, 0, 0),
            0,
            true}, 7, 1, 1, -1);
            this.treeList2.AppendNode(new object[] {
            "Deliverable 3",
            new System.DateTime(2003, 6, 19, 0, 0, 0),
            1,
            false}, 7, 1, 1, -1);
            this.treeList2.EndUnboundLoad();
            this.treeList2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit2,
            this.repositoryItemImageComboBox1,
            this.repositoryItemCheckEdit2});
            this.treeList2.SelectImageList = this.imageList1;
            this.treeList2.Size = new System.Drawing.Size(562, 267);
            this.treeList2.TabIndex = 11;
            // 
            // tlcName
            // 
            this.tlcName.Caption = "Name";
            this.tlcName.FieldName = "Name";
            this.tlcName.MinWidth = 81;
            this.tlcName.Name = "tlcName";
            this.tlcName.Visible = true;
            this.tlcName.VisibleIndex = 0;
            this.tlcName.Width = 221;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(562, 37);
            this.panel3.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(8, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(156, 22);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Show style conditions";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.treeList1);
            this.xtraTabPage2.Controls.Add(this.panel2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.xtraTabPage2.Size = new System.Drawing.Size(566, 308);
            this.xtraTabPage2.Text = "Custom Draw";
            // 
            // StyleConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "StyleConditions";
            this.Size = new System.Drawing.Size(575, 338);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryImageComboBox1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.CheckEdit checkBox1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcPriority;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcRejected;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.ComponentModel.IContainer components;

    }
}
