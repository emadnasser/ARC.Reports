<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="ServerSide.aspx.vb" Inherits="TreeView_ServerSide" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="height: 340px;">
		<div style="float: left; width: 45%; margin-right: 2%;">
			<dx:ASPxTreeView ID="treeView" runat="server" AllowSelectNode="true" AutoPostBack="true"
				AllowCheckNodes="true" OnExpandedChanged="treeView_ExpandedChanged" OnExpandedChanging="treeView_ExpandedChanging"
				OnNodeClick="treeView_NodeClick" OnCheckedChanged="treeView_CheckedChanged">
				<Nodes>
					<dx:TreeViewNode Text="Music" Name="musicFolder" Image-Url="Images/MediaContent/music.png"
						Image-UrlDisabled="Images/MediaContent/musicDisabled.png" AllowCheck="false"
						Expanded="true">
						<Nodes>
							<dx:TreeViewNode Text="Andy McKee - Rylynn" Name="music1">
							</dx:TreeViewNode>
							<dx:TreeViewNode Text="Andy McKee - Drifting" Name="music2">
							</dx:TreeViewNode>
							<dx:TreeViewNode Text="Antoine Dufour - Reality" Name="music3">
							</dx:TreeViewNode>
						</Nodes>
					</dx:TreeViewNode>
					<dx:TreeViewNode Text="Video" Name="videoFolder" Image-Url="Images/MediaContent/video.png"
						Image-UrlDisabled="Images/MediaContent/videoDisabled.png" AllowCheck="false"
						Expanded="true">
						<Nodes>
							<dx:TreeViewNode Text="Inception - Official trailer" Name="video1">
							</dx:TreeViewNode>
							<dx:TreeViewNode Text="MythBusters Top 25 Moments" Name="video2">
							</dx:TreeViewNode>
							<dx:TreeViewNode Text="Richard Feynman - Ode on a Flower" Name="video3">
							</dx:TreeViewNode>
						</Nodes>
					</dx:TreeViewNode>
					<dx:TreeViewNode Text="Pictures" Name="picturesFolder" Image-Url="Images/MediaContent/pictures.png"
						Image-UrlDisabled="Images/MediaContent/picturesDisabled.png" AllowCheck="false"
						Expanded="true">
						<Nodes>
							<dx:TreeViewNode Text="Desert" Name="picture1">
							</dx:TreeViewNode>
							<dx:TreeViewNode Text="Me & Kate" Name="picture2">
							</dx:TreeViewNode>
							<dx:TreeViewNode Text="Party 03.08" Name="picture3">
							</dx:TreeViewNode>
						</Nodes>
					</dx:TreeViewNode>
				</Nodes>
				<Images NodeImage-Width="16px">
				</Images>
				<Styles NodeImage-Paddings-PaddingLeft="4px" NodeImage-Paddings-PaddingTop="3px">
				</Styles>
			</dx:ASPxTreeView>
		</div>
		<div style="float: left;">
			<table class="OptionsTable">
				<tr>
					<td>
						<dx:ASPxLabel runat="server" Text="Choose node:" EnableViewState="False" ID="lblNodes"
							AssociatedControlID="cbNodes" />
					</td>
					<td >
						<dx:ASPxComboBox AutoPostBack="True" Width="150px" ID="cbNodes" runat="server" 
							OnSelectedIndexChanged="cbNodes_SelectedIndexChanged">
						</dx:ASPxComboBox>
					</td>
				</tr>
				<tr>
					<td></td>
					<td>
						<dx:ASPxCheckBox AutoPostBack="true" ID="chbEnabled" Text="Enabled" Checked="true"
							runat="server" OnCheckedChanged="chbEnabled_CheckedChanged" />
					</td>
				</tr>
				<tr>
					<td></td>
					<td>
						<dx:ASPxCheckBox AutoPostBack="true" ID="chbVisible" Text="Visible" Checked="true"
							runat="server" OnCheckedChanged="chbVisible_CheckedChanged" />
					</td>
				</tr>
				<tr>
					<td></td>
					<td>
						<dx:ASPxCheckBox AutoPostBack="true" ID="chbSelected" Text="Selected" Checked="true"
							runat="server" OnCheckedChanged="chbSelected_CheckedChanged" />
					</td>
				</tr>
				<tr>
					<td></td>
					<td>
						<dx:ASPxCheckBox AutoPostBack="true" ID="chbChecked" Text="Checked" Checked="true"
							runat="server" OnCheckedChanged="chbChecked_CheckedChanged" />
					</td>
				</tr>
				<tr>
					<td></td>
					<td>
						<dx:ASPxCheckBox AutoPostBack="true" ID="chbExpanded" Text="Expanded" Checked="true"
							runat="server" OnCheckedChanged="chbExpanded_CheckedChanged" />
					</td>
				</tr>
			</table>
		</div>
	</div>
	<dx:ServerEventMonitor ID="EventMonitor" runat="server" EventNames="NodeClick ExpandedChanging ExpandedChanged CheckedChanged" EventLogWidth="540" />
</asp:Content>