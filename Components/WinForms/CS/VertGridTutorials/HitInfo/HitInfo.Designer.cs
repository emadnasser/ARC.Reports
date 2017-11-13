using DevExpress.XtraEditors;
namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
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
            this.lbRow = new DevExpress.XtraEditors.LabelControl();
            this.lbHitTest = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbCellValue);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbRow);
            this.panel2.Controls.Add(this.lbHitTest);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 75);
            this.panel2.TabIndex = 8;
            // 
            // lbCellValue
            // 
            this.lbCellValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCellValue.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbCellValue.Appearance.Options.UseBackColor = true;
            this.lbCellValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbCellValue.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbCellValue.Location = new System.Drawing.Point(66, 44);
            this.lbCellValue.Name = "lbCellValue";
            this.lbCellValue.Padding = new System.Windows.Forms.Padding(2);
            this.lbCellValue.Size = new System.Drawing.Size(324, 18);
            this.lbCellValue.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "CellValue:";
            // 
            // lbRow
            // 
            this.lbRow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRow.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbRow.Appearance.Options.UseBackColor = true;
            this.lbRow.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbRow.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbRow.Location = new System.Drawing.Point(211, 10);
            this.lbRow.Name = "lbRow";
            this.lbRow.Padding = new System.Windows.Forms.Padding(2);
            this.lbRow.Size = new System.Drawing.Size(179, 18);
            this.lbRow.TabIndex = 1;
            // 
            // lbHitTest
            // 
            this.lbHitTest.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbHitTest.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHitTest.Appearance.Options.UseBackColor = true;
            this.lbHitTest.Appearance.Options.UseFont = true;
            this.lbHitTest.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbHitTest.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbHitTest.Location = new System.Drawing.Point(66, 10);
            this.lbHitTest.Name = "lbHitTest";
            this.lbHitTest.Padding = new System.Windows.Forms.Padding(2);
            this.lbHitTest.Size = new System.Drawing.Size(97, 18);
            this.lbHitTest.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(180, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Row:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "HitTest:";
            // 
            // vGridControl1
            // 
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.Location = new System.Drawing.Point(0, 83);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.Size = new System.Drawing.Size(407, 459);
            this.vGridControl1.TabIndex = 9;
            this.vGridControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vGridControl1_MouseMove);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 75);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(407, 8);
            this.panelControl1.TabIndex = 13;
            // 
            // HitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel2);
            this.Name = "HitInfo";
            this.Size = new System.Drawing.Size(407, 542);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.HitInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PanelControl panel2;
        private DevExpress.XtraEditors.LabelControl lbCellValue;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.LabelControl lbRow;
        private DevExpress.XtraEditors.LabelControl lbHitTest;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private System.ComponentModel.IContainer components = null;
        private PanelControl panelControl1;

    }
}
