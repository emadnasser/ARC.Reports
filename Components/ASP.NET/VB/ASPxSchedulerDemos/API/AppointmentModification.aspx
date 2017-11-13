<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AppointmentModification.aspx.vb"
	Inherits="ClientSide_AppointmentModification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<script type="text/javascript">
		function OnMenuItemClick(s, e) {
			e.handled = true;
			switch(e.itemName) {
				case ASPx.SchedulerMenuItemId.NewAppointment:
					NewAppointment(scheduler);
					break;
				case ASPx.SchedulerMenuItemId.NewRecurringAppointment:
					NewRecurringAppointment(scheduler);
					break;
				case ASPx.SchedulerMenuItemId.NewAllDayEvent:
					NewAllDayEvent(scheduler);
					break;
				case ASPx.SchedulerMenuItemId.NewRecurringEvent:
					NewRecurringEvent(scheduler);
					break;
				case ASPx.SchedulerMenuItemId.OpenAppointment:
					OpenAppointment(scheduler);
					break;
				case ASPx.SchedulerMenuItemId.EditSeries:
					EditSeries(scheduler);
					break;
				default:
					e.handled = false;
			}
		}
		function OpenAppointment(scheduler) {
			var apt = GetSelectedAppointment(scheduler);
			scheduler.RefreshClientAppointmentProperties(apt, AppointmentPropertyNames.Normal, OnAppointmentRefresh);
		}
		function EditSeries(scheduler) {
			var apt = GetSelectedAppointment(scheduler);
			scheduler.RefreshClientAppointmentProperties(apt, AppointmentPropertyNames.Pattern, OnAppointmentEditSeriesRefresh);
		}
		function OnAppointmentRefresh(apt) {
			ShowAppointmentForm(apt);
		}
		function OnAppointmentEditSeriesRefresh(apt) {
			if(apt.GetRecurrencePattern()) {
				ShowAppointmentForm(apt.GetRecurrencePattern());
			}
		}
		function NewAppointment(scheduler) {
			var apt = CreateAppointment(scheduler)
			ShowAppointmentForm(apt);
		}
		function NewRecurringAppointment(scheduler) {
			var apt = CreateRecurringAppointment(scheduler);
			ShowAppointmentForm(apt);
		}
		function NewRecurringEvent(scheduler) {
			var apt = CreateRecurringEvent(scheduler);
			ShowAppointmentForm(apt);
		}
		function NewAllDayEvent(scheduler) {
			var apt = CreateAllDayEvent(scheduler);
			ShowAppointmentForm(apt);
		}
		function ShowAppointmentForm(apt) {
			MyScriptForm.Clear();
			MyScriptForm.Update(apt);
			if(apt.GetSubject() != "")
				myFormPopup.SetHeaderText(apt.GetSubject() + " - Appointment");
			else
				myFormPopup.SetHeaderText("Untitled - Appointment");
			myFormPopup.Show();
		}
		function CloseAppointmentForm() {
			myFormPopup.Hide();
		}
		function CreateAppointment(scheduler) {
			var apt = new ASPxClientAppointment();
			var selectedInterval = scheduler.GetSelectedInterval();
			apt.SetStart(selectedInterval.GetStart());
			apt.SetEnd(selectedInterval.GetEnd());
			apt.AddResource(scheduler.GetSelectedResource());
			apt.SetLabelId(1);
			apt.SetStatusId(1);
			return apt;
		}
		function CreateRecurringAppointment(scheduler) {
			var apt = CreateAppointment(scheduler);
			apt.SetAppointmentType(ASPxAppointmentType.Pattern);
			var recurrenceInfo = new ASPxClientRecurrenceInfo();
			recurrenceInfo.SetStart(apt.GetStart());
			recurrenceInfo.SetEnd(apt.GetEnd());
			apt.SetRecurrenceInfo(recurrenceInfo);
			return apt;
		}
		function CreateAllDayEvent(scheduler) {
			var apt = CreateAppointment(scheduler);
			var start = apt.interval.start;
			var today = new Date(start.getFullYear(), start.getMonth(), start.getDate());
			apt.SetStart(today);
			apt.SetDuration(24 * 60 * 60 * 1000);
			apt.SetAllDay(true);
			return apt;
		}
		function CreateRecurringEvent(scheduler) {
			var apt = CreateAllDayEvent(scheduler);
			apt.SetAppointmentType(ASPxAppointmentType.Pattern);
			var recurrenceInfo = new ASPxClientRecurrenceInfo();
			recurrenceInfo.SetStart(apt.GetStart());
			recurrenceInfo.SetEnd(apt.GetEnd());
			apt.SetRecurrenceInfo(recurrenceInfo);
			return apt;
		}
		function GetSelectedAppointment(scheduler) {
			var aptIds = scheduler.GetSelectedAppointmentIds();
			if(aptIds.length == 0)
				return;
			var apt = scheduler.GetAppointment(aptIds[0]);
			return apt;
		}
	</script>
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="WorkWeek" GroupType="Resource" 
		AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource" ClientInstanceName="scheduler">
		<ResourceNavigator EnableIncreaseDecrease="false" />
		<Views>
			<DayView ResourcesPerPage="1" VisibleTime-Start="07:00">
				<DayViewStyles ScrollAreaHeight="500px" />
			</DayView>
			<WorkWeekView ResourcesPerPage="1" VisibleTime-Start="07:00">
				<WorkWeekViewStyles ScrollAreaHeight="500px" />
			</WorkWeekView>  
			<WeekView Enabled="false"/>    
			<MonthView ResourcesPerPage="1" AppointmentDisplayOptions-ShowRecurrence="true">
				<MonthViewStyles>
					<DateCellBody Height="150px" />
				</MonthViewStyles>
			</MonthView>
			<TimelineView ResourcesPerPage="1">
				<TimelineViewStyles>
					<TimelineCellBody Height="250px" />
				</TimelineViewStyles>
			</TimelineView>
		</Views>
		<ClientSideEvents MenuItemClicked="function(s, e) { OnMenuItemClick(s,e); }" />
		<Storage EnableReminders="false">
			<Appointments>
				<CustomFieldMappings>
					<dx:ASPxAppointmentCustomFieldMapping Member="ContactInfo" Name="ContactInfo" />
				</CustomFieldMappings>
			</Appointments>
		</Storage>
	</dx:ASPxScheduler>
	<dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" ClientInstanceName="myFormPopup"
		AllowDragging="true" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter"
		PopupAnimationType="None" Width="0px" Height="0px" Modal="true" CloseAction="CloseButton">
		<ClientSideEvents Shown="function(s,e) { s.SetSize(10,10); } " />
		<ContentCollection>
			<dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
				<demo:ScriptAppointmentForm runat="server" ID="AppointmentForm" SchedulerId="ASPxScheduler1"
					ClientInstanceName="MyScriptForm" ClientSideEvents-FormClosed="function(s, e) { CloseAppointmentForm();}" />
			</dx:PopupControlContentControl>
		</ContentCollection>
	</dx:ASPxPopupControl>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>