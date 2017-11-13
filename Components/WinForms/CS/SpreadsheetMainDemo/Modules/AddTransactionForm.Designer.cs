namespace DevExpress.XtraSpreadsheet.Demos
{
	partial class AddTransactionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.categoryComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.categoryLabel = new DevExpress.XtraEditors.LabelControl();
            this.sumEdit = new DevExpress.XtraEditors.SpinEdit();
            this.sumLabel = new DevExpress.XtraEditors.LabelControl();
            this.monthLabel = new DevExpress.XtraEditors.LabelControl();
            this.monthComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dayLabel = new DevExpress.XtraEditors.LabelControl();
            this.OKButton = new DevExpress.XtraEditors.SimpleButton();
            this.CnclButton = new DevExpress.XtraEditors.SimpleButton();
            this.dayTextEdit = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.EditValue = "";
            this.categoryComboBox.Location = new System.Drawing.Point(65, 12);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryComboBox.Size = new System.Drawing.Size(138, 20);
            this.categoryComboBox.TabIndex = 55;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Location = new System.Drawing.Point(12, 15);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 56;
            this.categoryLabel.Text = "Category:";
            // 
            // sumEdit
            // 
            this.sumEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sumEdit.Location = new System.Drawing.Point(65, 38);
            this.sumEdit.Name = "sumEdit";
            this.sumEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sumEdit.Properties.Mask.EditMask = "c";
            this.sumEdit.Size = new System.Drawing.Size(138, 20);
            this.sumEdit.TabIndex = 57;
            // 
            // sumLabel
            // 
            this.sumLabel.Location = new System.Drawing.Point(12, 41);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(24, 13);
            this.sumLabel.TabIndex = 58;
            this.sumLabel.Text = "Sum:";
            // 
            // monthLabel
            // 
            this.monthLabel.Location = new System.Drawing.Point(209, 15);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(34, 13);
            this.monthLabel.TabIndex = 59;
            this.monthLabel.Text = "Month:";
            // 
            // monthComboBox
            // 
            this.monthComboBox.EditValue = "";
            this.monthComboBox.Location = new System.Drawing.Point(249, 12);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.monthComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.monthComboBox.Size = new System.Drawing.Size(138, 20);
            this.monthComboBox.TabIndex = 60;
            this.monthComboBox.EditValueChanged += new System.EventHandler(this.MonthComboBoxEditValueChanged);
            // 
            // dayLabel
            // 
            this.dayLabel.Location = new System.Drawing.Point(209, 41);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(23, 13);
            this.dayLabel.TabIndex = 61;
            this.dayLabel.Text = "Day:";
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(231, 64);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 63;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // CnclButton
            // 
            this.CnclButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CnclButton.Location = new System.Drawing.Point(312, 64);
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(75, 23);
            this.CnclButton.TabIndex = 64;
            this.CnclButton.Text = "Cancel";
            // 
            // dayTextEdit
            // 
            this.dayTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dayTextEdit.Location = new System.Drawing.Point(249, 38);
            this.dayTextEdit.Name = "dayTextEdit";
            this.dayTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dayTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.dayTextEdit.Properties.Mask.EditMask = "n0";
            this.dayTextEdit.Size = new System.Drawing.Size(138, 20);
            this.dayTextEdit.TabIndex = 62;
            // 
            // AddTransactionForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CnclButton;
            this.ClientSize = new System.Drawing.Size(399, 99);
            this.Controls.Add(this.CnclButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.sumEdit);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.dayTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddTransactionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add transaction";
            ((System.ComponentModel.ISupportInitialize)(this.categoryComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
		}

		#endregion

        private DevExpress.XtraEditors.ComboBoxEdit categoryComboBox;
        private DevExpress.XtraEditors.LabelControl categoryLabel;
        private DevExpress.XtraEditors.SpinEdit sumEdit;
        private DevExpress.XtraEditors.LabelControl sumLabel;
        private DevExpress.XtraEditors.LabelControl monthLabel;
        private DevExpress.XtraEditors.ComboBoxEdit monthComboBox;
        private DevExpress.XtraEditors.LabelControl dayLabel;
        private DevExpress.XtraEditors.SimpleButton OKButton;
        private DevExpress.XtraEditors.SimpleButton CnclButton;
        private DevExpress.XtraEditors.SpinEdit dayTextEdit;
	}
}
