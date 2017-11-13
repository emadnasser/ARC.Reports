Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Calendar
Imports DevExpress.Skins

Namespace DevExpress.XtraEditors.Demos
    Partial Public Class ModuleCalendar
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleCalendar.vb"
            TutorialInfo.WhatsThisXMLFile = "calendar.xml"
            InitComboBoxes()
            InitValues()
            InitCellDataProvider()
        End Sub

        Private Sub InitCellDataProvider()
            Me.calendarControl2.CellStyleProvider = New MyCellStyleProvider()
        End Sub

        Protected Overrides ReadOnly Property AllowCenterControls() As Boolean
            Get
                Return False
            End Get
        End Property

        Private Sub InitComboBoxes()
            icbVistaDisplayMode.Properties.Items.AddEnum(GetType(CalendarView))
            icbShowVistaClock.Properties.Items.AddEnum(GetType(DefaultBoolean))
            icbWeekNumberRule.Properties.Items.AddEnum(GetType(WeekNumberRule))
            icbShowInactiveDays.Properties.Items.AddEnum(GetType(CalendarInactiveDaysVisibility))
            icbFirstDayOfWeek.Properties.Items.AddEnum(GetType(DayOfWeek))
            icbRowCount.Properties.Items.Add(New ImageComboBoxItem("Auto", 0))
            icbRowCount.Properties.Items.Add(New ImageComboBoxItem("1", 1))
            icbRowCount.Properties.Items.Add(New ImageComboBoxItem("2", 2))
            icbRowCount.Properties.Items.Add(New ImageComboBoxItem("3", 3))
            icbColumnCount.Properties.Items.Add(New ImageComboBoxItem("Auto", 0))
            icbColumnCount.Properties.Items.Add(New ImageComboBoxItem("1", 1))
            icbColumnCount.Properties.Items.Add(New ImageComboBoxItem("2", 2))
            icbColumnCount.Properties.Items.Add(New ImageComboBoxItem("3", 3))
        End Sub

        Private updateValues As Boolean
        Private Sub InitValues()
            updateValues = True
            calendarControl1.DateTime = Date.Now
            icbVistaDisplayMode.EditValue = calendarControl1.CalendarView
            icbShowVistaClock.EditValue = calendarControl1.CalendarTimeEditing
            icbWeekNumberRule.EditValue = calendarControl1.WeekNumberRule
            icbShowInactiveDays.EditValue = calendarControl1.InactiveDaysVisibility
            ceShowClear.Checked = calendarControl1.ShowClearButton
            ceShowToday.Checked = calendarControl1.ShowTodayButton
            ceShowWeekNumbers.Checked = calendarControl1.ShowWeekNumbers
            ceShowHeader.Checked = calendarControl1.ShowHeader
            ceShowFooter.Checked = calendarControl1.ShowFooter
            ceShowWeekNumbers.Checked = calendarControl1.ShowWeekNumbers

            icbFirstDayOfWeek.EditValue = calendarControl1.FirstDayOfWeek
            icbRowCount.SelectedIndex = 1
            icbColumnCount.SelectedIndex = 1

            updateValues = False
        End Sub

        Private Sub ceShowHeader_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowHeader.CheckedChanged
            If updateValues Then
                Return
            End If
            Me.calendarControl1.ShowHeader = ceShowHeader.Checked
        End Sub

        Private Sub ceShowFooter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowFooter.CheckedChanged
            If updateValues Then
                Return
            End If
            Me.calendarControl1.ShowFooter = ceShowFooter.Checked
        End Sub

        Private Sub ceShowMonthName_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowMonthName.CheckedChanged
            If updateValues Then
                Return
            End If
            Me.calendarControl1.ShowMonthHeaders = ceShowMonthName.Checked
        End Sub

        Private Sub ceShowClear_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowClear.CheckedChanged
            If updateValues Then
                Return
            End If
            Me.calendarControl1.ShowClearButton = ceShowClear.Checked
        End Sub

        Private Sub ceShowToday_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowToday.CheckedChanged
            If updateValues Then
                Return
            End If
            Me.calendarControl1.ShowTodayButton = ceShowToday.Checked
        End Sub

        Private Sub ceShowWeekNumbers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowWeekNumbers.CheckedChanged
            If updateValues Then
                Return
            End If
            Me.calendarControl1.ShowWeekNumbers = ceShowWeekNumbers.Checked
        End Sub

        Private Sub icbVistaDisplayMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbVistaDisplayMode.SelectedIndexChanged
            If updateValues Then
                Return
            End If
            Dim view As CalendarView = CType(CType(icbVistaDisplayMode.SelectedItem, ImageComboBoxItem).Value, CalendarView)
            Me.calendarControl1.CalendarView = view
            If view = CalendarView.Classic Then
                Me.ceShowToday.Enabled = True
            Else
                Me.ceShowToday.Enabled = False
            End If
        End Sub

        Private Sub icbShowVistaClock_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbShowVistaClock.SelectedIndexChanged
            Dim value As DefaultBoolean = CType(CType(icbShowVistaClock.SelectedItem, ImageComboBoxItem).Value, DefaultBoolean)
            Me.calendarControl1.CalendarTimeEditing = value
        End Sub

        Private Sub icbWeekNumberRule_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbWeekNumberRule.SelectedIndexChanged
            Dim value As WeekNumberRule = CType(CType(icbWeekNumberRule.SelectedItem, ImageComboBoxItem).Value, WeekNumberRule)
            Me.calendarControl1.WeekNumberRule = value
        End Sub

        Private Sub icbFirstDayOfWeek_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbFirstDayOfWeek.SelectedIndexChanged
            Dim value As DayOfWeek = CType(CType(icbFirstDayOfWeek.SelectedItem, ImageComboBoxItem).Value, DayOfWeek)
            Me.calendarControl1.FirstDayOfWeek = value
        End Sub

        Private Sub icbShowInactiveDays_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbShowInactiveDays.SelectedIndexChanged
            Dim value As CalendarInactiveDaysVisibility = CType(CType(icbShowInactiveDays.SelectedItem, ImageComboBoxItem).Value, CalendarInactiveDaysVisibility)
            Me.calendarControl1.InactiveDaysVisibility = value
        End Sub

        Private Sub icbRowCount_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbRowCount.SelectedIndexChanged
            Dim value As Integer = icbRowCount.SelectedIndex
            Me.calendarControl1.RowCount = value
            UpdateCalendarControlSizingMode()
        End Sub

        Private Sub UpdateCalendarControlSizingMode()
            If Me.calendarControl1.ColumnCount = 0 OrElse Me.calendarControl1.RowCount = 0 Then
                MakeCalendarControlSizeable()
            Else
                MakeCalendarControlAutoSize()
            End If
        End Sub

        Protected Function GetCalendarClientRect() As Rectangle
            Dim padding As Integer = 32
            Return New Rectangle(Me.xtraTabPage1.ClientRectangle.X + padding, Me.xtraTabPage1.ClientRectangle.Y + padding, Me.xtraTabPage1.Width - Me.groupControl1.Width - padding * 3, Me.xtraTabPage1.Height - padding * 2)
        End Function

        Private Sub MakeCalendarControlAutoSize()
            Me.calendarControl1.AutoSize = True
            Me.calendarControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Left
            Dim rect As Rectangle = GetCalendarClientRect()
            Me.calendarControl1.Location = New Point(rect.X + (rect.Width - Me.calendarControl1.Width) \ 2, rect.Y + (rect.Height - Me.calendarControl1.Height) \ 2)
        End Sub

        Private Sub MakeCalendarControlSizeable()
            Me.calendarControl1.AutoSize = False
            Me.calendarControl1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            Dim rect As Rectangle = GetCalendarClientRect()
            Me.calendarControl1.Bounds = rect
        End Sub

        Private Sub icbColumnCount_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbColumnCount.SelectedIndexChanged
            Dim value As Integer = icbColumnCount.SelectedIndex
            Me.calendarControl1.ColumnCount = value
            UpdateCalendarControlSizingMode()
        End Sub

        Private Shared ReadOnly Indent As Integer = 16
        Private Sub xtraTabPage1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles xtraTabPage1.Resize
            Me.groupControl1.Location = New Point(Me.xtraTabPage1.Width - Me.groupControl1.Width - Indent, Me.groupControl1.Location.Y)
            UpdateCalendarControlSizingMode()
            UpdatePropertyGridPosition()
        End Sub

        Private Sub UpdatePropertyGridPosition()
            Dim height As Integer = Me.groupControl1.Height + Me.groupControl2.Height + Indent
            Me.groupControl1.Location = New Point(Me.groupControl1.Location.X, Math.Max(Indent, (Me.xtraTabPage1.ClientRectangle.Height - height) \ 2))
            Me.groupControl2.Location = New Point(Me.groupControl1.Location.X, Me.groupControl1.Bottom + Indent)
        End Sub

        Private Sub calendarControl1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles calendarControl1.Resize
            UpdateCalendarControlSizingMode()
        End Sub

        Private Sub calendarControl2_ContextButtonCustomize(ByVal sender As Object, ByVal e As CalendarContextButtonCustomizeEventArgs) Handles calendarControl2.ContextButtonCustomize
            Dim provider As MyCellStyleProvider = CType(Me.calendarControl2.CellStyleProvider, MyCellStyleProvider)
            Dim data As MyCustomCellData = provider.GetCell(e.Cell.Date)
            If data Is Nothing OrElse String.IsNullOrEmpty(data.InfoText) Then
                e.Item.Visibility = ContextItemVisibility.Hidden
                Return
            End If
            e.Item.AllowGlyphSkinning = DefaultBoolean.True
            e.Item.AppearanceHover.ForeColor = e.Cell.Appearance.ForeColor
            e.Item.AppearanceNormal.ForeColor = e.Cell.Appearance.ForeColor
            e.Item.Tag = data
            e.Item.Glyph = data.InfoGlyph
        End Sub

        Private Sub calendarControl2_ContextButtonClick(ByVal sender As Object, ByVal e As ContextItemClickEventArgs) Handles calendarControl2.ContextButtonClick
            Dim data As MyCustomCellData = CType(e.Item.Tag, MyCustomCellData)
            If data Is Nothing Then
                Return
            End If
            Me.memoEdit1.Text = data.InfoText
            Me.flyoutPanel1.ShowBeakForm(New Point(e.ScreenBounds.X + e.ScreenBounds.Width \ 2, e.ScreenBounds.Top - 5))
        End Sub

        Private Sub calendarControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles calendarControl1.SelectionChanged
            Me.listBoxControl1.BeginUpdate()
            Try
                Me.listBoxControl1.Items.Clear()
                For Each range As DateRange In Me.calendarControl1.SelectedRanges
                    Me.listBoxControl1.Items.Add(range.StartDate.ToShortDateString() & " - " & range.EndDate.ToShortDateString())
                Next range
            Finally
                Me.listBoxControl1.EndUpdate()
            End Try
        End Sub
    End Class

    Public Enum CellDataType
        Undefined
        Work
        Family
        Events
    End Enum

    Public Class MyCustomCellData
        Public Property [Date]() As Date
        Public Property ForeColor() As Color
        Public Property BackColor() As Color
        Public Property InfoGlyph() As Image
        Public Property InfoText() As String
        Public Property CellType() As CellDataType

        Public Property Description() As String
        Public Property SpecialDate() As Boolean
    End Class

    Public Class MyCellStyleProvider
        Implements ICalendarCellStyleProvider

        Private cells_Renamed As List(Of MyCustomCellData)
        Protected ReadOnly Property Cells() As List(Of MyCustomCellData)
            Get
                If cells_Renamed Is Nothing Then
                    cells_Renamed = CreateCells()
                End If
                Return cells_Renamed
            End Get
        End Property

        Protected Overridable Function CreateCells() As List(Of MyCustomCellData)
            Dim res As New List(Of MyCustomCellData)()

            res.Add(New MyCustomCellData() With {.Date = New Date(2015, 7, 1), .CellType = CellDataType.Work, .InfoText = "Mexico City. Talks with Pure Products Inc.", .InfoGlyph = My.Resources.Flight})
            res.Add(New MyCustomCellData() With {.Date = New Date(2015, 7, 2), .CellType = CellDataType.Work})

            res.Add(New MyCustomCellData() With {.Date = New Date(2015, 7, 4), .SpecialDate = True, .Description = "INDEPENDENCE DAY"})
            res.Add(New MyCustomCellData() With {.Date = New Date(2015, 7, 6), .CellType = CellDataType.Family, .InfoText = "New York Knicks vs Orlando Magic", .InfoGlyph = My.Resources.Game})
            res.Add(New MyCustomCellData() With {.Date = New Date(2015, 7, 13), .CellType = CellDataType.Family})

            res.Add(New MyCustomCellData() With {.Date = New Date(2015, 7, 10), .CellType = CellDataType.Work, .InfoText = "Call Susanne Guper, New warehouse issues", .InfoGlyph = My.Resources.Meeting})
            res.Add(New MyCustomCellData() With {.Date = New Date(2015, 7, 16), .Description = "JOHN" & ControlChars.Lf & "BIRTHDAY", .SpecialDate = True})

            res.Add(New MyCustomCellData() With {.Date = New Date(2015, 7, 21), .CellType = CellDataType.Events})
            res.Add(New MyCustomCellData() With {.Date = New Date(2015, 7, 22), .Description = "MARY" & ControlChars.Lf & "BIRTHDAY", .SpecialDate = True})
            res.Add(New MyCustomCellData() With {.Date = New Date(2015, 7, 29), .CellType = CellDataType.Events})

            res.Add(New MyCustomCellData() With {.Date = New Date(2015, 7, 17), .CellType = CellDataType.Events, .InfoText = "Flatiron Club", .InfoGlyph = My.Resources.Party})
            res.Add(New MyCustomCellData() With {.Date = New Date(2015, 7, 30), .CellType = CellDataType.Family, .InfoText = "Slow Food Farmers' Market", .InfoGlyph = My.Resources.Shopping})
            res.Add(New MyCustomCellData() With {.Date = New Date(2015, 7, 31), .CellType = CellDataType.Family})

            Return res
        End Function

        Public Function GetCell(ByVal [date] As Date) As MyCustomCellData
            Return Cells.FirstOrDefault(Function(c) c.Date.Date = [date].Date)
        End Function
        Private Sub ICalendarCellStyleProvider_UpdateAppearance(ByVal cell As CalendarCellStyle) Implements ICalendarCellStyleProvider.UpdateAppearance
            Dim cellInfo As MyCustomCellData = GetCell(cell.Date)
            If cellInfo Is Nothing Then
                Return
            End If

            cell.Description = cellInfo.Description
            If cell.Description IsNot Nothing Then
                cell.DescriptionAppearance = DirectCast(cell.Appearance.Clone(), AppearanceObject)
                cell.DescriptionAppearance.Font = New Font(cell.Appearance.Font.FontFamily, 7.0F, FontStyle.Bold)
                cell.DescriptionAppearance.TextOptions.WordWrap = WordWrap.Wrap
            End If
            If Not cellInfo.ForeColor.IsEmpty Then
                cell.Appearance.ForeColor = cellInfo.ForeColor
            End If
            If cell.State = Utils.Drawing.ObjectState.Normal Then
                cell.Appearance.BackColor = GetCellColor(cellInfo, cell)
            End If
            If cellInfo.SpecialDate Then
                cell.Appearance.Font = New Font(cell.Appearance.Font.FontFamily, 20.0F, FontStyle.Bold)
            End If
        End Sub

        Private Function GetCellColor(cellInfo As MyCustomCellData, cell As CalendarCellStyle) As Color
            If cellInfo.CellType = CellDataType.Events Then
                Return SchedulerSkins.GetSkin(cell.PaintStyle.LookAndFeel).Colors.GetColor("ResourceColor02", Color.FromArgb(255, 209, 240, 253))
            End If
            If cellInfo.CellType = CellDataType.Family Then
                Return SchedulerSkins.GetSkin(cell.PaintStyle.LookAndFeel).Colors.GetColor("ResourceColor03", Color.FromArgb(255, 229, 253, 177))
            End If
            If cellInfo.CellType = CellDataType.Work Then
                Return SchedulerSkins.GetSkin(cell.PaintStyle.LookAndFeel).Colors.GetColor("ResourceColor04", Color.FromArgb(255, 255, 228, 239))
            End If

        End Function

    End Class
End Namespace
