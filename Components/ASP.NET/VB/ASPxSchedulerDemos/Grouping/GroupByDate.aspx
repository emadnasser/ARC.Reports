<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="GroupByDate.aspx.vb"
	Inherits="Grouping_GroupByDate" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="Day" EnableClientRender="false"
		GroupType="Date" AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
		<Views>
			<DayView ResourcesPerPage="2" ShowWorkTimeOnly="true">
				<WorkTime Start="07:00:00" End="20:00:00" />
			</DayView>
			<WorkWeekView ResourcesPerPage="2" ShowWorkTimeOnly="true">
				<WorkTime Start="07:00:00" End="20:00:00" />
			</WorkWeekView>
			<FullWeekView Enabled="true" ResourcesPerPage="2" ShowWorkTimeOnly="true">
				<WorkTime Start="07:00:00" End="20:00:00" />
			</FullWeekView>
			<WeekView Enabled="false" />
			<MonthView ResourcesPerPage="2" ShowWeekend="false">
				<AppointmentDisplayOptions StartTimeVisibility="Never" EndTimeVisibility="Never" StatusDisplayType="Bounds" ShowRecurrence="true"/>
				<MonthViewStyles>
					<DateCellBody Height="170px" />
				</MonthViewStyles>
			</MonthView>
			<TimelineView ResourcesPerPage="2">
				<Scales>
					<dx:TimeScaleMonth />
					<dx:TimeScaleDay />
				</Scales>
				<TimelineViewStyles>
					<TimelineCellBody Height="250px" />
				</TimelineViewStyles>
			</TimelineView>
		</Views>
		<Storage EnableReminders="false" />
	</dx:ASPxScheduler>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>