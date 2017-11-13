<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BoundMode.aspx.vb"
	Inherits="DataBinding_BoundMode" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="ResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" /> 
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" GroupType="Resource"
		ResourceDataSourceID="ResourceDataSource" AppointmentDataSourceID="AppointmentDataSource">
		<ResourceNavigator EnableIncreaseDecrease="false" />
		<Storage EnableReminders="false">
			<Appointments CommitIdToDataSource="false">               
				<Mappings AppointmentId="ID" End="EndTime" Start="StartTime" Subject="Subject" Description="Description"
					Location="Location" AllDay="AllDay" Type="EventType" RecurrenceInfo="RecurrenceInfo"
					ReminderInfo="ReminderInfo" Label="Label" Status="Status" ResourceId="MedicId" />
			</Appointments>
			<Resources>
				<Mappings ResourceId="ID" Caption="DisplayName" />
			</Resources>
		</Storage>
		<Views>
			<DayView ResourcesPerPage="1" ShowWorkTimeOnly="true">
				<WorkTime Start="07:00:00" End="20:00:00" />
			</DayView>
			<WorkWeekView ResourcesPerPage="1" ShowWorkTimeOnly="true">
				<WorkTime Start="07:00:00" End="20:00:00" />
			</WorkWeekView>
			<WeekView Enabled="false"/>
			<MonthView Enabled="false" />
			<TimelineView ResourcesPerPage="1" />
		</Views>
	</dx:ASPxScheduler>
</asp:Content>