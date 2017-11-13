<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="WorkWeekView.aspx.vb"
	Inherits="ViewTypes_WorkWeekView" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="3" Theme="Metropolis" Width="100%">
		<Items>
			<dx:LayoutGroup Caption="Current Time Visualization"  GroupBoxDecoration="HeadingLine">
				<Items>
					<dx:LayoutItem Caption="TimeIndicator&nbsp;Visibility">
						<LayoutItemNestedControlCollection >
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="cbTimeIndicatorVisibility" runat="server" Width="90px" SelectedIndex="1" Theme="Metropolis"
									ValueType="System.Int32" >
									<ClientSideEvents SelectedIndexChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
									<Items>
										<dx:ListEditItem Text="Never" Value="0" />
										<dx:ListEditItem Text="Always" Value="1" />
										<dx:ListEditItem Text="TodayView" Value="2" />
										<dx:ListEditItem Text="CurrentDate" Value="3" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem Caption="TimeMarker&nbsp;Visibility">
						<LayoutItemNestedControlCollection >
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="cbTimeMarkerVisibility" runat="server" Width="90px" SelectedIndex="1" Theme="Metropolis"
									ValueType="System.Int32">
									<ClientSideEvents SelectedIndexChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
									<Items>
										<dx:ListEditItem Text="Never" Value="0" />
										<dx:ListEditItem Text="Always" Value="1" />
										<dx:ListEditItem Text="TodayView" Value="2" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
			<dx:LayoutGroup Caption="View Layout Options" GroupBoxDecoration="HeadingLine" ColCount="2">
				<Items>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								 <dx:ASPxCheckBox ID="chkMonday" runat="server" Text="Monday" Checked="True" Wrap="False" Theme="Metropolis">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								 <dx:ASPxCheckBox ID="chkFriday" runat="server" Text="Friday" Checked="True" Wrap="False" Theme="Metropolis">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								 <dx:ASPxCheckBox ID="chkTuesday" runat="server" Text="Tuesday" Checked="True" Wrap="False" Theme="Metropolis">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								  <dx:ASPxCheckBox ID="chkSaturday" runat="server" Text="Saturday" Checked="False" Theme="Metropolis"
									Wrap="False">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								 <dx:ASPxCheckBox ID="chkWednesday" runat="server" Text="Wednesday" Checked="True" Theme="Metropolis"
									Wrap="False">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								 <dx:ASPxCheckBox ID="chkSunday" runat="server" Text="Sunday" Checked="False" Wrap="False" Theme="Metropolis">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								 <dx:ASPxCheckBox ID="chkThursday" runat="server" Text="Thursday" Checked="True" Wrap="False" Theme="Metropolis">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
			<dx:LayoutGroup Caption="Common options" GroupBoxDecoration="HeadingLine">
				<Items>
					<dx:LayoutItem Caption="AppointmentSelection Appearance Mode">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="SelectionAppearanceModeComboBox" runat="server" Width="90px" SelectedIndex="0" Theme="Metropolis"
									ValueType="System.Int32">
									<ClientSideEvents SelectedIndexChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
									<Items>
										<dx:ListEditItem Text="Auto" Value="0" />
										<dx:ListEditItem Text="BackgroundOpacity" Value="1" />
										<dx:ListEditItem Text="BoundaryFrame" Value="2" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="ShowViewNavigatorCheckBox" runat="server" Checked="true" Wrap="False" Text="Show View Navigator" Theme="Metropolis">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="ShowViewVisibleIntervalCheckBox" runat="server" Checked="true" Wrap="False" Text="Show View Visible Interval" Theme="Metropolis">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="HighlightSelectionCheckBox" runat="server" Checked="true" Wrap="False" Text="Highlight Selection Headers" Theme="Metropolis">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
		</Items>
	</dx:ASPxFormLayout>
	<br />
	<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="WorkWeek" AppointmentDataSourceID="AppointmentDataSource" 
		ResourceDataSourceID="efResourceDataSource" ClientInstanceName="ASPxClientScheduler1" GroupType="Resource">
		<ResourceNavigator EnableIncreaseDecrease="false" />
		<Views>
			<DayView Enabled="False"/>
			<WorkWeekView ResourcesPerPage="1" ShowWorkTimeOnly="true">
				<WorkTime Start="07:00:00" End="20:00:00" />
			</WorkWeekView>
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