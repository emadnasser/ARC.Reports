<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Holidays.aspx.vb"
	Inherits="Miscellaneous_Holidays" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<script type="text/javascript">
		function OnLocationChanged(combo) {
			ASPxClientScheduler1.Refresh();
			clientBtnGenerate.SetEnabled(combo.GetSelectedIndex() > 0);
			clientBtnClear.SetEnabled(combo.GetSelectedIndex() > 0);
		}
	</script>
	<demo:DefaultObjectDataSource runat="server" ID="DataSource1" SessionName="Holidays" />
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Demo Options">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">
				<table class="OptionsTable" style="width: 100%">
					<tr>
						<td style="width: 100%">
							<dx:ASPxComboBox ID="cbLocation" runat="server" Width="250px" SelectedIndex="1" ValueType="System.Int32">
								<ClientSideEvents SelectedIndexChanged="function(s, e) { OnLocationChanged(s); }" />
								<Items>
									<dx:ListEditItem Text="Choose a location..." Value="0" />
									<dx:ListEditItem Text="United States" Value="1" />
									<dx:ListEditItem Text="United Kingdom" Value="2" />
									<dx:ListEditItem Text="United Arab Emirates" Value="3" />
									<dx:ListEditItem Text="Russia" Value="4" />
									<dx:ListEditItem Text="Japan" Value="5" />
									<dx:ListEditItem Text="India" Value="6" />
									<dx:ListEditItem Text="Brazil" Value="7" />
									<dx:ListEditItem Text="Australia" Value="8" />
								</Items>
							</dx:ASPxComboBox>
						</td>
						<td>
							<dx:ASPxButton ID="btnGenerate" runat="server" Text="Generate&nbsp;Appointments"
								ClientEnabled="false" ClientInstanceName="clientBtnGenerate" AutoPostBack="False"
								UseSubmitBehavior="False">
								<ClientSideEvents Click="function(s, e) { ASPxClientScheduler1.RaiseCallback(&quot;HOLGNR|&quot;); }" />
							</dx:ASPxButton>
						</td>
						<td>
							<dx:ASPxButton ID="btnClear" runat="server" Text="Clear&nbsp;Appointments" ClientEnabled="false"
								ClientInstanceName="clientBtnClear" AutoPostBack="False" UseSubmitBehavior="False">
								<ClientSideEvents Click="function(s, e) { ASPxClientScheduler1.RaiseCallback(&quot;HOLCLEAR|&quot;); }" />
							</dx:ASPxButton>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<br />
	<table style="width: 100%">
		<tr style="vertical-align: top;">
			<td style="width: 100%">
				<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" ActiveViewType="WorkWeek" ClientInstanceName="ASPxClientScheduler1"
					OnBeforeExecuteCallbackCommand="ASPxScheduler1_BeforeExecuteCallbackCommand">
					<Views>
						<DayView ShowWorkTimeOnly="True">
							<DayViewStyles ScrollAreaHeight="395px" />
						</DayView>
						<WorkWeekView ShowWorkTimeOnly="True" ShowFullWeek="True">
							<WorkWeekViewStyles ScrollAreaHeight="395px" />
						</WorkWeekView>
						<WeekView Enabled="false">
							<WeekViewStyles>
								<DateCellBody Height="100px" />
							</WeekViewStyles>
						</WeekView>
						<FullWeekView Enabled="true" ResourcesPerPage="2">
							<FullWeekViewStyles ScrollAreaHeight="395" />
						</FullWeekView>
						<MonthView>
							<MonthViewStyles>
								<DateCellBody Height="50px" />
							</MonthViewStyles>
						</MonthView>
						<TimelineView IntervalCount="4">
							<TimelineViewStyles>
								<TimelineCellBody Height="400px" />
							</TimelineViewStyles>
							<Scales>
								<dx:TimeScaleYear />
								<dx:TimeScaleQuarter Enabled="False" />
								<dx:TimeScaleMonth />
								<dx:TimeScaleWeek Enabled="False" />
								<dx:TimeScaleDay Enabled="False" />
								<dx:TimeScaleHour Enabled="False" />
								<dx:TimeScaleFixedInterval Enabled="False" />
							</Scales>
							<AppointmentDisplayOptions EndTimeVisibility="Never" StartTimeVisibility="Never" />
						</TimelineView>
					</Views>
					<OptionsBehavior ShowViewVisibleInterval="False" />
					<Storage EnableReminders="false">
					</Storage>
				</dx:ASPxScheduler>
			</td>
			<td>
				<dx:ASPxDateNavigator runat="server" ID="ASPxDateNavigator1" MasterControlID="ASPxScheduler1"
					Width="220px">
					<Properties Rows="2" DayNameFormat="FirstLetter" />
				</dx:ASPxDateNavigator>
			</td>
		</tr>
	</table>
</asp:Content>