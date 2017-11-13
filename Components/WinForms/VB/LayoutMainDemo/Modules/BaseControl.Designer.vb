Namespace DevExpress.XtraLayout.Demos
    Partial Public Class BaseTutorialControl
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
            Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.lcTitle = New DevExpress.XtraLayout.LayoutControl()
            Me.snapModeCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.showPropertyGridCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.showAdornerLayerCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.quickCustomizationCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.allowItemSkinningCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.highlightFocusedItemCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.sbCustomize = New DevExpress.XtraEditors.SimpleButton()
            Me.cbFiles = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.allowExpandAnimationCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.lcMainGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.quickCustomizationLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.showAdornerLayerLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.allowItemSkinningLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.highlightFocusedItemCheckEditLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcCustomizeButton = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.allowExpandAnimationLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.showPropertyGridLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.snapModeLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcItemCombo = New DevExpress.XtraLayout.LayoutControlItem()
            Me.tabTransitionAnimationCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.allowExpandAnimationLCI1 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            DirectCast(Me.lcTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcTitle.SuspendLayout()
            DirectCast(Me.snapModeCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.showPropertyGridCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.showAdornerLayerCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.quickCustomizationCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.allowItemSkinningCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.highlightFocusedItemCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbFiles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.allowExpandAnimationCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lcMainGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.quickCustomizationLCI, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.showAdornerLayerLCI, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.allowItemSkinningLCI, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.highlightFocusedItemCheckEditLCI, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lcCustomizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.allowExpandAnimationLCI, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.showPropertyGridLCI, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.snapModeLCI, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lcItemCombo, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tabTransitionAnimationCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.allowExpandAnimationLCI1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panelControl1.Location = New System.Drawing.Point(468, 0)
            Me.panelControl1.MaximumSize = New System.Drawing.Size(10, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(10, 396)
            Me.panelControl1.TabIndex = 3
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.AllowResize = False
            Me.navigationPane1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right
            Me.navigationPane1.Location = New System.Drawing.Point(478, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(236, 396)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(236, 396)
            Me.navigationPane1.TabIndex = 2
            Me.navigationPane1.Text = "navigationPane1"
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.lcTitle)
            Me.navigationPage1.ImageUri.Uri = "Properties;Size16x16;Office2013"
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(186, 336)
            ' 
            ' lcTitle
            ' 
            Me.lcTitle.AllowCustomization = False
            Me.lcTitle.Controls.Add(Me.snapModeCheckEdit)
            Me.lcTitle.Controls.Add(Me.showPropertyGridCheckEdit)
            Me.lcTitle.Controls.Add(Me.showAdornerLayerCheckEdit)
            Me.lcTitle.Controls.Add(Me.quickCustomizationCheckEdit)
            Me.lcTitle.Controls.Add(Me.allowItemSkinningCheckEdit)
            Me.lcTitle.Controls.Add(Me.highlightFocusedItemCheckEdit)
            Me.lcTitle.Controls.Add(Me.sbCustomize)
            Me.lcTitle.Controls.Add(Me.cbFiles)
            Me.lcTitle.Controls.Add(Me.allowExpandAnimationCheckEdit)
            Me.lcTitle.Controls.Add(Me.tabTransitionAnimationCheckEdit)
            Me.lcTitle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lcTitle.Location = New System.Drawing.Point(0, 0)
            Me.lcTitle.Name = "lcTitle"
            Me.lcTitle.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-1299, 548, 715, 579)
            Me.lcTitle.OptionsView.AllowItemSkinning = False
            Me.lcTitle.OptionsView.UseParentAutoScaleFactor = True
            Me.lcTitle.OptionsView.UseSkinIndents = False
            Me.lcTitle.Root = Me.lcMainGroup
            Me.lcTitle.Size = New System.Drawing.Size(186, 336)
            Me.lcTitle.TabIndex = 1
            ' 
            ' snapModeCheckEdit
            ' 
            Me.snapModeCheckEdit.EditValue = True
            Me.snapModeCheckEdit.Location = New System.Drawing.Point(2, 233)
            Me.snapModeCheckEdit.Name = "snapModeCheckEdit"
            Me.snapModeCheckEdit.Properties.Caption = "Snap Customization Form"
            Me.snapModeCheckEdit.Size = New System.Drawing.Size(182, 19)
            Me.snapModeCheckEdit.StyleController = Me.lcTitle
            Me.snapModeCheckEdit.TabIndex = 14
            '			Me.snapModeCheckEdit.CheckedChanged += New System.EventHandler(Me.snapModeCheckEdit_CheckedChanged)
            ' 
            ' showPropertyGridCheckEdit
            ' 
            Me.showPropertyGridCheckEdit.EditValue = True
            Me.showPropertyGridCheckEdit.Location = New System.Drawing.Point(2, 206)
            Me.showPropertyGridCheckEdit.Name = "showPropertyGridCheckEdit"
            Me.showPropertyGridCheckEdit.Properties.Caption = "Show PropertyGrid"
            Me.showPropertyGridCheckEdit.Size = New System.Drawing.Size(182, 19)
            Me.showPropertyGridCheckEdit.StyleController = Me.lcTitle
            Me.showPropertyGridCheckEdit.TabIndex = 13
            '			Me.showPropertyGridCheckEdit.CheckedChanged += New System.EventHandler(Me.showPropertyGridCheckEdit_CheckedChanged)
            ' 
            ' showAdornerLayerCheckEdit
            ' 
            Me.showAdornerLayerCheckEdit.Location = New System.Drawing.Point(2, 125)
            Me.showAdornerLayerCheckEdit.Name = "showAdornerLayerCheckEdit"
            Me.showAdornerLayerCheckEdit.Properties.Caption = "Show Adorner Layer"
            Me.showAdornerLayerCheckEdit.Size = New System.Drawing.Size(182, 19)
            Me.showAdornerLayerCheckEdit.StyleController = Me.lcTitle
            Me.showAdornerLayerCheckEdit.TabIndex = 12
            '			Me.showAdornerLayerCheckEdit.CheckedChanged += New System.EventHandler(Me.checkEdit6_CheckedChanged)
            ' 
            ' quickCustomizationCheckEdit
            ' 
            Me.quickCustomizationCheckEdit.Location = New System.Drawing.Point(2, 44)
            Me.quickCustomizationCheckEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.quickCustomizationCheckEdit.Name = "quickCustomizationCheckEdit"
            Me.quickCustomizationCheckEdit.Properties.Caption = "Quick Customization Mode"
            Me.quickCustomizationCheckEdit.Size = New System.Drawing.Size(182, 19)
            Me.quickCustomizationCheckEdit.StyleController = Me.lcTitle
            Me.quickCustomizationCheckEdit.TabIndex = 11
            '			Me.quickCustomizationCheckEdit.CheckedChanged += New System.EventHandler(Me.checkEdit5_CheckedChanged)
            ' 
            ' allowItemSkinningCheckEdit
            ' 
            Me.allowItemSkinningCheckEdit.EditValue = True
            Me.allowItemSkinningCheckEdit.Location = New System.Drawing.Point(2, 71)
            Me.allowItemSkinningCheckEdit.Name = "allowItemSkinningCheckEdit"
            Me.allowItemSkinningCheckEdit.Properties.Caption = "Allow Item Skinning"
            Me.allowItemSkinningCheckEdit.Size = New System.Drawing.Size(182, 19)
            Me.allowItemSkinningCheckEdit.StyleController = Me.lcTitle
            Me.allowItemSkinningCheckEdit.TabIndex = 9
            '			Me.allowItemSkinningCheckEdit.CheckedChanged += New System.EventHandler(Me.allowItemSkinningCheckEdit_CheckedChanged)
            ' 
            ' highlightFocusedItemCheckEdit
            ' 
            Me.highlightFocusedItemCheckEdit.Location = New System.Drawing.Point(2, 98)
            Me.highlightFocusedItemCheckEdit.Name = "highlightFocusedItemCheckEdit"
            Me.highlightFocusedItemCheckEdit.Properties.Caption = "Highlight Focused Item"
            Me.highlightFocusedItemCheckEdit.Size = New System.Drawing.Size(182, 19)
            Me.highlightFocusedItemCheckEdit.StyleController = Me.lcTitle
            Me.highlightFocusedItemCheckEdit.TabIndex = 8
            '			Me.highlightFocusedItemCheckEdit.CheckedChanged += New System.EventHandler(Me.highlightFocusedItemCheckEdit_CheckedChanged)
            ' 
            ' sbCustomize
            ' 
            Me.sbCustomize.Location = New System.Drawing.Point(1, 257)
            Me.sbCustomize.Name = "sbCustomize"
            Me.sbCustomize.Size = New System.Drawing.Size(184, 22)
            Me.sbCustomize.StyleController = Me.lcTitle
            Me.sbCustomize.TabIndex = 6
            Me.sbCustomize.Text = "Customize Layout"
            '			Me.sbCustomize.Click += New System.EventHandler(Me.sbCustomize_Click)
            ' 
            ' cbFiles
            ' 
            Me.cbFiles.EditValue = ""
            Me.cbFiles.Location = New System.Drawing.Point(1, 19)
            Me.cbFiles.Name = "cbFiles"
            Me.cbFiles.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbFiles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Load Layout", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Load Layout", Nothing, Nothing, False)
            })
            Me.cbFiles.Size = New System.Drawing.Size(184, 20)
            Me.cbFiles.StyleController = Me.lcTitle
            Me.cbFiles.TabIndex = 3
            '			Me.cbFiles.EditValueChanged += New System.EventHandler(Me.cbFiles_EditValueChanged)
            ' 
            ' allowExpandAnimationCheckEdit
            ' 
            Me.allowExpandAnimationCheckEdit.EditValue = True
            Me.allowExpandAnimationCheckEdit.Location = New System.Drawing.Point(2, 152)
            Me.allowExpandAnimationCheckEdit.Name = "allowExpandAnimationCheckEdit"
            Me.allowExpandAnimationCheckEdit.Properties.Caption = "Allow Group Expand Animation"
            Me.allowExpandAnimationCheckEdit.Size = New System.Drawing.Size(182, 19)
            Me.allowExpandAnimationCheckEdit.StyleController = Me.lcTitle
            Me.allowExpandAnimationCheckEdit.TabIndex = 12
            '			Me.allowExpandAnimationCheckEdit.CheckedChanged += New System.EventHandler(Me.allowExpandAnimationCheckEdit_CheckedChanged)
            ' 
            ' lcMainGroup
            ' 
            Me.lcMainGroup.CustomizationFormText = "Select xml file and restore layout"
            Me.lcMainGroup.GroupBordersVisible = False
            Me.lcMainGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1, Me.lcItemCombo})
            Me.lcMainGroup.Location = New System.Drawing.Point(0, 0)
            Me.lcMainGroup.Name = "Root"
            Me.lcMainGroup.OptionsItemText.TextToControlDistance = 5
            Me.lcMainGroup.Size = New System.Drawing.Size(186, 336)
            Me.lcMainGroup.Text = "Select xml file and restore layout"
            Me.lcMainGroup.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "Paint options"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.quickCustomizationLCI, Me.showAdornerLayerLCI, Me.allowItemSkinningLCI, Me.highlightFocusedItemCheckEditLCI, Me.lcCustomizeButton, Me.emptySpaceItem1, Me.allowExpandAnimationLCI, Me.showPropertyGridLCI, Me.snapModeLCI, Me.allowExpandAnimationLCI1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5
            Me.layoutControlGroup1.Size = New System.Drawing.Size(186, 296)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Paint options"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' quickCustomizationLCI
            ' 
            Me.quickCustomizationLCI.Control = Me.quickCustomizationCheckEdit
            Me.quickCustomizationLCI.CustomizationFormText = "quickCustomizationLCI"
            Me.quickCustomizationLCI.Location = New System.Drawing.Point(0, 0)
            Me.quickCustomizationLCI.Name = "quickCustomizationLCI"
            Me.quickCustomizationLCI.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.quickCustomizationLCI.Size = New System.Drawing.Size(186, 27)
            Me.quickCustomizationLCI.TextSize = New System.Drawing.Size(0, 0)
            Me.quickCustomizationLCI.TextVisible = False
            ' 
            ' showAdornerLayerLCI
            ' 
            Me.showAdornerLayerLCI.Control = Me.showAdornerLayerCheckEdit
            Me.showAdornerLayerLCI.Location = New System.Drawing.Point(0, 81)
            Me.showAdornerLayerLCI.Name = "showAdornerLayerLCI"
            Me.showAdornerLayerLCI.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.showAdornerLayerLCI.Size = New System.Drawing.Size(186, 27)
            Me.showAdornerLayerLCI.TextSize = New System.Drawing.Size(0, 0)
            Me.showAdornerLayerLCI.TextVisible = False
            ' 
            ' allowItemSkinningLCI
            ' 
            Me.allowItemSkinningLCI.Control = Me.allowItemSkinningCheckEdit
            Me.allowItemSkinningLCI.CustomizationFormText = "allowItemSkinningLCI"
            Me.allowItemSkinningLCI.Location = New System.Drawing.Point(0, 27)
            Me.allowItemSkinningLCI.Name = "allowItemSkinningLCI"
            Me.allowItemSkinningLCI.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.allowItemSkinningLCI.Size = New System.Drawing.Size(186, 27)
            Me.allowItemSkinningLCI.TextSize = New System.Drawing.Size(0, 0)
            Me.allowItemSkinningLCI.TextVisible = False
            ' 
            ' highlightFocusedItemCheckEditLCI
            ' 
            Me.highlightFocusedItemCheckEditLCI.Control = Me.highlightFocusedItemCheckEdit
            Me.highlightFocusedItemCheckEditLCI.CustomizationFormText = "highlightFocusedItemCheckEditLCI"
            Me.highlightFocusedItemCheckEditLCI.Location = New System.Drawing.Point(0, 54)
            Me.highlightFocusedItemCheckEditLCI.Name = "highlightFocusedItemCheckEditLCI"
            Me.highlightFocusedItemCheckEditLCI.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.highlightFocusedItemCheckEditLCI.Size = New System.Drawing.Size(186, 27)
            Me.highlightFocusedItemCheckEditLCI.TextSize = New System.Drawing.Size(0, 0)
            Me.highlightFocusedItemCheckEditLCI.TextVisible = False
            ' 
            ' lcCustomizeButton
            ' 
            Me.lcCustomizeButton.Control = Me.sbCustomize
            Me.lcCustomizeButton.CustomizationFormText = "lcCustomizeButton"
            Me.lcCustomizeButton.Location = New System.Drawing.Point(0, 216)
            Me.lcCustomizeButton.Name = "lcCustomizeButton"
            Me.lcCustomizeButton.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.lcCustomizeButton.Size = New System.Drawing.Size(186, 24)
            Me.lcCustomizeButton.TextSize = New System.Drawing.Size(0, 0)
            Me.lcCustomizeButton.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 240)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(186, 56)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' allowExpandAnimationLCI
            ' 
            Me.allowExpandAnimationLCI.Control = Me.allowExpandAnimationCheckEdit
            Me.allowExpandAnimationLCI.CustomizationFormText = "showAdornerLayerLCI"
            Me.allowExpandAnimationLCI.Location = New System.Drawing.Point(0, 108)
            Me.allowExpandAnimationLCI.Name = "allowExpandAnimationLCI"
            Me.allowExpandAnimationLCI.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.allowExpandAnimationLCI.Size = New System.Drawing.Size(186, 27)
            Me.allowExpandAnimationLCI.Text = "showAdornerLayerLCI"
            Me.allowExpandAnimationLCI.TextSize = New System.Drawing.Size(0, 0)
            Me.allowExpandAnimationLCI.TextVisible = False
            ' 
            ' showPropertyGridLCI
            ' 
            Me.showPropertyGridLCI.Control = Me.showPropertyGridCheckEdit
            Me.showPropertyGridLCI.Location = New System.Drawing.Point(0, 162)
            Me.showPropertyGridLCI.Name = "showPropertyGridLCI"
            Me.showPropertyGridLCI.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.showPropertyGridLCI.Size = New System.Drawing.Size(186, 27)
            Me.showPropertyGridLCI.TextSize = New System.Drawing.Size(0, 0)
            Me.showPropertyGridLCI.TextVisible = False
            ' 
            ' snapModeLCI
            ' 
            Me.snapModeLCI.Control = Me.snapModeCheckEdit
            Me.snapModeLCI.Location = New System.Drawing.Point(0, 189)
            Me.snapModeLCI.Name = "snapModeLCI"
            Me.snapModeLCI.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.snapModeLCI.Size = New System.Drawing.Size(186, 27)
            Me.snapModeLCI.TextSize = New System.Drawing.Size(0, 0)
            Me.snapModeLCI.TextVisible = False
            ' 
            ' lcItemCombo
            ' 
            Me.lcItemCombo.Control = Me.cbFiles
            Me.lcItemCombo.CustomizationFormText = "Xml files:"
            Me.lcItemCombo.Location = New System.Drawing.Point(0, 0)
            Me.lcItemCombo.Name = "lcItemCombo"
            Me.lcItemCombo.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.lcItemCombo.Size = New System.Drawing.Size(186, 40)
            Me.lcItemCombo.Text = "Xml files:"
            Me.lcItemCombo.TextLocation = DevExpress.Utils.Locations.Top
            Me.lcItemCombo.TextSize = New System.Drawing.Size(42, 13)
            ' 
            ' tabTransitionAnimationCheckEdit
            ' 
            Me.tabTransitionAnimationCheckEdit.EditValue = True
            Me.tabTransitionAnimationCheckEdit.Location = New System.Drawing.Point(2, 179)
            Me.tabTransitionAnimationCheckEdit.Name = "tabTransitionAnimationCheckEdit"
            Me.tabTransitionAnimationCheckEdit.Properties.Caption = "Allow Tab Transition Animation"
            Me.tabTransitionAnimationCheckEdit.Size = New System.Drawing.Size(182, 19)
            Me.tabTransitionAnimationCheckEdit.StyleController = Me.lcTitle
            Me.tabTransitionAnimationCheckEdit.TabIndex = 12
            '			Me.tabTransitionAnimationCheckEdit.CheckedChanged += New System.EventHandler(Me.tabTransitionAnimation_CheckedChanged)
            ' 
            ' allowExpandAnimationLCI1
            ' 
            Me.allowExpandAnimationLCI1.Control = Me.tabTransitionAnimationCheckEdit
            Me.allowExpandAnimationLCI1.CustomizationFormText = "showAdornerLayerLCI"
            Me.allowExpandAnimationLCI1.Location = New System.Drawing.Point(0, 135)
            Me.allowExpandAnimationLCI1.Name = "allowExpandAnimationLCI1"
            Me.allowExpandAnimationLCI1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.allowExpandAnimationLCI1.Size = New System.Drawing.Size(186, 27)
            Me.allowExpandAnimationLCI1.Text = "showAdornerLayerLCI"
            Me.allowExpandAnimationLCI1.TextSize = New System.Drawing.Size(0, 0)
            Me.allowExpandAnimationLCI1.TextVisible = False
            ' 
            ' BaseTutorialControl
            ' 
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "BaseTutorialControl"
            Me.Size = New System.Drawing.Size(714, 396)
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            DirectCast(Me.lcTitle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcTitle.ResumeLayout(False)
            DirectCast(Me.snapModeCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.showPropertyGridCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.showAdornerLayerCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.quickCustomizationCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.allowItemSkinningCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.highlightFocusedItemCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbFiles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.allowExpandAnimationCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lcMainGroup, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.quickCustomizationLCI, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.showAdornerLayerLCI, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.allowItemSkinningLCI, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.highlightFocusedItemCheckEditLCI, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lcCustomizeButton, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.allowExpandAnimationLCI, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.showPropertyGridLCI, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.snapModeLCI, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lcItemCombo, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tabTransitionAnimationCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.allowExpandAnimationLCI1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private lcMainGroup As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents cbFiles As DevExpress.XtraEditors.ComboBoxEdit
        Private lcTitle As DevExpress.XtraLayout.LayoutControl
        Private WithEvents sbCustomize As DevExpress.XtraEditors.SimpleButton
        Private WithEvents highlightFocusedItemCheckEdit As DevExpress.XtraEditors.CheckEdit
        Private WithEvents allowItemSkinningCheckEdit As DevExpress.XtraEditors.CheckEdit
        Private components As System.ComponentModel.IContainer = Nothing
        Private WithEvents quickCustomizationCheckEdit As XtraEditors.CheckEdit
        Private WithEvents showAdornerLayerCheckEdit As XtraEditors.CheckEdit
        Private layoutControlGroup1 As LayoutControlGroup
        Private quickCustomizationLCI As LayoutControlItem
        Private showAdornerLayerLCI As LayoutControlItem
        Private allowItemSkinningLCI As LayoutControlItem
        Private highlightFocusedItemCheckEditLCI As LayoutControlItem
        Private lcCustomizeButton As LayoutControlItem
        Private lcItemCombo As LayoutControlItem
        Private navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private panelControl1 As XtraEditors.PanelControl
        Private emptySpaceItem1 As EmptySpaceItem
        Private WithEvents allowExpandAnimationCheckEdit As XtraEditors.CheckEdit
        Private allowExpandAnimationLCI As LayoutControlItem
        Private WithEvents showPropertyGridCheckEdit As XtraEditors.CheckEdit
        Private showPropertyGridLCI As LayoutControlItem
        Private WithEvents snapModeCheckEdit As XtraEditors.CheckEdit
        Private snapModeLCI As LayoutControlItem
        Private WithEvents tabTransitionAnimationCheckEdit As XtraEditors.CheckEdit
        Private allowExpandAnimationLCI1 As LayoutControlItem
    End Class
End Namespace
