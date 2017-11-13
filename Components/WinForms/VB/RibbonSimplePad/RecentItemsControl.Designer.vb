Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
	Partial Public Class RecentItemsControl
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecentItemsControl))
            Me.labelControl1 = New DevExpress.XtraBars.Demos.RibbonSimplePad.BackstageViewLabel
            Me.labelControl2 = New DevExpress.XtraBars.Demos.RibbonSimplePad.BackstageViewLabel
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl
            Me.panel1 = New AutoHeightPanel
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit
            Me.panel2 = New System.Windows.Forms.Panel
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl
            Me.imageCollection3 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            Me.panel1.SuspendLayout()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'labelControl1
            '
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            Me.labelControl1.LineVisible = True
            Me.labelControl1.Location = New System.Drawing.Point(10, 0)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.ShowLineShadow = False
            Me.labelControl1.Size = New System.Drawing.Size(340, 36)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "Recent Documents"
            '
            'labelControl2
            '
            Me.labelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            Me.labelControl2.LineVisible = True
            Me.labelControl2.Location = New System.Drawing.Point(14, 0)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.ShowLineShadow = False
            Me.labelControl2.Size = New System.Drawing.Size(324, 36)
            Me.labelControl2.TabIndex = 1
            Me.labelControl2.Text = "Recent Places"
            '
            'splitContainer1
            '
            Me.splitContainer1.BackColor = System.Drawing.Color.Transparent
            Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer1.ForeColor = System.Drawing.Color.Transparent
            Me.splitContainer1.IsSplitterFixed = True
            Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainer1.Name = "splitContainer1"
            '
            'splitContainer1.Panel1
            '
            Me.splitContainer1.Panel1.Controls.Add(Me.labelControl3)
            Me.splitContainer1.Panel1.Controls.Add(Me.panel1)
            Me.splitContainer1.Panel1.Controls.Add(Me.labelControl1)
            Me.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Transparent
            Me.splitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
            '
            'splitContainer1.Panel2
            '
            Me.splitContainer1.Panel2.Controls.Add(Me.panel2)
            Me.splitContainer1.Panel2.Controls.Add(Me.labelControl4)
            Me.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Transparent
            Me.splitContainer1.Size = New System.Drawing.Size(720, 515)
            Me.splitContainer1.SplitterDistance = 360
            Me.splitContainer1.TabIndex = 2
            '
            'labelControl3
            '
            Me.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.labelControl3.LineVisible = True
            Me.labelControl3.Location = New System.Drawing.Point(10, 476)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.ShowLineShadow = False
            Me.labelControl3.Size = New System.Drawing.Size(340, 13)
            Me.labelControl3.TabIndex = 2
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.spinEdit1)
            Me.panel1.Controls.Add(Me.checkEdit1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(10, 489)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(340, 26)
            Me.panel1.TabIndex = 1
            '
            'spinEdit1
            '
            Me.spinEdit1.Dock = System.Windows.Forms.DockStyle.Right
            Me.spinEdit1.EditValue = New Decimal(New Integer() {4, 0, 0, 0})
            Me.spinEdit1.Enabled = False
            Me.spinEdit1.Location = New System.Drawing.Point(263, 0)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEdit1.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.spinEdit1.Size = New System.Drawing.Size(77, 20)
            Me.spinEdit1.TabIndex = 1
            '
            'checkEdit1
            '
            Me.checkEdit1.Dock = System.Windows.Forms.DockStyle.Left
            Me.checkEdit1.Location = New System.Drawing.Point(0, 0)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Quickly access this number of Recent Documents:"
            Me.checkEdit1.Size = New System.Drawing.Size(271, 19)
            Me.checkEdit1.TabIndex = 0
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.labelControl2)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel2.Location = New System.Drawing.Point(4, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Padding = New System.Windows.Forms.Padding(14, 0, 14, 0)
            Me.panel2.Size = New System.Drawing.Size(352, 515)
            Me.panel2.TabIndex = 2
            '
            'labelControl4
            '
            Me.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl4.Dock = System.Windows.Forms.DockStyle.Left
            Me.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical
            Me.labelControl4.LineVisible = True
            Me.labelControl4.Location = New System.Drawing.Point(0, 0)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(4, 515)
            Me.labelControl4.TabIndex = 3
            '
            'imageCollection3
            '
            Me.imageCollection3.ImageSize = New System.Drawing.Size(15, 15)
            Me.imageCollection3.ImageStream = CType(resources.GetObject("imageCollection3.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection3.Images.SetKeyName(2, "Edit_16x16.png")
            '
            'imageCollection1
            '
            Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
            Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "Edit_32x32.png")
            Me.imageCollection1.Images.SetKeyName(1, "Up_32x32.png")
            '
            'RecentItemsControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainer1)
            Me.Name = "RecentItemsControl"
            Me.Size = New System.Drawing.Size(720, 515)
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private labelControl1 As BackstageViewLabel
		Private labelControl2 As BackstageViewLabel
		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private imageCollection3 As DevExpress.Utils.ImageCollection
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private panel2 As System.Windows.Forms.Panel
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
