using System.ComponentModel;

namespace DevExpress.XtraCharts.Demos {
    
    partial class frmMain {
        IContainer components = null;

		protected override void Dispose(bool disposing) {
			if(disposing) 
				if (components != null) 
					components.Dispose();
			base.Dispose(disposing);
		}

        #region Designer generated code

		void InitializeComponent() {
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // pnlCaption
            // 
            this.pnlCaption.Location = new System.Drawing.Point(200, 126);
            this.pnlCaption.Size = new System.Drawing.Size(1078, 47);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(1278, 126);
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 832);
            this.ribbonStatusBar.Size = new System.Drawing.Size(1278, 23);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1278, 855);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "frmMain";
            this.Text = "XtraCharts Features Demo";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

#endregion
    }

}
