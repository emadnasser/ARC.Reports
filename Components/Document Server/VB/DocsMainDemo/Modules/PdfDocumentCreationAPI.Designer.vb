Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class PdfDocumentCreationAPI
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
			Me.viewerPanel = New DevExpress.XtraEditors.PanelControl()
			Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
			Me.buttonCreateDocument = New DevExpress.XtraEditors.SimpleButton()
			Me.buttonSave = New DevExpress.XtraEditors.SimpleButton()
			Me.panelHeader = New DevExpress.XtraEditors.PanelControl()
			Me.labelSeparationLine = New DevExpress.XtraEditors.LabelControl()
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.viewerPanel.SuspendLayout()
			CType(Me.panelHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelHeader.SuspendLayout()
			Me.SuspendLayout()
			' 
			' viewerPanel
			' 
			Me.viewerPanel.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.viewerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.viewerPanel.Controls.Add(Me.pdfViewer)
			Me.viewerPanel.Location = New System.Drawing.Point(0, 53)
			Me.viewerPanel.Margin = New System.Windows.Forms.Padding(0)
			Me.viewerPanel.Name = "viewerPanel"
			Me.viewerPanel.Size = New System.Drawing.Size(737, 514)
			Me.viewerPanel.TabIndex = 3
			' 
			' pdfViewer
			' 
			Me.pdfViewer.DetachStreamAfterLoadComplete = True
			Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
			Me.pdfViewer.Margin = New System.Windows.Forms.Padding(0)
			Me.pdfViewer.Name = "pdfViewer"
			Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Collapsed
			Me.pdfViewer.ReadOnly = True
			Me.pdfViewer.Size = New System.Drawing.Size(737, 514)
			Me.pdfViewer.TabIndex = 3
			Me.pdfViewer.TabStop = False
			Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
			' 
			' buttonCreateDocument
			' 
			Me.buttonCreateDocument.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonCreateDocument.Location = New System.Drawing.Point(496, 15)
			Me.buttonCreateDocument.Name = "buttonCreateDocument"
			Me.buttonCreateDocument.Size = New System.Drawing.Size(110, 23)
			Me.buttonCreateDocument.TabIndex = 0
			Me.buttonCreateDocument.Text = "Create Document"
'			Me.buttonCreateDocument.Click += New System.EventHandler(Me.OnButtonCreateDocumentClick);
			' 
			' buttonSave
			' 
			Me.buttonSave.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonSave.Enabled = False
			Me.buttonSave.Location = New System.Drawing.Point(612, 15)
			Me.buttonSave.Name = "buttonSave"
			Me.buttonSave.Size = New System.Drawing.Size(110, 23)
			Me.buttonSave.TabIndex = 1
			Me.buttonSave.Text = "Save..."
'			Me.buttonSave.Click += New System.EventHandler(Me.OnSaveButtonClick);
			' 
			' panelHeader
			' 
			Me.panelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelHeader.Controls.Add(Me.labelSeparationLine)
			Me.panelHeader.Controls.Add(Me.buttonCreateDocument)
			Me.panelHeader.Controls.Add(Me.buttonSave)
			Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelHeader.Location = New System.Drawing.Point(0, 0)
			Me.panelHeader.Name = "panelHeader"
			Me.panelHeader.Size = New System.Drawing.Size(737, 53)
			Me.panelHeader.TabIndex = 0
			' 
			' labelSeparationLine
			' 
			Me.labelSeparationLine.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelSeparationLine.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.labelSeparationLine.LineVisible = True
			Me.labelSeparationLine.Location = New System.Drawing.Point(0, 50)
			Me.labelSeparationLine.Name = "labelSeparationLine"
			Me.labelSeparationLine.Size = New System.Drawing.Size(737, 3)
			Me.labelSeparationLine.TabIndex = 2
			' 
			' PdfDocumentCreationAPI
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panelHeader)
			Me.Controls.Add(Me.viewerPanel)
			Me.Name = "PdfDocumentCreationAPI"
			Me.Size = New System.Drawing.Size(737, 564)
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.viewerPanel.ResumeLayout(False)
			CType(Me.panelHeader, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelHeader.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private viewerPanel As XtraEditors.PanelControl
		Private pdfViewer As XtraPdfViewer.PdfViewer
		Private WithEvents buttonCreateDocument As XtraEditors.SimpleButton
		Private WithEvents buttonSave As XtraEditors.SimpleButton
		Private panelHeader As XtraEditors.PanelControl
		Private labelSeparationLine As XtraEditors.LabelControl

	End Class
End Namespace
