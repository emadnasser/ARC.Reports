Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class frmLinkProperties
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
			Me.cbItem = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lbLinkItem = New DevExpress.XtraEditors.LabelControl()
			Me.txtCaption = New DevExpress.XtraEditors.TextEdit()
			Me.lbCaption = New DevExpress.XtraEditors.LabelControl()
			Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
			Me.lbImages = New DevExpress.XtraEditors.LabelControl()
			CType(Me.cbItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtCaption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cbItem
			' 
			Me.cbItem.Location = New Point(88, 37)
			Me.cbItem.Name = "cbItem"
			Me.cbItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbItem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbItem.Size = New Size(152, 20)
			Me.cbItem.TabIndex = 1
'			Me.cbItem.SelectedIndexChanged += New System.EventHandler(Me.cbItem_SelectedIndexChanged)
			' 
			' lbLinkItem
			' 
			Me.lbLinkItem.Location = New Point(8, 42)
			Me.lbLinkItem.Name = "lbLinkItem"
			Me.lbLinkItem.Size = New Size(44, 13)
			Me.lbLinkItem.TabIndex = 14
			Me.lbLinkItem.Text = "LinkItem:"
			' 
			' txtCaption
			' 
			Me.txtCaption.EditValue = ""
			Me.txtCaption.Location = New Point(88, 9)
			Me.txtCaption.Name = "txtCaption"
			Me.txtCaption.Size = New Size(152, 20)
			Me.txtCaption.TabIndex = 0
			' 
			' lbCaption
			' 
			Me.lbCaption.Location = New Point(8, 9)
			Me.lbCaption.Name = "lbCaption"
			Me.lbCaption.Size = New Size(66, 13)
			Me.lbCaption.TabIndex = 0
			Me.lbCaption.Text = "Item Caption:"
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = DialogResult.Cancel
			Me.btnCancel.Location = New Point(160, 134)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Size(80, 26)
			Me.btnCancel.TabIndex = 3
			Me.btnCancel.Text = "&Cancel"
			' 
			' btnOK
			' 
			Me.btnOK.DialogResult = DialogResult.OK
			Me.btnOK.Location = New Point(71, 134)
			Me.btnOK.Name = "btnOK"
			Me.btnOK.Size = New Size(80, 26)
			Me.btnOK.TabIndex = 2
			Me.btnOK.Text = "&OK"
			' 
			' lbImages
			' 
			Me.lbImages.Location = New Point(8, 74)
			Me.lbImages.Name = "lbImages"
			Me.lbImages.Size = New Size(39, 13)
			Me.lbImages.TabIndex = 15
			Me.lbImages.Text = "Images:"
			' 
			' frmLinkProperties
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(250, 166)
			Me.Controls.Add(Me.cbItem)
			Me.Controls.Add(Me.txtCaption)
			Me.Controls.Add(Me.lbImages)
			Me.Controls.Add(Me.lbLinkItem)
			Me.Controls.Add(Me.lbCaption)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnOK)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "frmLinkProperties"
			Me.StartPosition = FormStartPosition.Manual
			Me.Text = "Link Properties"
'			Me.Paint += New System.Windows.Forms.PaintEventHandler(Me.frmLinkProperties_Paint)
'			Me.Closing += New System.ComponentModel.CancelEventHandler(Me.frmLinkProperties_Closing)
			CType(Me.cbItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtCaption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private WithEvents cbItem As DevExpress.XtraEditors.ComboBoxEdit
		Private lbLinkItem As DevExpress.XtraEditors.LabelControl
		Private txtCaption As DevExpress.XtraEditors.TextEdit
		Private lbCaption As DevExpress.XtraEditors.LabelControl
		Private btnCancel As DevExpress.XtraEditors.SimpleButton
		Private btnOK As DevExpress.XtraEditors.SimpleButton
		Private components As System.ComponentModel.Container = Nothing
		Private lbImages As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
