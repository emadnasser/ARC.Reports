Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleImageEdit
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ModuleImageEdit))
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.ceCustomIcons = New DevExpress.XtraEditors.CheckEdit()
			Me.ceMenu = New DevExpress.XtraEditors.CheckEdit()
			Me.ceIcon = New DevExpress.XtraEditors.CheckEdit()
			Me.icbSizeMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.cePopupSizeable = New DevExpress.XtraEditors.CheckEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.imageEditSample = New DevExpress.XtraEditors.ImageEdit()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.ceCustomIcons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceMenu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceIcon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbSizeMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cePopupSizeable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.imageEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(697, 399)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(691, 393)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.ceCustomIcons)
			Me.groupControl1.Controls.Add(Me.ceMenu)
			Me.groupControl1.Controls.Add(Me.ceIcon)
			Me.groupControl1.Controls.Add(Me.icbSizeMode)
			Me.groupControl1.Controls.Add(Me.label3)
			Me.groupControl1.Controls.Add(Me.cePopupSizeable)
			Me.groupControl1.Location = New System.Drawing.Point(318, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(232, 177)
			Me.groupControl1.TabIndex = 2
			Me.groupControl1.Text = "Properties"
			' 
			' ceCustomIcons
			' 
			Me.ceCustomIcons.Location = New System.Drawing.Point(18, 136)
			Me.ceCustomIcons.Name = "ceCustomIcons"
			Me.ceCustomIcons.Properties.Caption = "Use custom icons"
			Me.ceCustomIcons.Size = New System.Drawing.Size(168, 19)
			Me.ceCustomIcons.TabIndex = 31
'			Me.ceCustomIcons.CheckedChanged += New System.EventHandler(Me.ceCustomIcons_CheckedChanged)
			' 
			' ceMenu
			' 
			Me.ceMenu.Location = New System.Drawing.Point(18, 86)
			Me.ceMenu.Name = "ceMenu"
			Me.ceMenu.Properties.Caption = "Show menu"
			Me.ceMenu.Size = New System.Drawing.Size(168, 19)
			Me.ceMenu.TabIndex = 29
'			Me.ceMenu.CheckedChanged += New System.EventHandler(Me.ceMenu_CheckedChanged)
			' 
			' ceIcon
			' 
			Me.ceIcon.Location = New System.Drawing.Point(18, 61)
			Me.ceIcon.Name = "ceIcon"
			Me.ceIcon.Properties.Caption = "Show icon"
			Me.ceIcon.Size = New System.Drawing.Size(168, 19)
			Me.ceIcon.TabIndex = 28
'			Me.ceIcon.CheckedChanged += New System.EventHandler(Me.ceIcon_CheckedChanged)
			' 
			' icbSizeMode
			' 
			Me.icbSizeMode.EditValue = "imageComboBoxEdit1"
			Me.icbSizeMode.Location = New System.Drawing.Point(96, 32)
			Me.icbSizeMode.Name = "icbSizeMode"
			Me.icbSizeMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbSizeMode.Size = New System.Drawing.Size(112, 20)
			Me.icbSizeMode.TabIndex = 27
'			Me.icbSizeMode.SelectedIndexChanged += New System.EventHandler(Me.icbSizeMode_SelectedIndexChanged)
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(20, 35)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(52, 13)
			Me.label3.TabIndex = 26
			Me.label3.Text = "Size mode:"
			' 
			' cePopupSizeable
			' 
			Me.cePopupSizeable.Location = New System.Drawing.Point(18, 111)
			Me.cePopupSizeable.Name = "cePopupSizeable"
			Me.cePopupSizeable.Properties.Caption = "Popup sizeable"
			Me.cePopupSizeable.Size = New System.Drawing.Size(168, 19)
			Me.cePopupSizeable.TabIndex = 30
'			Me.cePopupSizeable.CheckedChanged += New System.EventHandler(Me.cePopupSizeable_CheckedChanged)
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.imageEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(257, 177)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' imageEditSample
			' 
			Me.imageEditSample.EditValue = (CObj(resources.GetObject("imageEditSample.EditValue")))
			Me.imageEditSample.Location = New System.Drawing.Point(26, 71)
			Me.imageEditSample.Name = "imageEditSample"
			Me.imageEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.imageEditSample.Properties.PopupFormSize = New System.Drawing.Size(470, 240)
			Me.imageEditSample.Size = New System.Drawing.Size(198, 20)
			Me.imageEditSample.TabIndex = 0
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.InsertGalleryImage("gaugestylehalfcircular_16x16.png", "images/gauges/gaugestylehalfcircular_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/gauges/gaugestylehalfcircular_16x16.png"), 0)
			Me.imageCollection1.Images.SetKeyName(0, "gaugestylehalfcircular_16x16.png")
			Me.imageCollection1.InsertGalleryImage("comment_16x16.png", "images/miscellaneous/comment_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/comment_16x16.png"), 1)
			Me.imageCollection1.Images.SetKeyName(1, "comment_16x16.png")
			' 
			' ModuleImageEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleImageEdit"
			Me.Size = New System.Drawing.Size(702, 404)
'			Me.Load += New System.EventHandler(Me.ModuleImageEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.ceCustomIcons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceMenu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceIcon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbSizeMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cePopupSizeable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.imageEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private imageEditSample As DevExpress.XtraEditors.ImageEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbSizeMode As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents ceIcon As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceMenu As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceCustomIcons As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cePopupSizeable As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private imageCollection1 As Utils.ImageCollection

	End Class
End Namespace
