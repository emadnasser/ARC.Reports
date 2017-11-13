Namespace DevExpress.DevAV
    Partial Public Class ReportPrintControl
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

                If printerItemContainer IsNot Nothing Then
                    printerItemContainer.Dispose()
                    printerItemContainer = Nothing
                End If
                If imagesContainer IsNot Nothing Then
                    imagesContainer.Dispose()
                    imagesContainer = Nothing
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.moduleLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.settingsPanel = New DevExpress.DevAV.SettingPanel()
            Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
            Me.btnOptions = New DevExpress.XtraEditors.SimpleButton()
            Me.cbPrinters = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForButtonPrint = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForPrinters = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForOptions = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.captionLabelItem = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.buttonLabelItem = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.separator = New DevExpress.XtraLayout.SimpleSeparator()
            Me.ItemForSettings = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType(Me.cbPrinters.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForButtonPrint, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForPrinters, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForOptions, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.captionLabelItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonLabelItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.separator, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.settingsPanel)
            Me.moduleLayout.Controls.Add(Me.btnPrint)
            Me.moduleLayout.Controls.Add(Me.btnOptions)
            Me.moduleLayout.Controls.Add(Me.cbPrinters)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.layoutControlGroup1
            Me.moduleLayout.Size = New System.Drawing.Size(310, 600)
            Me.moduleLayout.TabIndex = 0
            Me.settingsPanel.Location = New System.Drawing.Point(40, 318)
            Me.settingsPanel.Name = "settingsPanel"
            Me.settingsPanel.Size = New System.Drawing.Size(228, 242)
            Me.settingsPanel.TabIndex = 4
            Me.btnPrint.Enabled = False
            Me.btnPrint.Image = My.Resources.icon_print_42x40
            Me.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
            Me.btnPrint.Location = New System.Drawing.Point(40, 89)
            Me.btnPrint.MaximumSize = New System.Drawing.Size(75, 75)
            Me.btnPrint.MinimumSize = New System.Drawing.Size(75, 75)
            Me.btnPrint.Name = "btnPrint"
            Me.btnPrint.Size = New System.Drawing.Size(75, 75)
            Me.btnPrint.StyleController = Me.moduleLayout
            Me.btnPrint.TabIndex = 1
            Me.btnPrint.Text = "Print"
            Me.btnOptions.Enabled = False
            Me.btnOptions.Location = New System.Drawing.Point(40, 245)
            Me.btnOptions.Name = "btnOptions"
            Me.btnOptions.Size = New System.Drawing.Size(112, 22)
            Me.btnOptions.StyleController = Me.moduleLayout
            Me.btnOptions.TabIndex = 3
            Me.btnOptions.Text = "Print Options"
            Me.cbPrinters.Location = New System.Drawing.Point(40, 217)
            Me.cbPrinters.Name = "cbPrinters"
            Me.cbPrinters.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbPrinters.Size = New System.Drawing.Size(228, 20)
            Me.cbPrinters.StyleController = Me.moduleLayout
            Me.cbPrinters.TabIndex = 2
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForButtonPrint, Me.ItemForPrinters, Me.ItemForOptions, Me.emptySpaceItem1, Me.captionLabelItem, Me.buttonLabelItem, Me.separator, Me.ItemForSettings})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(40, 0, 0, 40)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(310, 600)
            Me.layoutControlGroup1.Text = "Root"
            Me.ItemForButtonPrint.Control = Me.btnPrint
            Me.ItemForButtonPrint.CustomizationFormText = "Print"
            Me.ItemForButtonPrint.Location = New System.Drawing.Point(0, 89)
            Me.ItemForButtonPrint.Name = "layoutControlItem1"
            Me.ItemForButtonPrint.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForButtonPrint.Size = New System.Drawing.Size(75, 75)
            Me.ItemForButtonPrint.Text = "Print"
            Me.ItemForButtonPrint.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForButtonPrint.TextToControlDistance = 0
            Me.ItemForButtonPrint.TextVisible = False
            Me.ItemForPrinters.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.ItemForPrinters.AppearanceItemCaption.Options.UseFont = True
            Me.ItemForPrinters.Control = Me.cbPrinters
            Me.ItemForPrinters.CustomizationFormText = "Printer"
            Me.ItemForPrinters.Location = New System.Drawing.Point(0, 164)
            Me.ItemForPrinters.Name = "Printer"
            Me.ItemForPrinters.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 16, 8)
            Me.ItemForPrinters.Size = New System.Drawing.Size(228, 81)
            Me.ItemForPrinters.Text = "Printer"
            Me.ItemForPrinters.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.ItemForPrinters.TextLocation = DevExpress.Utils.Locations.Top
            Me.ItemForPrinters.TextSize = New System.Drawing.Size(70, 32)
            Me.ItemForPrinters.TextToControlDistance = 5
            Me.ItemForOptions.Control = Me.btnOptions
            Me.ItemForOptions.CustomizationFormText = "layoutControlItem3"
            Me.ItemForOptions.Location = New System.Drawing.Point(0, 245)
            Me.ItemForOptions.Name = "layoutControlItem3"
            Me.ItemForOptions.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForOptions.Size = New System.Drawing.Size(112, 22)
            Me.ItemForOptions.Text = "layoutControlItem3"
            Me.ItemForOptions.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForOptions.TextToControlDistance = 0
            Me.ItemForOptions.TextVisible = False
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(112, 245)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(116, 22)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.captionLabelItem.AllowHotTrack = False
            Me.captionLabelItem.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.captionLabelItem.AppearanceItemCaption.Options.UseFont = True
            Me.captionLabelItem.CustomizationFormText = "Print"
            Me.captionLabelItem.Location = New System.Drawing.Point(0, 0)
            Me.captionLabelItem.Name = "simpleLabelItem1"
            Me.captionLabelItem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 24)
            Me.captionLabelItem.Size = New System.Drawing.Size(228, 89)
            Me.captionLabelItem.Text = "Print"
            Me.captionLabelItem.TextSize = New System.Drawing.Size(114, 65)
            Me.buttonLabelItem.AllowHotTrack = False
            Me.buttonLabelItem.AllowHtmlStringInCaption = True
            Me.buttonLabelItem.AppearanceItemCaption.Options.UseTextOptions = True
            Me.buttonLabelItem.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.buttonLabelItem.CustomizationFormText = "Specify how you want<br>the report to be printed"
            Me.buttonLabelItem.Location = New System.Drawing.Point(75, 89)
            Me.buttonLabelItem.Name = "simpleLabelItem2"
            Me.buttonLabelItem.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 0, 0, 0)
            Me.buttonLabelItem.Size = New System.Drawing.Size(153, 75)
            Me.buttonLabelItem.Text = "Specify how you want<br>the report to be printed"
            Me.buttonLabelItem.TextSize = New System.Drawing.Size(114, 26)
            Me.separator.AllowHotTrack = False
            Me.separator.CustomizationFormText = "simpleSeparator1"
            Me.separator.Location = New System.Drawing.Point(228, 0)
            Me.separator.Name = "simpleSeparator1"
            Me.separator.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.separator.Size = New System.Drawing.Size(42, 560)
            Me.separator.Spacing = New DevExpress.XtraLayout.Utils.Padding(40, 0, 0, 0)
            Me.separator.Text = "simpleSeparator1"
            Me.ItemForSettings.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 18F)
            Me.ItemForSettings.AppearanceItemCaption.Options.UseFont = True
            Me.ItemForSettings.Control = Me.settingsPanel
            Me.ItemForSettings.CustomizationFormText = "Settings"
            Me.ItemForSettings.Location = New System.Drawing.Point(0, 267)
            Me.ItemForSettings.Name = "ItemForSettings"
            Me.ItemForSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 16, 0)
            Me.ItemForSettings.Size = New System.Drawing.Size(228, 293)
            Me.ItemForSettings.Text = "Settings"
            Me.ItemForSettings.TextLocation = DevExpress.Utils.Locations.Top
            Me.ItemForSettings.TextSize = New System.Drawing.Size(114, 32)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Name = "ReportPrintControl"
            Me.Size = New System.Drawing.Size(310, 600)
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType(Me.cbPrinters.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForButtonPrint, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForPrinters, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForOptions, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.captionLabelItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonLabelItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.separator, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForSettings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
        Private cbPrinters As XtraEditors.ImageComboBoxEdit
        Private WithEvents btnOptions As DevExpress.XtraEditors.SimpleButton
        Private moduleLayout As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private ItemForButtonPrint As XtraLayout.LayoutControlItem
        Private ItemForOptions As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private captionLabelItem As XtraLayout.SimpleLabelItem
        Private ItemForPrinters As XtraLayout.LayoutControlItem
        Private buttonLabelItem As XtraLayout.SimpleLabelItem
        Private separator As XtraLayout.SimpleSeparator
        Private settingsPanel As SettingPanel
        Private ItemForSettings As XtraLayout.LayoutControlItem
    End Class
End Namespace
