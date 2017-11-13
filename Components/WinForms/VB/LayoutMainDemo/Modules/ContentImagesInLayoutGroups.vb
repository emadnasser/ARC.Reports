Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraLayout.Utils
Namespace DevExpress.XtraLayout.Demos
	Public Partial Class ContentImages
		Inherits TutorialControl
		Private layoutControl1 As LayoutControl
		Private layoutControlGroup2 As LayoutControlGroup
		Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
		Private layoutControlItem2 As LayoutControlItem
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private layoutControlItem1 As LayoutControlItem
		Private layoutControlItem3 As LayoutControlItem
		Private layoutControlItem4 As LayoutControlItem
		Private layoutControlItem5 As LayoutControlItem
		Private layoutControlItem6 As LayoutControlItem
		Private emptySpaceItem1 As EmptySpaceItem
        Private emptySpaceItem3 As EmptySpaceItem
        Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
		Private layoutControlGroup1 As LayoutControlGroup
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContentImages))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.labelControl5)
            Me.layoutControl1.Controls.Add(Me.labelControl4)
            Me.layoutControl1.Controls.Add(Me.labelControl3)
            Me.layoutControl1.Controls.Add(Me.labelControl2)
            Me.layoutControl1.Controls.Add(Me.labelControl1)
            Me.layoutControl1.Controls.Add(Me.pictureEdit1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.LookAndFeel.UseDefaultLookAndFeel = False
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsView.ShareLookAndFeelWithChildren = False
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(535, 412)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '
            'labelControl5
            '
            Me.labelControl5.Appearance.ForeColor = System.Drawing.Color.Transparent
            Me.labelControl5.Appearance.Options.UseForeColor = True
            Me.labelControl5.Location = New System.Drawing.Point(165, 155)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Size = New System.Drawing.Size(155, 13)
            Me.labelControl5.TabIndex = 10
            Me.labelControl5.Text = "ComputerName: ComputerName"
            '
            'labelControl4
            '
            Me.labelControl4.Appearance.ForeColor = System.Drawing.Color.Transparent
            Me.labelControl4.Appearance.Options.UseForeColor = True
            Me.labelControl4.Location = New System.Drawing.Point(165, 131)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(105, 13)
            Me.labelControl4.TabIndex = 9
            Me.labelControl4.Text = "NVIDIA GeForce 8800"
            '
            'labelControl3
            '
            Me.labelControl3.Appearance.ForeColor = System.Drawing.Color.Transparent
            Me.labelControl3.Appearance.Options.UseForeColor = True
            Me.labelControl3.Location = New System.Drawing.Point(165, 107)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(63, 13)
            Me.labelControl3.TabIndex = 8
            Me.labelControl3.Text = "1.98 Gb RAM"
            '
            'labelControl2
            '
            Me.labelControl2.Appearance.ForeColor = System.Drawing.Color.Transparent
            Me.labelControl2.Appearance.Options.UseForeColor = True
            Me.labelControl2.Location = New System.Drawing.Point(165, 83)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(213, 13)
            Me.labelControl2.TabIndex = 7
            Me.labelControl2.Text = "Intel Core(TM)2 CPU          6300  @ 1.86GHz"
            '
            'labelControl1
            '
            Me.labelControl1.Appearance.ForeColor = System.Drawing.Color.Transparent
            Me.labelControl1.Appearance.Options.UseForeColor = True
            Me.labelControl1.Location = New System.Drawing.Point(165, 59)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(122, 13)
            Me.labelControl1.TabIndex = 6
            Me.labelControl1.Text = "Microsoft Vista Enterprise"
            '
            'pictureEdit1
            '
            Me.pictureEdit1.EditValue = CType(resources.GetObject("pictureEdit1.EditValue"), Object)
            Me.pictureEdit1.Location = New System.Drawing.Point(35, 35)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopRight
            Me.pictureEdit1.Size = New System.Drawing.Size(94, 343)
            Me.pictureEdit1.TabIndex = 5
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(535, 412)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlGroup2
            '
            Me.layoutControlGroup2.BackgroundImage = CType(resources.GetObject("layoutControlGroup2.BackgroundImage"), System.Drawing.Image)
            Me.layoutControlGroup2.BackgroundImageVisible = True
            Me.layoutControlGroup2.CaptionImage = CType(resources.GetObject("layoutControlGroup2.CaptionImage"), System.Drawing.Image)
            Me.layoutControlGroup2.ContentImage = CType(resources.GetObject("layoutControlGroup2.ContentImage"), System.Drawing.Image)
            Me.layoutControlGroup2.CustomizationFormText = "ComputerName"
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem1, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.emptySpaceItem3, Me.emptySpaceItem1, Me.EmptySpaceItem4})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(533, 410)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutControlGroup2.Text = "ComputerName"
            Me.layoutControlGroup2.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.AllowHotTrack = False
            Me.layoutControlItem2.Control = Me.pictureEdit1
            Me.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(155, 0)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(155, 30)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(30, 30, 30, 30)
            Me.layoutControlItem2.Size = New System.Drawing.Size(155, 404)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.AllowHotTrack = False
            Me.layoutControlItem1.Control = Me.labelControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(155, 49)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem1.Size = New System.Drawing.Size(224, 24)
            Me.layoutControlItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.AllowHotTrack = False
            Me.layoutControlItem3.Control = Me.labelControl2
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(155, 73)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem3.Size = New System.Drawing.Size(224, 24)
            Me.layoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem3.Text = "layoutControlItem3"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.AllowHotTrack = False
            Me.layoutControlItem4.Control = Me.labelControl3
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(155, 97)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem4.Size = New System.Drawing.Size(224, 24)
            Me.layoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem4.Text = "layoutControlItem4"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextToControlDistance = 0
            Me.layoutControlItem4.TextVisible = False
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.AllowHotTrack = False
            Me.layoutControlItem5.Control = Me.labelControl4
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(155, 121)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem5.Size = New System.Drawing.Size(224, 24)
            Me.layoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem5.Text = "layoutControlItem5"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextToControlDistance = 0
            Me.layoutControlItem5.TextVisible = False
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.AllowHotTrack = False
            Me.layoutControlItem6.Control = Me.labelControl5
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(155, 145)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem6.Size = New System.Drawing.Size(224, 24)
            Me.layoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem6.Text = "layoutControlItem6"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextToControlDistance = 0
            Me.layoutControlItem6.TextVisible = False
            '
            'emptySpaceItem3
            '
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
            Me.emptySpaceItem3.Location = New System.Drawing.Point(379, 49)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.emptySpaceItem3.Size = New System.Drawing.Size(148, 120)
            Me.emptySpaceItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.emptySpaceItem3.Text = "emptySpaceItem3"
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(155, 169)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.emptySpaceItem1.Size = New System.Drawing.Size(372, 235)
            Me.emptySpaceItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'EmptySpaceItem4
            '
            Me.EmptySpaceItem4.AllowHotTrack = False
            Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
            Me.EmptySpaceItem4.Location = New System.Drawing.Point(155, 0)
            Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(0, 49)
            Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(10, 49)
            Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
            Me.EmptySpaceItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.EmptySpaceItem4.Size = New System.Drawing.Size(372, 49)
            Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.EmptySpaceItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
            Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
            '
            'ContentImages
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ContentImages"
            Me.Size = New System.Drawing.Size(535, 412)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
	End Class
End Namespace
