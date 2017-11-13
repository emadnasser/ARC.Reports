<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CustomDragAppointmentToolTip.ascx.cs" Inherits="UserForms_CustomDragAppointmentToolTip" %>
<div style="white-space:nowrap;">
    <dx:ASPxLabel ID="lblInterval" runat="server" Text="CustomDragAppointmentTooltip" EnableClientSideAPI="true">
        </dx:ASPxLabel>
    <br />
    <dx:ASPxLabel ID="lblInfo" runat="server" Text="Press ESC to cancel operation" EnableClientSideAPI="true"></dx:ASPxLabel>
</div>
<script id="dxss_ASPxCustomClientAppointmentDragTooltip" type="text/javascript"><!--
    ASPxCustomClientAppointmentDragTooltip = ASPx.CreateClass(ASPxClientToolTipBase, {
        CalculatePosition: function(bounds) {
            return new ASPxClientPoint(bounds.GetLeft(), bounds.GetTop() - bounds.GetHeight());
        },
        Update: function (toolTipData) {
            var stringInterval = this.GetToolTipContent(toolTipData);
            var oldText = this.controls.lblInterval.GetText();
            if (oldText != stringInterval)
                this.controls.lblInterval.SetText(stringInterval);
        },
        GetToolTipContent: function(toolTipData) {	
	        var interval = toolTipData.GetInterval();
	        return this.ConvertIntervalToString(interval);
        }
    });
//--></script>
