Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleMemoEdit
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
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.seMaxLength = New DevExpress.XtraEditors.SpinEdit()
			Me.ceTab = New DevExpress.XtraEditors.CheckEdit()
			Me.ceReturn = New DevExpress.XtraEditors.CheckEdit()
			Me.ceWordWrap = New DevExpress.XtraEditors.CheckEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.icbScrollBars = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.memoEditSample = New DevExpress.XtraEditors.MemoEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.seMaxLength.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceTab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceReturn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceWordWrap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbScrollBars.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.memoEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(649, 419)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(643, 413)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.seMaxLength)
			Me.groupControl1.Controls.Add(Me.ceTab)
			Me.groupControl1.Controls.Add(Me.ceReturn)
			Me.groupControl1.Controls.Add(Me.ceWordWrap)
			Me.groupControl1.Controls.Add(Me.label1)
			Me.groupControl1.Controls.Add(Me.icbScrollBars)
			Me.groupControl1.Controls.Add(Me.label2)
			Me.groupControl1.Location = New System.Drawing.Point(341, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(267, 212)
			Me.groupControl1.TabIndex = 2
			Me.groupControl1.Text = "Properties"
			' 
			' seMaxLength
			' 
			Me.seMaxLength.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seMaxLength.Location = New System.Drawing.Point(115, 139)
			Me.seMaxLength.Name = "seMaxLength"
			Me.seMaxLength.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seMaxLength.Properties.IsFloatValue = False
			Me.seMaxLength.Properties.Mask.EditMask = "N00"
			Me.seMaxLength.Properties.MaxValue = New Decimal(New Integer() { 10000, 0, 0, 0})
			Me.seMaxLength.Size = New System.Drawing.Size(124, 20)
			Me.seMaxLength.TabIndex = 4
'			Me.seMaxLength.EditValueChanged += New System.EventHandler(Me.seMaxLength_EditValueChanged)
			' 
			' ceTab
			' 
			Me.ceTab.Location = New System.Drawing.Point(113, 111)
			Me.ceTab.Name = "ceTab"
			Me.ceTab.Properties.Caption = "Accepts Tab"
			Me.ceTab.Size = New System.Drawing.Size(124, 19)
			Me.ceTab.TabIndex = 3
'			Me.ceTab.CheckedChanged += New System.EventHandler(Me.ceTab_CheckedChanged)
			' 
			' ceReturn
			' 
			Me.ceReturn.Location = New System.Drawing.Point(113, 86)
			Me.ceReturn.Name = "ceReturn"
			Me.ceReturn.Properties.Caption = "Accepts Return"
			Me.ceReturn.Size = New System.Drawing.Size(124, 19)
			Me.ceReturn.TabIndex = 2
'			Me.ceReturn.CheckedChanged += New System.EventHandler(Me.ceReturn_CheckedChanged)
			' 
			' ceWordWrap
			' 
			Me.ceWordWrap.Location = New System.Drawing.Point(113, 61)
			Me.ceWordWrap.Name = "ceWordWrap"
			Me.ceWordWrap.Properties.Caption = "Word wrap"
			Me.ceWordWrap.Size = New System.Drawing.Size(124, 19)
			Me.ceWordWrap.TabIndex = 1
'			Me.ceWordWrap.CheckedChanged += New System.EventHandler(Me.ceWordWrap_CheckedChanged)
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(20, 142)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(57, 13)
			Me.label1.TabIndex = 23
			Me.label1.Text = "Max length:"
			' 
			' icbScrollBars
			' 
			Me.icbScrollBars.EditValue = "imageComboBoxEdit1"
			Me.icbScrollBars.Location = New System.Drawing.Point(113, 32)
			Me.icbScrollBars.Name = "icbScrollBars"
			Me.icbScrollBars.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbScrollBars.Size = New System.Drawing.Size(124, 20)
			Me.icbScrollBars.TabIndex = 0
'			Me.icbScrollBars.SelectedIndexChanged += New System.EventHandler(Me.icbScrollBars_SelectedIndexChanged)
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(20, 35)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(53, 13)
			Me.label2.TabIndex = 21
			Me.label2.Text = "Scroll bars:"
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.memoEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(280, 212)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' memoEditSample
			' 
			Me.memoEditSample.EditValue = ""
			Me.memoEditSample.Location = New System.Drawing.Point(28, 48)
			Me.memoEditSample.Name = "memoEditSample"
			Me.memoEditSample.Size = New System.Drawing.Size(220, 136)
			Me.memoEditSample.TabIndex = 0
			Me.memoEditSample.UseOptimizedRendering = True
			' 
			' ModuleMemoEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleMemoEdit"
			Me.Size = New System.Drawing.Size(654, 424)
'			Me.Load += New System.EventHandler(Me.ModuleMemoEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.seMaxLength.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceTab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceReturn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceWordWrap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbScrollBars.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.memoEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private memoEditSample As DevExpress.XtraEditors.MemoEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbScrollBars As DevExpress.XtraEditors.ImageComboBoxEdit
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents ceWordWrap As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceReturn As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceTab As DevExpress.XtraEditors.CheckEdit
		Private WithEvents seMaxLength As DevExpress.XtraEditors.SpinEdit
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
