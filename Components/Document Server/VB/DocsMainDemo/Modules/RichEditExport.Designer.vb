Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class RichEditExport
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
			Me.printPreviewControl = New DevExpress.XtraPrinting.Control.PrintControl()
			Me.edtFilePath = New DevExpress.XtraEditors.ButtonEdit()
			Me.btnRtf = New DevExpress.XtraEditors.SimpleButton()
			Me.btnEpub = New DevExpress.XtraEditors.SimpleButton()
			Me.btnXml = New DevExpress.XtraEditors.SimpleButton()
			Me.btnOdt = New DevExpress.XtraEditors.SimpleButton()
			Me.btnDocx = New DevExpress.XtraEditors.SimpleButton()
			Me.btnMht = New DevExpress.XtraEditors.SimpleButton()
			Me.btnHtml = New DevExpress.XtraEditors.SimpleButton()
			Me.btnTxt = New DevExpress.XtraEditors.SimpleButton()
			Me.btnDoc = New DevExpress.XtraEditors.SimpleButton()
			Me.btnPdf = New DevExpress.XtraEditors.SimpleButton()
			Me.edtSaveTo = New DevExpress.XtraEditors.ButtonEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.edtFilePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtSaveTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' printPreviewControl
			' 
			Me.printPreviewControl.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.printPreviewControl.IsMetric = False
			Me.printPreviewControl.Location = New System.Drawing.Point(3, 82)
			Me.printPreviewControl.Name = "printPreviewControl"
			Me.printPreviewControl.Size = New System.Drawing.Size(778, 397)
			Me.printPreviewControl.TabIndex = 34
			Me.printPreviewControl.TooltipFont = New System.Drawing.Font("Tahoma", 8.25F)
			' 
			' edtFilePath
			' 
			Me.edtFilePath.Location = New System.Drawing.Point(63, 3)
			Me.edtFilePath.Name = "edtFilePath"
			Me.edtFilePath.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.edtFilePath.Size = New System.Drawing.Size(240, 20)
			Me.edtFilePath.TabIndex = 35
'			Me.edtFilePath.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.edtFilePath_ButtonClick);
'			Me.edtFilePath.KeyUp += New System.Windows.Forms.KeyEventHandler(Me.edtFilePath_KeyUp);
			' 
			' btnRtf
			' 
			Me.btnRtf.Location = New System.Drawing.Point(63, 28)
			Me.btnRtf.Name = "btnRtf"
			Me.btnRtf.Size = New System.Drawing.Size(50, 23)
			Me.btnRtf.TabIndex = 36
			Me.btnRtf.Text = "RTF"
'			Me.btnRtf.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' btnEpub
			' 
			Me.btnEpub.Location = New System.Drawing.Point(566, 28)
			Me.btnEpub.Name = "btnEpub"
			Me.btnEpub.Size = New System.Drawing.Size(50, 23)
			Me.btnEpub.TabIndex = 37
			Me.btnEpub.Text = "EPUB"
'			Me.btnEpub.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' btnXml
			' 
			Me.btnXml.Location = New System.Drawing.Point(510, 28)
			Me.btnXml.Name = "btnXml"
			Me.btnXml.Size = New System.Drawing.Size(50, 23)
			Me.btnXml.TabIndex = 38
			Me.btnXml.Text = "XML"
'			Me.btnXml.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' btnOdt
			' 
			Me.btnOdt.Location = New System.Drawing.Point(454, 28)
			Me.btnOdt.Name = "btnOdt"
			Me.btnOdt.Size = New System.Drawing.Size(50, 23)
			Me.btnOdt.TabIndex = 39
			Me.btnOdt.Text = "ODT"
'			Me.btnOdt.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' btnDocx
			' 
			Me.btnDocx.Location = New System.Drawing.Point(175, 28)
			Me.btnDocx.Name = "btnDocx"
			Me.btnDocx.Size = New System.Drawing.Size(50, 23)
			Me.btnDocx.TabIndex = 40
			Me.btnDocx.Text = "DOCX"
'			Me.btnDocx.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' btnMht
			' 
			Me.btnMht.Location = New System.Drawing.Point(398, 28)
			Me.btnMht.Name = "btnMht"
			Me.btnMht.Size = New System.Drawing.Size(50, 23)
			Me.btnMht.TabIndex = 41
			Me.btnMht.Text = "MHT"
'			Me.btnMht.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' btnHtml
			' 
			Me.btnHtml.Location = New System.Drawing.Point(342, 28)
			Me.btnHtml.Name = "btnHtml"
			Me.btnHtml.Size = New System.Drawing.Size(50, 23)
			Me.btnHtml.TabIndex = 42
			Me.btnHtml.Text = "HTML"
'			Me.btnHtml.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' btnTxt
			' 
			Me.btnTxt.Location = New System.Drawing.Point(287, 28)
			Me.btnTxt.Name = "btnTxt"
			Me.btnTxt.Size = New System.Drawing.Size(50, 23)
			Me.btnTxt.TabIndex = 43
			Me.btnTxt.Text = "TXT"
'			Me.btnTxt.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' btnDoc
			' 
			Me.btnDoc.Location = New System.Drawing.Point(119, 28)
			Me.btnDoc.Name = "btnDoc"
			Me.btnDoc.Size = New System.Drawing.Size(50, 23)
			Me.btnDoc.TabIndex = 37
			Me.btnDoc.Text = "DOC"
'			Me.btnDoc.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' btnPdf
			' 
			Me.btnPdf.Location = New System.Drawing.Point(231, 28)
			Me.btnPdf.Name = "btnPdf"
			Me.btnPdf.Size = New System.Drawing.Size(50, 23)
			Me.btnPdf.TabIndex = 37
			Me.btnPdf.Text = "PDF"
'			Me.btnPdf.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' edtSaveTo
			' 
			Me.edtSaveTo.Location = New System.Drawing.Point(377, 3)
			Me.edtSaveTo.Name = "edtSaveTo"
			Me.edtSaveTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.edtSaveTo.Size = New System.Drawing.Size(239, 20)
			Me.edtSaveTo.TabIndex = 35
'			Me.edtSaveTo.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.edtSaveTo_ButtonClick);
'			Me.edtSaveTo.KeyUp += New System.Windows.Forms.KeyEventHandler(Me.edtFilePath_KeyUp);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(6, 6)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(20, 13)
			Me.labelControl1.TabIndex = 46
			Me.labelControl1.Text = "File:"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(6, 33)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(49, 13)
			Me.labelControl2.TabIndex = 46
			Me.labelControl2.Text = "Export to:"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(330, 6)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(41, 13)
			Me.labelControl3.TabIndex = 46
			Me.labelControl3.Text = "Save to:"
			' 
			' RichEditExport
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.btnTxt)
			Me.Controls.Add(Me.btnHtml)
			Me.Controls.Add(Me.btnMht)
			Me.Controls.Add(Me.btnDocx)
			Me.Controls.Add(Me.btnOdt)
			Me.Controls.Add(Me.btnXml)
			Me.Controls.Add(Me.btnPdf)
			Me.Controls.Add(Me.btnDoc)
			Me.Controls.Add(Me.btnEpub)
			Me.Controls.Add(Me.btnRtf)
			Me.Controls.Add(Me.edtSaveTo)
			Me.Controls.Add(Me.edtFilePath)
			Me.Controls.Add(Me.printPreviewControl)
			Me.Name = "RichEditExport"
			CType(Me.edtFilePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtSaveTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private printPreviewControl As XtraPrinting.Control.PrintControl
		Private WithEvents edtFilePath As XtraEditors.ButtonEdit
		Private WithEvents btnRtf As XtraEditors.SimpleButton
		Private WithEvents btnEpub As XtraEditors.SimpleButton
		Private WithEvents btnXml As XtraEditors.SimpleButton
		Private WithEvents btnOdt As XtraEditors.SimpleButton
		Private WithEvents btnDocx As XtraEditors.SimpleButton
		Private WithEvents btnMht As XtraEditors.SimpleButton
		Private WithEvents btnHtml As XtraEditors.SimpleButton
		Private WithEvents btnTxt As XtraEditors.SimpleButton
		Private WithEvents btnDoc As XtraEditors.SimpleButton
		Private WithEvents btnPdf As XtraEditors.SimpleButton
		Private WithEvents edtSaveTo As XtraEditors.ButtonEdit
		Private labelControl1 As XtraEditors.LabelControl
		Private labelControl2 As XtraEditors.LabelControl
		Private labelControl3 As XtraEditors.LabelControl
	End Class
End Namespace
