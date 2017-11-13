Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class PrintTitlesModule
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(PrintTitlesModule))
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.panel = New DevExpress.XtraEditors.PanelControl()
			Me.btnManyPages = New DevExpress.XtraEditors.SimpleButton()
			Me.btnWholePage = New DevExpress.XtraEditors.SimpleButton()
			Me.btnPageSetup = New DevExpress.XtraEditors.SimpleButton()
			Me.spreadsheetPreview1 = New DevExpress.XtraSpreadsheet.Demos.SpreadsheetPreview()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage2.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
			Me.spreadsheetControl1.ReadOnly = True
			Me.spreadsheetControl1.Size = New System.Drawing.Size(719, 428)
			Me.spreadsheetControl1.TabIndex = 0
'			Me.spreadsheetControl1.ContentChanged += New System.EventHandler(Me.spreadsheetControl1_ContentChanged);
			' 
			' panel
			' 
			Me.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel.Controls.Add(Me.btnManyPages)
			Me.panel.Controls.Add(Me.btnWholePage)
			Me.panel.Controls.Add(Me.btnPageSetup)
			Me.panel.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel.Location = New System.Drawing.Point(0, 0)
			Me.panel.Name = "panel"
			Me.panel.Size = New System.Drawing.Size(719, 29)
			Me.panel.TabIndex = 6
			' 
			' btnManyPages
			' 
			Me.btnManyPages.Image = (CType(resources.GetObject("btnManyPages.Image"), System.Drawing.Image))
			Me.btnManyPages.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
			Me.btnManyPages.Location = New System.Drawing.Point(162, 3)
			Me.btnManyPages.Name = "btnManyPages"
			Me.btnManyPages.Size = New System.Drawing.Size(23, 23)
			Me.btnManyPages.TabIndex = 2
			Me.btnManyPages.ToolTip = "View Many Pages"
'			Me.btnManyPages.Click += New System.EventHandler(Me.btnManyPages_Click);
			' 
			' btnWholePage
			' 
			Me.btnWholePage.Image = (CType(resources.GetObject("btnWholePage.Image"), System.Drawing.Image))
			Me.btnWholePage.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
			Me.btnWholePage.Location = New System.Drawing.Point(133, 3)
			Me.btnWholePage.Name = "btnWholePage"
			Me.btnWholePage.Size = New System.Drawing.Size(23, 23)
			Me.btnWholePage.TabIndex = 1
			Me.btnWholePage.ToolTip = "View Whole Page"
'			Me.btnWholePage.Click += New System.EventHandler(Me.btnWholePage_Click);
			' 
			' btnPageSetup
			' 
			Me.btnPageSetup.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
			Me.btnPageSetup.Location = New System.Drawing.Point(3, 3)
			Me.btnPageSetup.Name = "btnPageSetup"
			Me.btnPageSetup.Size = New System.Drawing.Size(124, 23)
			Me.btnPageSetup.TabIndex = 0
			Me.btnPageSetup.Text = "Page Setup"
'			Me.btnPageSetup.Click += New System.EventHandler(Me.btnPageSetup_Click);
			' 
			' spreadsheetPreview1
			' 
			Me.spreadsheetPreview1.CanShowBorders = True
			Me.spreadsheetPreview1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetPreview1.Location = New System.Drawing.Point(0, 29)
			Me.spreadsheetPreview1.Name = "spreadsheetPreview1"
			Me.spreadsheetPreview1.PreviewZoom = DevExpress.XtraSpreadsheet.Demos.SpreadhsheetPreviewZoom.Default
			Me.spreadsheetPreview1.Size = New System.Drawing.Size(719, 399)
			Me.spreadsheetPreview1.TabIndex = 7
			Me.spreadsheetPreview1.Workbook = Nothing
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage2
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True
			Me.xtraTabControl1.Size = New System.Drawing.Size(725, 456)
			Me.xtraTabControl1.TabIndex = 8
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.spreadsheetPreview1)
			Me.xtraTabPage2.Controls.Add(Me.panel)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(719, 428)
			Me.xtraTabPage2.Text = "Preview"
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.spreadsheetControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(719, 428)
			Me.xtraTabPage1.Text = "Content"
			' 
			' PrintTitlesModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "PrintTitlesModule"
			Me.Size = New System.Drawing.Size(725, 456)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage2.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents spreadsheetControl1 As SpreadsheetControl
		Private panel As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnPageSetup As SimpleButton
		Private spreadsheetPreview1 As SpreadsheetPreview
		Private WithEvents btnWholePage As SimpleButton
		Private WithEvents btnManyPages As SimpleButton
		Private xtraTabControl1 As XtraTab.XtraTabControl
		Private xtraTabPage2 As XtraTab.XtraTabPage
		Private xtraTabPage1 As XtraTab.XtraTabPage
	End Class
End Namespace
