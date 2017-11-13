namespace DevExpress.XtraSpreadsheet.Demos {
    partial class MinesweeperModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.spreadsheetControl = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.cellSizeLabel = new DevExpress.XtraEditors.LabelControl();
            this.NewGameBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.cellSizeTrack = new DevExpress.XtraEditors.TrackBarControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeTrack.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl
            // 
            this.spreadsheetControl.AllowDrop = true;
            this.spreadsheetControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl.Location = new System.Drawing.Point(0, 42);
            this.spreadsheetControl.Name = "spreadsheetControl";
            this.spreadsheetControl.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl.Options.Export.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Options.Export.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Options.Import.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Options.Import.ThrowExceptionOnInvalidDocument = false;
            this.spreadsheetControl.Options.Import.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Size = new System.Drawing.Size(784, 390);
            this.spreadsheetControl.TabIndex = 55;
            this.spreadsheetControl.Text = "spreadsheetControl1";
            // 
            // cellSizeLabel
            // 
            this.cellSizeLabel.Location = new System.Drawing.Point(288, 13);
            this.cellSizeLabel.Name = "cellSizeLabel";
            this.cellSizeLabel.Size = new System.Drawing.Size(43, 13);
            this.cellSizeLabel.TabIndex = 57;
            this.cellSizeLabel.Text = "Cell Size:";
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewGameBtn.Location = new System.Drawing.Point(704, 8);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(75, 23);
            this.NewGameBtn.TabIndex = 58;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.Click += new System.EventHandler(this.Button1Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cellSizeLabel);
            this.panel1.Controls.Add(this.NewGameBtn);
            this.panel1.Controls.Add(this.radioGroup1);
            this.panel1.Controls.Add(this.cellSizeTrack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 42);
            this.panel1.TabIndex = 54;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(3, 8);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Columns = 3;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Beginner"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Intermediate"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Expert")});
            this.radioGroup1.Size = new System.Drawing.Size(279, 23);
            this.radioGroup1.TabIndex = 52;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.RadioGroup1SelectedIndexChanged);
            // 
            // cellSizeTrack
            // 
            this.cellSizeTrack.EditValue = 18;
            this.cellSizeTrack.Location = new System.Drawing.Point(327, 8);
            this.cellSizeTrack.Name = "cellSizeTrack";
            this.cellSizeTrack.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.cellSizeTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cellSizeTrack.Properties.Maximum = 35;
            this.cellSizeTrack.Properties.Minimum = 18;
            this.cellSizeTrack.Size = new System.Drawing.Size(279, 45);
            this.cellSizeTrack.TabIndex = 54;
            this.cellSizeTrack.Value = 18;
            this.cellSizeTrack.ValueChanged += new System.EventHandler(this.CellSizeTrackValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // MinesweeperModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spreadsheetControl);
            this.Controls.Add(this.panel1);
            this.Name = "MinesweeperModule";
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeTrack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeTrack)).EndInit();
            this.ResumeLayout(false);

        }

        private SpreadsheetControl spreadsheetControl;
        private XtraEditors.LabelControl cellSizeLabel;
        private DevExpress.XtraEditors.SimpleButton NewGameBtn;
        private DevExpress.XtraEditors.PanelControl panel1;
        private XtraEditors.RadioGroup radioGroup1;
        private XtraEditors.TrackBarControl cellSizeTrack;
        private System.Windows.Forms.Timer timer1;
    }
}
