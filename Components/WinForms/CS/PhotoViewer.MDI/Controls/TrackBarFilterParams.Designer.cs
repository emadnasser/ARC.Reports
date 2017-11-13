namespace PhotoViewer {
    partial class TrackBarFilterParams {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.trackBar = new DevExpress.XtraEditors.TrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleFilterParamsConvertedLayout)).BeginInit();
            this.SimpleFilterParamsConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyButtonItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar.Properties)).BeginInit();
            this.SuspendLayout();
            this.SimpleFilterParamsConvertedLayout.Controls.SetChildIndex(this.applyFilterButton, 0);
            // 
            // trackBarControl1
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.EditValue = 500;
            this.trackBar.Location = new System.Drawing.Point(104, 51);
            this.trackBar.Name = "trackBarControl1";
            this.trackBar.Properties.Alignment = DevExpress.Utils.VertAlignment.Center;
            this.trackBar.Properties.AllowFocused = false;
            this.trackBar.Properties.AutoSize = false;
            this.trackBar.Properties.Maximum = 1000;
            this.trackBar.Properties.ShowValueToolTip = true;
            this.trackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Properties.BeforeShowValueToolTip += new DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(this.OnBeforeShowTrackBarValueToolTip);
            this.trackBar.Size = new System.Drawing.Size(216, 70);
            this.trackBar.TabIndex = 1;
            this.trackBar.Value = 500;
            this.trackBar.EditValueChanged += new System.EventHandler(this.trackBar_EditValueChanged);
            // 
            // TrackBarFilterParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TrackBarFilterParams";
            ((System.ComponentModel.ISupportInitialize)(this.SimpleFilterParamsConvertedLayout)).EndInit();
            this.SimpleFilterParamsConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyButtonItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.TrackBarControl trackBar;

    }
}
