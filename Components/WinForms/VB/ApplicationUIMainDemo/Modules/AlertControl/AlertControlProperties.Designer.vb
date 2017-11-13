Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class AlertControlProperties
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
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.seAutoFormDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.icbControlBoxPosition = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbFormDisplaySpeed = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.icbFormLocation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.ceAllowHtmlText = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowCloseButton = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowPinButton = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowPopupMenu = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowTooltips = New DevExpress.XtraEditors.CheckEdit()
            Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
            Me.ccbeButtons = New DevExpress.XtraEditors.CheckedComboBoxEdit()
            Me.ceAutoHeight = New DevExpress.XtraEditors.CheckEdit()
            Me.icbShowingEffect = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
            Me.seFormMaxCount = New DevExpress.XtraEditors.SpinEdit()
            Me.ceAutoClose = New DevExpress.XtraEditors.CheckEdit()
            CType(Me.seAutoFormDelay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icbControlBoxPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icbFormDisplaySpeed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icbFormLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAllowHtmlText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowCloseButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowPinButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowPopupMenu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowTooltips.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ccbeButtons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAutoHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icbShowingEffect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seFormMaxCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAutoClose.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(14, 14)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(84, 13)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "Auto Form Delay:"
            '
            'seAutoFormDelay
            '
            Me.seAutoFormDelay.EditValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seAutoFormDelay.Location = New System.Drawing.Point(136, 11)
            Me.seAutoFormDelay.Name = "seAutoFormDelay"
            Me.seAutoFormDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seAutoFormDelay.Properties.IsFloatValue = False
            Me.seAutoFormDelay.Properties.Mask.EditMask = "N00"
            Me.seAutoFormDelay.Properties.MaxValue = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.seAutoFormDelay.Properties.MinValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seAutoFormDelay.Size = New System.Drawing.Size(172, 20)
            Me.seAutoFormDelay.TabIndex = 0
            '
            'labelControl2
            '
            Me.labelControl2.Location = New System.Drawing.Point(14, 40)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(100, 13)
            Me.labelControl2.TabIndex = 1
            Me.labelControl2.Text = "Control Box Position:"
            '
            'icbControlBoxPosition
            '
            Me.icbControlBoxPosition.Location = New System.Drawing.Point(136, 37)
            Me.icbControlBoxPosition.Name = "icbControlBoxPosition"
            Me.icbControlBoxPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbControlBoxPosition.Size = New System.Drawing.Size(172, 20)
            Me.icbControlBoxPosition.TabIndex = 1
            '
            'icbFormDisplaySpeed
            '
            Me.icbFormDisplaySpeed.Location = New System.Drawing.Point(136, 63)
            Me.icbFormDisplaySpeed.Name = "icbFormDisplaySpeed"
            Me.icbFormDisplaySpeed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbFormDisplaySpeed.Size = New System.Drawing.Size(172, 20)
            Me.icbFormDisplaySpeed.TabIndex = 2
            '
            'labelControl3
            '
            Me.labelControl3.Location = New System.Drawing.Point(14, 66)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(98, 13)
            Me.labelControl3.TabIndex = 2
            Me.labelControl3.Text = "Form Display Speed:"
            '
            'icbFormLocation
            '
            Me.icbFormLocation.Location = New System.Drawing.Point(136, 89)
            Me.icbFormLocation.Name = "icbFormLocation"
            Me.icbFormLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbFormLocation.Size = New System.Drawing.Size(172, 20)
            Me.icbFormLocation.TabIndex = 3
            '
            'labelControl4
            '
            Me.labelControl4.Location = New System.Drawing.Point(14, 92)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(71, 13)
            Me.labelControl4.TabIndex = 3
            Me.labelControl4.Text = "Form Location:"
            '
            'ceAllowHtmlText
            '
            Me.ceAllowHtmlText.Location = New System.Drawing.Point(134, 196)
            Me.ceAllowHtmlText.Name = "ceAllowHtmlText"
            Me.ceAllowHtmlText.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.ceAllowHtmlText.Properties.Appearance.Options.UseFont = True
            Me.ceAllowHtmlText.Properties.Caption = "Allow Html Text"
            Me.ceAllowHtmlText.Size = New System.Drawing.Size(174, 19)
            Me.ceAllowHtmlText.TabIndex = 7
            '
            'ceShowCloseButton
            '
            Me.ceShowCloseButton.Location = New System.Drawing.Point(134, 221)
            Me.ceShowCloseButton.Name = "ceShowCloseButton"
            Me.ceShowCloseButton.Properties.Caption = "Show Close Button"
            Me.ceShowCloseButton.Size = New System.Drawing.Size(174, 19)
            Me.ceShowCloseButton.TabIndex = 8
            '
            'ceShowPinButton
            '
            Me.ceShowPinButton.Location = New System.Drawing.Point(134, 246)
            Me.ceShowPinButton.Name = "ceShowPinButton"
            Me.ceShowPinButton.Properties.Caption = "Show Pin Button"
            Me.ceShowPinButton.Size = New System.Drawing.Size(174, 19)
            Me.ceShowPinButton.TabIndex = 9
            '
            'ceShowPopupMenu
            '
            Me.ceShowPopupMenu.Location = New System.Drawing.Point(134, 271)
            Me.ceShowPopupMenu.Name = "ceShowPopupMenu"
            Me.ceShowPopupMenu.Properties.Caption = "Show Popup Menu"
            Me.ceShowPopupMenu.Size = New System.Drawing.Size(174, 19)
            Me.ceShowPopupMenu.TabIndex = 10
            '
            'ceShowTooltips
            '
            Me.ceShowTooltips.Location = New System.Drawing.Point(134, 296)
            Me.ceShowTooltips.Name = "ceShowTooltips"
            Me.ceShowTooltips.Properties.Caption = "Show Tooltips"
            Me.ceShowTooltips.Size = New System.Drawing.Size(174, 19)
            Me.ceShowTooltips.TabIndex = 11
            '
            'labelControl6
            '
            Me.labelControl6.Location = New System.Drawing.Point(14, 144)
            Me.labelControl6.Name = "labelControl6"
            Me.labelControl6.Size = New System.Drawing.Size(41, 13)
            Me.labelControl6.TabIndex = 5
            Me.labelControl6.Text = "Buttons:"
            '
            'ccbeButtons
            '
            Me.ccbeButtons.Location = New System.Drawing.Point(136, 141)
            Me.ccbeButtons.Name = "ccbeButtons"
            Me.ccbeButtons.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ccbeButtons.Size = New System.Drawing.Size(172, 20)
            Me.ccbeButtons.TabIndex = 5
            '
            'ceAutoHeight
            '
            Me.ceAutoHeight.Location = New System.Drawing.Point(134, 320)
            Me.ceAutoHeight.Name = "ceAutoHeight"
            Me.ceAutoHeight.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceAutoHeight.Properties.Caption = "<b>Auto</b> Height"
            Me.ceAutoHeight.Size = New System.Drawing.Size(174, 19)
            Me.ceAutoHeight.TabIndex = 12
            '
            'icbShowingEffect
            '
            Me.icbShowingEffect.Location = New System.Drawing.Point(136, 115)
            Me.icbShowingEffect.Name = "icbShowingEffect"
            Me.icbShowingEffect.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowingEffect.Size = New System.Drawing.Size(172, 20)
            Me.icbShowingEffect.TabIndex = 4
            '
            'labelControl5
            '
            Me.labelControl5.Location = New System.Drawing.Point(14, 118)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Size = New System.Drawing.Size(103, 13)
            Me.labelControl5.TabIndex = 18
            Me.labelControl5.Text = "Form Showing Effect:"
            '
            'labelControl7
            '
            Me.labelControl7.Location = New System.Drawing.Point(14, 170)
            Me.labelControl7.Name = "labelControl7"
            Me.labelControl7.Size = New System.Drawing.Size(83, 13)
            Me.labelControl7.TabIndex = 19
            Me.labelControl7.Text = "Form Max Count:"
            '
            'seFormMaxCount
            '
            Me.seFormMaxCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seFormMaxCount.Location = New System.Drawing.Point(136, 167)
            Me.seFormMaxCount.Name = "seFormMaxCount"
            Me.seFormMaxCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seFormMaxCount.Properties.IsFloatValue = False
            Me.seFormMaxCount.Properties.Mask.EditMask = "N00"
            Me.seFormMaxCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.seFormMaxCount.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seFormMaxCount.Size = New System.Drawing.Size(172, 20)
            Me.seFormMaxCount.TabIndex = 6
            '
            'ceAutoClose
            '
            Me.ceAutoClose.Location = New System.Drawing.Point(134, 345)
            Me.ceAutoClose.Name = "ceAutoClose"
            Me.ceAutoClose.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceAutoClose.Properties.Caption = "Auto Close Form On Click "
            Me.ceAutoClose.Size = New System.Drawing.Size(175, 19)
            Me.ceAutoClose.TabIndex = 20
            '
            'AlertControlProperties
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ceAutoClose)
            Me.Controls.Add(Me.labelControl7)
            Me.Controls.Add(Me.icbShowingEffect)
            Me.Controls.Add(Me.labelControl5)
            Me.Controls.Add(Me.ceAutoHeight)
            Me.Controls.Add(Me.ccbeButtons)
            Me.Controls.Add(Me.labelControl6)
            Me.Controls.Add(Me.ceShowTooltips)
            Me.Controls.Add(Me.ceShowPopupMenu)
            Me.Controls.Add(Me.ceShowPinButton)
            Me.Controls.Add(Me.ceShowCloseButton)
            Me.Controls.Add(Me.ceAllowHtmlText)
            Me.Controls.Add(Me.icbFormLocation)
            Me.Controls.Add(Me.labelControl4)
            Me.Controls.Add(Me.icbFormDisplaySpeed)
            Me.Controls.Add(Me.labelControl3)
            Me.Controls.Add(Me.icbControlBoxPosition)
            Me.Controls.Add(Me.labelControl2)
            Me.Controls.Add(Me.seAutoFormDelay)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.seFormMaxCount)
            Me.Name = "AlertControlProperties"
            Me.Size = New System.Drawing.Size(321, 379)
            CType(Me.seAutoFormDelay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icbControlBoxPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icbFormDisplaySpeed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icbFormLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAllowHtmlText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowCloseButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowPinButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowPopupMenu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowTooltips.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ccbeButtons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAutoHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icbShowingEffect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seFormMaxCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAutoClose.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents seAutoFormDelay As DevExpress.XtraEditors.SpinEdit
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
        Private WithEvents icbControlBoxPosition As DevExpress.XtraEditors.ImageComboBoxEdit
        Private WithEvents icbFormDisplaySpeed As DevExpress.XtraEditors.ImageComboBoxEdit
        Private labelControl3 As DevExpress.XtraEditors.LabelControl
        Private WithEvents icbFormLocation As DevExpress.XtraEditors.ImageComboBoxEdit
        Private labelControl4 As DevExpress.XtraEditors.LabelControl
        Private WithEvents ceAllowHtmlText As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceShowCloseButton As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceShowPinButton As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceShowPopupMenu As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceShowTooltips As DevExpress.XtraEditors.CheckEdit
        Private labelControl6 As DevExpress.XtraEditors.LabelControl
        Private WithEvents ccbeButtons As DevExpress.XtraEditors.CheckedComboBoxEdit
        Private WithEvents ceAutoHeight As DevExpress.XtraEditors.CheckEdit
        Private WithEvents icbShowingEffect As DevExpress.XtraEditors.ImageComboBoxEdit
        Private labelControl5 As DevExpress.XtraEditors.LabelControl
        Private labelControl7 As DevExpress.XtraEditors.LabelControl
        Private WithEvents seFormMaxCount As DevExpress.XtraEditors.SpinEdit
        Private ceAutoClose As XtraEditors.CheckEdit
    End Class
End Namespace
