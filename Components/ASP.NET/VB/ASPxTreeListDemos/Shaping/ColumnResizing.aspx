<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ColumnResizing.aspx.vb" Inherits="Shaping_ColumnResizing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable BottomMargin">
		<tr>
			<td>Column resizing mode: </td>
			<td>
				<dx:ASPxComboBox runat="server" ID="ddlResizingMode" AutoPostBack="true" SelectedIndex="1">
					<Items>
						<dx:ListEditItem Value="Disabled" />
						<dx:ListEditItem Value="NextColumn" />
						<dx:ListEditItem Value="Control" />
					</Items>
				</dx:ASPxComboBox>
			</td>
		</tr>
		<tr>
			<td>Resizing visualization: </td>
			<td>
				<dx:ASPxComboBox runat="server" ID="ddlResizingVisualization" AutoPostBack="true" SelectedIndex="0">
					<Items>
						<dx:ListEditItem Value="Live" />
						<dx:ListEditItem Value="Postponed" />
					</Items>
				</dx:ASPxComboBox>
			</td>
		</tr>
	</table>
	<dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="false" DataSourceID="DepartmentsDataSource" 
		KeyFieldName="ID" ParentFieldName="ParentID" Width="700">
		<Columns>
			<dx:TreeListDataColumn FieldName="DepartmentName" Caption="Departments" />            
			<dx:TreeListDataColumn FieldName="Budget" DisplayFormat="{0:C}" />
			<dx:TreeListDataColumn FieldName="Location" />
			<dx:TreeListDataColumn FieldName="Phone1" />
			<dx:TreeListDataColumn FieldName="Phone2" />
		</Columns>
		<Settings GridLines="Both" />
		<SettingsBehavior AllowEllipsisInText="True" AutoExpandAllNodes="true"></SettingsBehavior>
	</dx:ASPxTreeList>
	<ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
</asp:Content>