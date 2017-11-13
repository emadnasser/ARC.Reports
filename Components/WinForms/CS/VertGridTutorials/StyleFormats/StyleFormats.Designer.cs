using DevExpress.XtraEditors;
namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    partial class StyleFormats {
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
            this.panel2 = new PanelControl();
            this.lsStyles = new DevExpress.XtraEditors.ListBoxControl();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new DevExpress.XtraEditors.SplitterControl();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsStyles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsStyles);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(128, 482);
            this.panel2.TabIndex = 9;
            // 
            // lsStyles
            // 
            this.lsStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsStyles.ItemHeight = 15;
            this.lsStyles.Location = new System.Drawing.Point(4, 24);
            this.lsStyles.Name = "lsStyles";
            this.lsStyles.Size = new System.Drawing.Size(120, 454);
            this.lsStyles.TabIndex = 16;
            this.lsStyles.SelectedIndexChanged += new System.EventHandler(this.lsStyles_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Style Formats:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(128, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 482);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // vGridControl1
            // 
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.Location = new System.Drawing.Point(134, 0);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.Size = new System.Drawing.Size(349, 482);
            this.vGridControl1.TabIndex = 11;
            // 
            // StyleFormats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Name = "StyleFormats";
            this.Size = new System.Drawing.Size(483, 482);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.StyleFormats_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lsStyles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PanelControl panel2;
        private DevExpress.XtraEditors.SplitterControl splitter1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraEditors.ListBoxControl lsStyles;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.IContainer components = null;

    }
}
