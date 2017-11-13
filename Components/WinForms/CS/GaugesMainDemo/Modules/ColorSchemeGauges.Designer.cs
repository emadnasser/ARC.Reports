namespace DevExpress.XtraGauges.Demos {
    partial class ColorSchemeGauges {
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
            this.colorPickControl = new DevExpress.XtraGauges.Demos.ColorPickerControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gaugesDashboard1 = new DevExpress.XtraGauges.Demos.GaugesDashboard();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorPickEditTabControlBase1
            // 
            this.colorPickControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPickControl.Location = new System.Drawing.Point(0, 10);
            this.colorPickControl.Margin = new System.Windows.Forms.Padding(10);
            this.colorPickControl.Name = "colorPickEditTabControlBase1";
            this.colorPickControl.Size = new System.Drawing.Size(271, 600);
            this.colorPickControl.TabIndex = 1;
            this.colorPickControl.TabStop = false;
            this.colorPickControl.ResultColorChanged += ColorPickControlResultColorChanged;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.colorPickControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(481, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.panel1.Size = new System.Drawing.Size(281, 620);
            this.panel1.TabIndex = 2;
            // 
            // gaugesDashboard1
            // 
            this.gaugesDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugesDashboard1.Location = new System.Drawing.Point(0, 0);
            this.gaugesDashboard1.Name = "gaugesDashboard1";
            this.gaugesDashboard1.Size = new System.Drawing.Size(481, 620);
            this.gaugesDashboard1.TabIndex = 3;
            // 
            // ColorSchemeGauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gaugesDashboard1);
            this.Controls.Add(this.panel1);
            this.Name = "ColorSchemeGauge";
            this.Size = new System.Drawing.Size(762, 620);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private ColorPickerControl colorPickControl;
        private System.Windows.Forms.Panel panel1;
        private GaugesDashboard gaugesDashboard1;
    }
}
