<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Custom.aspx.vb"
	Inherits="Summary_Custom" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxTreeList ID="treeList" runat="server" Width="100%" AutoGenerateColumns="False"
		DataSourceID="DepartmentsDataSource" KeyFieldName="ID" ParentFieldName="ParentID"
		OnCustomSummaryCalculate="treeList_CustomSummaryCalculate">
		<Summary>
			<dx:TreeListSummaryItem DisplayFormat="{0:C}" FieldName="Budget" ShowInColumn="Budget"
				SummaryType="Custom" />
		</Summary>
		<Columns>
			<dx:TreeListDataColumn FieldName="DepartmentName" Caption="Department" VisibleIndex="0" />
			<dx:TreeListDataColumn FieldName="Location" VisibleIndex="1">
				<GroupFooterCellTemplate>
					Selected:</GroupFooterCellTemplate>
				<FooterCellTemplate>
					SELECTED:</FooterCellTemplate>
			</dx:TreeListDataColumn>
			<dx:TreeListDataColumn FieldName="Budget" VisibleIndex="2" DisplayFormat="{0:C}" />
		</Columns>
		<Settings ShowFooter="True" ShowGroupFooter="true" GridLines="Both" />
		<SettingsBehavior AutoExpandAllNodes="True" ProcessSelectionChangedOnServer="true"
			ExpandCollapseAction="NodeDblClick" />
		<SettingsSelection Enabled="True" Recursive="False" />
		<Styles>
			<AlternatingNode Enabled="True" />            
			<GroupFooterCell HorizontalAlign="Right" Font-Bold="true" />
			<FooterCell HorizontalAlign="Right" Font-Bold="true" />
		</Styles>
	</dx:ASPxTreeList>
	<ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
</asp:Content>