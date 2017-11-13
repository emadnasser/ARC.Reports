Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class Layout
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Layout))
			Me.checkBox2 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkBox1 = New DevExpress.XtraEditors.CheckEdit()
			Me.groupBox3 = New DevExpress.XtraEditors.GroupControl()
			Me.radioButton10 = New DevExpress.XtraEditors.CheckEdit()
			Me.radioButton9 = New DevExpress.XtraEditors.CheckEdit()
			Me.radioButton8 = New DevExpress.XtraEditors.CheckEdit()
			Me.radioButton7 = New DevExpress.XtraEditors.CheckEdit()
			Me.radioButton6 = New DevExpress.XtraEditors.CheckEdit()
			Me.groupBox1 = New DevExpress.XtraEditors.GroupControl()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.radioButton3 = New DevExpress.XtraEditors.CheckEdit()
			Me.radioButton2 = New DevExpress.XtraEditors.CheckEdit()
			Me.radioButton1 = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlLeft.SuspendLayout()
			CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox3.SuspendLayout()
			CType(Me.radioButton10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.radioButton3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			' 
			' pnlLeft
			' 
			Me.pnlLeft.Controls.Add(Me.checkBox2)
			Me.pnlLeft.Controls.Add(Me.checkBox1)
			Me.pnlLeft.Controls.Add(Me.groupBox3)
			Me.pnlLeft.Controls.Add(Me.groupBox1)
			Me.pnlLeft.Controls.SetChildIndex(Me.groupBox1, 0)
			Me.pnlLeft.Controls.SetChildIndex(Me.groupBox3, 0)
			Me.pnlLeft.Controls.SetChildIndex(Me.checkBox1, 0)
			Me.pnlLeft.Controls.SetChildIndex(Me.checkBox2, 0)
			' 
			' checkBox2
			' 
			Me.checkBox2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkBox2.Location = New System.Drawing.Point(16, 296)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Properties.Caption = "Show TreeView ButtonStyle"
			Me.checkBox2.Properties.FullFocusRect = True
			Me.checkBox2.Size = New System.Drawing.Size(168, 19)
			Me.checkBox2.TabIndex = 7
'			Me.checkBox2.CheckedChanged += New System.EventHandler(Me.checkBox2_CheckedChanged)
			' 
			' checkBox1
			' 
			Me.checkBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkBox1.EditValue = True
			Me.checkBox1.Location = New System.Drawing.Point(16, 320)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Properties.Appearance.Options.UseTextOptions = True
			Me.checkBox1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.checkBox1.Properties.AutoHeight = False
			Me.checkBox1.Properties.Caption = "Use alternative editors (MemoEx and RadioGroup)"
			Me.checkBox1.Properties.FullFocusRect = True
			Me.checkBox1.Size = New System.Drawing.Size(168, 36)
			Me.checkBox1.TabIndex = 8
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged)
			' 
			' groupBox3
			' 
			Me.groupBox3.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.groupBox3.Controls.Add(Me.radioButton10)
			Me.groupBox3.Controls.Add(Me.radioButton9)
			Me.groupBox3.Controls.Add(Me.radioButton8)
			Me.groupBox3.Controls.Add(Me.radioButton7)
			Me.groupBox3.Controls.Add(Me.radioButton6)
			Me.groupBox3.Location = New System.Drawing.Point(16, 128)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(176, 152)
			Me.groupBox3.TabIndex = 6
			Me.groupBox3.Text = "Show Button Mode"
			' 
			' radioButton10
			' 
			Me.radioButton10.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radioButton10.Location = New System.Drawing.Point(8, 120)
			Me.radioButton10.Name = "radioButton10"
			Me.radioButton10.Properties.Caption = "ShowOnlyInEditor"
			Me.radioButton10.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioButton10.Properties.RadioGroupIndex = 2
			Me.radioButton10.Size = New System.Drawing.Size(162, 19)
			Me.radioButton10.TabIndex = 6
			Me.radioButton10.TabStop = False
'			Me.radioButton10.CheckedChanged += New System.EventHandler(Me.radioButtonButtonMode_CheckedChanged)
			' 
			' radioButton9
			' 
			Me.radioButton9.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radioButton9.Location = New System.Drawing.Point(8, 96)
			Me.radioButton9.Name = "radioButton9"
			Me.radioButton9.Properties.Caption = "ShowForFocusedRecord"
			Me.radioButton9.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioButton9.Properties.RadioGroupIndex = 2
			Me.radioButton9.Size = New System.Drawing.Size(162, 19)
			Me.radioButton9.TabIndex = 5
			Me.radioButton9.TabStop = False
'			Me.radioButton9.CheckedChanged += New System.EventHandler(Me.radioButtonButtonMode_CheckedChanged)
			' 
			' radioButton8
			' 
			Me.radioButton8.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radioButton8.Location = New System.Drawing.Point(8, 72)
			Me.radioButton8.Name = "radioButton8"
			Me.radioButton8.Properties.Caption = "ShowForFocusedCell"
			Me.radioButton8.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioButton8.Properties.RadioGroupIndex = 2
			Me.radioButton8.Size = New System.Drawing.Size(162, 19)
			Me.radioButton8.TabIndex = 4
			Me.radioButton8.TabStop = False
'			Me.radioButton8.CheckedChanged += New System.EventHandler(Me.radioButtonButtonMode_CheckedChanged)
			' 
			' radioButton7
			' 
			Me.radioButton7.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radioButton7.Location = New System.Drawing.Point(8, 48)
			Me.radioButton7.Name = "radioButton7"
			Me.radioButton7.Properties.Caption = "ShowForFocusedRow"
			Me.radioButton7.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioButton7.Properties.RadioGroupIndex = 2
			Me.radioButton7.Size = New System.Drawing.Size(162, 19)
			Me.radioButton7.TabIndex = 3
			Me.radioButton7.TabStop = False
'			Me.radioButton7.CheckedChanged += New System.EventHandler(Me.radioButtonButtonMode_CheckedChanged)
			' 
			' radioButton6
			' 
			Me.radioButton6.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radioButton6.Location = New System.Drawing.Point(8, 24)
			Me.radioButton6.Name = "radioButton6"
			Me.radioButton6.Properties.Caption = "ShowAlways"
			Me.radioButton6.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioButton6.Properties.RadioGroupIndex = 2
			Me.radioButton6.Size = New System.Drawing.Size(162, 19)
			Me.radioButton6.TabIndex = 2
			Me.radioButton6.TabStop = False
'			Me.radioButton6.CheckedChanged += New System.EventHandler(Me.radioButtonButtonMode_CheckedChanged)
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.groupBox1.Controls.Add(Me.label4)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Controls.Add(Me.radioButton3)
			Me.groupBox1.Controls.Add(Me.radioButton2)
			Me.groupBox1.Controls.Add(Me.radioButton1)
			Me.groupBox1.Location = New System.Drawing.Point(16, 16)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(176, 104)
			Me.groupBox1.TabIndex = 5
			Me.groupBox1.Text = "Layout Style"
			' 
			' label4
			' 
			Me.label4.ImageIndex = 2
			Me.label4.ImageList = Me.imageList2
			Me.label4.Location = New System.Drawing.Point(128, 72)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(32, 20)
			Me.label4.TabIndex = 5
			' 
			' label2
			' 
			Me.label2.ImageIndex = 1
			Me.label2.ImageList = Me.imageList2
			Me.label2.Location = New System.Drawing.Point(128, 48)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(32, 20)
			Me.label2.TabIndex = 4
			' 
			' label3
			' 
			Me.label3.ImageIndex = 0
			Me.label3.ImageList = Me.imageList2
			Me.label3.Location = New System.Drawing.Point(128, 24)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(32, 20)
			Me.label3.TabIndex = 3
			' 
			' radioButton3
			' 
			Me.radioButton3.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radioButton3.Location = New System.Drawing.Point(8, 72)
			Me.radioButton3.Name = "radioButton3"
			Me.radioButton3.Properties.Caption = "Multi Record View"
			Me.radioButton3.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioButton3.Properties.RadioGroupIndex = 0
			Me.radioButton3.Size = New System.Drawing.Size(162, 19)
			Me.radioButton3.TabIndex = 2
			Me.radioButton3.TabStop = False
'			Me.radioButton3.CheckedChanged += New System.EventHandler(Me.radioButtonLayoutStyle_CheckedChanged)
			' 
			' radioButton2
			' 
			Me.radioButton2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radioButton2.Location = New System.Drawing.Point(8, 48)
			Me.radioButton2.Name = "radioButton2"
			Me.radioButton2.Properties.Caption = "Single Record View"
			Me.radioButton2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioButton2.Properties.RadioGroupIndex = 0
			Me.radioButton2.Size = New System.Drawing.Size(162, 19)
			Me.radioButton2.TabIndex = 1
			Me.radioButton2.TabStop = False
'			Me.radioButton2.CheckedChanged += New System.EventHandler(Me.radioButtonLayoutStyle_CheckedChanged)
			' 
			' radioButton1
			' 
			Me.radioButton1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radioButton1.Location = New System.Drawing.Point(8, 24)
			Me.radioButton1.Name = "radioButton1"
			Me.radioButton1.Properties.Caption = "Bands View"
			Me.radioButton1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioButton1.Properties.RadioGroupIndex = 0
			Me.radioButton1.Size = New System.Drawing.Size(162, 19)
			Me.radioButton1.TabIndex = 0
			Me.radioButton1.TabStop = False
'			Me.radioButton1.CheckedChanged += New System.EventHandler(Me.radioButtonLayoutStyle_CheckedChanged)
			' 
			' Layout
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "Layout"
			Me.Size = New System.Drawing.Size(805, 488)
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlLeft.ResumeLayout(False)
			CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox3.ResumeLayout(False)
			CType(Me.radioButton10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			CType(Me.radioButton3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents checkBox2 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkBox1 As DevExpress.XtraEditors.CheckEdit
		Private groupBox3 As DevExpress.XtraEditors.GroupControl
		Private WithEvents radioButton10 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents radioButton9 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents radioButton8 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents radioButton7 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents radioButton6 As DevExpress.XtraEditors.CheckEdit
		Private groupBox1 As DevExpress.XtraEditors.GroupControl
		Private label4 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private WithEvents radioButton3 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents radioButton2 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents radioButton1 As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
