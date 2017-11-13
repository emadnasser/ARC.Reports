namespace DevExpress.XtraGrid.Demos.Tutorials {
    partial class GridHitInfoForm {
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
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.lbBand = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.lbCellValue = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.lbRow = new DevExpress.XtraEditors.LabelControl();
            this.lbColumn = new DevExpress.XtraEditors.LabelControl();
            this.lbHitTest = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel1.Controls.Add(this.lbBand);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbCellValue);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbRow);
            this.panel1.Controls.Add(this.lbColumn);
            this.panel1.Controls.Add(this.lbHitTest);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 80);
            this.panel1.TabIndex = 3;
            // 
            // lbBand
            // 
            this.lbBand.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbBand.Appearance.Options.UseBackColor = true;
            this.lbBand.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbBand.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbBand.Location = new System.Drawing.Point(68, 30);
            this.lbBand.Name = "lbBand";
            this.lbBand.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lbBand.Size = new System.Drawing.Size(244, 18);
            this.lbBand.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Band:";
            // 
            // lbCellValue
            // 
            this.lbCellValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCellValue.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbCellValue.Appearance.Options.UseBackColor = true;
            this.lbCellValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbCellValue.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbCellValue.Location = new System.Drawing.Point(373, 54);
            this.lbCellValue.Name = "lbCellValue";
            this.lbCellValue.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lbCellValue.Size = new System.Drawing.Size(298, 18);
            this.lbCellValue.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(320, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "CellValue:";
            // 
            // lbRow
            // 
            this.lbRow.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbRow.Appearance.Options.UseBackColor = true;
            this.lbRow.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbRow.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbRow.Location = new System.Drawing.Point(68, 54);
            this.lbRow.Name = "lbRow";
            this.lbRow.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lbRow.Size = new System.Drawing.Size(244, 18);
            this.lbRow.TabIndex = 8;
            // 
            // lbColumn
            // 
            this.lbColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbColumn.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbColumn.Appearance.Options.UseBackColor = true;
            this.lbColumn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbColumn.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbColumn.Location = new System.Drawing.Point(373, 30);
            this.lbColumn.Name = "lbColumn";
            this.lbColumn.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lbColumn.Size = new System.Drawing.Size(298, 18);
            this.lbColumn.TabIndex = 9;
            // 
            // lbHitTest
            // 
            this.lbHitTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHitTest.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.lbHitTest.Appearance.Options.UseBackColor = true;
            this.lbHitTest.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbHitTest.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbHitTest.Location = new System.Drawing.Point(68, 6);
            this.lbHitTest.Name = "lbHitTest";
            this.lbHitTest.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lbHitTest.Size = new System.Drawing.Size(603, 18);
            this.lbHitTest.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "RowHandle:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(328, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Column:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "HitTest:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(685, 386);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            this.gridControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseMove);
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            // 
            // GridHitInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "GridHitInfoForm";
            this.Size = new System.Drawing.Size(685, 466);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.GridHitInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraEditors.LabelControl lbCellValue;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.LabelControl lbRow;
        private DevExpress.XtraEditors.LabelControl lbColumn;
        private DevExpress.XtraEditors.LabelControl lbHitTest;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl lbBand;
        private DevExpress.XtraEditors.LabelControl label2;
        private System.ComponentModel.IContainer components = null;

    }
}
