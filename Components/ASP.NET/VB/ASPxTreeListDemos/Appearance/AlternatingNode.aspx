<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AlternatingNode.aspx.vb"
	Inherits="Appearance_AlternatingNode" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False" DataSourceID="DepartmentsDataSource"
		Width="100%" KeyFieldName="ID" ParentFieldName="ParentID">
		<Columns>
			<dx:TreeListDataColumn FieldName="DepartmentName" Caption="Department" VisibleIndex="0" />
			<dx:TreeListDataColumn FieldName="Location" VisibleIndex="1" />
			<dx:TreeListDataColumn FieldName="Phone1" VisibleIndex="2" Caption="Phone" />
		</Columns>
		<Styles>
			<AlternatingNode Enabled="true" />
		</Styles>
		<Settings GridLines="Both" />
		<SettingsBehavior ExpandCollapseAction="NodeDblClick" />
	</dx:ASPxTreeList>
	<ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
</asp:Content>