<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Schedule.aspx.vb"
	Theme="DXConnect" Inherits="Schedule" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
	<div class="mainContent schedulerTab">
		<div class="contentHeader">
			<div class="content">
				<img id="scheduleTitle" src="Images/title_schedule.png" alt="Schedule" />
			</div>
		</div>
		<div class="content">
			<dx:ASPxTabControl ID="ASPxTabControl1" runat="server" CssClass="tabControl" ActiveTabIndex="0">
				<ClientSideEvents ActiveTabChanging="ChangeSheduleDay" TabClick="SheduleDayTabClick" />
				<TabTemplate>
					<site:UnselectedTab runat="server" />
				</TabTemplate>
				<ActiveTabTemplate>
					<site:SelectedTab runat="server" />
				</ActiveTabTemplate>
				<TabStyle>
					<Paddings Padding="0px" />
					<BorderBottom BorderStyle="None" BorderWidth="0px" />
				</TabStyle>
				<Paddings Padding="0px" />
			</dx:ASPxTabControl>
			<dx:ASPxHyperLink runat="server" Cursor="pointer" NavigateUrl="~/PrintSchedule.aspx"
				CssClass="printButton" ImageUrl="~/Images/printSchedule.png" Target="_blank" />
			<asp:Repeater ID="rpCategories" runat="server">
				<HeaderTemplate>
					<table class="categories">
						<tr>
				</HeaderTemplate>
				<ItemTemplate>
					<td class="cell">
						<table>
							<tr>
								<td>
									<div class="color" style='<%#String.Format("background-color: {0}", ColorTranslator.ToHtml(CType(Eval("Color"), Color)))%>'></div>
								</td>
								<td>
									<dx:ASPxLabel ID="ASPxLabel1" runat="server" Text='<%#Eval("Name")%>' />
								</td>
							</tr>
						</table>
					</td>
				</ItemTemplate>
				<FooterTemplate>
					</tr></table>
				</FooterTemplate>
			</asp:Repeater>
			<div class="dxConnectScheduler">
				<dx:ASPxScheduler ID="ASPxScheduler1" runat="server" ClientInstanceName="ASPxScheduler1"
					Width="1000px" EnableCallBacks="true" GroupType="Date" ActiveViewType="Day" AppointmentDataSourceID="AppointmentDataSource"
					OnAppointmentsInserted="ASPxScheduler1_AppointmentInserted" OnPopupMenuShowing="ASPxScheduler1_PopupMenuShowing"
					OnHtmlTimeCellPrepared="ASPxScheduler1_HtmlTimeCellPrepared" OnVisibleIntervalChanged="ASPxScheduler1_VisibleIntervalChanged"
					OnPrepareAppointmentFormPopupContainer="ASPxScheduler1_PrepareAppointmentFormPopupContainer">
					<OptionsLoadingPanel Text="" />
					<OptionsCustomization AllowAppointmentCreate="None" AllowAppointmentDelete="None"
						AllowAppointmentDrag="None" AllowAppointmentResize="None" AllowInplaceEditor="None"
						AllowAppointmentEdit="All" AllowAppointmentMultiSelect="false" AllowDisplayAppointmentForm="Always"/>
					<OptionsBehavior ShowViewNavigator="false" ShowViewSelector="false"
						ShowViewVisibleInterval="false" />
					<ResourceNavigator Visibility="Never" />
					<OptionsToolTips ShowAppointmentToolTip="false" ShowSelectionToolTip="false" />
					<Views>
						<DayView NavigationButtonVisibility="Never" TimeScale="00:15:00" ShowWorkTimeOnly="true"
							ShowDayHeaders="true">
							<Templates>
								<VerticalAppointmentTemplate>
									<site:VerticalAppointment runat="server" />
								</VerticalAppointmentTemplate>
							</Templates>
							<AppointmentDisplayOptions ColumnPadding-Left="0" ColumnPadding-Right="0" SnapToCellsMode="Never" />
						</DayView>
					</Views>
					<OptionsForms AppointmentFormTemplateUrl="UserControls/Scheduler/AppointmentForm.ascx" />
				</dx:ASPxScheduler>
			</div>
		</div>
	</div>
	<asp:ObjectDataSource ID="AppointmentDataSource" runat="server" DataObjectTypeName="Session"
		TypeName="SessionDataSource" SelectMethod="SelectMethodHandler" InsertMethod="InsertMethodHandler"
		UpdateMethod="UpdateMethodHandler" OnObjectCreated="appointmentsDataSource_ObjectCreated"
		OnInserted="appointmentsDataSource_Inserted" />
</asp:Content>