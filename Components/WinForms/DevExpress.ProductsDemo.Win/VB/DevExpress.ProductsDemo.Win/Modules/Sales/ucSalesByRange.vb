﻿Imports System.ComponentModel
Imports DevExpress.SalesDemo.Model
Imports DevExpress.Sparkline
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Core.Base
Imports DevExpress.XtraGauges.Core.Drawing
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win.Gauges.Circular
Imports DevExpress.XtraEditors.Controls
Imports System.Collections

Namespace DevExpress.SalesDemo.Win.Modules
	Partial Public Class ucSalesByRange
		Inherits UserControl

		Private currentDate As Date
		Private provider As ISalesByRangeProvider

		Private rangeControlSalesClient As RangeControlSalesClient

		Private ReadOnly Property Palette() As Palette
			Get
				Return pieChart.PaletteRepository(pieChart.PaletteName)
			End Get
		End Property
		Private ReadOnly Property PieSeries() As Series
			Get
				Return pieChart.Series(0)
			End Get
		End Property
		Private ReadOnly Property BarSeries() As Series
			Get
				Return barChart.Series(0)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()

			Dim palette_Renamed As Palette = ChartUtils.GeneratePalette()
			pieChart.PaletteRepository.Add(palette_Renamed.Name, palette_Renamed)
			pieChart.PaletteName = palette_Renamed.Name
			AddHandler pieChart.CustomDrawSeriesPoint, AddressOf ChartUtils.CustomDrawSeriesPointLegendMarker

			barChart.PaletteRepository.Add(palette_Renamed.Name, palette_Renamed)
			barChart.PaletteName = palette_Renamed.Name
			AddHandler barChart.CustomDrawAxisLabel, AddressOf ChartUtils.CustomDrawAxisYLabel

			rangeControlSalesClient = New RangeControlSalesClient(Palette(3).Color)
		End Sub


		Public Sub SetSalesByRangeProvider(ByVal provider As ISalesByRangeProvider)
			Me.provider = provider
			currentDate = Date.Today

			rangeControl.Client = rangeControlSalesClient
			AddHandler rangeControl.RangeChanged, AddressOf RangeControlRangeChanged

			UpdateRangeControl(currentDate)
		End Sub
		Private Sub RangeControlRangeChanged(ByVal sender As Object, ByVal range As RangeControlRangeEventArgs)
			Dim start As New Date(currentDate.Year, currentDate.Month, CInt(Fix(range.Range.Minimum)) + 1)
			Dim [end] As New Date(currentDate.Year, currentDate.Month, CInt(Fix(range.Range.Maximum)) + 1)
			Dim productSales As IEnumerable(Of SalesGroup) = provider.GetSalesDataForItemForPeriod(start, [end])
			UpdateCharts(productSales)
			UpdateNextButton()
		End Sub

		Private Sub UpdateCharts(ByVal productSales As IEnumerable(Of SalesGroup))
			PieSeries.DataSource = productSales
			BarSeries.DataSource = productSales
		End Sub

		Private Sub UpdateNextButton()
			btnNext.Enabled = (currentDate < Date.Today)
		End Sub
		Private Sub UpdateRangeControl(ByVal dateTime As Date)
			Dim start As New Date(dateTime.Year, dateTime.Month, 1)
			Dim [end] As New Date(dateTime.Year, dateTime.Month, Date.DaysInMonth(dateTime.Year, dateTime.Month))
			Dim sales As IEnumerable(Of SalesGroup) = provider.GetSalesDataForAllItemsForPeriod(start, [end])
			rangeControlSalesClient.UpdateData(sales)
		End Sub

		Private Sub btnPrev_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrev.Click
			currentDate = currentDate.AddMonths(-1)
			UpdateRangeControl(currentDate)
			UpdateNextButton()
		End Sub
		Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			currentDate = currentDate.AddMonths(1)
			If currentDate > Date.Today Then
				currentDate = Date.Today
			End If
			UpdateRangeControl(currentDate)
			UpdateNextButton()
		End Sub
	End Class

	Public Class RangeControlSalesClient
		Implements IRangeControlClient

		Private Const rulerDeltaConst As Integer = 1
		Private events_Renamed As EventHandlerList
		Private currentSparkline As SparklineEdit
		Private data() As SalesGroup
		Private chartColor As Color
		Private ReadOnly Property ItemsCount() As Integer
			Get
				Return data.Count() - 1
			End Get
		End Property
		Private rulerValues(-1) As SalesGroup

		Public Sub New(ByVal chartColor As Color)
			Me.chartColor = chartColor
			currentSparkline = CreateSparkline(chartColor)
		End Sub
		Public YearMonth As Boolean = False

		Public Sub UpdateData(ByVal data As IEnumerable(Of SalesGroup))
			Me.data = data.ToArray()
			GenerateRuler()
			currentSparkline.Dispose()
			currentSparkline = CreateSparkline(chartColor)
			currentSparkline.Data = CreateSparklineData(data)
			RaiseRangeChanged()
		End Sub

		Private Sub GenerateRuler()
			If YearMonth Then
				GenerateYearMonthRuler()
			Else
				GenerateRegularRuler()
			End If
		End Sub

		Private Sub GenerateRegularRuler()
			Dim count As Integer = ItemsCount \ 3
			Me.rulerValues = New SalesGroup(count - 1){}
			For n As Integer = 0 To count - 1
				Dim i As Integer = n * 3
				If i < data.Count() Then
					rulerValues(n) = data(i)
				End If
			Next n
		End Sub

		Private Sub GenerateYearMonthRuler()
			Dim months As New Hashtable()
			For Each sg As SalesGroup In data
				Dim dt As New Date(sg.StartOfPeriod.Year, sg.StartOfPeriod.Month, 1)
				If months.Contains(dt) Then
					Continue For
				End If
				months(dt) = sg
			Next sg
			Me.rulerValues = New SalesGroup(months.Count - 1){}
			Dim i As Integer = 0
			For Each dt As Date In months.Keys.Cast(Of Date)().OrderBy(Function(a) a)
				rulerValues(i) = CType(months(dt), SalesGroup)
				i += 1
			Next dt
		End Sub

		Private Function CreateSparkline(ByVal color As Color) As SparklineEdit
			Dim sparkline As New SparklineEdit()
			sparkline.Properties.View.Color = color
			sparkline.BorderStyle = BorderStyles.NoBorder
			Return sparkline
		End Function

		Private Function CreateSparklineData(ByVal data As IEnumerable(Of SalesGroup)) As Double()
			Dim sparklineData(data.Count() - 1) As Double
			Dim index As Integer = 0
			For Each sale As SalesGroup In data
				sparklineData(index) = CDbl(sale.TotalCost)
				index += 1
			Next sale
			Return sparklineData
		End Function

		Protected ReadOnly Property Events() As EventHandlerList
			Get
				If events_Renamed Is Nothing Then
					events_Renamed = New EventHandlerList()
				End If
				Return events_Renamed
			End Get
		End Property

        Private Shared ReadOnly _rangeChanged As New Object()

		Protected Sub RaiseRangeChanged()
            Dim handler As ClientRangeChangedEventHandler = TryCast(Events(_rangeChanged), ClientRangeChangedEventHandler)
			If handler IsNot Nothing Then
				Dim e As New RangeControlClientRangeEventArgs()
				e.Range = New RangeControlRange(0, data.Count() - 1)
				e.InvalidateContent = True
				handler(Me, e)
			End If
		End Sub

		#Region "IRangeControlClient Members"
		Protected Overridable Sub DrawGraph(ByVal graphics As Graphics, ByVal contentBounds As Rectangle)
			graphics.Clear(Color.Transparent)
			contentBounds.Inflate(1, 1)
			currentSparkline.Size = contentBounds.Size
			currentSparkline.Properties.View = New AreaSparklineView()
			Using bitmap As New Bitmap(currentSparkline.Size.Width, currentSparkline.Size.Height)
				currentSparkline.DrawToBitmap(bitmap, New Rectangle(0, 0, bitmap.Width, bitmap.Height))
				graphics.DrawImage(bitmap, contentBounds.X, contentBounds.Y)
			End Using
		End Sub

		Private ReadOnly Property IRangeControlClient_IsValid() As Boolean Implements IRangeControlClient.IsValid
			Get
				Return True
			End Get
		End Property
		Private ReadOnly Property IRangeControlClient_InvalidText() As String Implements IRangeControlClient.InvalidText
			Get
				Return "invalid"
			End Get
		End Property
		Private Function IRangeControlClient_GetOptions() As Object Implements IRangeControlClient.GetOptions
			Return Me
		End Function
		Private ReadOnly Property IRangeControlClient_RulerDelta() As Object Implements IRangeControlClient.RulerDelta
			Get
				Return rulerDeltaConst
			End Get
		End Property
		Private ReadOnly Property IRangeControlClient_NormalizedRulerDelta() As Double Implements IRangeControlClient.NormalizedRulerDelta ' ItemsCount; } }
			Get
				Return CDbl(rulerDeltaConst) / rulerValues.Length
			End Get
		End Property
		Private ReadOnly Property IRangeControlClient_RangeBoxTopIndent() As Integer Implements IRangeControlClient.RangeBoxTopIndent
			Get
				Return 0
			End Get
		End Property
		Private ReadOnly Property IRangeControlClient_RangeBoxBottomIndent() As Integer Implements IRangeControlClient.RangeBoxBottomIndent
			Get
				Return 0
			End Get
		End Property
		Private ReadOnly Property IRangeControlClient_IsCustomRuler() As Boolean Implements IRangeControlClient.IsCustomRuler
			Get
				Return False
			End Get
		End Property

		Private Function IRangeControlClient_IsValidType(ByVal type As Type) As Boolean Implements IRangeControlClient.IsValidType
			Return True
		End Function
		Private Custom Event RangeChanged As ClientRangeChangedEventHandler Implements IRangeControlClient.RangeChanged
			AddHandler(ByVal value As ClientRangeChangedEventHandler)
                Events.AddHandler(_rangeChanged, value)
			End AddHandler
			RemoveHandler(ByVal value As ClientRangeChangedEventHandler)
                Events.RemoveHandler(_rangeChanged, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
			End RaiseEvent
		End Event
		Private Function IRangeControlClient_SupportOrientation(ByVal orientation As Orientation) As Boolean Implements IRangeControlClient.SupportOrientation
			Return (orientation <> System.Windows.Forms.Orientation.Vertical)
		End Function
		Private Function IRangeControlClient_DrawRuler(ByVal e As RangeControlPaintEventArgs) As Boolean Implements IRangeControlClient.DrawRuler
			Return False
		End Function
		Private Function IRangeControlClient_RulerToString(ByVal index As Integer) As String Implements IRangeControlClient.RulerToString
			If index < rulerValues.Length Then
				Return rulerValues(index).StartOfPeriod.ToString(If(YearMonth, "yyyy/MM", "MM/dd"))
			End If
			Return String.Empty
		End Function
		Private Function IRangeControlClient_GetRuler(ByVal e As RulerInfoArgs) As List(Of Object) Implements IRangeControlClient.GetRuler
			Return Nothing
		End Function
		Private Function IRangeControlClient_GetValue(ByVal normalizedValue As Double) As Object Implements IRangeControlClient.GetValue
			Dim index As Integer = CInt(Fix(normalizedValue * ItemsCount))
			Return index
		End Function
		Private Function IRangeControlClient_GetNormalizedValue(ByVal value As Object) As Double Implements IRangeControlClient.GetNormalizedValue
			If value Is Nothing Then
				Return 0
			End If
			Dim index As Integer = CInt(Fix(value))
			Return (CDbl(index)) / ItemsCount
		End Function
		Private Function IRangeControlClient_ValueToString(ByVal normalizedValue As Double) As String Implements IRangeControlClient.ValueToString
			Dim timeSpan As TimeSpan = data(data.Count() - 1).StartOfPeriod.Subtract(data(0).StartOfPeriod)
			Dim days As Double = Math.Round(timeSpan.TotalDays * normalizedValue)
			Dim [date] As Date = data(0).StartOfPeriod.AddDays(days)
			Return [date].ToString(If(YearMonth, "yyyy/MM", "MM/dd"))
		End Function
		Private Sub IRangeControlClient_DrawContent(ByVal e As RangeControlPaintEventArgs) Implements IRangeControlClient.DrawContent
			DrawGraph(e.Graphics, e.ContentBounds)
		End Sub
		Private Sub IRangeControlClient_ValidateRange(ByVal info As NormalizedRangeInfo) Implements IRangeControlClient.ValidateRange
			Dim start As Integer = CInt(Fix(info.Range.Minimum * ItemsCount))
			Dim [end] As Integer = CInt(Fix(info.Range.Maximum * ItemsCount))
			If [end] = start Then
				[end] = start + 2
			End If

			info.Range.Minimum = CDbl(start) / ItemsCount
			info.Range.Maximum = CDbl([end]) / ItemsCount
		End Sub
		Private Function IRangeControlClient_ValidateScale(ByVal newScale As Double) As Double Implements IRangeControlClient.ValidateScale
			Return 1.0
		End Function
		Private Sub IRangeControlClient_OnRangeChanged(ByVal rangeMinimum As Object, ByVal rangeMaximum As Object) Implements IRangeControlClient.OnRangeChanged
		End Sub
		Private Sub IRangeControlClient_OnRangeControlChanged(ByVal rangeControl As IRangeControl) Implements IRangeControlClient.OnRangeControlChanged
		End Sub
		Private Sub IRangeControlClient_OnResize() Implements IRangeControlClient.OnResize
		End Sub
		Private Sub IRangeControlClient_OnClick(ByVal hitInfo As RangeControlHitInfo) Implements IRangeControlClient.OnClick
		End Sub
		Private Sub IRangeControlClient_Calculate(ByVal contentRect As Rectangle) Implements IRangeControlClient.Calculate
		End Sub
		Private Sub IRangeControlClient_UpdatePressedInfo(ByVal hitInfo As RangeControlHitInfo) Implements IRangeControlClient.UpdatePressedInfo
		End Sub
		Private Sub IRangeControlClient_UpdateHotInfo(ByVal hitInfo As RangeControlHitInfo) Implements IRangeControlClient.UpdateHotInfo
		End Sub
		#End Region
	End Class

	Public Interface ISalesByRangeProvider
		Function GetSalesDataForItemForPeriod(ByVal start As Date, ByVal [end] As Date) As IEnumerable(Of SalesGroup)
		Function GetSalesDataForAllItemsForPeriod(ByVal start As Date, ByVal [end] As Date) As IEnumerable(Of SalesGroup)
	End Interface
End Namespace
