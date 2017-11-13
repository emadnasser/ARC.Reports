<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="NodeLinkMode.aspx.vb" Inherits="TreeView_NodeLinkMode" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="float: left; width: 50%">
		<dx:ASPxTreeView ID="treeView1" runat="server" AllowSelectNode="true">
			<Nodes>
				<dx:TreeViewNode Text="Linkin Park">
					<Nodes>
						<dx:TreeViewNode Text="Hybrid Theory (2000)" NavigateUrl="javascript:void(0);">
						</dx:TreeViewNode>
						<dx:TreeViewNode Text="Meteora (2003)" NavigateUrl="javascript:void(1);">
						</dx:TreeViewNode>
						<dx:TreeViewNode Text="Minutes to Midnight (2007)" NavigateUrl="javascript:void(2);">
						</dx:TreeViewNode>
						<dx:TreeViewNode Text="A Thousand Suns (2010)" NavigateUrl="javascript:void(3);">
						</dx:TreeViewNode>
					</Nodes>
				</dx:TreeViewNode>
				<dx:TreeViewNode Text="Coldplay">
					<Nodes>
						<dx:TreeViewNode Text="Parachutes (2000)" NavigateUrl="javascript:void(4);">
						</dx:TreeViewNode>
						<dx:TreeViewNode Text="A Rush of Blood to the Head (2002)" NavigateUrl="javascript:void(5);">
						</dx:TreeViewNode>
						<dx:TreeViewNode Text="X&Y (2005)" NavigateUrl="javascript:void(6);">
						</dx:TreeViewNode>
						<dx:TreeViewNode Text="Viva la Vida or Death and All His Friends (2008)" NavigateUrl="javascript:void(7);">
						</dx:TreeViewNode>
					</Nodes>
				</dx:TreeViewNode>
			</Nodes>
		</dx:ASPxTreeView>
		<div style="margin: 32px 0 0 16px;">
			<b>NodeLinkMode</b>="<b>ContentBounds</b>"<br />
			<br />
			<p>
				Specific service scripts are used to apply the hovered and selected styles to TreeView
				items and generate the <b>NodeClick</b> events.
			</p>
		</div>
	</div>
	<div style="float: right; width: 48%">
		<dx:ASPxTreeView ID="treeView2" runat="server" AllowSelectNode="true" NodeLinkMode="TextOnly">
			<Nodes>
				<dx:TreeViewNode Text="Linkin Park">
					<Nodes>
						<dx:TreeViewNode Text="Hybrid Theory (2000)" NavigateUrl="javascript:void(0);">
						</dx:TreeViewNode>
						<dx:TreeViewNode Text="Meteora (2003)" NavigateUrl="javascript:void(1);">
						</dx:TreeViewNode>
						<dx:TreeViewNode Text="Minutes to Midnight (2007)" NavigateUrl="javascript:void(2);">
						</dx:TreeViewNode>
						<dx:TreeViewNode Text="A Thousand Suns (2010)" NavigateUrl="javascript:void(3);">
						</dx:TreeViewNode>
					</Nodes>
				</dx:TreeViewNode>
				<dx:TreeViewNode Text="Coldplay">
					<Nodes>
						<dx:TreeViewNode Text="Parachutes (2000)" NavigateUrl="javascript:void(4);">
						</dx:TreeViewNode>
						<dx:TreeViewNode Text="A Rush of Blood to the Head (2002)" NavigateUrl="javascript:void(5);">
						</dx:TreeViewNode>
						<dx:TreeViewNode Text="X&Y (2005)" NavigateUrl="javascript:void(6);">
						</dx:TreeViewNode>
						<dx:TreeViewNode Text="Viva la Vida or Death and All His Friends (2008)" NavigateUrl="javascript:void(7);">
						</dx:TreeViewNode>
					</Nodes>
				</dx:TreeViewNode>
			</Nodes>
			<Styles>
				<Link>
					<HoverFont Underline="true" />
				</Link>
			</Styles>
		</dx:ASPxTreeView>
		<div style="margin: 32px 0 0 16px;">
			<b>NodeLinkMode</b>="<b>TextOnly</b>"<br />
			<br />
			<p>
				The hovered and selected styles are applied without using scripts. The style settings
				available via the <b>Styles.Link</b> property are used to define the appearance
				of links.
			</p>
		</div>
	</div>
</asp:Content>