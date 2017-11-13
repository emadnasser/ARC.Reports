Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraWizard.Demos
	Partial Public Class frmStart
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'simpleButton1
            '
            Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.simpleButton1.Location = New System.Drawing.Point(10, 224)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(187, 23)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "Start Demo!"
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.checkEdit1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(10, 10)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(187, 34)
            Me.panelControl1.TabIndex = 1
            '
            'checkEdit1
            '
            Me.checkEdit1.Location = New System.Drawing.Point(0, 3)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Use Windows Native Style"
            Me.checkEdit1.Size = New System.Drawing.Size(172, 15)
            Me.checkEdit1.TabIndex = 0
            '
            'listBoxControl1
            '
            Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl1.Location = New System.Drawing.Point(10, 44)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(187, 167)
            Me.listBoxControl1.TabIndex = 2
            '
            'panelControl2
            '
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl2.Location = New System.Drawing.Point(10, 211)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(187, 13)
            Me.panelControl2.TabIndex = 3
            '
            'frmStart
            '
            Me.AcceptButton = Me.simpleButton1
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.simpleButton1
            Me.ClientSize = New System.Drawing.Size(207, 257)
            Me.ControlBox = False
            Me.Controls.Add(Me.listBoxControl1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.simpleButton1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmStart"
            Me.Padding = New System.Windows.Forms.Padding(10)
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Choose skin"
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
