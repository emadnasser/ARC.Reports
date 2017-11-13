<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomInplaceEditor.aspx.vb"
	Inherits="Customization_CustomInplaceEditor" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" OnBeforeExecuteCallbackCommand="ASPxScheduler1_BeforeExecuteCallbackCommand"
		AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource" GroupType="Resource">
		<ResourceNavigator EnableIncreaseDecrease="false" />
		<Views>
			<DayView ResourcesPerPage="1" />
			<WorkWeekView ResourcesPerPage="1" />
			<FullWeekView Enabled="true" ResourcesPerPage="1" />
			<MonthView ResourcesPerPage="1">
				<MonthViewStyles>
					<DateCellBody Height="100px" />
				</MonthViewStyles>
			</MonthView>
			<TimelineView ResourcesPerPage="1">
				<TimelineViewStyles>
					<TimelineCellBody Height="500px" />
				</TimelineViewStyles>
			</TimelineView>
		</Views>
		<OptionsForms AppointmentInplaceEditorFormTemplateUrl="~/UserForms/MyInplaceEditor.ascx" />
		<Storage EnableReminders="false" />
	</dx:ASPxScheduler>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>