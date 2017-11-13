<%@ Control Language="C#" AutoEventWireup="true" CodeFile="VerticalAppointment.ascx.cs"
    Inherits="UserControls_VerticalAppointment" %>
<div id="AppointmentDiv" runat="server" class="apt">
    <div runat="server" id="StatusContainer" class="status">
    </div>
    <div class="session">
        <dx:ASPxHyperLink ID="hlTitle" runat="server" CssClass="title" Text="<%# ((VerticalAppointmentTemplateContainer)Container).AppointmentViewInfo.Appointment.Subject%>">
            <ClientSideEvents Click="ShowSelectedAppointmentDetails" />
        </dx:ASPxHyperLink>
        <dx:ASPxLabel ID="lblSpeaker" runat="server" CssClass="speaker">
        </dx:ASPxLabel>
    </div>
    <div class="attending">
        <dx:ASPxComboBox ID="cmbAttendingSwitch" runat="server" SkinID="Attend" EnableClientSideAPI="True"
            ValueType="System.Int32" ShowImageInEditBox="True" SelectedIndex="0">
            <ClientSideEvents Init="ResizeSwitcher" />
            <Items>
                <dx:ListEditItem Text="Will not attend" Value="0" Selected="true" ImageUrl="~/Images/attendNot.png" />
                <dx:ListEditItem Text="Will probably attend" Value="1" ImageUrl="~/Images/attendProbably.png" />
                <dx:ListEditItem Text="Will attend" Value="2" ImageUrl="~/Images/attend.png" />
            </Items>
        </dx:ASPxComboBox>
    </div>
</div>
