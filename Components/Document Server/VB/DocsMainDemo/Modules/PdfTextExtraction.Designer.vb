Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class PdfTextExtraction
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
			Dim splashScreenManager1 As New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, True, GetType(System.Windows.Forms.UserControl))
			Me.buttonOpen = New DevExpress.XtraEditors.SimpleButton()
			Me.buttonExtractText = New DevExpress.XtraEditors.SimpleButton()
			Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
			Me.viewerPanel = New DevExpress.XtraEditors.PanelControl()
			Me.headerPanel = New DevExpress.XtraEditors.PanelControl()
			Me.labelSeparationLine = New DevExpress.XtraEditors.LabelControl()
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.viewerPanel.SuspendLayout()
			CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.headerPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' buttonOpen
			' 
			Me.buttonOpen.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonOpen.Location = New System.Drawing.Point(543, 15)
			Me.buttonOpen.Name = "buttonOpen"
			Me.buttonOpen.Size = New System.Drawing.Size(110, 23)
			Me.buttonOpen.TabIndex = 0
			Me.buttonOpen.Text = "Open..."
'			Me.buttonOpen.Click += New System.EventHandler(Me.OnButtonOpenClick);
			' 
			' buttonExtractText
			' 
			Me.buttonExtractText.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonExtractText.Location = New System.Drawing.Point(659, 15)
			Me.buttonExtractText.Name = "buttonExtractText"
			Me.buttonExtractText.Size = New System.Drawing.Size(110, 23)
			Me.buttonExtractText.TabIndex = 1
			Me.buttonExtractText.Text = "Extract text..."
'			Me.buttonExtractText.Click += New System.EventHandler(Me.OnButtonExtractClick);
			' 
			' pdfViewer
			' 
			Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
			Me.pdfViewer.Name = "pdfViewer"
			Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
			Me.pdfViewer.Size = New System.Drawing.Size(784, 485)
			Me.pdfViewer.TabIndex = 2
			Me.pdfViewer.TabStop = False
			Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
'			Me.pdfViewer.DocumentChanged += New DevExpress.XtraPdfViewer.PdfDocumentChangedEventHandler(Me.OnDocumentChanged);
			' 
			' viewerPanel
			' 
			Me.viewerPanel.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.viewerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.viewerPanel.Controls.Add(Me.pdfViewer)
			Me.viewerPanel.Location = New System.Drawing.Point(0, 53)
			Me.viewerPanel.Name = "viewerPanel"
			Me.viewerPanel.Size = New System.Drawing.Size(784, 485)
			Me.viewerPanel.TabIndex = 2
			' 
			' headerPanel
			' 
			Me.headerPanel.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.headerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.headerPanel.Controls.Add(Me.labelSeparationLine)
			Me.headerPanel.Controls.Add(Me.buttonOpen)
			Me.headerPanel.Controls.Add(Me.buttonExtractText)
			Me.headerPanel.Location = New System.Drawing.Point(0, 0)
			Me.headerPanel.Name = "headerPanel"
			Me.headerPanel.Size = New System.Drawing.Size(784, 53)
			Me.headerPanel.TabIndex = 0
			' 
			' labelSeparationLine
			' 
			Me.labelSeparationLine.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelSeparationLine.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.labelSeparationLine.LineVisible = True
			Me.labelSeparationLine.Location = New System.Drawing.Point(0, 50)
			Me.labelSeparationLine.Name = "labelSeparationLine"
			Me.labelSeparationLine.Size = New System.Drawing.Size(784, 3)
			Me.labelSeparationLine.TabIndex = 3
			' 
			' PdfTextExtraction
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.headerPanel)
			Me.Controls.Add(Me.viewerPanel)
			Me.Name = "PdfTextExtraction"
			Me.Size = New System.Drawing.Size(784, 538)
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.viewerPanel.ResumeLayout(False)
			CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.headerPanel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents buttonOpen As XtraEditors.SimpleButton
		Private WithEvents buttonExtractText As XtraEditors.SimpleButton
		Private WithEvents pdfViewer As XtraPdfViewer.PdfViewer
		Private viewerPanel As XtraEditors.PanelControl
		Private headerPanel As XtraEditors.PanelControl
		Private labelSeparationLine As XtraEditors.LabelControl
	End Class
End Namespace
