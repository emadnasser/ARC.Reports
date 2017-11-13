<%@ Control Language="vb" AutoEventWireup="true" CodeFile="ReportsDataSource.ascx.vb"
	Inherits="ReportsDataSource" %>
<ef:EntityDataSource ID="efAppointmentDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="MedicalAppointments" 
	EnableInsert="true" EnableUpdate="true" EnableDelete="true" EnableFlattening="false" />
<ef:EntityDataSource ID="efResourceDataSource" runat="server" ContextTypeName="MedicsSchedulingDBContext" EntitySetName="Medics" EnableFlattening="false" />
<dx:ASPxScheduler ID="ASPxSchedulerControl" runat="server" Visible="false">
	<Storage EnableReminders="False"/>
	<OptionsBehavior ShowViewNavigator="False" ShowViewSelector="False" ShowViewVisibleInterval="False" />
	<Views>
		<DayView>
			<VisibleTime End="00:30:00" />
		</DayView>
	</Views>
</dx:ASPxScheduler>
<dx:ASPxSchedulerStoragePrintAdapter ID="ASPxStoragePrintAdapter" runat="server"
	SchedulerControlID="ASPxSchedulerControl" />