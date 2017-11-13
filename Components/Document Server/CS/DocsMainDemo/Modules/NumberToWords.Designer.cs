namespace DevExpress.Docs.Demos {
	partial class NumberToWords {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System.ComponentModel.IContainer components = null;

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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.numberSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.resultTreeList = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.numberSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // numberSpinEdit
            // 
            this.numberSpinEdit.EditValue = new decimal(new int[] {
            4321,
            0,
            0,
            0});
            this.numberSpinEdit.Location = new System.Drawing.Point(94, 18);
            this.numberSpinEdit.Name = "numberSpinEdit";
            this.numberSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numberSpinEdit.Properties.IsFloatValue = false;
            this.numberSpinEdit.Properties.Mask.EditMask = "N00";
            this.numberSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.numberSpinEdit.TabIndex = 0;
            this.numberSpinEdit.ValueChanged += new System.EventHandler(this.spinEdit1_ValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(17, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Number:";
            // 
            // resultTreeList
            // 
            this.resultTreeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTreeList.Location = new System.Drawing.Point(17, 53);
            this.resultTreeList.Name = "resultTreeList";
            this.resultTreeList.OptionsBehavior.Editable = false;
            this.resultTreeList.OptionsView.ShowIndicator = false;
            this.resultTreeList.Size = new System.Drawing.Size(750, 360);
            this.resultTreeList.TabIndex = 2;
            // 
            // NumberToWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultTreeList);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.numberSpinEdit);
            this.Name = "NumberToWords";
            ((System.ComponentModel.ISupportInitialize)(this.numberSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTreeList)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private XtraEditors.SpinEdit numberSpinEdit;
        private XtraEditors.LabelControl labelControl1;
        private XtraTreeList.TreeList resultTreeList;
	}
}
