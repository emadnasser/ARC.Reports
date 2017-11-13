<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TimelineView.aspx.vb"
	Inherits="ViewTypes_TimelineView" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="3" Theme="Metropolis" Width="100%">
		<items>
			<dx:LayoutGroup GroupBoxDecoration="None">
				<Paddings PaddingTop="0" PaddingRight="0" />
				<ParentContainerStyle Paddings-PaddingRight="0">
				</ParentContainerStyle>
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
												<dx:ListEditItem Text="CurrentDate" Value="3" />
											</Items>
										</dx:ASPxComboBox>
									</dx:LayoutItemNestedControlContainer>
								</LayoutItemNestedControlCollection>
							</dx:LayoutItem>
						</Items>
					</dx:LayoutGroup>
					<dx:LayoutGroup Caption="View Layout options"  GroupBoxDecoration="HeadingLine" ColCount="2">
						 <Items>
							 <dx:LayoutItem Caption="Interval Count">
								 <LayoutItemNestedControlCollection >
									<dx:LayoutItemNestedControlContainer>
										<dx:ASPxComboBox ID="cbIntervalCount" runat="server" ValueType="System.Int32" SelectedIndex="3" Theme="Metropolis"
											Width="50px">
											<ClientSideEvents SelectedIndexChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
											<Items>
												<dx:ListEditItem Text="1" Value="1" />
												<dx:ListEditItem Text="2" Value="2" />
												<dx:ListEditItem Text="3" Value="3" />
												<dx:ListEditItem Text="4" Value="4" />
												<dx:ListEditItem Text="5" Value="5" />
												<dx:ListEditItem Text="6" Value="6" />
												<dx:ListEditItem Text="7" Value="7" />
												<dx:ListEditItem Text="8" Value="8" />
												<dx:ListEditItem Text="9" Value="9" />
												<dx:ListEditItem Text="10" Value="10" />
											</Items>
										</dx:ASPxComboBox>
									</dx:LayoutItemNestedControlContainer>
								 </LayoutItemNestedControlCollection>
							</dx:LayoutItem>
						 </Items>
					</dx:LayoutGroup>
				</Items>
			</dx:LayoutGroup>
			<dx:LayoutGroup Caption="Appointment Layout"  GroupBoxDecoration="HeadingLine">
				<Items>
					<dx:LayoutItem Caption="Snap To Cells Mode">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="cbSnapToCellsMode" runat="server" Width="90px" SelectedIndex="0" Theme="Metropolis"
								ValueType="System.Int32">
									<ClientSideEvents SelectedIndexChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
									<Items>
										<dx:ListEditItem Text="Auto" Value="0" />
										<dx:ListEditItem Text="Always" Value="1" />
										<dx:ListEditItem Text="Never" Value="2" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>    
					</dx:LayoutItem>
					<dx:LayoutItem Caption="Appointment Height">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="cbAppointmentHeight" runat="server" ValueType="System.Int32" Theme="Metropolis"
								SelectedIndex="4" Width="50px">
									<ClientSideEvents SelectedIndexChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
									<Items>
										<dx:ListEditItem Text="20px" Value="20" />
										<dx:ListEditItem Text="25px" Value="25" />
										<dx:ListEditItem Text="30px" Value="30" />
										<dx:ListEditItem Text="35px" Value="35" />
										<dx:ListEditItem Text="40px" Value="40" />
									</Items>
								</dx:ASPxComboBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="chkAutoHeight" runat="server" Text="Auto Height" Checked="True" Theme="Metropolis"
									Wrap="False">                                
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>    
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
			 <dx:LayoutGroup Caption="Common options" GroupBoxDecoration="HeadingLine" >
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
				</Items>
			</dx:LayoutGroup>
		 </items>
	</dx:ASPxFormLayout>
	<br />
	<dx:ASPxScheduler ID="ASPxScheduler1" ClientInstanceName="ASPxClientScheduler1" runat="server" GroupType="Resource" AppointmentDataSourceID="AppointmentDataSource" 
		ResourceDataSourceID="efResourceDataSource" Width="100%" ActiveViewType="Timeline">
		<ResourceNavigator EnableIncreaseDecrease="false" />
		<Views>
			<DayView Enabled="false" />
			<WorkWeekView Enabled="false" />
			<WeekView Enabled="false" />
			<MonthView Enabled="false" />
			<TimelineView ResourcesPerPage="1">
				<Scales>
					<dx:TimeScaleMonth />
					<dx:TimeScaleDay />
				</Scales>
			</TimelineView>
		</Views>
		<OptionsBehavior ShowViewSelector="false" />
		<Storage EnableReminders="false">
		</Storage>
	</dx:ASPxScheduler>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>