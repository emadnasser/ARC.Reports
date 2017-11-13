Imports Microsoft.VisualBasic
Imports System
Namespace ContactManagement
	Public Partial Class About
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.btnOk = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(16, 16)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(232, 48)
			Me.label1.TabIndex = 0
			Me.label1.Text = "This is a  sample program for Xpo.Net. Copyright Developer Express Inc. 2000-2006" & ""
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' btnOk
			' 
			Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnOk.Location = New System.Drawing.Point(93, 80)
			Me.btnOk.Name = "btnOk"
			Me.btnOk.Size = New System.Drawing.Size(70, 20)
			Me.btnOk.TabIndex = 1
			Me.btnOk.Text = "OK"
			' 
			' About
			' 
			Me.AcceptButton = Me.btnOk
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.CancelButton = Me.btnOk
			Me.ClientSize = New System.Drawing.Size(257, 109)
			Me.Controls.Add(Me.btnOk)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "About"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "About"
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private label1 As System.Windows.Forms.Label
		Private btnOk As System.Windows.Forms.Button
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
