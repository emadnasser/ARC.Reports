<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MonthView.aspx.vb"
	Inherits="ViewTypes_MonthView" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="2" Theme="Metropolis" Width="100%">
		<Items>
			<dx:LayoutGroup Caption="Month View Options" GroupBoxDecoration="HeadingLine" ColCount="2">
				<Items>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="chkShowWeekend" runat="server" Text="Show Weekend" Checked="True" Theme="Metropolis"
									Wrap="False">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="chkCompressWeekend" runat="server" Text="Compress Weekend" Checked="False" Theme="Metropolis"
									Wrap="False">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="chkShowMoreButtons" runat="server" Text="Show More Buttons" Theme="Metropolis"
									Checked="True" Wrap="False">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxComboBox ID="cbWeekCount" runat="server" Caption="Week Count" ValueType="System.Int32" SelectedIndex="2" Theme="Metropolis"
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
			<dx:LayoutGroup Caption="Common options" GroupBoxDecoration="HeadingLine" ColCount="2">
				<Items>
					<dx:LayoutItem ShowCaption="False">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxCheckBox ID="ShowViewNavigatorCheckBox" runat="server" Checked="true" Wrap="False" Text="Show View Navigator" Theme="Metropolis">
									<ClientSideEvents CheckedChanged="function(s, e) { ASPxClientScheduler1.Refresh(); }" />
								</dx:ASPxCheckBox>
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
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
	<dx:ASPxScheduler ID="ASPxScheduler1" ClientInstanceName="ASPxClientScheduler1" runat="server" GroupType="Resource" AppointmentDataSourceID="AppointmentDataSource" 
		ResourceDataSourceID="efResourceDataSource" Width="100%" ActiveViewType="Month" >
		<ResourceNavigator EnableIncreaseDecrease="false" />
		<Views>
			<DayView Enabled="false" />
			<WorkWeekView Enabled="false" />
			<WeekView Enabled="false" />
			<MonthView ResourcesPerPage="1">
				<AppointmentDisplayOptions StartTimeVisibility="Never" EndTimeVisibility="Never" StatusDisplayType="Bounds" ShowRecurrence="true"/>
				<CellAutoHeightOptions Mode="LimitHeight" MinHeight="200" />
			</MonthView>
			<TimelineView Enabled="false" />
		</Views>
		<OptionsBehavior ShowViewSelector="false" />
		<Storage EnableReminders="false" />
	</dx:ASPxScheduler>
	<demo:SchedulerDemoDataSource runat="server" ID="AppointmentDataSource" DataSourceID="efAppointmentDataSource" IsSiteMode="True"></demo:SchedulerDemoDataSource>
	<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
		EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
	<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
</asp:Content>