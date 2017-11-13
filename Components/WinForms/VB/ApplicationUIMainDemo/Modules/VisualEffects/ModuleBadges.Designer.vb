Namespace DevExpress.ApplicationUI.Demos.VisualEffects
    Partial Public Class ModuleBadges
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuleBadges))
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.targetElement2 = New DevExpress.XtraEditors.PanelControl()
            Me.targetElement1 = New DevExpress.XtraEditors.PanelControl()
            Me.adornerUIManager1 = New DevExpress.Utils.VisualEffects.AdornerUIManager(Me.components)
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.cbAllowGlyphSkinning = New DevExpress.XtraEditors.CheckEdit()
            Me.cbStretchImage = New DevExpress.XtraEditors.CheckEdit()
            Me.cbAllowImage = New DevExpress.XtraEditors.CheckEdit()
            Me.ceVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.seYOffset = New DevExpress.XtraEditors.SpinEdit()
            Me.seXOffset = New DevExpress.XtraEditors.SpinEdit()
            Me.cbTargetElement = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.teText = New DevExpress.XtraEditors.TextEdit()
            Me.ceImageColor = New DevExpress.XtraEditors.ColorEdit()
            Me.ceTextColor = New DevExpress.XtraEditors.ColorEdit()
            Me.ieImage = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.ieLocation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.lbYOffset = New DevExpress.XtraEditors.LabelControl()
            Me.lbXOffset = New DevExpress.XtraEditors.LabelControl()
            Me.lbLocation = New DevExpress.XtraEditors.LabelControl()
            Me.lbImageColor = New DevExpress.XtraEditors.LabelControl()
            Me.lbImage = New DevExpress.XtraEditors.LabelControl()
            Me.lbTextColor = New DevExpress.XtraEditors.LabelControl()
            Me.lbText = New DevExpress.XtraEditors.LabelControl()
            Me.lbTargetElement = New DevExpress.XtraEditors.LabelControl()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            CType(Me.targetElement2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.targetElement1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType(Me.cbAllowGlyphSkinning.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbStretchImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbAllowImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceVisible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seYOffset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seXOffset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbTargetElement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceImageColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceTextColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ieImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ieLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'groupControl2
            '
            Me.groupControl2.Controls.Add(Me.targetElement2)
            Me.groupControl2.Controls.Add(Me.targetElement1)
            Me.groupControl2.Location = New System.Drawing.Point(46, 28)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(288, 362)
            Me.groupControl2.TabIndex = 8
            Me.groupControl2.Text = "Sample"
            '
            'targetElement2
            '
            Me.targetElement2.Location = New System.Drawing.Point(23, 201)
            Me.targetElement2.Name = "targetElement2"
            Me.targetElement2.Size = New System.Drawing.Size(242, 137)
            Me.targetElement2.TabIndex = 1
            '
            'targetElement1
            '
            Me.targetElement1.Location = New System.Drawing.Point(23, 42)
            Me.targetElement1.Name = "targetElement1"
            Me.targetElement1.Size = New System.Drawing.Size(242, 137)
            Me.targetElement1.TabIndex = 0
            '
            'adornerUIManager1
            '
            Me.adornerUIManager1.Owner = Me
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.groupControl2)
            Me.xtraTabPage1.Controls.Add(Me.groupControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(773, 421)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            '
            'groupControl1
            '
            Me.groupControl1.Controls.Add(Me.cbAllowGlyphSkinning)
            Me.groupControl1.Controls.Add(Me.cbStretchImage)
            Me.groupControl1.Controls.Add(Me.cbAllowImage)
            Me.groupControl1.Controls.Add(Me.ceVisible)
            Me.groupControl1.Controls.Add(Me.seYOffset)
            Me.groupControl1.Controls.Add(Me.seXOffset)
            Me.groupControl1.Controls.Add(Me.cbTargetElement)
            Me.groupControl1.Controls.Add(Me.teText)
            Me.groupControl1.Controls.Add(Me.ceImageColor)
            Me.groupControl1.Controls.Add(Me.ceTextColor)
            Me.groupControl1.Controls.Add(Me.ieImage)
            Me.groupControl1.Controls.Add(Me.ieLocation)
            Me.groupControl1.Controls.Add(Me.lbYOffset)
            Me.groupControl1.Controls.Add(Me.lbXOffset)
            Me.groupControl1.Controls.Add(Me.lbLocation)
            Me.groupControl1.Controls.Add(Me.lbImageColor)
            Me.groupControl1.Controls.Add(Me.lbImage)
            Me.groupControl1.Controls.Add(Me.lbTextColor)
            Me.groupControl1.Controls.Add(Me.lbText)
            Me.groupControl1.Controls.Add(Me.lbTargetElement)
            Me.groupControl1.Location = New System.Drawing.Point(440, 28)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(288, 362)
            Me.groupControl1.TabIndex = 7
            Me.groupControl1.Text = "Badge Properties"
            '
            'cbAllowGlyphSkinning
            '
            Me.cbAllowGlyphSkinning.EditValue = True
            Me.cbAllowGlyphSkinning.Location = New System.Drawing.Point(139, 294)
            Me.cbAllowGlyphSkinning.Name = "cbAllowGlyphSkinning"
            Me.cbAllowGlyphSkinning.Properties.Caption = "Allow Glyph Skinning"
            Me.cbAllowGlyphSkinning.Size = New System.Drawing.Size(119, 19)
            Me.cbAllowGlyphSkinning.TabIndex = 19
            '
            'cbStretchImage
            '
            Me.cbStretchImage.EditValue = True
            Me.cbStretchImage.Location = New System.Drawing.Point(139, 324)
            Me.cbStretchImage.Name = "cbStretchImage"
            Me.cbStretchImage.Properties.Caption = "Stretch Image"
            Me.cbStretchImage.Size = New System.Drawing.Size(100, 19)
            Me.cbStretchImage.TabIndex = 18
            '
            'cbAllowImage
            '
            Me.cbAllowImage.EditValue = True
            Me.cbAllowImage.Location = New System.Drawing.Point(30, 324)
            Me.cbAllowImage.Name = "cbAllowImage"
            Me.cbAllowImage.Properties.Caption = "Allow Image"
            Me.cbAllowImage.Size = New System.Drawing.Size(84, 19)
            Me.cbAllowImage.TabIndex = 17
            '
            'ceVisible
            '
            Me.ceVisible.EditValue = True
            Me.ceVisible.Location = New System.Drawing.Point(30, 294)
            Me.ceVisible.Name = "ceVisible"
            Me.ceVisible.Properties.Caption = "Visible"
            Me.ceVisible.Size = New System.Drawing.Size(75, 19)
            Me.ceVisible.TabIndex = 16
            '
            'seYOffset
            '
            Me.seYOffset.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seYOffset.Location = New System.Drawing.Point(139, 264)
            Me.seYOffset.Name = "seYOffset"
            Me.seYOffset.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seYOffset.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seYOffset.Properties.MinValue = New Decimal(New Integer() {100, 0, 0, -2147483648})
            Me.seYOffset.Size = New System.Drawing.Size(125, 20)
            Me.seYOffset.TabIndex = 15
            '
            'seXOffset
            '
            Me.seXOffset.EditValue = New Decimal(New Integer() {40, 0, 0, -2147483648})
            Me.seXOffset.Location = New System.Drawing.Point(139, 234)
            Me.seXOffset.Name = "seXOffset"
            Me.seXOffset.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seXOffset.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seXOffset.Properties.MinValue = New Decimal(New Integer() {100, 0, 0, -2147483648})
            Me.seXOffset.Size = New System.Drawing.Size(125, 20)
            Me.seXOffset.TabIndex = 14
            '
            'cbTargetElement
            '
            Me.cbTargetElement.Location = New System.Drawing.Point(139, 39)
            Me.cbTargetElement.Name = "cbTargetElement"
            Me.cbTargetElement.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTargetElement.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbTargetElement.Size = New System.Drawing.Size(125, 20)
            Me.cbTargetElement.TabIndex = 13
            '
            'teText
            '
            Me.teText.EditValue = "5"
            Me.teText.Location = New System.Drawing.Point(139, 69)
            Me.teText.Name = "teText"
            Me.teText.Size = New System.Drawing.Size(125, 20)
            Me.teText.TabIndex = 12
            '
            'ceImageColor
            '
            Me.ceImageColor.EditValue = System.Drawing.Color.Empty
            Me.ceImageColor.Location = New System.Drawing.Point(139, 204)
            Me.ceImageColor.Name = "ceImageColor"
            Me.ceImageColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ceImageColor.Size = New System.Drawing.Size(125, 20)
            Me.ceImageColor.TabIndex = 11
            '
            'ceTextColor
            '
            Me.ceTextColor.EditValue = System.Drawing.Color.Empty
            Me.ceTextColor.Location = New System.Drawing.Point(139, 99)
            Me.ceTextColor.Name = "ceTextColor"
            Me.ceTextColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ceTextColor.Size = New System.Drawing.Size(125, 20)
            Me.ceTextColor.TabIndex = 10
            '
            'ieImage
            '
            Me.ieImage.EditValue = "0"
            Me.ieImage.Location = New System.Drawing.Point(139, 129)
            Me.ieImage.Name = "ieImage"
            Me.ieImage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ieImage.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Circle", "0", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Square", "1", 1)})
            Me.ieImage.Properties.SmallImages = Me.imageList1
            Me.ieImage.Size = New System.Drawing.Size(125, 34)
            Me.ieImage.TabIndex = 9
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "Circle_32x32.png")
            Me.imageList1.Images.SetKeyName(1, "Square_32x32.png")
            '
            'ieLocation
            '
            Me.ieLocation.Location = New System.Drawing.Point(139, 174)
            Me.ieLocation.Name = "ieLocation"
            Me.ieLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ieLocation.Size = New System.Drawing.Size(125, 20)
            Me.ieLocation.TabIndex = 8
            '
            'lbYOffset
            '
            Me.lbYOffset.Location = New System.Drawing.Point(30, 267)
            Me.lbYOffset.Name = "lbYOffset"
            Me.lbYOffset.Size = New System.Drawing.Size(44, 13)
            Me.lbYOffset.TabIndex = 7
            Me.lbYOffset.Text = "Y Offset:"
            '
            'lbXOffset
            '
            Me.lbXOffset.Location = New System.Drawing.Point(30, 237)
            Me.lbXOffset.Name = "lbXOffset"
            Me.lbXOffset.Size = New System.Drawing.Size(44, 13)
            Me.lbXOffset.TabIndex = 6
            Me.lbXOffset.Text = "X Offset:"
            '
            'lbLocation
            '
            Me.lbLocation.Location = New System.Drawing.Point(30, 177)
            Me.lbLocation.Name = "lbLocation"
            Me.lbLocation.Size = New System.Drawing.Size(44, 13)
            Me.lbLocation.TabIndex = 5
            Me.lbLocation.Text = "Location:"
            '
            'lbImageColor
            '
            Me.lbImageColor.Location = New System.Drawing.Point(30, 207)
            Me.lbImageColor.Name = "lbImageColor"
            Me.lbImageColor.Size = New System.Drawing.Size(62, 13)
            Me.lbImageColor.TabIndex = 4
            Me.lbImageColor.Text = "Image Color:"
            '
            'lbImage
            '
            Me.lbImage.Location = New System.Drawing.Point(30, 139)
            Me.lbImage.Name = "lbImage"
            Me.lbImage.Size = New System.Drawing.Size(34, 13)
            Me.lbImage.TabIndex = 3
            Me.lbImage.Text = "Image:"
            '
            'lbTextColor
            '
            Me.lbTextColor.Location = New System.Drawing.Point(30, 102)
            Me.lbTextColor.Name = "lbTextColor"
            Me.lbTextColor.Size = New System.Drawing.Size(54, 13)
            Me.lbTextColor.TabIndex = 2
            Me.lbTextColor.Text = "Text Color:"
            '
            'lbText
            '
            Me.lbText.Location = New System.Drawing.Point(30, 72)
            Me.lbText.Name = "lbText"
            Me.lbText.Size = New System.Drawing.Size(26, 13)
            Me.lbText.TabIndex = 1
            Me.lbText.Text = "Text:"
            '
            'lbTargetElement
            '
            Me.lbTargetElement.Location = New System.Drawing.Point(30, 42)
            Me.lbTargetElement.Name = "lbTargetElement"
            Me.lbTargetElement.Size = New System.Drawing.Size(77, 13)
            Me.lbTargetElement.TabIndex = 0
            Me.lbTargetElement.Text = "Target Element:"
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
            Me.xtraTabControl1.Size = New System.Drawing.Size(779, 427)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1})
            Me.xtraTabControl1.TabStop = False
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList2.Images.SetKeyName(0, "Add_32x32.png")
            Me.imageList2.Images.SetKeyName(1, "Close_32x32.png")
            '
            'ModuleAdornerElementsManager
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleAdornerElementsManager"
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            CType(Me.targetElement2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.targetElement1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            CType(Me.cbAllowGlyphSkinning.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbStretchImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbAllowImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceVisible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seYOffset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seXOffset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbTargetElement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceImageColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceTextColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ieImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ieLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private adornerUIManager1 As Utils.VisualEffects.AdornerUIManager
        Private xtraTabPage1 As XtraTab.XtraTabPage
        Private xtraTabControl1 As XtraTab.XtraTabControl
        Private groupControl2 As XtraEditors.GroupControl
        Private groupControl1 As XtraEditors.GroupControl
        Private targetElement2 As XtraEditors.PanelControl
        Private targetElement1 As XtraEditors.PanelControl
        Private lbImageColor As XtraEditors.LabelControl
        Private lbImage As XtraEditors.LabelControl
        Private lbTextColor As XtraEditors.LabelControl
        Private lbText As XtraEditors.LabelControl
        Private lbTargetElement As XtraEditors.LabelControl
        Private lbXOffset As XtraEditors.LabelControl
        Private lbLocation As XtraEditors.LabelControl
        Private lbYOffset As XtraEditors.LabelControl
        Private WithEvents cbAllowGlyphSkinning As XtraEditors.CheckEdit
        Private WithEvents cbStretchImage As XtraEditors.CheckEdit
        Private WithEvents cbAllowImage As XtraEditors.CheckEdit
        Private WithEvents ceVisible As XtraEditors.CheckEdit
        Private WithEvents seYOffset As XtraEditors.SpinEdit
        Private WithEvents seXOffset As XtraEditors.SpinEdit
        Private WithEvents cbTargetElement As XtraEditors.ComboBoxEdit
        Private WithEvents teText As XtraEditors.TextEdit
        Private WithEvents ceImageColor As XtraEditors.ColorEdit
        Private WithEvents ceTextColor As XtraEditors.ColorEdit
        Private WithEvents ieImage As XtraEditors.ImageComboBoxEdit
        Private WithEvents ieLocation As XtraEditors.ImageComboBoxEdit
        Private imageList1 As System.Windows.Forms.ImageList
        Private imageList2 As System.Windows.Forms.ImageList
    End Class
End Namespace
