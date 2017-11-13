namespace DevExpress.XtraWizard.Demos {
    partial class frmMain {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.wpRecipientData = new DevExpress.XtraWizard.WizardPage();
            this.teEmail = new DevExpress.XtraEditors.TextEdit();
            this.teRecipientName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.wpCardTemplate = new DevExpress.XtraWizard.WizardPage();
            this.ceSignature = new DevExpress.XtraEditors.CheckEdit();
            this.rgWishes = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.wpSignature = new DevExpress.XtraWizard.WizardPage();
            this.sbSkipSignature = new DevExpress.XtraEditors.SimpleButton();
            this.teYourName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbeSignatureTemplate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.wpPreview = new DevExpress.XtraWizard.WizardPage();
            this.sbSend = new DevExpress.XtraEditors.SimpleButton();
            this.meCard = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.welcomeWizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.wpRecipientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRecipientName.Properties)).BeginInit();
            this.wpCardTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceSignature.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgWishes.Properties)).BeginInit();
            this.wpSignature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teYourName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSignatureTemplate.Properties)).BeginInit();
            this.completionWizardPage1.SuspendLayout();
            this.wpPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meCard.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wpRecipientData);
            this.wizardControl1.Controls.Add(this.wpCardTemplate);
            this.wizardControl1.Controls.Add(this.wpSignature);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Controls.Add(this.wpPreview);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wpRecipientData,
            this.wpCardTemplate,
            this.wpSignature,
            this.wpPreview,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(556, 363);
            this.wizardControl1.Text = "Birthday Card";
            this.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl1.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wizardControl1_SelectedPageChanged);
            this.wizardControl1.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardControl1_SelectedPageChanging);
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_CancelClick);
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Controls.Add(this.pictureEdit1);
            this.welcomeWizardPage1.Controls.Add(this.labelControl1);
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(496, 201);
            this.welcomeWizardPage1.Text = "Welcome to DevExpress XtraWizard Control Demo";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = global::DevExpress.XtraWizard.Demos.Properties.Resources.picture_post_card;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 26);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Size = new System.Drawing.Size(496, 175);
            this.pictureEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(496, 26);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thank you for evaluating XtraWizard! This demo application will generate a birthd" +
    "ay card for you, all the while showing off many features of our wizard control, " +
    "including the Windows Aero layout.";
            // 
            // wpRecipientData
            // 
            this.wpRecipientData.AllowNext = false;
            this.wpRecipientData.Controls.Add(this.teEmail);
            this.wpRecipientData.Controls.Add(this.teRecipientName);
            this.wpRecipientData.Controls.Add(this.labelControl3);
            this.wpRecipientData.Controls.Add(this.labelControl2);
            this.wpRecipientData.Name = "wpRecipientData";
            this.wpRecipientData.Size = new System.Drawing.Size(496, 201);
            this.wpRecipientData.Text = "Recipient Name and Address";
            // 
            // teEmail
            // 
            this.teEmail.Location = new System.Drawing.Point(22, 129);
            this.teEmail.Name = "teEmail";
            this.teEmail.Properties.Mask.EditMask = ".+@.+\\..+";
            this.teEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.teEmail.Size = new System.Drawing.Size(337, 20);
            this.teEmail.TabIndex = 4;
            this.teEmail.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.teEmail_InvalidValue);
            this.teEmail.TextChanged += new System.EventHandler(this.teRecipient_TextChanged);
            // 
            // teRecipientName
            // 
            this.teRecipientName.Location = new System.Drawing.Point(22, 36);
            this.teRecipientName.Name = "teRecipientName";
            this.teRecipientName.Size = new System.Drawing.Size(337, 20);
            this.teRecipientName.TabIndex = 3;
            this.teRecipientName.TextChanged += new System.EventHandler(this.teRecipient_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl3.Location = new System.Drawing.Point(0, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(496, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Please enter the recipient\'s email address:";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.Location = new System.Drawing.Point(0, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(496, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Please enter the recipient’s name as you’d like to see it on the birthday card:\r\n" +
    "";
            // 
            // wpCardTemplate
            // 
            this.wpCardTemplate.Controls.Add(this.ceSignature);
            this.wpCardTemplate.Controls.Add(this.rgWishes);
            this.wpCardTemplate.Controls.Add(this.labelControl4);
            this.wpCardTemplate.Name = "wpCardTemplate";
            this.wpCardTemplate.Size = new System.Drawing.Size(496, 201);
            this.wpCardTemplate.Text = "Card Template";
            // 
            // ceSignature
            // 
            this.ceSignature.EditValue = true;
            this.ceSignature.Location = new System.Drawing.Point(20, 164);
            this.ceSignature.Name = "ceSignature";
            this.ceSignature.Properties.Caption = "Include signature ";
            this.ceSignature.Size = new System.Drawing.Size(339, 19);
            this.ceSignature.TabIndex = 4;
            // 
            // rgWishes
            // 
            this.rgWishes.EditValue = "0";
            this.rgWishes.Location = new System.Drawing.Point(22, 33);
            this.rgWishes.Name = "rgWishes";
            this.rgWishes.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("0", "May all your wishes come true!"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Wishing you a day as special as you are!"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("2", "Your birthday makes this day really special, just like you are!")});
            this.rgWishes.Size = new System.Drawing.Size(337, 85);
            this.rgWishes.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl4.Location = new System.Drawing.Point(0, 0);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(496, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Please select a birthday wish from the list below:\r\n";
            // 
            // wpSignature
            // 
            this.wpSignature.AllowNext = false;
            this.wpSignature.Controls.Add(this.sbSkipSignature);
            this.wpSignature.Controls.Add(this.teYourName);
            this.wpSignature.Controls.Add(this.labelControl6);
            this.wpSignature.Controls.Add(this.cbeSignatureTemplate);
            this.wpSignature.Controls.Add(this.labelControl5);
            this.wpSignature.Name = "wpSignature";
            this.wpSignature.Size = new System.Drawing.Size(496, 201);
            this.wpSignature.Text = "Signature";
            // 
            // sbSkipSignature
            // 
            this.sbSkipSignature.Location = new System.Drawing.Point(415, 173);
            this.sbSkipSignature.Name = "sbSkipSignature";
            this.sbSkipSignature.Size = new System.Drawing.Size(78, 24);
            this.sbSkipSignature.TabIndex = 7;
            this.sbSkipSignature.Text = "&Skip";
            this.sbSkipSignature.Click += new System.EventHandler(this.sbSkipSignature_Click);
            // 
            // teYourName
            // 
            this.teYourName.Location = new System.Drawing.Point(22, 129);
            this.teYourName.Name = "teYourName";
            this.teYourName.Size = new System.Drawing.Size(337, 20);
            this.teYourName.TabIndex = 6;
            this.teYourName.TextChanged += new System.EventHandler(this.teYourName_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl6.Location = new System.Drawing.Point(0, 94);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(496, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Enter your name as you would like it to appear on the card:";
            // 
            // cbeSignatureTemplate
            // 
            this.cbeSignatureTemplate.EditValue = "Love";
            this.cbeSignatureTemplate.Location = new System.Drawing.Point(22, 36);
            this.cbeSignatureTemplate.Name = "cbeSignatureTemplate";
            this.cbeSignatureTemplate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbeSignatureTemplate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeSignatureTemplate.Properties.DropDownRows = 10;
            this.cbeSignatureTemplate.Properties.Items.AddRange(new object[] {
            "Love",
            "Hugs",
            "Regards",
            "Respectfully yours",
            "Respectfully",
            "Sincerely yours",
            "Sincerely",
            "Take care",
            "Yours truly"});
            this.cbeSignatureTemplate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeSignatureTemplate.Size = new System.Drawing.Size(337, 20);
            this.cbeSignatureTemplate.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl5.Location = new System.Drawing.Point(0, 0);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(496, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Please select a signature template from the list below:\r\n";
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Controls.Add(this.labelControl9);
            this.completionWizardPage1.Controls.Add(this.labelControl8);
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(496, 201);
            this.completionWizardPage1.Text = "Wizard Complete";
            // 
            // labelControl9
            // 
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelControl9.Location = new System.Drawing.Point(0, 188);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(496, 13);
            this.labelControl9.TabIndex = 6;
            this.labelControl9.Text = "To complete this wizard, click Finish.";
            // 
            // labelControl8
            // 
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl8.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl8.Location = new System.Drawing.Point(0, 0);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(496, 26);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "We want to thank you once again for trying this demo and hope you enjoyed the bir" +
    "thday card we created for you.";
            // 
            // wpPreview
            // 
            this.wpPreview.Controls.Add(this.sbSend);
            this.wpPreview.Controls.Add(this.meCard);
            this.wpPreview.Controls.Add(this.labelControl7);
            this.wpPreview.Name = "wpPreview";
            this.wpPreview.Size = new System.Drawing.Size(496, 201);
            this.wpPreview.Text = "Preview and Send";
            // 
            // sbSend
            // 
            this.sbSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbSend.Location = new System.Drawing.Point(342, 173);
            this.sbSend.Name = "sbSend";
            this.sbSend.Size = new System.Drawing.Size(151, 24);
            this.sbSend.TabIndex = 8;
            this.sbSend.Text = "Ready to send";
            this.sbSend.Click += new System.EventHandler(this.sbSend_Click);
            // 
            // meCard
            // 
            this.meCard.Location = new System.Drawing.Point(22, 36);
            this.meCard.Name = "meCard";
            this.meCard.Size = new System.Drawing.Size(442, 115);
            this.meCard.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl7.Location = new System.Drawing.Point(0, 0);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(496, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Here\'s your birthday card preview:\r\n";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 363);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraWizard Demo (WizardAero  Style, C# code)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.welcomeWizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.wpRecipientData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRecipientName.Properties)).EndInit();
            this.wpCardTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceSignature.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgWishes.Properties)).EndInit();
            this.wpSignature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teYourName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSignatureTemplate.Properties)).EndInit();
            this.completionWizardPage1.ResumeLayout(false);
            this.wpPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meCard.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wpRecipientData;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private WizardPage wpCardTemplate;
        private WizardPage wpSignature;
        private WizardPage wpPreview;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teRecipientName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teEmail;
        private DevExpress.XtraEditors.CheckEdit ceSignature;
        private DevExpress.XtraEditors.RadioGroup rgWishes;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton sbSkipSignature;
        private DevExpress.XtraEditors.TextEdit teYourName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cbeSignatureTemplate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton sbSend;
        private DevExpress.XtraEditors.MemoEdit meCard;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}

