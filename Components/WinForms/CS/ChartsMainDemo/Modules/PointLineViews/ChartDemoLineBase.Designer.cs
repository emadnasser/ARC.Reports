namespace DevExpress.XtraCharts.Demos.PointLineViews {
	partial class ChartDemoLineBase {
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
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
            this.checkEditShowMarkers = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelAngle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowMarkers.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEditMarkerKind
            // 
            this.comboBoxEditMarkerKind.Size = new System.Drawing.Size(107, 20);
            // 
            // comboBoxEditLabelAngle
            // 
            // 
            // comboBoxEditMarkerSize
            // 
            // 
            // panel
            // 
            this.panel.Controls.Add(this.checkEditShowMarkers);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditLabelAngle, 0);
            this.panel.Controls.SetChildIndex(this.labelAngle, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowMarkers, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(600, 37);
            this.checkEditShowLabels.TabIndex = 58;
            // 
            // checkEditShowMarkers
            // 
            this.checkEditShowMarkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEditShowMarkers.Location = new System.Drawing.Point(600, 9);
            this.checkEditShowMarkers.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.checkEditShowMarkers.Name = "checkEditShowMarkers";
            this.checkEditShowMarkers.Properties.Caption = "Show Markers";
            this.checkEditShowMarkers.Size = new System.Drawing.Size(90, 19);
            this.checkEditShowMarkers.TabIndex = 56;
            this.checkEditShowMarkers.CheckedChanged += new System.EventHandler(this.checkEditShowMarkers_CheckedChanged);
            // 
            // ChartDemoLineBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ChartDemoLineBase";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelAngle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowMarkers.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        protected DevExpress.XtraEditors.CheckEdit checkEditShowMarkers;

	}
}
