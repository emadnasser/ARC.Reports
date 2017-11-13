Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ucChoroplethMapItem
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
            Dim baseLayer As New VectorItemsLayer()
            Dim adapter = CreateShapefileDataAdapter()
            baseLayer.Data = adapter
            baseLayer.EnableHighlighting = False
            baseLayer.SelectedItemStyle.StrokeWidth = 0
            mapControl1.Layers.Add(baseLayer)
            Dim fileLayer As New VectorItemsLayer()
            adapter = CreateShapefileDataAdapter()
            AddHandler adapter.ItemsLoaded, AddressOf OnFileLoaded
            fileLayer.Data = adapter
            fileLayer.Colorizer = CreateGDPColorizer()
            fileLayer.ToolTipPattern = "{NAME}"
            mapControl1.Layers.Add(fileLayer)
        End Sub
        Private Function CreateShapefileDataAdapter() As ShapefileDataAdapter
            Dim adapter As New ShapefileDataAdapter()
            Dim path As String = DataLoader.GetRelativePath("USA.shp")
            If (Not String.IsNullOrEmpty(path)) Then
                adapter.FileUri = New System.Uri(path, System.UriKind.Absolute)
            End If
            Return adapter
        End Function
        Private Sub OnFileLoaded(ByVal sender As Object, ByVal e As ItemsLoadedEventArgs)
            For Each item As MapItem In e.Items
                Dim attr As New MapItemAttribute()
                attr.Name = "RevenueYTD"
                Dim mItem As MapItem = item
                Dim value = SalesPerformanceDataGenerator.Current.TotalSales.Where(Function(d) String.Equals(d.State, mItem.Attributes("NAME").Value.ToString())).Sum(Function(d) d.RevenueYTD)
                attr.Value = value
                If value = 0 Then
                    item.Visible = False
                End If
                item.Attributes.Add(attr)
            Next item
        End Sub
        Private Function GetColorItems(ByVal colors As List(Of Color)) As GenericColorizerItemCollection(Of ColorizerColorItem)
            Dim result As New GenericColorizerItemCollection(Of ColorizerColorItem)
            result.BeginUpdate()
            Try
                For Each color As Color In colors
                    result.Add(New ColorizerColorItem(color))
                Next color
            Finally
                result.EndUpdate()
            End Try
            Return result
        End Function
        Private Function CreateGDPColorizer() As ChoroplethColorizer
            Dim colorizer As New ChoroplethColorizer()
            colorizer.ValueProvider = New ShapeAttributeValueProvider() With {.AttributeName = "RevenueYTD"}
            colorizer.RangeStops.AddRange(New List(Of Double)(New Double() {0, 1000000, 2000000, 3000000, 4000000, 5000000, 6000000, 7000000, 8000000, 9000000, 10000000}))
            Dim colors As New List(Of Color)(New Color() {Color.FromArgb(&H5F, &H8B, &H95), Color.FromArgb(&H79, &H96, &H89), Color.FromArgb(&HA2, &HA8, &H75), Color.FromArgb(&HCE, &HBB, &H5F), Color.FromArgb(&HF2, &HCB, &H4E), Color.FromArgb(&HF1, &HC1, &H49), Color.FromArgb(&HE5, &HA8, &H4D), Color.FromArgb(&HD6, &H86, &H4E), Color.FromArgb(&HC5, &H64, &H50), Color.FromArgb(&HBA, &H4D, &H51)})
            colorizer.ColorItems.AddRange(GetColorItems(colors))
            Return colorizer
        End Function
        Private item As MapItem
        Private Sub OnMapItemClick(ByVal sender As Object, ByVal e As MapItemClickEventArgs) Handles mapControl1.MapItemClick
            Dim attr = e.Item.Attributes("RevenueYTD")
            If attr Is Nothing Then
                TryCast(mapControl1.Layers(1), VectorItemsLayer).SelectedItem = item
                Return
            End If
            item = e.Item
            SalesPerformanceDataGenerator.Current.Filter = e.Item.Attributes("NAME").Value.ToString()
        End Sub
    End Class

End Namespace
