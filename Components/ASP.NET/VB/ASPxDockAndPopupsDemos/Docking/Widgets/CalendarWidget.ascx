<%@ Control Language="vb" ClassName="CalendarWidget" %>
<script runat="server">
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Calendar.SelectedDate = New DateTime(DateTime.Now.Year, 3, 14)
	End Sub
</script>
<dx:ASPxCalendar runat="server" ID="Calendar" ShowClearButton="false" ShowHeader="false"
	ShowTodayButton="false" ShowWeekNumbers="false" HighlightToday="false" Width="100%">
	<Border BorderStyle="None" />
</dx:ASPxCalendar>