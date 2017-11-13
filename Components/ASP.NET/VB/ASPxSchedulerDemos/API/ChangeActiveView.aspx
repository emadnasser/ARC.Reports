<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ChangeActiveView.aspx.vb"
	Inherits="ClientSide_ChangeActiveView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<script type="text/javascript">
	// <![CDATA[
		function OnActiveViewChanging(args) {
			var answer = confirm('Do you want to switch the current view from ' + args.oldView + ' to ' + args.newView + '?');
			if(!answer) {
				args.cancel = true;
				clientViewsCombo.SetValue(args.oldView);
			}
		}
		function OnActiveViewChanged() {
			var currType = ASPxClientScheduler1.GetActiveViewType();
			clientViewsCombo.SetValue(currType);
		}
		function OnSelectViewType(viewType) {
			var newType = clientViewsCombo.GetSelectedItem().value;
			ASPxClientScheduler1.SetActiveViewType(newType);
		}
	// ]]> 
	</script>
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Scheduler Active View">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">
				<dx:ASPxComboBox ID="cbActiveView" ClientInstanceName="clientViewsCombo" runat="server"
					Width="250px" SelectedIndex="0" ValueType="System.String">
					<ClientSideEvents SelectedIndexChanged="function(s, e) { OnSelectViewType(s); }" />
					<Items>
						<dx:ListEditItem Text="Day View" Value="Day" />
						<dx:ListEditItem Text="Week View" Value="Week" />
						<dx:ListEditItem Text="Work Week View" Value="WorkWeek" />
						<dx:ListEditItem Text="Month View" Value="Month" />
						<dx:ListEditItem Text="Timeline View" Value="Timeline" />
					</Items>
				</dx:ASPxComboBox>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<br />
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" GroupType="Resource"
		AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="efResourceDataSource" ClientInstanceName="ASPxClientScheduler1">
		<ResourceNavigator EnableIncreaseDecrease="false" />
		<Views>
			<DayView ResourcesPerPage="1" />
			<WorkWeekView ResourcesPerPage="1" />
			<WeekView Enabled="false">
				<WeekViewStyles>
					<DateCellBody Height="200px" />
				</WeekViewStyles>
			</WeekView>
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
		<ClientSideEvents ActiveViewChanged="function(s, e) { OnActiveViewChanged(); }" ActiveViewChanging="function(s, e) { OnActiveViewChanging(e); }" />
		<Storage EnableReminders="False" />
	</dx:ASPxScheduler>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>