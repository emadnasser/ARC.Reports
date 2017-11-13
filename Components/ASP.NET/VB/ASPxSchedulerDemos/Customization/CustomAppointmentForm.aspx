<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomAppointmentForm.aspx.vb"
	Inherits="Customization_CustomAppointmentForm" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource"
		GroupType="Resource" OnAppointmentFormShowing="ASPxScheduler1_AppointmentFormShowing" OnBeforeExecuteCallbackCommand="ASPxScheduler1_BeforeExecuteCallbackCommand">
		<ResourceNavigator EnableIncreaseDecrease="false" />
		<Storage>
			<Appointments>
				<CustomFieldMappings>
					<dx:ASPxAppointmentCustomFieldMapping Name="ContactInfo" Member="ContactInfo" />
				</CustomFieldMappings>
			</Appointments>
		</Storage>
		<OptionsForms AppointmentFormTemplateUrl="~/UserForms/MyAppointmentForm.ascx" />
		<Views>
			<DayView ResourcesPerPage="1" />
			<WorkWeekView ResourcesPerPage="1" />
			<FullWeekView Enabled="true" ResourcesPerPage="1"/>
			<WeekView Enabled="false"/>
			<MonthView ResourcesPerPage="1" />
			<TimelineView ResourcesPerPage="1" />
		</Views>
		<Storage EnableReminders="false" />
	</dx:ASPxScheduler>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>