Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class PdfPageDeletion
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
			Me.buttonDeletePage = New DevExpress.XtraEditors.SimpleButton()
			Me.spinEditPageNumber = New DevExpress.XtraEditors.SpinEdit()
			Me.labelPageNumber = New DevExpress.XtraEditors.LabelControl()
			Me.buttonOpen = New DevExpress.XtraEditors.SimpleButton()
			Me.buttonSave = New DevExpress.XtraEditors.SimpleButton()
			Me.deletePagePanel = New DevExpress.XtraEditors.PanelControl()
			Me.docOperationsPanel = New DevExpress.XtraEditors.PanelControl()
			Me.headerPanel = New DevExpress.XtraEditors.PanelControl()
			Me.labelSeparationLine = New DevExpress.XtraEditors.LabelControl()
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.viewerPanel.SuspendLayout()
			CType(Me.spinEditPageNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.deletePagePanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.deletePagePanel.SuspendLayout()
			CType(Me.docOperationsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.docOperationsPanel.SuspendLayout()
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
			Me.viewerPanel.TabIndex = 6
			' 
			' pdfViewer
			' 
			Me.pdfViewer.DetachStreamAfterLoadComplete = True
			Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
			Me.pdfViewer.Name = "pdfViewer"
			Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
			Me.pdfViewer.Size = New System.Drawing.Size(737, 511)
			Me.pdfViewer.TabIndex = 6
			Me.pdfViewer.TabStop = False
			Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
'			Me.pdfViewer.CurrentPageChanged += New DevExpress.XtraPdfViewer.PdfCurrentPageChangedEventHandler(Me.PdfViewerCurrentPageChanged);
			' 
			' buttonDeletePage
			' 
			Me.buttonDeletePage.Location = New System.Drawing.Point(0, 0)
			Me.buttonDeletePage.Name = "buttonDeletePage"
			Me.buttonDeletePage.Size = New System.Drawing.Size(110, 23)
			Me.buttonDeletePage.TabIndex = 2
			Me.buttonDeletePage.Text = "Delete Page"
'			Me.buttonDeletePage.Click += New System.EventHandler(Me.OnButtonDeletePageClick);
			' 
			' spinEditPageNumber
			' 
			Me.spinEditPageNumber.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinEditPageNumber.Location = New System.Drawing.Point(89, 17)
			Me.spinEditPageNumber.Name = "spinEditPageNumber"
			Me.spinEditPageNumber.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.spinEditPageNumber.Properties.IsFloatValue = False
			Me.spinEditPageNumber.Properties.Mask.EditMask = "N00"
			Me.spinEditPageNumber.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinEditPageNumber.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinEditPageNumber.Size = New System.Drawing.Size(65, 20)
			Me.spinEditPageNumber.TabIndex = 1
			' 
			' labelPageNumber
			' 
			Me.labelPageNumber.Location = New System.Drawing.Point(15, 20)
			Me.labelPageNumber.Margin = New System.Windows.Forms.Padding(32, 3, 3, 3)
			Me.labelPageNumber.Name = "labelPageNumber"
			Me.labelPageNumber.Size = New System.Drawing.Size(67, 13)
			Me.labelPageNumber.TabIndex = 0
			Me.labelPageNumber.Text = "Page number:"
			' 
			' buttonOpen
			' 
			Me.buttonOpen.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonOpen.Location = New System.Drawing.Point(0, 0)
			Me.buttonOpen.Name = "buttonOpen"
			Me.buttonOpen.Size = New System.Drawing.Size(110, 23)
			Me.buttonOpen.TabIndex = 3
			Me.buttonOpen.Text = "Open..."
'			Me.buttonOpen.Click += New System.EventHandler(Me.OnButtonOpenClick);
			' 
			' buttonSave
			' 
			Me.buttonSave.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonSave.Location = New System.Drawing.Point(116, 0)
			Me.buttonSave.Name = "buttonSave"
			Me.buttonSave.Size = New System.Drawing.Size(110, 23)
			Me.buttonSave.TabIndex = 4
			Me.buttonSave.Text = "Save..."
'			Me.buttonSave.Click += New System.EventHandler(Me.OnButtonSaveClick);
			' 
			' deletePagePanel
			' 
			Me.deletePagePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.deletePagePanel.Controls.Add(Me.buttonDeletePage)
			Me.deletePagePanel.Location = New System.Drawing.Point(160, 15)
			Me.deletePagePanel.Name = "deletePagePanel"
			Me.deletePagePanel.Size = New System.Drawing.Size(110, 23)
			Me.deletePagePanel.TabIndex = 2
			' 
			' docOperationsPanel
			' 
			Me.docOperationsPanel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.docOperationsPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.docOperationsPanel.Controls.Add(Me.buttonOpen)
			Me.docOperationsPanel.Controls.Add(Me.buttonSave)
			Me.docOperationsPanel.Location = New System.Drawing.Point(496, 15)
			Me.docOperationsPanel.Name = "docOperationsPanel"
			Me.docOperationsPanel.Size = New System.Drawing.Size(226, 23)
			Me.docOperationsPanel.TabIndex = 3
			' 
			' headerPanel
			' 
			Me.headerPanel.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.headerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.headerPanel.Controls.Add(Me.labelSeparationLine)
			Me.headerPanel.Controls.Add(Me.spinEditPageNumber)
			Me.headerPanel.Controls.Add(Me.labelPageNumber)
			Me.headerPanel.Controls.Add(Me.deletePagePanel)
			Me.headerPanel.Controls.Add(Me.docOperationsPanel)
			Me.headerPanel.Location = New System.Drawing.Point(0, 0)
			Me.headerPanel.Name = "headerPanel"
			Me.headerPanel.Size = New System.Drawing.Size(737, 53)
			Me.headerPanel.TabIndex = 11
			' 
			' labelSeparationLine
			' 
			Me.labelSeparationLine.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelSeparationLine.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.labelSeparationLine.LineVisible = True
			Me.labelSeparationLine.Location = New System.Drawing.Point(0, 50)
			Me.labelSeparationLine.Name = "labelSeparationLine"
			Me.labelSeparationLine.Size = New System.Drawing.Size(737, 3)
			Me.labelSeparationLine.TabIndex = 5
			' 
			' PdfPageDeletion
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.headerPanel)
			Me.Controls.Add(Me.viewerPanel)
			Me.Name = "PdfPageDeletion"
			Me.Size = New System.Drawing.Size(737, 564)
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.viewerPanel.ResumeLayout(False)
			CType(Me.spinEditPageNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.deletePagePanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.deletePagePanel.ResumeLayout(False)
			CType(Me.docOperationsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.docOperationsPanel.ResumeLayout(False)
			CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.headerPanel.ResumeLayout(False)
			Me.headerPanel.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private viewerPanel As XtraEditors.PanelControl
		Private WithEvents pdfViewer As XtraPdfViewer.PdfViewer
		Private WithEvents buttonDeletePage As XtraEditors.SimpleButton
		Private spinEditPageNumber As XtraEditors.SpinEdit
		Private labelPageNumber As XtraEditors.LabelControl
		Private WithEvents buttonOpen As XtraEditors.SimpleButton
		Private WithEvents buttonSave As XtraEditors.SimpleButton
		Private deletePagePanel As XtraEditors.PanelControl
		Private docOperationsPanel As XtraEditors.PanelControl
		Private headerPanel As XtraEditors.PanelControl
		Private labelSeparationLine As XtraEditors.LabelControl

	End Class
End Namespace
