Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraMap.Demos
	Partial Public Class OSMDataProviders
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
			Dim miniMap1 As New DevExpress.XtraMap.MiniMap()
			Dim dynamicMiniMapBehavior1 As New DevExpress.XtraMap.DynamicMiniMapBehavior()
			Me.MiniMapImageTilesLayer = New DevExpress.XtraMap.MiniMapImageTilesLayer()
			Me.MiniMapDataProvider = New DevExpress.XtraMap.OpenStreetMapDataProvider()
			Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
			Me.BaseProvider = New DevExpress.XtraMap.OpenStreetMapDataProvider()
			Me.OverlayLayer = New DevExpress.XtraMap.ImageLayer()
			Me.OverlayProvider = New DevExpress.XtraMap.OpenStreetMapDataProvider()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.listBoxControl2 = New DevExpress.XtraEditors.ListBoxControl()
			Me.trackBarControl2 = New DevExpress.XtraEditors.TrackBarControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' MiniMapImageTilesLayer
			' 
			Me.MiniMapImageTilesLayer.DataProvider = Me.MiniMapDataProvider
			' 
			' TilesLayer
			' 
			Me.TilesLayer.DataProvider = Me.BaseProvider
			Me.TilesLayer.Name = "TilesLayer"
			' 
			' OverlayLayer
			' 
			Me.OverlayLayer.DataProvider = Me.OverlayProvider
			Me.OverlayLayer.Name = "OverlayLayer"
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Appearance.Control.BorderColor = System.Drawing.Color.Transparent
			Me.layoutControl1.Appearance.Control.Options.UseBorderColor = True
			Me.layoutControl1.Controls.Add(Me.trackBarControl1)
			Me.layoutControl1.Controls.Add(Me.listBoxControl1)
			Me.layoutControl1.Controls.Add(Me.mapControl1)
			Me.layoutControl1.Controls.Add(Me.listBoxControl2)
			Me.layoutControl1.Controls.Add(Me.trackBarControl2)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 141)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(219, 128, 768, 627)
			Me.layoutControl1.OptionsView.EnableIndentsInGroupsWithoutBorders = True
			Me.layoutControl1.OptionsView.ItemBorderColor = System.Drawing.Color.Transparent
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(601, 339)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' trackBarControl1
			' 
			Me.trackBarControl1.EditValue = Nothing
			Me.trackBarControl1.Location = New System.Drawing.Point(447, 198)
			Me.trackBarControl1.MenuManager = Me
			Me.trackBarControl1.Name = "trackBarControl1"
			Me.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.trackBarControl1.Properties.Maximum = 255
			Me.trackBarControl1.Properties.ShowLabels = True
			Me.trackBarControl1.Properties.TickStyle = System.Windows.Forms.TickStyle.None
			Me.trackBarControl1.Size = New System.Drawing.Size(140, 45)
			Me.trackBarControl1.StyleController = Me.layoutControl1
			Me.trackBarControl1.TabIndex = 6
'			Me.trackBarControl1.EditValueChanged += New System.EventHandler(Me.trackBarControl1_EditValueChanged);
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.listBoxControl1.Location = New System.Drawing.Point(442, 28)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(150, 149)
			Me.listBoxControl1.StyleController = Me.layoutControl1
			Me.listBoxControl1.TabIndex = 5
'			Me.listBoxControl1.SelectedValueChanged += New System.EventHandler(Me.listBoxControl1_SelectedValueChanged);
			' 
			' mapControl1
			' 
			Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(50.067R, 14.417R)
			Me.mapControl1.Layers.Add(Me.TilesLayer)
			Me.mapControl1.Layers.Add(Me.OverlayLayer)
			Me.mapControl1.Location = New System.Drawing.Point(0, 0)
			miniMap1.Alignment = DevExpress.XtraMap.MiniMapAlignment.TopRight
			miniMap1.Behavior = dynamicMiniMapBehavior1
			miniMap1.Layers.Add(Me.MiniMapImageTilesLayer)
			Me.mapControl1.MiniMap = miniMap1
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.Size = New System.Drawing.Size(436, 332)
			Me.mapControl1.TabIndex = 4
			Me.mapControl1.ZoomLevel = 5R
			' 
			' listBoxControl2
			' 
			Me.listBoxControl2.Cursor = System.Windows.Forms.Cursors.Default
			Me.listBoxControl2.Location = New System.Drawing.Point(442, 256)
			Me.listBoxControl2.Name = "listBoxControl2"
			Me.listBoxControl2.Size = New System.Drawing.Size(150, 27)
			Me.listBoxControl2.StyleController = Me.layoutControl1
			Me.listBoxControl2.TabIndex = 5
'			Me.listBoxControl2.SelectedValueChanged += New System.EventHandler(Me.listBoxControl2_SelectedValueChanged);
			' 
			' trackBarControl2
			' 
			Me.trackBarControl2.EditValue = Nothing
			Me.trackBarControl2.Location = New System.Drawing.Point(447, 304)
			Me.trackBarControl2.Name = "trackBarControl2"
			Me.trackBarControl2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.trackBarControl2.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.trackBarControl2.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.trackBarControl2.Properties.Maximum = 255
			Me.trackBarControl2.Properties.TickStyle = System.Windows.Forms.TickStyle.None
			Me.trackBarControl2.Size = New System.Drawing.Size(140, 45)
			Me.trackBarControl2.StyleController = Me.layoutControl1
			Me.trackBarControl2.TabIndex = 6
'			Me.trackBarControl2.EditValueChanged += New System.EventHandler(Me.trackBarControl2_EditValueChanged);
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlGroup2, Me.layoutControlGroup3})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 5, 0, 5)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(601, 339)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.mapControl1
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 2, 0, 2)
			Me.layoutControlItem1.Size = New System.Drawing.Size(438, 334)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup2.GroupBordersVisible = False
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem3})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(438, 0)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
			Me.layoutControlGroup2.Size = New System.Drawing.Size(158, 228)
			Me.layoutControlGroup2.Text = "Base Layers"
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.AppearanceItemCaption.BorderColor = System.Drawing.Color.Transparent
			Me.layoutControlItem2.AppearanceItemCaption.Options.UseBorderColor = True
			Me.layoutControlItem2.Control = Me.listBoxControl1
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.MaxSize = New System.Drawing.Size(150, 149)
			Me.layoutControlItem2.MinSize = New System.Drawing.Size(150, 149)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem2.Size = New System.Drawing.Size(150, 149)
			Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.AppearanceItemCaption.BorderColor = System.Drawing.Color.Transparent
			Me.layoutControlItem3.AppearanceItemCaption.Options.UseBorderColor = True
			Me.layoutControlItem3.Control = Me.trackBarControl1
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 149)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem3.Size = New System.Drawing.Size(150, 71)
			Me.layoutControlItem3.Text = "Transparency"
			Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(66, 13)
			' 
			' layoutControlGroup3
			' 
			Me.layoutControlGroup3.CustomizationFormText = "Overlay Layers"
			Me.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup3.GroupBordersVisible = False
			Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem4, Me.layoutControlItem5})
			Me.layoutControlGroup3.Location = New System.Drawing.Point(438, 228)
			Me.layoutControlGroup3.Name = "layoutControlGroup3"
			Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
			Me.layoutControlGroup3.Size = New System.Drawing.Size(158, 106)
			Me.layoutControlGroup3.Text = "Overlay Layers"
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.listBoxControl2
			Me.layoutControlItem4.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem4.Size = New System.Drawing.Size(150, 27)
			Me.layoutControlItem4.Text = "layoutControlItem2"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.trackBarControl2
			Me.layoutControlItem5.CustomizationFormText = "Transparency"
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 27)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem5.Size = New System.Drawing.Size(150, 71)
			Me.layoutControlItem5.Text = "Transparency"
			Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(66, 13)
			' 
			' OSMDataProviders
			' 
			Me.Appearance.Options.UseFont = True
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "OSMDataProviders"
			Me.Size = New System.Drawing.Size(601, 480)
			Me.Controls.SetChildIndex(Me.layoutControl1, 0)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private layoutControl1 As XtraLayout.LayoutControl
		Private mapControl1 As MapControl
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private WithEvents listBoxControl1 As XtraEditors.ListBoxControl
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private WithEvents trackBarControl1 As XtraEditors.TrackBarControl
		Private layoutControlItem3 As XtraLayout.LayoutControlItem
		Private WithEvents listBoxControl2 As XtraEditors.ListBoxControl
		Private WithEvents trackBarControl2 As XtraEditors.TrackBarControl
		Private layoutControlGroup3 As XtraLayout.LayoutControlGroup
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private layoutControlItem5 As XtraLayout.LayoutControlItem
		Private TilesLayer As ImageLayer
		Private BaseProvider As OpenStreetMapDataProvider
		Private OverlayLayer As ImageLayer
		Private OverlayProvider As OpenStreetMapDataProvider
		Private MiniMapDataProvider As OpenStreetMapDataProvider
		Private MiniMapImageTilesLayer As MiniMapImageTilesLayer
	End Class
End Namespace
