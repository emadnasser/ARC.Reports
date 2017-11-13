<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TimeRulerHeaderTemplate.aspx.vb"
	Inherits="Templates_TimeRulerHeaderTemplate" %>
<%@ Register Namespace="DevExpress.Web.Demos.ASPxScheduler" TagPrefix="demo" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" ActiveViewType="Day" GroupType="Date"
		AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource"
		ClientInstanceName="ASPxClientScheduler1" OnBeforeExecuteCallbackCommand="ASPxScheduler1_BeforeExecuteCallbackCommand">
		<Views>
			<DayView ResourcesPerPage="2">
				<TimeRulers>
					<dx:TimeRuler TimeZoneId="Greenwich" />
					<dx:TimeRuler ShowMinutes="True" />
				</TimeRulers>
				<DayViewStyles>
					<TimeRulerHoursItem Width="57px" />
					<LeftTopCorner>
						<Paddings Padding="2px" />
					</LeftTopCorner>
				</DayViewStyles>
				<Templates>
					<TimeRulerHeaderTemplate>
						<demo:ASPxTimeZoneEditEx runat="server" MasterControlID="ASPxScheduler1" TimeRuler='<%#Container.TimerRuler%>'
							Width="75px" />
					</TimeRulerHeaderTemplate>
				</Templates>
			</DayView>
			<WorkWeekView Enabled="False" />
			<WeekView Enabled="False" />
			<MonthView Enabled="False" />
			<TimelineView Enabled="False" />
		</Views>
		<OptionsBehavior ShowViewSelector="False" />
		<Storage EnableReminders="false" />
	</dx:ASPxScheduler>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>