Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class PdfFileAttachmentDemo
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
			Me.deleteButton = New DevExpress.XtraEditors.SimpleButton()
			Me.buttonAttachFile = New DevExpress.XtraEditors.SimpleButton()
			Me.lbFileAttachments = New DevExpress.XtraEditors.ListBoxControl()
			Me.labelFileAttachments = New DevExpress.XtraEditors.LabelControl()
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.viewerPanel.SuspendLayout()
			Me.panelDocument.SuspendLayout()
			Me.panelOptions.SuspendLayout()
			CType(Me.lbFileAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.panelDocument.Size = New System.Drawing.Size(529, 564)
			Me.panelDocument.TabIndex = 6
			' 
			' pdfViewer
			' 
			Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
			Me.pdfViewer.Name = "pdfViewer"
			Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Collapsed
			Me.pdfViewer.NavigationPaneWidth = 300
			Me.pdfViewer.ReadOnly = True
			Me.pdfViewer.Size = New System.Drawing.Size(529, 564)
			Me.pdfViewer.TabIndex = 6
			Me.pdfViewer.TabStop = False
			Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
			' 
			' panelOptions
			' 
			Me.panelOptions.Controls.Add(Me.deleteButton)
			Me.panelOptions.Controls.Add(Me.buttonAttachFile)
			Me.panelOptions.Controls.Add(Me.lbFileAttachments)
			Me.panelOptions.Controls.Add(Me.labelFileAttachments)
			Me.panelOptions.Dock = System.Windows.Forms.DockStyle.Right
			Me.panelOptions.Location = New System.Drawing.Point(529, 0)
			Me.panelOptions.Name = "panelOptions"
			Me.panelOptions.Size = New System.Drawing.Size(208, 564)
			Me.panelOptions.TabIndex = 6
			' 
			' deleteButton
			' 
			Me.deleteButton.Location = New System.Drawing.Point(18, 289)
			Me.deleteButton.Margin = New System.Windows.Forms.Padding(30)
			Me.deleteButton.Name = "deleteButton"
			Me.deleteButton.Size = New System.Drawing.Size(172, 23)
			Me.deleteButton.TabIndex = 26
			Me.deleteButton.Text = "Delete Selected File"
'			Me.deleteButton.Click += New System.EventHandler(Me.OnDeleteFile);
			' 
			' buttonAttachFile
			' 
			Me.buttonAttachFile.Location = New System.Drawing.Point(18, 18)
			Me.buttonAttachFile.Margin = New System.Windows.Forms.Padding(30)
			Me.buttonAttachFile.Name = "buttonAttachFile"
			Me.buttonAttachFile.Size = New System.Drawing.Size(172, 23)
			Me.buttonAttachFile.TabIndex = 1
			Me.buttonAttachFile.Text = "Attach File..."
'			Me.buttonAttachFile.Click += New System.EventHandler(Me.OnAttachFile);
			' 
			' lbFileAttachments
			' 
			Me.lbFileAttachments.DisplayMember = "FileName"
			Me.lbFileAttachments.ItemAutoHeight = True
			Me.lbFileAttachments.Location = New System.Drawing.Point(18, 84)
			Me.lbFileAttachments.Name = "lbFileAttachments"
			Me.lbFileAttachments.Size = New System.Drawing.Size(172, 195)
			Me.lbFileAttachments.TabIndex = 0
			' 
			' labelFileAttachments
			' 
			Me.labelFileAttachments.Location = New System.Drawing.Point(18, 61)
			Me.labelFileAttachments.Name = "labelFileAttachments"
			Me.labelFileAttachments.Size = New System.Drawing.Size(84, 13)
			Me.labelFileAttachments.TabIndex = 25
			Me.labelFileAttachments.Text = "File Attachments:"
			' 
			' PdfFileAttachmentDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.viewerPanel)
			Me.Name = "PdfFileAttachmentDemo"
			Me.Size = New System.Drawing.Size(737, 564)
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.viewerPanel.ResumeLayout(False)
			Me.panelDocument.ResumeLayout(False)
			Me.panelOptions.ResumeLayout(False)
			Me.panelOptions.PerformLayout()
			CType(Me.lbFileAttachments, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private viewerPanel As XtraEditors.PanelControl
		Private panelOptions As System.Windows.Forms.Panel
		Private panelDocument As System.Windows.Forms.Panel
		Private pdfViewer As XtraPdfViewer.PdfViewer
		Private labelFileAttachments As XtraEditors.LabelControl
		Private lbFileAttachments As XtraEditors.ListBoxControl
		Private WithEvents buttonAttachFile As XtraEditors.SimpleButton
		Private WithEvents deleteButton As XtraEditors.SimpleButton

	End Class
End Namespace
