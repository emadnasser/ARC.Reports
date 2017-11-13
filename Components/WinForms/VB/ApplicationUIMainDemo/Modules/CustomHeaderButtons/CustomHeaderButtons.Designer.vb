Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class CustomHeaderButtons
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomHeaderButtons))
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.rgTemplatesButton = New DevExpress.XtraEditors.RadioGroup()
			Me.buttonPropertyGrid = New DevExpress.ApplicationUI.Demos.ButtonPropertyGrid()
			Me.actionDockPanel = New DevExpress.ApplicationUI.Demos.ActionDockPanel()
			Me.lcCustomButtons = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.rgTemplatesButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcCustomButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.rgTemplatesButton)
			Me.layoutControl1.Controls.Add(Me.buttonPropertyGrid)
			Me.layoutControl1.Controls.Add(Me.actionDockPanel)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(847, 192, 450, 350)
			Me.layoutControl1.Root = Me.lcCustomButtons
			Me.layoutControl1.Size = New System.Drawing.Size(819, 419)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' rgTemplatesButton
			' 
			Me.rgTemplatesButton.AutoSizeInLayoutControl = True
			Me.rgTemplatesButton.EditValue = ""
			Me.rgTemplatesButton.Location = New System.Drawing.Point(12, 12)
			Me.rgTemplatesButton.Name = "rgTemplatesButton"
			Me.rgTemplatesButton.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.rgTemplatesButton.Properties.Appearance.Options.UseBackColor = True
			Me.rgTemplatesButton.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.rgTemplatesButton.Properties.Columns = 1
			Me.rgTemplatesButton.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default
			Me.rgTemplatesButton.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem("PushButton", "Push button"), New DevExpress.XtraEditors.Controls.RadioGroupItem("CheckButton", "Check Button"), New DevExpress.XtraEditors.Controls.RadioGroupItem("ButtonWithImage", "Button with image"), New DevExpress.XtraEditors.Controls.RadioGroupItem("ButtonWithGlyphs", "Button with glyphs")})
			Me.rgTemplatesButton.Size = New System.Drawing.Size(115, 68)
			Me.rgTemplatesButton.StyleController = Me.layoutControl1
			Me.rgTemplatesButton.TabIndex = 6
'			Me.rgTemplatesButton.SelectedIndexChanged += New System.EventHandler(Me.TemplatesButtonSelectedIndexChanged);
			' 
			' buttonPropertyGrid
			' 
			Me.buttonPropertyGrid.Location = New System.Drawing.Point(396, 12)
			Me.buttonPropertyGrid.Margin = New System.Windows.Forms.Padding(4)
			Me.buttonPropertyGrid.Name = "buttonPropertyGrid"
			Me.buttonPropertyGrid.SelectObject = Nothing
			Me.buttonPropertyGrid.Size = New System.Drawing.Size(411, 395)
			Me.buttonPropertyGrid.TabIndex = 5
			' 
			' actionDockPanel
			' 
			Me.actionDockPanel.Location = New System.Drawing.Point(12, 84)
			Me.actionDockPanel.Margin = New System.Windows.Forms.Padding(4)
			Me.actionDockPanel.Name = "actionDockPanel"
			Me.actionDockPanel.Size = New System.Drawing.Size(380, 323)
			Me.actionDockPanel.TabIndex = 4
			Me.actionDockPanel.TextActions = ""
			' 
			' lcCustomButtons
			' 
			Me.lcCustomButtons.CustomizationFormText = "lcCustomButtons"
			Me.lcCustomButtons.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcCustomButtons.GroupBordersVisible = False
			Me.lcCustomButtons.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.emptySpaceItem1})
			Me.lcCustomButtons.Location = New System.Drawing.Point(0, 0)
			Me.lcCustomButtons.Name = "lcCustomButtons"
			Me.lcCustomButtons.Size = New System.Drawing.Size(819, 419)
			Me.lcCustomButtons.Text = "lcCustomButtons"
			Me.lcCustomButtons.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.actionDockPanel
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 72)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(384, 327)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.buttonPropertyGrid
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(384, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(415, 399)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.rgTemplatesButton
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(119, 72)
			Me.layoutControlItem3.Text = "layoutControlItem3"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextToControlDistance = 0
			Me.layoutControlItem3.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(119, 0)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(265, 72)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "Backward_16x16.png")
			Me.imageList1.Images.SetKeyName(1, "Next_16x16.png")
			Me.imageList1.Images.SetKeyName(2, "Apply_16x16.png")
			Me.imageList1.Images.SetKeyName(3, "Unmark_16x16.png")
			Me.imageList1.Images.SetKeyName(4, "Forward_16x16.png")
			Me.imageList1.Images.SetKeyName(5, "Previous_16x16.png")
			' 
			' CustomHeaderButtons
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "CustomHeaderButtons"
			Me.Size = New System.Drawing.Size(819, 419)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.rgTemplatesButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcCustomButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private buttonPropertyGrid As ButtonPropertyGrid
		Private actionDockPanel As ActionDockPanel
		Private lcCustomButtons As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents rgTemplatesButton As DevExpress.XtraEditors.RadioGroup
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private imageList1 As System.Windows.Forms.ImageList
	End Class
End Namespace
