Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class StartupMDIDemos
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
			Me.sbClose = New DevExpress.XtraEditors.SimpleButton()
			Me.sbStart = New DevExpress.XtraEditors.SimpleButton()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' sbClose
			' 
			Me.sbClose.Location = New System.Drawing.Point(21, 49)
			Me.sbClose.Name = "sbClose"
			Me.sbClose.Size = New System.Drawing.Size(136, 26)
			Me.sbClose.TabIndex = 3
			Me.sbClose.Text = "Close Sample"
'			Me.sbClose.Click += New System.EventHandler(Me.sbClose_Click);
			' 
			' sbStart
			' 
			Me.sbStart.Location = New System.Drawing.Point(21, 17)
			Me.sbStart.Name = "sbStart"
			Me.sbStart.Size = New System.Drawing.Size(136, 26)
			Me.sbStart.TabIndex = 2
			Me.sbStart.Text = "Launch Sample"
'			Me.sbStart.Click += New System.EventHandler(Me.sbStart_Click);
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.sbStart)
			Me.xtraTabPage1.Controls.Add(Me.sbClose)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(763, 426)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(769, 432)
			Me.xtraTabControl1.TabIndex = 6
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' StartupMDIDemos
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "StartupMDIDemos"
			Me.Size = New System.Drawing.Size(774, 437)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents sbClose As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbStart As DevExpress.XtraEditors.SimpleButton
		Private xtraTabControl1 As XtraTab.XtraTabControl
		Private xtraTabPage1 As XtraTab.XtraTabPage
	End Class
End Namespace
