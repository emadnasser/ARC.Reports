Namespace DevExpress.MailClient.Win.Controls
	Partial Public Class ucContactInfo
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
			Me.teNotes = New DevExpress.XtraEditors.MemoEdit()
			Me.teAddress = New DevExpress.XtraEditors.TextEdit()
			Me.tePhone = New DevExpress.XtraEditors.TextEdit()
			Me.teEmail = New DevExpress.XtraEditors.HyperLinkEdit()
			Me.teBirthDate = New DevExpress.XtraEditors.TextEdit()
			Me.lbName = New DevExpress.XtraEditors.LabelControl()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.pePhoto = New DevExpress.MailClient.Win.PictureEditSimpleZoom()
			Me.lciPhoto = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.teNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teBirthDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
            Me.lcMain.AllowCustomization = False
			Me.lcMain.Controls.Add(Me.teNotes)
			Me.lcMain.Controls.Add(Me.teAddress)
			Me.lcMain.Controls.Add(Me.tePhone)
			Me.lcMain.Controls.Add(Me.teEmail)
			Me.lcMain.Controls.Add(Me.teBirthDate)
			Me.lcMain.Controls.Add(Me.lbName)
			Me.lcMain.Controls.Add(Me.pePhoto)
			Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lcMain.Location = New System.Drawing.Point(0, 0)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(669, 200, 450, 350)
			Me.lcMain.Root = Me.lcgMain
			Me.lcMain.Size = New System.Drawing.Size(227, 397)
			Me.lcMain.TabIndex = 0
			Me.lcMain.Text = "layoutControl1"
			' 
			' teNotes
			' 
			Me.teNotes.Location = New System.Drawing.Point(2, 381)
			Me.teNotes.Name = "teNotes"
			Me.teNotes.Properties.ReadOnly = True
			Me.teNotes.Size = New System.Drawing.Size(223, 16)
			Me.teNotes.StyleController = Me.lcMain
			Me.teNotes.TabIndex = 11
			Me.teNotes.UseOptimizedRendering = True
			' 
			' teAddress
			' 
			Me.teAddress.Location = New System.Drawing.Point(2, 341)
			Me.teAddress.Name = "teAddress"
			Me.teAddress.Properties.ReadOnly = True
			Me.teAddress.Size = New System.Drawing.Size(223, 20)
			Me.teAddress.StyleController = Me.lcMain
			Me.teAddress.TabIndex = 10
			' 
			' tePhone
			' 
			Me.tePhone.Location = New System.Drawing.Point(57, 301)
			Me.tePhone.Name = "tePhone"
			Me.tePhone.Properties.ReadOnly = True
			Me.tePhone.Size = New System.Drawing.Size(168, 20)
			Me.tePhone.StyleController = Me.lcMain
			Me.tePhone.TabIndex = 9
			' 
			' teEmail
			' 
			Me.teEmail.Location = New System.Drawing.Point(57, 277)
			Me.teEmail.Name = "teEmail"
			Me.teEmail.Properties.ReadOnly = True
			Me.teEmail.Size = New System.Drawing.Size(168, 20)
			Me.teEmail.StyleController = Me.lcMain
			Me.teEmail.TabIndex = 8
'			Me.teEmail.OpenLink += New DevExpress.XtraEditors.Controls.OpenLinkEventHandler(Me.teEmail_OpenLink)
			' 
			' teBirthDate
			' 
			Me.teBirthDate.Location = New System.Drawing.Point(57, 253)
			Me.teBirthDate.Name = "teBirthDate"
			Me.teBirthDate.Properties.ReadOnly = True
			Me.teBirthDate.Size = New System.Drawing.Size(168, 20)
			Me.teBirthDate.StyleController = Me.lcMain
			Me.teBirthDate.TabIndex = 7
			' 
			' lbName
			' 
			Me.lbName.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.lbName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
			Me.lbName.Location = New System.Drawing.Point(2, 224)
			Me.lbName.Name = "lbName"
			Me.lbName.Size = New System.Drawing.Size(223, 25)
			Me.lbName.StyleController = Me.lcMain
			Me.lbName.TabIndex = 6
			Me.lbName.Text = "Name"
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "lcgMain"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciPhoto, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem1})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "Root"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Size = New System.Drawing.Size(227, 397)
			Me.lcgMain.Text = "Root"
			Me.lcgMain.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.teBirthDate
			Me.layoutControlItem2.CustomizationFormText = "Birth Date:"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 251)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(227, 24)
			Me.layoutControlItem2.Text = "Birth Date:"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(52, 13)
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.teEmail
			Me.layoutControlItem3.CustomizationFormText = "Email:"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 275)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(227, 24)
			Me.layoutControlItem3.Text = "Email:"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(52, 13)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.tePhone
			Me.layoutControlItem4.CustomizationFormText = "Phone:"
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 299)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(227, 24)
			Me.layoutControlItem4.Text = "Phone:"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(52, 13)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.teAddress
			Me.layoutControlItem5.CustomizationFormText = "Address:"
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 323)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(227, 40)
			Me.layoutControlItem5.Text = "Address:"
			Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(52, 13)
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.teNotes
			Me.layoutControlItem6.CustomizationFormText = "Notes:"
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 363)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 0)
			Me.layoutControlItem6.Size = New System.Drawing.Size(227, 34)
			Me.layoutControlItem6.Text = "Notes:"
			Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(52, 13)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.lbName
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 222)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(227, 29)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' pePhoto
			' 
			Me.pePhoto.Location = New System.Drawing.Point(0, 0)
			Me.pePhoto.Name = "pePhoto"
			Me.pePhoto.Properties.AllowFocused = False
			Me.pePhoto.Properties.NullText = " "
			Me.pePhoto.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
			Me.pePhoto.Properties.ReadOnly = True
			Me.pePhoto.Properties.ShowMenu = False
			Me.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.pePhoto.Size = New System.Drawing.Size(225, 222)
			Me.pePhoto.StyleController = Me.lcMain
			Me.pePhoto.TabIndex = 4
'			Me.pePhoto.Resize += New System.EventHandler(Me.pePhoto_Resize)
			' 
			' lciPhoto
			' 
			Me.lciPhoto.Control = Me.pePhoto
			Me.lciPhoto.CustomizationFormText = "lciPhoto"
			Me.lciPhoto.Location = New System.Drawing.Point(0, 0)
			Me.lciPhoto.Name = "lciPhoto"
			Me.lciPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 2, 0, 0)
			Me.lciPhoto.Size = New System.Drawing.Size(227, 222)
			Me.lciPhoto.Text = "lciPhoto"
			Me.lciPhoto.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPhoto.TextToControlDistance = 0
			Me.lciPhoto.TextVisible = False
			' 
			' ucContactInfo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.lcMain)
			Me.Name = "ucContactInfo"
			Me.Size = New System.Drawing.Size(227, 397)
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.teNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teBirthDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lcMain As DevExpress.XtraLayout.LayoutControl
		Private WithEvents pePhoto As PictureEditSimpleZoom
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private lciPhoto As DevExpress.XtraLayout.LayoutControlItem
		Private teAddress As XtraEditors.TextEdit
		Private tePhone As XtraEditors.TextEdit
		Private WithEvents teEmail As XtraEditors.HyperLinkEdit
		Private teBirthDate As XtraEditors.TextEdit
		Private lbName As XtraEditors.LabelControl
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private layoutControlItem3 As XtraLayout.LayoutControlItem
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private layoutControlItem5 As XtraLayout.LayoutControlItem
		Private teNotes As XtraEditors.MemoEdit
		Private layoutControlItem6 As XtraLayout.LayoutControlItem
	End Class
End Namespace
