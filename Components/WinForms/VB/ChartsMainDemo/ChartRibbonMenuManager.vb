Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraCharts.Demos

	Public Class ChartRibbonMenuManager
		Inherits RibbonMenuManager
		Private bsiAppearances As BarSubItem
		Private bsiPalettes As BarSubItem

		Public Property CurrentModule() As TutorialControl

		Public Sub New(ByVal form As RibbonMainForm)
			MyBase.New(form)
			CreateChartAppearanceMenu(form.ReservGroup1)
			CreateChartWizardMenu(form.ReservGroup2)
		End Sub
		Private Sub CreateChartAppearanceMenu(ByVal ribbonPageGroup As RibbonPageGroup)
			ribbonPageGroup.Text = "Chart Appearance"
			Dim chart As New ChartControl()
			bsiAppearances = New BarSubItem()
			bsiAppearances.Caption = "Appearance"
			bsiAppearances.Glyph = My.Resources.Appearance_16x16
			bsiAppearances.LargeGlyph = My.Resources.Appearance_32x32
			Dim appearanceNames() As String = chart.GetLocalizedAppearanceNames()
			Dim defaultIndex As Integer = 0
			For i As Integer = 0 To appearanceNames.Length - 1
				Dim cbiAppearanceName As New CheckBarItem(Manager, appearanceNames(i), New ItemClickEventHandler(AddressOf cbiAppearanceName_Click))
				If appearanceNames(i) = chart.AppearanceName Then
					defaultIndex = i
				End If
				bsiAppearances.AddItem(cbiAppearanceName)
			Next i
			ribbonPageGroup.ItemLinks.Add(bsiAppearances)
			If appearanceNames.Length > 0 Then
				Dim item As CheckBarItem = TryCast(bsiAppearances.ItemLinks(defaultIndex).Item, CheckBarItem)
				If bsiAppearances IsNot Nothing Then
					cbiAppearanceName_Click(Manager, New ItemClickEventArgs(item, Nothing))
					item.Checked = True
				End If
			End If
			bsiPalettes = New BarSubItem()
			bsiPalettes.Caption = "Palette"
			bsiPalettes.Glyph = My.Resources.Palette_16x16
			bsiPalettes.LargeGlyph = My.Resources.Palette_32x32
			Dim paletteNames() As String = chart.GetLocalizedPaletteNames()
			defaultIndex = 0
			For i As Integer = 0 To paletteNames.Length - 1
				Dim cbiPaletteName As New CheckBarItem(Manager, paletteNames(i), New ItemClickEventHandler(AddressOf cbiPaletteName_Click))
				If paletteNames(i) = chart.PaletteName Then
					defaultIndex = i
				End If
				bsiPalettes.ItemLinks.Add(cbiPaletteName)
			Next i
			ribbonPageGroup.ItemLinks.Add(bsiPalettes)
			If paletteNames.Length > 0 Then
				Dim item As CheckBarItem = TryCast(bsiPalettes.ItemLinks(defaultIndex).Item, CheckBarItem)
				If bsiPalettes IsNot Nothing Then
					cbiPaletteName_Click(Manager, New ItemClickEventArgs(item, Nothing))
					item.Checked = True
				End If
			End If
			chart.Dispose()
		End Sub
		Private Sub CreateChartWizardMenu(ByVal ribbonPageGroup As RibbonPageGroup)
			ribbonPageGroup.Text = "Designer"
			Dim bbiWizard As New ButtonBarItem(Manager, "Run Chart Designer...", New ItemClickEventHandler(AddressOf bbiWizard_Click))
			bbiWizard.Glyph = My.Resources.Wizard_16x16
			bbiWizard.LargeGlyph = My.Resources.Wizard_32x32
			ribbonPageGroup.ItemLinks.Add(bbiWizard)
		End Sub
		Friend Sub UpdateMenu()
			Dim count As Integer = bsiAppearances.ItemLinks.Count
			For i As Integer = 0 To count - 1
				Dim item As BarCheckItem = TryCast(bsiAppearances.ItemLinks(i).Item, BarCheckItem)
				If item IsNot Nothing AndAlso CurrentModule IsNot Nothing AndAlso CurrentModule.ChartControl IsNot Nothing Then
					item.Checked = item.Caption = CurrentModule.ChartControl.AppearanceName
				End If
			Next i
			If bsiPalettes IsNot Nothing Then
				count = bsiPalettes.ItemLinks.Count
				For i As Integer = 0 To count - 1
					Dim item As BarCheckItem = TryCast(bsiPalettes.ItemLinks(i).Item, BarCheckItem)
					If item IsNot Nothing AndAlso CurrentModule IsNot Nothing AndAlso CurrentModule.ChartControl IsNot Nothing Then
						item.Checked = item.Caption = CurrentModule.ChartControl.PaletteName
					End If
				Next i
			End If
		End Sub
		Private Sub SetAppearanceName(ByVal name As String)
			If bsiAppearances IsNot Nothing Then
				Dim paletteName As String = DemosInfo.SetAppearanceName(name)
				UpdateMenu()
			End If
		End Sub
		Private Sub SetPaletteName(ByVal name As String)
			If bsiPalettes IsNot Nothing Then
				Dim appearanceName As String = DemosInfo.SetPaletteName(name)
				UpdateMenu()
			End If
		End Sub
		Private Sub cbiAppearanceName_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim item As CheckBarItem = TryCast(e.Item, CheckBarItem)
			If item IsNot Nothing Then
				SetAppearanceName(item.Caption)
			End If
		End Sub
		Private Sub cbiPaletteName_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim item As CheckBarItem = TryCast(e.Item, CheckBarItem)
			If item IsNot Nothing Then
				SetPaletteName(item.Caption)
			End If
		End Sub
		Private Sub bbiWizard_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			DemosInfo.RunChartWizard()
		End Sub
	End Class

End Namespace
