namespace DevExpress.Docs.Demos
{
    partial class PdfFormFilling
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
            this.deDate = new DevExpress.XtraEditors.DateEdit();
            this.labelDate = new DevExpress.XtraEditors.LabelControl();
            this.labelFlight = new DevExpress.XtraEditors.LabelControl();
            this.teFlight = new DevExpress.XtraEditors.TextEdit();
            this.labelPassport = new DevExpress.XtraEditors.LabelControl();
            this.tePassport = new DevExpress.XtraEditors.TextEdit();
            this.buttonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.panelSubmit = new System.Windows.Forms.Panel();
            this.labelAddress = new DevExpress.XtraEditors.LabelControl();
            this.labelVisa = new DevExpress.XtraEditors.LabelControl();
            this.labelCountry = new DevExpress.XtraEditors.LabelControl();
            this.labelGender = new DevExpress.XtraEditors.LabelControl();
            this.labelLastName = new DevExpress.XtraEditors.LabelControl();
            this.labelFirstName = new DevExpress.XtraEditors.LabelControl();
            this.cbeNationality = new DevExpress.XtraEditors.ComboBoxEdit();
            this.teAddress = new DevExpress.XtraEditors.TextEdit();
            this.teVisa = new DevExpress.XtraEditors.TextEdit();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.ceFemale = new DevExpress.XtraEditors.CheckEdit();
            this.ceMale = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).BeginInit();
            this.viewerPanel.SuspendLayout();
            this.panelDocument.SuspendLayout();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFlight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeNationality.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teVisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFemale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMale.Properties)).BeginInit();
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
            this.panelDocument.TabIndex = 8;
            // 
            // pdfViewer
            // 
            this.pdfViewer.DetachStreamAfterLoadComplete = true;
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
            this.pdfViewer.ReadOnly = true;
            this.pdfViewer.Size = new System.Drawing.Size(451, 564);
            this.pdfViewer.TabIndex = 6;
            this.pdfViewer.TabStop = false;
            this.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth;
            this.pdfViewer.DocumentClosing += new DevExpress.XtraPdfViewer.PdfDocumentClosingEventHandler(this.DocumentClosing);
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.deDate);
            this.panelOptions.Controls.Add(this.labelDate);
            this.panelOptions.Controls.Add(this.teLastName);
            this.panelOptions.Controls.Add(this.labelFlight);
            this.panelOptions.Controls.Add(this.ceMale);
            this.panelOptions.Controls.Add(this.teFlight);
            this.panelOptions.Controls.Add(this.ceFemale);
            this.panelOptions.Controls.Add(this.labelPassport);
            this.panelOptions.Controls.Add(this.teFirstName);
            this.panelOptions.Controls.Add(this.tePassport);
            this.panelOptions.Controls.Add(this.teVisa);
            this.panelOptions.Controls.Add(this.buttonSubmit);
            this.panelOptions.Controls.Add(this.teAddress);
            this.panelOptions.Controls.Add(this.panelSubmit);
            this.panelOptions.Controls.Add(this.cbeNationality);
            this.panelOptions.Controls.Add(this.labelAddress);
            this.panelOptions.Controls.Add(this.labelFirstName);
            this.panelOptions.Controls.Add(this.labelVisa);
            this.panelOptions.Controls.Add(this.labelLastName);
            this.panelOptions.Controls.Add(this.labelCountry);
            this.panelOptions.Controls.Add(this.labelGender);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOptions.Location = new System.Drawing.Point(451, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(286, 564);
            this.panelOptions.TabIndex = 6;
            // 
            // deDate
            // 
            this.deDate.EditValue = new System.DateTime(1985, 8, 30, 0, 0, 0, 0);
            this.deDate.Location = new System.Drawing.Point(112, 134);
            this.deDate.Name = "deDate";
            this.deDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.MaxValue = new System.DateTime(((long)(0)));
            this.deDate.Size = new System.Drawing.Size(152, 20);
            this.deDate.TabIndex = 64;
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(22, 137);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(65, 13);
            this.labelDate.TabIndex = 63;
            this.labelDate.Text = "Date of Birth:";
            // 
            // labelFlight
            // 
            this.labelFlight.Location = new System.Drawing.Point(22, 257);
            this.labelFlight.Name = "labelFlight";
            this.labelFlight.Size = new System.Drawing.Size(46, 13);
            this.labelFlight.TabIndex = 62;
            this.labelFlight.Text = "Flight No:";
            // 
            // teFlight
            // 
            this.teFlight.EditValue = "(KL) KLM 876";
            this.teFlight.Location = new System.Drawing.Point(112, 254);
            this.teFlight.Margin = new System.Windows.Forms.Padding(2);
            this.teFlight.Name = "teFlight";
            this.teFlight.Size = new System.Drawing.Size(152, 20);
            this.teFlight.TabIndex = 61;
            // 
            // labelPassport
            // 
            this.labelPassport.Location = new System.Drawing.Point(21, 161);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(62, 13);
            this.labelPassport.TabIndex = 60;
            this.labelPassport.Text = "Passport No:";
            // 
            // tePassport
            // 
            this.tePassport.EditValue = "31195855";
            this.tePassport.Location = new System.Drawing.Point(112, 158);
            this.tePassport.Margin = new System.Windows.Forms.Padding(2);
            this.tePassport.Name = "tePassport";
            this.tePassport.Size = new System.Drawing.Size(152, 20);
            this.tePassport.TabIndex = 59;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(112, 282);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(30);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(152, 23);
            this.buttonSubmit.TabIndex = 52;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.Click += new System.EventHandler(this.SubmitClick);
            // 
            // panelSubmit
            // 
            this.panelSubmit.Location = new System.Drawing.Point(112, 282);
            this.panelSubmit.Name = "panelSubmit";
            this.panelSubmit.Size = new System.Drawing.Size(152, 23);
            this.panelSubmit.TabIndex = 58;
            // 
            // labelAddress
            // 
            this.labelAddress.Location = new System.Drawing.Point(21, 209);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(43, 13);
            this.labelAddress.TabIndex = 57;
            this.labelAddress.Text = "Address:";
            // 
            // labelVisa
            // 
            this.labelVisa.Location = new System.Drawing.Point(22, 233);
            this.labelVisa.Name = "labelVisa";
            this.labelVisa.Size = new System.Drawing.Size(39, 13);
            this.labelVisa.TabIndex = 56;
            this.labelVisa.Text = "Visa No:";
            // 
            // labelCountry
            // 
            this.labelCountry.Location = new System.Drawing.Point(22, 185);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(55, 13);
            this.labelCountry.TabIndex = 55;
            this.labelCountry.Text = "Nationality:";
            // 
            // labelGender
            // 
            this.labelGender.Location = new System.Drawing.Point(22, 80);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(39, 13);
            this.labelGender.TabIndex = 54;
            this.labelGender.Text = "Gender:";
            // 
            // labelLastName
            // 
            this.labelLastName.Location = new System.Drawing.Point(22, 42);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(53, 13);
            this.labelLastName.TabIndex = 53;
            this.labelLastName.Text = "Last name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.Location = new System.Drawing.Point(21, 18);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(54, 13);
            this.labelFirstName.TabIndex = 50;
            this.labelFirstName.Text = "First name:";
            // 
            // cbeNationality
            // 
            this.cbeNationality.EditValue = "United States";
            this.cbeNationality.Location = new System.Drawing.Point(112, 182);
            this.cbeNationality.Margin = new System.Windows.Forms.Padding(2);
            this.cbeNationality.Name = "cbeNationality";
            this.cbeNationality.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeNationality.Size = new System.Drawing.Size(152, 20);
            this.cbeNationality.TabIndex = 48;
            // 
            // teAddress
            // 
            this.teAddress.EditValue = "98033, 722 Moss Bay Blvd., Kirkland, WA, USA";
            this.teAddress.Location = new System.Drawing.Point(112, 206);
            this.teAddress.Margin = new System.Windows.Forms.Padding(2);
            this.teAddress.Name = "teAddress";
            this.teAddress.Size = new System.Drawing.Size(152, 20);
            this.teAddress.TabIndex = 51;
            // 
            // teVisa
            // 
            this.teVisa.EditValue = "73203393";
            this.teVisa.Location = new System.Drawing.Point(112, 230);
            this.teVisa.Margin = new System.Windows.Forms.Padding(2);
            this.teVisa.Name = "teVisa";
            this.teVisa.Size = new System.Drawing.Size(152, 20);
            this.teVisa.TabIndex = 49;
            // 
            // teLastName
            // 
            this.teLastName.EditValue = "Leverling";
            this.teLastName.Location = new System.Drawing.Point(112, 39);
            this.teLastName.Margin = new System.Windows.Forms.Padding(2);
            this.teLastName.Name = "teLastName";
            this.teLastName.Size = new System.Drawing.Size(152, 20);
            this.teLastName.TabIndex = 45;
            // 
            // teFirstName
            // 
            this.teFirstName.EditValue = "Janet";
            this.teFirstName.Location = new System.Drawing.Point(112, 15);
            this.teFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Size = new System.Drawing.Size(152, 20);
            this.teFirstName.TabIndex = 44;
            // 
            // ceFemale
            // 
            this.ceFemale.EditValue = true;
            this.ceFemale.Location = new System.Drawing.Point(112, 96);
            this.ceFemale.Name = "ceFemale";
            this.ceFemale.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.ceFemale.Properties.Caption = "Female";
            this.ceFemale.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceFemale.Properties.RadioGroupIndex = 0;
            this.ceFemale.Size = new System.Drawing.Size(152, 19);
            this.ceFemale.TabIndex = 47;
            // 
            // ceMale
            // 
            this.ceMale.Location = new System.Drawing.Point(112, 77);
            this.ceMale.Name = "ceMale";
            this.ceMale.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.ceMale.Properties.Caption = "Male";
            this.ceMale.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceMale.Properties.RadioGroupIndex = 0;
            this.ceMale.Size = new System.Drawing.Size(152, 19);
            this.ceMale.TabIndex = 46;
            this.ceMale.TabStop = false;
            // 
            // PdfFormFilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewerPanel);
            this.Name = "PdfFormFilling";
            this.Size = new System.Drawing.Size(737, 564);
            ((System.ComponentModel.ISupportInitialize)(this.viewerPanel)).EndInit();
            this.viewerPanel.ResumeLayout(false);
            this.panelDocument.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFlight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeNationality.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teVisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFemale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMale.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private XtraEditors.PanelControl viewerPanel;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panelDocument;
        private XtraPdfViewer.PdfViewer pdfViewer;
        private XtraEditors.DateEdit deDate;
        private XtraEditors.LabelControl labelDate;
        private XtraEditors.LabelControl labelFlight;
        private XtraEditors.TextEdit teFlight;
        private XtraEditors.LabelControl labelPassport;
        private XtraEditors.TextEdit tePassport;
        private XtraEditors.SimpleButton buttonSubmit;
        private System.Windows.Forms.Panel panelSubmit;
        private XtraEditors.LabelControl labelAddress;
        private XtraEditors.LabelControl labelVisa;
        private XtraEditors.LabelControl labelCountry;
        private XtraEditors.LabelControl labelGender;
        private XtraEditors.LabelControl labelLastName;
        private XtraEditors.LabelControl labelFirstName;
        private XtraEditors.ComboBoxEdit cbeNationality;
        private XtraEditors.TextEdit teAddress;
        private XtraEditors.TextEdit teVisa;
        private XtraEditors.TextEdit teLastName;
        private XtraEditors.TextEdit teFirstName;
        private XtraEditors.CheckEdit ceFemale;
        private XtraEditors.CheckEdit ceMale;

    }
}
