Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class EncryptionModule
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(EncryptionModule))
			Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
			Me.basePanel = New DevExpress.XtraEditors.PanelControl()
			Me.chbOpenResultingFile = New DevExpress.XtraEditors.CheckEdit()
			Me.passwordLabel = New DevExpress.XtraEditors.LabelControl()
			Me.btnExportToXLS = New DevExpress.XtraEditors.SimpleButton()
			Me.btnExportToXLSX = New DevExpress.XtraEditors.SimpleButton()
			Me.passwordEdit = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.typeEdit = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.typeLabel = New DevExpress.XtraEditors.LabelControl()
			Me.separatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
			CType(Me.basePanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.basePanel.SuspendLayout()
			CType(Me.chbOpenResultingFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.passwordEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.typeEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.separatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.MinimumSize = New System.Drawing.Size(200, 150)
			Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
			Me.spreadsheetControl1.Size = New System.Drawing.Size(630, 411)
			Me.spreadsheetControl1.TabIndex = 0
			' 
			' splitterControl1
			' 
			Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.splitterControl1.Location = New System.Drawing.Point(853, 25)
			Me.splitterControl1.MinExtra = 250
			Me.splitterControl1.MinSize = 150
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(5, 527)
			Me.splitterControl1.TabIndex = 7
			Me.splitterControl1.TabStop = False
			' 
			' basePanel
			' 
			Me.basePanel.Controls.Add(Me.chbOpenResultingFile)
			Me.basePanel.Controls.Add(Me.passwordLabel)
			Me.basePanel.Controls.Add(Me.btnExportToXLS)
			Me.basePanel.Controls.Add(Me.btnExportToXLSX)
			Me.basePanel.Controls.Add(Me.passwordEdit)
			Me.basePanel.Controls.Add(Me.typeEdit)
			Me.basePanel.Controls.Add(Me.typeLabel)
			Me.basePanel.Dock = System.Windows.Forms.DockStyle.Right
			Me.basePanel.Location = New System.Drawing.Point(640, 141)
			Me.basePanel.Name = "basePanel"
			Me.basePanel.Size = New System.Drawing.Size(218, 411)
			Me.basePanel.TabIndex = 4
			' 
			' chbOpenResultingFile
			' 
			Me.chbOpenResultingFile.EditValue = True
			Me.chbOpenResultingFile.Location = New System.Drawing.Point(15, 175)
			Me.chbOpenResultingFile.Name = "chbOpenResultingFile"
			Me.chbOpenResultingFile.Properties.Caption = "Open resulting file"
			Me.chbOpenResultingFile.Size = New System.Drawing.Size(144, 19)
			Me.chbOpenResultingFile.TabIndex = 3
			' 
			' passwordLabel
			' 
			Me.passwordLabel.Location = New System.Drawing.Point(15, 21)
			Me.passwordLabel.Name = "passwordLabel"
			Me.passwordLabel.Size = New System.Drawing.Size(50, 13)
			Me.passwordLabel.TabIndex = 6
			Me.passwordLabel.Text = "&Password:"
			' 
			' btnExportToXLS
			' 
			Me.btnExportToXLS.Image = (CType(resources.GetObject("btnExportToXLS.Image"), System.Drawing.Image))
			Me.btnExportToXLS.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
			Me.btnExportToXLS.Location = New System.Drawing.Point(115, 97)
			Me.btnExportToXLS.Name = "btnExportToXLS"
			Me.btnExportToXLS.Size = New System.Drawing.Size(90, 59)
			Me.btnExportToXLS.TabIndex = 1
			Me.btnExportToXLS.Text = "Save as XLS"
'			Me.btnExportToXLS.Click += New System.EventHandler(Me.BtnExportToXLS_Click);
			' 
			' btnExportToXLSX
			' 
			Me.btnExportToXLSX.Image = (CType(resources.GetObject("btnExportToXLSX.Image"), System.Drawing.Image))
			Me.btnExportToXLSX.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
			Me.btnExportToXLSX.Location = New System.Drawing.Point(15, 97)
			Me.btnExportToXLSX.Name = "btnExportToXLSX"
			Me.btnExportToXLSX.Size = New System.Drawing.Size(90, 59)
			Me.btnExportToXLSX.TabIndex = 0
			Me.btnExportToXLSX.Text = "Save as XLSX"
'			Me.btnExportToXLSX.Click += New System.EventHandler(Me.BtnExportToXLSX_Click);
			' 
			' passwordEdit
			' 
			Me.passwordEdit.Location = New System.Drawing.Point(84, 18)
			Me.passwordEdit.Name = "passwordEdit"
			Me.passwordEdit.Properties.MaxLength = 255
			Me.passwordEdit.Size = New System.Drawing.Size(118, 20)
			Me.passwordEdit.TabIndex = 8
'			Me.passwordEdit.TextChanged += New System.EventHandler(PasswordEdit_TextChanged);
			' 
			' typeEdit
			' 
			Me.typeEdit.Location = New System.Drawing.Point(84, 53)
			Me.typeEdit.Name = "typeEdit"
			Me.typeEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.typeEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.typeEdit.Size = New System.Drawing.Size(118, 20)
			Me.typeEdit.TabIndex = 9
'			Me.typeEdit.TextChanged += New System.EventHandler(TypeEdit_TextChanged);
			' 
			' typeLabel
			' 
			Me.typeLabel.Location = New System.Drawing.Point(15, 56)
			Me.typeLabel.Name = "typeLabel"
			Me.typeLabel.Size = New System.Drawing.Size(28, 13)
			Me.typeLabel.TabIndex = 7
			Me.typeLabel.Text = "Type:"
			' 
			' separatorControl1
			' 
			Me.separatorControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.separatorControl1.Location = New System.Drawing.Point(630, 141)
			Me.separatorControl1.Name = "separatorControl1"
			Me.separatorControl1.Size = New System.Drawing.Size(10, 411)
			Me.separatorControl1.TabIndex = 6
			' 
			' EncryptionModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.separatorControl1)
			Me.Controls.Add(Me.basePanel)
			Me.Name = "EncryptionModule"
			Me.Size = New System.Drawing.Size(858, 552)
			Me.Controls.SetChildIndex(Me.basePanel, 0)
			Me.Controls.SetChildIndex(Me.separatorControl1, 0)
			Me.Controls.SetChildIndex(Me.spreadsheetControl1, 0)
			CType(Me.basePanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.basePanel.ResumeLayout(False)
			Me.basePanel.PerformLayout()
			CType(Me.chbOpenResultingFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.passwordEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.typeEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.separatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
		Private basePanel As DevExpress.XtraEditors.PanelControl
		Private chbOpenResultingFile As XtraEditors.CheckEdit
		Private passwordLabel As XtraEditors.LabelControl
		Private WithEvents btnExportToXLS As XtraEditors.SimpleButton
		Private WithEvents btnExportToXLSX As XtraEditors.SimpleButton
		Private WithEvents passwordEdit As XtraEditors.ComboBoxEdit
		Private WithEvents typeEdit As XtraEditors.ComboBoxEdit
		Private typeLabel As XtraEditors.LabelControl
		Private separatorControl1 As XtraEditors.SeparatorControl
	End Class
End Namespace
