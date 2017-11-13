<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomMenu.aspx.vb"
	Inherits="Customization_CustomMenu" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" GroupType="Resource"
		OnPopupMenuShowing="ASPxScheduler1_PopupMenuShowing" OnBeforeExecuteCallbackCommand="ASPxScheduler1_BeforeExecuteCallbackCommand"
		AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
		<ResourceNavigator EnableIncreaseDecrease="false" />
		<Storage EnableReminders="false">
			<Appointments>
				<CustomFieldMappings>
					<dx:ASPxAppointmentCustomFieldMapping Name="ContactInfo" Member="ContactInfo" />
				</CustomFieldMappings>
			</Appointments>
		</Storage>
		<Views>
			<DayView ResourcesPerPage="1">
				<DayViewStyles ScrollAreaHeight="400px">
				</DayViewStyles>
			</DayView>
			<WorkWeekView ResourcesPerPage="1">
				<WorkWeekViewStyles ScrollAreaHeight="400px">
				</WorkWeekViewStyles>
			</WorkWeekView>
			<FullWeekView Enabled="true" ResourcesPerPage="1">
				<FullWeekViewStyles ScrollAreaHeight="400px" />
			</FullWeekView>
			<WeekView Enabled="false"/>
			<TimelineView ResourcesPerPage="1">
			</TimelineView>
		</Views>
	</dx:ASPxScheduler>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
	<script type="text/javascript">
	// <![CDATA[
		function DefaultAppointmentMenuHandler(scheduler, s, args) {
			if(args.item.GetItemCount() <= 0)
				scheduler.RaiseCallback("USRAPTMENU|" + args.item.name);
		}
	// ]]> 
	</script>
</asp:Content>