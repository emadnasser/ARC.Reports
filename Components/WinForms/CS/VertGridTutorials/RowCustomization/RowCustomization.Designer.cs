using DevExpress.XtraEditors;
namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    partial class RowCustomization {
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
            this.sbCustomize = new DevExpress.XtraEditors.SimpleButton();
            this.splitter1 = new DevExpress.XtraEditors.SplitterControl();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sbCustomize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(332, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(108, 474);
            this.panel2.TabIndex = 7;
            // 
            // sbCustomize
            // 
            this.sbCustomize.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbCustomize.Location = new System.Drawing.Point(8, 8);
            this.sbCustomize.Name = "sbCustomize";
            this.sbCustomize.Size = new System.Drawing.Size(92, 61);
            this.sbCustomize.TabIndex = 2;
            this.sbCustomize.Text = "Customize...";
            this.sbCustomize.Click += new System.EventHandler(this.sbCustomize_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(326, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 474);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // vGridControl1
            // 
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.Location = new System.Drawing.Point(0, 0);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.Size = new System.Drawing.Size(326, 474);
            this.vGridControl1.TabIndex = 9;
            this.vGridControl1.HideCustomizationForm += new System.EventHandler(this.vGridControl1_HideCustomizationForm);
            // 
            // RowCustomization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Name = "RowCustomization";
            this.Size = new System.Drawing.Size(440, 474);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.RowCustomization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PanelControl panel2;
        private DevExpress.XtraEditors.SplitterControl splitter1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraEditors.SimpleButton sbCustomize;
        private System.ComponentModel.IContainer components = null;

    }
}
