<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="iCalendarExport.aspx.vb"
	Inherits="iCalendar_iCalendarExport" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<script type="text/javascript">
		function OnMenuClick(s, e) {
			if(e.item.GetItemCount() <= 0) {
				if(e.item.name == "ExportAppointment")
					scheduler.SendPostBack("EXPORTAPT|");
				else
					scheduler.RaiseCallback("MNUAPT|" + e.item.name);
			}
		}
	</script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<demo:DefaultDataSources runat="server" ID="DataSource1" />
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Demo Options">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">
				<dx:ASPxButton ID="ASPxButton1" runat="server" Text="Export appointments" AutoPostBack="False"
					PostBackUrl="~/Default.aspx">
					<ClientSideEvents Click="function(s, e) {
						ASPx.Url.Navigate(&quot;iCalendarExport.aspx?DevExpressCalendar.ics&quot;, &quot;&quot;); 
					}" />
				</dx:ASPxButton>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<br />
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="WorkWeek"
		 ClientInstanceName="scheduler" OnPopupMenuShowing="ASPxScheduler1_PopupMenuShowing"
		OnBeforeExecuteCallbackCommand="ASPxScheduler1_BeforeExecuteCallbackCommand">
		<Views>
			<DayView>
				<DayViewStyles ScrollAreaHeight="400px" />
			</DayView>
			<WorkWeekView>
				<WorkWeekViewStyles ScrollAreaHeight="400px" />
			</WorkWeekView>
			<FullWeekView Enabled="true">
				<FullWeekViewStyles ScrollAreaHeight="400px" />
			</FullWeekView>
			<WeekView Enabled="false"></WeekView>
		</Views>
		<Storage EnableReminders="false">
		</Storage>
	</dx:ASPxScheduler>
</asp:Content>