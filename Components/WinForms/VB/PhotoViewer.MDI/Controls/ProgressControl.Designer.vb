Imports Microsoft.VisualBasic
Imports System
Namespace PhotoViewer
	Partial Public Class ProgressControl
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
			Me.label = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.progressBar = New DevExpress.XtraEditors.ProgressBarControl()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.progressBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' labelControl1
			' 
			Me.label.Location = New System.Drawing.Point(136, 9)
			Me.label.Name = "labelControl1"
			Me.label.Size = New System.Drawing.Size(82, 13)
			Me.label.TabIndex = 0
			Me.label.Text = "Processing folder"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.progressBar)
			Me.panelControl1.Controls.Add(Me.label)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(355, 57)
			Me.panelControl1.TabIndex = 1
			' 
			' progressBarControl1
			' 
			Me.progressBar.Location = New System.Drawing.Point(5, 31)
			Me.progressBar.Name = "progressBarControl1"
			Me.progressBar.Size = New System.Drawing.Size(345, 18)
			Me.progressBar.TabIndex = 1
			' 
			' ProgressControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "ProgressControl"
			Me.Size = New System.Drawing.Size(355, 57)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.progressBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private label As DevExpress.XtraEditors.LabelControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private progressBar As DevExpress.XtraEditors.ProgressBarControl
	End Class
End Namespace
