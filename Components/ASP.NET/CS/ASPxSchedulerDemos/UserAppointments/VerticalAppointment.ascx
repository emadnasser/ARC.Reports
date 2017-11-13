<%@ Control Language="C#" AutoEventWireup="true" CodeFile="VerticalAppointment.ascx.cs"
    Inherits="VerticalAppointment" %>
<table style="height: 100%; width: 100%; filter: alpha(opacity=80); opacity: 0.80;">
    <tr>
        <td style="background: url(../Content/AppointmentTemplates/vTopLeftCorner.gif) no-repeat;
            font-size: 0">
            <div style="width: 9px;">
            </div>
        </td>
        <td style="width: 100%; background: url(../Content/AppointmentTemplates/vTopEdge.gif) repeat-x #f3fef7;">
            <div style="height: 9px;">
            </div>
        </td>
        <td style="background: url(../Content/AppointmentTemplates/vTopRightCorner.gif) no-repeat right top;
            font-size: 0">
            <div style="width: 9px;">
            </div>
        </td>
    </tr>
    <tr>
        <td style="background: url(../Content/AppointmentTemplates/vBottomLeftCorner.gif) no-repeat left bottom;
            font-size: 0">
            <div style="width: 9px;">
            </div>
        </td>
        <td style="border-bottom: solid 1px #7eacb1; background: #f3fef7">
            <div style="height: 1px;">
            </div>
        </td>
        <td style="background: url(../Content/AppointmentTemplates/vBottomRightCorner.gif) no-repeat right bottom;
            font-size: 0">
            <div style="width: 9px;">
            </div>
        </td>
    </tr>
</table>
<div style="position: absolute; top: 3px; left: 3px; height: 90%; width: 90%; overflow: hidden;
    cursor: default;">
    <div style="white-space: nowrap; overflow: hidden; text-align: center; font: 8pt Tahoma;
        color: #37414D">
        <asp:Label ID="lblHeader" runat="server"></asp:Label>
    </div>
    <table style="width: 100%">
        <tr>
            <td>
                <table id="imageContainer" runat="server" style="text-align: center">
                    <tr>
                        <td>
                        </td>
                    </tr>
                </table>
            </td>
            <td style="width: 100%">
                <div style="margin-top: 5px; text-align: center; font: 8pt Tahoma; color: #37414D;">
                    Subject:</div>
                <div style="text-align: center; font: bold 9pt Tahoma; color: Black">
                    <asp:Label ID="lblSubject" runat="server"></asp:Label></div>
                <div style="margin-top: 5px; text-align: center; font: 8pt Tahoma; color: #37414D;">
                    Location:</div>
                <div style="text-align: center; font: bold 9pt Tahoma; color: Black">
                    <asp:Label ID="lblLocation" runat="server"></asp:Label>
                </div>
                <div style="margin-top: 10px; text-align: center; font: 9pt Tahoma; color: Black">
                    <asp:Label ID="lblDescription" runat="server"></asp:Label>
                </div>
            </td>
        </tr>
    </table>
</div>
