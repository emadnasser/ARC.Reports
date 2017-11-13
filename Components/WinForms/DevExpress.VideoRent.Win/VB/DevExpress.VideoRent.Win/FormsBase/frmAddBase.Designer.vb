Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmAddBase
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.pcFormButtons = New DevExpress.XtraEditors.PanelControl()
			Me.sbSave = New DevExpress.XtraEditors.SimpleButton()
			Me.pcSeparator = New DevExpress.XtraEditors.PanelControl()
			Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.dxValidationProvider = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
			CType(Me.pcFormButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcFormButtons.SuspendLayout()
			CType(Me.pcSeparator, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pcFormButtons
			' 
			Me.pcFormButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcFormButtons.Controls.Add(Me.sbSave)
			Me.pcFormButtons.Controls.Add(Me.pcSeparator)
			Me.pcFormButtons.Controls.Add(Me.sbCancel)
			Me.pcFormButtons.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.pcFormButtons.Location = New System.Drawing.Point(12, 238)
			Me.pcFormButtons.Name = "pcFormButtons"
			Me.pcFormButtons.Size = New System.Drawing.Size(368, 22)
			Me.pcFormButtons.TabIndex = 1
			' 
			' sbSave
			' 
			Me.sbSave.Dock = System.Windows.Forms.DockStyle.Right
			Me.sbSave.Location = New System.Drawing.Point(194, 0)
			Me.sbSave.Name = "sbSave"
			Me.sbSave.Size = New System.Drawing.Size(83, 22)
			Me.sbSave.TabIndex = 0
			Me.sbSave.Text = "&Add"
'			Me.sbSave.Click += New System.EventHandler(Me.sbSave_Click);
			' 
			' pcSeparator
			' 
			Me.pcSeparator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcSeparator.Dock = System.Windows.Forms.DockStyle.Right
			Me.pcSeparator.Location = New System.Drawing.Point(277, 0)
			Me.pcSeparator.Name = "pcSeparator"
			Me.pcSeparator.Size = New System.Drawing.Size(8, 22)
			Me.pcSeparator.TabIndex = 2
			' 
			' sbCancel
			' 
			Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.sbCancel.Dock = System.Windows.Forms.DockStyle.Right
			Me.sbCancel.Location = New System.Drawing.Point(285, 0)
			Me.sbCancel.Name = "sbCancel"
			Me.sbCancel.Size = New System.Drawing.Size(83, 22)
			Me.sbCancel.TabIndex = 1
			Me.sbCancel.Text = "&Cancel"
			' 
			' lcMain
			' 
			Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lcMain.Location = New System.Drawing.Point(12, 12)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.Root = Me.lcgMain
			Me.lcMain.Size = New System.Drawing.Size(368, 226)
			Me.lcMain.TabIndex = 0
			Me.lcMain.Text = "layoutControl1"
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "lcgMain"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "lcgMain"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 8)
			Me.lcgMain.Size = New System.Drawing.Size(368, 226)
			Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Text = "lcgMain"
			Me.lcgMain.TextVisible = False
			' 
			' frmAddBase
			' 
			Me.AcceptButton = Me.sbSave
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.sbCancel
			Me.ClientSize = New System.Drawing.Size(392, 272)
			Me.Controls.Add(Me.lcMain)
			Me.Controls.Add(Me.pcFormButtons)
			Me.MinimizeBox = False
			Me.MinimumSize = New System.Drawing.Size(300, 200)
			Me.Name = "frmAddBase"
			Me.Padding = New System.Windows.Forms.Padding(12)
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "frmAddBase"
			CType(Me.pcFormButtons, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcFormButtons.ResumeLayout(False)
			CType(Me.pcSeparator, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pcFormButtons As DevExpress.XtraEditors.PanelControl
		Protected lcMain As DevExpress.XtraLayout.LayoutControl
		Protected lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private pcSeparator As DevExpress.XtraEditors.PanelControl
		Private sbCancel As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbSave As DevExpress.XtraEditors.SimpleButton
		Private dxValidationProvider As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
	End Class
End Namespace