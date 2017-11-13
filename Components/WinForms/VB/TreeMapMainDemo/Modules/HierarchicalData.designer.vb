Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraTreeMap.Demos
	Partial Public Class HierarchicalData
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
			Dim treeMapPaletteColorizer1 As New DevExpress.XtraTreeMap.TreeMapPaletteColorizer()
			Dim treeMapHierarchicalDataAdapter1 As New DevExpress.XtraTreeMap.TreeMapHierarchicalDataAdapter()
			Dim treeMapHierarchicalDataMapping1 As New DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping()
			Dim treeMapHierarchicalDataMapping2 As New DevExpress.XtraTreeMap.TreeMapHierarchicalDataMapping()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.btnWithoutGrouping = New DevExpress.XtraBars.BarCheckItem()
			Me.btnGroupByResidence = New DevExpress.XtraBars.BarCheckItem()
			Me.btnGroupByAge = New DevExpress.XtraBars.BarCheckItem()
			Me.btnGroupByResidenceAndAge = New DevExpress.XtraBars.BarCheckItem()
			Me.treeMapControl1 = New DevExpress.XtraTreeMap.TreeMapControl()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeMapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.btnWithoutGrouping, Me.btnGroupByResidence, Me.btnGroupByAge, Me.btnGroupByResidenceAndAge})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 8
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Size = New System.Drawing.Size(731, 47)
			' 
			' btnWithoutGrouping
			' 
			Me.btnWithoutGrouping.Caption = "Without Grouping"
			Me.btnWithoutGrouping.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.btnWithoutGrouping.GroupIndex = 1
			Me.btnWithoutGrouping.Id = 3
			Me.btnWithoutGrouping.Name = "btnWithoutGrouping"
			' 
			' btnGroupByResidence
			' 
			Me.btnGroupByResidence.BindableChecked = True
			Me.btnGroupByResidence.Caption = "Group By Residence"
			Me.btnGroupByResidence.Checked = True
			Me.btnGroupByResidence.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.btnGroupByResidence.GroupIndex = 1
			Me.btnGroupByResidence.Id = 5
			Me.btnGroupByResidence.Name = "btnGroupByResidence"
			' 
			' btnGroupByAge
			' 
			Me.btnGroupByAge.Caption = "Group By Age Category"
			Me.btnGroupByAge.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.btnGroupByAge.GroupIndex = 1
			Me.btnGroupByAge.Id = 6
			Me.btnGroupByAge.Name = "btnGroupByAge"
			' 
			' btnGroupByResidenceAndAge
			' 
			Me.btnGroupByResidenceAndAge.Caption = "Group By Residence And Age Category"
			Me.btnGroupByResidenceAndAge.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
			Me.btnGroupByResidenceAndAge.GroupIndex = 1
			Me.btnGroupByResidenceAndAge.Id = 7
			Me.btnGroupByResidenceAndAge.Name = "btnGroupByResidenceAndAge"
			' 
			' treeMapControl1
			' 
			Me.treeMapControl1.BackColor = System.Drawing.Color.Transparent
			Me.treeMapControl1.BorderOptions.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(157))))), (CInt(Fix((CByte(160))))), (CInt(Fix((CByte(170))))))
			treeMapPaletteColorizer1.Palette = DevExpress.XtraTreeMap.Palette.Office2016Palette
			Me.treeMapControl1.Colorizer = treeMapPaletteColorizer1
			treeMapHierarchicalDataMapping1.ChildrenDataMember = "EnergyStatistic"
			treeMapHierarchicalDataMapping1.LabelDataMember = "Country"
			treeMapHierarchicalDataMapping2.LabelDataMember = "TypeName"
			treeMapHierarchicalDataMapping2.ValueDataMember = "Value"
			treeMapHierarchicalDataAdapter1.Mappings.Add(treeMapHierarchicalDataMapping1)
			treeMapHierarchicalDataAdapter1.Mappings.Add(treeMapHierarchicalDataMapping2)
			Me.treeMapControl1.DataAdapter = treeMapHierarchicalDataAdapter1
			Me.treeMapControl1.Location = New System.Drawing.Point(12, 35)
			Me.treeMapControl1.Name = "treeMapControl1"
			Me.treeMapControl1.Size = New System.Drawing.Size(707, 428)
			Me.treeMapControl1.TabIndex = 1
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.labelControl1)
			Me.layoutControl1.Controls.Add(Me.treeMapControl1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 47)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(731, 475)
			Me.layoutControl1.TabIndex = 3
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12F)
			Me.labelControl1.Location = New System.Drawing.Point(147, 12)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(437, 19)
			Me.labelControl1.StyleController = Me.layoutControl1
			Me.labelControl1.TabIndex = 10
			Me.labelControl1.Text = "Energy Consumption in 2004 (millions of tons, oil equivalent)"
			Me.labelControl1.UseMnemonic = False
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(731, 475)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.treeMapControl1
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 23)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(711, 432)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.labelControl1
			Me.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(711, 23)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' HierarhicalData
			' 
			Me.Appearance.Options.UseFont = True
			Me.Controls.Add(Me.layoutControl1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.MenuManager = Me.ribbonControl1
			Me.Name = "HierarhicalData"
			Me.Size = New System.Drawing.Size(731, 522)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeMapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private btnWithoutGrouping As XtraBars.BarCheckItem
		Private btnGroupByResidence As XtraBars.BarCheckItem
		Private btnGroupByAge As XtraBars.BarCheckItem
		Private btnGroupByResidenceAndAge As XtraBars.BarCheckItem
		Private treeMapControl1 As TreeMapControl
		Private layoutControl1 As XtraLayout.LayoutControl
		Private labelControl1 As XtraEditors.LabelControl
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private layoutControlItem2 As XtraLayout.LayoutControlItem

	End Class
End Namespace
