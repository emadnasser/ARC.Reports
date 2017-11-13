Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleMarqueeProgressBar
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
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.checkEditPause = New DevExpress.XtraEditors.CheckEdit()
            Me.teTitle = New DevExpress.XtraEditors.TextEdit()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.icbProgressViewStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.spinEditAnimationSpeed = New DevExpress.XtraEditors.SpinEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.checkEditVertical = New DevExpress.XtraEditors.CheckEdit()
            Me.lblBarStyle = New DevExpress.XtraEditors.LabelControl()
            Me.checkEditShowTitle = New DevExpress.XtraEditors.CheckEdit()
            Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
            Me.marqueeProgressBarControl1 = New DevExpress.XtraEditors.MarqueeProgressBarControl()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            CType(Me.checkEditPause.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icbProgressViewStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinEditAnimationSpeed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEditVertical.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEditShowTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl3.SuspendLayout()
            CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
            Me.xtraTabControl1.Size = New System.Drawing.Size(822, 631)
            Me.xtraTabControl1.TabIndex = 16
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1})
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.groupControl2)
            Me.xtraTabPage1.Controls.Add(Me.groupControl3)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(816, 625)
            Me.xtraTabPage1.Text = "Layout and Appearance"
            '
            'groupControl2
            '
            Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl2.Appearance.Options.UseBackColor = True
            Me.groupControl2.Controls.Add(Me.checkEditPause)
            Me.groupControl2.Controls.Add(Me.teTitle)
            Me.groupControl2.Controls.Add(Me.labelControl2)
            Me.groupControl2.Controls.Add(Me.icbProgressViewStyle)
            Me.groupControl2.Controls.Add(Me.spinEditAnimationSpeed)
            Me.groupControl2.Controls.Add(Me.labelControl1)
            Me.groupControl2.Controls.Add(Me.checkEditVertical)
            Me.groupControl2.Controls.Add(Me.lblBarStyle)
            Me.groupControl2.Controls.Add(Me.checkEditShowTitle)
            Me.groupControl2.Location = New System.Drawing.Point(383, 30)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(263, 351)
            Me.groupControl2.TabIndex = 4
            Me.groupControl2.Text = "Properties"
            '
            'checkEditPause
            '
            Me.checkEditPause.Location = New System.Drawing.Point(18, 141)
            Me.checkEditPause.Name = "checkEditPause"
            Me.checkEditPause.Properties.Caption = "Pause"
            Me.checkEditPause.Size = New System.Drawing.Size(63, 19)
            Me.checkEditPause.TabIndex = 11
            '
            'teTitle
            '
            Me.teTitle.Location = New System.Drawing.Point(72, 176)
            Me.teTitle.Name = "teTitle"
            Me.teTitle.Size = New System.Drawing.Size(168, 20)
            Me.teTitle.TabIndex = 10
            '
            'labelControl2
            '
            Me.labelControl2.Location = New System.Drawing.Point(20, 179)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(24, 13)
            Me.labelControl2.TabIndex = 9
            Me.labelControl2.Text = "Title:"
            '
            'icbProgressViewStyle
            '
            Me.icbProgressViewStyle.Location = New System.Drawing.Point(136, 31)
            Me.icbProgressViewStyle.Name = "icbProgressViewStyle"
            Me.icbProgressViewStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbProgressViewStyle.Size = New System.Drawing.Size(104, 20)
            Me.icbProgressViewStyle.TabIndex = 0
            '
            'spinEditAnimationSpeed
            '
            Me.spinEditAnimationSpeed.EditValue = New Decimal(New Integer() {200, 0, 0, 0})
            Me.spinEditAnimationSpeed.Location = New System.Drawing.Point(136, 60)
            Me.spinEditAnimationSpeed.Name = "spinEditAnimationSpeed"
            Me.spinEditAnimationSpeed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEditAnimationSpeed.Properties.IsFloatValue = False
            Me.spinEditAnimationSpeed.Properties.Mask.EditMask = "N00"
            Me.spinEditAnimationSpeed.Properties.MaxValue = New Decimal(New Integer() {500, 0, 0, 0})
            Me.spinEditAnimationSpeed.Properties.MinValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.spinEditAnimationSpeed.Size = New System.Drawing.Size(104, 20)
            Me.spinEditAnimationSpeed.TabIndex = 1
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(20, 63)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(81, 13)
            Me.labelControl1.TabIndex = 8
            Me.labelControl1.Text = "Animation Delay:"
            '
            'checkEditVertical
            '
            Me.checkEditVertical.Location = New System.Drawing.Point(18, 91)
            Me.checkEditVertical.Name = "checkEditVertical"
            Me.checkEditVertical.Properties.Caption = "Vertical"
            Me.checkEditVertical.Size = New System.Drawing.Size(200, 19)
            Me.checkEditVertical.TabIndex = 2
            '
            'lblBarStyle
            '
            Me.lblBarStyle.Location = New System.Drawing.Point(20, 35)
            Me.lblBarStyle.Name = "lblBarStyle"
            Me.lblBarStyle.Size = New System.Drawing.Size(46, 13)
            Me.lblBarStyle.TabIndex = 7
            Me.lblBarStyle.Text = "Bar style:"
            '
            'checkEditShowTitle
            '
            Me.checkEditShowTitle.Location = New System.Drawing.Point(18, 116)
            Me.checkEditShowTitle.Name = "checkEditShowTitle"
            Me.checkEditShowTitle.Properties.Caption = "Show title"
            Me.checkEditShowTitle.Size = New System.Drawing.Size(200, 19)
            Me.checkEditShowTitle.TabIndex = 3
            '
            'groupControl3
            '
            Me.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl3.Appearance.Options.UseBackColor = True
            Me.groupControl3.Controls.Add(Me.marqueeProgressBarControl1)
            Me.groupControl3.Location = New System.Drawing.Point(30, 30)
            Me.groupControl3.Name = "groupControl3"
            Me.groupControl3.Size = New System.Drawing.Size(322, 351)
            Me.groupControl3.TabIndex = 0
            Me.groupControl3.Text = "Sample"
            '
            'marqueeProgressBarControl1
            '
            Me.marqueeProgressBarControl1.EditValue = "Rebuild..."
            Me.marqueeProgressBarControl1.Location = New System.Drawing.Point(44, 105)
            Me.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1"
            Me.marqueeProgressBarControl1.Size = New System.Drawing.Size(244, 18)
            Me.marqueeProgressBarControl1.TabIndex = 0
            '
            'ModuleMarqueeProgressBar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleMarqueeProgressBar"
            Me.Size = New System.Drawing.Size(827, 636)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            Me.groupControl2.PerformLayout()
            CType(Me.checkEditPause.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icbProgressViewStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinEditAnimationSpeed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEditVertical.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEditShowTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl3.ResumeLayout(False)
            CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private marqueeProgressBarControl1 As DevExpress.XtraEditors.MarqueeProgressBarControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents checkEditVertical As DevExpress.XtraEditors.CheckEdit
		Private lblBarStyle As DevExpress.XtraEditors.LabelControl
		Private WithEvents checkEditShowTitle As DevExpress.XtraEditors.CheckEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents spinEditAnimationSpeed As DevExpress.XtraEditors.SpinEdit
		Private WithEvents icbProgressViewStyle As DevExpress.XtraEditors.ImageComboBoxEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents teTitle As DevExpress.XtraEditors.TextEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents checkEditPause As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
