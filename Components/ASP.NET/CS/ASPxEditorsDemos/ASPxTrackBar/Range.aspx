<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Range.aspx.cs" Inherits="ASPxTrackBar_Range" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function updateTrackBarLabels() {
            updateTickTrackBarLabels(tickTrackBar); 
            updateItemTrackBarLabels(itemTrackBar);
        }
        function updateTickTrackBarLabels(trackBar) {
            tickStart.SetText("SelectionStart: " + trackBar.GetPositionStart());
            tickEnd.SetText("SelectionEnd: " + trackBar.GetPositionEnd());
        }
        
        function updateItemTrackBarLabels(trackBar) {
            itemStart.SetText("SelectionStart: " + trackBar.GetPositionStart());
            itemEnd.SetText("SelectionEnd: " + trackBar.GetPositionEnd());
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxGlobalEvents runat="server">
        <ClientSideEvents ControlsInitialized="updateTrackBarLabels" />
    </dx:ASPxGlobalEvents>
    
    <div style="width: 500px; margin: auto;">
        <table>
            <tr>
                <td>
                    <dx:ASPxTrackBar runat="server" ID="trackBar1" MinValue="0" MaxValue="50" Step="1" LargeTickInterval="10" SmallTickFrequency="5" Width="256"
                        AllowRangeSelection="true" PositionStart="10" PositionEnd="20" ScalePosition="LeftOrTop" ClientInstanceName="tickTrackBar">
                        <ClientSideEvents PositionChanged="updateTickTrackBarLabels" /> 
                    </dx:ASPxTrackBar>
                </td>
                <td style="padding-left: 40px; padding-top: 20px;">
                    <dx:ASPxLabel runat="server" ClientInstanceName="tickStart" ForeColor="Gray" /><br />
                    <dx:ASPxLabel runat="server" ClientInstanceName="tickEnd" ForeColor="Gray" />
                </td>
            </tr>
            <tr style="height: 80px">
                <td>
                    <dx:ASPxTrackBar runat="server" ID="trackBar2" AllowRangeSelection="true" PositionStart="0" PositionEnd="2" Width="256"
                        ScalePosition="LeftOrTop" ClientInstanceName="itemTrackBar" ValueToolTipPosition="RightOrBottom">
                        <Items>
                            <dx:TrackBarItem Text="Item1" Value="1" />
                            <dx:TrackBarItem Text="Item2" Value="2" />
                            <dx:TrackBarItem Text="Item3" Value="3" />
                            <dx:TrackBarItem Text="Item4" Value="4" />
                        </Items>
                        <ClientSideEvents ValueChanged="updateItemTrackBarLabels" /> 
                    </dx:ASPxTrackBar>
                </td>
                <td style="padding-left: 40px; padding-top: 20px;">
                    <dx:ASPxLabel runat="server" ClientInstanceName="itemStart" ForeColor="Gray" /><br />
                    <dx:ASPxLabel runat="server" ClientInstanceName="itemEnd" ForeColor="Gray" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
