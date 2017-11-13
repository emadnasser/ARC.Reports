Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class HeaderFooterModule
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
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.panel = New DevExpress.XtraEditors.PanelControl()
			Me.btnPageSetup = New DevExpress.XtraEditors.SimpleButton()
			Me.spreadsheetPreview1 = New DevExpress.XtraSpreadsheet.Demos.SpreadsheetPreview()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Location = New System.Drawing.Point(24, 74)
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
			Me.spreadsheetControl1.Size = New System.Drawing.Size(509, 303)
			Me.spreadsheetControl1.TabIndex = 0
			Me.spreadsheetControl1.Visible = False
			' 
			' panel
			' 
			Me.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel.Controls.Add(Me.btnPageSetup)
			Me.panel.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel.Location = New System.Drawing.Point(0, 0)
			Me.panel.Name = "panel"
			Me.panel.Size = New System.Drawing.Size(725, 26)
			Me.panel.TabIndex = 6
			' 
			' btnPageSetup
			' 
			Me.btnPageSetup.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
			Me.btnPageSetup.Location = New System.Drawing.Point(0, 0)
			Me.btnPageSetup.Name = "btnPageSetup"
			Me.btnPageSetup.Size = New System.Drawing.Size(124, 23)
			Me.btnPageSetup.TabIndex = 0
			Me.btnPageSetup.Text = "Headers/Footers"
'			Me.btnPageSetup.Click += New System.EventHandler(Me.btnPageSetup_Click);
			' 
			' spreadsheetPreview1
			' 
			Me.spreadsheetPreview1.CanShowBorders = True
			Me.spreadsheetPreview1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetPreview1.Location = New System.Drawing.Point(0, 26)
			Me.spreadsheetPreview1.Name = "spreadsheetPreview1"
			Me.spreadsheetPreview1.Size = New System.Drawing.Size(725, 430)
			Me.spreadsheetPreview1.TabIndex = 7
			Me.spreadsheetPreview1.Workbook = Nothing
			' 
			' HeaderFooterModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.spreadsheetPreview1)
			Me.Controls.Add(Me.spreadsheetControl1)
			Me.Controls.Add(Me.panel)
			Me.Name = "HeaderFooterModule"
			Me.Size = New System.Drawing.Size(725, 456)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private spreadsheetControl1 As SpreadsheetControl
		Private panel As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnPageSetup As SimpleButton
		Private spreadsheetPreview1 As SpreadsheetPreview
	End Class
End Namespace
