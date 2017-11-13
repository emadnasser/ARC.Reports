Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class AlertInfoProperties
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(AlertInfoProperties))
            Me.icbImage = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.txtCaption = New DevExpress.XtraEditors.TextEdit()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.txtText = New DevExpress.XtraEditors.MemoEdit()
            Me.txtHotTrackedText = New DevExpress.XtraEditors.MemoEdit()
            Me.lcHotTrackedText = New DevExpress.XtraEditors.LabelControl()
            Me.ceShowAnimatedImage = New DevExpress.XtraEditors.CheckEdit()
            CType(Me.icbImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtCaption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtHotTrackedText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowAnimatedImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' icbImage
            ' 
            Me.icbImage.EditValue = 0
            Me.icbImage.Location = New Point(107, 11)
            Me.icbImage.Name = "icbImage"
            Me.icbImage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbImage.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Scheduler", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Note", 1, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Address", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Department", 3, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Products", 4, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("<None>", 5, -1)})
            Me.icbImage.Properties.LargeImages = Me.imageCollection1
            Me.icbImage.Properties.SmallImages = Me.imageCollection2
            Me.icbImage.ShowToolTips = False
            Me.icbImage.Size = New Size(175, 20)
            Me.icbImage.TabIndex = 0
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageSize = New Size(32, 32)
            Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            ' 
            ' imageCollection2
            ' 
            Me.imageCollection2.ImageStream = (CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New Point(14, 14)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New Size(34, 13)
            Me.labelControl2.TabIndex = 8
            Me.labelControl2.Text = "Image:"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New Point(14, 64)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New Size(41, 13)
            Me.labelControl1.TabIndex = 10
            Me.labelControl1.Text = "Caption:"
            ' 
            ' txtCaption
            ' 
            Me.txtCaption.Location = New Point(107, 61)
            Me.txtCaption.Name = "txtCaption"
            Me.txtCaption.Size = New Size(175, 20)
            Me.txtCaption.TabIndex = 2
            '			Me.txtCaption.EditValueChanged += New System.EventHandler(Me.txtCaption_EditValueChanged)
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Location = New Point(14, 92)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New Size(26, 13)
            Me.labelControl3.TabIndex = 12
            Me.labelControl3.Text = "Text:"
            ' 
            ' txtText
            ' 
            Me.txtText.Location = New Point(107, 90)
            Me.txtText.Name = "txtText"
            Me.txtText.Size = New Size(175, 94)
            Me.txtText.TabIndex = 3
            '			Me.txtText.EditValueChanged += New System.EventHandler(Me.txtText_EditValueChanged)
            ' 
            ' txtHotTrackedText
            ' 
            Me.txtHotTrackedText.Location = New Point(107, 196)
            Me.txtHotTrackedText.Name = "txtHotTrackedText"
            Me.txtHotTrackedText.Size = New Size(175, 89)
            Me.txtHotTrackedText.TabIndex = 4
            '			Me.txtHotTrackedText.EditValueChanged += New System.EventHandler(Me.txtSelectedText_EditValueChanged)
            ' 
            ' lcHotTrackedText
            ' 
            Me.lcHotTrackedText.Location = New Point(14, 198)
            Me.lcHotTrackedText.Name = "lcHotTrackedText"
            Me.lcHotTrackedText.Size = New Size(87, 13)
            Me.lcHotTrackedText.TabIndex = 14
            Me.lcHotTrackedText.Text = "Hot Tracked Text:"
            ' 
            ' ceShowAnimatedImage
            ' 
            Me.ceShowAnimatedImage.Location = New Point(105, 36)
            Me.ceShowAnimatedImage.Name = "ceShowAnimatedImage"
            Me.ceShowAnimatedImage.Properties.Caption = "Show Animated Image"
            Me.ceShowAnimatedImage.Size = New Size(177, 19)
            Me.ceShowAnimatedImage.TabIndex = 1
            '			Me.ceShowAnimatedImage.CheckedChanged += New System.EventHandler(Me.ceShowAnimatedImage_CheckedChanged)
            ' 
            ' AlertInfoProperties
            ' 
            Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.ceShowAnimatedImage)
            Me.Controls.Add(Me.txtHotTrackedText)
            Me.Controls.Add(Me.lcHotTrackedText)
            Me.Controls.Add(Me.txtText)
            Me.Controls.Add(Me.labelControl3)
            Me.Controls.Add(Me.txtCaption)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.icbImage)
            Me.Controls.Add(Me.labelControl2)
            Me.Name = "AlertInfoProperties"
            Me.Size = New Size(336, 298)
            CType(Me.icbImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtCaption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtHotTrackedText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowAnimatedImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private icbImage As DevExpress.XtraEditors.ImageComboBoxEdit
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents txtCaption As DevExpress.XtraEditors.TextEdit
        Private labelControl3 As DevExpress.XtraEditors.LabelControl
        Private WithEvents txtText As DevExpress.XtraEditors.MemoEdit
        Private WithEvents txtHotTrackedText As DevExpress.XtraEditors.MemoEdit
        Private lcHotTrackedText As DevExpress.XtraEditors.LabelControl
        Private imageCollection1 As DevExpress.Utils.ImageCollection
        Private imageCollection2 As DevExpress.Utils.ImageCollection
        Private WithEvents ceShowAnimatedImage As DevExpress.XtraEditors.CheckEdit
    End Class
End Namespace
