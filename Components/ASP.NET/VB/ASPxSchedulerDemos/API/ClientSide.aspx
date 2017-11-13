<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSide.aspx.vb"
	Inherits="ClientSide" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="Timeline" GroupType="Resource"
		AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource" ClientInstanceName="scheduler">
		<ResourceNavigator EnableIncreaseDecrease="false" />
		<Views>
			<DayView ResourcesPerPage="1" />
			<WorkWeekView ResourcesPerPage="1" />
			<FullWeekView ResourcesPerPage="1" Enabled="true" />            
			<WeekView Enabled="false"/>
			<MonthView Enabled="false"/>
			<TimelineView ResourcesPerPage="1">
				<TimelineViewStyles>
					<TimelineCellBody Height="250px" />
				</TimelineViewStyles>
			</TimelineView>
		</Views>
		<ClientSideEvents
			AppointmentClick="function(s, e) { DXEventMonitor.Trace(s, e, 'AppointmentClick'); }"
			AppointmentDrag="function(s, e) { DXEventMonitor.Trace(s, e, 'AppointmentDrag'); }"
			AppointmentDrop="function(s, e) { DXEventMonitor.Trace(s, e, 'AppointmentDrop'); }"
			AppointmentResize="function(s, e) { DXEventMonitor.Trace(s, e, 'AppointmentResize'); }"
			AppointmentResizing="function(s, e) { DXEventMonitor.Trace(s, e, 'AppointmentResizing'); }"
			AppointmentDeleting="function(s, e) { DXEventMonitor.Trace(s, e, 'AppointmentDeleting'); }"
			AppointmentsSelectionChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'AppointmentsSelectionChanged'); }"
			AppointmentDoubleClick="function(s, e) { DXEventMonitor.Trace(s, e, 'AppointmentDoubleClick'); }"
			ActiveViewChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'ActiveViewChanged'); }"
			ActiveViewChanging="function(s, e) { DXEventMonitor.Trace(s, e, 'ActiveViewChanging'); }"
			SelectionChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'SelectionChanged'); }"
			SelectionChanging="function(s, e) { DXEventMonitor.Trace(s, e, 'SelectionChanging'); }"
			VisibleIntervalChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'VisibleIntervalChanged'); }"
			MenuItemClicked="function(s, e) { DXEventMonitor.Trace(s, e, 'MenuItemClicked'); }"
			MoreButtonClicked="function(s, e) { DXEventMonitor.Trace(s, e, 'MoreButtonClicked'); }"
			MouseUp="function(s, e) { DXEventMonitor.Trace(s, e, 'MouseUp'); }"
			BeginCallback="function(s, e) { DXEventMonitor.Trace(s, e, 'BeginCallback'); }"
			CallbackError="function(s, e) { DXEventMonitor.Trace(s, e, 'CallbackError'); }"
			EndCallback="function(s, e) { DXEventMonitor.Trace(s, e, 'EndCallback'); }"
			Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init'); }" />
		<Storage EnableReminders="false">
			<Appointments>
				<CustomFieldMappings>
					<dx:ASPxAppointmentCustomFieldMapping Member="ContactInfo" Name="ContactInfo" />
				</CustomFieldMappings>
			</Appointments>
		</Storage>
	</dx:ASPxScheduler>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
	<br/>
	<br />
	<dx:EventMonitor ID="EventMonitor" runat="server"  ScrollContainerHeight="300" EventLogHeight="300" EventLogWidth="665"
		EventNames="AppointmentClick AppointmentDrag AppointmentDrop AppointmentResize AppointmentResizing AppointmentDeleting
		AppointmentsSelectionChanged AppointmentDoubleClick  SelectionChanged SelectionChanging VisibleIntervalChanged ActiveViewChanged ActiveViewChanging
		MenuItemClicked MoreButtonClicked MouseUp BeginCallback CallbackError EndCallback Init" />
</asp:Content>