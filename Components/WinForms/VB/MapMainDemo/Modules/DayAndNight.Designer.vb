Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraMap.Demos
	Partial Public Class DayAndNight
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
			Dim mapCustomElement1 As New DevExpress.XtraMap.MapCustomElement()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DayAndNight))
			Dim mapPolygon1 As New DevExpress.XtraMap.MapPolygon()
			Dim mapCustomElement2 As New DevExpress.XtraMap.MapCustomElement()
			Me.FileLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.ShapefileDataAdapter = New DevExpress.XtraMap.ShapefileDataAdapter()
			Me.ItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.Data = New DevExpress.XtraMap.MapItemStorage()
			Me.btnCurrent = New DevExpress.XtraBars.BarButtonItem()
			Me.barEditCalendar = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.chkSteadily = New DevExpress.XtraBars.BarCheckItem()
			Me.btnMinus = New DevExpress.XtraBars.BarButtonItem()
			Me.btnPlus = New DevExpress.XtraBars.BarButtonItem()
			Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.rpgInteractivity = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgDateTime = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.repositoryItemTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar()
			Me.repositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
			Me.repositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
			Me.repositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
			Me.repositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.repositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.chkPlay = New DevExpress.XtraBars.BarCheckItem()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.timer = New System.Windows.Forms.Timer(Me.components)
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' FileLayer
			' 
			Me.FileLayer.Data = Me.ShapefileDataAdapter
			Me.FileLayer.EnableHighlighting = False
			Me.FileLayer.EnableSelection = False
			Me.FileLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb((CInt(Fix((CByte(125))))), (CInt(Fix((CByte(211))))), (CInt(Fix((CByte(236))))))
			Me.FileLayer.ItemStyle.StrokeWidth = 0
			Me.FileLayer.Name = "FileLayer"
			Me.FileLayer.ShapeTitlesPattern = ""
'			Me.FileLayer.DataLoaded += New DevExpress.XtraMap.DataLoadedEventHandler(Me.DayAndNight_DataLoaded);
			' 
			' ItemsLayer
			' 
			Me.ItemsLayer.Data = Me.Data
			Me.ItemsLayer.EnableHighlighting = False
			Me.ItemsLayer.EnableSelection = False
			Me.ItemsLayer.Name = "ItemsLayer"
			' 
			' Data
			' 
			mapCustomElement1.Image = (CType(resources.GetObject("mapCustomElement1.Image"), System.Drawing.Image))
			mapCustomElement1.UseAnimation = False
			mapPolygon1.Fill = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(11))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(66))))))
			mapPolygon1.StrokeWidth = 0
			mapCustomElement2.Image = (CType(resources.GetObject("mapCustomElement2.Image"), System.Drawing.Image))
			mapCustomElement2.UseAnimation = False
			Me.Data.Items.Add(mapCustomElement1)
			Me.Data.Items.Add(mapPolygon1)
			Me.Data.Items.Add(mapCustomElement2)
			' 
			' btnCurrent
			' 
			Me.btnCurrent.Caption = "Current Time"
			Me.btnCurrent.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.btnCurrent.Glyph = (CType(resources.GetObject("btnCurrent.Glyph"), System.Drawing.Image))
			Me.btnCurrent.Id = 6
			Me.btnCurrent.LargeGlyph = (CType(resources.GetObject("btnCurrent.LargeGlyph"), System.Drawing.Image))
			Me.btnCurrent.Name = "btnCurrent"
'			Me.btnCurrent.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.btnCurrent_ItemClick);
			' 
			' barEditItem2
			' 
			Me.barEditCalendar.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.barEditCalendar.Edit = Me.repositoryItemDateEdit1
			Me.barEditCalendar.EditWidth = 150
			Me.barEditCalendar.Id = 24
			Me.barEditCalendar.Name = "barEditCalendar"
'			Me.barEditCalendar.EditValueChanged += New System.EventHandler(Me.barEditItem2_EditValueChanged);
			' 
			' repositoryItemDateEdit1
			' 
			Me.repositoryItemDateEdit1.AutoHeight = False
			Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.Mask.EditMask = "G"
			Me.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = True
			Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
			' 
			' chkSteadily
			' 
			Me.chkSteadily.Caption = "Steadily"
			Me.chkSteadily.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.chkSteadily.Glyph = (CType(resources.GetObject("chkSteadily.Glyph"), System.Drawing.Image))
			Me.chkSteadily.Id = 30
			Me.chkSteadily.LargeGlyph = (CType(resources.GetObject("chkSteadily.LargeGlyph"), System.Drawing.Image))
			Me.chkSteadily.Name = "chkSteadily"
'			Me.chkSteadily.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.chkSteadily_CheckedChanged);
			' 
			' btnMinus
			' 
			Me.btnMinus.Caption = "Backward"
			Me.btnMinus.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.btnMinus.Glyph = (CType(resources.GetObject("btnMinus.Glyph"), System.Drawing.Image))
			Me.btnMinus.Id = 31
			Me.btnMinus.LargeGlyph = (CType(resources.GetObject("btnMinus.LargeGlyph"), System.Drawing.Image))
			Me.btnMinus.Name = "btnMinus"
'			Me.btnMinus.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.btnMinus_ItemClick);
			' 
			' btnPlus
			' 
			Me.btnPlus.Caption = "Forward"
			Me.btnPlus.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.btnPlus.Glyph = (CType(resources.GetObject("btnPlus.Glyph"), System.Drawing.Image))
			Me.btnPlus.Id = 32
			Me.btnPlus.LargeGlyph = (CType(resources.GetObject("btnPlus.LargeGlyph"), System.Drawing.Image))
			Me.btnPlus.Name = "btnPlus"
'			Me.btnPlus.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.btnPlus_ItemClick);
			' 
			' barStaticItem1
			' 
			Me.barStaticItem1.Caption = "Custom Time"
			Me.barStaticItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.barStaticItem1.Id = 46
			Me.barStaticItem1.Name = "barStaticItem1"
			Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' ribbonPageGroup2
			' 
			Me.rpgInteractivity.ItemLinks.Add(Me.chkSteadily)
			Me.rpgInteractivity.ItemLinks.Add(Me.btnMinus)
			Me.rpgInteractivity.ItemLinks.Add(Me.btnPlus)
			Me.rpgInteractivity.Name = "ribbonPageGroup2"
			Me.rpgInteractivity.Text = "Interactivity"
			' 
			' ribbonPageGroup1
			' 
			Me.rpgDateTime.ItemLinks.Add(Me.barEditCalendar)
			Me.rpgDateTime.ItemLinks.Add(Me.btnCurrent)
			Me.rpgDateTime.Name = "ribbonPageGroup1"
			Me.rpgDateTime.Text = "Set Date and Time"
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.AutoHeight = False
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.DropDownRows = 10
			Me.repositoryItemComboBox1.Items.AddRange(New Object() { "Spherical Mercator", "Equal Area", "Equirectangular", "Elliptical Mercator", "Miller", "Equidistant", "Lambert Cylindrical Equal Area", "Braun Stereographic", "Kavrayskiy", "Sinusoidal"})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			' 
			' repositoryItemTrackBar1
			' 
			Me.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = True
			Me.repositoryItemTrackBar1.LargeChange = 24
			Me.repositoryItemTrackBar1.Maximum = 8760
			Me.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1"
			' 
			' repositoryItemTimeEdit1
			' 
			Me.repositoryItemTimeEdit1.AutoHeight = False
			Me.repositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1"
			' 
			' repositoryItemPopupContainerEdit1
			' 
			Me.repositoryItemPopupContainerEdit1.AutoHeight = False
			Me.repositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1"
			' 
			' repositoryItemRadioGroup1
			' 
			Me.repositoryItemRadioGroup1.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "1"), New DevExpress.XtraEditors.Controls.RadioGroupItem(25, "25")})
			Me.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1"
			' 
			' repositoryItemComboBox2
			' 
			Me.repositoryItemComboBox2.AutoHeight = False
			Me.repositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox2.Items.AddRange(New Object() { "1", "25"})
			Me.repositoryItemComboBox2.Name = "repositoryItemComboBox2"
			' 
			' repositoryItemComboBox3
			' 
			Me.repositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox3.Items.AddRange(New Object() { "1", "25"})
			Me.repositoryItemComboBox3.Name = "repositoryItemComboBox3"
			Me.repositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			' 
			' chkPlay
			' 
			Me.chkPlay.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.chkPlay.Id = 9
			Me.chkPlay.Name = "chkPlay"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "-1"
			Me.barButtonItem1.Id = -1
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "+1"
			Me.barButtonItem2.Id = -1
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
			Me.splitContainerControl1.IsSplitterFixed = True
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 141)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.mapControl1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.groupControl1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(500, 359)
			Me.splitContainerControl1.SplitterPosition = 166
			Me.splitContainerControl1.TabIndex = 6
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' mapControl1
			' 
			Me.mapControl1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(47))))), (CInt(Fix((CByte(173))))), (CInt(Fix((CByte(213))))))
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapControl1.EnableZooming = False
			Me.mapControl1.Layers.Add(Me.FileLayer)
			Me.mapControl1.Layers.Add(Me.ItemsLayer)
			Me.mapControl1.Location = New System.Drawing.Point(0, 0)
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.NavigationPanelOptions.ShowZoomTrackbar = False
			Me.mapControl1.Size = New System.Drawing.Size(329, 359)
			Me.mapControl1.TabIndex = 5
			Me.mapControl1.ZoomLevel = 1.8059329233548773R
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.listBoxControl1)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl1.Location = New System.Drawing.Point(0, 0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(166, 359)
			Me.groupControl1.TabIndex = 1
			Me.groupControl1.Text = "Projection"
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBoxControl1.Items.AddRange(New Object() { "Spherical Mercator", "Equal Area", "Equirectangular", "Elliptical Mercator", "Miller", "Equidistant", "Lambert Cylindrical Equal Area", "Braun Stereographic", "Kavrayskiy", "Sinusoidal", "EPSG:4326"})
			Me.listBoxControl1.Location = New System.Drawing.Point(2, 20)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(162, 337)
			Me.listBoxControl1.TabIndex = 0
'			Me.listBoxControl1.SelectedIndexChanged += New System.EventHandler(Me.listBoxControl1_SelectedIndexChanged);
			' 
			' timer
			' 
'			Me.timer.Tick += New System.EventHandler(Me.timer_Tick);
			' 
			' DayAndNight
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "DayAndNight"
			CType(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private repositoryItemComboBox1 As XtraEditors.Repository.RepositoryItemComboBox
		Private repositoryItemTrackBar1 As XtraEditors.Repository.RepositoryItemTrackBar
		Private rpgInteractivity As XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents btnCurrent As XtraBars.BarButtonItem
		Private chkPlay As XtraBars.BarCheckItem
		Private barButtonItem1 As XtraBars.BarButtonItem
		Private barButtonItem2 As XtraBars.BarButtonItem
		Private WithEvents barEditCalendar As XtraBars.BarEditItem
		Private repositoryItemDateEdit1 As XtraEditors.Repository.RepositoryItemDateEdit
		Private repositoryItemTimeEdit1 As XtraEditors.Repository.RepositoryItemTimeEdit
		Private WithEvents chkSteadily As XtraBars.BarCheckItem
		Private WithEvents btnMinus As XtraBars.BarButtonItem
		Private WithEvents btnPlus As XtraBars.BarButtonItem
		Private repositoryItemPopupContainerEdit1 As XtraEditors.Repository.RepositoryItemPopupContainerEdit
		Private splitContainerControl1 As XtraEditors.SplitContainerControl
		Private mapControl1 As MapControl
		Private WithEvents listBoxControl1 As XtraEditors.ListBoxControl
		Private rpgDateTime As XtraBars.Ribbon.RibbonPageGroup
		Private barStaticItem1 As XtraBars.BarStaticItem
		Private repositoryItemRadioGroup1 As XtraEditors.Repository.RepositoryItemRadioGroup
		Private repositoryItemComboBox2 As XtraEditors.Repository.RepositoryItemComboBox
		Private repositoryItemComboBox3 As XtraEditors.Repository.RepositoryItemComboBox
		Private groupControl1 As XtraEditors.GroupControl
		Private WithEvents timer As System.Windows.Forms.Timer
		Private WithEvents FileLayer As VectorItemsLayer
		Private ShapefileDataAdapter As ShapefileDataAdapter
		Private ItemsLayer As VectorItemsLayer
		Private Data As MapItemStorage
	End Class
End Namespace
