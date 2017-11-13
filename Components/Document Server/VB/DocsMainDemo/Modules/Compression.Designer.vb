Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class Compression
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
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.cbEncryption = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.edtPassword = New DevExpress.XtraEditors.TextEdit()
			Me.Encryption = New DevExpress.XtraEditors.LabelControl()
			Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.pnlProgress = New DevExpress.XtraEditors.PanelControl()
			Me.lblTotalFilesCount = New DevExpress.XtraEditors.LabelControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.fileSystemViewer1 = New DevExpress.Docs.Demos.Modules.FileSystemViewer()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.cbEncryption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlProgress, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlProgress.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.simpleButton1.Location = New System.Drawing.Point(8, 87)
			Me.simpleButton1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(186, 29)
			Me.simpleButton1.TabIndex = 3
			Me.simpleButton1.Text = "Add To Archive..."
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' groupControl2
			' 
			Me.groupControl2.Controls.Add(Me.cbEncryption)
			Me.groupControl2.Controls.Add(Me.labelControl1)
			Me.groupControl2.Controls.Add(Me.edtPassword)
			Me.groupControl2.Controls.Add(Me.Encryption)
			Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.groupControl2.Location = New System.Drawing.Point(8, 0)
			Me.groupControl2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Padding = New System.Windows.Forms.Padding(0, 6, 6, 0)
			Me.groupControl2.Size = New System.Drawing.Size(186, 79)
			Me.groupControl2.TabIndex = 7
			Me.groupControl2.Text = "Options"
			' 
			' cbEncryption
			' 
			Me.cbEncryption.Location = New System.Drawing.Point(74, 52)
			Me.cbEncryption.Name = "cbEncryption"
			Me.cbEncryption.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbEncryption.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbEncryption.Size = New System.Drawing.Size(105, 20)
			Me.cbEncryption.TabIndex = 4
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(13, 29)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(50, 13)
			Me.labelControl1.TabIndex = 6
			Me.labelControl1.Text = "Password:"
			' 
			' edtPassword
			' 
			Me.edtPassword.Location = New System.Drawing.Point(74, 26)
			Me.edtPassword.Margin = New System.Windows.Forms.Padding(3, 6, 6, 3)
			Me.edtPassword.Name = "edtPassword"
			Me.edtPassword.Size = New System.Drawing.Size(105, 20)
			Me.edtPassword.TabIndex = 5
			' 
			' Encryption
			' 
			Me.Encryption.Location = New System.Drawing.Point(13, 55)
			Me.Encryption.Name = "Encryption"
			Me.Encryption.Size = New System.Drawing.Size(55, 13)
			Me.Encryption.TabIndex = 6
			Me.Encryption.Text = "Encryption:"
			' 
			' progressBarControl1
			' 
			Me.progressBarControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.progressBarControl1.Location = New System.Drawing.Point(3, 29)
			Me.progressBarControl1.Name = "progressBarControl1"
			Me.progressBarControl1.Size = New System.Drawing.Size(710, 18)
			Me.progressBarControl1.TabIndex = 2
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.simpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 7F)
			Me.simpleButton2.Appearance.Options.UseFont = True
			Me.simpleButton2.Appearance.Options.UseTextOptions = True
			Me.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.simpleButton2.Location = New System.Drawing.Point(716, 29)
			Me.simpleButton2.Margin = New System.Windows.Forms.Padding(0)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(63, 18)
			Me.simpleButton2.TabIndex = 8
			Me.simpleButton2.Text = "Cancel"
'			Me.simpleButton2.Click += New System.EventHandler(Me.OnCancelArchivingOperation);
			' 
			' pnlProgress
			' 
			Me.pnlProgress.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlProgress.Controls.Add(Me.lblTotalFilesCount)
			Me.pnlProgress.Controls.Add(Me.progressBarControl1)
			Me.pnlProgress.Controls.Add(Me.simpleButton2)
			Me.pnlProgress.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.pnlProgress.Location = New System.Drawing.Point(0, 381)
			Me.pnlProgress.Name = "pnlProgress"
			Me.pnlProgress.Size = New System.Drawing.Size(784, 51)
			Me.pnlProgress.TabIndex = 9
			' 
			' lblTotalFilesCount
			' 
			Me.lblTotalFilesCount.Location = New System.Drawing.Point(5, 6)
			Me.lblTotalFilesCount.Name = "lblTotalFilesCount"
			Me.lblTotalFilesCount.Size = New System.Drawing.Size(0, 13)
			Me.lblTotalFilesCount.TabIndex = 9
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.fileSystemViewer1)
			Me.panel1.Controls.Add(Me.panel2)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(784, 381)
			Me.panel1.TabIndex = 10
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.simpleButton1)
			Me.panel2.Controls.Add(Me.groupControl2)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel2.Location = New System.Drawing.Point(590, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
			Me.panel2.Size = New System.Drawing.Size(194, 381)
			Me.panel2.TabIndex = 8
			' 
			' fileSystemViewer1
			' 
			Me.fileSystemViewer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.fileSystemViewer1.Location = New System.Drawing.Point(0, 0)
			Me.fileSystemViewer1.Name = "fileSystemViewer1"
			Me.fileSystemViewer1.Size = New System.Drawing.Size(590, 381)
			Me.fileSystemViewer1.TabIndex = 2
			' 
			' Compression
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.pnlProgress)
			Me.Name = "Compression"
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.cbEncryption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlProgress, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlProgress.ResumeLayout(False)
			Me.pnlProgress.PerformLayout()
			Me.panel1.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private progressBarControl1 As XtraEditors.ProgressBarControl
		Private WithEvents simpleButton1 As XtraEditors.SimpleButton
		Private cbEncryption As XtraEditors.ComboBoxEdit
		Private edtPassword As XtraEditors.TextEdit
		Private Encryption As XtraEditors.LabelControl
		Private labelControl1 As XtraEditors.LabelControl
		Private groupControl2 As XtraEditors.GroupControl
		Private WithEvents simpleButton2 As XtraEditors.SimpleButton
		Private fileSystemViewer1 As Modules.FileSystemViewer
		Private pnlProgress As XtraEditors.PanelControl
		Private lblTotalFilesCount As XtraEditors.LabelControl
		Private panel1 As System.Windows.Forms.Panel
		Private panel2 As System.Windows.Forms.Panel

	End Class
End Namespace
