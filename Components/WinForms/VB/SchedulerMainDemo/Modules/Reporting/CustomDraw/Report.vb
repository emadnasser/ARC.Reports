Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports System.Drawing
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Native
Imports System.Drawing.Drawing2D
Imports DevExpress.Utils.Controls
Imports DevExpress.Utils

Namespace DevExpress.XtraScheduler.Demos.Reporting.CustomDraw
	''' <summary>
	''' Summary description for Report.
	''' </summary>
	Partial Public Class Report
		Inherits XtraSchedulerReport
		Private carUsageImages As ImageCollection

		Private allowCustomDrawDayHeader_Renamed As Boolean
		Private allowCustomDrawResourceHeader_Renamed As Boolean
		Private allowCustomDrawAllDayArea_Renamed As Boolean
		Private allowCustomDrawTimeCell_Renamed As Boolean
		Private allowCustomDrawTimeRuler_Renamed As Boolean
		Private allowCustomDrawAppointment_Renamed As Boolean
		Private allowCustomDrawAppointmentBackground_Renamed As Boolean

		Public Sub New()

			Me.carUsageImages = ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.car_usage_types.png"), System.Reflection.Assembly.GetExecutingAssembly(), New Size(16, 16))
			InitializeComponent()
		End Sub
		Public Property AllowCustomDrawDayHeader() As Boolean
			Get
				Return allowCustomDrawDayHeader_Renamed
			End Get
			Set(ByVal value As Boolean)
				allowCustomDrawDayHeader_Renamed = value
			End Set
		End Property
		Public Property AllowCustomDrawResourceHeader() As Boolean
			Get
				Return allowCustomDrawResourceHeader_Renamed
			End Get
			Set(ByVal value As Boolean)
				allowCustomDrawResourceHeader_Renamed = value
			End Set
		End Property
		Public Property AllowCustomDrawAllDayArea() As Boolean
			Get
				Return allowCustomDrawAllDayArea_Renamed
			End Get
			Set(ByVal value As Boolean)
				allowCustomDrawAllDayArea_Renamed = value
			End Set
		End Property
		Public Property AllowCustomDrawTimeCell() As Boolean
			Get
				Return allowCustomDrawTimeCell_Renamed
			End Get
			Set(ByVal value As Boolean)
				allowCustomDrawTimeCell_Renamed = value
			End Set
		End Property
		Public Property AllowCustomDrawTimeRuler() As Boolean
			Get
				Return allowCustomDrawTimeRuler_Renamed
			End Get
			Set(ByVal value As Boolean)
				allowCustomDrawTimeRuler_Renamed = value
			End Set
		End Property
		Public Property AllowCustomDrawAppointment() As Boolean
			Get
				Return allowCustomDrawAppointment_Renamed
			End Get
			Set(ByVal value As Boolean)
				allowCustomDrawAppointment_Renamed = value
			End Set
		End Property
		Public Property AllowCustomDrawAppointmentBackground() As Boolean
			Get
				Return allowCustomDrawAppointmentBackground_Renamed
			End Get
			Set(ByVal value As Boolean)
				allowCustomDrawAppointmentBackground_Renamed = value
			End Set
		End Property

		Private Sub dayViewTimeCells1_CustomDrawTimeCell(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs) Handles dayViewTimeCells1.CustomDrawTimeCell
			If (Not AllowCustomDrawTimeCell) Then
				Return
			End If
			Dim cell As TimeCell = CType(e.ObjectInfo, TimeCell)

			Dim rect As Rectangle = e.Bounds
			rect.Height = 1
			rect.Offset(0, rect.Height - 1)
			e.Cache.DrawRectangle(Pens.Gray, rect)

			If TypeOf cell Is ExtendedCell Then
				Dim schema As SchedulerColorSchema = GetResourceColorSchema(cell.Resource)
				cell.Appearance.BackColor = Color.White
				cell.Appearance.BackColor2 = schema.CellLight
				e.DrawDefault()

			Else
				Using sf As New StringFormat()
					sf.Alignment = StringAlignment.Far
					rect = cell.Bounds
					rect.Inflate(-10, 0)
					e.Cache.DrawString(cell.Interval.Start.ToShortTimeString(), e.Cache.GetFont(cell.Appearance.Font, FontStyle.Regular), e.Cache.GetSolidBrush(Color.Gray), rect, sf)
				End Using
			End If
			e.Handled = True
		End Sub

		Private Sub dayViewTimeRuler1_CustomDrawDayViewTimeRuler(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs) Handles dayViewTimeRuler1.CustomDrawDayViewTimeRuler
			If (Not AllowCustomDrawTimeRuler) Then
				Return
			End If

			e.Cache.FillRectangle(e.Cache.GetSolidBrush(Color.LightYellow), e.Bounds)
			Using sf As New StringFormat()
				sf.Alignment = StringAlignment.Center
				sf.LineAlignment = StringAlignment.Center

				e.Cache.DrawVString(TimeZoneInfo.Local.DisplayName, e.Cache.GetFont(New Font(Font.FontFamily, 20, FontStyle.Bold), FontStyle.Bold), e.Cache.GetSolidBrush(Color.Gray), e.Bounds, sf, -90)

				e.Handled = True
			End Using

		End Sub

		Private Sub horizontalResourceHeaders1_CustomDrawResourceHeader(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs) Handles horizontalResourceHeaders1.CustomDrawResourceHeader
			If (Not AllowCustomDrawResourceHeader) Then
				Return
			End If

			Dim header As ResourceHeader = CType(e.ObjectInfo, ResourceHeader)
			DrawHeaderUsingColorSchema(header, e.Cache)
			e.DrawDefault()
			e.Handled = True
		End Sub
		Private Sub horizontalDateHeaders1_CustomDrawDayHeader(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs) Handles horizontalDateHeaders1.CustomDrawDayHeader
			If (Not AllowCustomDrawDayHeader) Then
				Return
			End If

			Dim header As DayHeader = CType(e.ObjectInfo, DayHeader)
			DrawHeaderUsingColorSchema(header, e.Cache)

			e.DrawDefault()
			e.Handled = True
		End Sub

		Private Sub DrawHeaderUsingColorSchema(ByVal header As SchedulerHeader, ByVal cache As DevExpress.Utils.Drawing.GraphicsCache)
			Dim schema As SchedulerColorSchema = GetResourceColorSchema(header.Resource)

			header.Appearance.HeaderCaption.BackColor = schema.CellLight
			header.Appearance.HeaderCaption.BackColor2 = schema.Cell

			Dim color As Color = schema.CellBorderDark
			header.Appearance.HeaderCaption.ForeColor = TransformColor(color, 0.6)
			header.Appearance.HeaderCaption.Font = cache.GetFont(header.Appearance.HeaderCaption.Font, FontStyle.Bold)
		End Sub

		Private Function TransformColor(ByVal color As Color, ByVal light As Double) As Color
			Return Color.FromArgb(CInt(Fix(color.R * light)), CInt(Fix(color.G * light)), CInt(Fix(color.B * light)))
		End Function

		Private Sub dayViewTimeCells1_CustomDrawDayViewAllDayArea(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs) Handles dayViewTimeCells1.CustomDrawDayViewAllDayArea
			If (Not AllowCustomDrawAllDayArea) Then
				Return
			End If

			Dim cell As AllDayAreaCell = CType(e.ObjectInfo, AllDayAreaCell)
			Dim schema As SchedulerColorSchema = GetResourceColorSchema(cell.Resource)

			cell.Appearance.BackColor = schema.Cell
			cell.Appearance.BackColor2 = schema.CellBorder
		End Sub

		Private Sub dayViewTimeCells1_CustomDrawAppointmentBackground(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs) Handles dayViewTimeCells1.CustomDrawAppointmentBackground
			If (Not AllowCustomDrawAppointmentBackground) Then
				Return
			End If

			e.DrawDefault()
			Dim vi As AppointmentViewInfo = CType(e.ObjectInfo, AppointmentViewInfo)
			Dim rect As Rectangle = vi.Bounds
			rect.Inflate(-vi.LeftBorderBounds.Width, -vi.TopBorderBounds.Height)

			Dim brush As Brush = e.Cache.GetGradientBrush(rect, Color.White, vi.Appearance.BackColor, LinearGradientMode.Vertical)
			e.Cache.FillRectangle(brush, rect)
			e.Handled = True
		End Sub

		Private Sub dayViewTimeCells1_CustomDrawAppointment(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs) Handles dayViewTimeCells1.CustomDrawAppointment
			If (Not AllowCustomDrawAppointment) Then
				Return
			End If

			Dim vi As AppointmentViewInfo = CType(e.ObjectInfo, AppointmentViewInfo)

			Dim imgRect As Rectangle = RectUtils.CutFromLeft(vi.InnerBounds, vi.InnerBounds.Width - 18)
			imgRect = RectUtils.AlignRectangle(New Rectangle(0, 0, 16, 16), imgRect, ContentAlignment.MiddleCenter)
			e.Cache.Paint.DrawImage(e.Graphics, carUsageImages.Images(CInt(Fix(vi.Appointment.StatusKey))), imgRect)

			Dim textRect As Rectangle = RectUtils.CutFromRight(vi.InnerBounds, 18)
			Using sf As New StringFormat()
				Dim brush As Brush = e.Cache.GetSolidBrush(vi.Appearance.ForeColor)

				Dim fntBold As Font = e.Cache.GetFont(vi.Appearance.Font, FontStyle.Bold)
				Dim fntItalic As Font = e.Cache.GetFont(vi.Appearance.Font, FontStyle.Italic)

				If vi.Appointment.LongerThanADay Then
					Dim rowRects() As Rectangle = RectUtils.SplitHorizontally(textRect, 2)
					Dim hours As String = String.Format(" [{0:F2} h]", vi.AppointmentInterval.Duration.TotalHours)
					e.Cache.DrawString(vi.DisplayText & hours, fntBold, brush, textRect, sf)
				Else
					Dim rects() As Rectangle = RectUtils.SplitVertically(textRect, 3)
					e.Cache.DrawString(vi.Interval.Start.ToShortTimeString() & " " & vi.Interval.End.ToShortTimeString(), vi.Appearance.Font, brush, rects(0), sf)

					e.Cache.DrawString(String.Format("{0} [{1}]", vi.Appointment.Subject, vi.Appointment.Location), fntBold, brush, rects(1), sf)
					e.Cache.DrawString(vi.Description, fntItalic, brush, rects(2), sf)
				End If
			End Using
			e.Handled = True
		End Sub

	End Class
End Namespace
