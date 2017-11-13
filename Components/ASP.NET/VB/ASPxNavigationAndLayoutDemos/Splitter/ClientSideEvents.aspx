<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSideEvents.aspx.vb"
	Inherits="Splitter_ClientSideEvents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxSplitter ID="ASPxSplitter1" runat="server" Height="250px" Width="100%" ShowCollapseBackwardButton="True"
		ShowCollapseForwardButton="True" Orientation="Vertical" style="margin-bottom: 16px;">
		<Panes>
			<dx:SplitterPane Name="Pane 0">
				<ContentCollection>
					<dx:SplitterContentControl ID="SplitterContentControl1" runat="server">
						Pane 0
					</dx:SplitterContentControl>
				</ContentCollection>
			</dx:SplitterPane>
			<dx:SplitterPane Name="Pane 1">
				<Panes>
					<dx:SplitterPane Name="Pane 1-0">
						<ContentCollection>
							<dx:SplitterContentControl ID="SplitterContentControl2" runat="server">
								Pane 1-0
							</dx:SplitterContentControl>
						</ContentCollection>
					</dx:SplitterPane>
					<dx:SplitterPane Name="Pane 1-1">
						<ContentCollection>
							<dx:SplitterContentControl ID="SplitterContentControl3" runat="server">
								Pane 1-1
							</dx:SplitterContentControl>
						</ContentCollection>
					</dx:SplitterPane>
					<dx:SplitterPane Name="Pane 1-2">
						<ContentCollection>
							<dx:SplitterContentControl ID="SplitterContentControl4" runat="server">
								Pane 1-2
							</dx:SplitterContentControl>
						</ContentCollection>
					</dx:SplitterPane>
				</Panes>
			</dx:SplitterPane>
		</Panes>
		<ClientSideEvents Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init'); }" PaneResized="function(s, e) { DXEventMonitor.Trace(s, e, 'PaneResized'); }"
			PaneCollapsed="function(s, e) { DXEventMonitor.Trace(s, e, 'PaneCollapsed'); }"
			PaneCollapsing="function(s, e) { DXEventMonitor.Trace(s, e, 'PaneCollapsing'); }"
			PaneExpanded="function(s, e) { DXEventMonitor.Trace(s, e, 'PaneExpanded'); }"
			PaneExpanding="function(s, e) { DXEventMonitor.Trace(s, e, 'PaneExpanding'); }"
			PaneResizing="function(s, e) { DXEventMonitor.Trace(s, e, 'PaneResizing'); }" />
	</dx:ASPxSplitter>
	<dx:EventMonitor ID="EventMonitor" runat="server" EventNames="Init PaneResizing PaneResized PaneCollapsing PaneCollapsed PaneExpanding PaneExpanded" />
</asp:Content>