<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FixedSize.aspx.vb"
	Inherits="Sizing_FixedSize" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="Day" GroupType="Resource"
		AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
		<ResourceNavigator EnableIncreaseDecrease="false" />
		<Views>
			<DayView ResourcesPerPage="1">
				<DayViewStyles ScrollAreaHeight="500px" />
				<VisibleTime Start="06:00" End="21:00" />
			</DayView>
			<WorkWeekView ResourcesPerPage="1">
				<WorkWeekViewStyles ScrollAreaHeight="500px" />
				<VisibleTime Start="06:00" End="21:00" />
			</WorkWeekView>
			<FullWeekView Enabled="true" ResourcesPerPage="1">
				<FullWeekViewStyles ScrollAreaHeight="500px" />
				<VisibleTime Start="06:00" End="21:00" />
			</FullWeekView>
			<WeekView Enabled="false" />
			<MonthView ResourcesPerPage="1" WeekCount="4" AppointmentDisplayOptions-ShowRecurrence="true">
				<MonthViewStyles>
					<DateCellBody Height="105px" />
				</MonthViewStyles>
			</MonthView>
			<TimelineView ResourcesPerPage="1">
				<TimelineViewStyles>
					<TimelineCellBody Height="523px" />
				</TimelineViewStyles>
			</TimelineView>
		</Views>
		<Storage EnableReminders="false">
		</Storage>
	</dx:ASPxScheduler>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>