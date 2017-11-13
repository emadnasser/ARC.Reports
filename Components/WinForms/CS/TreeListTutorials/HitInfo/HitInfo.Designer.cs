using DevExpress.XtraEditors;
namespace DevExpress.XtraTreeList.Demos.Tutorials {
    partial class HitInfo {
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
            this.lbCellValue = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.lbNode = new DevExpress.XtraEditors.LabelControl();
            this.lbColumn = new DevExpress.XtraEditors.LabelControl();
            this.lbHitTest = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbCellValue);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbNode);
            this.panel2.Controls.Add(this.lbColumn);
            this.panel2.Controls.Add(this.lbHitTest);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 41);
            this.panel2.TabIndex = 6;
            // 
            // lbCellValue
            // 
            this.lbCellValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCellValue.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbCellValue.Appearance.Options.UseBackColor = true;
            this.lbCellValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbCellValue.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbCellValue.Location = new System.Drawing.Point(470, 10);
            this.lbCellValue.Name = "lbCellValue";
            this.lbCellValue.Padding = new System.Windows.Forms.Padding(2);
            this.lbCellValue.Size = new System.Drawing.Size(75, 18);
            this.lbCellValue.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(417, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "CellValue:";
            // 
            // lbNode
            // 
            this.lbNode.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbNode.Appearance.Options.UseBackColor = true;
            this.lbNode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbNode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbNode.Location = new System.Drawing.Point(358, 10);
            this.lbNode.Name = "lbNode";
            this.lbNode.Padding = new System.Windows.Forms.Padding(2);
            this.lbNode.Size = new System.Drawing.Size(44, 18);
            this.lbNode.TabIndex = 1;
            // 
            // lbColumn
            // 
            this.lbColumn.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbColumn.Appearance.Options.UseBackColor = true;
            this.lbColumn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbColumn.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbColumn.Location = new System.Drawing.Point(218, 10);
            this.lbColumn.Name = "lbColumn";
            this.lbColumn.Padding = new System.Windows.Forms.Padding(2);
            this.lbColumn.Size = new System.Drawing.Size(77, 18);
            this.lbColumn.TabIndex = 1;
            // 
            // lbHitTest
            // 
            this.lbHitTest.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbHitTest.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHitTest.Appearance.Options.UseBackColor = true;
            this.lbHitTest.Appearance.Options.UseFont = true;
            this.lbHitTest.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbHitTest.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbHitTest.Location = new System.Drawing.Point(56, 10);
            this.lbHitTest.Name = "lbHitTest";
            this.lbHitTest.Padding = new System.Windows.Forms.Padding(2);
            this.lbHitTest.Size = new System.Drawing.Size(99, 18);
            this.lbHitTest.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(312, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "NodeID:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(173, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Column:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "HitTest:";
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 49);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(616, 251);
            this.treeList1.TabIndex = 7;
            this.treeList1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseMove);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 41);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(616, 8);
            this.panelControl1.TabIndex = 9;
            // 
            // HitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel2);
            this.Name = "HitInfo";
            this.Size = new System.Drawing.Size(616, 300);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PanelControl panel2;
        private DevExpress.XtraEditors.LabelControl lbCellValue;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.LabelControl lbNode;
        private DevExpress.XtraEditors.LabelControl lbColumn;
        private DevExpress.XtraEditors.LabelControl lbHitTest;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.ComponentModel.Container components = null;
        private PanelControl panelControl1;

    }
}
