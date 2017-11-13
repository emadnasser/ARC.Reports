namespace DevExpress.XtraEditors.Demos {
    partial class LookUpProperties {
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
            this.lblSelect = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.lbDisplay = new DevExpress.XtraEditors.LabelControl();
            this.lbValue = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ceCaseSensitiveSearch = new DevExpress.XtraEditors.CheckEdit();
            this.icbSearchMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.icbHeaderClickMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.seColumnIndex = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ceShowLines = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowHeader = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowFooter = new DevExpress.XtraEditors.CheckEdit();
            this.ceHotTrack = new DevExpress.XtraEditors.CheckEdit();
            this.teNullText = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.seItemHeight = new DevExpress.XtraEditors.SpinEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceCaseSensitiveSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSearchMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbHeaderClickMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seColumnIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowLines.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowFooter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHotTrack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNullText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seItemHeight.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.Location = new System.Drawing.Point(30, 20);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(79, 13);
            this.lblSelect.TabIndex = 13;
            this.lblSelect.Text = "Display Member:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Value Member:";
            // 
            // lbDisplay
            // 
            this.lbDisplay.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbDisplay.Location = new System.Drawing.Point(126, 20);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(47, 13);
            this.lbDisplay.TabIndex = 15;
            this.lbDisplay.Text = "Member";
            // 
            // lbValue
            // 
            this.lbValue.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbValue.Location = new System.Drawing.Point(126, 42);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(47, 13);
            this.lbValue.TabIndex = 16;
            this.lbValue.Text = "Member";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ceCaseSensitiveSearch);
            this.groupControl1.Controls.Add(this.icbSearchMode);
            this.groupControl1.Controls.Add(this.icbHeaderClickMode);
            this.groupControl1.Controls.Add(this.seColumnIndex);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(30, 66);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(255, 163);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Search";
            // 
            // ceCaseSensitiveSearch
            // 
            this.ceCaseSensitiveSearch.Location = new System.Drawing.Point(18, 119);
            this.ceCaseSensitiveSearch.Name = "ceCaseSensitiveSearch";
            this.ceCaseSensitiveSearch.Properties.Caption = "Case sensitive search";
            this.ceCaseSensitiveSearch.Size = new System.Drawing.Size(148, 19);
            this.ceCaseSensitiveSearch.TabIndex = 20;
            this.ceCaseSensitiveSearch.CheckedChanged += new System.EventHandler(this.ceCaseSensitiveSearch_CheckedChanged);
            // 
            // icbSearchMode
            // 
            this.icbSearchMode.EditValue = "imageComboBoxEdit2";
            this.icbSearchMode.Location = new System.Drawing.Point(124, 90);
            this.icbSearchMode.Name = "icbSearchMode";
            this.icbSearchMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbSearchMode.Size = new System.Drawing.Size(112, 20);
            this.icbSearchMode.TabIndex = 19;
            this.icbSearchMode.SelectedIndexChanged += new System.EventHandler(this.icbSearchMode_SelectedIndexChanged);
            // 
            // icbHeaderClickMode
            // 
            this.icbHeaderClickMode.EditValue = "imageComboBoxEdit1";
            this.icbHeaderClickMode.Location = new System.Drawing.Point(124, 61);
            this.icbHeaderClickMode.Name = "icbHeaderClickMode";
            this.icbHeaderClickMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbHeaderClickMode.Size = new System.Drawing.Size(112, 20);
            this.icbHeaderClickMode.TabIndex = 18;
            this.icbHeaderClickMode.SelectedIndexChanged += new System.EventHandler(this.icbHeaderClickMode_SelectedIndexChanged);
            // 
            // seColumnIndex
            // 
            this.seColumnIndex.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seColumnIndex.Location = new System.Drawing.Point(176, 32);
            this.seColumnIndex.Name = "seColumnIndex";
            this.seColumnIndex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seColumnIndex.Properties.IsFloatValue = false;
            this.seColumnIndex.Properties.Mask.EditMask = "N00";
            this.seColumnIndex.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.seColumnIndex.Size = new System.Drawing.Size(60, 20);
            this.seColumnIndex.TabIndex = 17;
            this.seColumnIndex.EditValueChanged += new System.EventHandler(this.seColumnIndex_EditValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Search mode:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Header click mode:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Auto-search column index:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ceShowLines);
            this.groupControl2.Controls.Add(this.ceShowHeader);
            this.groupControl2.Controls.Add(this.ceShowFooter);
            this.groupControl2.Controls.Add(this.ceHotTrack);
            this.groupControl2.Controls.Add(this.teNullText);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.seItemHeight);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Location = new System.Drawing.Point(30, 250);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(255, 196);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Appearance";
            // 
            // ceShowLines
            // 
            this.ceShowLines.Location = new System.Drawing.Point(18, 160);
            this.ceShowLines.Name = "ceShowLines";
            this.ceShowLines.Properties.Caption = "Show lines";
            this.ceShowLines.Size = new System.Drawing.Size(148, 19);
            this.ceShowLines.TabIndex = 24;
            this.ceShowLines.CheckedChanged += new System.EventHandler(this.ceShowLines_CheckedChanged);
            // 
            // ceShowHeader
            // 
            this.ceShowHeader.Location = new System.Drawing.Point(18, 137);
            this.ceShowHeader.Name = "ceShowHeader";
            this.ceShowHeader.Properties.Caption = "Show header";
            this.ceShowHeader.Size = new System.Drawing.Size(148, 19);
            this.ceShowHeader.TabIndex = 23;
            this.ceShowHeader.CheckedChanged += new System.EventHandler(this.ceShowHeader_CheckedChanged);
            // 
            // ceShowFooter
            // 
            this.ceShowFooter.Location = new System.Drawing.Point(18, 112);
            this.ceShowFooter.Name = "ceShowFooter";
            this.ceShowFooter.Properties.Caption = "Show footer";
            this.ceShowFooter.Size = new System.Drawing.Size(148, 19);
            this.ceShowFooter.TabIndex = 22;
            this.ceShowFooter.CheckedChanged += new System.EventHandler(this.ceShowFooter_CheckedChanged);
            // 
            // ceHotTrack
            // 
            this.ceHotTrack.Location = new System.Drawing.Point(18, 87);
            this.ceHotTrack.Name = "ceHotTrack";
            this.ceHotTrack.Properties.Caption = "Hot-track items";
            this.ceHotTrack.Size = new System.Drawing.Size(148, 19);
            this.ceHotTrack.TabIndex = 21;
            this.ceHotTrack.CheckedChanged += new System.EventHandler(this.ceHotTrack_CheckedChanged);
            // 
            // teNullText
            // 
            this.teNullText.EditValue = "";
            this.teNullText.Location = new System.Drawing.Point(124, 61);
            this.teNullText.Name = "teNullText";
            this.teNullText.Size = new System.Drawing.Size(112, 20);
            this.teNullText.TabIndex = 20;
            this.teNullText.EditValueChanged += new System.EventHandler(this.teNullText_EditValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Null Text:";
            // 
            // seItemHeight
            // 
            this.seItemHeight.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seItemHeight.Location = new System.Drawing.Point(176, 32);
            this.seItemHeight.Name = "seItemHeight";
            this.seItemHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seItemHeight.Properties.IsFloatValue = false;
            this.seItemHeight.Properties.Mask.EditMask = "N00";
            this.seItemHeight.Properties.MaxValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.seItemHeight.Size = new System.Drawing.Size(60, 20);
            this.seItemHeight.TabIndex = 18;
            this.seItemHeight.EditValueChanged += new System.EventHandler(this.seItemHeight_EditValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dropdown item height:";
            // 
            // LookUpProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelect);
            this.Name = "LookUpProperties";
            this.Size = new System.Drawing.Size(311, 475);
            this.Load += new System.EventHandler(this.LookUpProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceCaseSensitiveSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSearchMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbHeaderClickMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seColumnIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowLines.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowFooter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHotTrack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNullText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seItemHeight.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblSelect;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl lbDisplay;
        private DevExpress.XtraEditors.LabelControl lbValue;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label6;
        private System.ComponentModel.Container components = null;
        private DevExpress.XtraEditors.SpinEdit seColumnIndex;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbHeaderClickMode;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbSearchMode;
        private DevExpress.XtraEditors.CheckEdit ceCaseSensitiveSearch;
        private DevExpress.XtraEditors.SpinEdit seItemHeight;
        private DevExpress.XtraEditors.TextEdit teNullText;
        private DevExpress.XtraEditors.CheckEdit ceHotTrack;
        private DevExpress.XtraEditors.CheckEdit ceShowFooter;
        private DevExpress.XtraEditors.CheckEdit ceShowHeader;
        private DevExpress.XtraEditors.CheckEdit ceShowLines;

    }
}
