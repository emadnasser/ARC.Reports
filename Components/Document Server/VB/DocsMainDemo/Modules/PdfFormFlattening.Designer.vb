Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class PdfFormFlattening
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				fileHelper.Dispose()
				documentProcessor.Dispose()
				If components IsNot Nothing Then
					components.Dispose()
				End If
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
			Me.viewerPanel = New DevExpress.XtraEditors.PanelControl()
			Me.panelDocument = New System.Windows.Forms.Panel()
			Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
			Me.panelOptions = New System.Windows.Forms.Panel()
			Me.buttonLoadDemoDocument = New DevExpress.XtraEditors.SimpleButton()
			Me.docOperationsPanel = New DevExpress.XtraEditors.PanelControl()
			Me.buttonOpen = New DevExpress.XtraEditors.SimpleButton()
			Me.buttonSave = New DevExpress.XtraEditors.SimpleButton()
			Me.buttonFlattenFormFields = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.viewerPanel.SuspendLayout()
			Me.panelDocument.SuspendLayout()
			Me.panelOptions.SuspendLayout()
			CType(Me.docOperationsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.docOperationsPanel.SuspendLayout()
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
			Me.panelDocument.Location = New System.Drawing.Point(0, 53)
			Me.panelDocument.Name = "panelDocument"
			Me.panelDocument.Size = New System.Drawing.Size(737, 511)
			Me.panelDocument.TabIndex = 8
			' 
			' pdfViewer
			' 
			Me.pdfViewer.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pdfViewer.DetachStreamAfterLoadComplete = True
			Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
			Me.pdfViewer.Name = "pdfViewer"
			Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
			Me.pdfViewer.Size = New System.Drawing.Size(737, 511)
			Me.pdfViewer.TabIndex = 6
			Me.pdfViewer.TabStop = False
			Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
'			Me.pdfViewer.DocumentClosing += New DevExpress.XtraPdfViewer.PdfDocumentClosingEventHandler(Me.DocumentClosing);
			' 
			' panelOptions
			' 
			Me.panelOptions.Controls.Add(Me.buttonLoadDemoDocument)
			Me.panelOptions.Controls.Add(Me.docOperationsPanel)
			Me.panelOptions.Controls.Add(Me.buttonFlattenFormFields)
			Me.panelOptions.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelOptions.Location = New System.Drawing.Point(0, 0)
			Me.panelOptions.Name = "panelOptions"
			Me.panelOptions.Size = New System.Drawing.Size(737, 53)
			Me.panelOptions.TabIndex = 6
			' 
			' buttonLoadDemoDocument
			' 
			Me.buttonLoadDemoDocument.Location = New System.Drawing.Point(187, 14)
			Me.buttonLoadDemoDocument.Margin = New System.Windows.Forms.Padding(30)
			Me.buttonLoadDemoDocument.Name = "buttonLoadDemoDocument"
			Me.buttonLoadDemoDocument.Size = New System.Drawing.Size(162, 23)
			Me.buttonLoadDemoDocument.TabIndex = 46
			Me.buttonLoadDemoDocument.Text = "Load Demo Document"
'			Me.buttonLoadDemoDocument.Click += New System.EventHandler(Me.LoadDemoDocumentClick);
			' 
			' docOperationsPanel
			' 
			Me.docOperationsPanel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.docOperationsPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.docOperationsPanel.Controls.Add(Me.buttonOpen)
			Me.docOperationsPanel.Controls.Add(Me.buttonSave)
			Me.docOperationsPanel.Location = New System.Drawing.Point(498, 14)
			Me.docOperationsPanel.Name = "docOperationsPanel"
			Me.docOperationsPanel.Size = New System.Drawing.Size(226, 23)
			Me.docOperationsPanel.TabIndex = 45
			' 
			' buttonOpen
			' 
			Me.buttonOpen.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonOpen.Location = New System.Drawing.Point(0, 0)
			Me.buttonOpen.Name = "buttonOpen"
			Me.buttonOpen.Size = New System.Drawing.Size(110, 23)
			Me.buttonOpen.TabIndex = 3
			Me.buttonOpen.Text = "Open..."
'			Me.buttonOpen.Click += New System.EventHandler(Me.OpenClick);
			' 
			' buttonSave
			' 
			Me.buttonSave.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonSave.Location = New System.Drawing.Point(116, 0)
			Me.buttonSave.Name = "buttonSave"
			Me.buttonSave.Size = New System.Drawing.Size(110, 23)
			Me.buttonSave.TabIndex = 4
			Me.buttonSave.Text = "Save..."
'			Me.buttonSave.Click += New System.EventHandler(Me.SaveClick);
			' 
			' buttonFlattenFormFields
			' 
			Me.buttonFlattenFormFields.Location = New System.Drawing.Point(15, 14)
			Me.buttonFlattenFormFields.Margin = New System.Windows.Forms.Padding(30)
			Me.buttonFlattenFormFields.Name = "buttonFlattenFormFields"
			Me.buttonFlattenFormFields.Size = New System.Drawing.Size(162, 23)
			Me.buttonFlattenFormFields.TabIndex = 44
			Me.buttonFlattenFormFields.Text = "Flatten Form Fields"
'			Me.buttonFlattenFormFields.Click += New System.EventHandler(Me.FlattenFormFieldsClick);
			' 
			' PdfFormFlattening
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.viewerPanel)
			Me.Name = "PdfFormFlattening"
			Me.Size = New System.Drawing.Size(737, 564)
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.viewerPanel.ResumeLayout(False)
			Me.panelDocument.ResumeLayout(False)
			Me.panelOptions.ResumeLayout(False)
			CType(Me.docOperationsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.docOperationsPanel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private viewerPanel As XtraEditors.PanelControl
		Private panelOptions As System.Windows.Forms.Panel
		Private panelDocument As System.Windows.Forms.Panel
		Private WithEvents pdfViewer As XtraPdfViewer.PdfViewer
		Private WithEvents buttonFlattenFormFields As XtraEditors.SimpleButton
		Private docOperationsPanel As XtraEditors.PanelControl
		Private WithEvents buttonOpen As XtraEditors.SimpleButton
		Private WithEvents buttonSave As XtraEditors.SimpleButton
		Private WithEvents buttonLoadDemoDocument As XtraEditors.SimpleButton

	End Class
End Namespace
