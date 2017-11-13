Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleMemoExEdit
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ModuleMemoExEdit))
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.ceWordWrap = New DevExpress.XtraEditors.CheckEdit()
			Me.ceCustomIcons = New DevExpress.XtraEditors.CheckEdit()
			Me.ceIcon = New DevExpress.XtraEditors.CheckEdit()
			Me.icbScrollBars = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.cePopupSizeable = New DevExpress.XtraEditors.CheckEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.memoExEditSample = New DevExpress.XtraEditors.MemoExEdit()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.ceWordWrap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceCustomIcons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceIcon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbScrollBars.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cePopupSizeable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.memoExEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(750, 475)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(744, 469)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.ceWordWrap)
			Me.groupControl1.Controls.Add(Me.ceCustomIcons)
			Me.groupControl1.Controls.Add(Me.ceIcon)
			Me.groupControl1.Controls.Add(Me.icbScrollBars)
			Me.groupControl1.Controls.Add(Me.label3)
			Me.groupControl1.Controls.Add(Me.cePopupSizeable)
			Me.groupControl1.Location = New System.Drawing.Point(327, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(231, 180)
			Me.groupControl1.TabIndex = 3
			Me.groupControl1.Text = "Properties"
			' 
			' ceWordWrap
			' 
			Me.ceWordWrap.Location = New System.Drawing.Point(18, 61)
			Me.ceWordWrap.Name = "ceWordWrap"
			Me.ceWordWrap.Properties.Caption = "Word wrap"
			Me.ceWordWrap.Size = New System.Drawing.Size(168, 19)
			Me.ceWordWrap.TabIndex = 1
'			Me.ceWordWrap.CheckedChanged += New System.EventHandler(Me.ceWordWrap_CheckedChanged)
			' 
			' ceCustomIcons
			' 
			Me.ceCustomIcons.Location = New System.Drawing.Point(18, 136)
			Me.ceCustomIcons.Name = "ceCustomIcons"
			Me.ceCustomIcons.Properties.Caption = "Use custom icons"
			Me.ceCustomIcons.Size = New System.Drawing.Size(168, 19)
			Me.ceCustomIcons.TabIndex = 6
'			Me.ceCustomIcons.CheckedChanged += New System.EventHandler(Me.ceCustomIcons_CheckedChanged)
			' 
			' ceIcon
			' 
			Me.ceIcon.Location = New System.Drawing.Point(18, 86)
			Me.ceIcon.Name = "ceIcon"
			Me.ceIcon.Properties.Caption = "Show icon"
			Me.ceIcon.Size = New System.Drawing.Size(168, 19)
			Me.ceIcon.TabIndex = 4
'			Me.ceIcon.CheckedChanged += New System.EventHandler(Me.ceIcon_CheckedChanged)
			' 
			' icbScrollBars
			' 
			Me.icbScrollBars.EditValue = "imageComboBoxEdit1"
			Me.icbScrollBars.Location = New System.Drawing.Point(98, 32)
			Me.icbScrollBars.Name = "icbScrollBars"
			Me.icbScrollBars.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbScrollBars.Size = New System.Drawing.Size(112, 20)
			Me.icbScrollBars.TabIndex = 0
'			Me.icbScrollBars.SelectedIndexChanged += New System.EventHandler(Me.icbScrollBars_SelectedIndexChanged)
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(20, 35)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(53, 13)
			Me.label3.TabIndex = 26
			Me.label3.Text = "Scroll bars:"
			' 
			' cePopupSizeable
			' 
			Me.cePopupSizeable.Location = New System.Drawing.Point(18, 111)
			Me.cePopupSizeable.Name = "cePopupSizeable"
			Me.cePopupSizeable.Properties.Caption = "Popup sizeable"
			Me.cePopupSizeable.Size = New System.Drawing.Size(168, 19)
			Me.cePopupSizeable.TabIndex = 5
'			Me.cePopupSizeable.CheckedChanged += New System.EventHandler(Me.cePopupSizeable_CheckedChanged)
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.memoExEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(265, 180)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' memoExEditSample
			' 
			Me.memoExEditSample.Location = New System.Drawing.Point(31, 55)
			Me.memoExEditSample.Name = "memoExEditSample"
			Me.memoExEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.memoExEditSample.Size = New System.Drawing.Size(188, 20)
			Me.memoExEditSample.TabIndex = 0
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			' 
			' ModuleMemoExEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleMemoExEdit"
			Me.Size = New System.Drawing.Size(755, 480)
'			Me.Load += New System.EventHandler(Me.ModuleMemoExEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.ceWordWrap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceCustomIcons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceIcon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbScrollBars.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cePopupSizeable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.memoExEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private memoExEditSample As DevExpress.XtraEditors.MemoExEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents ceCustomIcons As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceIcon As DevExpress.XtraEditors.CheckEdit
		Private WithEvents icbScrollBars As DevExpress.XtraEditors.ImageComboBoxEdit
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents cePopupSizeable As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceWordWrap As DevExpress.XtraEditors.CheckEdit
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
