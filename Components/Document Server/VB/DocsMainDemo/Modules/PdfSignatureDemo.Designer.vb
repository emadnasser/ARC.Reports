Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class PdfSignatureDemo
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.viewerPanel = New DevExpress.XtraEditors.PanelControl()
			Me.panelDocument = New System.Windows.Forms.Panel()
			Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
			Me.panelOptions = New System.Windows.Forms.Panel()
			Me.buttonNewCertificate = New DevExpress.XtraEditors.SimpleButton()
			Me.teReason = New DevExpress.XtraEditors.TextEdit()
			Me.lbCerts = New DevExpress.XtraEditors.ListBoxControl()
			Me.labelContactInfo = New DevExpress.XtraEditors.LabelControl()
			Me.labelLocation = New DevExpress.XtraEditors.LabelControl()
			Me.labelReason = New DevExpress.XtraEditors.LabelControl()
			Me.labelCertificate = New DevExpress.XtraEditors.LabelControl()
			Me.teContactInfo = New DevExpress.XtraEditors.TextEdit()
			Me.teLocation = New DevExpress.XtraEditors.TextEdit()
			Me.buttonSign = New DevExpress.XtraEditors.SimpleButton()
			Me.panelNewCertificate = New System.Windows.Forms.Panel()
			Me.panelSign = New System.Windows.Forms.Panel()
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.viewerPanel.SuspendLayout()
			Me.panelDocument.SuspendLayout()
			Me.panelOptions.SuspendLayout()
			CType(Me.teReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbCerts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teContactInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelNewCertificate.SuspendLayout()
			Me.panelSign.SuspendLayout()
			Me.SuspendLayout()
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
			Me.viewerPanel.TabIndex = 7
			' 
			' panelDocument
			' 
			Me.panelDocument.Controls.Add(Me.pdfViewer)
			Me.panelDocument.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelDocument.Location = New System.Drawing.Point(0, 0)
			Me.panelDocument.Name = "panelDocument"
			Me.panelDocument.Size = New System.Drawing.Size(451, 564)
			Me.panelDocument.TabIndex = 6
			' 
			' pdfViewer
			' 
			Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
			Me.pdfViewer.Name = "pdfViewer"
			Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
			Me.pdfViewer.ReadOnly = True
			Me.pdfViewer.Size = New System.Drawing.Size(451, 564)
			Me.pdfViewer.TabIndex = 6
			Me.pdfViewer.TabStop = False
			Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
			' 
			' panelOptions
			' 
			Me.panelOptions.Controls.Add(Me.panelSign)
			Me.panelOptions.Controls.Add(Me.panelNewCertificate)
			Me.panelOptions.Controls.Add(Me.teReason)
			Me.panelOptions.Controls.Add(Me.lbCerts)
			Me.panelOptions.Controls.Add(Me.labelContactInfo)
			Me.panelOptions.Controls.Add(Me.labelLocation)
			Me.panelOptions.Controls.Add(Me.labelReason)
			Me.panelOptions.Controls.Add(Me.labelCertificate)
			Me.panelOptions.Controls.Add(Me.teContactInfo)
			Me.panelOptions.Controls.Add(Me.teLocation)
			Me.panelOptions.Dock = System.Windows.Forms.DockStyle.Right
			Me.panelOptions.Location = New System.Drawing.Point(451, 0)
			Me.panelOptions.Name = "panelOptions"
			Me.panelOptions.Size = New System.Drawing.Size(286, 564)
			Me.panelOptions.TabIndex = 6
			' 
			' buttonNewCertificate
			' 
			Me.buttonNewCertificate.Location = New System.Drawing.Point(0, 0)
			Me.buttonNewCertificate.Margin = New System.Windows.Forms.Padding(30)
			Me.buttonNewCertificate.Name = "buttonNewCertificate"
			Me.buttonNewCertificate.Size = New System.Drawing.Size(152, 23)
			Me.buttonNewCertificate.TabIndex = 1
			Me.buttonNewCertificate.Text = "Load Certificate..."
'			Me.buttonNewCertificate.Click += New System.EventHandler(Me.OnButtonNewCertificateClick);
			' 
			' teReason
			' 
			Me.teReason.Location = New System.Drawing.Point(116, 149)
			Me.teReason.Margin = New System.Windows.Forms.Padding(2)
			Me.teReason.Name = "teReason"
			Me.teReason.Size = New System.Drawing.Size(152, 20)
			Me.teReason.TabIndex = 2
			' 
			' lbCerts
			' 
			Me.lbCerts.DisplayMember = "Name"
			Me.lbCerts.ItemAutoHeight = True
			Me.lbCerts.Location = New System.Drawing.Point(116, 30)
			Me.lbCerts.Name = "lbCerts"
			Me.lbCerts.Size = New System.Drawing.Size(152, 83)
			Me.lbCerts.TabIndex = 0
			' 
			' labelContactInfo
			' 
			Me.labelContactInfo.Location = New System.Drawing.Point(25, 200)
			Me.labelContactInfo.Name = "labelContactInfo"
			Me.labelContactInfo.Size = New System.Drawing.Size(63, 13)
			Me.labelContactInfo.TabIndex = 35
			Me.labelContactInfo.Text = "Contact info:"
			' 
			' labelLocation
			' 
			Me.labelLocation.Location = New System.Drawing.Point(26, 176)
			Me.labelLocation.Name = "labelLocation"
			Me.labelLocation.Size = New System.Drawing.Size(44, 13)
			Me.labelLocation.TabIndex = 33
			Me.labelLocation.Text = "Location:"
			' 
			' labelReason
			' 
			Me.labelReason.Location = New System.Drawing.Point(26, 152)
			Me.labelReason.Name = "labelReason"
			Me.labelReason.Size = New System.Drawing.Size(40, 13)
			Me.labelReason.TabIndex = 31
			Me.labelReason.Text = "Reason:"
			' 
			' labelCertificate
			' 
			Me.labelCertificate.Location = New System.Drawing.Point(25, 33)
			Me.labelCertificate.Name = "labelCertificate"
			Me.labelCertificate.Size = New System.Drawing.Size(54, 13)
			Me.labelCertificate.TabIndex = 25
			Me.labelCertificate.Text = "Certificate:"
			' 
			' teContactInfo
			' 
			Me.teContactInfo.Location = New System.Drawing.Point(116, 197)
			Me.teContactInfo.Margin = New System.Windows.Forms.Padding(2)
			Me.teContactInfo.Name = "teContactInfo"
			Me.teContactInfo.Size = New System.Drawing.Size(152, 20)
			Me.teContactInfo.TabIndex = 4
			' 
			' teLocation
			' 
			Me.teLocation.Location = New System.Drawing.Point(116, 173)
			Me.teLocation.Margin = New System.Windows.Forms.Padding(2)
			Me.teLocation.Name = "teLocation"
			Me.teLocation.Size = New System.Drawing.Size(152, 20)
			Me.teLocation.TabIndex = 3
			' 
			' buttonSign
			' 
			Me.buttonSign.Location = New System.Drawing.Point(0, 0)
			Me.buttonSign.Margin = New System.Windows.Forms.Padding(30)
			Me.buttonSign.Name = "buttonSign"
			Me.buttonSign.Size = New System.Drawing.Size(152, 23)
			Me.buttonSign.TabIndex = 5
			Me.buttonSign.Text = "Sign and Save..."
'			Me.buttonSign.Click += New System.EventHandler(Me.OnButtonSignClick);
			' 
			' panelNewCertificate
			' 
			Me.panelNewCertificate.Controls.Add(Me.buttonNewCertificate)
			Me.panelNewCertificate.Location = New System.Drawing.Point(116, 118)
			Me.panelNewCertificate.Name = "panelNewCertificate"
			Me.panelNewCertificate.Size = New System.Drawing.Size(152, 23)
			Me.panelNewCertificate.TabIndex = 1
			' 
			' panelSign
			' 
			Me.panelSign.Controls.Add(Me.buttonSign)
			Me.panelSign.Location = New System.Drawing.Point(116, 225)
			Me.panelSign.Name = "panelSign"
			Me.panelSign.Size = New System.Drawing.Size(152, 23)
			Me.panelSign.TabIndex = 5
			' 
			' PdfSignatureDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.viewerPanel)
			Me.Name = "PdfSignatureDemo"
			Me.Size = New System.Drawing.Size(737, 564)
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.viewerPanel.ResumeLayout(False)
			Me.panelDocument.ResumeLayout(False)
			Me.panelOptions.ResumeLayout(False)
			Me.panelOptions.PerformLayout()
			CType(Me.teReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbCerts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teContactInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelNewCertificate.ResumeLayout(False)
			Me.panelSign.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private viewerPanel As XtraEditors.PanelControl
		Private panelOptions As System.Windows.Forms.Panel
		Private panelDocument As System.Windows.Forms.Panel
		Private pdfViewer As XtraPdfViewer.PdfViewer
		Private WithEvents buttonSign As XtraEditors.SimpleButton
		Private teContactInfo As XtraEditors.TextEdit
		Private teLocation As XtraEditors.TextEdit
		Private labelContactInfo As XtraEditors.LabelControl
		Private labelLocation As XtraEditors.LabelControl
		Private labelReason As XtraEditors.LabelControl
		Private labelCertificate As XtraEditors.LabelControl
		Private lbCerts As XtraEditors.ListBoxControl
		Private teReason As XtraEditors.TextEdit
		Private WithEvents buttonNewCertificate As XtraEditors.SimpleButton
		Private panelSign As System.Windows.Forms.Panel
		Private panelNewCertificate As System.Windows.Forms.Panel

	End Class
End Namespace
