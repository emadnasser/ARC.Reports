Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos
	Partial Public Class ProgressForm
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' progressBarControl1
			' 
			Me.progressBarControl1.Location = New System.Drawing.Point(4, 9)
			Me.progressBarControl1.Name = "progressBarControl1"
			Me.progressBarControl1.Size = New System.Drawing.Size(420, 19)
			Me.progressBarControl1.TabIndex = 0
			' 
			' ProgressForm
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.ClientSize = New System.Drawing.Size(430, 38)
			Me.ControlBox = False
			Me.Controls.Add(Me.progressBarControl1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "ProgressForm"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.TopMost = True
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
