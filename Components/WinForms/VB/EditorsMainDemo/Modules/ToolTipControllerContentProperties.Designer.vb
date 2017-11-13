Namespace EditorsTutorials.Modules
	Partial Public Class ToolTipControllerContentProperties
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ToolTipControllerContentProperties))
			Me.icbIconSize = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.icbCustomImage = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.imcSmall = New DevExpress.Utils.ImageCollection(Me.components)
			Me.icbIconType = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.teTitleText = New DevExpress.XtraEditors.TextEdit()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.lblColumnCount = New DevExpress.XtraEditors.LabelControl()
			Me.meToolTipText = New DevExpress.XtraEditors.MemoEdit()
			CType(Me.icbIconSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbCustomImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imcSmall, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbIconType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teTitleText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.meToolTipText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' icbIconSize
			' 
			Me.icbIconSize.Location = New System.Drawing.Point(208, 92)
			Me.icbIconSize.Name = "icbIconSize"
			Me.icbIconSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbIconSize.Size = New System.Drawing.Size(64, 20)
			Me.icbIconSize.TabIndex = 22
'			Me.icbIconSize.SelectedIndexChanged += New System.EventHandler(Me.icbIconSize_SelectedIndexChanged)
			' 
			' icbCustomImage
			' 
			Me.icbCustomImage.EditValue = 0
			Me.icbCustomImage.Location = New System.Drawing.Point(112, 121)
			Me.icbCustomImage.Name = "icbCustomImage"
			Me.icbCustomImage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbCustomImage.Properties.DropDownRows = 12
			Me.icbCustomImage.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("<None>", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", 1, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Design", 2, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mail", 3, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Pie", 4, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Home", 5, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tag", 6, 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Contact", 7, 6), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Database", 8, 7), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Task", 9, 8), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Video", 10, 9)})
			Me.icbCustomImage.Properties.SmallImages = Me.imcSmall
			Me.icbCustomImage.Size = New System.Drawing.Size(160, 20)
			Me.icbCustomImage.TabIndex = 23
'			Me.icbCustomImage.SelectedIndexChanged += New System.EventHandler(Me.icbCustomImage_SelectedIndexChanged)
			' 
			' imcSmall
			' 
			Me.imcSmall.ImageStream = (CType(resources.GetObject("imcSmall.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imcSmall.InsertGalleryImage("time_16x16.png", "images/scheduling/time_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/time_16x16.png"), 0)
			Me.imcSmall.Images.SetKeyName(0, "time_16x16.png")
			Me.imcSmall.InsertGalleryImage("design_16x16.png", "images/miscellaneous/design_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/design_16x16.png"), 1)
			Me.imcSmall.Images.SetKeyName(1, "design_16x16.png")
			Me.imcSmall.InsertGalleryImage("mail_16x16.png", "images/mail/mail_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/mail_16x16.png"), 2)
			Me.imcSmall.Images.SetKeyName(2, "mail_16x16.png")
			Me.imcSmall.InsertGalleryImage("pie_16x16.png", "images/chart/pie_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/pie_16x16.png"), 3)
			Me.imcSmall.Images.SetKeyName(3, "pie_16x16.png")
			Me.imcSmall.InsertGalleryImage("home_16x16.png", "images/navigation/home_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/home_16x16.png"), 4)
			Me.imcSmall.Images.SetKeyName(4, "home_16x16.png")
			Me.imcSmall.InsertGalleryImage("tag_16x16.png", "images/programming/tag_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/tag_16x16.png"), 5)
			Me.imcSmall.Images.SetKeyName(5, "tag_16x16.png")
			Me.imcSmall.InsertGalleryImage("contact_16x16.png", "images/mail/contact_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/contact_16x16.png"), 6)
			Me.imcSmall.Images.SetKeyName(6, "contact_16x16.png")
			Me.imcSmall.InsertGalleryImage("database_16x16.png", "images/data/database_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/database_16x16.png"), 7)
			Me.imcSmall.Images.SetKeyName(7, "database_16x16.png")
			Me.imcSmall.InsertGalleryImage("task_16x16.png", "images/tasks/task_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/tasks/task_16x16.png"), 8)
			Me.imcSmall.Images.SetKeyName(8, "task_16x16.png")
			Me.imcSmall.InsertGalleryImage("video_16x16.png", "images/miscellaneous/video_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/video_16x16.png"), 9)
			Me.imcSmall.Images.SetKeyName(9, "video_16x16.png")
			' 
			' icbIconType
			' 
			Me.icbIconType.Location = New System.Drawing.Point(110, 92)
			Me.icbIconType.Name = "icbIconType"
			Me.icbIconType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbIconType.Properties.DropDownRows = 12
			Me.icbIconType.Size = New System.Drawing.Size(92, 20)
			Me.icbIconType.TabIndex = 21
'			Me.icbIconType.SelectedIndexChanged += New System.EventHandler(Me.icbIconType_SelectedIndexChanged)
			' 
			' teTitleText
			' 
			Me.teTitleText.EditValue = ""
			Me.teTitleText.Location = New System.Drawing.Point(110, 62)
			Me.teTitleText.Name = "teTitleText"
			Me.teTitleText.Size = New System.Drawing.Size(162, 20)
			Me.teTitleText.TabIndex = 20
'			Me.teTitleText.TextChanged += New System.EventHandler(Me.teTitleText_TextChanged)
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(20, 124)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(71, 13)
			Me.label4.TabIndex = 18
			Me.label4.Text = "Custom image:"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(20, 95)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(72, 13)
			Me.label3.TabIndex = 17
			Me.label3.Text = "Icon type/size:"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(20, 65)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(47, 13)
			Me.label2.TabIndex = 16
			Me.label2.Text = "Title text:"
			' 
			' lblColumnCount
			' 
			Me.lblColumnCount.Location = New System.Drawing.Point(20, 11)
			Me.lblColumnCount.Name = "lblColumnCount"
			Me.lblColumnCount.Size = New System.Drawing.Size(61, 13)
			Me.lblColumnCount.TabIndex = 15
			Me.lblColumnCount.Text = "ToolTip text:"
			' 
			' meToolTipText
			' 
			Me.meToolTipText.EditValue = ""
			Me.meToolTipText.Location = New System.Drawing.Point(110, 9)
			Me.meToolTipText.Name = "meToolTipText"
			Me.meToolTipText.Size = New System.Drawing.Size(162, 44)
			Me.meToolTipText.TabIndex = 19
			Me.meToolTipText.UseOptimizedRendering = True
'			Me.meToolTipText.TextChanged += New System.EventHandler(Me.meToolTipText_TextChanged)
			' 
			' ToolTipControllerContentProperties
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.icbIconSize)
			Me.Controls.Add(Me.icbCustomImage)
			Me.Controls.Add(Me.icbIconType)
			Me.Controls.Add(Me.teTitleText)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.lblColumnCount)
			Me.Controls.Add(Me.meToolTipText)
			Me.Name = "ToolTipControllerContentProperties"
			Me.Size = New System.Drawing.Size(285, 161)
			CType(Me.icbIconSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbCustomImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imcSmall, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbIconType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teTitleText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.meToolTipText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private WithEvents icbIconSize As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents icbCustomImage As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents icbIconType As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents teTitleText As DevExpress.XtraEditors.TextEdit
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private lblColumnCount As DevExpress.XtraEditors.LabelControl
		Private WithEvents meToolTipText As DevExpress.XtraEditors.MemoEdit
		Private components As System.ComponentModel.IContainer
		Private imcSmall As DevExpress.Utils.ImageCollection

	End Class
End Namespace
