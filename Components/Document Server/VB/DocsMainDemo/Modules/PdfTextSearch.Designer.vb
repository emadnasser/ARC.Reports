Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class PdfTextSearch
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
			Me.labelTextToFind = New DevExpress.XtraEditors.LabelControl()
			Me.textEditTextToFind = New DevExpress.XtraEditors.TextEdit()
			Me.labelWordCount = New DevExpress.XtraEditors.LabelControl()
			Me.spinEditWordCount = New DevExpress.XtraEditors.SpinEdit()
			Me.viewerPanel = New DevExpress.XtraEditors.PanelControl()
			Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
			Me.buttonSearch = New DevExpress.XtraEditors.SimpleButton()
			Me.buttonOpen = New DevExpress.XtraEditors.SimpleButton()
			Me.headerPanel = New DevExpress.XtraEditors.PanelControl()
			Me.labelSeparationLine = New DevExpress.XtraEditors.LabelControl()
			Me.docOperationsPanel = New System.Windows.Forms.Panel()
			CType(Me.textEditTextToFind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditWordCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.viewerPanel.SuspendLayout()
			CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.headerPanel.SuspendLayout()
			Me.docOperationsPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' labelTextToFind
			' 
			Me.labelTextToFind.Location = New System.Drawing.Point(13, 18)
			Me.labelTextToFind.Name = "labelTextToFind"
			Me.labelTextToFind.Size = New System.Drawing.Size(60, 13)
			Me.labelTextToFind.TabIndex = 0
			Me.labelTextToFind.Text = "Text to find:"
			' 
			' textEditTextToFind
			' 
			Me.textEditTextToFind.EditValue = "Customer:"
			Me.textEditTextToFind.Location = New System.Drawing.Point(83, 17)
			Me.textEditTextToFind.Name = "textEditTextToFind"
			Me.textEditTextToFind.Size = New System.Drawing.Size(93, 20)
			Me.textEditTextToFind.TabIndex = 1
			' 
			' labelWordCount
			' 
			Me.labelWordCount.Location = New System.Drawing.Point(193, 18)
			Me.labelWordCount.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
			Me.labelWordCount.Name = "labelWordCount"
			Me.labelWordCount.Size = New System.Drawing.Size(60, 13)
			Me.labelWordCount.TabIndex = 2
			Me.labelWordCount.Text = "Word count:"
			' 
			' spinEditWordCount
			' 
			Me.spinEditWordCount.EditValue = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.spinEditWordCount.Location = New System.Drawing.Point(263, 17)
			Me.spinEditWordCount.Name = "spinEditWordCount"
			Me.spinEditWordCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.spinEditWordCount.Properties.IsFloatValue = False
			Me.spinEditWordCount.Properties.Mask.EditMask = "N00"
			Me.spinEditWordCount.Properties.MaxValue = New Decimal(New Integer() { 1000, 0, 0, 0})
			Me.spinEditWordCount.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinEditWordCount.Size = New System.Drawing.Size(65, 20)
			Me.spinEditWordCount.TabIndex = 3
			' 
			' viewerPanel
			' 
			Me.viewerPanel.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.viewerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.viewerPanel.Controls.Add(Me.pdfViewer)
			Me.viewerPanel.Location = New System.Drawing.Point(0, 53)
			Me.viewerPanel.Name = "viewerPanel"
			Me.viewerPanel.Size = New System.Drawing.Size(737, 511)
			Me.viewerPanel.TabIndex = 7
			' 
			' pdfViewer
			' 
			Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
			Me.pdfViewer.Name = "pdfViewer"
			Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
			Me.pdfViewer.Size = New System.Drawing.Size(737, 511)
			Me.pdfViewer.TabIndex = 7
			Me.pdfViewer.TabStop = False
			Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
'			Me.pdfViewer.DocumentChanged += New DevExpress.XtraPdfViewer.PdfDocumentChangedEventHandler(Me.OnDocumentChanged);
			' 
			' buttonSearch
			' 
			Me.buttonSearch.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonSearch.Location = New System.Drawing.Point(116, 0)
			Me.buttonSearch.Name = "buttonSearch"
			Me.buttonSearch.Size = New System.Drawing.Size(110, 23)
			Me.buttonSearch.TabIndex = 5
			Me.buttonSearch.Text = "Search..."
'			Me.buttonSearch.Click += New System.EventHandler(Me.OnButtonSearchClick);
			' 
			' buttonOpen
			' 
			Me.buttonOpen.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonOpen.Location = New System.Drawing.Point(0, 0)
			Me.buttonOpen.Name = "buttonOpen"
			Me.buttonOpen.Size = New System.Drawing.Size(110, 23)
			Me.buttonOpen.TabIndex = 4
			Me.buttonOpen.Text = "Open..."
'			Me.buttonOpen.Click += New System.EventHandler(Me.OnButtonOpenClick);
			' 
			' headerPanel
			' 
			Me.headerPanel.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.headerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.headerPanel.Controls.Add(Me.labelSeparationLine)
			Me.headerPanel.Controls.Add(Me.docOperationsPanel)
			Me.headerPanel.Controls.Add(Me.labelTextToFind)
			Me.headerPanel.Controls.Add(Me.textEditTextToFind)
			Me.headerPanel.Controls.Add(Me.labelWordCount)
			Me.headerPanel.Controls.Add(Me.spinEditWordCount)
			Me.headerPanel.Location = New System.Drawing.Point(0, 0)
			Me.headerPanel.Name = "headerPanel"
			Me.headerPanel.Size = New System.Drawing.Size(737, 53)
			Me.headerPanel.TabIndex = 6
			' 
			' labelSeparationLine
			' 
			Me.labelSeparationLine.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelSeparationLine.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.labelSeparationLine.LineVisible = True
			Me.labelSeparationLine.Location = New System.Drawing.Point(0, 50)
			Me.labelSeparationLine.Name = "labelSeparationLine"
			Me.labelSeparationLine.Size = New System.Drawing.Size(737, 3)
			Me.labelSeparationLine.TabIndex = 6
			' 
			' docOperationsPanel
			' 
			Me.docOperationsPanel.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.docOperationsPanel.Controls.Add(Me.buttonSearch)
			Me.docOperationsPanel.Controls.Add(Me.buttonOpen)
			Me.docOperationsPanel.Location = New System.Drawing.Point(496, 15)
			Me.docOperationsPanel.Name = "docOperationsPanel"
			Me.docOperationsPanel.Size = New System.Drawing.Size(226, 23)
			Me.docOperationsPanel.TabIndex = 4
			' 
			' PdfTextSearch
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.headerPanel)
			Me.Controls.Add(Me.viewerPanel)
			Me.Name = "PdfTextSearch"
			Me.Size = New System.Drawing.Size(737, 564)
			CType(Me.textEditTextToFind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditWordCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.viewerPanel.ResumeLayout(False)
			CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.headerPanel.ResumeLayout(False)
			Me.headerPanel.PerformLayout()
			Me.docOperationsPanel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private labelTextToFind As XtraEditors.LabelControl
		Private textEditTextToFind As XtraEditors.TextEdit
		Private labelWordCount As XtraEditors.LabelControl
		Private spinEditWordCount As XtraEditors.SpinEdit
		Private viewerPanel As XtraEditors.PanelControl
		Private WithEvents pdfViewer As XtraPdfViewer.PdfViewer
		Private WithEvents buttonSearch As XtraEditors.SimpleButton
		Private WithEvents buttonOpen As XtraEditors.SimpleButton
		Private headerPanel As XtraEditors.PanelControl
		Private docOperationsPanel As System.Windows.Forms.Panel
		Private labelSeparationLine As XtraEditors.LabelControl

	End Class
End Namespace
