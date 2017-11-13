<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"%>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
	   .exampleContent
	   {
			font-size: 20px;
			text-align: center;
	   }
	</style>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<dx:ASPxSplitter ID="ASPxSplitter1" runat="server" Height="100px">
		<Panes>
			<dx:SplitterPane>
				<ContentCollection>
					<dx:SplitterContentControl runat="server">
						<div class="exampleContent">Left container</div>
					</dx:SplitterContentControl>
				</ContentCollection>
			</dx:SplitterPane>
			<dx:SplitterPane>
				<ContentCollection>
					<dx:SplitterContentControl runat="server">
						<div class="exampleContent">Right container</div>
					</dx:SplitterContentControl>
				</ContentCollection>
			</dx:SplitterPane>
		</Panes>
	</dx:ASPxSplitter>
</asp:Content>