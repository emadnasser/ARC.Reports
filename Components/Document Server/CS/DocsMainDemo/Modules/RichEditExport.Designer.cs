namespace DevExpress.Docs.Demos {
    partial class RichEditExport {
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
        private void InitializeComponent() {
            this.printPreviewControl = new DevExpress.XtraPrinting.Control.PrintControl();
            this.edtFilePath = new DevExpress.XtraEditors.ButtonEdit();
            this.btnRtf = new DevExpress.XtraEditors.SimpleButton();
            this.btnEpub = new DevExpress.XtraEditors.SimpleButton();
            this.btnXml = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdt = new DevExpress.XtraEditors.SimpleButton();
            this.btnDocx = new DevExpress.XtraEditors.SimpleButton();
            this.btnMht = new DevExpress.XtraEditors.SimpleButton();
            this.btnHtml = new DevExpress.XtraEditors.SimpleButton();
            this.btnTxt = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnPdf = new DevExpress.XtraEditors.SimpleButton();
            this.edtSaveTo = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.edtFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSaveTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewControl
            // 
            this.printPreviewControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl.IsMetric = false;
            this.printPreviewControl.Location = new System.Drawing.Point(3, 82);
            this.printPreviewControl.Name = "printPreviewControl";
            this.printPreviewControl.Size = new System.Drawing.Size(778, 397);
            this.printPreviewControl.TabIndex = 34;
            this.printPreviewControl.TooltipFont = new System.Drawing.Font("Tahoma", 8.25F);
            // 
            // edtFilePath
            // 
            this.edtFilePath.Location = new System.Drawing.Point(63, 3);
            this.edtFilePath.Name = "edtFilePath";
            this.edtFilePath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtFilePath.Size = new System.Drawing.Size(240, 20);
            this.edtFilePath.TabIndex = 35;
            this.edtFilePath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.edtFilePath_ButtonClick);
            this.edtFilePath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edtFilePath_KeyUp);
            // 
            // btnRtf
            // 
            this.btnRtf.Location = new System.Drawing.Point(63, 28);
            this.btnRtf.Name = "btnRtf";
            this.btnRtf.Size = new System.Drawing.Size(50, 23);
            this.btnRtf.TabIndex = 36;
            this.btnRtf.Text = "RTF";
            this.btnRtf.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnEpub
            // 
            this.btnEpub.Location = new System.Drawing.Point(566, 28);
            this.btnEpub.Name = "btnEpub";
            this.btnEpub.Size = new System.Drawing.Size(50, 23);
            this.btnEpub.TabIndex = 37;
            this.btnEpub.Text = "EPUB";
            this.btnEpub.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(510, 28);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(50, 23);
            this.btnXml.TabIndex = 38;
            this.btnXml.Text = "XML";
            this.btnXml.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnOdt
            // 
            this.btnOdt.Location = new System.Drawing.Point(454, 28);
            this.btnOdt.Name = "btnOdt";
            this.btnOdt.Size = new System.Drawing.Size(50, 23);
            this.btnOdt.TabIndex = 39;
            this.btnOdt.Text = "ODT";
            this.btnOdt.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDocx
            // 
            this.btnDocx.Location = new System.Drawing.Point(175, 28);
            this.btnDocx.Name = "btnDocx";
            this.btnDocx.Size = new System.Drawing.Size(50, 23);
            this.btnDocx.TabIndex = 40;
            this.btnDocx.Text = "DOCX";
            this.btnDocx.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnMht
            // 
            this.btnMht.Location = new System.Drawing.Point(398, 28);
            this.btnMht.Name = "btnMht";
            this.btnMht.Size = new System.Drawing.Size(50, 23);
            this.btnMht.TabIndex = 41;
            this.btnMht.Text = "MHT";
            this.btnMht.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnHtml
            // 
            this.btnHtml.Location = new System.Drawing.Point(342, 28);
            this.btnHtml.Name = "btnHtml";
            this.btnHtml.Size = new System.Drawing.Size(50, 23);
            this.btnHtml.TabIndex = 42;
            this.btnHtml.Text = "HTML";
            this.btnHtml.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(287, 28);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(50, 23);
            this.btnTxt.TabIndex = 43;
            this.btnTxt.Text = "TXT";
            this.btnTxt.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(119, 28);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(50, 23);
            this.btnDoc.TabIndex = 37;
            this.btnDoc.Text = "DOC";
            this.btnDoc.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(231, 28);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(50, 23);
            this.btnPdf.TabIndex = 37;
            this.btnPdf.Text = "PDF";
            this.btnPdf.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // edtSaveTo
            // 
            this.edtSaveTo.Location = new System.Drawing.Point(377, 3);
            this.edtSaveTo.Name = "edtSaveTo";
            this.edtSaveTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtSaveTo.Size = new System.Drawing.Size(239, 20);
            this.edtSaveTo.TabIndex = 35;
            this.edtSaveTo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.edtSaveTo_ButtonClick);
            this.edtSaveTo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edtFilePath_KeyUp);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 46;
            this.labelControl1.Text = "File:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 46;
            this.labelControl2.Text = "Export to:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(330, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "Save to:";
            // 
            // RichEditExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.btnHtml);
            this.Controls.Add(this.btnMht);
            this.Controls.Add(this.btnDocx);
            this.Controls.Add(this.btnOdt);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnEpub);
            this.Controls.Add(this.btnRtf);
            this.Controls.Add(this.edtSaveTo);
            this.Controls.Add(this.edtFilePath);
            this.Controls.Add(this.printPreviewControl);
            this.Name = "RichEditExport";
            ((System.ComponentModel.ISupportInitialize)(this.edtFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSaveTo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraPrinting.Control.PrintControl printPreviewControl;
        private XtraEditors.ButtonEdit edtFilePath;
        private XtraEditors.SimpleButton btnRtf;
        private XtraEditors.SimpleButton btnEpub;
        private XtraEditors.SimpleButton btnXml;
        private XtraEditors.SimpleButton btnOdt;
        private XtraEditors.SimpleButton btnDocx;
        private XtraEditors.SimpleButton btnMht;
        private XtraEditors.SimpleButton btnHtml;
        private XtraEditors.SimpleButton btnTxt;
        private XtraEditors.SimpleButton btnDoc;
        private XtraEditors.SimpleButton btnPdf;
        private XtraEditors.ButtonEdit edtSaveTo;
        private XtraEditors.LabelControl labelControl1;
        private XtraEditors.LabelControl labelControl2;
        private XtraEditors.LabelControl labelControl3;
    }
}
