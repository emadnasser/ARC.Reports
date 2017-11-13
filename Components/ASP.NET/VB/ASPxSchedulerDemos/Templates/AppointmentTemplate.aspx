<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AppointmentTemplate.aspx.vb"
	Inherits="Templates_AppointmentTemplate" %>
<%@ Register Src="~/UserAppointments/VerticalAppointment.ascx" TagName="VerticalAppointment" TagPrefix="demo" %>
<%@ Register Src="~/UserAppointments/HorizontalAppointment.ascx" TagName="HorizontalAppointment" TagPrefix="demo" %>
<%@ Register Src="~/UserAppointments/HorizontalSameDayAppointment.ascx" TagName="HorizontalSameDayAppointment" TagPrefix="demo" %>
<%@ Register Src="~/UserAppointments/HorizontalAlldayAreaAppointment.ascx" TagName="HorizontalAlldayAreaAppointment" TagPrefix="demo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
	<link rel="stylesheet" type="text/css" href="../Content/AppointmentTemplates/styles.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table style="width:100%">
		<tr>
			<td>
				<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" ActiveViewType="Day" GroupType="Resource"
					AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource"
					ClientInstanceName="ASPxClientScheduler1">
					<ResourceNavigator EnableIncreaseDecrease="false" />
					<Views>
						<DayView ResourcesPerPage="1">
							<AppointmentDisplayOptions AppointmentAutoHeight="false" AppointmentHeight="30" StartTimeVisibility="always"
								EndTimeVisibility="always" />
							<DayViewStyles>
							</DayViewStyles>
							<TimeRulers>
								<dx:TimeRuler></dx:TimeRuler>
							</TimeRulers>
							<Templates>
								<VerticalAppointmentTemplate>
									<demo:VerticalAppointment runat="server" />
								</VerticalAppointmentTemplate>
								<HorizontalAppointmentTemplate>
									<demo:HorizontalAlldayAreaAppointment ID="HorizontalAppointment2" runat="server" />
								</HorizontalAppointmentTemplate>
							</Templates>
						</DayView>
						<WorkWeekView ResourcesPerPage="1">
							<AppointmentDisplayOptions AppointmentAutoHeight="false" AppointmentHeight="30" StartTimeVisibility="always"
								EndTimeVisibility="always" />
							<Templates>
								<HorizontalAppointmentTemplate>
									<demo:HorizontalAlldayAreaAppointment ID="HorizontalAppointment1" runat="server" />
								</HorizontalAppointmentTemplate>
								<VerticalAppointmentTemplate>
									<demo:VerticalAppointment runat="server" />
								</VerticalAppointmentTemplate>
							</Templates>
						</WorkWeekView>
						<FullWeekView Enabled="true" ResourcesPerPage="1">
							<AppointmentDisplayOptions AppointmentAutoHeight="false" AppointmentHeight="30" StartTimeVisibility="always"
								EndTimeVisibility="always" />
							<Templates>
								<HorizontalAppointmentTemplate>
									<demo:HorizontalAlldayAreaAppointment ID="HorizontalAlldayAreaAppointment1" runat="server" />
								</HorizontalAppointmentTemplate>
								<VerticalAppointmentTemplate>
									<demo:VerticalAppointment runat="server" />
								</VerticalAppointmentTemplate>
							</Templates>
						</FullWeekView>
						<WeekView Enabled="false" />
						<MonthView ResourcesPerPage="1">
							<AppointmentDisplayOptions AppointmentAutoHeight="false" AppointmentHeight="40" />
							<Templates>
								<HorizontalAppointmentTemplate>
									<demo:HorizontalAppointment runat="server" />
								</HorizontalAppointmentTemplate>
								<HorizontalSameDayAppointmentTemplate>
									<demo:HorizontalSameDayAppointment runat="server" />
								</HorizontalSameDayAppointmentTemplate>
							</Templates>
						</MonthView>
						<TimelineView ResourcesPerPage="1">
							<AppointmentDisplayOptions AppointmentAutoHeight="false" AppointmentHeight="35" />
							<Templates>
								<HorizontalAppointmentTemplate>
									<demo:HorizontalAppointment runat="server" />
								</HorizontalAppointmentTemplate>
							</Templates>
						</TimelineView>
					</Views>
					<Storage EnableReminders="false "/>
				</dx:ASPxScheduler>
			</td>
		</tr>
	</table>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>