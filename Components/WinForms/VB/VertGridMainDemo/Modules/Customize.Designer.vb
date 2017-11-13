Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class Customize
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customize))
            Me.chCustomize = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlLeft.SuspendLayout()
            CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.Images.SetKeyName(0, "")
            Me.imageList2.Images.SetKeyName(1, "")
            Me.imageList2.Images.SetKeyName(2, "")
            '
            'pnlLeft
            '
            Me.pnlLeft.Controls.Add(Me.chCustomize)
            Me.pnlLeft.Controls.SetChildIndex(Me.chCustomize, 0)
            '
            'chCustomize
            '
            Me.chCustomize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chCustomize.Image = CType(resources.GetObject("chCustomize.Image"), System.Drawing.Image)
            Me.chCustomize.Location = New System.Drawing.Point(32, 16)
            Me.chCustomize.Name = "chCustomize"
            Me.chCustomize.Size = New System.Drawing.Size(136, 64)
            Me.chCustomize.TabIndex = 3
            Me.chCustomize.Text = "Show" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Customization" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Form"
            '
            'Customize
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Customize"
            Me.Size = New System.Drawing.Size(809, 488)
            CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlLeft.ResumeLayout(False)
            CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private WithEvents chCustomize As DevExpress.XtraEditors.SimpleButton
		Private components As System.ComponentModel.IContainer = Nothing
	End Class
End Namespace
