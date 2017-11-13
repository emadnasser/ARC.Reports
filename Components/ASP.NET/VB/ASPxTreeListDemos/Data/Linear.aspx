<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Linear.aspx.vb" Inherits="Data_Linear" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxCheckBox ID="chkServiceColumns" runat="server" 
		AutoPostBack="True" Text="Show service columns" CssClass="OptionsBottomMargin"/>
	<dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False"
		DataSourceID="DepartmentsDataSource" Width="100%"
		KeyFieldName="ID" ParentFieldName="ParentID">
		<Columns>
			<dx:TreeListDataColumn FieldName="DepartmentName" Caption="Department" VisibleIndex="0" />            
			<dx:TreeListDataColumn FieldName="Budget" VisibleIndex="1" DisplayFormat="{0:C}" />
			<dx:TreeListDataColumn FieldName="Location" VisibleIndex="2" />
			<dx:TreeListDataColumn FieldName="Phone1" Caption="Phone" VisibleIndex="3" />
			<dx:TreeListDataColumn FieldName="ID" Visible="False" VisibleIndex="4">
				<CellStyle BackColor="#ffebb1" />
			</dx:TreeListDataColumn>
			<dx:TreeListDataColumn FieldName="ParentID" Visible="False" VisibleIndex="5">
				<CellStyle BackColor="#ffebb1" />
			</dx:TreeListDataColumn>            
		</Columns>
		<SettingsBehavior ExpandCollapseAction="NodeDblClick" />
	</dx:ASPxTreeList>
	<ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
</asp:Content>