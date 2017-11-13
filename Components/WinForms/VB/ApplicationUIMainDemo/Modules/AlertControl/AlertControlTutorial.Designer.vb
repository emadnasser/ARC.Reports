Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class AlertControlTutorial
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
            Dim alertButton1 As New DevExpress.XtraBars.Alerter.AlertButton()
            Dim alertButton2 As New DevExpress.XtraBars.Alerter.AlertButton()
            Dim alertButton3 As New DevExpress.XtraBars.Alerter.AlertButton()
            Dim alertButton4 As New DevExpress.XtraBars.Alerter.AlertButton()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(AlertControlTutorial))
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.sePostponedFormCount = New DevExpress.XtraEditors.SpinEdit()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.ceHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.ceWidth = New DevExpress.XtraEditors.SpinEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.alertInfoProperties1 = New DevExpress.ApplicationUI.Demos.AlertInfoProperties()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.alertControlProperties1 = New DevExpress.ApplicationUI.Demos.AlertControlProperties()
            Me.button1 = New DevExpress.XtraEditors.SimpleButton()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.alertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem2 = New DevExpress.XtraBars.BarCheckItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barCheckItem3 = New DevExpress.XtraBars.BarCheckItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            DirectCast(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            DirectCast(Me.sePostponedFormCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceWidth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            DirectCast(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
            Me.xtraTabControl1.Size = New System.Drawing.Size(708, 530)
            Me.xtraTabControl1.TabIndex = 6
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
            Me.xtraTabControl1.TabStop = False
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.sePostponedFormCount)
            Me.xtraTabPage1.Controls.Add(Me.labelControl3)
            Me.xtraTabPage1.Controls.Add(Me.labelControl2)
            Me.xtraTabPage1.Controls.Add(Me.ceHeight)
            Me.xtraTabPage1.Controls.Add(Me.ceWidth)
            Me.xtraTabPage1.Controls.Add(Me.labelControl1)
            Me.xtraTabPage1.Controls.Add(Me.groupControl2)
            Me.xtraTabPage1.Controls.Add(Me.groupControl1)
            Me.xtraTabPage1.Controls.Add(Me.button1)
            Me.xtraTabPage1.Controls.Add(Me.barDockControlLeft)
            Me.xtraTabPage1.Controls.Add(Me.barDockControlRight)
            Me.xtraTabPage1.Controls.Add(Me.barDockControlBottom)
            Me.xtraTabPage1.Controls.Add(Me.barDockControlTop)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(702, 524)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            ' 
            ' sePostponedFormCount
            ' 
            Me.sePostponedFormCount.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.sePostponedFormCount.Location = New System.Drawing.Point(316, 21)
            Me.sePostponedFormCount.Name = "sePostponedFormCount"
            Me.sePostponedFormCount.Properties.IsFloatValue = False
            Me.sePostponedFormCount.Properties.Mask.EditMask = "N00"
            Me.sePostponedFormCount.Properties.ReadOnly = True
            Me.sePostponedFormCount.Size = New System.Drawing.Size(61, 20)
            Me.sePostponedFormCount.TabIndex = 18
            Me.sePostponedFormCount.TabStop = False
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Location = New System.Drawing.Point(183, 24)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(114, 13)
            Me.labelControl3.TabIndex = 17
            Me.labelControl3.Text = "Postponed Form Count:"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(203, 484)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(4, 13)
            Me.labelControl2.TabIndex = 12
            Me.labelControl2.Text = ","
            ' 
            ' ceHeight
            ' 
            Me.ceHeight.EditValue = New Decimal(New Integer() { 110, 0, 0, 0})
            Me.ceHeight.Location = New System.Drawing.Point(216, 481)
            Me.ceHeight.Name = "ceHeight"
            Me.ceHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.ceHeight.Properties.IsFloatValue = False
            Me.ceHeight.Properties.Mask.EditMask = "N00"
            Me.ceHeight.Properties.MaxValue = New Decimal(New Integer() { 400, 0, 0, 0})
            Me.ceHeight.Properties.MinValue = New Decimal(New Integer() { 100, 0, 0, 0})
            Me.ceHeight.Size = New System.Drawing.Size(84, 20)
            Me.ceHeight.TabIndex = 11
            ' 
            ' ceWidth
            ' 
            Me.ceWidth.EditValue = New Decimal(New Integer() { 250, 0, 0, 0})
            Me.ceWidth.Location = New System.Drawing.Point(113, 481)
            Me.ceWidth.Name = "ceWidth"
            Me.ceWidth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.ceWidth.Properties.IsFloatValue = False
            Me.ceWidth.Properties.Mask.EditMask = "N00"
            Me.ceWidth.Properties.MaxValue = New Decimal(New Integer() { 500, 0, 0, 0})
            Me.ceWidth.Properties.MinValue = New Decimal(New Integer() { 100, 0, 0, 0})
            Me.ceWidth.Size = New System.Drawing.Size(84, 20)
            Me.ceWidth.TabIndex = 9
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(14, 484)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(76, 13)
            Me.labelControl1.TabIndex = 8
            Me.labelControl1.Text = "Alert Form Size:"
            ' 
            ' groupControl2
            ' 
            Me.groupControl2.Controls.Add(Me.alertInfoProperties1)
            Me.groupControl2.Location = New System.Drawing.Point(359, 54)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(298, 399)
            Me.groupControl2.TabIndex = 7
            Me.groupControl2.Text = "Alert Info:"
            ' 
            ' alertInfoProperties1
            ' 
            Me.alertInfoProperties1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.alertInfoProperties1.Location = New System.Drawing.Point(2, 20)
            Me.alertInfoProperties1.Name = "alertInfoProperties1"
            Me.alertInfoProperties1.Size = New System.Drawing.Size(294, 377)
            Me.alertInfoProperties1.TabIndex = 0
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Controls.Add(Me.alertControlProperties1)
            Me.groupControl1.Location = New System.Drawing.Point(12, 54)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(328, 399)
            Me.groupControl1.TabIndex = 6
            Me.groupControl1.Text = "Alert Control Properties:"
            ' 
            ' alertControlProperties1
            ' 
            Me.alertControlProperties1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.alertControlProperties1.Location = New System.Drawing.Point(2, 20)
            Me.alertControlProperties1.Name = "alertControlProperties1"
            Me.alertControlProperties1.Size = New System.Drawing.Size(324, 377)
            Me.alertControlProperties1.TabIndex = 0
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(12, 16)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(141, 28)
            Me.button1.TabIndex = 5
            Me.button1.Text = "&Show Alert Form"
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 524)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(702, 0)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 524)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 524)
            Me.barDockControlBottom.Size = New System.Drawing.Size(702, 0)
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(702, 0)
            ' 
            ' alertControl1
            ' 
            alertButton1.Hint = "Open Info"
            alertButton1.ImageIndex = 5
            alertButton1.Name = "Open"
            alertButton2.Hint = "Copy Info"
            alertButton2.ImageIndex = 2
            alertButton2.Name = "Copy"
            alertButton3.Hint = "Delete Info"
            alertButton3.ImageIndex = 6
            alertButton3.Name = "Delete"
            alertButton4.Down = True
            alertButton4.Hint = "Mail"
            alertButton4.ImageDownIndex = 1
            alertButton4.ImageIndex = 0
            alertButton4.Name = "Mail"
            alertButton4.Style = DevExpress.XtraBars.Alerter.AlertButtonStyle.CheckButton
            Me.alertControl1.Buttons.Add(alertButton1)
            Me.alertControl1.Buttons.Add(alertButton2)
            Me.alertControl1.Buttons.Add(alertButton3)
            Me.alertControl1.Buttons.Add(alertButton4)
            Me.alertControl1.FormMaxCount = 7
            Me.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal
            Me.alertControl1.Images = Me.imageCollection1
            Me.alertControl1.PopupMenu = Me.popupMenu1
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = (DirectCast(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            ' 
            ' popupMenu1
            ' 
            Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3, True),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem3),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1, True),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2)
            })
            Me.popupMenu1.Manager = Me.barManager1
            Me.popupMenu1.Name = "popupMenu1"
            ' 
            ' barSubItem1
            ' 
            Me.barSubItem1.Caption = "Contact"
            Me.barSubItem1.Id = 0
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem2)
            })
            Me.barSubItem1.Name = "barSubItem1"
            ' 
            ' barCheckItem1
            ' 
            Me.barCheckItem1.BindableChecked = True
            Me.barCheckItem1.Caption = "Customer"
            Me.barCheckItem1.Checked = True
            Me.barCheckItem1.GroupIndex = 1
            Me.barCheckItem1.Id = 1
            Me.barCheckItem1.ImageIndex = 10
            Me.barCheckItem1.Name = "barCheckItem1"
            ' 
            ' barCheckItem2
            ' 
            Me.barCheckItem2.Caption = "Employee"
            Me.barCheckItem2.GroupIndex = 1
            Me.barCheckItem2.Id = 2
            Me.barCheckItem2.ImageIndex = 11
            Me.barCheckItem2.Name = "barCheckItem2"
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "Find"
            Me.barButtonItem3.Id = 6
            Me.barButtonItem3.ImageIndex = 4
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' barCheckItem3
            ' 
            Me.barCheckItem3.BindableChecked = True
            Me.barCheckItem3.Caption = "Attachment"
            Me.barCheckItem3.Checked = True
            Me.barCheckItem3.Id = 5
            Me.barCheckItem3.ImageIndex = 9
            Me.barCheckItem3.Name = "barCheckItem3"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Preview"
            Me.barButtonItem1.Id = 3
            Me.barButtonItem1.ImageIndex = 7
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "Print"
            Me.barButtonItem2.Id = 4
            Me.barButtonItem2.ImageIndex = 8
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barManager1
            ' 
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Images = Me.imageCollection1
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barSubItem1, Me.barCheckItem1, Me.barCheckItem2, Me.barButtonItem1, Me.barButtonItem2, Me.barCheckItem3, Me.barButtonItem3})
            Me.barManager1.MaxItemId = 7
            ' 
            ' AlertControlTutorial
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "AlertControlTutorial"
            Me.Size = New System.Drawing.Size(713, 535)
            DirectCast(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            Me.xtraTabPage1.PerformLayout()
            DirectCast(Me.sePostponedFormCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceWidth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            DirectCast(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents alertControl1 As DevExpress.XtraBars.Alerter.AlertControl
        Private WithEvents button1 As DevExpress.XtraEditors.SimpleButton
        Private groupControl1 As DevExpress.XtraEditors.GroupControl
        Private WithEvents alertControlProperties1 As AlertControlProperties
        Private imageCollection1 As DevExpress.Utils.ImageCollection
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private popupMenu1 As DevExpress.XtraBars.PopupMenu
        Private barSubItem1 As DevExpress.XtraBars.BarSubItem
        Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem
        Private barCheckItem2 As DevExpress.XtraBars.BarCheckItem
        Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
        Private barCheckItem3 As DevExpress.XtraBars.BarCheckItem
        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
        Private groupControl2 As DevExpress.XtraEditors.GroupControl
        Private alertInfoProperties1 As AlertInfoProperties
        Private ceHeight As DevExpress.XtraEditors.SpinEdit
        Private ceWidth As DevExpress.XtraEditors.SpinEdit
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
        Private labelControl3 As DevExpress.XtraEditors.LabelControl
        Private sePostponedFormCount As DevExpress.XtraEditors.SpinEdit
        Private xtraTabControl1 As XtraTab.XtraTabControl
        Private xtraTabPage1 As XtraTab.XtraTabPage

    End Class
End Namespace
