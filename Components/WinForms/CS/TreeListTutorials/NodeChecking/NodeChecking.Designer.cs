namespace DevExpress.XtraTreeList.Demos.Tutorials {
    partial class NodeChecking {
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.chkAllowIndeterminate = new DevExpress.XtraEditors.CheckEdit();
            this.chkAllowRecursive = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowIndeterminate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowRecursive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 50);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.treeList1.OptionsView.ShowCheckBoxes = true;
            this.treeList1.Size = new System.Drawing.Size(551, 250);
            this.treeList1.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 42);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(551, 8);
            this.panelControl1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkAllowIndeterminate);
            this.panel2.Controls.Add(this.chkAllowRecursive);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 42);
            this.panel2.TabIndex = 11;
            // 
            // chkAllowIndeterminate
            // 
            this.chkAllowIndeterminate.Location = new System.Drawing.Point(193, 12);
            this.chkAllowIndeterminate.Name = "chkAllowIndeterminate";
            this.chkAllowIndeterminate.Properties.Caption = "Allow Indeterminate Check State";
            this.chkAllowIndeterminate.Properties.CheckedChanged += new System.EventHandler(this.chkAllowRecursive_Properties_CheckedChanged);
            this.chkAllowIndeterminate.Size = new System.Drawing.Size(187, 19);
            this.chkAllowIndeterminate.TabIndex = 3;
            this.chkAllowIndeterminate.CheckedChanged += new System.EventHandler(this.chkAllowIndeterminate_CheckedChanged);
            // 
            // chkAllowRecursive
            // 
            this.chkAllowRecursive.EditValue = true;
            this.chkAllowRecursive.Location = new System.Drawing.Point(10, 12);
            this.chkAllowRecursive.Name = "chkAllowRecursive";
            this.chkAllowRecursive.Properties.Caption = "Allow Recursive Node Checking";
            this.chkAllowRecursive.Properties.CheckedChanged += new System.EventHandler(this.chkAllowRecursive_Properties_CheckedChanged);
            this.chkAllowRecursive.Size = new System.Drawing.Size(177, 19);
            this.chkAllowRecursive.TabIndex = 3;
            this.chkAllowRecursive.CheckedChanged += new System.EventHandler(this.chkAllowRecursive_Properties_CheckedChanged);
            // 
            // NodeChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel2);
            this.Name = "NodeChecking";
            this.Size = new System.Drawing.Size(551, 300);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowIndeterminate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowRecursive.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panel2;
        private DevExpress.XtraEditors.CheckEdit chkAllowIndeterminate;
        private DevExpress.XtraEditors.CheckEdit chkAllowRecursive;

    }
}
