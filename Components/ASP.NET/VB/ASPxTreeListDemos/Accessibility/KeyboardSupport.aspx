<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="KeyboardSupport.aspx.vb"
	Inherits="Accessibility_KeyboardSupport" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="margin-bottom: 16px">
		Press <b>CTRL</b> + <b>SHIFT</b> + <b>G</b> to move focus to the ASPxTreeList control
	</div>
	<dx:ASPxTreeList runat="server" ID="treeList" Width="100%" AutoGenerateColumns="False"
		DataSourceID="DepartmentsDataSource" KeyFieldName="ID" ParentFieldName="ParentID"
		KeyboardSupport="True" AccessKey="G">
		<columns>
			<dx:TreeListDataColumn FieldName="DepartmentName" Caption="Department" VisibleIndex="0" />            
			<dx:TreeListDataColumn FieldName="Location" VisibleIndex="1" />            
			<dx:TreeListDataColumn FieldName="Phone1" VisibleIndex="2" />
			<dx:TreeListDataColumn FieldName="Phone2" VisibleIndex="3" />
		</columns>
		<settingsselection enabled="true" />
	</dx:ASPxTreeList>
	<ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
</asp:Content>