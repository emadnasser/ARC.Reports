Namespace DevExpress.MailClient.Win.Forms
	Partial Public Class frmFeed
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmFeed))
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.heLink = New DevExpress.XtraEditors.HyperLinkEdit()
			Me.cbeGroup = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.teCaption = New DevExpress.XtraEditors.TextEdit()
			Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.sbOK = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.heLink.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbeGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teCaption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.FontSizeDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.FontSizeDelta"), Integer))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.FontStyleDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.GradientMode = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.Image = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.Image"), System.Drawing.Image))
            Me.layoutControl1.Appearance.DisabledLayoutItem.FontSizeDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.FontSizeDelta"), Integer))
            Me.layoutControl1.Appearance.DisabledLayoutItem.FontStyleDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.Appearance.DisabledLayoutItem.GradientMode = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.Appearance.DisabledLayoutItem.Image = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.Image"), System.Drawing.Image))
            Me.layoutControl1.Controls.Add(Me.heLink)
            Me.layoutControl1.Controls.Add(Me.cbeGroup)
            Me.layoutControl1.Controls.Add(Me.teCaption)
            Me.layoutControl1.Controls.Add(Me.sbCancel)
            Me.layoutControl1.Controls.Add(Me.sbOK)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(738, 385, 450, 350)
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.FontSizeDelta = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.FontSizeDelta"), Integer))
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.FontStyleDelta = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.GradientMode = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Image = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.Image"), System.Drawing.Image))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.FontSizeDelta = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.FontStyleDelta = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.GradientMode = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.Image = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.Image"), System.Drawing.Image))
            'this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' heLink
            ' 
            resources.ApplyResources(Me.heLink, "heLink")
            Me.heLink.Name = "heLink"
            Me.heLink.Properties.AccessibleDescription = resources.GetString("heLink.Properties.AccessibleDescription")
            Me.heLink.Properties.AccessibleName = resources.GetString("heLink.Properties.AccessibleName")
            Me.heLink.Properties.AutoHeight = (CType(resources.GetObject("heLink.Properties.AutoHeight"), Boolean))
            Me.heLink.Properties.Caption = resources.GetString("heLink.Properties.Caption")
            Me.heLink.Properties.Mask.AutoComplete = (CType(resources.GetObject("heLink.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.heLink.Properties.Mask.BeepOnError = (CType(resources.GetObject("heLink.Properties.Mask.BeepOnError"), Boolean))
            Me.heLink.Properties.Mask.EditMask = resources.GetString("heLink.Properties.Mask.EditMask")
            Me.heLink.Properties.Mask.IgnoreMaskBlank = (CType(resources.GetObject("heLink.Properties.Mask.IgnoreMaskBlank"), Boolean))
            Me.heLink.Properties.Mask.MaskType = (CType(resources.GetObject("heLink.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.heLink.Properties.Mask.PlaceHolder = (CType(resources.GetObject("heLink.Properties.Mask.PlaceHolder"), Char))
            Me.heLink.Properties.Mask.SaveLiteral = (CType(resources.GetObject("heLink.Properties.Mask.SaveLiteral"), Boolean))
            Me.heLink.Properties.Mask.ShowPlaceHolders = (CType(resources.GetObject("heLink.Properties.Mask.ShowPlaceHolders"), Boolean))
            Me.heLink.Properties.Mask.UseMaskAsDisplayFormat = (CType(resources.GetObject("heLink.Properties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.heLink.Properties.NullValuePrompt = resources.GetString("heLink.Properties.NullValuePrompt")
            Me.heLink.Properties.NullValuePromptShowForEmptyValue = (CType(resources.GetObject("heLink.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.heLink.Properties.SingleClick = False
            Me.heLink.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.heLink.StyleController = Me.layoutControl1
            ' 
            ' cbeGroup
            ' 
            resources.ApplyResources(Me.cbeGroup, "cbeGroup")
            Me.cbeGroup.Name = "cbeGroup"
            Me.cbeGroup.Properties.AccessibleDescription = resources.GetString("cbeGroup.Properties.AccessibleDescription")
            Me.cbeGroup.Properties.AccessibleName = resources.GetString("cbeGroup.Properties.AccessibleName")
            Me.cbeGroup.Properties.AutoHeight = (CType(resources.GetObject("cbeGroup.Properties.AutoHeight"), Boolean))
            Me.cbeGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("cbeGroup.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.cbeGroup.Properties.NullValuePrompt = resources.GetString("cbeGroup.Properties.NullValuePrompt")
            Me.cbeGroup.Properties.NullValuePromptShowForEmptyValue = (CType(resources.GetObject("cbeGroup.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.cbeGroup.StyleController = Me.layoutControl1
            ' 
            ' teCaption
            ' 
            resources.ApplyResources(Me.teCaption, "teCaption")
            Me.teCaption.Name = "teCaption"
            Me.teCaption.Properties.AccessibleDescription = resources.GetString("teCaption.Properties.AccessibleDescription")
            Me.teCaption.Properties.AccessibleName = resources.GetString("teCaption.Properties.AccessibleName")
            Me.teCaption.Properties.AutoHeight = (CType(resources.GetObject("teCaption.Properties.AutoHeight"), Boolean))
            Me.teCaption.Properties.Mask.AutoComplete = (CType(resources.GetObject("teCaption.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.teCaption.Properties.Mask.BeepOnError = (CType(resources.GetObject("teCaption.Properties.Mask.BeepOnError"), Boolean))
            Me.teCaption.Properties.Mask.EditMask = resources.GetString("teCaption.Properties.Mask.EditMask")
            Me.teCaption.Properties.Mask.IgnoreMaskBlank = (CType(resources.GetObject("teCaption.Properties.Mask.IgnoreMaskBlank"), Boolean))
            Me.teCaption.Properties.Mask.MaskType = (CType(resources.GetObject("teCaption.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.teCaption.Properties.Mask.PlaceHolder = (CType(resources.GetObject("teCaption.Properties.Mask.PlaceHolder"), Char))
            Me.teCaption.Properties.Mask.SaveLiteral = (CType(resources.GetObject("teCaption.Properties.Mask.SaveLiteral"), Boolean))
            Me.teCaption.Properties.Mask.ShowPlaceHolders = (CType(resources.GetObject("teCaption.Properties.Mask.ShowPlaceHolders"), Boolean))
            Me.teCaption.Properties.Mask.UseMaskAsDisplayFormat = (CType(resources.GetObject("teCaption.Properties.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.teCaption.Properties.NullValuePrompt = resources.GetString("teCaption.Properties.NullValuePrompt")
            Me.teCaption.Properties.NullValuePromptShowForEmptyValue = (CType(resources.GetObject("teCaption.Properties.NullValuePromptShowForEmptyValue"), Boolean))
            Me.teCaption.StyleController = Me.layoutControl1
            ' 
            ' sbCancel
            ' 
            resources.ApplyResources(Me.sbCancel, "sbCancel")
            Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.sbCancel.Name = "sbCancel"
            Me.sbCancel.StyleController = Me.layoutControl1
            ' 
            ' sbOK
            ' 
            resources.ApplyResources(Me.sbOK, "sbOK")
            Me.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.sbOK.Name = "sbOK"
            Me.sbOK.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.emptySpaceItem1, Me.layoutControlItem4, Me.emptySpaceItem2, Me.layoutControlItem5})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(490, 138)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Control = Me.teCaption
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(470, 24)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' layoutControlItem2
            ' 
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Control = Me.cbeGroup
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(470, 24)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' layoutControlItem3
            ' 
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.Control = Me.heLink
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(470, 24)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 72)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(470, 20)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem4
            ' 
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.Control = Me.sbOK
            Me.layoutControlItem4.Location = New System.Drawing.Point(85, 92)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(81, 26)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem2, "emptySpaceItem2")
            Me.emptySpaceItem2.Location = New System.Drawing.Point(166, 92)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(304, 26)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem5
            ' 
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.Control = Me.sbCancel
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 92)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(85, 26)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' dxValidationProvider1
            ' 
            Me.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto
            ' 
            ' frmFeed
            ' 
            Me.AcceptButton = Me.sbOK
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.sbCancel
            Me.Controls.Add(Me.layoutControl1)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.Name = "frmFeed"
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.heLink.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbeGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teCaption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private teCaption As DevExpress.XtraEditors.TextEdit
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private heLink As DevExpress.XtraEditors.HyperLinkEdit
		Private cbeGroup As DevExpress.XtraEditors.ComboBoxEdit
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private sbOK As DevExpress.XtraEditors.SimpleButton
		Private sbCancel As DevExpress.XtraEditors.SimpleButton
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
	End Class
End Namespace
