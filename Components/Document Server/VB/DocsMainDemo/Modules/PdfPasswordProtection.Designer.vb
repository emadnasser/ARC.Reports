Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class PdfPasswordProtection
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.panelOptions = New System.Windows.Forms.Panel()
			Me.imageComboBoxInteractivity = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.imageComboBoxModifying = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.imageComboBoxDataExtraction = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.imageComboBoxPrinting = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.labelInteractivity = New DevExpress.XtraEditors.LabelControl()
			Me.labelModifying = New DevExpress.XtraEditors.LabelControl()
			Me.labelDataExtraction = New DevExpress.XtraEditors.LabelControl()
			Me.labelPrinting = New DevExpress.XtraEditors.LabelControl()
			Me.teOwnerPassword = New DevExpress.XtraEditors.TextEdit()
			Me.labelUserPassword = New DevExpress.XtraEditors.LabelControl()
			Me.labelOwnerPassword = New DevExpress.XtraEditors.LabelControl()
			Me.teUserPassword = New DevExpress.XtraEditors.TextEdit()
			Me.buttonEncrypt = New DevExpress.XtraEditors.SimpleButton()
			Me.viewerPanel = New DevExpress.XtraEditors.PanelControl()
			Me.panelDocument = New System.Windows.Forms.Panel()
			Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
			Me.panelPermissions = New System.Windows.Forms.Panel()
			Me.panelEncrypt = New System.Windows.Forms.Panel()
			Me.panelOptions.SuspendLayout()
			CType(Me.imageComboBoxInteractivity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageComboBoxModifying.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageComboBoxDataExtraction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageComboBoxPrinting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teOwnerPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teUserPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.viewerPanel.SuspendLayout()
			Me.panelDocument.SuspendLayout()
			Me.panelPermissions.SuspendLayout()
			Me.panelEncrypt.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panelOptions
			' 
			Me.panelOptions.Controls.Add(Me.panelEncrypt)
			Me.panelOptions.Controls.Add(Me.panelPermissions)
			Me.panelOptions.Controls.Add(Me.labelInteractivity)
			Me.panelOptions.Controls.Add(Me.labelModifying)
			Me.panelOptions.Controls.Add(Me.labelDataExtraction)
			Me.panelOptions.Controls.Add(Me.labelPrinting)
			Me.panelOptions.Controls.Add(Me.teOwnerPassword)
			Me.panelOptions.Controls.Add(Me.labelUserPassword)
			Me.panelOptions.Controls.Add(Me.labelOwnerPassword)
			Me.panelOptions.Controls.Add(Me.teUserPassword)
			Me.panelOptions.Dock = System.Windows.Forms.DockStyle.Right
			Me.panelOptions.Location = New System.Drawing.Point(451, 0)
			Me.panelOptions.Name = "panelOptions"
			Me.panelOptions.Size = New System.Drawing.Size(286, 564)
			Me.panelOptions.TabIndex = 1
			' 
			' imageComboBoxInteractivity
			' 
			Me.imageComboBoxInteractivity.Location = New System.Drawing.Point(0, 75)
			Me.imageComboBoxInteractivity.Name = "imageComboBoxInteractivity"
			Me.imageComboBoxInteractivity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.imageComboBoxInteractivity.Size = New System.Drawing.Size(135, 20)
			Me.imageComboBoxInteractivity.TabIndex = 5
			' 
			' imageComboBoxModifying
			' 
			Me.imageComboBoxModifying.Location = New System.Drawing.Point(0, 50)
			Me.imageComboBoxModifying.Name = "imageComboBoxModifying"
			Me.imageComboBoxModifying.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.imageComboBoxModifying.Size = New System.Drawing.Size(135, 20)
			Me.imageComboBoxModifying.TabIndex = 4
			' 
			' imageComboBoxDataExtraction
			' 
			Me.imageComboBoxDataExtraction.Location = New System.Drawing.Point(0, 25)
			Me.imageComboBoxDataExtraction.Name = "imageComboBoxDataExtraction"
			Me.imageComboBoxDataExtraction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.imageComboBoxDataExtraction.Size = New System.Drawing.Size(135, 20)
			Me.imageComboBoxDataExtraction.TabIndex = 3
			' 
			' imageComboBoxPrinting
			' 
			Me.imageComboBoxPrinting.Location = New System.Drawing.Point(0, 0)
			Me.imageComboBoxPrinting.Margin = New System.Windows.Forms.Padding(30)
			Me.imageComboBoxPrinting.Name = "imageComboBoxPrinting"
			Me.imageComboBoxPrinting.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.imageComboBoxPrinting.Size = New System.Drawing.Size(135, 20)
			Me.imageComboBoxPrinting.TabIndex = 2
			' 
			' labelInteractivity
			' 
			Me.labelInteractivity.Location = New System.Drawing.Point(25, 160)
			Me.labelInteractivity.Name = "labelInteractivity"
			Me.labelInteractivity.Size = New System.Drawing.Size(63, 13)
			Me.labelInteractivity.TabIndex = 51
			Me.labelInteractivity.Text = "Interactivity:"
			' 
			' labelModifying
			' 
			Me.labelModifying.Location = New System.Drawing.Point(25, 135)
			Me.labelModifying.Name = "labelModifying"
			Me.labelModifying.Size = New System.Drawing.Size(50, 13)
			Me.labelModifying.TabIndex = 49
			Me.labelModifying.Text = "Modifying:"
			' 
			' labelDataExtraction
			' 
			Me.labelDataExtraction.Location = New System.Drawing.Point(25, 110)
			Me.labelDataExtraction.Name = "labelDataExtraction"
			Me.labelDataExtraction.Size = New System.Drawing.Size(79, 13)
			Me.labelDataExtraction.TabIndex = 47
			Me.labelDataExtraction.Text = "Data extraction:"
			' 
			' labelPrinting
			' 
			Me.labelPrinting.Location = New System.Drawing.Point(25, 85)
			Me.labelPrinting.Name = "labelPrinting"
			Me.labelPrinting.Size = New System.Drawing.Size(40, 13)
			Me.labelPrinting.TabIndex = 45
			Me.labelPrinting.Text = "Printing:"
			' 
			' teOwnerPassword
			' 
			Me.teOwnerPassword.Location = New System.Drawing.Point(132, 30)
			Me.teOwnerPassword.Margin = New System.Windows.Forms.Padding(2)
			Me.teOwnerPassword.Name = "teOwnerPassword"
			Me.teOwnerPassword.Properties.PasswordChar = "*"c
			Me.teOwnerPassword.Size = New System.Drawing.Size(135, 20)
			Me.teOwnerPassword.TabIndex = 0
			' 
			' labelUserPassword
			' 
			Me.labelUserPassword.Location = New System.Drawing.Point(25, 57)
			Me.labelUserPassword.Name = "labelUserPassword"
			Me.labelUserPassword.Size = New System.Drawing.Size(75, 13)
			Me.labelUserPassword.TabIndex = 31
			Me.labelUserPassword.Text = "User password:"
			' 
			' labelOwnerPassword
			' 
			Me.labelOwnerPassword.Location = New System.Drawing.Point(25, 33)
			Me.labelOwnerPassword.Name = "labelOwnerPassword"
			Me.labelOwnerPassword.Size = New System.Drawing.Size(85, 13)
			Me.labelOwnerPassword.TabIndex = 25
			Me.labelOwnerPassword.Text = "Owner password:"
			' 
			' teUserPassword
			' 
			Me.teUserPassword.Location = New System.Drawing.Point(132, 54)
			Me.teUserPassword.Margin = New System.Windows.Forms.Padding(2)
			Me.teUserPassword.Name = "teUserPassword"
			Me.teUserPassword.Properties.PasswordChar = "*"c
			Me.teUserPassword.Size = New System.Drawing.Size(135, 20)
			Me.teUserPassword.TabIndex = 1
			' 
			' buttonEncrypt
			' 
			Me.buttonEncrypt.Location = New System.Drawing.Point(0, 0)
			Me.buttonEncrypt.Margin = New System.Windows.Forms.Padding(30)
			Me.buttonEncrypt.Name = "buttonEncrypt"
			Me.buttonEncrypt.Size = New System.Drawing.Size(135, 23)
			Me.buttonEncrypt.TabIndex = 6
			Me.buttonEncrypt.Text = "Protect and Save..."
'			Me.buttonEncrypt.Click += New System.EventHandler(Me.OnButtonEncryptClick);
			' 
			' viewerPanel
			' 
			Me.viewerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.viewerPanel.Controls.Add(Me.panelDocument)
			Me.viewerPanel.Controls.Add(Me.panelOptions)
			Me.viewerPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.viewerPanel.Location = New System.Drawing.Point(0, 0)
			Me.viewerPanel.Name = "viewerPanel"
			Me.viewerPanel.Size = New System.Drawing.Size(737, 564)
			Me.viewerPanel.TabIndex = 8
			' 
			' panelDocument
			' 
			Me.panelDocument.Controls.Add(Me.pdfViewer)
			Me.panelDocument.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelDocument.Location = New System.Drawing.Point(0, 0)
			Me.panelDocument.Name = "panelDocument"
			Me.panelDocument.Size = New System.Drawing.Size(451, 564)
			Me.panelDocument.TabIndex = 7
			' 
			' pdfViewer
			' 
			Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
			Me.pdfViewer.Name = "pdfViewer"
			Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
			Me.pdfViewer.ReadOnly = True
			Me.pdfViewer.Size = New System.Drawing.Size(451, 564)
			Me.pdfViewer.TabIndex = 7
			Me.pdfViewer.TabStop = False
			Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
			' 
			' panelPermissions
			' 
			Me.panelPermissions.Controls.Add(Me.imageComboBoxDataExtraction)
			Me.panelPermissions.Controls.Add(Me.imageComboBoxModifying)
			Me.panelPermissions.Controls.Add(Me.imageComboBoxInteractivity)
			Me.panelPermissions.Controls.Add(Me.imageComboBoxPrinting)
			Me.panelPermissions.Location = New System.Drawing.Point(132, 82)
			Me.panelPermissions.Name = "panelPermissions"
			Me.panelPermissions.Size = New System.Drawing.Size(135, 95)
			Me.panelPermissions.TabIndex = 2
			' 
			' panelEncrypt
			' 
			Me.panelEncrypt.Controls.Add(Me.buttonEncrypt)
			Me.panelEncrypt.Location = New System.Drawing.Point(132, 185)
			Me.panelEncrypt.Name = "panelEncrypt"
			Me.panelEncrypt.Size = New System.Drawing.Size(135, 23)
			Me.panelEncrypt.TabIndex = 52
			' 
			' PdfPasswordProtection
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.viewerPanel)
			Me.Name = "PdfPasswordProtection"
			Me.Size = New System.Drawing.Size(737, 564)
			Me.panelOptions.ResumeLayout(False)
			Me.panelOptions.PerformLayout()
			CType(Me.imageComboBoxInteractivity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageComboBoxModifying.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageComboBoxDataExtraction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageComboBoxPrinting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teOwnerPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teUserPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.viewerPanel.ResumeLayout(False)
			Me.panelDocument.ResumeLayout(False)
			Me.panelPermissions.ResumeLayout(False)
			Me.panelEncrypt.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelOptions As System.Windows.Forms.Panel
		Private teOwnerPassword As XtraEditors.TextEdit
		Private labelUserPassword As XtraEditors.LabelControl
		Private labelOwnerPassword As XtraEditors.LabelControl
		Private teUserPassword As XtraEditors.TextEdit
		Private WithEvents buttonEncrypt As XtraEditors.SimpleButton
		Private viewerPanel As XtraEditors.PanelControl
		Private panelDocument As System.Windows.Forms.Panel
		Private pdfViewer As XtraPdfViewer.PdfViewer
		Private labelDataExtraction As XtraEditors.LabelControl
		Private labelPrinting As XtraEditors.LabelControl
		Private labelInteractivity As XtraEditors.LabelControl
		Private labelModifying As XtraEditors.LabelControl
		Private imageComboBoxPrinting As XtraEditors.ImageComboBoxEdit
		Private imageComboBoxInteractivity As XtraEditors.ImageComboBoxEdit
		Private imageComboBoxModifying As XtraEditors.ImageComboBoxEdit
		Private imageComboBoxDataExtraction As XtraEditors.ImageComboBoxEdit
		Private panelPermissions As System.Windows.Forms.Panel
		Private panelEncrypt As System.Windows.Forms.Panel


	End Class
End Namespace
