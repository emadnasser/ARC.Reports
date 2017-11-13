<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomWorkTime.aspx.vb"
	Inherits="Miscellaneous_CustomWorkTime" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<script type="text/javascript">
		function onAppointmentIntervalChanging(sender, event) {
			if (event.dragInformation) {
				var i = 0;
				var allowIntervalChange = true;
				var dragInfo = event.dragInformation[i];
				do {
					allowIntervalChange = isIntervalValid(dragInfo);
					i++;
				} while (event.dragInformation.length > i && allowIntervalChange);
			}
			else {
				allowIntervalChange = isIntervalValid(event);
			}
			event.allow = allowIntervalChange;
		}
		function isIntervalValid(dragInfo) {
			var newInterval = dragInfo.newInterval;
			var endTime = newInterval.start.getTime() + newInterval.duration;
			var endDate = new Date();
			endDate.setTime(endTime);
			var resource = dragInfo.newResources ? dragInfo.newResources[0] : ASPxClientScheduler1.GetSelectedResource();
			var workTimes = ASPxClientScheduler1.cp_workTimes;
			var arrayIndex, workTime;

			if (!chkCustomWorkTime.GetChecked()) {
				workTime = workTimes[0];
			}
			else if (resource == 0) {
				if (newInterval.start.getDay() % 2 == 0)
					workTime = workTimes[0];
				else
					return false;
			}
			else {
				workTime = workTimes[resource % workTimes.length];
			}
			var startWorkHour = workTime ? workTime.Start.split(':')[0] : null;
			var endWorkHour = workTime ? workTime.End.split(':')[0] : null;
			endWorkHour = (endWorkHour == "1.00") ? 24 : endWorkHour;
			return workTime && newInterval.start.getHours() >= startWorkHour && endDate.getHours() <= endWorkHour
				&& newInterval.start.getHours() < endDate.getHours();
		}
	</script>
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Demo Options">
		<panelcollection>
			<dx:PanelContent runat="server">
				<dx:ASPxCheckBox ID="chkCustomWorkTime" runat="server" Text="Custom Work Time" Checked="True" ClientInstanceName="chkCustomWorkTime"
					Wrap="False">
					<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
				</dx:ASPxCheckBox>
			</dx:PanelContent>
		</panelcollection>
	</dx:ASPxRoundPanel>
	<br />
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="Timeline"
		GroupType="Resource" ClientInstanceName="ASPxClientScheduler1" OnQueryWorkTime="ASPxScheduler1_QueryWorkTime" Start="2014/5/23"
		AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource">
		<ClientSideEvents AppointmentResizing="onAppointmentIntervalChanging" AppointmentDrag="onAppointmentIntervalChanging" />
		<Views>
			<DayView ResourcesPerPage="2">
				<DayViewStyles ScrollAreaHeight="600px" />
			</DayView>
			<WorkWeekView ResourcesPerPage="2">
				<WorkWeekViewStyles ScrollAreaHeight="600px" />
			</WorkWeekView>
			<WeekView Enabled="False" />
			<FullWeekView Enabled="false" />
			<MonthView ResourcesPerPage="2" Enabled="False">
				<MonthViewStyles>
					<DateCellBody Height="100px" />
				</MonthViewStyles>
			</MonthView>
			<TimelineView ResourcesPerPage="4" IntervalCount="19">
				<TimelineViewStyles>
					<TimelineCellBody Height="120px" />
				</TimelineViewStyles>
				<Scales>
					<dx:TimeScaleYear Enabled="False" />
					<dx:TimeScaleQuarter Enabled="False" />
					<dx:TimeScaleMonth Enabled="False" />
					<dx:TimeScaleWeek Visible="False" />
					<dx:TimeScaleDay />
					<dx:TimeScaleHour DisplayFormat="hh:mm"/>
					<dx:TimeScaleFixedInterval Enabled="False" />
				</Scales>
			</TimelineView>
		</Views>
		<Storage enablereminders="false">
			<Appointments AutoRetrieveId="true" />   
		</Storage>
	</dx:ASPxScheduler>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>