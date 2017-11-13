Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class DistanceChanger
		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
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
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.checkBox1 = New DevExpress.XtraEditors.CheckEdit()
			Me.trackBar1 = New DevExpress.XtraEditors.TrackBarControl()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Appearance.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
			Me.label1.Location = New Point(5, 5)
			Me.label1.Margin = New Padding(3, 4, 3, 4)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(0, 17)
			Me.label1.TabIndex = 0
			' 
			' checkBox1
			' 
			Me.checkBox1.EditValue = True
			Me.checkBox1.Location = New Point(5, 34)
			Me.checkBox1.Margin = New Padding(3, 4, 3, 4)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Properties.Caption = "Enabled"
			Me.checkBox1.Size = New Size(161, 20)
			Me.checkBox1.TabIndex = 1
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged)
			' 
			' trackBar1
			' 
			Me.trackBar1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.trackBar1.EditValue = Nothing
			Me.trackBar1.Location = New Point(193, 10)
			Me.trackBar1.Margin = New Padding(3, 4, 3, 4)
			Me.trackBar1.Name = "trackBar1"
			Me.trackBar1.Properties.Maximum = 50
			Me.trackBar1.Size = New Size(242, 56)
			Me.trackBar1.TabIndex = 2
'			Me.trackBar1.ValueChanged += New System.EventHandler(Me.trackBar1_ValueChanged)
			' 
			' DistanceChanger
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 16F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.trackBar1)
			Me.Controls.Add(Me.checkBox1)
			Me.Controls.Add(Me.label1)
			Me.Margin = New Padding(3, 4, 3, 4)
			Me.Name = "DistanceChanger"
			Me.Size = New Size(439, 59)
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents checkBox1 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents trackBar1 As DevExpress.XtraEditors.TrackBarControl
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
