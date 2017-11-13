namespace DevExpress.XtraSpreadsheet.Demos {
    partial class WeatherInCaliforniaModule {
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
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.chkHumidity = new DevExpress.XtraEditors.CheckEdit();
            this.chkPressure = new DevExpress.XtraEditors.CheckEdit();
            this.chkTemperature = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkHumidity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPressure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTemperature.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 60);
            this.ribbonControl1.Size = new System.Drawing.Size(697, 142);
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 202);
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheetControl1.Size = new System.Drawing.Size(697, 208);
            // 
            // panel
            // 
            this.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel.Controls.Add(this.chkHumidity);
            this.panel.Controls.Add(this.chkPressure);
            this.panel.Controls.Add(this.chkTemperature);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(697, 35);
            this.panel.TabIndex = 55;
            // 
            // chkHumidity
            // 
            this.chkHumidity.EditValue = true;
            this.chkHumidity.Location = new System.Drawing.Point(98, 8);
            this.chkHumidity.Name = "chkHumidity";
            this.chkHumidity.Properties.AutoWidth = true;
            this.chkHumidity.Properties.Caption = "Humidity";
            this.chkHumidity.Size = new System.Drawing.Size(63, 19);
            this.chkHumidity.TabIndex = 1;
            this.chkHumidity.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // chkPressure
            // 
            this.chkPressure.EditValue = true;
            this.chkPressure.Location = new System.Drawing.Point(198, 8);
            this.chkPressure.Name = "chkPressure";
            this.chkPressure.Properties.AutoWidth = true;
            this.chkPressure.Properties.Caption = "Pressure";
            this.chkPressure.Size = new System.Drawing.Size(64, 19);
            this.chkPressure.TabIndex = 2;
            this.chkPressure.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // chkTemperature
            // 
            this.chkTemperature.EditValue = true;
            this.chkTemperature.Location = new System.Drawing.Point(0, 8);
            this.chkTemperature.Name = "chkTemperature";
            this.chkTemperature.Properties.AutoWidth = true;
            this.chkTemperature.Properties.Caption = "Temperature";
            this.chkTemperature.Size = new System.Drawing.Size(84, 19);
            this.chkTemperature.TabIndex = 0;
            this.chkTemperature.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // WeatherInCaliforniaModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "WeatherInCaliforniaModule";
            this.Size = new System.Drawing.Size(697, 410);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkHumidity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPressure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTemperature.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraEditors.PanelControl panel;
        protected XtraEditors.CheckEdit chkTemperature;
        protected XtraEditors.CheckEdit chkPressure;
        protected XtraEditors.CheckEdit chkHumidity;
    }
}
