Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleListBox
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
			Me.xtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.splitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
			Me.searchControlSample = New DevExpress.XtraEditors.SearchControl()
			Me.listBoxControlSample = New DevExpress.XtraEditors.ListBoxControl()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.checkedListBoxControlSample = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
			Me.seInvert = New DevExpress.XtraEditors.SimpleButton()
			Me.ceCustomDraw = New DevExpress.XtraEditors.CheckEdit()
			Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
			Me.imageListBoxControlSample = New DevExpress.XtraEditors.ImageListBoxControl()
			Me.lbSample = New DevExpress.XtraEditors.LabelControl()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
			CType(Me.xtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl2.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl.SuspendLayout()
			CType(Me.searchControlSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControlSample, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.checkedListBoxControlSample, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl3.SuspendLayout()
			CType(Me.ceCustomDraw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage3.SuspendLayout()
			CType(Me.imageListBoxControlSample, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' xtraTabControl2
			' 
			Me.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl2.Location = New System.Drawing.Point(374, 0)
			Me.xtraTabControl2.Name = "xtraTabControl2"
			Me.xtraTabControl2.SelectedTabPage = Me.xtraTabPage5
			Me.xtraTabControl2.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl2.Size = New System.Drawing.Size(418, 541)
			Me.xtraTabControl2.TabIndex = 5
			Me.xtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage5})
			Me.xtraTabControl2.TabStop = False
			' 
			' xtraTabPage5
			' 
			Me.xtraTabPage5.Name = "xtraTabPage5"
			Me.xtraTabPage5.Size = New System.Drawing.Size(412, 535)
			Me.xtraTabPage5.Text = "xtraTabPage5"
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.splitContainerControl)
			Me.xtraTabPage1.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Padding = New System.Windows.Forms.Padding(20)
			Me.xtraTabPage1.Size = New System.Drawing.Size(358, 513)
			Me.xtraTabPage1.Text = "ListBox"
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl.Horizontal = False
			Me.splitContainerControl.IsSplitterFixed = True
			Me.splitContainerControl.Location = New System.Drawing.Point(20, 20)
			Me.splitContainerControl.Name = "splitContainerControl1"
			Me.splitContainerControl.Panel1.Controls.Add(Me.searchControlSample)
			Me.splitContainerControl.Panel1.Text = "Panel1"
			Me.splitContainerControl.Panel2.Controls.Add(Me.listBoxControlSample)
			Me.splitContainerControl.Panel2.Text = "Panel2"
			Me.splitContainerControl.Size = New System.Drawing.Size(318, 473)
			Me.splitContainerControl.SplitterPosition = 20
			Me.splitContainerControl.TabIndex = 20
			Me.splitContainerControl.Text = "splitContainerControl"
			' 
			' searchControl1
			' 
			Me.searchControlSample.Dock = System.Windows.Forms.DockStyle.Fill
			Me.searchControlSample.Location = New System.Drawing.Point(0, 0)
			Me.searchControlSample.Name = "searchControlSample"
            Me.searchControlSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
			Me.searchControlSample.Size = New System.Drawing.Size(318, 20)
			Me.searchControlSample.TabIndex = 19
			' 
			' listBoxControlSample
			' 
			Me.listBoxControlSample.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True
			Me.listBoxControlSample.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBoxControlSample.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
			Me.listBoxControlSample.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
			Me.listBoxControlSample.Location = New System.Drawing.Point(0, 0)
			Me.listBoxControlSample.MultiColumn = True
			Me.listBoxControlSample.Name = "listBoxControlSample"
			Me.listBoxControlSample.Size = New System.Drawing.Size(318, 448)
			Me.listBoxControlSample.TabIndex = 0
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.checkedListBoxControlSample)
			Me.xtraTabPage2.Controls.Add(Me.panelControl3)
			Me.xtraTabPage2.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Padding = New System.Windows.Forms.Padding(20)
			Me.xtraTabPage2.Size = New System.Drawing.Size(358, 513)
			Me.xtraTabPage2.Text = "CheckedListBox"
			' 
			' checkedListBoxControlSample
			' 
			Me.checkedListBoxControlSample.Dock = System.Windows.Forms.DockStyle.Fill
			Me.checkedListBoxControlSample.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
			Me.checkedListBoxControlSample.Location = New System.Drawing.Point(20, 20)
			Me.checkedListBoxControlSample.Name = "checkedListBoxControlSample"
			Me.checkedListBoxControlSample.Size = New System.Drawing.Size(318, 434)
			Me.checkedListBoxControlSample.TabIndex = 0
'			Me.checkedListBoxControlSample.DrawItem += New DevExpress.XtraEditors.ListBoxDrawItemEventHandler(Me.checkedListBoxControlSample_DrawItem)
			' 
			' panelControl3
			' 
			Me.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl3.Appearance.Options.UseBackColor = True
			Me.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl3.Controls.Add(Me.seInvert)
			Me.panelControl3.Controls.Add(Me.ceCustomDraw)
			Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl3.Location = New System.Drawing.Point(20, 454)
			Me.panelControl3.Name = "panelControl3"
			Me.panelControl3.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
			Me.panelControl3.Size = New System.Drawing.Size(318, 39)
			Me.panelControl3.TabIndex = 7
			' 
			' seInvert
			' 
			Me.seInvert.Dock = System.Windows.Forms.DockStyle.Right
			Me.seInvert.Location = New System.Drawing.Point(178, 8)
			Me.seInvert.Name = "seInvert"
			Me.seInvert.Size = New System.Drawing.Size(140, 23)
			Me.seInvert.TabIndex = 2
			Me.seInvert.Text = "Invert Checked Items"
'			Me.seInvert.Click += New System.EventHandler(Me.seInvert_Click)
			' 
			' ceCustomDraw
			' 
			Me.ceCustomDraw.EditValue = True
			Me.ceCustomDraw.Location = New System.Drawing.Point(2, 10)
			Me.ceCustomDraw.Name = "ceCustomDraw"
			Me.ceCustomDraw.Properties.Caption = "Custom draw"
			Me.ceCustomDraw.Size = New System.Drawing.Size(96, 19)
			Me.ceCustomDraw.TabIndex = 1
'			Me.ceCustomDraw.CheckedChanged += New System.EventHandler(Me.ceCustomDraw_CheckedChanged)
			' 
			' xtraTabPage3
			' 
			Me.xtraTabPage3.Controls.Add(Me.imageListBoxControlSample)
			Me.xtraTabPage3.Controls.Add(Me.lbSample)
			Me.xtraTabPage3.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xtraTabPage3.Name = "xtraTabPage3"
			Me.xtraTabPage3.Padding = New System.Windows.Forms.Padding(20)
			Me.xtraTabPage3.Size = New System.Drawing.Size(358, 513)
			Me.xtraTabPage3.Text = "ImageListBox"
			' 
			' imageListBoxControlSample
			' 
			Me.imageListBoxControlSample.Dock = System.Windows.Forms.DockStyle.Fill
			Me.imageListBoxControlSample.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
			Me.imageListBoxControlSample.Location = New System.Drawing.Point(20, 20)
			Me.imageListBoxControlSample.Name = "imageListBoxControlSample"
			Me.imageListBoxControlSample.Size = New System.Drawing.Size(318, 452)
			Me.imageListBoxControlSample.TabIndex = 0
'			Me.imageListBoxControlSample.SelectedIndexChanged += New System.EventHandler(Me.imageListBoxControlSample_SelectedIndexChanged)
			' 
			' lbSample
			' 
			Me.lbSample.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.lbSample.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.lbSample.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.lbSample.Location = New System.Drawing.Point(20, 472)
			Me.lbSample.Name = "lbSample"
			Me.lbSample.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
			Me.lbSample.Size = New System.Drawing.Size(59, 21)
			Me.lbSample.TabIndex = 2
			Me.lbSample.Text = "Font Sample"
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.xtraTabControl1.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(364, 541)
			Me.xtraTabControl1.TabIndex = 4
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2, Me.xtraTabPage3})
'			Me.xtraTabControl1.SelectedPageChanged += New DevExpress.XtraTab.TabPageChangedEventHandler(Me.xtraTabControl1_SelectedPageChanged)
			' 
			' splitterControl1
			' 
			Me.splitterControl1.Location = New System.Drawing.Point(369, 0)
			Me.splitterControl1.MinExtra = 350
			Me.splitterControl1.MinSize = 300
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(5, 541)
			Me.splitterControl1.TabIndex = 6
			Me.splitterControl1.TabStop = False
			' 
			' ModuleListBox
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl2)
			Me.Controls.Add(Me.splitterControl1)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleListBox"
			Me.Size = New System.Drawing.Size(792, 546)
			CType(Me.xtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl2.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl.ResumeLayout(False)
			CType(Me.searchControlSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControlSample, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.checkedListBoxControlSample, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl3.ResumeLayout(False)
			CType(Me.ceCustomDraw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage3.ResumeLayout(False)
			Me.xtraTabPage3.PerformLayout()
			CType(Me.imageListBoxControlSample, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private xtraTabControl2 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage5 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
		Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private listBoxControlSample As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents checkedListBoxControlSample As DevExpress.XtraEditors.CheckedListBoxControl
		Private WithEvents ceCustomDraw As DevExpress.XtraEditors.CheckEdit
		Private panelControl3 As DevExpress.XtraEditors.PanelControl
		Private lbSample As DevExpress.XtraEditors.LabelControl
		Private WithEvents seInvert As DevExpress.XtraEditors.SimpleButton
		Private WithEvents imageListBoxControlSample As DevExpress.XtraEditors.ImageListBoxControl
		Private splitterControl1 As SplitterControl
		Private splitContainerControl As SplitContainerControl
		Private searchControlSample As SearchControl

	End Class
End Namespace
