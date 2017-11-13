Imports System
Imports DataAccess
Imports DevExpress.Web

Partial Public Class RangeControl
    Inherits UserControlBase
    Implements IRangeControl

    Private Const ChartUrlPattern As String = "~/Chart.aspx?w=1141px&h=50px&start={0:s}&end={1:s}", CurrentYearSessionKey As String = "CurrentYear"

    Protected Property MinDateTime() As Date
    Protected Property MaxDateTime() As Date
    Protected Property CurrentYear() As Integer
        Get
            If Session(CurrentYearSessionKey) Is Nothing Then
                Session(CurrentYearSessionKey) = Date.Now.Year
            End If
            Return DirectCast(Session(CurrentYearSessionKey), Integer)
        End Get
        Set(ByVal value As Integer)
            Session(CurrentYearSessionKey) = value
        End Set
    End Property

    Public Function GetStartDate() As Date Implements IRangeControl.GetStartDate
        Dim selectedMonth As Integer = NormalizeMonth(CInt((SalesDateRange.PositionStart)) + 1)
        Return DateTimeHelper.GetIntervalStartDate(New Date(CurrentYear, selectedMonth, 1), SelectionInterval.Month)
    End Function
    Public Function GetEndDate() As Date Implements IRangeControl.GetEndDate
        Dim selectedMonth As Integer = NormalizeMonth(CInt((SalesDateRange.PositionEnd)) + 1)
        Return DateTimeHelper.GetIntervalEndDate(New Date(CurrentYear, selectedMonth, 1), SelectionInterval.Month)
    End Function
    Private Function NormalizeMonth(ByVal month As Integer) As Integer
        Return Math.Max(Math.Min(month, 12), 1)
    End Function

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        UpdateMinMaxDate()
        PopulateTrackBarItems()
        If Not IsPostBack Then
            InitializePositions()
        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        PrepareControl()
    End Sub

    Private Function GetBackgroundChartImageUrl() As String
        Return String.Format(ChartUrlPattern, DateTimeHelper.GetIntervalStartDate(New Date(CurrentYear, 1, 1), SelectionInterval.Month), DateTimeHelper.GetIntervalEndDate(New Date(CurrentYear, GetLastPossibleMonth(), 1), SelectionInterval.Month))
    End Function
    Private Function GetLastPossibleMonth() As Integer
        If CurrentYear = Date.Now.Year Then
            Return Date.Now.Month
        End If
        Return 12
    End Function
    Private Sub UpdateMinMaxDate()
        MinDateTime = DateTimeHelper.GetIntervalStartDate(SalesProvider.GetMinDate(), SelectionInterval.Month)
        MaxDateTime = DateTimeHelper.GetIntervalEndDate(SalesProvider.GetMaxDate(), SelectionInterval.Month)
    End Sub
    Private Sub PopulateTrackBarItems()
        SalesDateRange.Items.Clear()
        Dim startDate As New Date(CurrentYear, 1, 1)
        Dim endDate As New Date(CurrentYear, 12, 1)
        If endDate > MaxDateTime Then
            endDate = MaxDateTime
        End If
        If startDate < MinDateTime Then
            startDate = MinDateTime
        End If

        Dim tempDate As Date = startDate
        Do While tempDate <= endDate
            Dim mask As String = If(DateTimeHelper.HasSameYearAndMonth(tempDate, startDate) OrElse DateTimeHelper.HasSameYearAndMonth(tempDate, endDate), "MMM yyyy", "MMM")
            SalesDateRange.Items.Add(tempDate.ToString(mask), tempDate.Month - 1)
            tempDate = tempDate.AddMonths(1)
        Loop
    End Sub
    Private Sub PrepareControl()
        LeftShiftButton.Enabled = MinDateTime.Year < CurrentYear
        RightShiftButton.Enabled = MaxDateTime.Year > CurrentYear
        BackgroundChartImage.ImageUrl = GetBackgroundChartImageUrl()
    End Sub
    Protected Sub CallbackPanel_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
        Dim deltaYear As Integer = Nothing
        If Int32.TryParse(e.Parameter, deltaYear) AndAlso (CurrentYear + deltaYear) <= MaxDateTime.Year AndAlso (CurrentYear + deltaYear) >= MinDateTime.Year Then
            CurrentYear += deltaYear
            PopulateTrackBarItems()
            PrepareControl()
            InitializePositions()
        End If
    End Sub
    Private Sub InitializePositions()
        SalesDateRange.PositionEnd = SalesDateRange.Items.Count - 1
        SalesDateRange.PositionStart = 0
    End Sub
End Class
