Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class ctrlAlphaBlending
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
			Me.groupBox1 = New DevExpress.XtraEditors.GroupControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.pictureBox1 = New PictureBox()
			Me.numericUpDown1 = New DevExpress.XtraEditors.SpinEdit()
			Me.trackBar1 = New DevExpress.XtraEditors.TrackBarControl()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.groupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.numericUpDown1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.pictureBox1)
			Me.groupBox1.Controls.Add(Me.numericUpDown1)
			Me.groupBox1.Controls.Add(Me.trackBar1)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Dock = DockStyle.Fill
			Me.groupBox1.Location = New Point(0, 0)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New Size(345, 96)
			Me.groupBox1.TabIndex = 0
			' 
			' label2
			' 
			Me.label2.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.label2.Location = New Point(267, 32)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(34, 13)
			Me.label2.TabIndex = 4
			Me.label2.Text = "Image:"
'			Me.label2.DoubleClick += New System.EventHandler(Me.label2_DoubleClick)
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.pictureBox1.BorderStyle = BorderStyle.FixedSingle
			Me.pictureBox1.Cursor = Cursors.Hand
			Me.pictureBox1.Location = New Point(267, 48)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New Size(68, 24)
			Me.pictureBox1.TabIndex = 3
			Me.pictureBox1.TabStop = False
'			Me.pictureBox1.Click += New System.EventHandler(Me.pictureBox1_Click)
			' 
			' numericUpDown1
			' 
			Me.numericUpDown1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.numericUpDown1.Location = New Point(24, 53)
			Me.numericUpDown1.Name = "numericUpDown1"
			Me.numericUpDown1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.numericUpDown1.Properties.Increment = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.numericUpDown1.Properties.IsFloatValue = False
			Me.numericUpDown1.Properties.Mask.EditMask = "N00"
			Me.numericUpDown1.Properties.MaxValue = New Decimal(New Integer() { 255, 0, 0, 0})
			Me.numericUpDown1.Size = New Size(96, 20)
			Me.numericUpDown1.TabIndex = 0
'			Me.numericUpDown1.ValueChanged += New System.EventHandler(Me.numericUpDown1_ValueChanged)
			' 
			' trackBar1
			' 
			Me.trackBar1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.trackBar1.EditValue = Nothing
			Me.trackBar1.Location = New Point(134, 36)
			Me.trackBar1.Name = "trackBar1"
			Me.trackBar1.Properties.Maximum = 255
			Me.trackBar1.Properties.TickFrequency = 20
			Me.trackBar1.Properties.TickStyle = TickStyle.TopLeft
			Me.trackBar1.Size = New Size(125, 45)
			Me.trackBar1.TabIndex = 1
'			Me.trackBar1.ValueChanged += New System.EventHandler(Me.trackBar1_ValueChanged)
			' 
			' label1
			' 
			Me.label1.Location = New Point(8, 32)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(102, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Alpha Blending Level:"
			' 
			' ctrlAlphaBlending
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "ctrlAlphaBlending"
			Me.Size = New Size(345, 96)
			CType(Me.groupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.numericUpDown1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private groupBox1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents trackBar1 As DevExpress.XtraEditors.TrackBarControl
		Private WithEvents numericUpDown1 As DevExpress.XtraEditors.SpinEdit
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents pictureBox1 As PictureBox
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
