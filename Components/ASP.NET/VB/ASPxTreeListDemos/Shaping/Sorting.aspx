<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Sorting.aspx.vb"
	Inherits="Shaping_Sorting" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable OptionsBottomMargin">
		<tr>
			<td>
				<dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Sort by:" />
			</td>
			<td>
				<dx:ASPxButton ID="ASPxButton1" runat="server" Text="Department" AutoPostBack="False"
					UseSubmitBehavior="False" EnableClientSideAPI="True">
					<ClientSideEvents Click="function(s, e) { treeList.SortBy(&quot;DepartmentName&quot;); }" />
				</dx:ASPxButton>
			</td>
			<td>
				<dx:ASPxButton ID="ASPxButton2" runat="server" Text="Location" AutoPostBack="False"
					UseSubmitBehavior="False" EnableClientSideAPI="True">
					<ClientSideEvents Click="function(s, e) { treeList.SortBy(&quot;Location&quot;); }" />
				</dx:ASPxButton>
			</td>
			<td>
				<dx:ASPxButton ID="ASPxButton3" runat="server" Text="Budget" AutoPostBack="False"
					UseSubmitBehavior="False" EnableClientSideAPI="True">
					<ClientSideEvents Click="function(s, e) { treeList.SortBy(&quot;Budget&quot;); }" />
				</dx:ASPxButton>
			</td>
		</tr>
	</table>
	<dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False" ClientInstanceName="treeList"
		Width="100%" DataSourceID="DepartmentsDataSource" KeyFieldName="ID" ParentFieldName="ParentID">
		<Columns>
			<dx:TreeListDataColumn FieldName="DepartmentName" Caption="Department" VisibleIndex="0" />
			<dx:TreeListDataColumn FieldName="Location" SortIndex="0" SortOrder="Ascending" VisibleIndex="1" />
			<dx:TreeListDataColumn FieldName="Budget" SortIndex="1" SortOrder="Descending" VisibleIndex="2"
				DisplayFormat="{0:C}" />
		</Columns>
		<Settings GridLines="Vertical" SuppressOuterGridLines="true" />
		<SettingsBehavior AutoExpandAllNodes="True" ExpandCollapseAction="NodeDblClick" />
		<Border BorderStyle="Solid" />
	</dx:ASPxTreeList>
	<ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
</asp:Content>