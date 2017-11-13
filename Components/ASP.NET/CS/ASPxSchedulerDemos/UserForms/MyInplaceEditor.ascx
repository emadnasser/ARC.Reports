<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MyInplaceEditor.ascx.cs"  Inherits="Templates_MyInplaceEditor" %>
<table style="height: 100%; border-collapse: collapse" width="100%">
    <tr>
        <td>
            <div style="background: #73a2bb; color: white; font-weight: bold; padding: 3px; border-bottom: solid 1px #4986a2">
                <table style="width: 100%">
                    <tr>
                        <td>
                            <asp:Label ID="lbAptTime" runat="server" Text='<%#((AppointmentInplaceEditorTemplateContainer)Container).Appointment.Start.Date.ToShortDateString() + ", " + ((AppointmentInplaceEditorTemplateContainer)Container).Appointment.Start.ToShortTimeString() + " - " +  ((AppointmentInplaceEditorTemplateContainer)Container).Appointment.End.ToShortTimeString() %>'></asp:Label>
                        </td>
                        <td style="text-align: right">
                            <img onclick='<%#((AppointmentInplaceEditorTemplateContainer)Container).CancelScript %>'
                                src="../Content/Demo/Close.png" alt="Close" />
                        </td>
                    </tr>
                </table>
            </div>
            <table style="width: 100%">
                <tr>
                    <td style="padding: 8px;">
                        <b>Subject:</b>
                    </td>
                    <td style="width: 100%; padding: 8px;">
                        <asp:TextBox ID="txSubject" Text="<%#((AppointmentInplaceEditorTemplateContainer)Container).Appointment.Subject %>"
                            runat="server" Width="100%"></asp:TextBox>
                        <div style="font-size: 8pt; margin-top: 4px;">
                            for instance, Meeting with friends
                        </div>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td style="padding: 8px;">
            <table style="width: 100%">
                <tr>
                    <td>
                        <input type="button" value="Update" onclick='<%#((AppointmentInplaceEditorTemplateContainer)Container).SaveScript %>' />
                    </td>
                    <td style="text-align: right">
                        <span style="cursor: pointer; color: blue; text-decoration: underline;" onclick='<%#((AppointmentInplaceEditorTemplateContainer)Container).EditFormScript %>'>
                            More Information&hellip; </span>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
