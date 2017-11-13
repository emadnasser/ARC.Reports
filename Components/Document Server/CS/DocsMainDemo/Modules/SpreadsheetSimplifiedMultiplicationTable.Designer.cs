using System;
using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetSimplifiedMultiplicationTableModule {
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
            this.tableCountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.columnsSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tableCountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableCountSpinEdit
            // 
            this.tableCountSpinEdit.EditValue = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.tableCountSpinEdit.Location = new System.Drawing.Point(90, 18);
            this.tableCountSpinEdit.Name = "tableCountSpinEdit";
            this.tableCountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tableCountSpinEdit.Properties.IsFloatValue = false;
            this.tableCountSpinEdit.Properties.Mask.EditMask = "N00";
            this.tableCountSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.tableCountSpinEdit.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.tableCountSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tableCountSpinEdit.Size = new System.Drawing.Size(60, 20);
            this.tableCountSpinEdit.TabIndex = 0;
            this.tableCountSpinEdit.EditValueChanged += new System.EventHandler(this.spinEdit_EditValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Count:";
            // 
            // columnsSpinEdit
            // 
            this.columnsSpinEdit.EditValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.columnsSpinEdit.Location = new System.Drawing.Point(90, 48);
            this.columnsSpinEdit.Name = "columnsSpinEdit";
            this.columnsSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.columnsSpinEdit.Properties.IsFloatValue = false;
            this.columnsSpinEdit.Properties.Mask.EditMask = "N00";
            this.columnsSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.columnsSpinEdit.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.columnsSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnsSpinEdit.Size = new System.Drawing.Size(60, 20);
            this.columnsSpinEdit.TabIndex = 1;
            this.columnsSpinEdit.EditValueChanged += new System.EventHandler(this.spinEdit_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Column Count:";
            // 
            // SpreadsheetSimplifiedMultiplicationTableModule
            // 
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnsSpinEdit);
            this.Controls.Add(this.tableCountSpinEdit);
            this.Name = "SpreadsheetSimplifiedMultiplicationTableModule";
            this.Controls.SetChildIndex(this.tableCountSpinEdit, 0);
            this.Controls.SetChildIndex(this.columnsSpinEdit, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tableCountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        SpinEdit tableCountSpinEdit;
        LabelControl label1;
        SpinEdit columnsSpinEdit;
        LabelControl labelControl1;
    }
}
