Imports Microsoft.VisualBasic
Imports System.Data
Imports DevExpress.Utils

Namespace DevExpress.XtraTreeMap.Demos
	Partial Public Class Grouping
		Inherits TreeMapTutorialControl
		Private ReadOnly Property DataAdapter() As TreeMapFlatDataAdapter
			Get
				Return CType(treeMapControl1.DataAdapter, TreeMapFlatDataAdapter)
			End Get
		End Property
		Private ReadOnly Property Colorizer() As TreeMapPaletteColorizer
			Get
				Return CType(treeMapControl1.Colorizer, TreeMapPaletteColorizer)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			DataAdapter.DataSource = Utils.CreateDataSet("Billionares.xml")
			Colorizer.Palette = Palette.Office2016Palette
			UpdateGrouping()
		End Sub

		Private Sub UpdateGrouping()
			DataAdapter.GroupDataMembers.Clear()
			Colorizer.ColorizeGroups = Not btnWithoutGrouping.Checked
			If btnGroupByAge.Checked Then
				DataAdapter.GroupDataMembers.Add("AgeCategory")
			End If
			If btnGroupByResidence.Checked Then
				DataAdapter.GroupDataMembers.Add("Residence")
			End If
			If btnGroupByResidenceAndAge.Checked Then
				DataAdapter.GroupDataMembers.AddRange(New String() { "Residence", "AgeCategory" })
			End If
		End Sub
		Private Sub OnGroupingItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles btnWithoutGrouping.ItemClick, btnGroupByResidence.ItemClick, btnGroupByAge.ItemClick, btnGroupByResidenceAndAge.ItemClick
			UpdateGrouping()
		End Sub

		Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs) Handles toolTipController1.BeforeShow
			Dim item As TreeMapItem = CType(e.SelectedObject, TreeMapItem)
			If (Not item.IsGroup) Then
				Dim superToolTip As New SuperToolTip()
				superToolTip.Items.Add(New ToolTipTitleItem() With {.Text = item.Label})
				superToolTip.Items.Add(New ToolTipSeparatorItem())
				Dim dataRowView As DataRowView = CType(item.Tag, DataRowView)
				superToolTip.Items.Add(New ToolTipItem() With {.Text = dataRowView("Residence").ToString() & ", " & dataRowView("NetWorth").ToString() & "B$"})
				e.SuperTip = superToolTip
			End If
		End Sub
	End Class
End Namespace
