<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FixedWidth.aspx.vb"
	Inherits="Sizing_FixedWidth" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="300px" ActiveViewType="Day" GroupType="Resource"
		AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
		<ResourceNavigator EnableIncreaseDecrease="false" />
		<Views>
			<DayView ResourcesPerPage="1" />
			<WorkWeekView ResourcesPerPage="1" />
			<WeekView Enabled="false"/>
			<MonthView ResourcesPerPage="1" />
			<FullWeekView Enabled="true" ResourcesPerPage="1"/>
			<TimelineView ResourcesPerPage="1" />
		</Views>
		<Storage EnableReminders="false">
		</Storage>
	</dx:ASPxScheduler>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>