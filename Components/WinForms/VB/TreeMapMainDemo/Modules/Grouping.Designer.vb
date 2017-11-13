Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraTreeMap.Demos
	Partial Public Class Grouping
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
			Dim treeMapFlatDataAdapter1 As New DevExpress.XtraTreeMap.TreeMapFlatDataAdapter()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Grouping))
			Me.treeMapControl1 = New DevExpress.XtraTreeMap.TreeMapControl()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.btnWithoutGrouping = New DevExpress.XtraBars.BarCheckItem()
			Me.btnGroupByResidence = New DevExpress.XtraBars.BarCheckItem()
			Me.btnGroupByAge = New DevExpress.XtraBars.BarCheckItem()
			Me.btnGroupByResidenceAndAge = New DevExpress.XtraBars.BarCheckItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.treeMapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeMapControl1
			' 
			Me.treeMapControl1.BorderOptions.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(157))))), (CInt(Fix((CByte(160))))), (CInt(Fix((CByte(170))))))
			treeMapFlatDataAdapter1.DataMember = Nothing
			treeMapFlatDataAdapter1.LabelDataMember = "Name"
			treeMapFlatDataAdapter1.ValueDataMember = "NetWorth"
			Me.treeMapControl1.DataAdapter = treeMapFlatDataAdapter1
			Me.treeMapControl1.Location = New System.Drawing.Point(12, 35)
			Me.treeMapControl1.Name = "treeMapControl1"
			Me.treeMapControl1.Size = New System.Drawing.Size(476, 312)
			Me.treeMapControl1.TabIndex = 0
			Me.treeMapControl1.ToolTipController = Me.toolTipController1
			Me.treeMapControl1.ToolTipGroupPattern = "{L}: {V}B$"
			Me.treeMapControl1.ToolTipLeafPattern = "{L}: {V}B$"
			' 
			' toolTipController1
			' 
			Me.toolTipController1.Appearance.Options.UseTextOptions = True
			Me.toolTipController1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None
			Me.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
'			Me.toolTipController1.BeforeShow += New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(Me.toolTipController1_BeforeShow);
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.btnWithoutGrouping, Me.btnGroupByResidence, Me.btnGroupByAge, Me.btnGroupByResidenceAndAge})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 8
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.Size = New System.Drawing.Size(500, 141)
			' 
			' btnWithoutGrouping
			' 
			Me.btnWithoutGrouping.Caption = "Without Grouping"
			Me.btnWithoutGrouping.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.btnWithoutGrouping.GroupIndex = 1
			Me.btnWithoutGrouping.Id = 3
			Me.btnWithoutGrouping.ImageOptions.Image = (CType(resources.GetObject("btnWithoutGrouping.ImageOptions.Image"), System.Drawing.Image))
			Me.btnWithoutGrouping.ImageOptions.LargeImage = (CType(resources.GetObject("btnWithoutGrouping.ImageOptions.LargeImage"), System.Drawing.Image))
			Me.btnWithoutGrouping.Name = "btnWithoutGrouping"
'			Me.btnWithoutGrouping.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnGroupingItemClick);
			' 
			' btnGroupByResidence
			' 
			Me.btnGroupByResidence.BindableChecked = True
			Me.btnGroupByResidence.Caption = "Group By Residence"
			Me.btnGroupByResidence.Checked = True
			Me.btnGroupByResidence.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.btnGroupByResidence.GroupIndex = 1
			Me.btnGroupByResidence.Id = 5
			Me.btnGroupByResidence.ImageOptions.Image = (CType(resources.GetObject("btnGroupByResidence.ImageOptions.Image"), System.Drawing.Image))
			Me.btnGroupByResidence.ImageOptions.LargeImage = (CType(resources.GetObject("btnGroupByResidence.ImageOptions.LargeImage"), System.Drawing.Image))
			Me.btnGroupByResidence.Name = "btnGroupByResidence"
'			Me.btnGroupByResidence.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnGroupingItemClick);
			' 
			' btnGroupByAge
			' 
			Me.btnGroupByAge.Caption = "Group By Age Category"
			Me.btnGroupByAge.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.btnGroupByAge.GroupIndex = 1
			Me.btnGroupByAge.Id = 6
			Me.btnGroupByAge.ImageOptions.Image = (CType(resources.GetObject("btnGroupByAge.ImageOptions.Image"), System.Drawing.Image))
			Me.btnGroupByAge.ImageOptions.LargeImage = (CType(resources.GetObject("btnGroupByAge.ImageOptions.LargeImage"), System.Drawing.Image))
			Me.btnGroupByAge.Name = "btnGroupByAge"
'			Me.btnGroupByAge.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnGroupingItemClick);
			' 
			' btnGroupByResidenceAndAge
			' 
			Me.btnGroupByResidenceAndAge.Caption = "Group By Residence And Age Category"
			Me.btnGroupByResidenceAndAge.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.btnGroupByResidenceAndAge.GroupIndex = 1
			Me.btnGroupByResidenceAndAge.Id = 7
			Me.btnGroupByResidenceAndAge.ImageOptions.Image = (CType(resources.GetObject("btnGroupByResidenceAndAge.ImageOptions.Image"), System.Drawing.Image))
			Me.btnGroupByResidenceAndAge.ImageOptions.LargeImage = (CType(resources.GetObject("btnGroupByResidenceAndAge.ImageOptions.LargeImage"), System.Drawing.Image))
			Me.btnGroupByResidenceAndAge.Name = "btnGroupByResidenceAndAge"
'			Me.btnGroupByResidenceAndAge.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnGroupingItemClick);
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "Options"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.btnGroupByResidence)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.btnGroupByAge)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.btnGroupByResidenceAndAge)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.btnWithoutGrouping)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "Group Definitions"
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.labelControl1)
			Me.layoutControl1.Controls.Add(Me.treeMapControl1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 141)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(500, 359)
			Me.layoutControl1.TabIndex = 2
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12F)
			Me.labelControl1.Appearance.Options.UseFont = True
			Me.labelControl1.Location = New System.Drawing.Point(137, 12)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(226, 19)
			Me.labelControl1.StyleController = Me.layoutControl1
			Me.labelControl1.TabIndex = 10
			Me.labelControl1.Text = "Forbes World's Billionaires 2010"
			Me.labelControl1.UseMnemonic = False
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(500, 359)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.treeMapControl1
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 23)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(480, 316)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.labelControl1
			Me.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(480, 23)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' Grouping
			' 
			Me.Appearance.Options.UseFont = True
			Me.Controls.Add(Me.layoutControl1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.MenuManager = Me.ribbonControl1
			Me.Name = "Grouping"
			CType(Me.treeMapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private treeMapControl1 As TreeMapControl
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private WithEvents btnWithoutGrouping As XtraBars.BarCheckItem
		Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents btnGroupByResidence As XtraBars.BarCheckItem
		Private WithEvents btnGroupByAge As XtraBars.BarCheckItem
		Private WithEvents btnGroupByResidenceAndAge As XtraBars.BarCheckItem
		Private WithEvents toolTipController1 As DevExpress.Utils.ToolTipController
		Private layoutControl1 As XtraLayout.LayoutControl
		Private labelControl1 As XtraEditors.LabelControl
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
	End Class
End Namespace
