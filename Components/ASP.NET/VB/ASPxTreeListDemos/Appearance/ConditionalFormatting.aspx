<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConditionalFormatting.aspx.vb"
	Inherits="Appearance_ConditionalFormatting" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False" DataSourceID="DepartmentsDataSource"
		Width="100%" KeyFieldName="ID" ParentFieldName="ParentID" OnHtmlRowPrepared="treeList_HtmlRowPrepared"
		OnHtmlDataCellPrepared="treeList_HtmlDataCellPrepared">
		<Columns>
			<dx:TreeListDataColumn FieldName="DepartmentName" Caption="Department" VisibleIndex="0" />
			<dx:TreeListDataColumn FieldName="Location" VisibleIndex="1" />
			<dx:TreeListDataColumn FieldName="Budget" VisibleIndex="2" DisplayFormat="{0:C}" Name="budget" />
			<dx:TreeListDataColumn FieldName="Phone1" VisibleIndex="3" Caption="Phone" />
		</Columns>
		<Settings GridLines="Both" />
		<SettingsBehavior AutoExpandAllNodes="True" ExpandCollapseAction="NodeDblClick" />
		<Styles>
			<Cell>
				<Border BorderColor="White" />
			</Cell>
		</Styles>
	</dx:ASPxTreeList>
	<ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
</asp:Content>