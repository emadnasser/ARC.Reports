Namespace DevExpress.DevAV.Modules
    Partial Public Class OrderView
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
            Dim dataSourceInfo1 As New DevExpress.Snap.Core.API.DataSourceInfo()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.modueLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.buttons = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.snapControl = New DevExpress.Snap.SnapControl()
            Me.TitleLabel = New DevExpress.XtraEditors.LabelControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForTitle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
            Me.ItemForDocument = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForButtons = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.modueLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.modueLayout.SuspendLayout()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForDocument, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForButtons, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Order)
            Me.modueLayout.AllowCustomization = False
            Me.modueLayout.Controls.Add(Me.buttons)
            Me.modueLayout.Controls.Add(Me.snapControl)
            Me.modueLayout.Controls.Add(Me.TitleLabel)
            Me.modueLayout.DataSource = Me.bindingSource
            Me.modueLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.modueLayout.Location = New System.Drawing.Point(0, 0)
            Me.modueLayout.Margin = New System.Windows.Forms.Padding(2)
            Me.modueLayout.Name = "modueLayout"
            Me.modueLayout.Root = Me.Root
            Me.modueLayout.Size = New System.Drawing.Size(400, 600)
            Me.modueLayout.TabIndex = 0
            Me.buttons.AllowGlyphSkinning = False
            Me.buttons.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() { New DevExpress.XtraBars.Docking2010.WindowsUIButton(Nothing, My.Resources.icon_edit_16, -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", False, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False)})
            Me.buttons.ContentAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.buttons.Location = New System.Drawing.Point(298, 2)
            Me.buttons.Name = "buttons"
            Me.buttons.Size = New System.Drawing.Size(100, 33)
            Me.buttons.TabIndex = 32
            Me.buttons.UseButtonBackgroundImages = False
            Me.snapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            dataSourceInfo1.DataSource = Me.bindingSource
            dataSourceInfo1.DataSourceName = ""
            Me.snapControl.DataSources.Add(dataSourceInfo1)
            Me.snapControl.EnableToolTips = True
            Me.snapControl.Location = New System.Drawing.Point(0, 47)
            Me.snapControl.Modified = True
            Me.snapControl.Name = "snapControl"
            Me.snapControl.Options.CopyPaste.MaintainDocumentSectionSettings = False
            Me.snapControl.Options.Fields.UseCurrentCultureDateTimeFormat = False
            Me.snapControl.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.snapControl.Options.SnapMailMergeVisualOptions.DataSourceName = "Employee"
            Me.snapControl.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.snapControl.ReadOnly = True
            Me.snapControl.Size = New System.Drawing.Size(400, 553)
            Me.snapControl.TabIndex = 19
            Me.snapControl.Views.PrintLayoutView.MaxHorizontalPageCount = 1
            Me.TitleLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.TitleLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "InvoiceNumber", True))
            Me.TitleLabel.Location = New System.Drawing.Point(131, 0)
            Me.TitleLabel.Margin = New System.Windows.Forms.Padding(2)
            Me.TitleLabel.Name = "TitleLabel"
            Me.TitleLabel.Size = New System.Drawing.Size(124, 37)
            Me.TitleLabel.StyleController = Me.modueLayout
            Me.TitleLabel.TabIndex = 4
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup1})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.OptionsItemText.TextToControlDistance = 6
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(400, 600)
            Me.Root.Text = "Root"
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "autoGeneratedGroup0"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForTitle, Me.simpleSeparator1, Me.ItemForDocument, Me.ItemForButtons, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6
            Me.layoutControlGroup1.Size = New System.Drawing.Size(400, 600)
            Me.layoutControlGroup1.Text = "autoGeneratedGroup0"
            Me.ItemForTitle.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 20.25F)
            Me.ItemForTitle.AppearanceItemCaption.Options.UseFont = True
            Me.ItemForTitle.Control = Me.TitleLabel
            Me.ItemForTitle.CustomizationFormText = "Title"
            Me.ItemForTitle.Location = New System.Drawing.Point(0, 0)
            Me.ItemForTitle.Name = "ItemForTitle"
            Me.ItemForTitle.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForTitle.Size = New System.Drawing.Size(255, 37)
            Me.ItemForTitle.Text = "INVOICE #"
            Me.ItemForTitle.TextSize = New System.Drawing.Size(125, 37)
            Me.simpleSeparator1.AllowHotTrack = False
            Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
            Me.simpleSeparator1.Location = New System.Drawing.Point(0, 37)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Size = New System.Drawing.Size(400, 10)
            Me.simpleSeparator1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 8, 0)
            Me.simpleSeparator1.Text = "simpleSeparator1"
            Me.ItemForDocument.Control = Me.snapControl
            Me.ItemForDocument.CustomizationFormText = "ItemForDocument"
            Me.ItemForDocument.Location = New System.Drawing.Point(0, 47)
            Me.ItemForDocument.Name = "ItemForDocument"
            Me.ItemForDocument.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForDocument.Size = New System.Drawing.Size(400, 553)
            Me.ItemForDocument.Text = "ItemForDocument"
            Me.ItemForDocument.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForDocument.TextToControlDistance = 0
            Me.ItemForDocument.TextVisible = False
            Me.ItemForButtons.Control = Me.buttons
            Me.ItemForButtons.CustomizationFormText = "ItemForButtons"
            Me.ItemForButtons.Location = New System.Drawing.Point(296, 0)
            Me.ItemForButtons.MaxSize = New System.Drawing.Size(104, 0)
            Me.ItemForButtons.MinSize = New System.Drawing.Size(104, 24)
            Me.ItemForButtons.Name = "ItemForButtons"
            Me.ItemForButtons.Size = New System.Drawing.Size(104, 37)
            Me.ItemForButtons.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForButtons.Text = "ItemForButtons"
            Me.ItemForButtons.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForButtons.TextToControlDistance = 0
            Me.ItemForButtons.TextVisible = False
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(255, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(41, 37)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.modueLayout)
            Me.Name = "OrderView"
            Me.Size = New System.Drawing.Size(400, 600)
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.modueLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.modueLayout.ResumeLayout(False)
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForDocument, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForButtons, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private bindingSource As System.Windows.Forms.BindingSource
        Private modueLayout As DevExpress.XtraDataLayout.DataLayoutControl
        Private TitleLabel As XtraEditors.LabelControl
        Private Root As XtraLayout.LayoutControlGroup
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private ItemForTitle As XtraLayout.LayoutControlItem
        Private simpleSeparator1 As XtraLayout.SimpleSeparator
        Private snapControl As Snap.SnapControl
        Private ItemForDocument As XtraLayout.LayoutControlItem
        Private buttons As XtraBars.Docking2010.WindowsUIButtonPanel
        Private ItemForButtons As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
    End Class
End Namespace
