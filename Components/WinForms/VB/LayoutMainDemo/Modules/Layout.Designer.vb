Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraLayout.Demos
	Public Partial Class Layout
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
			Me.components = New System.ComponentModel.Container()
			Me.sbOpen = New DevExpress.XtraEditors.SimpleButton()
			Me.sbDelete = New DevExpress.XtraEditors.SimpleButton()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.SuspendLayout()
			' 
			' sbOpen
			' 
			Me.sbOpen.Location = New System.Drawing.Point(8, 8)
			Me.sbOpen.Name = "sbOpen"
			Me.sbOpen.Size = New System.Drawing.Size(96, 24)
			Me.sbOpen.TabIndex = 0
			Me.sbOpen.Text = "Open Form"
'			Me.sbOpen.Click += New System.EventHandler(Me.sbOpen_Click);
			' 
			' sbDelete
			' 
			Me.sbDelete.Location = New System.Drawing.Point(108, 8)
			Me.sbDelete.Name = "sbDelete"
			Me.sbDelete.Size = New System.Drawing.Size(132, 24)
			Me.sbDelete.TabIndex = 1
			Me.sbDelete.Text = "Delete xml file"
'			Me.sbDelete.Click += New System.EventHandler(Me.sbDelete_Click);
			' 
			' timer1
			' 
			Me.timer1.Interval = 500
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' Layout
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.sbDelete)
			Me.Controls.Add(Me.sbOpen)
			Me.Name = "Layout"
			Me.Size = New System.Drawing.Size(459, 272)
'			Me.Load += New System.EventHandler(Me.Layout_Load);
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents sbOpen As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbDelete As DevExpress.XtraEditors.SimpleButton
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
