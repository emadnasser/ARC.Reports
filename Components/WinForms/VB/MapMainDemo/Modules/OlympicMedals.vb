Imports Microsoft.VisualBasic
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Linq

Namespace DevExpress.XtraMap.Demos
	Partial Public Class OlympicMedals
		Inherits MapTutorialControl
		Private ReadOnly flagsRepository As New FlagsRepository()
		Private gridInitialized As Boolean
		Private focusedCountry As OlympicCountry

		Private ReadOnly Property PieColorLegend() As ColorListLegend
			Get
				Return CType(mapControl1.Legends(0), ColorListLegend)
			End Get
		End Property
		Private ReadOnly Property PieSizeLegend() As SizeLegend
			Get
				Return CType(mapControl1.Legends(1), SizeLegend)
			End Get
		End Property
		Protected ReadOnly Property Callout() As MapCallout
			Get
				Return CType(mapItemStorage1.Items(0), MapCallout)
			End Get
		End Property
		Protected Overrides ReadOnly Property Overlays() As MapOverlay()
			Get
				Return OverlayUtils.GetMedalsOverlay()
			End Get
		End Property
		Public Overrides ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property

		Public Sub New()
			AutoMergeRibbon = True
			InitializeComponent()
			ShapefileDataAdapter.FileUri = New Uri("file:\\" & DemoUtils.GetRelativePath("Countries.shp"), UriKind.RelativeOrAbsolute)
			PrepareDataSource()
		End Sub
		Private Sub PrepareDataSource()
			Me.gridInitialized = False
			Dim countryMedals As New OlympicMedalsDataGenerator()
			PieChartDataAdapter.DataSource = countryMedals.Medals
			Me.gridControl1.DataSource = countryMedals.Countries
			Me.gridView1.BestFitColumns()
			Me.gridInitialized = True
		End Sub
		Private Sub SetFocusedCountry(ByVal value As OlympicCountry, ByVal shouldUpdateMapCenter As Boolean)
			If focusedCountry Is value Then
				Return
			End If
			focusedCountry = value
			OnFocusedCountryChanged(shouldUpdateMapCenter)
		End Sub
		Private Sub OnFocusedCountryChanged(ByVal shouldUpdateMapCenter As Boolean)
			If focusedCountry IsNot Nothing Then
				Dim rowIndex As Integer = gridView1.FindRow(focusedCountry)
				gridView1.FocusedRowHandle = rowIndex
				PieLayer.SelectedItem = focusedCountry.GetMedal()
				If shouldUpdateMapCenter Then
					mapControl1.CenterPoint = focusedCountry.Location
				End If
				ShowCallout()
			Else
				gridView1.FocusInvalidRow()
				PieLayer.SelectedItem = Nothing
				HideCallout()
			End If
		End Sub
		Private Sub ShowCallout()
			Dim country As String = focusedCountry.Country
			If (Not flagsRepository.Contains(country)) Then
				Return
			End If
			Callout.Visible = True
			Callout.Location = focusedCountry.Location
			Callout.Image = flagsRepository.GetFlag(country, True)
			Callout.Text = String.Format("<b>{0}</b><br><br>Gold = {1}<br>Silver = {2}<br>Bronze = {3}<br>Total = {4}", focusedCountry.Name, focusedCountry.Gold, focusedCountry.Silver, focusedCountry.Bronze, focusedCountry.Total)
		End Sub
		Private Sub HideCallout()
			Callout.Visible = False
		End Sub
		Private Sub OnLegendsButtonCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles chkPieColorLegend.CheckedChanged, chkPieInlineLegend.CheckedChanged, chkPieNestedLegend.CheckedChanged
			UpdateLegendsVisibility()
		End Sub
		Private Sub UpdateLegendsVisibility()
			MapControl.SuspendRender()
			PieColorLegend.Visibility = If(chkPieColorLegend.Checked, VisibilityMode.Visible, VisibilityMode.Hidden)
			PieSizeLegend.Visibility = If((chkPieInlineLegend.Checked OrElse chkPieNestedLegend.Checked), VisibilityMode.Visible, VisibilityMode.Hidden)
			PieSizeLegend.Type = If(chkPieInlineLegend.Checked, SizeLegendType.Inline, SizeLegendType.Nested)
			MapControl.ResumeRender()
		End Sub
		Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
			Dim focusedCountry As OlympicCountry = If(e.FocusedRowHandle <> GridControl.InvalidRowHandle, CType(gridView1.GetFocusedRow(), OlympicCountry), Nothing)
			SetFocusedCountry(focusedCountry, Me.gridInitialized)
		End Sub
		Private Sub mapControl1_SelectionChanged(ByVal sender As Object, ByVal e As MapSelectionChangedEventArgs) Handles mapControl1.SelectionChanged
			Dim selectedMedal As Medal = If(e.Selection.Count > 0, CType(e.Selection(0), Medal), Nothing)
			SetFocusedCountry(If(selectedMedal IsNot Nothing, selectedMedal.Country, Nothing), False)
		End Sub
		Protected Overrides Sub InitRibbon()
			MyBase.InitRibbon()
			OptionsPage.Groups.Add(rpgLegendType)
			OptionsPage.Ribbon.Items.AddRange(New BarItem() { chkPieInlineLegend, chkPieNestedLegend })
			ChkLockNavigation.Enabled = False
		End Sub
		Protected Overrides Sub RestoreInitialView()
			MapControl.CenterPoint = New GeoPoint(40, 0)
			MapControl.ZoomLevel = 1.7
		End Sub
		Protected Overrides Function CreateMiniMapLayer() As MiniMapLayerBase
			Dim adapter As ShapefileDataAdapter = New XtraMap.ShapefileDataAdapter()
			adapter.FileUri = New Uri("file:\\" & DemoUtils.GetRelativePath("Countries.shp"), UriKind.RelativeOrAbsolute)
			Dim layer As New MiniMapVectorItemsLayer()
			layer.Data = adapter
			layer.ItemStyle.Fill = Color.White
			layer.ItemStyle.Stroke = Color.FromArgb(95, 139, 149)
			Return layer
		End Function
		#Region "Grid preparation events"
		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			If e.Column.Name <> "PositionGridColumn" Then
				Return
			End If
			If gridView1.SortInfo(0).SortOrder = Data.ColumnSortOrder.Descending Then
				e.Value = gridView1.GetRowHandle(e.ListSourceRowIndex) + 1
			Else
				e.Value = gridView1.RowCount - gridView1.GetRowHandle(e.ListSourceRowIndex)
			End If
		End Sub
		Private Sub gridView1_StartSorting(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.StartSorting
			Dim column As String = gridView1.SortInfo(0).Column.FieldName
			Dim sortOrder As Data.ColumnSortOrder = gridView1.SortInfo(0).SortOrder
			gridView1.SortInfo.AddRange(New GridColumnSortInfo() { New GridColumnSortInfo(gridView1.Columns("Silver"), sortOrder), New GridColumnSortInfo(gridView1.Columns("Bronze"), sortOrder), New GridColumnSortInfo(gridView1.Columns("Name"), Data.ColumnSortOrder.Ascending) })
		End Sub
		Private Sub gridView1_CustomRowCellEdit(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gridView1.CustomRowCellEdit
			If e.Column.FieldName = "Name" Then
				Dim info As String = If(e.CellValue IsNot Nothing, e.CellValue.ToString(), String.Empty)
				If (Not String.IsNullOrEmpty(info)) Then
					Dim key As String = gridView1.GetRowCellValue(e.RowHandle, "Country").ToString().ToLower()
					If (Not flagsRepository.Contains(key)) Then
						Return
					End If
					Dim imageView As New InvariantImageRepositoryItem()
					imageView.PictureGrayed = flagsRepository.GetFlag(key, False)
					imageView.CheckStyle = CheckStyles.UserDefined
					imageView.Caption = "  " & info
					imageView.GlyphAlignment = HorzAlignment.Near
					gridControl1.RepositoryItems.Add(imageView)
					e.RepositoryItem = imageView
				End If
			End If
		End Sub
		#End Region
	End Class

	Public Class Medal
		Private owner As OlympicCountry
		Public Property MedalClass() As Integer
		Public Property Quantity() As Integer
		Public ReadOnly Property Country() As OlympicCountry
			Get
				Return owner
			End Get
		End Property
		Public ReadOnly Property Name() As String
			Get
				Return owner.Name
			End Get
		End Property
		Public ReadOnly Property Location() As GeoPoint
			Get
				Return owner.Location
			End Get
		End Property

		Public Sub New(ByVal owner As OlympicCountry)
			Me.owner = owner
			owner.AddMedal(Me)
		End Sub

	End Class
	Public Class OlympicCountry
		Private ReadOnly medals As New List(Of Medal)()

		Public Property Country() As String
		Public Property Name() As String
		Public Property Location() As GeoPoint
		Public Property Gold() As Integer
		Public Property Silver() As Integer
		Public Property Bronze() As Integer
		Public ReadOnly Property Total() As Integer
			Get
				Return Gold + Silver + Bronze
			End Get
		End Property

		Friend Sub AddMedal(ByVal medal As Medal)
			Me.medals.Add(medal)
		End Sub
		Public Function GetMedal() As Medal
			Return If(medals.Count > 0, medals(0), Nothing)
		End Function
	End Class
	Public Class OlympicMedalsDataGenerator
		Private ReadOnly medals_Renamed As New List(Of Medal)()
		Private ReadOnly countries_Renamed As New List(Of OlympicCountry)()

		Public ReadOnly Property Medals() As List(Of Medal)
			Get
				Return medals_Renamed
			End Get
		End Property
		Public ReadOnly Property Countries() As List(Of OlympicCountry)
			Get
				Return countries_Renamed
			End Get
		End Property

		Public Sub New()
			medals_Renamed.Clear()
			countries_Renamed.Clear()

			Dim dataSet As New DataSet()
			Dim path As String = DemoUtils.GetRelativePath("rio2016.xml")
			dataSet.ReadXml(path)

			CreateObjects(dataSet.Tables(0))
		End Sub
		Private Sub CreateObjects(ByVal source As DataTable)
			Dim data = source.AsEnumerable().GroupBy(Function(row) New With {Key .Country = row.Field(Of String)("Country"), Key .Name = row.Field(Of String)("Name"), Key .Location = New GeoPoint(row.Field(Of Double)("CapitalLat"), row.Field(Of Double)("CapitalLon"))})
			For Each group In data
				Dim country As New OlympicCountry() With {.Location = group.Key.Location, .Country = group.Key.Country.ToLower(), .Name = group.Key.Name}
				Dim medals = group.Select(Function(row) New With {Key .Class = Convert.ToInt32(row("MedalClass")), Key .Quantity = Convert.ToInt32(row("Quantity"))}).ToList()

				For Each item In medals
					Dim medal As New Medal(country) With {.MedalClass = item.Class, .Quantity = item.Quantity}
					Me.Medals.Add(medal)
					SetCountryMedals(country, medal.MedalClass, medal.Quantity)
				Next item
				Countries.Add(country)
			Next group
		End Sub
		Private Sub SetCountryMedals(ByVal country As OlympicCountry, ByVal medalClass As Integer, ByVal quantity As Integer)
			Select Case medalClass
				Case 1
					country.Gold = quantity
				Case 2
					country.Silver = quantity
				Case 3
					country.Bronze = quantity
				Case Else
					Throw New ArgumentException("Undefined medal class")
			End Select
		End Sub
	End Class
End Namespace
