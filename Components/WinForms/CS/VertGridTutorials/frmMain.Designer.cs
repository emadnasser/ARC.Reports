namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    partial class frmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.pnlCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNavigations)).BeginInit();
            this.gcNavigations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horzSplitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDescription)).BeginInit();
            this.gcDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.pcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWhatsThis
            // 
            this.btnWhatsThis.Location = new System.Drawing.Point(640, 9);
            this.btnWhatsThis.Size = new System.Drawing.Size(96, 37);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(76, 9);
            // 
            // pnlHint
            // 
            this.pnlHint.Size = new System.Drawing.Size(696, 33);
            // 
            // pnlCaption
            // 
            this.pnlCaption.Location = new System.Drawing.Point(204, 22);
            this.pnlCaption.Size = new System.Drawing.Size(716, 59);
            // 
            // gcNavigations
            // 
            this.gcNavigations.Controls.Add(this.listBoxControl1);
            this.gcNavigations.Location = new System.Drawing.Point(0, 22);
            this.gcNavigations.Size = new System.Drawing.Size(204, 628);
            this.gcNavigations.Controls.SetChildIndex(this.listBoxControl1, 0);
            // 
            // gcContainer
            // 
            this.gcContainer.Size = new System.Drawing.Size(700, 508);
            // 
            // horzSplitter
            // 
            this.horzSplitter.Location = new System.Drawing.Point(8, 516);
            this.horzSplitter.Size = new System.Drawing.Size(700, 8);
            // 
            // gcDescription
            // 
            this.gcDescription.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gcDescription.Appearance.Options.UseBackColor = true;
            this.gcDescription.Location = new System.Drawing.Point(8, 524);
            this.gcDescription.Size = new System.Drawing.Size(700, 37);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Blue";
            // 
            // pcMain
            // 
            this.pcMain.Location = new System.Drawing.Point(204, 81);
            this.pcMain.Size = new System.Drawing.Size(716, 569);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl1.ItemHeight = 16;
            this.listBoxControl1.Location = new System.Drawing.Point(21, 2);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(181, 624);
            this.listBoxControl1.TabIndex = 0;
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(920, 650);
            this.HintVisible = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Tutorials (C# code)";
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.ImagePatternFill = ((System.Drawing.Image)(resources.GetObject("frmMain.TutorialInfo.ImagePatternFill")));
            this.TutorialInfo.ImageWhatsThisButton = ((System.Drawing.Image)(resources.GetObject("frmMain.TutorialInfo.ImageWhatsThisButton")));
            this.TutorialInfo.ImageWhatsThisButtonStop = ((System.Drawing.Image)(resources.GetObject("frmMain.TutorialInfo.ImageWhatsThisButtonStop")));
            this.TutorialInfo.SourceFileComment = "//";
            this.TutorialInfo.SourceFileType = DevExpress.Tutorials.SourceFileType.CS;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.pnlCaption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNavigations)).EndInit();
            this.gcNavigations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horzSplitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDescription)).EndInit();
            this.gcDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.pcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private System.ComponentModel.IContainer components = null;

    }
}
