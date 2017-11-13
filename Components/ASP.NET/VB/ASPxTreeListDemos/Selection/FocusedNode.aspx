<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FocusedNode.aspx.vb"
	Inherits="Presentation_FocusedNode" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False" DataSourceID="NewsGroupsDataSource"
		KeyFieldName="ID" ParentFieldName="ParentID" ClientInstanceName="treeList" Width="100%"
		OnCustomDataCallback="treeList_CustomDataCallback" OnHtmlDataCellPrepared="treeList_HtmlDataCellPrepared">
		<Columns>
			<dx:TreeListDataColumn FieldName="Subject" VisibleIndex="0" />
			<dx:TreeListDataColumn FieldName="From" VisibleIndex="1" />
			<dx:TreeListDataColumn FieldName="DateCreated" VisibleIndex="2" />
		</Columns>
		<Settings ShowTreeLines="False" SuppressOuterGridLines="true" />
		<SettingsBehavior AllowFocusedNode="True" ExpandCollapseAction="NodeDblClick" />
		<ClientSideEvents CustomDataCallback="function(s, e) { document.getElementById('messageText').innerHTML = e.result; }"
			FocusedNodeChanged="function(s, e) { 
			var key = treeList.GetFocusedNodeKey();
			treeList.PerformCustomDataCallback(key); 
		}" />
		<Border BorderStyle="Solid" />
	</dx:ASPxTreeList>
	<br />
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" HeaderText="Message Text"
		Width="100%">
		<PanelCollection>
			<dx:PanelContent runat="server">
				<span id="messageText">
					<asp:Literal ID="messageLiteral" runat="server"></asp:Literal></span>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<ef:EntityDataSource ID="NewsGroupsDataSource" runat="server" ContextTypeName="NewsGroupsContext" EntitySetName="Threads" />
</asp:Content>