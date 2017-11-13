Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class PdfPageMerging
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
			Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
			Me.buttonAppend = New DevExpress.XtraEditors.SimpleButton()
			Me.buttonOpen = New DevExpress.XtraEditors.SimpleButton()
			Me.saveButton = New DevExpress.XtraEditors.SimpleButton()
			Me.newButton = New DevExpress.XtraEditors.SimpleButton()
			Me.headerPanel = New DevExpress.XtraEditors.PanelControl()
			Me.labelSeparationLine = New DevExpress.XtraEditors.LabelControl()
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.viewerPanel.SuspendLayout()
			CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.headerPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' viewerPanel
			' 
			Me.viewerPanel.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.viewerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.viewerPanel.Controls.Add(Me.pdfViewer)
			Me.viewerPanel.Location = New System.Drawing.Point(0, 53)
			Me.viewerPanel.Name = "viewerPanel"
			Me.viewerPanel.Size = New System.Drawing.Size(737, 511)
			Me.viewerPanel.TabIndex = 5
			' 
			' pdfViewer
			' 
			Me.pdfViewer.DetachStreamAfterLoadComplete = True
			Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
			Me.pdfViewer.Name = "pdfViewer"
			Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
			Me.pdfViewer.ReadOnly = True
			Me.pdfViewer.Size = New System.Drawing.Size(737, 511)
			Me.pdfViewer.TabIndex = 5
			Me.pdfViewer.TabStop = False
			Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
			' 
			' buttonAppend
			' 
			Me.buttonAppend.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonAppend.Location = New System.Drawing.Point(496, 15)
			Me.buttonAppend.Name = "buttonAppend"
			Me.buttonAppend.Size = New System.Drawing.Size(110, 23)
			Me.buttonAppend.TabIndex = 2
			Me.buttonAppend.Text = "Append..."
'			Me.buttonAppend.Click += New System.EventHandler(Me.OnButtonAppendClick);
			' 
			' buttonOpen
			' 
			Me.buttonOpen.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonOpen.Location = New System.Drawing.Point(380, 15)
			Me.buttonOpen.Name = "buttonOpen"
			Me.buttonOpen.Size = New System.Drawing.Size(110, 23)
			Me.buttonOpen.TabIndex = 1
			Me.buttonOpen.Text = "Open..."
'			Me.buttonOpen.Click += New System.EventHandler(Me.OnButtonOpenClick);
			' 
			' saveButton
			' 
			Me.saveButton.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.saveButton.Location = New System.Drawing.Point(612, 15)
			Me.saveButton.Name = "saveButton"
			Me.saveButton.Size = New System.Drawing.Size(110, 23)
			Me.saveButton.TabIndex = 3
			Me.saveButton.Text = "Save..."
'			Me.saveButton.Click += New System.EventHandler(Me.OnSaveButtonClick);
			' 
			' newButton
			' 
			Me.newButton.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.newButton.Location = New System.Drawing.Point(264, 15)
			Me.newButton.Name = "newButton"
			Me.newButton.Size = New System.Drawing.Size(110, 23)
			Me.newButton.TabIndex = 0
			Me.newButton.Text = "New"
'			Me.newButton.Click += New System.EventHandler(Me.OnNewButtonClick);
			' 
			' headerPanel
			' 
			Me.headerPanel.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.headerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.headerPanel.Controls.Add(Me.labelSeparationLine)
			Me.headerPanel.Controls.Add(Me.buttonAppend)
			Me.headerPanel.Controls.Add(Me.buttonOpen)
			Me.headerPanel.Controls.Add(Me.saveButton)
			Me.headerPanel.Controls.Add(Me.newButton)
			Me.headerPanel.Location = New System.Drawing.Point(0, 0)
			Me.headerPanel.Name = "headerPanel"
			Me.headerPanel.Size = New System.Drawing.Size(737, 53)
			Me.headerPanel.TabIndex = 0
			' 
			' labelSeparationLine
			' 
			Me.labelSeparationLine.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelSeparationLine.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.labelSeparationLine.LineVisible = True
			Me.labelSeparationLine.Location = New System.Drawing.Point(0, 50)
			Me.labelSeparationLine.Name = "labelSeparationLine"
			Me.labelSeparationLine.Size = New System.Drawing.Size(737, 3)
			Me.labelSeparationLine.TabIndex = 4
			' 
			' PdfPageMerging
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.headerPanel)
			Me.Controls.Add(Me.viewerPanel)
			Me.Name = "PdfPageMerging"
			Me.Size = New System.Drawing.Size(737, 564)
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.viewerPanel.ResumeLayout(False)
			CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.headerPanel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private viewerPanel As XtraEditors.PanelControl
		Private pdfViewer As XtraPdfViewer.PdfViewer
		Private WithEvents buttonAppend As XtraEditors.SimpleButton
		Private WithEvents buttonOpen As XtraEditors.SimpleButton
		Private WithEvents saveButton As XtraEditors.SimpleButton
		Private WithEvents newButton As XtraEditors.SimpleButton
		Private headerPanel As XtraEditors.PanelControl
		Private labelSeparationLine As XtraEditors.LabelControl

	End Class
End Namespace
