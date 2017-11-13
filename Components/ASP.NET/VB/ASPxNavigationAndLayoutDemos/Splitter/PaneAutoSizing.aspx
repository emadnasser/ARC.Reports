<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PaneAutoSizing.aspx.vb"
	Inherits="Splitter_PaneAutoSizing" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<script type="text/javascript">
		function OnNodeClick(s, e) {
			callbackPanel.PerformCallback(e.node.GetText());
		}
	</script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<p>To see the feature in action, change the size of pane content by selecting different nodes or moving the splitter separator.</p>
	<dx:ASPxSplitter runat="server" id="ASPxSplitter1" ResizingMode="Live" >
		<Panes>
			<dx:SplitterPane AutoHeight="True" Size="20%" MinSize="110px" >
				<ContentCollection>
					<dx:SplitterContentControl ID="SplitterContentControl1" runat="server" 
						SupportsDisabledAttribute="True">
						<dx:ASPxTreeView ID="ASPxTreeView1" runat="server" AllowSelectNode="true" 
							AutoPostBack="false">
							<ClientSideEvents NodeClick="OnNodeClick" />
							<Nodes>
								<dx:TreeViewNode Text="Articles" Expanded="true">
									<Nodes>
										<dx:TreeViewNode Text="Blueberry" Name="Blueberry">
										</dx:TreeViewNode>
										<dx:TreeViewNode Text="Mushroom" Name="Mushroom">
										</dx:TreeViewNode>
										<dx:TreeViewNode Text="Fragaria" Name="Fragaria">
										</dx:TreeViewNode>
									</Nodes>
								</dx:TreeViewNode>
							</Nodes>
						</dx:ASPxTreeView>
					</dx:SplitterContentControl>
				</ContentCollection>
			</dx:SplitterPane>
			<dx:SplitterPane AutoHeight="True" Size="80%" MinSize="280px" >
				<ContentCollection>
					<dx:SplitterContentControl ID="SplitterContentControl2" runat="server" 
						SupportsDisabledAttribute="True">
						<dx:ASPxCallbackPanel runat="server" ID="ASPxCallbackPanel1" 
							ClientInstanceName="callbackPanel"
							Height="100%" Width="100%">
							<PanelCollection>
								<dx:PanelContent ID="PanelContent1">
									<%=GetHtml()%>
								</dx:PanelContent>
							</PanelCollection>
						</dx:ASPxCallbackPanel>
					</dx:SplitterContentControl>
				</ContentCollection>
			</dx:SplitterPane>
		</Panes>
	</dx:ASPxSplitter>
	<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/DataViewDiscs.xml">
	</asp:XmlDataSource>
</asp:Content>