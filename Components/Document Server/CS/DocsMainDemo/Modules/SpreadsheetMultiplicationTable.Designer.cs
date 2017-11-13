using System;
using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetMultiplicationTableModule {
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

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent() {
            this.widthSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.heightSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.createInfoCellsCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.useSharedFormulaCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createInfoCellsCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useSharedFormulaCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // widthSpinEdit
            // 
            this.widthSpinEdit.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.widthSpinEdit.Location = new System.Drawing.Point(47, 15);
            this.widthSpinEdit.Name = "widthSpinEdit";
            this.widthSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.widthSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.widthSpinEdit.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.widthSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthSpinEdit.Size = new System.Drawing.Size(60, 20);
            this.widthSpinEdit.TabIndex = 0;
            this.widthSpinEdit.EditValueChanged += new System.EventHandler(this.ParametersChanged);
            // 
            // heightSpinEdit
            // 
            this.heightSpinEdit.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.heightSpinEdit.Location = new System.Drawing.Point(162, 15);
            this.heightSpinEdit.Name = "heightSpinEdit";
            this.heightSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.heightSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.heightSpinEdit.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.heightSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightSpinEdit.Size = new System.Drawing.Size(60, 20);
            this.heightSpinEdit.TabIndex = 1;
            this.heightSpinEdit.EditValueChanged += new System.EventHandler(this.ParametersChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(121, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height:";
            // 
            // createInfoCellsCheckEdit
            // 
            this.createInfoCellsCheckEdit.EditValue = true;
            this.createInfoCellsCheckEdit.Location = new System.Drawing.Point(3, 65);
            this.createInfoCellsCheckEdit.Name = "createInfoCellsCheckEdit";
            this.createInfoCellsCheckEdit.Properties.Caption = "Create Info Cells";
            this.createInfoCellsCheckEdit.Size = new System.Drawing.Size(107, 19);
            this.createInfoCellsCheckEdit.TabIndex = 3;
            this.createInfoCellsCheckEdit.CheckedChanged += new System.EventHandler(this.ParametersChanged);
            // 
            // useSharedFormulaCheckEdit
            // 
            this.useSharedFormulaCheckEdit.EditValue = true;
            this.useSharedFormulaCheckEdit.Location = new System.Drawing.Point(3, 41);
            this.useSharedFormulaCheckEdit.Name = "useSharedFormulaCheckEdit";
            this.useSharedFormulaCheckEdit.Properties.AutoWidth = true;
            this.useSharedFormulaCheckEdit.Properties.Caption = "Use Shared Formula";
            this.useSharedFormulaCheckEdit.Size = new System.Drawing.Size(118, 19);
            this.useSharedFormulaCheckEdit.TabIndex = 2;
            this.useSharedFormulaCheckEdit.CheckedChanged += new System.EventHandler(this.ParametersChanged);
            // 
            // SpreadsheetMultiplicationTableModule
            // 
            this.Controls.Add(this.useSharedFormulaCheckEdit);
            this.Controls.Add(this.createInfoCellsCheckEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heightSpinEdit);
            this.Controls.Add(this.widthSpinEdit);
            this.Name = "SpreadsheetMultiplicationTableModule";
            this.Controls.SetChildIndex(this.widthSpinEdit, 0);
            this.Controls.SetChildIndex(this.heightSpinEdit, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.createInfoCellsCheckEdit, 0);
            this.Controls.SetChildIndex(this.useSharedFormulaCheckEdit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.widthSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createInfoCellsCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useSharedFormulaCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        SpinEdit widthSpinEdit;
        SpinEdit heightSpinEdit;
        LabelControl label1;
        LabelControl label2;
        CheckEdit createInfoCellsCheckEdit;
        CheckEdit useSharedFormulaCheckEdit;
    }
}
