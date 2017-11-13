Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraScheduler.Native

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class CustomDrawModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Private carUsageImages As ImageCollection
		Private hatchBrush As Brush = Nothing

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			Me.carUsageImages = ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.car_usage_types.png"), System.Reflection.Assembly.GetExecutingAssembly(), New Size(16, 16))
			' TODO: Add any initialization after the InitializeComponent call
		End Sub

		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property


		Public ReadOnly Property SchedulerAppearances() As BaseAppearanceCollection
			Get
				Return Me.schedulerControl.Appearance
			End Get
		End Property

		Private Sub DayViewModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DemoUtils.FillAppointmentStatuses(Me.schedulerStorage)
			CarsDataHelper.FillData(schedulerControl, schedulerStorage)
			UpdateControls()
		End Sub
		Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.ActiveViewChanged
			UpdateControls()
		End Sub
		Private Sub UpdateControls()
			Dim view As SchedulerViewBase = schedulerControl.ActiveView
			Dim grType As SchedulerGroupType = schedulerControl.GroupType

			Dim isAgendaView As Boolean = TypeOf view Is AgendaView

			chkDayViewAllDayArea.Enabled = TypeOf view Is DayView
			chkWeekViewTopLeftCorner.Enabled = (TypeOf view Is WeekView AndAlso grType.Equals(SchedulerGroupType.Date)) OrElse (TypeOf view Is TimelineView AndAlso (Not grType.Equals(SchedulerGroupType.None)))
			chkGroupSeparator.Enabled = (Not grType.Equals(SchedulerGroupType.None)) AndAlso Not isAgendaView
			chkResourceHeader.Enabled = (Not grType.Equals(SchedulerGroupType.None)) AndAlso Not isAgendaView
			chkDayOfWeekHeader.Enabled = (TypeOf view Is WeekView AndAlso grType.Equals(SchedulerGroupType.Date)) OrElse (TypeOf view Is MonthView AndAlso (Not grType.Equals(SchedulerGroupType.None)))
			chkTimeCell.Enabled = Not isAgendaView
		End Sub
		Private Sub schedulerControl_CustomDrawAppointment(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs) Handles schedulerControl.CustomDrawAppointment
			If (Not chkAppointment.Checked) Then
				Return
			End If

			Dim vi As AppointmentViewInfo = TryCast(e.ObjectInfo, AppointmentViewInfo)
			If vi Is Nothing Then
				Return
			End If

			Dim imgRect As Rectangle = RectUtils.CutFromLeft(vi.InnerBounds, vi.InnerBounds.Width - 18)
			imgRect = RectUtils.AlignRectangle(New Rectangle(0, 0, 16, 16), imgRect, ContentAlignment.MiddleCenter)
			e.Cache.Paint.DrawImage(e.Graphics, carUsageImages.Images(CInt(Fix(vi.Appointment.StatusKey))), imgRect)

			Dim textRect As Rectangle = RectUtils.CutFromRight(vi.InnerBounds, 18)
			vi.Appearance.DrawString(e.Cache, vi.DisplayText, textRect, vi.Appearance.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis))

			If Me.schedulerControl.ActiveViewType = SchedulerViewType.Agenda AndAlso vi.Selected Then
				e.Cache.DrawRectangle(Pens.Black, e.Bounds)
			End If

			e.Handled = True
		End Sub
		Private Sub schedulerControl_CustomDrawAppointmentBackground(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs) Handles schedulerControl.CustomDrawAppointmentBackground
			If (Not chkAppointmentBackground.Checked) Then
				Return
			End If

			Dim aptViewInfo As AppointmentViewInfo = TryCast(e.ObjectInfo, AppointmentViewInfo)
			If aptViewInfo Is Nothing Then
				Return
			End If

			Dim r As Rectangle = e.Bounds
			FillRoundedRect(e.Graphics, GetStatusBrush(aptViewInfo.Status, e.Cache), r, 5)

			r.Inflate(-3, -3)
			Dim br As Brush = e.Cache.GetSolidBrush(Me.schedulerStorage.GetLabelColor(aptViewInfo.Appointment.LabelKey))
			FillRoundedRect(e.Graphics, br, r, 5)
			e.Handled = True
		End Sub
		Private Function GetStatusBrush(ByVal status As IAppointmentStatus, ByVal cache As GraphicsCache) As Brush
			If status.Type = AppointmentStatusType.Tentative Then
				If Me.hatchBrush Is Nothing Then
					Me.hatchBrush = New HatchBrush(HatchStyle.WideUpwardDiagonal, DXColor.White, (CType(status.GetBrush(), SolidBrush)).Color)
				End If
				Return Me.hatchBrush
			End If
			Return status.GetBrush()
		End Function
		Private Sub FillRoundedRect(ByVal gr As Graphics, ByVal br As Brush, ByVal r As Rectangle, ByVal roundRadius As Integer)
			Using rgn As New Region(CreateRoundedRectPath(r, roundRadius))
				gr.FillRegion(br, rgn)
			End Using
		End Sub
		Private Sub schedulerControl_CustomDrawTimeCell(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs) Handles schedulerControl.CustomDrawTimeCell
			If (Not chkTimeCell.Checked) Then
				Return
			End If
			Dim viewInfo As SelectableIntervalViewInfo = TryCast(e.ObjectInfo, SelectableIntervalViewInfo)

			Dim cell As SchedulerViewCellBase = TryCast(e.ObjectInfo, SchedulerViewCellBase)

			If viewInfo.Selected Then
				e.Cache.FillRectangle(SystemBrushes.Highlight, cell.Bounds)
			Else
				FillGradient(e.Cache, cell.Bounds, Color.FromArgb(165, 203, 141), Color.FromArgb(185, 233, 181), 45)
			End If
			e.Handled = True
		End Sub
		Private Sub FillGradient(ByVal cache As GraphicsCache, ByVal r As Rectangle, ByVal c1 As Color, ByVal c2 As Color, ByVal angle As Integer)
			If r.Width <= 0 OrElse r.Height <= 0 Then
				Return
			End If

			Using br As New LinearGradientBrush(r, c1, c2, angle)
				cache.FillRectangle(br, r)
			End Using
		End Sub
		Public Shared Function CreateRoundedRectPath(ByVal r As Rectangle, ByVal radius As Integer) As GraphicsPath
			Dim path As New GraphicsPath()

			path.AddLine(r.Left + radius, r.Top, r.Left + r.Width - radius * 2, r.Top)
			path.AddArc(r.Left + r.Width - radius * 2, r.Top, radius * 2, radius * 2, 270, 90)
			path.AddLine(r.Left + r.Width, r.Top + radius, r.Left + r.Width, r.Top + r.Height - radius * 2)
			path.AddArc(r.Left + r.Width - radius * 2, r.Top + r.Height - radius * 2, radius * 2, radius * 2, 0, 90)
			path.AddLine(r.Left + r.Width - radius * 2, r.Top + r.Height, r.Left + radius, r.Top + r.Height)
			path.AddArc(r.Left, r.Top + r.Height - radius * 2, radius * 2, radius * 2, 90, 90)
			path.AddLine(r.Left, r.Top + r.Height - radius * 2, r.Left, r.Top + radius)
			path.AddArc(r.Left, r.Top, radius * 2, radius * 2, 180, 90)
			path.CloseFigure()
			Return path
		End Function
		Private Sub schedulerControl_CustomDrawResourceHeader(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs) Handles schedulerControl.CustomDrawResourceHeader
			If (Not chkResourceHeader.Checked) Then
				Return
			End If
			Dim header As SchedulerHeader = TryCast(e.ObjectInfo, SchedulerHeader)
			Dim app As AppearanceObject = header.Appearance.HeaderCaption

			Dim grType As SchedulerGroupType = schedulerControl.ActiveView.GroupType
			Dim vertLayout As Boolean = (TypeOf schedulerControl.ActiveView Is WeekView AndAlso grType.Equals(SchedulerGroupType.Date)) OrElse (TypeOf schedulerControl.ActiveView Is TimelineView AndAlso (Not grType.Equals(SchedulerGroupType.None)))

			Dim gradientMode As LinearGradientMode = If(vertLayout, LinearGradientMode.Horizontal, LinearGradientMode.Vertical)

			e.Cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(206, 188, 239), Color.FromArgb(156, 138, 189), gradientMode), e.Bounds)
			Dim innerRect As Rectangle = Rectangle.Inflate(e.Bounds, -2, -2)
			e.Cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(156, 138, 189), Color.FromArgb(206, 188, 239), gradientMode), innerRect)

			Dim sf As StringFormat = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis)
			If vertLayout Then
				e.Cache.DrawVString(header.Caption, app.Font, app.GetForeBrush(e.Cache), innerRect, sf, 270)
			Else
				e.Cache.DrawString(header.Caption, app.Font, app.GetForeBrush(e.Cache), innerRect, sf)
			End If
			e.Handled = True
		End Sub

		Private Sub schedulerControl_CustomDrawWeekViewTopLeftCorner(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs) Handles schedulerControl.CustomDrawWeekViewTopLeftCorner
			If (Not chkWeekViewTopLeftCorner.Checked) Then
				Return
			End If
			e.Cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(176, 158, 209), Color.FromArgb(146, 128, 179), LinearGradientMode.Vertical), e.Bounds)
			Dim innerRect As Rectangle = Rectangle.Inflate(e.Bounds, -2, -2)
			e.Cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(146, 128, 179), Color.FromArgb(176, 158, 209), LinearGradientMode.Vertical), innerRect)
			e.Handled = True
		End Sub

		Private Sub schedulerControl_CustomDrawDayHeader(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs) Handles schedulerControl.CustomDrawDayHeader
			If (Not chkDayHeader.Checked) Then
				Return
			End If

			Dim header As SchedulerHeader = TryCast(e.ObjectInfo, SchedulerHeader)
			Dim app As AppearanceObject = header.Appearance.HeaderCaption

			If e.Bounds.Height > 0 AndAlso e.Bounds.Width > 0 Then
				e.Cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(175, 231, 228), Color.FromArgb(125, 181, 178), LinearGradientMode.Vertical), e.Bounds)
				Dim innerRect As Rectangle = Rectangle.Inflate(e.Bounds, -2, -2)
				e.Cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(125, 181, 178), Color.FromArgb(175, 231, 228), LinearGradientMode.Vertical), innerRect)

				Dim sf As StringFormat = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis)
				e.Cache.DrawString(header.Caption, app.Font, New SolidBrush(Color.Black), innerRect, sf)
			End If
			e.Handled = True
		End Sub

		Private Sub schedulerControl_CustomDrawDayOfWeekHeader(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs) Handles schedulerControl.CustomDrawDayOfWeekHeader
			If (Not chkDayOfWeekHeader.Checked) Then
				Return
			End If
			Dim header As SchedulerHeader = TryCast(e.ObjectInfo, SchedulerHeader)
			Dim app As AppearanceObject = header.Appearance.HeaderCaption

			e.Cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(145, 181, 198), Color.FromArgb(95, 131, 148), LinearGradientMode.Vertical), e.Bounds)
			Dim innerRect As Rectangle = Rectangle.Inflate(e.Bounds, -2, -2)
			e.Cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(95, 131, 148), Color.FromArgb(145, 181, 198), LinearGradientMode.Vertical), innerRect)

			Dim sf As StringFormat = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis)
			e.Cache.DrawString(header.Caption, app.Font, New SolidBrush(Color.White), innerRect, sf)
			e.Handled = True
		End Sub

		Private Sub schedulerControl_CustomDrawGroupSeparator(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs) Handles schedulerControl.CustomDrawGroupSeparator
			If (Not chkGroupSeparator.Checked) Then
				Return
			End If
			Dim c As Color = Color.FromArgb(&HC4, &HA6, &HF4)
			FillGradient(e.Cache, e.Bounds, Color.FromArgb(&HE0, &HCF, &HE9), c, 45)
			e.Cache.DrawRectangle(e.Cache.GetPen(c), e.Bounds)
			e.Handled = True
		End Sub

		Private Sub schedulerControl_CustomDrawDayViewAllDayArea(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs) Handles schedulerControl.CustomDrawDayViewAllDayArea
			If (Not chkDayViewAllDayArea.Checked) Then
				Return
			End If
			Dim viewInfo As SelectableIntervalViewInfo = TryCast(e.ObjectInfo, SelectableIntervalViewInfo)
			If viewInfo IsNot Nothing AndAlso viewInfo.Selected Then
				e.Cache.FillRectangle(SystemBrushes.Highlight, e.Bounds)
				DrawAllDayAreaCaption(e, SystemBrushes.HighlightText)
			Else
				FillGradient(e.Cache, e.Bounds, Color.FromArgb(215, 233, 171), Color.FromArgb(185, 203, 141), 90)
				DrawAllDayAreaCaption(e, Brushes.Black)
			End If
			e.Handled = True
		End Sub
		Private Sub DrawAllDayAreaCaption(ByVal e As CustomDrawObjectEventArgs, ByVal br As Brush)
			Dim app As AppearanceObject = schedulerControl.Appearance.HeaderCaption
			Dim sf As StringFormat = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis)
			e.Cache.DrawString("All Day Events", schedulerControl.DayView.Appearance.AllDayArea.Font, br, e.Bounds, sf)
		End Sub

		Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNavigationButton.CheckedChanged, chkWeekViewTopLeftCorner.CheckedChanged, chkAppointmentBackground.CheckedChanged, chkDayViewAllDayArea.CheckedChanged, chkGroupSeparator.CheckedChanged, chkTimeCell.CheckedChanged, chkDayOfWeekHeader.CheckedChanged, chkAppointment.CheckedChanged, chkDayHeader.CheckedChanged, chkResourceHeader.CheckedChanged
			schedulerControl.ActiveView.LayoutChanged()
		End Sub

		Private Sub schedulerControl_CustomDrawNavigationButton(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs) Handles schedulerControl.CustomDrawNavigationButton
			If (Not chkNavigationButton.Checked) Then
				Return
			End If
			Dim button As NavigationButton = TryCast(e.ObjectInfo, NavigationButton)
			Dim bgBrush As Brush
			If button.Enabled Then
				If button.HotTracked Then
					bgBrush = New LinearGradientBrush(e.Bounds, Color.FromArgb(100, 200, 150), Color.FromArgb(150, 240, 150), LinearGradientMode.Horizontal)
				Else
					bgBrush = New LinearGradientBrush(e.Bounds, Color.FromArgb(100, 180, 150), Color.FromArgb(150, 220, 150), LinearGradientMode.Horizontal)
				End If
			Else
				bgBrush = New LinearGradientBrush(e.Bounds, Color.FromArgb(100, 160, 150), Color.FromArgb(150, 160, 150), LinearGradientMode.Horizontal)
			End If

			Dim borderPen As Pen = If(button.Enabled, Pens.Green, Pens.Gray)
			Dim textBrush As Brush = If(button.Enabled, SystemBrushes.ActiveCaptionText, SystemBrushes.InactiveCaptionText)

			e.Cache.FillRectangle(bgBrush, e.Bounds)
			e.Cache.DrawRectangle(borderPen, e.Bounds)
			Dim app As AppearanceObject = button.Appearance
			Dim sf As StringFormat = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis)
			e.Cache.DrawVString(button.DisplayText, app.Font, textBrush, e.Bounds, sf, 270)
			e.Handled = True
		End Sub
		Private Sub schedulerControl_InitNewAppointment(ByVal sender As Object, ByVal e As AppointmentEventArgs) Handles schedulerControl.InitNewAppointment
			e.Appointment.StatusKey = 0
		End Sub
		Private Sub schedulerControl_GroupTypeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl.GroupTypeChanged
			UpdateControls()
		End Sub
	End Class
End Namespace

