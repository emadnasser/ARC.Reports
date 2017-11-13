Imports Microsoft.VisualBasic
Imports System
Namespace DataSetServerDemo
	Public Partial Class Form1
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
			Me.btnSave = New System.Windows.Forms.Button()
			Me.btnTerminate = New System.Windows.Forms.Button()
			Me.btnExit = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' btnSave
			' 
			Me.btnSave.Location = New System.Drawing.Point(16, 16)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New System.Drawing.Size(144, 23)
			Me.btnSave.TabIndex = 1
			Me.btnSave.Text = "&Save database"
'			Me.btnSave.Click += New System.EventHandler(Me.btnSave_Click);
			' 
			' btnTerminate
			' 
			Me.btnTerminate.Location = New System.Drawing.Point(168, 16)
			Me.btnTerminate.Name = "btnTerminate"
			Me.btnTerminate.Size = New System.Drawing.Size(144, 23)
			Me.btnTerminate.TabIndex = 2
			Me.btnTerminate.Text = "&Terminate Server"
'			Me.btnTerminate.Click += New System.EventHandler(Me.btnTerminate_Click);
			' 
			' btnExit
			' 
			Me.btnExit.Location = New System.Drawing.Point(16, 48)
			Me.btnExit.Name = "btnExit"
			Me.btnExit.Size = New System.Drawing.Size(296, 23)
			Me.btnExit.TabIndex = 0
			Me.btnExit.Text = "Save database and e&xit"
'			Me.btnExit.Click += New System.EventHandler(Me.btnExit_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(330, 88)
			Me.Controls.Add(Me.btnExit)
			Me.Controls.Add(Me.btnTerminate)
			Me.Controls.Add(Me.btnSave)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.Text = "DataSet Server Demo"
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents btnSave As System.Windows.Forms.Button
		Private WithEvents btnTerminate As System.Windows.Forms.Button
		Private WithEvents btnExit As System.Windows.Forms.Button
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
