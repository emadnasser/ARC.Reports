<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Calendar.aspx.vb" Inherits="Calendar" EnableViewState="False" %>
<asp:Content ID="Content1" ContentPlaceHolderID="SideHolder" Runat="Server">
	<div class="DateNavigatorContainer">

		<dx:ASPxDateNavigator runat="server" ID="DateNavigator" MasterControlID="Scheduler" CssClass="DateNavigator">
			<Properties Rows="2" DayNameFormat="FirstLetter">
				<Style Border-BorderWidth="0">
				</Style>
			</Properties>
		</dx:ASPxDateNavigator>

	</div>
	<dx:ASPxNavBar runat="server" ID="ResourceNavBar" DataSourceID="ResourceNavBarDataSource" CssClass="CalendarResourceNavBar"
		EnableAnimation="True" Width="100%" AutoCollapse="true">
		<ItemTemplate>
			<dx:ASPxCheckBox runat="server" ID="CheckBox" Text='<%#Eval("Name")%>' Checked="<%#GetResourceCheckedState(Container)%>">
				<ClientSideEvents CheckedChanged="MailDemo.ClientResourceCheckBox_CheckedChanged" />
			</dx:ASPxCheckBox>
		</ItemTemplate>
		<GroupHeaderStyle>
			<BorderLeft BorderWidth="0" />
			<BorderRight BorderWidth="0" />
		</GroupHeaderStyle>
		<GroupContentStyle>
			<BorderLeft BorderWidth="0" />
			<BorderRight BorderWidth="0" />
			<BorderBottom BorderWidth="0" />
		</GroupContentStyle>
		<Paddings Padding="0" />
		<BorderLeft BorderWidth="0" />
		<BorderRight BorderWidth="0" />
		<BorderBottom BorderWidth="0" />
	</dx:ASPxNavBar>
	<asp:XmlDataSource ID="ResourceNavBarDataSource" runat="server" DataFile="~/App_Data/Resources.xml" 
		XPath="/Resources/*" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainHolder" Runat="Server">

	<dx:ASPxScheduler runat="server" ID="Scheduler" AppointmentDataSourceID="AppointmentDataSource" ResourceDataSourceID="ResourceDataSource" 
		ClientInstanceName="ClientScheduler" ActiveViewType="WorkWeek" Width="100%"
		OnFilterAppointment="Scheduler_FilterAppointment">
		<Views>
			<DayView>
				<DayViewStyles ScrollAreaHeight="600"></DayViewStyles>
			</DayView>
			<WorkWeekView>
				<WorkWeekViewStyles ScrollAreaHeight="600" />
			</WorkWeekView>
			<WeekView Enabled="False" />
			<MonthView CompressWeekend="False" />
			<TimelineView Enabled="False" />
		</Views>
		<Storage EnableReminders="False">
			<Appointments  AutoRetrieveId="true">
				<Mappings AppointmentId="ID" Type="Type" Start="StartDate" End="EndDate" AllDay="AllDay" 
					Subject="Subject" Location="Location" Description="Description" Status="Status" Label="Label"
					ResourceId="ResourceID" RecurrenceInfo="RecurrenceInfo" />
			</Appointments>
			<Resources>
				<Mappings ResourceId="ID" Caption="Name" />
			</Resources>
		</Storage>
		<OptionsBehavior RecurrentAppointmentEditAction="Ask" />
		<ClientSideEvents AppointmentDoubleClick="MailDemo.ClientScheduler_AppointmentDoubleClick" />
		<Border BorderWidth="0" />
	</dx:ASPxScheduler>
	<asp:ObjectDataSource runat="server" ID="AppointmentDataSource" 
		DataObjectTypeName="SchedulerAppointmentObject" TypeName="SchedulerData"
		SelectMethod="GetAppointments" InsertMethod="Insert" UpdateMethod="Update" DeleteMethod="Delete" />
	<asp:ObjectDataSource runat="server" ID="ResourceDataSource" 
		DataObjectTypeName="SchedulerResourceObject" TypeName="SchedulerData" 
		SelectMethod="GetResources" />
</asp:Content>