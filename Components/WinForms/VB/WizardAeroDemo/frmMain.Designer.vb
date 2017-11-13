Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraWizard.Demos
	Partial Public Class frmMain
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
            Me.wizardControl1 = New DevExpress.XtraWizard.WizardControl()
            Me.welcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
            Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.wpRecipientData = New DevExpress.XtraWizard.WizardPage()
            Me.teEmail = New DevExpress.XtraEditors.TextEdit()
            Me.teRecipientName = New DevExpress.XtraEditors.TextEdit()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.wpCardTemplate = New DevExpress.XtraWizard.WizardPage()
            Me.ceSignature = New DevExpress.XtraEditors.CheckEdit()
            Me.rgWishes = New DevExpress.XtraEditors.RadioGroup()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.wpSignature = New DevExpress.XtraWizard.WizardPage()
            Me.sbSkipSignature = New DevExpress.XtraEditors.SimpleButton()
            Me.teYourName = New DevExpress.XtraEditors.TextEdit()
            Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
            Me.cbeSignatureTemplate = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.completionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
            Me.labelControl9 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl8 = New DevExpress.XtraEditors.LabelControl()
            Me.wpPreview = New DevExpress.XtraWizard.WizardPage()
            Me.sbSend = New DevExpress.XtraEditors.SimpleButton()
            Me.meCard = New DevExpress.XtraEditors.MemoEdit()
            Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
            CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.wizardControl1.SuspendLayout()
            Me.welcomeWizardPage1.SuspendLayout()
            CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.wpRecipientData.SuspendLayout()
            CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teRecipientName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.wpCardTemplate.SuspendLayout()
            CType(Me.ceSignature.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rgWishes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.wpSignature.SuspendLayout()
            CType(Me.teYourName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbeSignatureTemplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.completionWizardPage1.SuspendLayout()
            Me.wpPreview.SuspendLayout()
            CType(Me.meCard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'wizardControl1
            '
            Me.wizardControl1.Controls.Add(Me.welcomeWizardPage1)
            Me.wizardControl1.Controls.Add(Me.wpRecipientData)
            Me.wizardControl1.Controls.Add(Me.wpCardTemplate)
            Me.wizardControl1.Controls.Add(Me.wpSignature)
            Me.wizardControl1.Controls.Add(Me.completionWizardPage1)
            Me.wizardControl1.Controls.Add(Me.wpPreview)
            Me.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.wizardControl1.Location = New System.Drawing.Point(0, 0)
            Me.wizardControl1.Name = "wizardControl1"
            Me.wizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.welcomeWizardPage1, Me.wpRecipientData, Me.wpCardTemplate, Me.wpSignature, Me.wpPreview, Me.completionWizardPage1})
            Me.wizardControl1.Size = New System.Drawing.Size(556, 363)
            Me.wizardControl1.Text = "Birthday Card"
            Me.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero
            '
            'welcomeWizardPage1
            '
            Me.welcomeWizardPage1.Controls.Add(Me.PictureEdit1)
            Me.welcomeWizardPage1.Controls.Add(Me.labelControl1)
            Me.welcomeWizardPage1.Name = "welcomeWizardPage1"
            Me.welcomeWizardPage1.Size = New System.Drawing.Size(496, 201)
            Me.welcomeWizardPage1.Text = "Welcome to DevExpress XtraWizard Control Demo"
            '
            'PictureEdit1
            '
            Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PictureEdit1.EditValue = Global.Resources.picture_post_card
            Me.PictureEdit1.Location = New System.Drawing.Point(0, 26)
            Me.PictureEdit1.Name = "PictureEdit1"
            Me.PictureEdit1.Properties.AllowFocused = False
            Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.PictureEdit1.Properties.ShowMenu = False
            Me.PictureEdit1.Size = New System.Drawing.Size(496, 175)
            Me.PictureEdit1.TabIndex = 1
            '
            'labelControl1
            '
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl1.Location = New System.Drawing.Point(0, 0)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(496, 26)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "Thank you for evaluating XtraWizard! This demo application will generate a birthd" & _
        "ay card for you, all the while showing off many features of our wizard control, " & _
        "including the Windows Aero layout."
            '
            'wpRecipientData
            '
            Me.wpRecipientData.AllowNext = False
            Me.wpRecipientData.Controls.Add(Me.teEmail)
            Me.wpRecipientData.Controls.Add(Me.teRecipientName)
            Me.wpRecipientData.Controls.Add(Me.labelControl3)
            Me.wpRecipientData.Controls.Add(Me.labelControl2)
            Me.wpRecipientData.Name = "wpRecipientData"
            Me.wpRecipientData.Size = New System.Drawing.Size(496, 201)
            Me.wpRecipientData.Text = "Recipient Name and Address"
            '
            'teEmail
            '
            Me.teEmail.Location = New System.Drawing.Point(22, 129)
            Me.teEmail.Name = "teEmail"
            Me.teEmail.Properties.Mask.EditMask = ".+@.+\..+"
            Me.teEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
            Me.teEmail.Size = New System.Drawing.Size(337, 20)
            Me.teEmail.TabIndex = 4
            '
            'teRecipientName
            '
            Me.teRecipientName.Location = New System.Drawing.Point(22, 36)
            Me.teRecipientName.Name = "teRecipientName"
            Me.teRecipientName.Size = New System.Drawing.Size(337, 20)
            Me.teRecipientName.TabIndex = 3
            '
            'labelControl3
            '
            Me.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl3.Location = New System.Drawing.Point(0, 85)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(496, 13)
            Me.labelControl3.TabIndex = 2
            Me.labelControl3.Text = "Please enter the recipient's email address:"
            '
            'labelControl2
            '
            Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl2.Location = New System.Drawing.Point(0, 0)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(496, 13)
            Me.labelControl2.TabIndex = 1
            Me.labelControl2.Text = "Please enter the recipient’s name as you’d like to see it on the birthday card:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
        ""
            '
            'wpCardTemplate
            '
            Me.wpCardTemplate.Controls.Add(Me.ceSignature)
            Me.wpCardTemplate.Controls.Add(Me.rgWishes)
            Me.wpCardTemplate.Controls.Add(Me.labelControl4)
            Me.wpCardTemplate.Name = "wpCardTemplate"
            Me.wpCardTemplate.Size = New System.Drawing.Size(496, 201)
            Me.wpCardTemplate.Text = "Card Template"
            '
            'ceSignature
            '
            Me.ceSignature.EditValue = True
            Me.ceSignature.Location = New System.Drawing.Point(20, 164)
            Me.ceSignature.Name = "ceSignature"
            Me.ceSignature.Properties.Caption = "Include signature "
            Me.ceSignature.Size = New System.Drawing.Size(339, 19)
            Me.ceSignature.TabIndex = 4
            '
            'rgWishes
            '
            Me.rgWishes.EditValue = "0"
            Me.rgWishes.Location = New System.Drawing.Point(22, 33)
            Me.rgWishes.Name = "rgWishes"
            Me.rgWishes.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("0", "May all your wishes come true!"), New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Wishing you a day as special as you are!"), New DevExpress.XtraEditors.Controls.RadioGroupItem("2", "Your birthday makes this day really special, just like you are!")})
            Me.rgWishes.Size = New System.Drawing.Size(337, 85)
            Me.rgWishes.TabIndex = 3
            '
            'labelControl4
            '
            Me.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl4.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl4.Location = New System.Drawing.Point(0, 0)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(496, 13)
            Me.labelControl4.TabIndex = 2
            Me.labelControl4.Text = "Please select a birthday wish from the list below:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'wpSignature
            '
            Me.wpSignature.AllowNext = False
            Me.wpSignature.Controls.Add(Me.sbSkipSignature)
            Me.wpSignature.Controls.Add(Me.teYourName)
            Me.wpSignature.Controls.Add(Me.labelControl6)
            Me.wpSignature.Controls.Add(Me.cbeSignatureTemplate)
            Me.wpSignature.Controls.Add(Me.labelControl5)
            Me.wpSignature.Name = "wpSignature"
            Me.wpSignature.Size = New System.Drawing.Size(496, 201)
            Me.wpSignature.Text = "Signature"
            '
            'sbSkipSignature
            '
            Me.sbSkipSignature.Location = New System.Drawing.Point(415, 173)
            Me.sbSkipSignature.Name = "sbSkipSignature"
            Me.sbSkipSignature.Size = New System.Drawing.Size(78, 24)
            Me.sbSkipSignature.TabIndex = 7
            Me.sbSkipSignature.Text = "&Skip"
            '
            'teYourName
            '
            Me.teYourName.Location = New System.Drawing.Point(22, 129)
            Me.teYourName.Name = "teYourName"
            Me.teYourName.Size = New System.Drawing.Size(337, 20)
            Me.teYourName.TabIndex = 6
            '
            'labelControl6
            '
            Me.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl6.Location = New System.Drawing.Point(0, 94)
            Me.labelControl6.Name = "labelControl6"
            Me.labelControl6.Size = New System.Drawing.Size(496, 13)
            Me.labelControl6.TabIndex = 5
            Me.labelControl6.Text = "Enter your name as you would like it to appear on the card:"
            '
            'cbeSignatureTemplate
            '
            Me.cbeSignatureTemplate.EditValue = "Love"
            Me.cbeSignatureTemplate.Location = New System.Drawing.Point(22, 36)
            Me.cbeSignatureTemplate.Name = "cbeSignatureTemplate"
            Me.cbeSignatureTemplate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.cbeSignatureTemplate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeSignatureTemplate.Properties.DropDownRows = 10
            Me.cbeSignatureTemplate.Properties.Items.AddRange(New Object() {"Love", "Hugs", "Regards", "Respectfully yours", "Respectfully", "Sincerely yours", "Sincerely", "Take care", "Yours truly"})
            Me.cbeSignatureTemplate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbeSignatureTemplate.Size = New System.Drawing.Size(337, 20)
            Me.cbeSignatureTemplate.TabIndex = 4
            '
            'labelControl5
            '
            Me.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl5.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl5.Location = New System.Drawing.Point(0, 0)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Size = New System.Drawing.Size(496, 13)
            Me.labelControl5.TabIndex = 3
            Me.labelControl5.Text = "Please select a signature template from the list below:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'completionWizardPage1
            '
            Me.completionWizardPage1.Controls.Add(Me.labelControl9)
            Me.completionWizardPage1.Controls.Add(Me.labelControl8)
            Me.completionWizardPage1.Name = "completionWizardPage1"
            Me.completionWizardPage1.Size = New System.Drawing.Size(496, 201)
            Me.completionWizardPage1.Text = "Wizard Complete"
            '
            'labelControl9
            '
            Me.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl9.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.labelControl9.Location = New System.Drawing.Point(0, 188)
            Me.labelControl9.Name = "labelControl9"
            Me.labelControl9.Size = New System.Drawing.Size(496, 13)
            Me.labelControl9.TabIndex = 6
            Me.labelControl9.Text = "To complete this wizard, click Finish."
            '
            'labelControl8
            '
            Me.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl8.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl8.Location = New System.Drawing.Point(0, 0)
            Me.labelControl8.Name = "labelControl8"
            Me.labelControl8.Size = New System.Drawing.Size(496, 26)
            Me.labelControl8.TabIndex = 5
            Me.labelControl8.Text = "We want to thank you once again for trying this demo and hope you enjoyed the bir" & _
        "thday card we created for you."
            '
            'wpPreview
            '
            Me.wpPreview.Controls.Add(Me.sbSend)
            Me.wpPreview.Controls.Add(Me.meCard)
            Me.wpPreview.Controls.Add(Me.labelControl7)
            Me.wpPreview.Name = "wpPreview"
            Me.wpPreview.Size = New System.Drawing.Size(496, 201)
            Me.wpPreview.Text = "Preview and Send"
            '
            'sbSend
            '
            Me.sbSend.Cursor = System.Windows.Forms.Cursors.Hand
            Me.sbSend.Location = New System.Drawing.Point(342, 173)
            Me.sbSend.Name = "sbSend"
            Me.sbSend.Size = New System.Drawing.Size(151, 24)
            Me.sbSend.TabIndex = 8
            Me.sbSend.Text = "Ready to send"
            '
            'meCard
            '
            Me.meCard.Location = New System.Drawing.Point(22, 36)
            Me.meCard.Name = "meCard"
            Me.meCard.Size = New System.Drawing.Size(442, 115)
            Me.meCard.TabIndex = 5
            '
            'labelControl7
            '
            Me.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl7.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl7.Location = New System.Drawing.Point(0, 0)
            Me.labelControl7.Name = "labelControl7"
            Me.labelControl7.Size = New System.Drawing.Size(496, 13)
            Me.labelControl7.TabIndex = 4
            Me.labelControl7.Text = "Here's your birthday card preview:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'frmMain
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(556, 363)
            Me.Controls.Add(Me.wizardControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "XtraWizard Demo (WizardAero  Style, VB code)"
            CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.wizardControl1.ResumeLayout(False)
            Me.welcomeWizardPage1.ResumeLayout(False)
            CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.wpRecipientData.ResumeLayout(False)
            CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teRecipientName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.wpCardTemplate.ResumeLayout(False)
            CType(Me.ceSignature.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rgWishes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.wpSignature.ResumeLayout(False)
            CType(Me.teYourName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbeSignatureTemplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.completionWizardPage1.ResumeLayout(False)
            Me.wpPreview.ResumeLayout(False)
            CType(Me.meCard.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents wizardControl1 As DevExpress.XtraWizard.WizardControl
		Private welcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
		Private wpRecipientData As DevExpress.XtraWizard.WizardPage
		Private completionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
		Private wpCardTemplate As WizardPage
		Private wpSignature As WizardPage
		Private wpPreview As WizardPage
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents teRecipientName As DevExpress.XtraEditors.TextEdit
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents teEmail As DevExpress.XtraEditors.TextEdit
		Private ceSignature As DevExpress.XtraEditors.CheckEdit
		Private rgWishes As DevExpress.XtraEditors.RadioGroup
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private WithEvents sbSkipSignature As DevExpress.XtraEditors.SimpleButton
		Private WithEvents teYourName As DevExpress.XtraEditors.TextEdit
		Private labelControl6 As DevExpress.XtraEditors.LabelControl
		Private cbeSignatureTemplate As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private labelControl9 As DevExpress.XtraEditors.LabelControl
		Private labelControl8 As DevExpress.XtraEditors.LabelControl
		Private WithEvents sbSend As DevExpress.XtraEditors.SimpleButton
		Private meCard As DevExpress.XtraEditors.MemoEdit
        Private labelControl7 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
	End Class
End Namespace

