Imports DevExpress.LookAndFeel
Imports DevExpress.SalesDemo.Model
Imports DevExpress.SalesDemo.Win
Imports DevExpress.Utils.Frames
Imports DevExpress.XtraCharts
Imports DevExpress.XtraGauges.Core.Base
Imports DevExpress.XtraGauges.Core.Drawing

Namespace DevExpress.ProductsDemo.Win.Modules
    Partial Public Class AnalyticsModule
        Inherits BaseModule
        Private ReadOnly Property SalesbySecorSeries() As Series
            Get
                Return chartSalesbySecor.Series(0)
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
            Initialize()
            AssignShader()
        End Sub
        Private Sub AssignShader()
            Dim shader = New FlatBackgroundShader(LookAndFeel)
            needleFiscalYear.Shader = shader
            needleFiscalToData.Shader = shader
            arcScaleBackgroundLayerComponent3.Shader = shader
            arcScaleBackgroundLayerComponent4.Shader = shader
        End Sub
        Private Sub Initialize()
            Dim dataProvider As IDataProvider = DataSource.GetDataProvider()
            SalesbySecorSeries.DataSource = dataProvider.GetSalesBySector(New Date(), Date.Now, GroupingPeriod.All)

            dailySalesPerformance.SetSalesPerformanceProvider(New DailySalesPerformance(dataProvider))
            monthlySalesPerformance.SetSalesPerformanceProvider(New MonthlySalesPerformance(dataProvider))

            Dim palette As Palette = ChartUtils.GeneratePalette()
            chartSalesbySecor.PaletteRepository.Add(palette.Name, palette)
            chartSalesbySecor.PaletteName = palette.Name
            AddHandler chartSalesbySecor.CustomDrawSeriesPoint, AddressOf ChartUtils.CustomDrawPieSeriesPoint


            Dim year As Integer = Date.Today.Year
            Dim thisYearSales As SalesGroup = dataProvider.GetTotalSalesByRange(New Date(year, 1, 1), Date.Today)
            Dim fiscalToDataValue As Decimal = thisYearSales.TotalCost
            fiscalToData.Text = fiscalToDataValue.ToString("$0,0")
            needleFiscalToData.Value = CSng(thisYearSales.TotalCost)
            Dim salesForecast As Decimal = SalesForecastMaker.GetYtdForecast(fiscalToDataValue)
            linearScaleRangeBarForecast.Value = CSng(salesForecast / 1000000)

            Dim preYear As Integer = year - 1
            Dim prevYearSales As SalesGroup = dataProvider.GetTotalSalesByRange(New Date(preYear, 1, 1), New Date(preYear, 12, Date.DaysInMonth(preYear, 12)))
            labelFiscalYear.Text = "FISCAL YEAR " & preYear.ToString()
            fiscalYear.Text = prevYearSales.TotalCost.ToString("$0,0")
            needleFiscalYear.Value = CSng(prevYearSales.TotalCost)
        End Sub
        Friend Class FlatBackgroundShader
            Inherits BaseColorShader
            Private ReadOnly backColorToReplace As Color = Color.FromArgb(255, 255, 255)
            Private ReadOnly borderColorToReplace As Color = Color.FromArgb(243, 243, 243)
            Private backColor As Color
            Private borderColor As Color
            Private lookAndFeel As UserLookAndFeel
            Public Sub New(ByVal lookAndFeel As UserLookAndFeel)
                Me.lookAndFeel = lookAndFeel
                AddHandler lookAndFeel.StyleChanged, AddressOf OnStyleChanged
                UpdateColors()
            End Sub
            Private Sub OnStyleChanged(ByVal sender As Object, ByVal e As EventArgs)
                UpdateColors()
            End Sub
            Private Sub UpdateColors()
                backColor = LookAndFeelHelper.GetSystemColorEx(lookAndFeel, SystemColors.Control)
                Dim isDarkSkin As Boolean = FrameHelper.IsDarkSkin(lookAndFeel.ActiveLookAndFeel)
                Dim scale As Double = If(isDarkSkin, 1.2, 0.95)
                borderColor = Color.FromArgb(CInt(Fix(backColor.R * scale)), CInt(Fix(backColor.G * scale)), CInt(Fix(backColor.B * scale)))
            End Sub
            Protected Overrides Sub OnDispose()
                MyBase.OnDispose()
                If lookAndFeel IsNot Nothing Then
                    RemoveHandler lookAndFeel.StyleChanged, AddressOf OnStyleChanged
                    lookAndFeel = Nothing
                End If
            End Sub
            Protected Overrides Sub OnCreate()
            End Sub
            Protected Overrides Sub ProcessCore(ByRef sourceColor As Color)
                If sourceColor = backColorToReplace Then
                    sourceColor = backColor
                End If
                If sourceColor = borderColorToReplace Then
                    sourceColor = borderColor
                End If
            End Sub
            Protected Overrides Function CloneCore() As BaseObject
                Return New FlatBackgroundShader(lookAndFeel)
            End Function
            Protected Overrides Function GetShaderTypeTag() As String
                Return "Empty"
            End Function
            Protected Overrides Function GetShaderDataTag() As String
                Return String.Empty
            End Function
            Protected Overrides Sub Assign(ByVal shaderData As String)
            End Sub
        End Class

        Private Sub chartSalesBySector_CustomDrawSeriesPoint(sender As Object, e As CustomDrawSeriesPointEventArgs) Handles chartSalesbySecor.CustomDrawSeriesPoint
            Dim markerBitmap As Bitmap = CreateLegendMarker(e.LegendMarkerSize, e.LegendDrawOptions.Color)
            e.LegendMarkerImage = markerBitmap
            e.DisposeLegendMarkerImage = True
            Dim value As Double = e.SeriesPoint.Values(0)
            e.LabelText = "$" + DoubleToShortString(value)
            Dim chart As ChartControl = CType(sender, ChartControl)
            If chart.LookAndFeel.ActiveSkinName = "Office 2016 Dark" Then
                e.LegendTextColor = Color.White
            End If
        End Sub

        Private Function CreateLegendMarker(sizeInst As Size, colorInst As Color) As Bitmap
            Dim bmp As Bitmap = New Bitmap(sizeInst.Width, sizeInst.Height)
            Using gr As Graphics = Graphics.FromImage(bmp)
                Using BrushInst As Brush = New SolidBrush(colorInst)
                    gr.FillRectangle(BrushInst, New Rectangle(Point.Empty, Size))
                End Using
            End Using
            Return bmp
        End Function

        Private Function DoubleToShortString(value As Double) As String
            If (value >= 1000000) Then
                Return Math.Round(value / 1000000).ToString() + "M"
            ElseIf (value >= 1000) Then
                Return Math.Round(value / 1000).ToString() + "K"
            Else
                Return value.ToString()
            End If
        End Function
    End Class
End Namespace
