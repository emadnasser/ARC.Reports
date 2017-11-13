Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraTreeMap.Demos
	Partial Public Class Colorizer
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
			Dim treeMapFlatDataAdapter1 As New DevExpress.XtraTreeMap.TreeMapFlatDataAdapter()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Colorizer))
			Me.treeMapControl1 = New DevExpress.XtraTreeMap.TreeMapControl()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.btnGroupGradient = New DevExpress.XtraBars.BarCheckItem()
			Me.btnPalette = New DevExpress.XtraBars.BarCheckItem()
			Me.btnRange = New DevExpress.XtraBars.BarCheckItem()
			Me.btnGradient = New DevExpress.XtraBars.BarCheckItem()
			Me.btnEnableGrouping = New DevExpress.XtraBars.BarCheckItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
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
			Me.treeMapControl1.BackColor = System.Drawing.Color.Transparent
			Me.treeMapControl1.BorderOptions.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(157))))), (CInt(Fix((CByte(160))))), (CInt(Fix((CByte(170))))))
			treeMapFlatDataAdapter1.DataMember = Nothing
			treeMapFlatDataAdapter1.LabelDataMember = "CompanyName"
			treeMapFlatDataAdapter1.ValueDataMember = "Assets"
			Me.treeMapControl1.DataAdapter = treeMapFlatDataAdapter1
			Me.treeMapControl1.Location = New System.Drawing.Point(12, 35)
			Me.treeMapControl1.Name = "treeMapControl1"
			Me.treeMapControl1.Size = New System.Drawing.Size(476, 312)
			Me.treeMapControl1.TabIndex = 0
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.btnGroupGradient, Me.btnPalette, Me.btnRange, Me.btnGradient, Me.btnEnableGrouping})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 11
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.Size = New System.Drawing.Size(500, 141)
			' 
			' btnGroupGradient
			' 
			Me.btnGroupGradient.Caption = "Group Gradient Colorizer"
			Me.btnGroupGradient.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.btnGroupGradient.Glyph = (CType(resources.GetObject("btnGroupGradient.Glyph"), System.Drawing.Image))
			Me.btnGroupGradient.GroupIndex = 1
			Me.btnGroupGradient.Id = 3
			Me.btnGroupGradient.LargeGlyph = (CType(resources.GetObject("btnGroupGradient.LargeGlyph"), System.Drawing.Image))
			Me.btnGroupGradient.Name = "btnGroupGradient"
			Me.btnGroupGradient.Tag = 3
'			Me.btnGroupGradient.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnColorizerChanged);
			' 
			' btnPalette
			' 
			Me.btnPalette.BindableChecked = True
			Me.btnPalette.Caption = "Palette Colorizer"
			Me.btnPalette.Checked = True
			Me.btnPalette.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.btnPalette.Glyph = (CType(resources.GetObject("btnPalette.Glyph"), System.Drawing.Image))
			Me.btnPalette.GroupIndex = 1
			Me.btnPalette.Id = 5
			Me.btnPalette.LargeGlyph = (CType(resources.GetObject("btnPalette.LargeGlyph"), System.Drawing.Image))
			Me.btnPalette.Name = "btnPalette"
			Me.btnPalette.Tag = 0
'			Me.btnPalette.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnColorizerChanged);
			' 
			' btnRange
			' 
			Me.btnRange.Caption = "Range Colorizer"
			Me.btnRange.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.btnRange.Glyph = (CType(resources.GetObject("btnRange.Glyph"), System.Drawing.Image))
			Me.btnRange.GroupIndex = 1
			Me.btnRange.Id = 6
			Me.btnRange.LargeGlyph = (CType(resources.GetObject("btnRange.LargeGlyph"), System.Drawing.Image))
			Me.btnRange.Name = "btnRange"
			Me.btnRange.Tag = 1
'			Me.btnRange.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnColorizerChanged);
			' 
			' btnGradient
			' 
			Me.btnGradient.Caption = "Gradient Colorizer"
			Me.btnGradient.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.btnGradient.Glyph = (CType(resources.GetObject("btnGradient.Glyph"), System.Drawing.Image))
			Me.btnGradient.GroupIndex = 1
			Me.btnGradient.Id = 7
			Me.btnGradient.LargeGlyph = (CType(resources.GetObject("btnGradient.LargeGlyph"), System.Drawing.Image))
			Me.btnGradient.Name = "btnGradient"
			Me.btnGradient.Tag = 2
'			Me.btnGradient.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnColorizerChanged);
			' 
			' btnEnableGrouping
			' 
			Me.btnEnableGrouping.BindableChecked = True
			Me.btnEnableGrouping.Caption = "Enable Grouping"
			Me.btnEnableGrouping.Checked = True
			Me.btnEnableGrouping.Glyph = (CType(resources.GetObject("btnEnableGrouping.Glyph"), System.Drawing.Image))
			Me.btnEnableGrouping.Id = 8
			Me.btnEnableGrouping.LargeGlyph = (CType(resources.GetObject("btnEnableGrouping.LargeGlyph"), System.Drawing.Image))
			Me.btnEnableGrouping.Name = "btnEnableGrouping"
'			Me.btnEnableGrouping.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnEnableGroupingCheckedChanged);
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "Options"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.btnPalette)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.btnRange)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.btnGradient)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.btnGroupGradient)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "Colorizer"
			' 
			' ribbonPageGroup2
			' 
			Me.ribbonPageGroup2.ItemLinks.Add(Me.btnEnableGrouping)
			Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
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
			Me.labelControl1.Location = New System.Drawing.Point(150, 12)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(200, 19)
			Me.labelControl1.StyleController = Me.layoutControl1
			Me.labelControl1.TabIndex = 10
			Me.labelControl1.Text = "US Largest Companies 2011"
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
			' Colorizer
			' 
			Me.Appearance.Options.UseFont = True
			Me.Controls.Add(Me.layoutControl1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.MenuManager = Me.ribbonControl1
			Me.Name = "Colorizer"
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
		Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents btnGroupGradient As XtraBars.BarCheckItem
		Private WithEvents btnPalette As XtraBars.BarCheckItem
		Private WithEvents btnRange As XtraBars.BarCheckItem
		Private WithEvents btnGradient As XtraBars.BarCheckItem
		Private WithEvents btnEnableGrouping As XtraBars.BarCheckItem
		Private ribbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
		Private layoutControl1 As XtraLayout.LayoutControl
		Private labelControl1 As XtraEditors.LabelControl
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
	End Class
End Namespace
