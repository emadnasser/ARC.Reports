Imports System
Imports System.Web.UI.HtmlControls
Imports DataAccess

Partial Public Class DateSelectorControl
    Inherits UserControlBase

    Private Const CurrentDateKey As String = "CurrentDateKey"

    Public Property SelectionInterval() As SelectionInterval
    Public Property CallbackPanelId() As String
    Public ReadOnly Property Text() As String
        Get
            Return CurrentDate.ToString(GetFormatString()).ToUpper()
        End Get
    End Property
    Public Property CurrentDate() As Date
        Get
            If Not DateSelectorHiddenField.Contains(CurrentDateKey) Then
                DateSelectorHiddenField.Add(CurrentDateKey, Date.Now)
            End If
            Return CDate(DateSelectorHiddenField(CurrentDateKey))
        End Get
        Set(ByVal value As Date)
            DateSelectorHiddenField(CurrentDateKey) = value
        End Set
    End Property


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        PrepareButton(PrevButton, IsPrevButtonEnabled(), -1, "prevButton")
        PrepareButton(NextButton, IsNextButtonEnabled(), 1, "nextButton")
    End Sub
    Private Sub PrepareButton(ByVal button As HtmlGenericControl, ByVal isEnabled As Boolean, ByVal arg As Integer, ByVal className As String)
        button.ClientIDMode = System.Web.UI.ClientIDMode.AutoID
        If isEnabled Then
            button.Attributes("onclick") = String.Format("CallbackHelper.UpdateContent({0}, {1}, {2})", CallbackPanelId, arg, button.ClientID)
            button.Attributes("class") = className & " enabledElement"
        Else
            button.Attributes.Remove("onclick")
            button.Attributes("class") = className & " disabledElement"
        End If
    End Sub
    Private Function GetFormatString() As String
        Select Case SelectionInterval
            Case SelectionInterval.Day
                Return "MMM dd, yyyy"
            Case SelectionInterval.Month
                Return "MMMM, yyyy"
            Case Else
                Return ""
        End Select
    End Function

    Private Function IsPrevButtonEnabled() As Boolean
        Dim minDate As Date = SalesProvider.GetMinDate()

        Dim currentDate_Renamed As Date = CurrentDate
        minDate = DateTimeHelper.GetIntervalStartDate(minDate, SelectionInterval)
        currentDate_Renamed = DateTimeHelper.GetIntervalStartDate(CurrentDate, SelectionInterval)
        Return minDate < currentDate_Renamed
    End Function
    Private Function IsNextButtonEnabled() As Boolean
        Dim maxDate As Date = SalesProvider.GetMaxDate()

        Dim currentDate_Renamed As Date = CurrentDate
        maxDate = DateTimeHelper.GetIntervalEndDate(maxDate, SelectionInterval)
        currentDate_Renamed = DateTimeHelper.GetIntervalEndDate(CurrentDate, SelectionInterval)
        Return maxDate > currentDate_Renamed
    End Function

    Public Sub ChangeDate(ByVal delta As Integer)
        If (delta > 0 AndAlso IsNextButtonEnabled()) OrElse (delta < 0 AndAlso IsPrevButtonEnabled()) Then
            Select Case SelectionInterval
                Case SelectionInterval.Month
                    CurrentDate = CurrentDate.AddMonths(delta)
                Case SelectionInterval.Day
                    CurrentDate = CurrentDate.AddDays(delta)
            End Select
        End If
        PrepareButton(PrevButton, IsPrevButtonEnabled(), -1, "prevButton")
        PrepareButton(NextButton, IsNextButtonEnabled(), 1, "nextButton")
    End Sub

End Class
