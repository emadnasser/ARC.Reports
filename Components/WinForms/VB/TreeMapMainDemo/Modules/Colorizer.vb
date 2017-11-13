Imports Microsoft.VisualBasic
Imports System.Drawing

Namespace DevExpress.XtraTreeMap.Demos
	Partial Public Class Colorizer
		Inherits TreeMapTutorialControl
		Private paletteColorizer_Renamed As TreeMapPaletteColorizer
		Private rangeColorizer_Renamed As TreeMapRangeColorizer
		Private gradientColorizer_Renamed As TreeMapGradientColorizer
		Private groupGradientColorizer_Renamed As TreeMapGroupGradientColorizer

		Private ReadOnly Property DataAdapter() As TreeMapFlatDataAdapter
			Get
				Return CType(treeMapControl1.DataAdapter, TreeMapFlatDataAdapter)
			End Get
		End Property
		Private ReadOnly Property PaletteColorizer() As TreeMapPaletteColorizer
			Get
				If paletteColorizer_Renamed Is Nothing Then
					paletteColorizer_Renamed = New TreeMapPaletteColorizer() With {.Palette = Palette.GreenYellowPalette}
				End If
				Return paletteColorizer_Renamed
			End Get
		End Property
		Private ReadOnly Property RangeColorizer() As TreeMapRangeColorizer
			Get
				If rangeColorizer_Renamed Is Nothing Then
					rangeColorizer_Renamed = New TreeMapRangeColorizer() With {.Palette = Palette.CreatePalette(Color.FromArgb(&HD8, &H61, &H0D), Color.FromArgb(&HEF, &H80, &H2B), Color.FromArgb(&HFF, &H9C, &H11), Color.FromArgb(&HFF, &HBB, &H32), Color.FromArgb(&HFF, &HCD, &H7C))}
					rangeColorizer_Renamed.RangeStops.AddRange(New Double() { 0, 59, 95, 300, 1300, 2500 })
				End If
				Return rangeColorizer_Renamed
			End Get
		End Property
		Private ReadOnly Property GradientColorizer() As TreeMapGradientColorizer
			Get
				If gradientColorizer_Renamed Is Nothing Then
					gradientColorizer_Renamed = New TreeMapGradientColorizer() With {.StartColor = Color.FromArgb(&H33, &H33, &H33), .EndColor = Color.FromArgb(&HEE, &HEE, &HEE)}
				End If
				Return gradientColorizer_Renamed
			End Get
		End Property
		Private ReadOnly Property GroupGradientColorizer() As TreeMapGroupGradientColorizer
			Get
				If groupGradientColorizer_Renamed Is Nothing Then
					groupGradientColorizer_Renamed = New TreeMapGroupGradientColorizer() With {.Palette = Palette.InAFogPalette}
				End If
				Return groupGradientColorizer_Renamed
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			DataAdapter.DataSource = Utils.CreateDataSet("USLargestCompanies2011.xml")
			UpdateGroups()
			UpdateColorizer()
		End Sub
		Private Sub UpdateGroups()
			If btnEnableGrouping.Checked Then
				DataAdapter.GroupDataMembers.Add("FieldOfActivity")
			Else
				DataAdapter.GroupDataMembers.Clear()
			End If
		End Sub
		Private Sub UpdateColorizer()
			treeMapControl1.Colorizer = GetColorizer()
		End Sub
		Private Function GetColorizer() As TreeMapColorizerBase
			If btnPalette.Checked Then
				Return PaletteColorizer
			End If
			If btnRange.Checked Then
				Return RangeColorizer
			End If
			If btnGradient.Checked Then
				Return GradientColorizer
			End If
			If btnGroupGradient.Checked Then
				Return GroupGradientColorizer
			End If
			Return Nothing
		End Function
		Private Sub OnColorizerChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles btnGroupGradient.CheckedChanged, btnPalette.CheckedChanged, btnRange.CheckedChanged, btnGradient.CheckedChanged
			UpdateColorizer()
		End Sub
		Private Sub OnEnableGroupingCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles btnEnableGrouping.CheckedChanged
			UpdateGroups()
		End Sub
	End Class
End Namespace
