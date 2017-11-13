namespace DevExpress.Docs.Demos
{
    partial class PdfSignatureDemo
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.viewerPanel = new DevExpress.XtraEditors.PanelControl();
            this.panelDocument = new System.Windows.Forms.Panel();
            this.pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.buttonNewCertificate = new DevExpress.XtraEditors.SimpleButton();
            this.teReason = new DevExpress.XtraEditors.TextEdit();
            this.lbCerts = new DevExpress.XtraEditors.ListBoxControl();
            this.labelContactInfo = new DevExpress.XtraEditors.LabelControl();
            this.labelLocation = new DevExpress.XtraEditors.LabelControl();
            this.labelReason = new DevExpress.XtraEditors.LabelControl();
            this.labelCertificate = new DevExpress.XtraEditors.LabelControl();
            this.teContactInfo = new DevExpress.XtraEditors.TextEdit();
            this.teLocation = new DevExpress.XtraEditors.TextEdit();
            this.buttonSign = new DevExpress.XtraEditors.SimpleButton();
            this.panelNewCertificate = new System.Windows.Forms.Panel();
            this.panelSign = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).BeginInit();
            this.viewerPanel.SuspendLayout();
            this.panelDocument.SuspendLayout();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContactInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocation.Properties)).BeginInit();
            this.panelNewCertificate.SuspendLayout();
            this.panelSign.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewerPanel
            // 
            this.viewerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.viewerPanel.Controls.Add(this.panelDocument);
            this.viewerPanel.Controls.Add(this.panelOptions);
            this.viewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerPanel.Location = new System.Drawing.Point(0, 0);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.Size = new System.Drawing.Size(737, 564);
            this.viewerPanel.TabIndex = 7;
            // 
            // panelDocument
            // 
            this.panelDocument.Controls.Add(this.pdfViewer);
            this.panelDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDocument.Location = new System.Drawing.Point(0, 0);
            this.panelDocument.Name = "panelDocument";
            this.panelDocument.Size = new System.Drawing.Size(451, 564);
            this.panelDocument.TabIndex = 6;
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
            this.pdfViewer.ReadOnly = true;
            this.pdfViewer.Size = new System.Drawing.Size(451, 564);
            this.pdfViewer.TabIndex = 6;
            this.pdfViewer.TabStop = false;
            this.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth;
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.panelSign);
            this.panelOptions.Controls.Add(this.panelNewCertificate);
            this.panelOptions.Controls.Add(this.teReason);
            this.panelOptions.Controls.Add(this.lbCerts);
            this.panelOptions.Controls.Add(this.labelContactInfo);
            this.panelOptions.Controls.Add(this.labelLocation);
            this.panelOptions.Controls.Add(this.labelReason);
            this.panelOptions.Controls.Add(this.labelCertificate);
            this.panelOptions.Controls.Add(this.teContactInfo);
            this.panelOptions.Controls.Add(this.teLocation);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOptions.Location = new System.Drawing.Point(451, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(286, 564);
            this.panelOptions.TabIndex = 6;
            // 
            // buttonNewCertificate
            // 
            this.buttonNewCertificate.Location = new System.Drawing.Point(0, 0);
            this.buttonNewCertificate.Margin = new System.Windows.Forms.Padding(30);
            this.buttonNewCertificate.Name = "buttonNewCertificate";
            this.buttonNewCertificate.Size = new System.Drawing.Size(152, 23);
            this.buttonNewCertificate.TabIndex = 1;
            this.buttonNewCertificate.Text = "Load Certificate...";
            this.buttonNewCertificate.Click += new System.EventHandler(this.OnButtonNewCertificateClick);
            // 
            // teReason
            // 
            this.teReason.Location = new System.Drawing.Point(116, 149);
            this.teReason.Margin = new System.Windows.Forms.Padding(2);
            this.teReason.Name = "teReason";
            this.teReason.Size = new System.Drawing.Size(152, 20);
            this.teReason.TabIndex = 2;
            // 
            // lbCerts
            // 
            this.lbCerts.DisplayMember = "Name";
            this.lbCerts.ItemAutoHeight = true;
            this.lbCerts.Location = new System.Drawing.Point(116, 30);
            this.lbCerts.Name = "lbCerts";
            this.lbCerts.Size = new System.Drawing.Size(152, 83);
            this.lbCerts.TabIndex = 0;
            // 
            // labelContactInfo
            // 
            this.labelContactInfo.Location = new System.Drawing.Point(25, 200);
            this.labelContactInfo.Name = "labelContactInfo";
            this.labelContactInfo.Size = new System.Drawing.Size(63, 13);
            this.labelContactInfo.TabIndex = 35;
            this.labelContactInfo.Text = "Contact info:";
            // 
            // labelLocation
            // 
            this.labelLocation.Location = new System.Drawing.Point(26, 176);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(44, 13);
            this.labelLocation.TabIndex = 33;
            this.labelLocation.Text = "Location:";
            // 
            // labelReason
            // 
            this.labelReason.Location = new System.Drawing.Point(26, 152);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(40, 13);
            this.labelReason.TabIndex = 31;
            this.labelReason.Text = "Reason:";
            // 
            // labelCertificate
            // 
            this.labelCertificate.Location = new System.Drawing.Point(25, 33);
            this.labelCertificate.Name = "labelCertificate";
            this.labelCertificate.Size = new System.Drawing.Size(54, 13);
            this.labelCertificate.TabIndex = 25;
            this.labelCertificate.Text = "Certificate:";
            // 
            // teContactInfo
            // 
            this.teContactInfo.Location = new System.Drawing.Point(116, 197);
            this.teContactInfo.Margin = new System.Windows.Forms.Padding(2);
            this.teContactInfo.Name = "teContactInfo";
            this.teContactInfo.Size = new System.Drawing.Size(152, 20);
            this.teContactInfo.TabIndex = 4;
            // 
            // teLocation
            // 
            this.teLocation.Location = new System.Drawing.Point(116, 173);
            this.teLocation.Margin = new System.Windows.Forms.Padding(2);
            this.teLocation.Name = "teLocation";
            this.teLocation.Size = new System.Drawing.Size(152, 20);
            this.teLocation.TabIndex = 3;
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(0, 0);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(30);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(152, 23);
            this.buttonSign.TabIndex = 5;
            this.buttonSign.Text = "Sign and Save...";
            this.buttonSign.Click += new System.EventHandler(this.OnButtonSignClick);
            // 
            // panelNewCertificate
            // 
            this.panelNewCertificate.Controls.Add(this.buttonNewCertificate);
            this.panelNewCertificate.Location = new System.Drawing.Point(116, 118);
            this.panelNewCertificate.Name = "panelNewCertificate";
            this.panelNewCertificate.Size = new System.Drawing.Size(152, 23);
            this.panelNewCertificate.TabIndex = 1;
            // 
            // panelSign
            // 
            this.panelSign.Controls.Add(this.buttonSign);
            this.panelSign.Location = new System.Drawing.Point(116, 225);
            this.panelSign.Name = "panelSign";
            this.panelSign.Size = new System.Drawing.Size(152, 23);
            this.panelSign.TabIndex = 5;
            // 
            // PdfSignatureDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewerPanel);
            this.Name = "PdfSignatureDemo";
            this.Size = new System.Drawing.Size(737, 564);
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).EndInit();
            this.viewerPanel.ResumeLayout(false);
            this.panelDocument.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContactInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocation.Properties)).EndInit();
            this.panelNewCertificate.ResumeLayout(false);
            this.panelSign.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private XtraEditors.PanelControl viewerPanel;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panelDocument;
        private XtraPdfViewer.PdfViewer pdfViewer;
        private XtraEditors.SimpleButton buttonSign;
        private XtraEditors.TextEdit teContactInfo;
        private XtraEditors.TextEdit teLocation;
        private XtraEditors.LabelControl labelContactInfo;
        private XtraEditors.LabelControl labelLocation;
        private XtraEditors.LabelControl labelReason;
        private XtraEditors.LabelControl labelCertificate;
        private XtraEditors.ListBoxControl lbCerts;
        private XtraEditors.TextEdit teReason;
        private XtraEditors.SimpleButton buttonNewCertificate;
        private System.Windows.Forms.Panel panelSign;
        private System.Windows.Forms.Panel panelNewCertificate;

    }
}
